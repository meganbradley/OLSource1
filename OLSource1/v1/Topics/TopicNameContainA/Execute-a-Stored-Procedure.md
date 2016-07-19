---
title: Execute a Stored Procedure
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-stored-Procs
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: a0b1337d-2059-4872-8c62-3f967d8b170f
manager: jhubbard
---
# Execute a Stored Procedure
This topic describes how to execute a stored procedure in [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)] by using [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)] or [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)].  
  
 There are two different ways to execute a stored procedure. The first and most common approach is for an application or user to call the procedure. The second approach is to set the procedure to run automatically when an instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] starts. When a procedure is called by an application or user, the [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)] EXECUTE or EXEC keyword is explicitly stated in the call. Alternatively, the procedure can be called and executed without the keyword if the procedure is the first statement in the [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)] batch.  
  
 **In This Topic**  
  
-   **Before you begin:**  
  
     [Limitations and Restrictions](#Restrictions)  
  
     [Recommendations](#Recommendations)  
  
     [Security](#Security)  
  
-   **To execute a stored procedure, using:**  
  
     [SQL Server Management Studio](#SSMSProcedure)  
  
     [Transact-SQL](#TsqlProcedure)  
  
##  <a name="BeforeYouBegin"></a> Before You Begin  
  
###  <a name="Restrictions"></a> Limitations and Restrictions  
  
-   The calling database collation is used when matching system procedure names. Therefore, always use the exact case of system procedure names in procedure calls. For example, this code will fail if it is executed in the context of a database that has a case-sensitive collation:  
  
    ```tsql  
    EXEC SP_heLP; -- Will fail to resolve because SP_heLP does not equal sp_help  
    ```  
  
     To display the exact system procedure names, query the [sys.system_objects](assetId:///069e9045-97f2-4463-8e8f-c73855f3ea0a) and [sys.system_parameters](assetId:///0d135c5f-68b5-4009-a0da-35e6abfee0ff) catalog views.  
  
-   If a user-defined procedure has the same name as a system procedure, the user-defined procedure might not ever execute.  
  
###  <a name="Recommendations"></a> Recommendations  
  
-   Executing System Stored Procedures  
  
     System procedures begin with the prefix **sp_**. Because they logically appear in all user- and system- defined databases, they can be executed from any database without having to fully quality the procedure name. However, we recommend schema-qualifying all system procedure names with the **sys** schema name to prevent name conflicts. The following example demonstrates the recommended method of calling a system procedure.  
  
    ```tsql  
    EXEC sys.sp_who;  
    ```  
  
-   Executing User-defined Stored Procedures  
  
     When executing a user-defined procedure, we recommend qualifying the procedure name with the schema name. This practice gives a small performance boost because the [!INCLUDE[ssDE](../../Topics/TopicNameContainA/includes/ssDE_md.md)] does not have to search multiple schemas. It also prevents executing the wrong procedure if a database has procedures with the same name in multiple schemas.  
  
     The following example demonstrates the recommended method to execute a user-defined procedure. Notice that the procedure accepts one input parameter. For information about specifying input and output parameters, see [Specify Parameters](../../Topics/TopicNameNotContainA/Specify-Parameters.md).  
  
    ```tsql  
    USE AdventureWorks2012;  
    GO  
    EXEC dbo.uspGetEmployeeManagers @BusinessEntityID = 50;  
    ```  
  
     -Or-  
  
    ```tsql  
    EXEC AdventureWorks2012.dbo.uspGetEmployeeManagers 50;  
    GO  
    ```  
  
     If a nonqualified user-defined procedure is specified, the [!INCLUDE[ssDE](../../Topics/TopicNameContainA/includes/ssDE_md.md)] searches for the procedure in the following order:  
  
    1.  The **sys** schema of the current database.  
  
    2.  The caller's default schema if it is executed in a batch or in dynamic SQL. Or, if the nonqualified procedure name appears inside the body of another procedure definition, the schema that contains this other procedure is searched next.  
  
    3.  The **dbo** schema in the current database.  
  
-   Executing Stored Procedures Automatically  
  
     Procedures marked for automatic execution are executed every time [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] starts and the **master** database is recovered during that startup process. Setting up procedures to execute automatically can be useful for performing database maintenance operations or for having procedures run continuously as background processes. Another use for automatic execution is to have the procedure perform system or maintenance tasks in **tempdb**, such as creating a global temporary table. This makes sure that such a temporary table will always exist when **tempdb** is re-created during [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] startup.  
  
     A procedure that is automatically executed operates with the same permissions as members of the **sysadmin** fixed server role. Any error messages generated by the procedure are written to the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] error log.  
  
     There is no limit to the number of startup procedures you can have, but be aware that each consumes one worker thread while executing. If you must execute multiple procedures at startup but do not need to execute them in parallel, make one procedure the startup procedure and have that procedure call the other procedures. This uses only one worker thread.  
  
    > [!TIP]  
    >  Do not return any result sets from a procedure that is executed automatically. Because the procedure is being executed by [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] instead of an application or user, there is nowhere for the result sets to go.  
  
-   Setting, Clearing, and Controlling Automatic Execution  
  
     Only the system administrator (**sa**) can mark a procedure to execute automatically. In addition, the procedure must be in the **master** database, owned by **sa**, and cannot have input or output parameters.  
  
     Use [sp_procoption](assetId:///6f0221bd-70b4-4b04-b15d-722235aceb3c) to:  
  
    1.  Designate an existing procedure as a startup procedure.  
  
    2.  Stop a procedure from executing at [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] startup.  
  
###  <a name="Security"></a> Security  
 For more information, see [EXECUTE AS (Transact-SQL)](assetId:///613b8271-7f7d-4378-b7a2-5a7698551dbd) and [EXECUTE AS Clause (Transact-SQL)](assetId:///bd517aa3-f06e-4356-87d8-70de5df4494a).  
  
####  <a name="Permissions"></a> Permissions  
 For more information, see the "Permissions" section in [EXECUTE (Transact-SQL)](assetId:///bc806b71-cc55-470a-913e-c5f761d5c4b7).  
  
##  <a name="SSMSProcedure"></a> Using SQL Server Management Studio  
  
#### To execute a stored procedure  
  
1.  In **Object Explorer**, connect to an instance of the [!INCLUDE[ssDEnoversion](../../Topics/TopicNameContainA/includes/ssDEnoversion_md.md)], expand that instance, and then expand **Databases**.  
  
2.  Expand the database that you want, expand **Programmability**, and then expand **Stored Procedures**.  
  
3.  Right-click the user-defined stored procedure that you want and click **Execute Stored Procedure**.  
  
4.  In the **Execute Procedure** dialog box, specify a value for each parameter and whether it should pass a null value.  
  
     **Parameter**  
     Indicates the name of the parameter.  
  
     **Data Type**  
     Indicates the data type of the parameter.  
  
     **Output Parameter**  
     Indicates if this is an output parameter.  
  
     **Pass Null Value**  
     Pass a NULL as the value of the parameter.  
  
     **Value**  
     Type the value for the parameter when calling the procedure.  
  
5.  To execute the stored procedure, click **OK**.  
  
##  <a name="TsqlProcedure"></a> Using Transact-SQL  
  
#### To execute a stored procedure  
  
1.  Connect to the [!INCLUDE[ssDE](../../Topics/TopicNameContainA/includes/ssDE_md.md)].  
  
2.  From the Standard bar, click **New Query**.  
  
3.  Copy and paste the following example into the query window and click **Execute**. This example shows how to execute a stored procedure that expects one parameter. The example executes the `uspGetEmployeeManagers` stored procedure with the value  `6` specified as the `@EmployeeID` parameter.  
  
```tsql  
USE AdventureWorks2012;  
GO  
EXEC dbo.uspGetEmployeeManagers 6;  
GO  
```  
  
#### To set or clear a procedure for executing automatically  
  
1.  Connect to the [!INCLUDE[ssDE](../../Topics/TopicNameContainA/includes/ssDE_md.md)].  
  
2.  From the Standard bar, click **New Query**.  
  
3.  Copy and paste the following example into the query window and click **Execute**. This example shows how to use [sp_procoption](assetId:///6f0221bd-70b4-4b04-b15d-722235aceb3c) to set a procedure for automatic execution.  
  
```tsql  
USE AdventureWorks2012;  
GO  
EXEC sp_procoption @ProcName = '<procedure name>'   
    , @OptionName = ] 'startup'   
    , @OptionValue = 'on';  
```  
  
#### To stop a procedure from executing automatically  
  
1.  Connect to the [!INCLUDE[ssDE](../../Topics/TopicNameContainA/includes/ssDE_md.md)].  
  
2.  From the Standard bar, click **New Query**.  
  
3.  Copy and paste the following example into the query window and click **Execute**. This example shows how to use [sp_procoption](assetId:///6f0221bd-70b4-4b04-b15d-722235aceb3c) to stop a procedure from executing automatically.  
  
```tsql  
USE AdventureWorks2012;  
GO  
EXEC sp_procoption @ProcName = '<procedure name>'   
    , @OptionValue = 'off';  
```  
  
###  <a name="TsqlExample"></a> Example (Transact-SQL)  
  
## See Also  
 [Specify Parameters](../../Topics/TopicNameNotContainA/Specify-Parameters.md)   
 [Configure the scan for startup procs Server Configuration Option](../../Topics/TopicNameNotContainA/Configure-the-scan-for-startup-procs-Server-Configuration-Option.md)   
 [EXECUTE (Transact-SQL)](assetId:///bc806b71-cc55-470a-913e-c5f761d5c4b7)   
 [CREATE PROCEDURE (Transact-SQL)](assetId:///afe3d86d-c9ab-44e4-b74d-4e3dbd9cc58c)   
 [Stored Procedures (Database Engine)](../../Topics/TopicNameNotContainA/Stored-Procedures--Database-Engine-.md)