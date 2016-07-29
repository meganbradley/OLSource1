---
title: "Recompile a Stored Procedure"
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-stored-Procs
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b90deb27-0099-4fe7-ba60-726af78f7c18
caps.latest.revision: 38
manager: jhubbard
---
# Recompile a Stored Procedure
This topic describes how to recompile a stored procedure in [!INCLUDE[ssCurrent](../../Topics/TopicNameContainA/includes/ssCurrent_md.md)] by using [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)]. There are three ways to do this: **WITH RECOMPILE** option in the procedure definition or when the procedure is called, the **RECOMPILE** query hint on individual statements, or by using the **sp_recompile** system stored procedure. This topic describes using the WITH RECOMPILE option when creating a procedure definition and executing an existing procedure. It also describes using the sp_recompile system stored procedure to recompile an existing procedure.  
  
 **In This Topic**  
  
-   **Before you begin:**  
  
     [Recommendations](#Recommendations)  
  
     [Security](#Security)  
  
-   **To recompile a stored procedure, using:**  
  
     [Transact-SQL](#TsqlProcedure)  
  
##  <a name="BeforeYouBegin"></a> Before You Begin  
  
###  <a name="Recommendations"></a> Recommendations  
  
-   When a procedure is compiled for the first time or recompiled, the procedure’s query plan is optimized for the current state of the database and its objects. If a database undergoes significant changes to its data or structure, recompiling a procedure updates and optimizes the procedure’s query plan for those changes. This can improve the procedure’s processing performance.  
  
-   There are times when procedure recompilation must be forced and other times when it occurs automatically. Automatic recompiling occurs whenever [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] is restarted. It also occurs if an underlying table referenced by the procedure has undergone physical design changes.  
  
-   Another reason to force a procedure to recompile is to counteract the "parameter sniffing" behavior of procedure compilation. When [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] executes procedures, any parameter values that are used by the procedure when it compiles are included as part of generating the query plan. If these values represent the typical ones with which the procedure is subsequently called, then the procedure benefits from the query plan every time that it compiles and executes. If parameter values on the procedure are frequently atypical, forcing a recompile of the procedure and a new plan based on different parameter values can improve performance.  
  
-   [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] features statement-level recompilation of procedures. When [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] recompiles stored procedures, only the statement that caused the recompilation is compiled, instead of the complete procedure.  
  
-   If certain queries in a procedure regularly use atypical or temporary values, procedure performance can be improved by using the RECOMPILE query hint inside those queries. Since only the queries using the query hint will be recompiled instead of the complete procedure, [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)]'s statement-level recompilation behavior is mimicked. But in addition to using the procedure's current parameter values, the RECOMPILE query hint also uses the values of any local variables inside the stored procedure when you compile the statement. For more information, see [Query Hint (Transact-SQL)](assetId:///66fb1520-dcdf-4aab-9ff1-7de8f79e5b2d).  
  
###  <a name="Security"></a> Security  
  
####  <a name="Permissions"></a> Permissions  
 **WITH RECOMPILE** Option  
 If this option is used when the procedure definition is created, it requires CREATE PROCEDURE permission in the database and ALTER permission on the schema in which the procedure is being created.  
  
 If this option is used in an EXECUTE statement, it requires EXECUTE permissions on the procedure. Permissions are not required on the EXECUTE statement itself but execute permissions are required on the procedure referenced in the EXECUTE statement. For more information, see [EXECUTE (Transact-SQL)](assetId:///bc806b71-cc55-470a-913e-c5f761d5c4b7).  
  
 **RECOMPILE** Query Hint  
 This feature is used when the procedure is created and the hint is included in [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)] statements in the procedure. Therefore, it requires CREATE PROCEDURE permission in the database and ALTER permission on the schema in which the procedure is being created.  
  
 **sp_recompile** System Stored Procedure  
 Requires ALTER permission on the specified procedure.  
  
##  <a name="TsqlProcedure"></a> Using Transact-SQL  
  
#### To recompile a stored procedure by using the WITH RECOMPILE option  
  
1.  Connect to the [!INCLUDE[ssDE](../../Topics/TopicNameContainA/includes/ssDE_md.md)].  
  
2.  From the Standard bar, click **New Query**.  
  
3.  Copy and paste the following example into the query window and click **Execute**. This example creates the procedure definition.  
  
```  
USE AdventureWorks2012;  
GO  
IF OBJECT_ID ( 'dbo.uspProductByVendor', 'P' ) IS NOT NULL   
    DROP PROCEDURE dbo.uspProductByVendor;  
GO  
CREATE PROCEDURE dbo.uspProductByVendor @Name varchar(30) = '%'  
WITH RECOMPILE  
AS  
    SET NOCOUNT ON;  
    SELECT v.Name AS 'Vendor name', p.Name AS 'Product name'  
    FROM Purchasing.Vendor AS v   
    JOIN Purchasing.ProductVendor AS pv   
      ON v.BusinessEntityID = pv.BusinessEntityID   
    JOIN Production.Product AS p   
      ON pv.ProductID = p.ProductID  
    WHERE v.Name LIKE @Name;  
  
```  
  
#### To recompile a stored procedure by using the WITH RECOMPILE option  
  
1.  Connect to the [!INCLUDE[ssDE](../../Topics/TopicNameContainA/includes/ssDE_md.md)].  
  
2.  From the Standard bar, click **New Query**.  
  
3.  Copy and paste the following example into the query window and click **Execute**. This example creates a simple procedure that returns all employees (first and last names supplied), their job titles, and their department names from a view.  
  
     And then copy and paste the second code example into the query window and click **Execute**. This executes the procedure and recompiles the procedure’s query plan.  
  
```tsql  
USE AdventureWorks2012;  
GO  
EXECUTE HumanResources.uspGetAllEmployees WITH RECOMPILE;  
GO  
  
```  
  
#### To recompile a stored procedure by using sp_recompile  
  
1.  Connect to the [!INCLUDE[ssDE](../../Topics/TopicNameContainA/includes/ssDE_md.md)].  
  
2.  From the Standard bar, click **New Query**.  
  
3.  Copy and paste the following example into the query window and click **Execute**. This example creates a simple procedure that returns all employees (first and last names supplied), their job titles, and their department names from a view.  
  
     Then, copy and paste the following example into the query window and click **Execute**. This does not execute the procedure but it does mark the procedure to be recompiled so that its query plan is updated the next time that the procedure is executed.  
  
```tsql  
USE AdventureWorks2012;  
GO  
EXEC sp_recompile N'HumanResources.uspGetAllEmployees';  
GO  
  
```  
  
## See Also  
 [Create a Stored Procedure](../../Topics/TopicNameContainA/Create-a-Stored-Procedure.md)   
 [Modify a Stored Procedure](../../Topics/TopicNameContainA/Modify-a-Stored-Procedure.md)   
 [Rename a Stored Procedure](../../Topics/TopicNameContainA/Rename-a-Stored-Procedure.md)   
 [View the Definition of a Stored Procedure](../../Topics/TopicNameContainA/View-the-Definition-of-a-Stored-Procedure.md)   
 [View the Dependencies of a Stored Procedure](../../Topics/TopicNameContainA/View-the-Dependencies-of-a-Stored-Procedure.md)   
 [DROP PROCEDURE (Transact-SQL)](assetId:///1c2d7235-7b9b-4336-8f17-429e7d82c2c3)