---
title: Integration Services (SSIS) Connections
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 72f5afa3-d636-410b-9e81-2ffa27772a8c
---
# Integration Services (SSIS) Connections
  [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)] packages use connections to perform different tasks and to implement [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)] features:  
  
-   Connecting to source and destination data stores such as text, XML, Excel workbooks, and relational databases to extract and load data.  
  
-   Connecting to relational databases that contain reference data to perform exact or fuzzy lookups.  
  
-   Connecting to relational databases to run SQL statements such as SELECT, DELETE, and INSERT commands and also stored procedures.  
  
-   Connecting to [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] to perform maintenance and transfer tasks such as backing up databases and transferring logins.  
  
-   Writing log entries in text and XML files and [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] tables and package configurations to [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] tables.  
  
-   Connecting to [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] to create temporary work tables that some transformations require to do their work.  
  
-   Connecting to [!INCLUDE[ssASnoversion](../../Token\Other/ssASnoversion_md.md)] projects and databases to access data mining models, process cubes and dimensions, and run DDL code.  
  
-   Specifying existing or creating new files and folders to use with Foreach Loop enumerators and tasks.  
  
-   Connecting to message queues and to Windows Management Instrumentation \(WMI\), [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Management Objects \(SMO\), Web, and mail servers.  
  
 To make these connections, [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)] uses connection managers, as described in the next section.  
  
## Connection Managers  
 [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)] uses the connection manager as a logical representation of a connection. At design time, you set the properties of a connection manager to describe the physical connection that [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)] creates when the package runs. For example, a connection manager includes the **ConnectionString** property that you set at design time; at run time, a physical connection is created using the value in the connection string property.  
  
 A package can use multiple instances of a connection manager type, and you can set the properties on each instance. At run time, each instance of a connection manager type creates a connection that has different attributes.  
  
 [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)] provides different types of connection managers that enable packages to connect to a variety of data sources and servers:  
  
-   There are built\-in connection managers that Setup installs when you install [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)].  
  
-   There are connection managers that are available for download from the [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] website.  
  
-   You can create your own custom connection manager if the existing connection managers do not meet your needs.  
  
### Built\-in Connection Managers  
 The following table lists the connection manager types that [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)] provides.  
  
