---
title: Get Information About DML Triggers
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-dml
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 37574aac-181d-4aca-a2cc-8abff64237dc
---
# Get Information About DML Triggers
  This topic describes how to get information about DML triggers in [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] by using [!INCLUDE[ssManStudioFull](../../Token\Other/ssManStudioFull_md.md)] or [!INCLUDE[tsql](../../Token\Other/tsql_md.md)]. This information can include the types of triggers on a table, the name of a trigger, its owner and the date it was created or modified. If the trigger was not encrypted when it was created, you obtain the definition of the trigger. You can use the definition to help you understand how a trigger affects the table up on which it is defined. Also, you can find out the objects that a specific trigger uses. With this information, you can identify the objects that affect the trigger if they are changed or deleted in the database.  
  
 **In This Topic**  
  
-   **Before you begin:**  
  
     [Security](#Security)  
  
-   **To get information about DML triggers, using:**  
  
     [SQL Server Management Studio](#SSMSProcedure)  
  
     [Transact\-SQL](#TsqlProcedure)  
  
##  <a name="BeforeYouBegin"></a> Before You Begin  
  
###  <a name="Security"></a> Security  
  
####  <a name="Permissions"></a> Permissions  
 **sys.sql.modules**, **sys.object**, **sys.triggers**, **sys.events**, **sys.trigger\_events**  
 [!INCLUDE[ssCatViewPerm](../../Token\Other/ssCatViewPerm_md.md)] For more information, see [Metadata Visibility Configuration](../../Topics\TopicNameNotContainA/Metadata-Visibility-Configuration.md).  
  
 OBJECT\_DEFINITION, OBJECTPROPERTY, **sp\_helptext**  
 Requires membership in the **public** role. The definition of user objects is visible to the object owner or grantees that have any one of the following permissions: ALTER, CONTROL, TAKE OWNERSHIP, or VIEW DEFINITION. These permissions are implicitly held by members of the **db\_owner**, **db\_ddladmin**, and **db\_securityadmin** fixed database roles.  
  
 **sys.sql\_expression\_dependencies**  
 Requires VIEW DEFINITION permission on the database and SELECT permission on **sys.sql\_expression\_dependencies** for the database. By default, SELECT permission is granted only to members of the **db\_owner** fixed database role. When SELECT and VIEW DEFINITION permissions are granted to another user, the grantee can view all dependencies in the database.  
  
##  <a name="SSMSProcedure"></a> Using SQL Server Management Studio  
  
#### To view the definition of a DML trigger  
  
1.  In **Object Explorer**, connect to an instance of [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)] and then expand that instance.  
  
2.  Expand the database that you want, expand **Tables**, and then expand the table that contains the trigger for which you want to view the definition.  
  
3.  Expand **Triggers**, right\-click the trigger you want, and then click **Modify**. The definition of the DML trigger appears in the query window.  
  
#### To view the dependencies of a DML trigger  
  
1.  In **Object Explorer**, connect to an instance of [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)] and then expand that instance.  
  
2.  Expand the database that you want, expand **Tables**, and then expand the table that contains the trigger and its dependencies that you want to view.  
  
3.  Expand **Triggers**, right\-click the trigger you want, and then click **View Dependencies**.  
  
4.  In the **Object Dependencies** window, to view the objects that depend on the DML trigger, select **Objects that depend on \<DML trigger name\>**. The objects appear in the **Dependencies** area.  
  
     To view the objects on which the DML depends, select **Objects on which \<DML trigger name\> depends**. The objects appear in the **Dependencies** area. Expand each node to see all the objects.  
  
5.  To obtain information about an object that appears in the **Dependencies** area, click the object. In the **Selected object** field, information is provided in the **Name**, **Type**, and **Dependency type** boxes.  
  
6.  To close the **Object Dependencies** window, click **OK**.  
  
##  <a name="TsqlProcedure"></a> Using Transact\-SQL  
  
#### To view the definition of a DML trigger  
  
1.  Connect to the [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)].  
  
