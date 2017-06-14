@ECHO OFF

ECHO Starting Job

ECHO Removing *_output.txt files
DEL "*_output.txt"

REM ------------------------------------------------------------------------
ECHO Step #1 - Backup existing Recipients table

sqlite3 "../FoodPantry.db" ".read 1_backup_recipients_table.txt"

ECHO Verify output file

IF NOT EXIST 1_backup_recipients_table.txt (
	ECHO ERROR! Output file 1_backup_recipients_table.txt could not be verified - exiting
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

sqlite3 NewFoodPantry.db ".read 2_extract_new_recipients_table.txt"

ECHO Verify output file

IF NOT EXIST 2_extract_new_recipients_table_output.txt (
	ECHO ERROR! Output file could not be verified - exiting
	EXIT /B
)

ECHO Step #2 Complete
REM ------------------------------------------------------------------------


REM ------------------------------------------------------------------------
ECHO Step #3 - Dump Recipients schema

sqlite3 "../FoodPantry.db" ".read 3_dump_recipients_schema.txt"

ECHO Verify output file

IF NOT EXIST 3_dump_recipients_schema_output.txt (
	ECHO ERROR! Output file could not be verified - exiting
	EXIT /B
)

ECHO Step #3 Complete
REM ------------------------------------------------------------------------


REM ------------------------------------------------------------------------
ECHO Step #4 - Drop Recipients table

sqlite3 "../FoodPantry.db" ".read 4_drop_recipients_table.txt"

ECHO Step #4 Complete
REM ------------------------------------------------------------------------


REM ------------------------------------------------------------------------
ECHO Step #5 - Create Recipients table

sqlite3 "../FoodPantry.db" ".read 5_create_recipients_table.txt"

ECHO Step #5 Complete
REM ------------------------------------------------------------------------


REM ------------------------------------------------------------------------
ECHO Step #6 - Import New Recipients table

sqlite3 "../FoodPantry.db" ".read 6_import_new_recipients_table.txt"

ECHO Step #6 Complete
REM ------------------------------------------------------------------------



ECHO Job Complete