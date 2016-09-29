---
title: "TaskBody Element (MSBuild)"
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
  - "TaskBody element [MSBuild]"
  - "<TaskBody> element [MSBuild]"
ms.assetid: 49d8741b-f1ea-4470-94fd-a1ac27341a6a
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# TaskBody Element (MSBuild)
Contains the data that is passed to a `UsingTask``TaskFactory`. For more information, see [UsingTask](../VS_csharp/usingtask-element--msbuild-.md).  
  
 <Project\>  
 <UsingTask\>  
 <TaskBody\>  
  
## Syntax  
  
```  
<TaskBody Evaluate="true/false" />  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|`Evaluate`|Optional Boolean attribute.<br /><br /> If `true`, MSBuild evaluates any inner elements, and expands items and properties before it passes the information to the `TaskFactory` when the task is instantiated.|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|Data|The text between the `TaskBody` tags is sent verbatim to the `TaskFactory`.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[UsingTask](../VS_csharp/usingtask-element--msbuild-.md)|Provides a way to register tasks in [!INCLUDE[vstecmsbuild](../VS_csharp/includes/vstecmsbuild_md.md)]. There may be zero or more `UsingTask` elements in a project.|  
  
## Example  
 The following example shows how to use the `TaskBody` element with an `Evaluate` attribute.  
  
```  
<UsingTask TaskName="MyTask" AssemblyName="My.Assembly" TaskFactory="MyTaskFactory">  
       <ParameterGroup>  
              <Parameter1 ParameterType="System.String" Required="False" Output="False"/>  
              <Parameter2 ParameterType="System.Int" Required="True" Output="False"/>  
              ...  
</ParameterGroup>  
       <TaskBody Evaluate="true">  
      ... Task factory-specific data ...  
       </TaskBody>  
</UsingTask>  
```  
  
## See Also  
 [MSBuild Tasks](../VS_csharp/msbuild-tasks.md)   
 [MSBuild Task Reference](../VS_csharp/msbuild-task-reference.md)   
 [MSBuild File Format](../VS_csharp/msbuild-project-file-schema-reference.md)