2.  From the Standard bar, click **New Query**.  
  
3.  Copy and paste one of the following examples into the query window and click **Execute**. Each example shows how you can view the definition of the `iuPerson` trigger.  
  
```tsql  
USE AdventureWorks2012;  
GO  
SELECT definition   
FROM sys.sql_modules  
WHERE object_id = OBJECT_ID(N'Person.iuPerson');   
GO  
```  
  
```tsql  
USE AdventureWorks2012;   
GO  
SELECT OBJECT_DEFINITION (OBJECT_ID(N'Person.iuPerson')) AS ObjectDefinition;   
GO  
  
```  
  
```tsql  
USE AdventureWorks2012;   
GO  
EXEC sp_helptext 'Person.iuPerson'  
GO  
  
```  
  
#### To view the dependencies of a DML trigger  
  
1.  Connect to the [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)].  
  
2.  From the Standard bar, click **New Query**.  
  
3.  Copy and paste one of the following examples into the query window and click **Execute**. Each example shows how you can view the dependencies of `iuPerson` trigger.  
  
```  
USE AdventureWorks2012;   
GO  
SELECT OBJECT_NAME(referencing_id) AS referencing_entity_name,   
    o.type_desc AS referencing_desciption,   
    COALESCE(COL_NAME(referencing_id, referencing_minor_id), '(n/a)') AS referencing_minor_id,   
    referencing_class_desc, referenced_class_desc,   
    referenced_server_name, referenced_database_name, referenced_schema_name,   
    referenced_entity_name,   
    COALESCE(COL_NAME(referenced_id, referenced_minor_id), '(n/a)') AS referenced_column_name,   
    is_caller_dependent, is_ambiguous  
FROM sys.sql_expression_dependencies AS sed  
INNER JOIN sys.objects AS o ON sed.referencing_id = o.object_id  
WHERE referencing_id = OBJECT_ID(N'Person.iuPerson');   
GO  
  
```  
  
#### To view information about DML triggers in the database  
  
1.  Connect to the [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)].  
  
2.  From the Standard bar, click **New Query**.  
  
3.  Copy and paste one of the following examples into the query window and click **Execute**. Each example shows how you can view information about DML triggers \(`TR`\) in the database.  
  
```  
USE AdventureWorks2012;   
GO  
SELECT  name, parent_id, create_date, modify_date, is_instead_of_trigger  
FROM sys.triggers  
WHERE type = 'TR';   
GO  
  
```  
  
```tsql  
USE AdventureWorks2012;   
GO  
SELECT  name, object_id, schema_id, parent_object_id, type_desc, create_date, modify_date, is_published  
FROM sys.objects  
WHERE type = 'TR';   
GO  
  
```  
  
```tsql  
USE AdventureWorks2012;   
GO  
SELECT OBJECTPROPERTY(OBJECT_ID(N'Person.iuPerson'), 'ExecIsInsteadOfTrigger');   
GO  
  
```  
  
#### To view information about events that fire a DML trigger  
  
1.  Connect to the [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)].  
  
2.  From the Standard bar, click **New Query**.  
  
3.  Copy and paste one of the following examples into the query window and click **Execute**. Each example shows how you can view the events that fire the `iuPerson` trigger.  
  
```tsql  
USE AdventureWorks2012;   
GO  
SELECT object_id, type, type_desc, is_trigger_event, event_group_type, event_group_type_desc   
FROM sys.events  
WHERE object_id = OBJECT_ID('Person.iuPerson');   
GO  
```  
  
```tsql  
USE AdventureWorks2012;   
GO   
SELECT object_id, type,is_first, is_last  
FROM sys.trigger_events  
WHERE object_id = OBJECT_ID('Person.iuPerson');   
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
 [OBJECTPROPERTY &#40;Transact-SQL&#41;](../Topic/OBJECTPROPERTY%20\(Transact-SQL\).md)   
 [OBJECT_DEFINITION &#40;Transact-SQL&#41;](../Topic/OBJECT_DEFINITION%20\(Transact-SQL\).md)  
  
  