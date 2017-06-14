@ECHO OFF

ECHO Starting Job

ECHO Removing *_output.txt files
DEL *_output.txt

SET step1=1_backup_recipients_table
SET step2=2_extract_new_recipients_table
SET step3=3_dump_recipients_schema
SET step4=4_drop_recipients_table
SET step5=5_create_recipients_table
SET step6=6_import_new_recipients_table

REM ------------------------------------------------------------------------
ECHO Step #1 - Backup existing Recipients table

sqlite3 "../FoodPantry.db" ".read %step1%.txt"

ECHO Verify output file

IF NOT EXIST %step1%_output.txt (
	ECHO ERROR! Output file %step1%_output.txt could not be verified - exiting
	EXIT /B
)

ECHO Step #1 Complete
REM ------------------------------------------------------------------------


REM ------------------------------------------------------------------------
ECHO Step #2 - Extract new Recipients table

IF NOT EXIST NewFoodPantry.db (
	ECHO ERROR! NewFoodPantry.db file could not be found - exiting
	EXIT /B
)

sqlite3 NewFoodPantry.db ".read %step2%.txt"

ECHO Verify output file

IF NOT EXIST %step2%_output.txt (
	ECHO ERROR! Output file %step2%_output.txt could not be found - exiting
	EXIT /B
)

ECHO Step #2 Complete
REM ------------------------------------------------------------------------


REM ------------------------------------------------------------------------
ECHO Step #3 - Dump Recipients schema

sqlite3 "../FoodPantry.db" ".read %step3%.txt"

ECHO Verify output file

IF NOT EXIST %step3%_output.txt (
	ECHO ERROR! Output file %step3%_output.txt could not be found - exiting
	EXIT /B
)

ECHO Step #3 Complete
REM ------------------------------------------------------------------------


REM ------------------------------------------------------------------------
ECHO Step #4 - Drop Recipients table

sqlite3 "../FoodPantry.db" ".read %step4%.txt"

ECHO Step #4 Complete
REM ------------------------------------------------------------------------


REM ------------------------------------------------------------------------
ECHO Step #5 - Create Recipients table

sqlite3 "../FoodPantry.db" ".read %step5%.txt"

ECHO Step #5 Complete
REM ------------------------------------------------------------------------


REM ------------------------------------------------------------------------
ECHO Step #6 - Import New Recipients table

sqlite3 "../FoodPantry.db" ".read %step6%.txt"

ECHO Step #6 Complete
REM ------------------------------------------------------------------------


ECHO Job Complete