|Type|Description|Topic|  
|----------|-----------------|-----------|  
|ADO|Connects to ActiveX Data Objects \(ADO\) objects.|[ADO Connection Manager](../../Topics\TopicNameNotContainA/ADO-Connection-Manager.md)|  
|ADO.NET|Connects to a data source by using a .NET provider.|[ADO.NET Connection Manager](../../Topics\TopicNameNotContainA/ADO.NET-Connection-Manager.md)|  
|CACHE|Reads data from the data flow or from a cache file \(.caw\), and can save data to the cache file.|[Cache Connection Manager](../../Topics\TopicNameNotContainA/Cache-Connection-Manager.md)|  
|DQS|Connects to a Data Quality Services server and a Data Quality Services database on the server.|[DQS Cleansing Connection Manager](../../Topics\TopicNameNotContainA/DQS-Cleansing-Connection-Manager.md)|  
|EXCEL|Connects to an Excel workbook file.|[Excel Connection Manager](../../Topics\TopicNameNotContainA/Excel-Connection-Manager.md)|  
|FILE|Connects to a file or a folder.|[File Connection Manager](../../Topics\TopicNameNotContainA/File-Connection-Manager.md)|  
|FLATFILE|Connect to data in a single flat file.|[Flat File Connection Manager](../../Topics\TopicNameNotContainA/Flat-File-Connection-Manager.md)|  
|FTP|Connect to an FTP server.|[FTP Connection Manager](../../Topics\TopicNameNotContainA/FTP-Connection-Manager.md)|  
|HTTP|Connects to a webserver.|[HTTP Connection Manager](../../Topics\TopicNameNotContainA/HTTP-Connection-Manager.md)|  
|MSMQ|Connects to a message queue.|[MSMQ Connection Manager](../../Topics\TopicNameNotContainA/MSMQ-Connection-Manager.md)|  
|MSOLAP100|Connects to an instance of [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] [!INCLUDE[ssASnoversion](../../Token\Other/ssASnoversion_md.md)] or an [!INCLUDE[ssASnoversion](../../Token\Other/ssASnoversion_md.md)] project.|[Analysis Services Connection Manager](../../Topics\TopicNameNotContainA/Analysis-Services-Connection-Manager.md)|  
|MULTIFILE|Connects to multiple files and folders.|[Multiple Files Connection Manager](../../Topics\TopicNameNotContainA/Multiple-Files-Connection-Manager.md)|  
|MULTIFLATFILE|Connects to multiple data files and folders.|[Multiple Flat Files Connection Manager](../../Topics\TopicNameNotContainA/Multiple-Flat-Files-Connection-Manager.md)|  
|OLEDB|Connects to a data source by using an OLE DB provider.|[OLE DB Connection Manager](../../Topics\TopicNameNotContainA/OLE-DB-Connection-Manager.md)|  
|ODBC|Connects to a data source by using ODBC.|[ODBC Connection Manager](../../Topics\TopicNameNotContainA/ODBC-Connection-Manager.md)|  
|SMOServer|Connects to a [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Management Objects \(SMO\) server.|[SMO Connection Manager](../../Topics\TopicNameNotContainA/SMO-Connection-Manager.md)|  
|SMTP|Connects to an SMTP mail server.|[SMTP Connection Manager](../../Topics\TopicNameNotContainA/SMTP-Connection-Manager.md)|  
|SQLMOBILE|Connects to a [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Compact database.|[SQL Server Compact Edition Connection Manager](../../Topics\TopicNameNotContainA/SQL-Server-Compact-Edition-Connection-Manager.md)|  
|WMI|Connects to a server and specifies the scope of Windows Management Instrumentation \(WMI\) management on the server.|[WMI Connection Manager](../../Topics\TopicNameNotContainA/WMI-Connection-Manager.md)|  
  
### Connection Managers Available for Download  
 The following table lists additional types of connection manager that you can download from the [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] website.  
  
> [!IMPORTANT]  
>  The connection managers listed in the following table work only with [!INCLUDE[ssEnterpriseEd11](../../Token\Other/ssEnterpriseEd11_md.md)] and [!INCLUDE[ssDeveloperEd11](../../Token\Other/ssDeveloperEd11_md.md)].  
  
|Type|Description|Topic|  
|----------|-----------------|-----------|  
|ORACLE|Connects to an Oracle \<version info\> server.|The Oracle connection manager is the connection manager component of the [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] Connector for Oracle by Attunity. The [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] Connector for Oracle by Attunity also includes a source and a destination. For more information, see the download page, [Microsoft Connectors for Oracle and Teradata by Attunity](http://go.microsoft.com/fwlink/?LinkId=251526).|  
|SAPBI|Connects to an SAP NetWeaver BI version 7 system.|The SAP BI connection manager is the connection manager component of the [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] Connector for SAP BI. The [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] Connector for SAP BI also includes a source and a destination. For more information, see the download page, [Microsoft SQL Server 2008 Feature Pack](http://go.microsoft.com/fwlink/?LinkId=262016).|  
|TERADATA|Connects to a Teradata \<version info\> server.|The Teradata connection manager is the connection manager component of the [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] Connector for Teradata by Attunity. The [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] Connector for Teradata by Attunity also includes a source and a destination. For more information, see the download page, [Microsoft Connectors for Oracle and Teradata by Attunity](http://go.microsoft.com/fwlink/?LinkId=251526).|  
  
### Custom Connection Managers  
 You can also write custom connection managers. For more information, see [Developing a Custom Connection Manager](../Topic/Developing%20a%20Custom%20Connection%20Manager.md).  
  
## Related Tasks  
 For details about how to add or delete a connection manager in a package, see [Add, Delete, or Share a Connection Manager in a Package](../../Topics\TopicNameContainA/Add,-Delete,-or-Share-a-Connection-Manager-in-a-Package.md).  
  
 For details about how to set the properties of a connection manager in a package, see [Set the Properties of a Connection Manager](../../Topics\TopicNameContainA/Set-the-Properties-of-a-Connection-Manager.md).  
  
## Related Content  
  
-   Video, [Leverage Microsoft Attunity Connector for Oracle to enhance Package Performance](http://technet.microsoft.com/sqlserver/gg598963.aspx), on technet.microsoft.com  
  
-   Wiki articles, [SSIS Connectivity](http://social.technet.microsoft.com/wiki/contents/articles/sql-server-integration-services-ssis.aspx#Connectivity), on social.technet.microsoft.com  
  
-   Blog entry, [Connecting to MySQL from SSIS](http://go.microsoft.com/fwlink/?LinkId=217669), on blogs.msdn.com.  
  
-   Technical article, [Extracting and Loading SharePoint Data in SQL Server Integration Services](http://go.microsoft.com/fwlink/?LinkId=247826), on msdn.microsoft.com.  
  
-   Technical article, [You get "DTS\_E\_CANNOTACQUIRECONNECTIONFROMCONNECTIONMANAGER" error message when using Oracle connection manager in SSIS](http://go.microsoft.com/fwlink/?LinkId=233696), on support.microsoft.com.  
  
  