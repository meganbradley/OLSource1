---
title: "Utility Administration (SQL Server Utility)"
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 3e5a00c3-8905-40f0-9ddc-d924df9c2f0d
caps.latest.revision: 7
manager: jhubbard
---
# Utility Administration (SQL Server Utility)
Use the Utility Administration tabs to manage policy, security, and data warehouse settings for a [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Utility. For more information about [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Utility concepts, see [SQL Server Utility Features and Tasks](../../Topics/TopicNameNotContainA/SQL-Server-Utility-Features-and-Tasks.md).  
  
## UIElement List  
 Policy tab - Use the policy tab to view or specify global monitoring policies.  
  
 Set global data-tier application monitoring policies. To expand the list of values for this option, click on the arrow next to the policy name, or click on the policy title.  
 When is an application running out of processor capacity? To change this policy, use the control to the right of the policy description, then click **Apply**. You can also restore default values or discard changes using buttons at the bottom of the display.  
  
-   The default maximum value for processor utilization is 70%.  
  
-   The default minimum value for processor utilization is 0%.  
  
 When is an application running out of file space? To change the policy for data file or log file space utilization, use the control to the right of the policy description, then click **Apply**. You can also restore default values or discard changes using buttons at the bottom of the display.  
  
-   The default maximum value for file space utilization is 70%.  
  
-   The default minimum value for file space utilization is 0%.  
  
 Set global SQL Server managed instance application monitoring policies. To expand the list of values for this option, click on the arrow next to the policy name, or click on the policy title.  
 When is a managed instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] running out of processor capacity? To change this policy, use the control to the right of the policy description, then click **Apply**. You can also restore default values or discard changes using buttons at the bottom of the display.  
  
-   The default maximum value for instance processor utilization is 70%.  
  
-   The default minimum value for instance processor utilization is 0%.  
  
 When is a managed instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] computer running out of processor capacity? To change this policy, use the control to the right of the policy description, then click **Apply**. You can also restore default values or discard changes using buttons at the bottom of the display.  
  
-   The default maximum value for computer processor utilization is 70%.  
  
-   The default minimum value for computer processor utilization is 0%.  
  
 When is a managed instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] running out of file space? To change the policy for data file or log file space utilization , use the control to the right of the policy description, then click **Apply**. You can also restore default values or discard changes using buttons at the bottom of the display.  
  
-   The default maximum value for file space utilization is 70%.  
  
-   The default minimum value for file space utilization is 0%.  
  
 When is a managed instance of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] computer running out of storage volume space? To change this policy, use the control to the right of the policy description, then click **Apply**. You can also restore default values or discard changes using buttons at the bottom of the display.  
  
-   The default maximum value for computer volume space utilization is 70%.  
  
-   The default minimum value for computer volume space utilization is 0%.  
  
 Reducing policy violation noise from highly volatile resources. To expand the controls for this feature, click on the down-arrow on the right side of the display.  
 For more information, see [Reduce Noise in CPU Utilization Policies (SQL Server Utility)](../../Topics/TopicNameNotContainA/Reduce-Noise-in-CPU-Utilization-Policies--SQL-Server-Utility-.md)  
  
## UIElement List  
 Security tab - Displays login names with permissions to administer or read from the UCP.  
  
 Select the logins from the UCP that will be added to the Utility Reader role.  
 The Utility Reader privilege allows the user account to:  
  
-   Connect to the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Utility.  
  
-   See all viewpoints in the Utility Explorer in SSMS.  
  
-   See settings on the Utility Administration node in Utility Explorer in SSMS.  
  
 Utility administrators can enroll instances of SQL Server into and remove instances of SQL Server from a SQL Server Utility, as well as modify policies on managed instances and modify administration settings on the UCP.  
  
 To be a Utility administrator, you must have sysadmin privileges on the instance of SQL Server. To add or change user accounts for the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] UCP, use Object Explorer in SSMS to add the user to the server logins of the UCP instance of SQL Server. For more information, see [sp_addlogin (Transact-SQL)](assetId:///030f19c3-a5e3-4b53-bfc4-de4bfca0fddc).  
  
## UIElement List  
 Data Warehouse tab - Displays configuration details for the utility management data warehouse.  
  
 Data Retention  
 Specify the data retention period for utilization information collected for managed instances of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)]. The default time period is 1 year. The minimum value is 1 month. The longest supported value is 2 years.  
  
 Utility Data Warehouse Configuration Information  
 The following configuration settings are not configurable in this release of [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)]:  
  
-   UMDW name: Sysutility_mdw_<GUID\>_DATA.  
  
-   Collection set upload frequency: Every 15 minutes.  
  
 The UMDW directory is configurable: <System drive\>:\Program Files\Microsoft SQL Server\MSSQL10_50.<UCP_Name>\MSSQL\Data\\, where <System drive\> is normally the C:\ drive. The log file, UMDW_<GUID\>_LOG, is located in the same directory.  
  
> [!NOTE]  
>  The UMDW (sysutility_mdw) file location can be changed using detach/attach or ALTER DATABASE. We recommend the use of ALTER DATABASE. For more information, see [ALTER DATABASE (Transact-SQL)](assetId:///15f8affd-8f39-4021-b092-0379fc6983da).  
  
 Go back to out-of-the-box defaults  
 To reset settings on this tab to default values, click the **Restore Defaults** button, then click **Apply**.  
  
## See Also  
 [Utility Dashboard (SQL Server Utility)](../../Topics/TopicNameNotContainA/Utility-Dashboard--SQL-Server-Utility-.md)   
 [Deployed Data-tier Application Details (SQL Server Utility)](../../Topics/TopicNameNotContainA/Deployed-Data-tier-Application-Details--SQL-Server-Utility-.md)   
 [Managed Instance Details (SQL Server Utility)](../../Topics/TopicNameNotContainA/Managed-Instance-Details--SQL-Server-Utility-.md)   
 [Monitor Instances of SQL Server in the SQL Server Utility](../../Topics/TopicNameNotContainA/Monitor-Instances-of-SQL-Server-in-the-SQL-Server-Utility.md)