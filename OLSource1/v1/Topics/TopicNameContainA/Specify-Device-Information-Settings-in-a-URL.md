---
title: Specify Device Information Settings in a URL
ms.custom: na
ms.date: 07/04/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - reporting-services-sharepoint
  - reporting-services-native
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: cb7f7577-c6a8-4e6f-8e60-5ec0760f29c3
manager: mblythe
---
# Specify Device Information Settings in a URL
Device information settings are parameters that are passed to a rendering extension. If you use the methods of the [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] Report Server Web service to render a report, a **DeviceInfo** XML element is passed as an input parameter. Child elements of the **DeviceInfo** element are specific to the device information settings of different rendering extensions. You can include device information settings in a URL by using the *rc:tag=value* parameter string, where *tag* is the name of the device information settings element being accessed. For more information about device information settings in [!INCLUDE[ssNoVersion](../../Topics/TopicNameContainA/includes/ssNoVersion_md.md)] [!INCLUDE[ssRSnoversion](../../Topics/TopicNameContainA/includes/ssRSnoversion_md.md)], see [Device Information Settings](assetId:///fe718939-7efe-4c7f-87cb-5f5b09caeff4).  
  
## Example  
 The following example sets the format of the specified report to JPEG by using the *OutputFormat* device information setting of the image rendering extension (the line breaks have been added for legibility):  
  
```  
http://servername/reportserver?/SampleReports  
/Employee Sales Summary&EmployeeID=38&rs:  
Command=Render&rs:Format=IMAGE&rc:OutputFormat=JPEG  
```  
  
## See Also  
 [URL Access (SSRS)](../../Topics/TopicNameNotContainA/URL-Access--SSRS-.md)   
 [URL Access Parameter Reference](../../Topics/TopicNameNotContainA/URL-Access-Parameter-Reference.md)