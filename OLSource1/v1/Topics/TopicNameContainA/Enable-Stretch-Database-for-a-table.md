---
title: Enable Stretch Database for a table
ms.custom: 
  - SQL2016_New_Updated
ms.prod: sql-server-2016
ms.reviewer: na
ms.service: sql-server-stretch-database
ms.suite: na
ms.technology: 
  - dbe-stretch
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: de4ac0c5-46ef-4593-a11e-9dd9bcd3ccdc
---
# Enable Stretch Database for a table
  To configure a table for  Stretch Database, select **Stretch | Enable** for a table in SQL Server Management Studio to open the **Enable Table for Stretch** wizard. You can also use Transact\-SQL to enable Stretch Database on an existing table, or to create a new table with Stretch Database enabled.  
  
-   If you store historical data in a separate table, you can migrate the entire table.  
  
-   If your table contains both historical and current data, you can specify a filter predicate to select the rows to migrate.  
  
 **Prerequisites**. If you select **Stretch | Enable** for a table, and you have not yet enabled Stretch Database for the database, the wizard first configures the database for Stretch Database. Follow the steps in [Get started by running the Enable Database for Stretch Wizard](../../Topics\TopicNameNotContainA/Get-started-by-running-the-Enable-Database-for-Stretch-Wizard.md) instead of the steps in this topic.  
  
 **Permissions**. Enabling Stretch Database on a database or a table requires db\_owner permissions. Enabling Stretch Database on  a table also requires ALTER permissions on the table.  
  
##  <a name="EnableWizardTable"></a> Use the wizard to enable Stretch Database on a table  
 **Launch the wizard**  
 1.  In SQL Server Management Studio, in Object Explorer, select the table on which you want to enable Stretch.  
  
2.  Right\-click and select **Stretch**, and then select **Enable** to launch the wizard.  
  
 **Introduction**  
 Review the purpose of the wizard and the prerequisites.  
  
 **Select database tables**  
 Confirm that the table you want to enable is displayed and selected.  
  
 You can migrate an entire table or you can specify a simple date\-based filter predicate in the wizard. If you want to use a different type of filter predicate to select rows to migrate, do one of the following things.  
  
-   Exit the wizard and run the ALTER TABLE statement to enable Stretch for the table and to specify a predicate.  
  
-   Run the ALTER TABLE statement to specify a predicate after you exit the wizard. For the required steps, see [Add a filter predicate after running the Wizard](Select%20rows%20to%20migrate%20by%20using%20a%20filter%20predicate%20\(Stretch%20Database\).md\#addafterwiz).  
  
 The ALTER TABLE syntax is described later in this topic.  
  
 **Summary**  
 Review the values that you entered and the options that you selected in the wizard. Then select **Finish** to enable Stretch.  
  
 **Results**  
 Review the results.  
  
##  <a name="EnableTSQLTable"></a> Use Transact\-SQL to enable Stretch Database on a table  
 You can enable Stretch Database for an existing table or create a new table with Stretch Database enabled by using Transact\-SQL.  
  
### Options  
 Use the following options when you run CREATE TABLE or ALTER TABLE to enable Stretch Database on a table.  
  
-   Optionally, use the `FILTER_PREDICATE = <predicate>` clause to specify  a predicate to select rows to migrate if the table contains both historical and current data. The predicate must call an inline table\-valued function. For more info, see [Select rows to migrate by using a filter predicate](Select%20rows%20to%20migrate%20by%20using%20a%20filter%20predicate%20\(Stretch%20Database\).md). If you don't specify a filter predicate, the entire table is migrated.  
  
    > [!IMPORTANT]  
    >  If you provide a filter predicate that performs poorly, data migration also performs poorly. Stretch Database applies the filter predicate to the table by using the CROSS APPLY operator.  
  
-   Specify `MIGRATION_STATE = OUTBOUND` to start data migration immediately or  `MIGRATION_STATE = PAUSED` to postpone the start of data migration.  
  
### Enable Stretch Database for an existing table  
 To configure an existing table for Stretch Database, run the ALTER TABLE command.  
  
 Here's an example that migrates the entire table and begins data migration immediately.  
  
```tsql  
ALTER TABLE <table name>  
    SET ( REMOTE_DATA_ARCHIVE = ON ( MIGRATION_STATE = OUTBOUND ) ) ;  
  
```  
  
 Here's an example that migrates only the rows identified by the `dbo.fn_stretchpredicate` inline table\-valued function and postpones data migration. For more info about the filter predicate, see [Select rows to migrate by using a filter predicate](Select%20rows%20to%20migrate%20by%20using%20a%20filter%20predicate%20\(Stretch%20Database\).md).  
  
```tsql  
ALTER TABLE <table name>  
    SET ( REMOTE_DATA_ARCHIVE = ON (  
        FILTER_PREDICATE = dbo.fn_stretchpredicate(date),  
        MIGRATION_STATE = PAUSED ) );  
  
```  
  
 For more info, see [ALTER TABLE &#40;Transact-SQL&#41;](../Topic/ALTER%20TABLE%20\(Transact-SQL\).md).  
  
### Create a new table with Stretch Database enabled  
 To create a new table with Stretch Database enabled, run the CREATE TABLE command.  
  
 Here's an example that migrates the entire table and begins data migration immediately.  
  
```tsql  
CREATE TABLE <table name> ...  
    WITH ( REMOTE_DATA_ARCHIVE = ON ( MIGRATION_STATE = OUTBOUND ) ) ;  
  
```  
  
 Here's an example that migrates only the rows identified by the `dbo.fn_stretchpredicate` inline table\-valued function and postpones data migration. For more info about the filter predicate, see [Select rows to migrate by using a filter predicate](Select%20rows%20to%20migrate%20by%20using%20a%20filter%20predicate%20\(Stretch%20Database\).md).  
  
```tsql  
CREATE TABLE <table name> ...  
    WITH ( REMOTE_DATA_ARCHIVE = ON (  
        FILTER_PREDICATE = dbo.fn_stretchpredicate(date),  
        MIGRATION_STATE = PAUSED ) );  
  
```  
  
 For more info, see [CREATE TABLE &#40;Transact-SQL&#41;](../Topic/CREATE%20TABLE%20\(Transact-SQL\).md).  
  
## See Also  
 [ALTER TABLE &#40;Transact-SQL&#41;](../Topic/ALTER%20TABLE%20\(Transact-SQL\).md)   
 [CREATE TABLE &#40;Transact-SQL&#41;](../Topic/CREATE%20TABLE%20\(Transact-SQL\).md)  
  
  