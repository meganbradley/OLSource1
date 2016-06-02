---
title: Allow Non-Administrators to Use Replication Monitor
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - replication
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 1cf21d9e-831d-41a1-a5a0-83ff6d22fa86
---
# Allow Non-Administrators to Use Replication Monitor
  This topic describes how to allow non\-administrators to use Replication Monitor in [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] by using [!INCLUDE[ssManStudioFull](../../Token\Other/ssManStudioFull_md.md)] or [!INCLUDE[tsql](../../Token\Other/tsql_md.md)]. Replication Monitor can be used by users who are members of the following roles:  
  
-   The **sysadmin** fixed server role.  
  
     These users can monitor replication and have full control over changing replication properties such as agent schedules, agent profiles, and so on.  
  
-   The **replmonitor** database role in the distribution database.  
  
     These users can monitor replication, but cannot change any replication properties.  
  
 **In This Topic**  
  
-   **Before you begin:**  
  
     [Security](#Security)  
  
-   **To allow non\-administrators to use Replication Monitor, using:**  
  
     [SQL Server Management Studio](#SSMSProcedure)  
  
     [Transact\-SQL](#TsqlProcedure)  
  
##  <a name="BeforeYouBegin"></a> Before You Begin  
  
###  <a name="Security"></a> Security  
  
####  <a name="Permissions"></a> Permissions  
 To allow non\-administrators to use Replication Monitor, a member of the **sysadmin** fixed server role must add the user to the distribution database and assign that user to the **replmonitor** role.  
  
##  <a name="SSMSProcedure"></a> Using SQL Server Management Studio  
  
#### To allow non\-administrators to use Replication Monitor  
  
1.  In [!INCLUDE[ssManStudioFull](../../Token\Other/ssManStudioFull_md.md)], connect to the Distributor, and then expand the server node.  
  
2.  Expand **Databases**, expand **System Databases**, and then expand the distribution database \(named **distribution** by default\).  
  
3.  Expand **Security**, right\-click **Users**, and then click **New User**.  
  
4.  Enter a user name and login for the user.  
  
5.  Select a default schema of **replmonitor**.  
  
6.  Select the **replmonitor** check box in the **Database role membership** grid.  
  
7.  [!INCLUDE[clickOK](../../Token\Other/clickOK_md.md)]  
  
##  <a name="TsqlProcedure"></a> Using Transact\-SQL  
  
#### To add a user to the replmonitor fixed database role  
  
1.  At the Distributor on the distribution database, execute [sp_helpuser &#40;Transact-SQL&#41;](../Topic/sp_helpuser%20\(Transact-SQL\).md). If the user is not listed in **UserName** in the result set, the user must be granted access to the distribution database using the [CREATE USER &#40;Transact-SQL&#41;](../Topic/CREATE%20USER%20\(Transact-SQL\).md) statement.  
  
2.  At the Distributor on the distribution database, execute [sp_helprolemember &#40;Transact-SQL&#41;](../Topic/sp_helprolemember%20\(Transact-SQL\).md), specifying a value of **replmonitor** for the **@rolename** parameter. If the user is listed in **MemberName** in the result set, the user already belongs to this role.  
  
3.  If the user does not belong to the **replmonitor** role, execute [sp_addrolemember &#40;Transact-SQL&#41;](../Topic/sp_addrolemember%20\(Transact-SQL\).md) at the Distributor on the distribution database. Specify a value of **replmonitor** for **@rolename** and the name of the database user or the [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] Windows login being added for **@membername**.  
  
#### To remove a user from the replmonitor fixed database role  
  
1.  To verify that the user belongs to the **replmonitor** role, execute [sp_helprolemember &#40;Transact-SQL&#41;](../Topic/sp_helprolemember%20\(Transact-SQL\).md) at the Distributor on the distribution database, and specify a value of **replmonitor** for **@rolename**. If the user is not listed in **MemberName** in the result set, the user does not currently belong to this role.  
  
2.  If the user does belong to the **replmonitor** role, execute [sp_droprolemember &#40;Transact-SQL&#41;](../Topic/sp_droprolemember%20\(Transact-SQL\).md) at the Distributor on the distribution database. Specify a value of **replmonitor** for **@rolename** and the name of the database user or the Windows login being removed for **@membername**.  
  
  