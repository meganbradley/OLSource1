---
title: "MSBuild Tasks Specific to Visual C++"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, tasks specific to Visual C++"
ms.assetid: 05410f0c-7356-4692-bc00-20664421c9ff
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Tasks Specific to Visual C++
Tasks provide the code that runs during the build process. When Visual C++ is installed, the following tasks are available, in addition to those that are installed with [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)]. For more information, see [MSBuild (Visual C++) Overview](../vs140/msbuild--visual-c----overview.md).  
  
 In addition to the parameters for each task, every task also has the following parameters.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`Condition`|Optional `String` parameter.\<br />\<br /> A `Boolean` expression that the [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] engine uses to determine whether this task will be executed. For information about the conditions that are supported by [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)], see [MSBuild Conditions](../vs140/msbuild-conditions.md).|  
|`ContinueOnError`|Optional parameter. Can contain one of the following values:\<br />\<br /> -   **WarnAndContinue** or **true**. When a task fails, subsequent tasks in the [Target](../vs140/target-element--msbuild-.md) element and the build continue to execute, and all errors from the task are treated as warnings\<br />-   **ErrorAndContinue**. When a task fails, subsequent tasks in the `Target` element and the build continue to execute, and all errors from the task are treated as errors.\<br />-   **ErrorAndStop** or **false** (default). When a task fails, the remaining tasks in the`Target` element and the build aren't executed, and the entire `Target` element and the build are considered to have failed.\<br />\<br /> Versions of the .NET Framework before 4.5 supported only the `true` and `false` values.\<br />\<br /> For more information, see [How to: Ignore Errors in Tasks](../vs140/how-to--ignore-errors-in-tasks.md).|  
  
## Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[BscMake Task](../vs140/bscmake-task.md)|Wraps the Microsoft Browse Information Maintenance Utility tool (bscmake.exe).|  
|[CL Task](../vs140/cl-task.md)|Wraps the Visual C++ compiler tool (cl.exe).|  
|[CPPClean Task](../vs140/cppclean-task.md)|Deletes the temporary files that MSBuild creates when a Visual C++ project is built.|  
|[LIB Task](../vs140/lib-task.md)|Wraps the Microsoft 32-Bit Library Manager tool (lib.exe).|  
|[Link Task](../vs140/link-task.md)|Wraps the Visual C++ linker tool (link.exe).|  
|[MIDL Task](../vs140/midl-task.md)|Wraps the Microsoft Interface Definition Language (MIDL) compiler tool (midl.exe).|  
|[MT Task](../vs140/mt-task.md)|Wraps the Microsoft Manifest Tool (mt.exe).|  
|[RC Task](../vs140/rc-task.md)|Wraps the Microsoft Windows Resource Compiler tool (rc.exe).|  
|[SetEnv Task](../vs140/setenv-task.md)|Sets or deletes the value of a specified environment variable.|  
|[VCMessage Task](../vs140/vcmessage-task.md)|Logs warning messages and error messages during a build.|  
|[XDCMake Task](../vs140/xdcmake-task.md)|Wraps the XML Documentation tool (xdcmake.exe), which merges XML document comment (.xdc) files into an .xml file.|  
|[XSD Task](../vs140/xsd-task.md)|Wraps the XML Schema Definition tool (xsd.exe), which generates schema or class files from a source.|  
|[MSBuild Reference](../vs140/msbuild-reference.md)|Describes the elements of the MSBuild system.|  
|[MSBuild Tasks](../vs140/msbuild-tasks.md)|Describes tasks, which are units of code that can be combined to produce a build.|  
|[Task Writing](../vs140/task-writing.md)|Describes how to create a task.|