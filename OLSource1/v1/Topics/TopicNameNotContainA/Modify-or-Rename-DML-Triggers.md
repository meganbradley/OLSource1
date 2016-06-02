---
title: Modify or Rename DML Triggers
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-dml
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: c7317eec-c0e9-479e-a4a7-83b6b6c58d59
---
# Modify or Rename DML Triggers
  This topic describes how to modify or rename a DML trigger in [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] by using [!INCLUDE[ssManStudioFull](../../Token\Other/ssManStudioFull_md.md)] or [!INCLUDE[tsql](../../Token\Other/tsql_md.md)].  
  
 **In This Topic**  
  
-   **Before you begin:**  
  
     [Limitations and Restrictions](#Restrictions)  
  
     [Recommendations](#Recommendations)  
  
     [Security](#Security)  
  
-   **To modify or rename a DML trigger, using:**  
  
     [SQL Server Management Studio](#SSMSProcedure)  
  
     [Transact\-SQL](#TsqlProcedure)  
  
##  <a name="BeforeYouBegin"></a> Before You Begin  
  
###  <a name="Restrictions"></a> Limitations and Restrictions  
  
-   When you rename a trigger, the trigger must be in the current database, and the new name must follow the rules for [identifiers](../../Topics\TopicNameNotContainA/Database-Identifiers.md).  
  
###  <a name="Recommendations"></a> Recommendations  
  
-   We recommend you do not use the [sp\_rename](../Topic/sp_rename%20\(Transact-SQL\).md) stored procedure to rename a trigger. Changing any part of an object name can break scripts and stored procedures. Renaming a trigger does not change the name of the corresponding object name in the definition column of the [sys.sql\_modules](../Topic/sys.sql_modules%20\(Transact-SQL\).md) catalog view. We recommend that you drop and and re\-create the trigger instead.  
  
-   If you change the name of an object referenced by a DML trigger, you must modify the trigger so that its text reflects the new name. Therefore, before you rename an object, display the dependencies of the object first to determine whether any triggers are affected by the proposed change.  
  
-   A DML trigger can also be modified to encrypt its definition.  
  
-   To view the dependencies of a trigger, you can use [!INCLUDE[ssManStudioFull](../../Token\Other/ssManStudioFull_md.md)] or the following function and catalog views:  
  
    -   [sys.sql_expression_dependencies &#40;Transact-SQL&#41;](../Topic/sys.sql_expression_dependencies%20\(Transact-SQL\).md)  
  
    -   [sys.dm_sql_referenced_entities &#40;Transact-SQL&#41;](../Topic/sys.dm_sql_referenced_entities%20\(Transact-SQL\).md)  
  
    -   [sys.dm_sql_referencing_entities &#40;Transact-SQL&#41;](../Topic/sys.dm_sql_referencing_entities%20\(Transact-SQL\).md)  
  
###  <a name="Security"></a> Security  
  
####  <a name="Permissions"></a> Permissions  
 To alter a DML trigger requires ALTER permission on the table or view on which the trigger is defined.  
  
##  <a name="SSMSProcedure"></a> Using SQL Server Management Studio  
  
#### To modify a DML trigger  
  
1.  In **Object Explorer**, connect to an instance of [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)] and then expand that instance.  
  
2.  Expand the database that you want, expand **Tables**, and then expand the table that contains the trigger that you want to modify.  
  
3.  Expand **Triggers**, right\-click the trigger to modify, and then click **Modify**.  
  
4.  Modify the trigger, and then click **Execute**.  
  
#### To rename a DML trigger  
  
1.  [Delete the trigger](../../Topics\TopicNameNotContainA/Delete-or-Disable-DML-Triggers.md) that you want to rename.  
  
2.  [Re\-create the trigger](../../Topics\TopicNameNotContainA/Create-DML-Triggers.md), specifying the new name.  
  
##  <a name="TsqlProcedure"></a> Using Transact\-SQL  
  
#### To modify a trigger using ALTER TRIGGER  
  
1.  Connect to the [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)].  
  
2.  From the Standard bar, click **New Query**.  
  
3.  Copy and paste the following examples into the query. Execute the first example to create a DML trigger that prints a user\-defined message to the client when a user tries to add or change data in the `SalesPersonQuotaHistory` table. Execute the [ALTER TRIGGER](../Topic/ALTER%20TRIGGER%20\(Transact-SQL\).md) statement to modify the trigger to fire only on `INSERT` activities. This trigger is helpful because it reminds the user that updates or inserts rows into this table to also notify the `Compensation` department.  
  
```tsql  
USE AdventureWorks2012;  
GO  
IF OBJECT_ID(N'Sales.bonus_reminder', N'TR') IS NOT NULL  
    DROP TRIGGER Sales.bonus_reminder;  
GO  
CREATE TRIGGER Sales.bonus_reminder  
ON Sales.SalesPersonQuotaHistory  
WITH ENCRYPTION  
AFTER INSERT, UPDATE   
AS RAISERROR ('Notify Compensation', 16, 10);  
GO  
  
```  
  
```tsql  
USE AdventureWorks2012;  
GO  
ALTER TRIGGER Sales.bonus_reminder  
ON Sales.SalesPersonQuotaHistory  
AFTER INSERT  
AS RAISERROR ('Notify Compensation', 16, 10);  
GO  
  
```  
  
#### To rename a trigger using DROP TRIGGER and ALTER TRIGGER  
  
1.  Connect to the [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)].  
  
2.  From the Standard bar, click **New Query**.  
  
3.  Copy and paste the following example into the query window and click **Execute**. This example use the [DROP TRIGGER](../Topic/DROP%20TRIGGER%20\(Transact-SQL\).md) and [ALTER TRIGGER](../Topic/ALTER%20TRIGGER%20\(Transact-SQL\).md) statements to rename the `Sales.bonus_reminder` trigger to `Sales.bonus_reminder_2`.  
  
```tsql  
USE AdventureWorks2012;  
GO  
IF OBJECT_ID(N'Sales.bonus_reminder', N'TR') IS NOT NULL  
    DROP TRIGGER Sales.bonus_reminder;  
GO  
CREATE TRIGGER Sales.bonus_reminder_2  
ON Sales.SalesPersonQuotaHistory  
WITH ENCRYPTION  
AFTER INSERT, UPDATE   
AS RAISERROR ('Notify Compensation', 16, 10);  
GO  
  
```  
  
## See Also  
 [CREATE TRIGGER &#40;Transact-SQL&#41;](../Topic/CREATE%20TRIGGER%20\(Transact-SQL\).md)   
 [DROP TRIGGER &#40;Transact-SQL&#41;](../Topic/DROP%20TRIGGER%20\(Transact-SQL\).md)   
 [ENABLE TRIGGER &#40;Transact-SQL&#41;](../Topic/ENABLE%20TRIGGER%20\(Transact-SQL\).md)   
 [DISABLE TRIGGER &#40;Transact-SQL&#41;](../Topic/DISABLE%20TRIGGER%20\(Transact-SQL\).md)   
 [EVENTDATA &#40;Transact-SQL&#41;](../Topic/EVENTDATA%20\(Transact-SQL\).md)   
 [sp_rename &#40;Transact-SQL&#41;](../Topic/sp_rename%20\(Transact-SQL\).md)   
 [ALTER TRIGGER &#40;Transact-SQL&#41;](../Topic/ALTER%20TRIGGER%20\(Transact-SQL\).md)   
 [Get Information About DML Triggers](../../Topics\TopicNameNotContainA/Get-Information-About-DML-Triggers.md)   
 [sp_help &#40;Transact-SQL&#41;](../Topic/sp_help%20\(Transact-SQL\).md)   
 [sp_helptrigger &#40;Transact-SQL&#41;](../Topic/sp_helptrigger%20\(Transact-SQL\).md)   
 [sys.triggers &#40;Transact-SQL&#41;](../Topic/sys.triggers%20\(Transact-SQL\).md)   
 [sys.trigger_events &#40;Transact-SQL&#41;](../Topic/sys.trigger_events%20\(Transact-SQL\).md)   
 [sys.sql_modules &#40;Transact-SQL&#41;](../Topic/sys.sql_modules%20\(Transact-SQL\).md)   
 [sys.assembly_modules &#40;Transact-SQL&#41;](../Topic/sys.assembly_modules%20\(Transact-SQL\).md)   
 [sys.server_triggers &#40;Transact-SQL&#41;](../Topic/sys.server_triggers%20\(Transact-SQL\).md)   
 [sys.server_trigger_events &#40;Transact-SQL&#41;](../Topic/sys.server_trigger_events%20\(Transact-SQL\).md)   
 [sys.server_sql_modules &#40;Transact-SQL&#41;](../Topic/sys.server_sql_modules%20\(Transact-SQL\).md)   
 [sys.server_assembly_modules &#40;Transact-SQL&#41;](../Topic/sys.server_assembly_modules%20\(Transact-SQL\).md)  
  
  