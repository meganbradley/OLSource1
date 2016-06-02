---
title: View or Change Server Properties (SQL Server)
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 55f3ac04-5626-4ad2-96bd-a1f1b079659d
---
# View or Change Server Properties (SQL Server)
  This topic describes how to view or change the properties of an instance of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] by using [!INCLUDE[ssManStudioFull](../../Token\Other/ssManStudioFull_md.md)], [!INCLUDE[tsql](../../Token\Other/tsql_md.md)], or SQL Server Configuration Manager.  
  
 **In This Topic**  
  
-   **Before you begin:**  
  
     [Limitations and Restrictions](#Restrictions)  
  
     [Security](#Security)  
  
-   **To view or change server properties, using:**  
  
     [SQL Server Management Studio](#SSMSProcedure)  
  
     [Transact\-SQL](#TsqlProcedure)  
  
     [SQL Server Configuration Manager](#PowerShellProcedure)  
  
-   **Follow Up:**  [After you change server properties](#FollowUp)  
  
##  <a name="BeforeYouBegin"></a> Before You Begin  
  
###  <a name="Restrictions"></a> Limitations and Restrictions  
  
-   When using sp\_configure, you must run either RECONFIGURE or RECONFIGURE WITH OVERRIDE after setting a configuration option. The RECONFIGURE WITH OVERRIDE statement is usually reserved for configuration options that should be used with extreme caution. However, RECONFIGURE WITH OVERRIDE works for all configuration options, and you can use it in place of RECONFIGURE.  
  
    > [!NOTE]  
    >  RECONFIGURE executes within a transaction. If any of the reconfigure operations fail, none of the reconfigure operations will take effect.  
  
-   Some property pages present information obtained via Windows Management Instrumentation \(WMI\). To display those pages, WMI must be installed on the computer running [!INCLUDE[ssManStudioFull](../../Token\Other/ssManStudioFull_md.md)].  
  
###  <a name="Security"></a> Security  
  
####  <a name="Permissions"></a> Permissions  
 For more information, see [Server-Level Roles](../../Topics\TopicNameNotContainA/Server-Level-Roles.md).  
  
 Execute permissions on **sp\_configure** with no parameters or with only the first parameter are granted to all users by default. To execute **sp\_configure** with both parameters to change a configuration option or to run the RECONFIGURE statement, a user must be granted the ALTER SETTINGS server\-level permission. The ALTER SETTINGS permission is implicitly held by the **sysadmin** and **serveradmin** fixed server roles.  
  
##  <a name="SSMSProcedure"></a> Using SQL Server Management Studio  
  
#### To view or change server properties  
  
1.  In Object Explorer, right\-click a server, and then click **Properties**.  
  
2.  In the **Server Properties** dialog box, click a page to view or change server information about that page. Some properties are read\-only.  
  
##  <a name="TsqlProcedure"></a> Using Transact\-SQL  
  
#### To view server properties by using the SERVERPROPERTY built\-in function  
  
1.  Connect to the [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)].  
  
2.  From the Standard bar, click **New Query**.  
  
3.  Copy and paste the following example into the query window and click **Execute**. This example uses the [SERVERPROPERTY](../Topic/SERVERPROPERTY%20\(Transact-SQL\).md) built\-in function in a `SELECT` statement to return information about the current server. This scenario is useful when there are multiple instances of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] installed on a Windows\-based server, and the client must open another connection to the same instance that is used by the current connection.  
  
    ```tsql  
    SELECT CONVERT( sysname, SERVERPROPERTY('servername'));  
    GO  
    ```  
  
#### To view server properties by using the sys.servers catalog view  
  
1.  Connect to the [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)].  
  
2.  From the Standard bar, click **New Query**.  
  
3.  Copy and paste the following example into the query window and click **Execute**. This example queries the [sys.servers](../Topic/sys.servers%20\(Transact-SQL\).md) catalog view to return the name \(`name`\) and ID \(`server_id`\) of the current server, and the name of the OLE DB provider \(`provider`\) for connecting to a linked server.  
  
    ```tsql  
    USE AdventureWorks2012;   
    GO  
    SELECT name, server_id, provider  
    FROM sys.servers ;   
    GO  
  
    ```  
  
#### To view server properties by using the sys.configurations catalog view  
  
1.  Connect to the [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)].  
  
2.  From the Standard bar, click **New Query**.  
  
3.  Copy and paste the following example into the query window and click **Execute**. This example queries the [sys.configurations](../Topic/sys.configurations%20\(Transact-SQL\).md) catalog view to return information about each server configuration option on the current server. The example returns the name \(`name`\) and description \(`description`\) of the option and whether the option is an advanced option \(`is_advanced`\).  
  
    ```wmimof  
    USE AdventureWorks2012;   
    GO  
    SELECT name, description, is_advanced  
    FROM sys.configurations ;   
    GO  
  
    ```  
  
#### To change a server property by using sp\_configure  
  
1.  Connect to the [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)].  
  
2.  From the Standard bar, click **New Query**.  
  
3.  Copy and paste the following example into the query window and click **Execute**. This example shows how to use [sp\_configure](../Topic/sp_configure%20\(Transact-SQL\).md) to change a server property. The example changes the value of the `fill factor` option to `100`. The server must be restarted before the change can take effect.  
  
```tsql  
Use AdventureWorks2012;  
GO  
sp_configure 'show advanced options', 1;  
GO  
RECONFIGURE;  
GO  
sp_configure 'fill factor', 100;  
GO  
RECONFIGURE;  
GO  
```  
  
 For more information, see [Server Configuration Options &#40;SQL Server&#41;](../Topic/Server%20Configuration%20Options%20\(SQL%20Server\).md).  
  
##  <a name="PowerShellProcedure"></a> Using SQL Server Configuration Manager  
 Some server properties can be viewed or changed by using SQL Server Configuration Manager. For example, you can view the version and edition of the instance of SQL Server, or change the location where error log files are stored. These properties can also be viewed by querying the [Server\-Related Dynamic Management Views and Functions](../Topic/Server-Related%20Dynamic%20Management%20Views%20and%20Functions%20\(Transact-SQL\).md).  
  
#### To view or change server properties  
  
1.  On the **Start** menu, point to **All Programs**, point to [!INCLUDE[ssCurrentUI](../../Token\Other/ssCurrentUI_md.md)], point to **Configuration Tools**, and then click **SQL Server Configuration Manager**.  
  
2.  In **SQL Server Configuration Manager**, click **SQL Server Services**.  
  
3.  In the details pane, right\-click **SQL Server \(\<***instancename***\>\)**, and then click **Properties**.  
  
4.  In the **SQL Server \(\<***instancename***\>\) Properties** dialog box, change the server properties on the **Service** tab or the **Advanced** tab, and then click **OK**.  
  
##  <a name="FollowUp"></a> Follow Up: After you change server properties  
 For some properties, the server might have to be restarted before the change can take effect.  
  
## See Also  
 [Server Configuration Options &#40;SQL Server&#41;](../Topic/Server%20Configuration%20Options%20\(SQL%20Server\).md)   
 [SET Statements &#40;Transact-SQL&#41;](../Topic/SET%20Statements%20\(Transact-SQL\).md)   
 [SERVERPROPERTY &#40;Transact-SQL&#41;](../Topic/SERVERPROPERTY%20\(Transact-SQL\).md)   
 [sp_configure &#40;Transact-SQL&#41;](../Topic/sp_configure%20\(Transact-SQL\).md)   
 [RECONFIGURE &#40;Transact-SQL&#41;](../Topic/RECONFIGURE%20\(Transact-SQL\).md)   
 [SELECT &#40;Transact-SQL&#41;](../Topic/SELECT%20\(Transact-SQL\).md)   
 [Configure WMI to Show Server Status in SQL Server Tools](../Topic/Configure%20WMI%20to%20Show%20Server%20Status%20in%20SQL%20Server%20Tools.md)   
 [SQL Server Configuration Manager](../../Topics\TopicNameNotContainA/SQL-Server-Configuration-Manager.md)   
 [Configuration Functions &#40;Transact-SQL&#41;](../Topic/Configuration%20Functions%20\(Transact-SQL\).md)   
 [Server-Related Dynamic Management Views and Functions &#40;Transact-SQL&#41;](../Topic/Server-Related%20Dynamic%20Management%20Views%20and%20Functions%20\(Transact-SQL\).md)  
  
  