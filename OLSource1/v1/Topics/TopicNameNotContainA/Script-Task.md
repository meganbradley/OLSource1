---
title: Script Task
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: f6cce7df-4bd6-4b75-9f89-6c37b4bb5558
---
# Script Task
  The Script task provides code to perform functions that are not available in the built\-in tasks and transformations that [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)] provides. The Script task can also combine functions in one script instead of using multiple tasks and transformations. You use the Script task for work that must be done once in a package \(or once per enumerated object\), instead than once per data row.  
  
 You can use the Script task for the following purposes:  
  
-   Access data by using other technologies that are not supported by built\-in connection types. For example, a script can use Active Directory Service Interfaces \(ADSI\) to access and extract user names from Active Directory.  
  
-   Create a package\-specific performance counter. For example, a script can create a performance counter that is updated while a complex or poorly performing task runs.  
  
-   Identify whether specified files are empty or how many rows they contain, and then based on that information affect the control flow in a package. For example, if a file contains zero rows, the value of a variable set to 0, and a precedence constraint that evaluates the value prevents a File System task from copying the file.  
  
 If you have to use the script to do the same work for each row of data in a set, you should use the Script component instead of the Script task. For example, if you want to assess the reasonableness of a postage amount and skip data rows that have very high or low amounts, you would use a Script component. For more information, see [Script Component](../../Topics\TopicNameNotContainA/Script-Component.md).  
  
 If more than one package uses a script, consider writing a custom task instead of using the Script task. For more information, see [Developing a Custom Task](../Topic/Developing%20a%20Custom%20Task.md).  
  
 After you decide that the Script task is the appropriate choice for your package, you have to both develop the script that the task uses and configure the task itself.  
  
## Writing and Running the Script that the Task Uses  
 The Script task uses [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] [!INCLUDE[vsprvs](../../Token\Other/vsprvs_md.md)] Tools for Applications \(VSTA\) as the environment in which you write the scripts and the engine that runs those scripts.  
  
 VSTA provides all the standard features of the [!INCLUDE[vsprvs](../../Token\Other/vsprvs_md.md)] environment, such as the color\-coded [!INCLUDE[vsprvs](../../Token\Other/vsprvs_md.md)] editor, IntelliSense, and **Object Explorer**. VSTA also uses the same debugger that other [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] development tools use. Breakpoints in the script work seamlessly with breakpoints on [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)] tasks and containers. VSTA supports both the [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] Visual Basic and [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] Visual C\# programming languages.  
  
 To run a script, you must have VSTA installed on the computer where the package runs. When the package runs, the task loads the script engine and runs the script. You can access external .NET assemblies in scripts by adding references to the assemblies in the project.  
  
> [!NOTE]  
>  Unlike earlier versions where you could indicate whether the scripts were precompiled, all scripts are precompiled in [!INCLUDE[ssISversion10](../../Token\Other/ssISversion10_md.md)] and later versions. When a script is precompiled, the language engine is not loaded at run time and the package runs more quickly. However, precompiled binary files consume significant disk space.  
  
## Configuring the Script Task  
 You can configure the Script task in the following ways:  
  
-   Provide the custom script that the task runs.  
  
-   Specify the method in the VSTA project that the [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)] runtime calls as the entry point into the Script task code.  
  
-   Specify the script language.  
  
-   Optionally, provide lists of read\-only and read\/write variables for use in the script.  
  
 You can set these properties through [!INCLUDE[ssIS](../../Token\Other/ssIS_md.md)] Designer or programmatically.  
  
### Configuring the Script Task in the Designer  
 The following table describes the **ScriptTaskLogEntry** event that can be logged for Script task. The **ScriptTaskLogEntry** event is selected for logging on the **Details** tab of the **Configure SSIS Logs** dialog box. For more information, see [Integration Services &#40;SSIS&#41; Logging](../Topic/Integration%20Services%20\(SSIS\)%20Logging.md) and [Custom Messages for Logging](../../Topics\TopicNameNotContainA/Custom-Messages-for-Logging.md).  
  
|Log entry|Description|  
|---------------|-----------------|  
|**ScriptTaskLogEntry**|Reports the results of implementing logging in the script. The task writes a log entry for each call to the **Log** method of the **Dts** object. The task writes these entries when the code is run. For more information, see [Logging in the Script Task](../Topic/Logging%20in%20the%20Script%20Task.md).|  
  
 For more information about the properties that you can set in [!INCLUDE[ssIS](../../Token\Other/ssIS_md.md)] Designer, see the following topics:  
  
-   [Script Task Editor &#40;General Page&#41;](../Topic/Script%20Task%20Editor%20\(General%20Page\).md)  
  
-   [Script Task Editor &#40;Script Page&#41;](../Topic/Script%20Task%20Editor%20\(Script%20Page\).md)  
  
-   [Expressions Page](../../Topics\TopicNameNotContainA/Expressions-Page.md)  
  
 For more information about how to set these properties in [!INCLUDE[ssIS](../../Token\Other/ssIS_md.md)] Designer, see the following topic:  
  
-   [Set the Properties of a Task or Container](../../Topics\TopicNameContainA/Set-the-Properties-of-a-Task-or-Container.md)  
  
### Configuring the Script Task Programmatically  
 For more information about programmatically setting these properties, see the following topic:  
  
-   [ScriptTask](assetId:///T:Microsoft.SqlServer.Dts.Tasks.ScriptTask.ScriptTask)  
  
## Related Content  
  
-   Technical article, [How to send email with delivery notification in C\#](http://go.microsoft.com/fwlink/?LinkId=237625), on shareourideas.com  
  
  