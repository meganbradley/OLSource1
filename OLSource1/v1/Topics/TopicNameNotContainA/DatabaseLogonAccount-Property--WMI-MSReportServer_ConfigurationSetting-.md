---
title: "DatabaseLogonAccount Property (WMI MSReportServer_ConfigurationSetting)"
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
apiname: 
  - DatabaseLogonAccount
apilocation: 
  - reportingservices.mof
apitype: MOFDef
ms.assetid: 55f2863f-1ac1-4519-b512-e7f11c0ea5ea
caps.latest.revision: 25
manager: mblythe
---
# DatabaseLogonAccount Property (WMI MSReportServer_ConfigurationSetting)
Specifies the logon account that the report server uses when connecting to the report server database. Read only.  
  
## Syntax  
  
```vb#  
Public Dim DatabaseLogonAccount As String  
```  
  
```c#  
public string DatabaseLogonAccount;  
```  
  
## Property Values  
 A **String** object that represents the logon account name.  
  
## Example Code  
 [MSReportServer_ConfigurationSetting Class](../../Topics/TopicNameNotContainA/MSReportServer_ConfigurationSetting-Class.md)  
  
## Remarks  
 Valid values for this property will vary depending on the value of the [DatabaseLogonType](../../Topics/TopicNameNotContainA/DatabaseLogonType-Property--WMI-MSReportServer_ConfigurationSetting-.md) property.  
  
 This property is ignored if the [DatabaseLogonType](../../Topics/TopicNameNotContainA/DatabaseLogonType-Property--WMI-MSReportServer_ConfigurationSetting-.md) property is set to **2 (Service)**.  
  
## Requirements  
 **Namespace:** [!INCLUDE[ssRSWMInmspcA](../../Topics/TopicNameNotContainA/includes/ssRSWMInmspcA_md.md)]  
  
## See Also  
 [MSReportServer_ConfigurationSetting Members](../../Topics/TopicNameNotContainA/MSReportServer_ConfigurationSetting-Members.md)