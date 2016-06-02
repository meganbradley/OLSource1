---
title: Integration Services (SSIS) Packages
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 9266bc64-7e1a-4e78-913b-a8deaa9843bf
---
# Integration Services (SSIS) Packages
  A package is an organized collection of connections, control flow elements, data flow elements, event handlers, variables, parameters, and configurations, that you assemble using either the graphical design tools that [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)] provides, or build programmatically.  You then save the completed package to [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)], the [!INCLUDE[ssIS](../../Token\Other/ssIS_md.md)] Package Store, or the file system, or you can deploy the ssISnoversion project to the [!INCLUDE[ssIS](../../Token\Other/ssIS_md.md)] server. The package is the unit of work that is retrieved, executed, and saved.  
  
 When you first create a package, it is an empty object that does nothing. To add functionality to a package, you add a control flow and, optionally, one or more data flows to the package.  
  
 The following diagram shows a simple package that contains a control flow with a Data Flow task, which in turn contains a data flow.  
  
 ![A package with a control flow and a data flow](../../Images\Image\ImageContaina/SSIS_Package.gif "SSIS_Package")  
  
 After you have created the basic package, you can add advanced features such as logging and variables to extend package functionality. For more information, see the section about Objects that Extend Package Functionality.  
  
 The completed package can then be configured by setting package\-level properties that implement security, enable restarting of packages from checkpoints, or incorporate transactions in package workflow. For more information, see the section about Properties that Support Extended Features.  
  
## Contents of a package  
 **Tasks and containers \(control flow\).** A control flow consists of one or more tasks and containers that execute when the package runs. To control order or define the conditions for running the next task or container in the package control flow, you use precedence constraints to connect the tasks and containers in a package. A subset of tasks and containers can also be grouped and run repeatedly as a unit within the package control flow. For more information, see [Control Flow](../../Topics\TopicNameNotContainA/Control-Flow.md).  
  
 **Data sources and destinations \(data flow\).** A data flow consists of the sources and destinations that extract and load data, the transformations that modify and extend data, and the paths that link sources, transformations, and destinations. Before you can add a data flow to a package, the package control flow must include a Data Flow task. The Data Flow task is the executable within the [!INCLUDE[ssIS](../../Token\Other/ssIS_md.md)] package that creates, orders, and runs the data flow. A separate instance of the data flow engine is opened for each Data Flow task in a package. For more information, see [Data Flow Task](../../Topics\TopicNameNotContainA/Data-Flow-Task.md) and [Data Flow](../../Topics\TopicNameNotContainA/Data-Flow.md).  
  
 **Connection managers \(connections\).** A package typically includes at least one connection manager. A connection manager is a link between a package and a data source that defines the connection string for accessing the data that the tasks, transformations, and event handlers in the package use. [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)] includes connection types for data sources such as text and XML files, relational databases, and [!INCLUDE[ssASnoversion](../../Token\Other/ssASnoversion_md.md)] databases and projects. For more information, see [Integration Services &#40;SSIS&#41; Connections](../Topic/Integration%20Services%20\(SSIS\)%20Connections.md).  
  
## Reuse an existing package as a template  
 Packages are frequently used as templates from which to build packages that share basic functionality. You build the basic package and then copy it, or you can designate the package is a template. For example, a package that downloads and copies files and then extracts the data may include the FTP and File System tasks in a Foreach Loop that enumerates files in a folder. It may also include Flat File connection managers to access the data, and Flat File sources to exact the data. The destination of the data varies, and the destination is added to each new package after it is copied from the basic package. You can also create packages and then use them as templates for the new packages that you add to an [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)] project. For more information, see [Create Packages in SQL Server Data Tools](../../Topics\TopicNameNotContainA/Create-Packages-in-SQL-Server-Data-Tools.md).  
  
 When a package is first created, either programmatically or by using SSIS Designer, a GUID is added to its **ID** property and a name to its **Name** property. If you create a new package by copying an existing package or by using a template package, the name and the GUID are copied as well. This can be a problem if you use logging, because the GUID and the name of the package are written to the logs to identify the package to which the logged information belongs. Therefore, you should update the name and the GUID of the new packages to help differentiate them from the package from which they were copied and from each other in the log data.  
  
 To change the package GUID, you regenerate a GUID in the **ID** property in the Properties window in [!INCLUDE[ssBIDevStudioFull](../../Token\Other/ssBIDevStudioFull_md.md)]. To change the package name, you can update the value of the **Name** property in the Properties window. You can also use the **dtutil** command prompt, or update the GUID and name programmatically. For more information, see [Set Package Properties](../../Topics\TopicNameNotContainA/Set-Package-Properties.md) and [dtutil Utility](../../Topics\TopicNameNotContainA/dtutil-Utility.md).  
  
## Objects that Extend Package Functionality  
 Packages can include additional objects that provide advanced features or extend existing functionality, such as event handlers, configurations, logging, and variables.  
  
