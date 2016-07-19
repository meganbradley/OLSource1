---
title: Disable or Pause Report and Subscription Processing
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - reporting-services-sharepoint
  - reporting-services-native
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 3cf9a240-24cc-46d4-bec6-976f82d8f830
manager: mblythe
---
# Disable or Pause Report and Subscription Processing
There are several approaches you can use to disable or pause [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] report and subscription processing. The approaches in this topic range from disabling a subscription to interrupting the data source connection. Not all approaches are possible with both [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] server modes.The following tables summaries the methods and supported [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] server modes:  
  
##  <a name="bkmk_top"></a> In this topic  
  
||Supported server mode|  
|-|---------------------------|  
|[Enable and disable subscriptions](#bkmk_disable_subscription)|Native mode|  
|[Pause a shared schedule](#bkmk_pause_schedule)|Native and SharePoint mode|  
|[Disable a shared data source](#bkmk_disable_shared_datasource)|Native and SharePoint mode|  
|[Modify role assignments to prevent access to a report (Native mode)](#bkmk_modify_role_assignment)|Native mode|  
|[Remove manage subscription permissions from role (Native mode)](#bkmk_remove_manage_subscriptions_permission)|Native mode|  
|[Disable delivery extensions](#bkmk_disable_extensions)|Native and SharePoint mode|  
  
##  <a name="bkmk_disable_subscription"></a> Enable and disable subscriptions  
  
> [!TIP]  
>  New in [!INCLUDE[ssSQL15](../../Topics/TopicNameContainA/includes/ssSQL15_md.md)]! **Enable and disable subscriptions**. New user interface options allow you to quickly disable and enable subscriptions. The disabled subscriptions maintain their other configuration properties such as schedule and can be easily enabled. You can also programmatically enable and disable subscriptions or audit which subscriptions are disabled.  
  
 ![reporting services subscription ribbon](../../Topics/TopicNameNotContainA/media/ssrs_subscription_ribbon.png "ssrs_subscription_ribbon")  
  
 In Native mode Report Manager, browse to the subscription from either the **My Subscriptions** page or the **Manage** page of an individual subscription. Select one or more subscriptions and then click either the disable ![disable a reporting services subscription](../../Topics/TopicNameNotContainA/media/ssrs_disable_subscription.png "ssrs_disable_subscription") button or enable button ![enable a reporting services subscription](../../Topics/TopicNameNotContainA/media/ssrs_enable_subscription.png "ssrs_enable_subscription") on the ribbon. Disabled subscriptions are flagged with a warning icon ![status warning of a reporting services subscriptio](../../Topics/TopicNameNotContainA/media/ssrs_subscription_warning.png "ssrs_subscription_warning") and the status is listed as **Disabled**.  
  
 [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] writes a row in the [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] log when a subscription is disabled and another entry when the subscription is enabled. For example, in report server log file:  
  
 `C:\Program Files\Microsoft SQL Server\MSRS13.MSSQLSERVER\Reporting Services\LogFiles\ReportServerService__10_16_2014_00_02_18.log`  
  
 you see rows similar to the following:  
  
 `library!ReportServer_0-1!b08!10/16/2014-16:21:14:: i INFO: Call to DisableSubscriptionAction(SubscriptionID=e843bc2b-023e-45a3-ba23-22f9dc9a0934)`  
  
 `library!ReportServer_0-1!2eec!10/16/2014-16:44:18:: i INFO: Call to EnableSubscriptionAction(SubscriptionID=e843bc2b-023e-45a3-ba23-22f9dc9a0934).`  
  
 ![PowerShell related content](../../Topics/TopicNameContainA/media/rs_PowerShellicon.jpg "rs_PowerShellicon") **Use Windows PowerShell to disable a single subscription:** Use the following PowerShell script to disable a specific subscription. Update the server name and subscription ID.  
  
```  
#disable specific subscription  
$rs2010 = New-WebServiceProxy -Uri "http://SERVERNAME/ReportServer/ReportService2010.asmx" -Namespace SSRS.ReportingService2010 -UseDefaultCredential;  
$subscriptionID = "subscription guid”;  
$rs2010.DisableSubscription($subscriptionID);  
  
```  
  
 You can use the following script to list all subscriptions with their IDs. Update the server name.  
  
```  
#list all subscriptions  
$rs2010 = New-WebServiceProxy -Uri "http://SERVERNAME /ReportServer/ReportService2010.asmx" -Namespace SSRS.ReportingService2010 -UseDefaultCredential;  
$subscriptions = $rs2010.ListSubscriptions("/");  
$subscriptions | select subscriptionid, report, status, path  
  
```  
  
 ![PowerShell related content](../../Topics/TopicNameContainA/media/rs_PowerShellicon.jpg "rs_PowerShellicon") **Use Windows PowerShell to list all disabled subscriptions:** Use the following PowerShell script to list all of the disabled subscriptions on the current Native mode report server. Update the server name.  
  
```  
#list all disabled subscriptions  
$rs2010 = New-WebServiceProxy -Uri "http://uetestb03/ReportServer/ReportService2010.asmx" -Namespace SSRS.ReportingService2010 -UseDefaultCredential;  
$subscriptions = $rs2010.ListSubscriptions("/");  
Write-Host "--- Disabled Subscriptions ---";  
Write-Host "----------------------------------- ";  
$subscriptions | Where-Object {$_.Active.DisabledByUserSpecified -and $_.Active.DisabledByUser } | select subscriptionid, report, status, lastexecuted,path | format-table -auto  
```  
  
 ![PowerShell related content](../../Topics/TopicNameContainA/media/rs_PowerShellicon.jpg "rs_PowerShellicon") **Use Windows PowerShell to enable all disabled subscriptions:** Use the following PowerShell script to enable all subscriptions that are currently disabled. Update the server name.  
  
```  
#enable all subscriptions  
$rs2010 = New-WebServiceProxy -Uri "http://SERVERNAME/ReportServer/ReportService2010.asmx" -Namespace SSRS.ReportingService2010 -UseDefaultCredential;  
$subscriptions = $rs2010.ListSubscriptions("/") | Where-Object {$_.status -eq "disabled" } ;  
ForEach ($subscription in $subscriptions)  
{  
    $rs2010.EnableSubscription($subscription.SubscriptionID);  
    $subscription | select subscriptionid, report, path  
}  
  
```  
  
 ![PowerShell related content](../../Topics/TopicNameContainA/media/rs_PowerShellicon.jpg "rs_PowerShellicon") **Use Windows PowerShell to DISABLE all subscriptions:** Use the following PowerShell script to list disable **ALL** subscriptions.  
  
```  
#DISABLE all subscriptions  
$rs2010 = New-WebServiceProxy -Uri "http://SERVERNAME/ReportServer/ReportService2010.asmx" -Namespace SSRS.ReportingService2010 -UseDefaultCredential;  
$subscriptions = $rs2010.ListSubscriptions("/") ;  
ForEach ($subscription in $subscriptions)  
{  
    $rs2010.DisableSubscription($subscription.SubscriptionID);  
    $subscription | select subscriptionid, report, path  
}  
```  
  
##  <a name="bkmk_pause_schedule"></a> Pause a shared schedule  
 If a report or subscription runs from a shared schedule, you can pause the schedule to prevent processing. All report and subscription processing driven by the schedule is deferred until the schedule is resumed.  
  
-   **SharePoint mode:** ![SharePoint Settings](../../Topics/TopicNameContainA/media/AS_SharePoint2013_settings_gear.gif "AS_SharePoint2013_settings_gear") In **Site settings**, select **Manage shared schedules**. Select the schedule and click **Pause selected schedules**.  
  
-   **Native mode:** In report manager, click **Site Settings**. Select the schedule and then click **Pause**.  
  
##  <a name="bkmk_disable_shared_datasource"></a> Disable a shared data source  
 One advantage to using shared data sources is that you can disable it to prevent a report or data-driven subscription from running. Disabling a shared data source disconnects the report from its external source. While it is disabled, the data source is unavailable to all reports and subscriptions that use it.  
  
 Note the report still loads even if the data source is unavailable. The report does not contain data, but users with appropriate permissions can access the property pages, security settings, report history, and subscription information associated with the report.  
  
-   **SharePoint mode:** To disable a shared data source in a SharePoint mode report server, browse to the document library that contains the data source. ![Shared data source icon](../../Topics/TopicNameContainA/media/hlp_16datasource.png "hlp_16datasource") Click the data source and then clear the **Enable this data source** check box.  
  
-   **Native mode:** To disable a shared data source in a Native mode report server, open the data source in Report Manager and clear the **Enable this data source** check box.  
  
##  <a name="bkmk_modify_role_assignment"></a> Modify role assignments to prevent access to a report (Native mode)  
 One way to make a report unavailable is to temporarily remove the role assignment that provides access to the report. This approach can be used on all reports regardless of how the data source connection is made. This approach targets only the report, without affecting the operation of other reports or items.  
  
 To remove the role assignment, open the Security Properties page of the report in Report Manager. If the report inherits security from a parent, you can click **Edit Item Security** to create a restrictive security policy that omits role assignments that provide widespread access (for example, you can remove a role assignment that provides access to Everyone, and keep the role assignment that provides access to a small group of users, such as Administrators).  
  
##  <a name="bkmk_remove_manage_subscriptions_permission"></a> Remove manage subscription permissions from role (Native mode)  
 To prevent users from creating subscriptions, clear the **Manage individual subscriptions** task from the role. When you remove this task, the Subscription pages are not available. In Report Manager, the My Subscriptions page appears to be empty (it cannot be deleted), even if it previously contained subscriptions. Removing subscription-related tasks prevents users from creating and modifying subscriptions, but does not delete existing subscriptions. Existing subscriptions continues to execute until you delete them. To remove the permission:  
  
1.  Open [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)] and con  
  
2.  Connect to the [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)] report server.  
  
3.  Expand the **Security** node.  
  
4.  Select the role and clear the **Manage individual subscriptions** task.  
  
##  <a name="bkmk_disable_extensions"></a> Disable delivery extensions  
 All delivery extensions installed on a report server are available to any user who has permission to create a subscription to a given report. The following delivery extensions are available and configured automatically:  
  
-   Windows File Share  
  
-   SharePoint Library (available only from a SharePoint site that is integrated with a SharePoint integrated mode report server)  
  
 E-mail delivery must be configured before it can be used. If you do not configure it, it is not available. For more information, see [Configure a Report Server for E-Mail Delivery (SSRS Configuration Manager)](assetId:///b838f970-d11a-4239-b164-8d11f4581d83).  
  
 If you want to turn off specific extensions, you can remove extension entries in the **RSReportServer.config** file. For more information, see [Reporting Services Configuration Files](../../Topics/TopicNameNotContainA/Reporting-Services-Configuration-Files.md) and [Configure a Report Server for E-Mail Delivery (SSRS Configuration Manager)](assetId:///b838f970-d11a-4239-b164-8d11f4581d83).  
  
 After you remove a delivery extension, it is no longer available in Report Manager or a SharePoint site. Removing a delivery extension can result in inactive subscriptions. Be sure to delete the subscriptions or configure them to use a different delivery extension before removing an extension.  
  
## See Also  
 [Subscriptions and Delivery (Reporting Services)](../../Topics/TopicNameNotContainA/Subscriptions-and-Delivery--Reporting-Services-.md)   
 [Reporting Services Configuration Files](../../Topics/TopicNameNotContainA/Reporting-Services-Configuration-Files.md)   
 [Configure Report Manager (Native Mode)](../../Topics/TopicNameNotContainA/Configure-Report-Manager--Native-Mode-.md)   
 [Reporting Services Report Server (Native Mode)](../../Topics/TopicNameNotContainA/Reporting-Services-Report-Server--Native-Mode-.md)   
 [Report Manager  (SSRS Native Mode)](../../Topics/TopicNameNotContainA/Report-Manager---SSRS-Native-Mode-.md)   
 [Security Properties Page, Items (Report Manager)](../../Topics/TopicNameNotContainA/Security-Properties-Page--Items--Report-Manager-.md)