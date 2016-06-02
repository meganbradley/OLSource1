---
title: Enable and Disable Always On Availability Groups (SQL Server)
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-high-availability
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 7c326958-5ae9-4761-9c57-905972276a8f
---
# Enable and Disable Always On Availability Groups (SQL Server)
  Enabling [!INCLUDE[ssHADR](../../Token\Other/ssHADR_md.md)] is a prerequisite for a server instance to use availability groups. Before you can create and configure any availability group, the [!INCLUDE[ssHADR](../../Token\Other/ssHADR_md.md)] feature must have been enabled on the each instance of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] that will host an availability replica for one or more availability groups.  
  
> [!IMPORTANT]  
>  If you delete and re\-create a WSFC cluster, you must disable and re\-enable the [!INCLUDE[ssHADR](../../Token\Other/ssHADR_md.md)] feature on each instance of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] that hosted an availability replica on the original WSFC cluster.  
  
-   **Before you begin:**  
  
     [Prerequisites](#Prerequisites)  
  
     [Security](#Security)  
  
-   **How To:**  
  
    -   [Determine Whether Always On Availability Groups is Enabled](#IsEnabled)  
  
    -   [Enable Always On Availability Groups](#EnableAOAG)  
  
    -   [Disable Always On Availability Groups](#DisableAOAG)  
  
##  <a name="BeforeYouBegin"></a> Before You Begin  
  
###  <a name="Prerequisites"></a> Prerequisites for Enabling Always On Availability Groups  
  
-   The server instance must reside on a Windows Server Failover Clustering \(WSFC\) node.  
  
-   The server instance must be running an edition of SQL Server that supports [!INCLUDE[ssHADR](../../Token\Other/ssHADR_md.md)]. For more information, see [Features Supported by the Editions of SQL Server 2016](../../Topics\TopicNameNotContainA/Features-Supported-by-the-Editions-of-SQL-Server-2016.md).  
  
-   Enable Always On Availability Groups on only one server instance at a time. After enabling Always On Availability Groups, wait until the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] service has restarted before you proceed to another server instance.  
  
 For information about additional prerequisites for creating and configuring availability groups, see [Prerequisites, Restrictions, and Recommendations for Always On Availability Groups &#40;SQL Server&#41;](../Topic/Prerequisites,%20Restrictions,%20and%20Recommendations%20for%20Always%20On%20Availability%20Groups%20\(SQL%20Server\).md).  
  
###  <a name="Security"></a> Security  
 While Always On Availability Groups is enabled on an instance of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)], the server instance has full control on the WSFC cluster.  
  
####  <a name="Permissions"></a> Permissions  
 Requires membership in the **Administrator** group on the local computer and full control on the WSFC cluster. When enabling Always On by using PowerShell, open the Command Prompt window using the **Run as administrator** option.  
  
 Requires Active Directory Create Objects and Manage Objects permissions.  
  
##  <a name="IsEnabled"></a> Determine Whether Always On Availability Groups is Enabled  
  
-   [SQL Server Management Studio](#SSMS1Procedure)  
  
-   [Transact\-SQL](#Tsql1Procedure)  
  
-   [PowerShell](#PowerShell1Procedure)  
  
###  <a name="SSMS1Procedure"></a> Using SQL Server Management Studio  
 **To determine whether Always On Availability Groups is enabled**  
  
1.  In Object Explorer, right\-click the server instance, and  click **Properties**.  
  
2.  In the **Server Properties** dialog box, click the **General** page. The **Is HADR Enabled** property displays one of the following values:  
  
    -   **True**, if Always On Availability Groups is enabled  
  
    -   **False**, if Always On Availability Groups is disabled.  
  
###  <a name="Tsql1Procedure"></a> Using Transact\-SQL  
 **To determine whether Always On Availability Groups is enabled**  
  
1.  Use the following [SERVERPROPERTY](../Topic/SERVERPROPERTY%20\(Transact-SQL\).md) statement:  
  
    ```  
    SELECT SERVERPROPERTY ('IsHadrEnabled');  
    ```  
  
     The setting of the **IsHadrEnabled** server property indicates whether an instance of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] is enabled for Always On Availability Groups, as follows:  
  
    -   If **IsHadrEnabled** \= 1, Always On Availability Groups is enabled.  
  
    -   If **IsHadrEnabled** \= 0, Always On Availability Groups is disabled.  
  
    > [!NOTE]  
    >  For more information about the **IsHadrEnabled** server property, see [SERVERPROPERTY &#40;Transact-SQL&#41;](../Topic/SERVERPROPERTY%20\(Transact-SQL\).md).  
  
###  <a name="PowerShell1Procedure"></a> Using PowerShell  
 **To determine whether Always On Availability Groups is enabled**  
  
1.  Set default \(**cd**\) to the server instance on which you want to determine whether [!INCLUDE[ssHADR](../../Token\Other/ssHADR_md.md)] is enabled.  
  
2.  Enter the following PowerShell **Get\-Item** command:  
  
    ```  
    PS SQLSERVER:\SQL\NODE1\DEFAULT> get-item . | select IsHadrEnabled  
    ```  
  
    > [!NOTE]  
    >  To view the syntax of a cmdlet, use the **Get\-Help** cmdlet in the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] PowerShell environment. For more information, see [Get Help SQL Server PowerShell](../../Topics\TopicNameNotContainA/Get-Help-SQL-Server-PowerShell.md).  
  
 **To set up and use the SQL Server PowerShell provider**  
  
-   [SQL Server PowerShell Provider](../../Topics\TopicNameNotContainA/SQL-Server-PowerShell-Provider.md)  
  
##  <a name="EnableAOAG"></a> Enable Always On Availability Groups  
 **To enable Always On, using:**  
  
-   [SQL Server Configuration Manager](#SQLCM2Procedure)  
  
-   [PowerShell](#PScmd2Procedure)  
  
###  <a name="SQLCM2Procedure"></a> Using SQL Server Configuration Manager  
 **To enable Always On Availability Groups**  
  
1.  Connect to the Windows Server Failover Clustering \(WSFC\) node that hosts the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] instance where you want to enable Always On Availability Groups.  
  
2.  On the **Start** menu, point to **All Programs**, point to [!INCLUDE[ssCurrentUI](../../Token\Other/ssCurrentUI_md.md)], point to **Configuration Tools**, and  click **SQL Server Configuration Manager**.  
  
3.  In **SQL Server Configuration Manager**, click **SQL Server Services**, right\-click SQL Server \(**\<***instance name***\>\)**, where **\<***instance name***\>** is the name of a local server instance for which you want to enable Always On Availability Groups, and click **Properties.**  
  
4.  Select the **Always On High Availability** tab.  
  
5.  Verify that **Windows failover cluster name** field contains the name of the local failover cluster. If this field is blank, this server instance currently does not support [!INCLUDE[ssHADR](../../Token\Other/ssHADR_md.md)]. Either the local computer is not a cluster node, the WSFC cluster has been shut down, or this edition of [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)] that does not support [!INCLUDE[ssHADR](../../Token\Other/ssHADR_md.md)].  
  
6.  Select the **Enable Always On Availability Groups** check box, and click **OK**.  
  
     [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Configuration Manager saves your change. Then, you must manually restart the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] service. This enables you to choose a restart time that is best for your business requirements. When the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] service restarts, Always On will be enabled, and the **IsHadrEnabled** server property will be set to 1.  
  
###  <a name="PScmd2Procedure"></a> Using SQL Server PowerShell  
 **To enable Always On**  
  
1.  Change directory \(**cd**\) to a server instance that you want to enable for Always On Availability Groups.  
  
2.  Use the **Enable\-SqlAlways On** cmdlet to enable Always On Availability Groups.  
  
     To view the syntax of a cmdlet, use the **Get\-Help** cmdlet in the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] PowerShell environment. For more information, see [Get Help SQL Server PowerShell](../../Topics\TopicNameNotContainA/Get-Help-SQL-Server-PowerShell.md).  
  
    > [!NOTE]  
    >  For information about how to control whether the **Enable\-SqlAlways On** cmdlet restarts the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] service, see [When Does a Cmdlet Restart the SQL Server Service?](#WhenCmdletRestartsSQL), later in this topic.  
  
 **To set up and use the SQL Server PowerShell provider**  
  
-   [SQL Server PowerShell Provider](../../Topics\TopicNameNotContainA/SQL-Server-PowerShell-Provider.md)  
  
####  <a name="ExmplEnable-SqlHadrServic"></a> Example: Enable\-SqlAlways On  
 The following PowerShell command enables [!INCLUDE[ssHADR](../../Token\Other/ssHADR_md.md)] on an instance of SQL Server \(*Computer*\\*Instance*\).  
  
```  
Enable-SqlAlways On -Path SQLSERVER:\SQL\Computer\Instance  
```  
  
##  <a name="DisableAOAG"></a> Disable Always On Availability Groups  
  
-   **Before you disable Always On:**  
  
     [Recommendations](#Recommendations)  
  
-   **To disable Always On, using:**  
  
    -   [SQL Server Configuration Manager](#SQLCM3Procedure)  
  
    -   [PowerShell](#PScmd3Procedure)  
  
-   **Follow Up:**  [After Disabling Always On](#FollowUp)  
  
> [!IMPORTANT]  
>  Disable Always On on only one server instance at a time. After disabling Always On Availability Groups, wait until the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] service has restarted before you proceed to another server instance.  
  
###  <a name="Recommendations"></a> Recommendations  
 Before you disable Always On on a server instance, we recommend that you do the following:  
  
1.  If the server instance is currently hosting the primary replica of an availability group that you want to keep, we recommend that you manually fail over the availability group to a synchronized secondary replica, if possible. For more information, see [Perform a Planned Manual Failover of an Availability Group &#40;SQL Server&#41;](../Topic/Perform%20a%20Planned%20Manual%20Failover%20of%20an%20Availability%20Group%20\(SQL%20Server\).md).  
  
2.  Remove all local secondary replicas. For more information, see [Remove a Secondary Replica from an Availability Group &#40;SQL Server&#41;](../Topic/Remove%20a%20Secondary%20Replica%20from%20an%20Availability%20Group%20\(SQL%20Server\).md).  
  
###  <a name="SQLCM3Procedure"></a> Using SQL Server Configuration Manager  
 **To disable Always On**  
  
1.  Connect to the Windows Server Failover Clustering \(WSFC\) node that hosts the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] instance where you want to disable Always On Availability Groups.  
  
2.  On the **Start** menu, point to **All Programs**, point to [!INCLUDE[ssCurrentUI](../../Token\Other/ssCurrentUI_md.md)], point to **Configuration Tools**, and click **SQL Server Configuration Manager**.  
  
3.  In **SQL Server Configuration Manager**, click **SQL Server Services**, right\-click SQL Server \(**\<***instance name***\>\)**, where **\<***instance name***\>** is the name of a local server instance for which you want to disable Always On Availability Groups, and click **Properties**.  
  
4.  On the**Always On High Availability**tab, deselect the **Enable Always On Availability Groups** check box, and click **OK**.  
  
     [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Configuration Manager saves your change and restarts the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] service. When the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] service restarts, Always On will be disabled, and the **IsHadrEnabled** server property will be set to 0, to indicate that Always On Availability Groups is disabled.  
  
5.  We recommend that you read the information in [Follow Up: After Disabling Always On](#FollowUp), later in this topic.  
  
###  <a name="PScmd3Procedure"></a> Using SQL Server PowerShell  
 **To disable Always On**  
  
1.  Change directory \(**cd**\) to a currently\-enabled server instance that that you want to disenable for Always On Availability Groups.  
  
2.  Use the **Disable\-SqlAlways On** cmdlet to enable Always On Availability Groups.  
  
     For example, the following command disables Always On Availability Groups on an instance of SQL Server \(*Computer*\\*Instance*\).  This command requires restarting the instance, and you will be prompted to confirm this restart.  
  
    ```  
    Disable-SqlAlways On -Path SQLSERVER:\SQL\Computer\Instance  
    ```  
  
    > [!IMPORTANT]  
    >  For information about how to control whether the **Disable\-SqlAlways On** cmdlet restarts the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] service, see [When Does a Cmdlet Restart the SQL Server Service?](#WhenCmdletRestartsSQL), later in this topic.  
  
     To view the syntax of a cmdlet, use the **Get\-Help** cmdlet in the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] PowerShell environment. For more information, see [Get Help SQL Server PowerShell](../../Topics\TopicNameNotContainA/Get-Help-SQL-Server-PowerShell.md).  
  
 **To set up and use the SQL Server PowerShell provider**  
  
-   [SQL Server PowerShell Provider](../../Topics\TopicNameNotContainA/SQL-Server-PowerShell-Provider.md)  
  
###  <a name="FollowUp"></a> Follow Up: After Disabling Always On  
 After you disable Always On Availability Groups, the instance of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] must be restarted. SQL Configuration Manager restarts the server instance automatically. However, if you used the **Disable\-SqlAlways On** cmdlet, you will need to restart the server instance manually. For more information, see [sqlservr Application](../../Topics\TopicNameNotContainA/sqlservr-Application.md).  
  
 On the restarted server instance:  
  
-   Availability databases do not start up at SQL Server startup, making them inaccessible.  
  
-   The only supported Always On [!INCLUDE[tsql](../../Token\Other/tsql_md.md)] statement is [DROP AVAILABILITY GROUP](../Topic/DROP%20AVAILABILITY%20GROUP%20\(Transact-SQL\).md). CREATE AVAILABILITY GROUP, ALTER AVAILABILITY GROUP, and the SET HADR options of ALTER DATABASE are not supported.  
  
-   [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] metadata and [!INCLUDE[ssHADR](../../Token\Other/ssHADR_md.md)] configuration data in WSFC are unaffected by disabling Always On Availability Groups.  
  
 If you permanently disable Always On Availability Groups on every server instance that hosts an availability replica for one or more availability groups, we recommend that you complete the following steps:  
  
1.  If you did not remove the local availability replicas before disabling Always On, delete \(drop\) each availability group for which the server instance is hosting an availability replica. For information about deleting an availability group, see [Remove an Availability Group &#40;SQL Server&#41;](../Topic/Remove%20an%20Availability%20Group%20\(SQL%20Server\).md).  
  
2.  To remove the metadata left behind, delete \(drop\) each affected availability group on a server instance that is part of the original WSFC cluster.  
  
3.  Any primary databases continue to be accessible to all connections but the data synchronization between the primary and secondary databases stops.  
  
4.  The secondary databases enter the RESTORING state. You can delete them, or you can restore them by using RESTORE WITH RECOVERY. However, restored databases are no longer participating in availability\-group data synchronization.  
  
##  <a name="WhenCmdletRestartsSQL"></a> When Does a Cmdlet Restart the SQL Server Service?  
 On a server instance that is currently running, using **Enable\-SqlAlways On** or **Disable\-SqlAlways On** to change the current Always On setting could cause the SQL Server service to restart. The restart behavior on depends on the following conditions:  
  
|\-NoServiceRestart parameter specified|\-Force parameter specified|Is the [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] service restarted?|  
|--------------------------------------------|---------------------------------|---------------------------------------------------------|  
|No|No|By default. But the cmdlet prompts you as follows:<br /><br /> **To complete this action, we must restart the SQL Server service for server instance '\<instance\_name\>'. Do you want to continue?**<br /><br /> **\[Y\] Yes  \[N\] No  \[S\] Suspend  \[?\] Help \(default is "Y"\):**<br /><br /> If you specify **N** or **S**, the service is not restarted.|  
|No|Yes|Service is restarted.|  
|Yes|No|Service is not restarted.|  
|Yes|Yes|Service is not restarted.|  
  
## See Also  
 [Overview of Always On Availability Groups &#40;SQL Server&#41;](../Topic/Overview%20of%20Always%20On%20Availability%20Groups%20\(SQL%20Server\).md)   
 [SERVERPROPERTY &#40;Transact-SQL&#41;](../Topic/SERVERPROPERTY%20\(Transact-SQL\).md)  
  
  