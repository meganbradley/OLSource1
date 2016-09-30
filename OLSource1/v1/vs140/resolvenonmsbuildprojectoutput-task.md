---
title: "ResolveNonMSBuildProjectOutput Task"
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
  - "MSBuild, ResolveNonMSBuildProjectOutput task"
  - "ResolveNonMSBuildProjectOutput task [MSBuild]"
ms.assetid: a0b8fcec-8c8d-4867-85ac-5304c5108e5e
caps.latest.revision: 6
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ResolveNonMSBuildProjectOutput Task
Determines the output files for non-MSBuild project references.  
  
## Parameters  
 The following table describes the parameters of the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies an XML string that contains resolved project outputs.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Required \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the project references.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>6\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Contains the list of resolved reference paths (and preserves the original project reference attributes).|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>8\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Contains the list of project reference items that could not be resolved by using the preresolved list of outputs.\<br />\<br /> Because Visual Studio only preresolves non-MSBuild projects, this means that project references in this list are in the MSBuild format.|  
  
## Remarks  
 In addition to having the parameters that are listed in the table, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../vs140/taskextension-base-class.md).  
  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)