---
title: Stretch 7 enable table
ms.custom: na
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: cfaab51d-769d-43cd-b01c-740f6b48d6e2
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pt-br
  - ru-ru
  - zh-cn
  - zh-tw
---
# Stretch 7 enable table
To configure a table for  Stretch Database, select **Stretch &#124; Enable** for a table in SQL Server Management Studio to open the **Enable Table for Stretch** wizard. You can also use Transact\-SQL to enable Stretch Database on a table.  
  
-   If you store historical data in a separate table, you can migrate the entire table.  
  
-   If your table contains both historical and current data, you can specify a filter predicate to select the rows to migrate. In CTP 3.1 through RC0, the option to specify a filter predicate is not available in the Enable Database for Stretch wizard. You have to use the ALTER TABLE statement to configure a table for Stretch Database with this option. For more info, see [ALTER TABLE \(Transact\-SQL\)](assetId:///f1745145-182d-4301-a334-18f799d361d1).  
  
 **Prerequisites**. If you select **Stretch &#124; Enable** for a table, and you have not yet enabled Stretch Database for the database, the wizard first configures the database for Stretch Database. Follow the steps in [Enable Database for Stretch Wizard](assetId:///855dd9fc-f80c-4dbc-bf46-55a9736bfe15) instead of the steps in this topic.  
  
 **Permissions**. Enabling Stretch Database on a database or a table requires db\_owner permissions. Enabling Stretch Database on  a table also requires ALTER permissions on the table.  
  
##  <a name="EnableWizardTable"></a> Use the wizard to enable Stretch Database on a table  
 **Launch the wizard**  
 1.  In SQL Server Management Studio, in Object Explorer, select the table on which you want to enable Stretch.  
  
2.  Right\-click and select **Stretch**, and then select **Enable** to launch the wizard.  
  
 **Introduction**  
 Review the purpose of the wizard and the prerequisites.  
  
 **Select database tables**  
 Confirm that the table you want to enable is displayed and selected.  
  
 In CTP 3.1 through RC0, you can only migrate an entire table by using the wizard. If you want to specify  a predicate to select rows to migrate from a table that contains both historical and current data, run the ALTER TABLE statement to specify a predicate after you exit the wizard, or exit the wizard and run the ALTER TABLE statement, as described later in this topic.  
  
 **Summary**  
 Review the values that you entered and the options that you selected in the wizard. Then select **Finish** to enable Stretch.  
  
 **Results**  
 Review the results.  
  
##  <a name="EnableTSQLTable"></a> Use Transact\-SQL to enable Stretch Database on a table  
 To configure a table for Stretch Database, run the ALTER TABLE command.  
  
1.  Optionally, use the `FILTER_PREDICATE = <predicate>` clause to specify  a predicate to select rows to migrate if the table contains both historical and current data. The predicate must call an inline table\-valued function. For more info, see [Write an Inline Table\-Valued Function to Select Rows \(Stretch Database\)](assetId:///090890ee-7620-4a08-8e15-d2fbc71dd12f). If you don't specify a filter predicate, the entire table is migrated.  
  
    > [!IMPORTANT]  
    >  If you provide a filter predicate that performs poorly, data migration also performs poorly. Stretch Database applies the filter predicate to the table by using the CROSS APPLY operator.  
  
     In CTP 3.1 through RC0, this option is not available in the Enable Database for Stretch wizard. You have to use the ALTER TABLE statement to configure a table for Stretch Database with this option. For more info, see [ALTER TABLE \(Transact\-SQL\)](assetId:///f1745145-182d-4301-a334-18f799d361d1).  
  
2.  Specify `MIGRATION_STATE = OUTBOUND` to start data migration immediately or  `MIGRATION_STATE = PAUSED` to postpone the start of data migration.  
  
 Here's an example that migrates the entire table and begins data migration immediately.  
  
```tsql  
ALTER TABLE <table name>  
    SET ( REMOTE_DATA_ARCHIVE = ON ( MIGRATION_STATE = OUTBOUND ) ) ;  
GO;  
```  
  
 Here's an example that migrates only the rows identified by the `dbo.fn_stretchpredicate` inline table\-valued function and postpones data migration. For more info about the filter predicate, see [Write an Inline Table\-Valued Function to Select Rows \(Stretch Database\)](assetId:///090890ee-7620-4a08-8e15-d2fbc71dd12f).  
  
```tsql  
ALTER TABLE <table name>  
    SET ( REMOTE_DATA_ARCHIVE = ON (  
        FILTER_PREDICATE = dbo.fn_stretchpredicate(date),  
        MIGRATION_STATE = PAUSED ) )  
  
```  
  
## See Also  
 [ALTER TABLE \(Transact\-SQL\)](assetId:///f1745145-182d-4301-a334-18f799d361d1)