### Event Handlers  
 An event handler is a workflow that runs in response to the events raised by a package, task, or container. For example, you could use an event handler to check disk space when a pre\-execution event occurs or if an error occurs, and send an e\-mail message that reports the available space or error information to an administrator. An event handler is constructed like a package, with a control flow and optional data flows. Event handlers can be added to individual tasks or containers in the package. For more information, see [Integration Services &#40;SSIS&#41; Event Handlers](../Topic/Integration%20Services%20\(SSIS\)%20Event%20Handlers.md).  
  
### Configurations  
 A configuration is a set of property\-value pairs that defines the properties of the package and its tasks, containers, variables, connections, and event handlers when the package runs. Using configurations makes it possible to update properties without modifying the package. When the package is run, the configuration information is loaded, updating the values of properties. For example, a configuration can update the connection string of connection.  
  
 The configuration is saved and then deployed with the package when the package is installed on a different computer. The values in the configuration can be updated when the package is installed to support the package in a different environment. For more information, see [Create Package Configurations](../../Topics\TopicNameNotContainA/Create-Package-Configurations.md).  
  
### Logging and Log Providers  
 A log is a collection of information about the package that is collected when the package runs. For example, a log can provide the start and finish time for a package run. A log provider defines the destination type and the format that the package and its containers and tasks can use to log run\-time information. The logs are associated with a package, but the tasks and containers in the package can log information to any package log. [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)] includes a variety of built\-in log providers for logging. For example, [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)] includes log providers for [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] and text files. You can also create custom log providers and use them for logging. For more information, see [Integration Services &#40;SSIS&#41; Logging](../Topic/Integration%20Services%20\(SSIS\)%20Logging.md).  
  
### Variables  
 [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)] supports system variables and user\-defined variables. The system variables provide useful information about package objects at run time, and user\-defined variables support custom scenarios in packages. Both types of variables can be used in expressions, scripts, and configurations.  
  
 The package\-level variables include the pre\-defined system variables available to a package and the user\-defined variables with package scope. For more information, see [Integration Services &#40;SSIS&#41; Variables](../Topic/Integration%20Services%20\(SSIS\)%20Variables.md).  
  
### Parameters  
 [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)] parameters allow you to assign values to properties within packages at the time of package execution. You can create *project parameters* at the project level and *package parameters* at the package level. Project parameters are used to supply any external input the project receives to one or more packages in the project. Package parameters allow you to modify package execution without having to edit and redeploy the package. For more information, see [Integration Services &#40;SSIS&#41; Parameters](../Topic/Integration%20Services%20\(SSIS\)%20Parameters.md).  
  
## Package Properties that Support Extended Features  
 The package object can be configured to support features such as restarting the package at checkpoints, signing the package with a digital certificate, setting the package protection level, and ensuring data integrity by using transactions.  
  
### Restarting Packages  
 The package includes checkpoint properties that you can use to restart the package when one or more of its tasks fail. For example, if a package has two Data Flow tasks that update two different tables and the second task fails, the package can be rerun without repeating the first Data Flow task. Restarting a package can save time for long\-running packages. Restarting means you can start the package from the failed task instead of having to rerun the whole package. For more information, see [Restart Packages by Using Checkpoints](../../Topics\TopicNameNotContainA/Restart-Packages-by-Using-Checkpoints.md).  
  
### Securing Packages  
 A package can be signed with a digital signature and encrypted by using a password or a user key. A digital signature authenticates the source of the package. However, you must also configure [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)] to check the digital signature when the package loads. For more information, see [Identify the Source of Packages with Digital Signatures](../../Topics\TopicNameNotContainA/Identify-the-Source-of-Packages-with-Digital-Signatures.md) and [Access Control for Sensitive Data in Packages](../../Topics\TopicNameNotContainA/Access-Control-for-Sensitive-Data-in-Packages.md).  
  
### Supporting Transactions  
 Setting a transaction attribute on the package enables tasks, containers, and connections in the package to join the transaction. Transaction attributes ensure that the package and its elements succeed or fail as a unit. Packages can also run other packages and enroll other packages in transactions, so that you can run multiple packages as a single unit of work. For more information, see [Integration Services Transactions](../../Topics\TopicNameNotContainA/Integration-Services-Transactions.md).  
  
## Custom Log Entries Available on the Package  
 The following table lists the custom log entries for packages. For more information, see [Integration Services &#40;SSIS&#41; Logging](../Topic/Integration%20Services%20\(SSIS\)%20Logging.md) and [Custom Messages for Logging](../../Topics\TopicNameNotContainA/Custom-Messages-for-Logging.md).  
  
|Log entry|Description|  
|---------------|-----------------|  
|**PackageStart**|Indicates that the package began to run.<br /><br /> Note: This log entry is automatically written to the log. You cannot exclude it.|  
|**PackageEnd**|Indicates that the package completed.<br /><br /> Note: This log entry is automatically written to the log. You cannot exclude it.|  
|**Diagnostic**|Provides information about the system configuration that affects package execution such as the number executables that can be run concurrently.|  
  
## Configuration of Packages  
 You can set properties in the **Properties** window of [!INCLUDE[ssBIDevStudioFull](../../Token\Other/ssBIDevStudioFull_md.md)] or programmatically.  
  
 For information about how to set these properties using [!INCLUDE[ssBIDevStudioFull](../../Token\Other/ssBIDevStudioFull_md.md)], see [Set Package Properties](../../Topics\TopicNameNotContainA/Set-Package-Properties.md).  
  
 For information about programmatically setting these properties, see [Package](assetId:///T:Microsoft.SqlServer.Dts.Runtime.Package).  
  
## Related Tasks  
 [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)] includes two graphical tools, [!INCLUDE[ssIS](../../Token\Other/ssIS_md.md)] Designer and [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Import and Export Wizard, in addition to the [!INCLUDE[ssIS](../../Token\Other/ssIS_md.md)] object model for creating packages. See the following topics for details.  
  
-   [SQL Server Import and Export Wizard](../../Topics\TopicNameNotContainA/SQL-Server-Import-and-Export-Wizard.md)  
  
-   [Create Packages in SQL Server Data Tools](../../Topics\TopicNameNotContainA/Create-Packages-in-SQL-Server-Data-Tools.md)  
  
-   See **Building Packages Programmatically** section in the Developer Guide.  
  
  