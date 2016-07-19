---
title: Manage DQS Log Files
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - data-quality-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 4fccfd24-aede-4882-be69-ec1e82682e16
manager: jhubbard
---
# Manage DQS Log Files
[!INCLUDE[ssDQSnoversion](../../Topics/TopicNameContainA/includes/ssDQSnoversion_md.md)] (DQS) log files help you in diagnosing and troubleshooting issue with [!INCLUDE[ssDQSServer](../../Topics/TopicNameContainA/includes/ssDQSServer_md.md)], [!INCLUDE[ssDQSClient](../../Topics/TopicNameContainA/includes/ssDQSClient_md.md)], and the [!INCLUDE[ssDQSCleansingLong](../../Topics/TopicNameNotContainA/includes/ssDQSCleansingLong_md.md)]. Separate log files are generated for [!INCLUDE[ssDQSServer](../../Topics/TopicNameContainA/includes/ssDQSServer_md.md)], [!INCLUDE[ssDQSClient](../../Topics/TopicNameContainA/includes/ssDQSClient_md.md)], and the [!INCLUDE[ssDQSCleansing](../../Topics/TopicNameNotContainA/includes/ssDQSCleansing_md.md)].  
  
 You can use [!INCLUDE[ssDQSClient](../../Topics/TopicNameContainA/includes/ssDQSClient_md.md)] to configure the log severity setting for [!INCLUDE[ssDQSServer](../../Topics/TopicNameContainA/includes/ssDQSServer_md.md)] features and modules. Additionally, you can also configure some other (advanced) settings for the DQS log files by manually changing the DQS log configuration settings in the DQS_MAIN database and an XML file on the [!INCLUDE[ssDQSClient](../../Topics/TopicNameContainA/includes/ssDQSClient_md.md)] computer.  
  
##  <a name="DQSServer"></a> Data Quality Server Log File  
 The [!INCLUDE[ssDQSServer](../../Topics/TopicNameContainA/includes/ssDQSServer_md.md)] log file, DQServerLog.DQS_MAIN.log, includes logs of activities that are run on [!INCLUDE[ssDQSServer](../../Topics/TopicNameContainA/includes/ssDQSServer_md.md)]. If you installed the default instance of SQL Server, the DQServerLog.DQS_MAIN.log file is available at C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\Log. The [!INCLUDE[ssDQSServer](../../Topics/TopicNameContainA/includes/ssDQSServer_md.md)] log file contains the following pieces of information, each delimited by a pipe (&#124;):  
  
-   Date and time  
  
-   Thread name  
  
-   Thread ID  
  
-   Log severity (FATAL, ERROR, WARN, INFO, and DEBUG)  
  
    > [!NOTE]  
    >  The DEBUG logging severity is same as Verbose.  
  
-   UID (internal DQS infrastructure ID)  
  
-   Namespace  
  
-   Class and method  
  
-   Message  
  
 Along with these, the log file also displays information about the application version, computer name, user name, and operating system.  
  
 A sample entry in the [!INCLUDE[ssDQSServer](../../Topics/TopicNameContainA/includes/ssDQSServer_md.md)] log file looks like the following:  
  
```  
23-08-2013 01:45:29|[]|4|INFO|PUID|InfInfoModuleStarting|Microsoft.Ssdqs.Core.Startup.ServerInit|Starting DQS ServerInit: version [12.0.0.0], machine name [DQS-TEST], user name [NT Service\MSSQLSERVER], operating system [Microsoft Windows NT 6.1.7600.0]...  
```  
  
 The DQServerLog.DQS_MAIN.log file is a rolling file, and a new log file is created once the existing log file exceeds the rolling file size limit specified in the [!INCLUDE[ssDQSServer](../../Topics/TopicNameContainA/includes/ssDQSServer_md.md)] log configuration settings. For more information, see [Configure Advanced Settings for DQS Log Files](../../Topics/TopicNameNotContainA/Configure-Advanced-Settings-for-DQS-Log-Files.md).  
  
##  <a name="DQSClient"></a> Data Quality Client Log File  
 The [!INCLUDE[ssDQSClient](../../Topics/TopicNameContainA/includes/ssDQSClient_md.md)] log file, DQClientLog.log, includes the client side logs. The [!INCLUDE[ssDQSClient](../../Topics/TopicNameContainA/includes/ssDQSClient_md.md)] log file is available at %APPDATA%\SSDQS\Log. The [!INCLUDE[ssDQSClient](../../Topics/TopicNameContainA/includes/ssDQSClient_md.md)] log file contains similar set of information as in the server log file, but for the client side.  
  
 As with the [!INCLUDE[ssDQSServer](../../Topics/TopicNameContainA/includes/ssDQSServer_md.md)] log file, the [!INCLUDE[ssDQSClient](../../Topics/TopicNameContainA/includes/ssDQSClient_md.md)] log file is also a rolling file, and a new log file is created once the existing log file exceeds the rolling file size limit specified in the [!INCLUDE[ssDQSClient](../../Topics/TopicNameContainA/includes/ssDQSClient_md.md)] log configuration settings. For more information, see [Configure Advanced Settings for DQS Log Files](../../Topics/TopicNameNotContainA/Configure-Advanced-Settings-for-DQS-Log-Files.md).  
  
##  <a name="DQSCleansing"></a> DQS Cleansing Component Log File  
 The [!INCLUDE[ssDQSCleansing](../../Topics/TopicNameNotContainA/includes/ssDQSCleansing_md.md)] log file, DQSSSISLog.log, includes logs of activities performed using the [!INCLUDE[ssDQSCleansingLong](../../Topics/TopicNameNotContainA/includes/ssDQSCleansingLong_md.md)]. The [!INCLUDE[ssDQSCleansing](../../Topics/TopicNameNotContainA/includes/ssDQSCleansing_md.md)] component log file is available at %APPDATA%\SSDQS\Log. The [!INCLUDE[ssDQSCleansing](../../Topics/TopicNameNotContainA/includes/ssDQSCleansing_md.md)] log file contains similar set of information as in the server log file, but for the [!INCLUDE[ssDQSCleansing](../../Topics/TopicNameNotContainA/includes/ssDQSCleansing_md.md)].  
  
##  <a name="RT"></a> Related Tasks  
  
|Task Description|Topic|  
|----------------------|-----------|  
|Describes how to configure log severity settings for DQS log files using [!INCLUDE[ssDQSClient](../../Topics/TopicNameContainA/includes/ssDQSClient_md.md)].|[Configure Severity Levels for DQS Log Files](../../Topics/TopicNameNotContainA/Configure-Severity-Levels-for-DQS-Log-Files.md)|  
|Describes how to manually configure advanced settings for DQS log files.|[Configure Advanced Settings for DQS Log Files](../../Topics/TopicNameNotContainA/Configure-Advanced-Settings-for-DQS-Log-Files.md)|  
  
## See Also  
 [DQS Administration](../../Topics/TopicNameNotContainA/DQS-Administration.md)