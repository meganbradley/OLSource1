---
title: Reporting Services Tools
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - reporting-services-sharepoint
  - reporting-services-native
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 23d616e3-eb90-43fb-9b7a-869bd7e22e7b
---
# Reporting Services Tools
  [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] [!INCLUDE[ssRSnoversion](../../Token\Other/ssRSnoversion_md.md)] contains a set of graphical and scripting tools that support the development and use of rich reports in a managed environment. The tool set includes development tools, configuration and administration tools, and report viewing tools. This topic gives a brief overview of each tool in [!INCLUDE[ssRSnoversion](../../Token\Other/ssRSnoversion_md.md)] and how it can be accessed.  
  
 To find a tool right away, see [Tutorial: How to Locate and Start Reporting Services Tools &#40;SSRS&#41;](../Topic/Tutorial:%20How%20to%20Locate%20and%20Start%20Reporting%20Services%20Tools%20\(SSRS\).md).  
  
## Tools for Report Authoring  
 The following table lists the available tools for report authoring in [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] [!INCLUDE[ssRSnoversion](../../Token\Other/ssRSnoversion_md.md)].  
  
|Tool|Description|How to access|  
|----------|-----------------|-------------------|  
|[!INCLUDE[SS_MobileReptPub_Long](../../Token\Other/SS_MobileReptPub_Long_md.md)]|With [!INCLUDE[SS_MobileReptPub_Short](../../Token\Other/SS_MobileReptPub_Short_md.md)], you can create mobile reports that dynamically adjust the content to fit your screen or browser window and scale well to any screen size.<br /><br /> Create mobile reports on a design surface with adjustable grid rows and columns, and flexible mobile report elements.<br /><br /> For more information, see [Create mobile reports with SQL Server Mobile Report Publisher](../../Topics\TopicNameNotContainA/Create-mobile-reports-with-SQL-Server-Mobile-Report-Publisher.md).|Download the [SQL Server Mobile Report Publisher](http://go.microsoft.com/fwlink/?LinkId=733527)|  
|[!INCLUDE[ssCrescent](../../Token\Other/ssCrescent_md.md)]|An interactive data exploration and visual presentation experience designed to let you create and interact with reports based on [!INCLUDE[ssASnoversion](../../Token\Other/ssASnoversion_md.md)] tabular models.|[!INCLUDE[ssRSnoversion](../../Token\Other/ssRSnoversion_md.md)] in SharePoint mode. Browser with Silverlight.|  
|Report Designer|Use this tool to design reports. Includes the following features:<br /><br /> Deploy to a native mode or SharePoint mode report server.<br /><br /> Hosted in [!INCLUDE[ssBIDevStudioFull](../../Token\Other/ssBIDevStudioFull_md.md)]<br /><br /> Report Data pane to organize data used in your report<br /><br /> Tabbed views for Design and Preview for interactive report design<br /><br /> Query designers to help specify which data to retrieve from data sources and that are associated with data source types in the [RSReportDesigner Configuration File](../../Topics\TopicNameNotContainA/RSReportDesigner-Configuration-File.md)<br /><br /> Expression editor with IntelliSense to build [!INCLUDE[vbprvb](../../Token\Other/vbprvb_md.md)] expressions that customize report content and appearance<br /><br /> Supports custom report items and custom query designers<br /><br /> <br /><br /> For more information, see [Reporting Services in SQL Server Data Tools &#40;SSDT&#41;](../Topic/Reporting%20Services%20in%20SQL%20Server%20Data%20Tools%20\(SSDT\).md).|[!INCLUDE[ssBIDevStudioFull](../../Token\Other/ssBIDevStudioFull_md.md)]|  
|Report Builder|Use this tool to design reports. Includes the following features:<br /><br /> Deploy to a native mode or SharePoint mode report server.<br /><br /> [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] Office\-like authoring environment[!INCLUDE[SS_MobileReptPub_Long](../../Token\Other/SS_MobileReptPub_Long_md.md)]<br /><br /> Ability to save report items as report parts<br /><br /> A wizard for creating maps<br /><br /> Aggregates of aggregates<br /><br /> Enhanced support for expressions<br /><br /> Query designers to help specify which data to retrieve from a selection of built\-in data sources types<br /><br /> For more information, see [Report Builder in SQL Server 2016](../../Topics\TopicNameNotContainA/Report-Builder-in-SQL-Server-2016.md).|Download the [standalone version of Report Builder](http://go.microsoft.com/fwlink/?LinkID=219138)<br /><br /> Or open from Report Manager\/SharePoint|  
  
## Tools for Report Server Administration  
 A set of graphical and scripting tools are available for administering the report server in [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] [!INCLUDE[ssRSnoversion](../../Token\Other/ssRSnoversion_md.md)]. The tools that you use depend on the deployment mode of your report server.  
  
### Native Mode  
 The following table lists the available tools for administering the report server that is deployed in native mode.  
  
|Tool|Description|How to access|  
|----------|-----------------|-------------------|  
|Reporting Services Configuration Manager|Use this tool to configure a Reporting Services installation. Available tasks include:<br /><br /> Configuring both local and remote report server instances<br /><br /> Configuring the Report Server service account.<br /><br /> Creating and configuring one or more Web service URL.<br /><br /> Configuring the Report Manager URL<br /><br /> Creating and configuring the report server database.<br /><br /> Configuring a scale\-out deployment.<br /><br /> Backup, restoring, or replacing the symmetric key that is used to encrypt stored connection strings and credentials.<br /><br /> Configuring the unattended execution account.<br /><br /> Configuring an SMTP server for e\-mail delivery.<br /><br /> <br /><br /> Note: The Reporting Services Configuration Manager does not help you manage report server content, enable additional features, or grant access to the server.<br /><br /> For more information, see [Reporting Services Configuration Manager &#40;Native Mode&#41;](../Topic/Reporting%20Services%20Configuration%20Manager%20\(Native%20Mode\).md).|Start menu|  
|SQL Server Management Studio|Use this tool to manage one or more report server instances in a single environment, including:<br /><br /> Managing both local and remote report server instances<br /><br /> Setting report server properties<br /><br /> Modifying role definitions<br /><br /> Turning off report server features you are not using<br /><br /> Managing jobs<br /><br /> Managing shared schedules|Start menu|  
|SQL Server Configuration Manager|Use this tool to:<br /><br /> Start and stop the Reporting Services Windows services<br /><br /> Configure Customer Feedback Reporting, the dump directory location, and error reporting<br /><br /> <br /><br /> **\*\* Warning \*\***Do not use this tool to configure service account. Use the Reporting Services Configuration tool instead.<br /><br /> For more information, see [SQL Server Configuration Manager](../../Topics\TopicNameNotContainA/SQL-Server-Configuration-Manager.md).|Start menu|  
|Rsconfig Utility|Use this tool to configure and manage a report server connection to the report server database. You can also use it to specify a user account to use for unattended report processing.<br /><br /> For more information, see [Report Server Command Prompt Utilities &#40;SSRS&#41;](../Topic/Report%20Server%20Command%20Prompt%20Utilities%20\(SSRS\).md).|Command prompt|  
|Rskeymgmt Utility|Use this tool to:<br /><br /> Extract, restore, create, and delete the symmetric key used to encrypt report server data<br /><br /> Join report server instances in a scale\-out deployment<br /><br /> <br /><br /> For more information, see [Report Server Command Prompt Utilities &#40;SSRS&#41;](../Topic/Report%20Server%20Command%20Prompt%20Utilities%20\(SSRS\).md).|Command prompt|  
|Windows Management Instrumentation \(WMI\) Classes|Use these classes to automate the configuration tasks in Reporting Services Configuration Manager without the need to use the graphical user interface.<br /><br /> For more information, see [Accessing the WMI Provider Programmatically](../Topic/Accessing%20the%20WMI%20Provider%20Programmatically.md).|Visual Basic script|  
  
### SharePoint Integrated Mode  
 In SharePoint mode, the Reporting Services is a service application in the SharePoint architecture, and is administered directly through SharePoint  
  
|Tool|Description|How to access|  
|----------|-----------------|-------------------|  
|SharePoint Central Administration|Use SharePoint Central Administration to create, query, and manage the shared service applications for [!INCLUDE[ssRSnoversion](../../Token\Other/ssRSnoversion_md.md)].<br /><br /> For more information, see [Configuration and Administration of a Report Server &#40;Reporting Services SharePoint Mode&#41;](../Topic/Configuration%20and%20Administration%20of%20a%20Report%20Server%20\(Reporting%20Services%20SharePoint%20Mode\).md).|Browser to the SharePoint site URL for Central Administration|  
|PowerShell Cmdlets|Use PowerShell cmdlets to create, query, and manage the shared service applications for [!INCLUDE[ssRSnoversion](../../Token\Other/ssRSnoversion_md.md)].<br /><br /> For more information, see [PowerShell cmdlets for Reporting Services SharePoint Mode](../../Topics\TopicNameNotContainA/PowerShell-cmdlets-for-Reporting-Services-SharePoint-Mode.md).|SharePoint 2010 Management Shell|  
  
## Tools for Report Content Management  
 A set of graphical and scripting tools are available for managing content in [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] [!INCLUDE[ssRSnoversion](../../Token\Other/ssRSnoversion_md.md)]. The tools that you use depend on the deployment mode of your report server.  
  
|Tool|Description|How to access|  
|----------|-----------------|-------------------|  
|Report Server Web service URL|Use this tool to browse content in the report catalog in a generic item navigation page.<br /><br /> For more information, see [Report Server Web Service](../Topic/Report%20Server%20Web%20Service.md).|Browser|  
|Web Portal|**\(Native mode only\)** Use this tool to administer a single report server instance from a remote location over an HTTP connection. You can do the following:<br /><br /> View, search, print, and subscribe to reports.<br /><br /> Create, secure, and maintain the folder hierarchy to organize items on the server.<br /><br /> Configure role\-based security that determines access to items and operations.<br /><br /> Configure report execution properties, report history, and report parameters.<br /><br /> Create report models that connect to and retrieve data from a Microsoft SQL Server Analysis Services data source or from a SQL Server relational data source.<br /><br /> Set model item security to allow access to specific entities in the model, or map entities to predefined clickthrough reports that you create in advance.<br /><br /> Create shared schedules and shared data sources to make schedules and data source connections more manageable.<br /><br /> Create data\-driven subscriptions that roll out reports to a large recipient list.<br /><br /> Create linked reports to reuse and repurpose an existing report in different ways.<br /><br /> Launch Report Builder to create reports that you can save and run on the report server. For more information, see [Web Portal (SSRS Native mode)](Web%20portal%20\(SSRS%20Native%20Mode\).md).| Browser  
|RS Utility|This tool is a script host that you can use to perform scripted operations. Use this tool to run [!INCLUDE[vbprvb](../../Token\Other/vbprvb_md.md)] scripts that copy data between report server databases, publish reports, create items in a report server database, and more. For more information, see [Report Server Command Prompt Utilities &#40;SSRS&#41;](../Topic/Report%20Server%20Command%20Prompt%20Utilities%20\(SSRS\).md).|Command prompt|  
  
## See Also  
 [Reporting Services Report Server](../../Topics\TopicNameNotContainA/Reporting-Services-Report-Server.md)   
 [Reporting Services Concepts &#40;SSRS&#41;](../Topic/Reporting%20Services%20Concepts%20\(SSRS\).md)   
 [Reporting Services &#40;SSRS&#41;](../Topic/Reporting%20Services%20\(SSRS\).md)  
  
  