---
title: "CombinePath Task"
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
  - "MSBuild, CombinePath task"
  - "CombinePath task [MSBuild]"
ms.assetid: c20edbf4-3d4f-4f66-b1d5-753a0d858ed8
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CombinePath Task
Combines the specified paths into a single path.  
  
## Task Parameters  
 The following table describes the parameters of the [CombinePath Task](../vs140/combinepath-task.md).  
  
|Parameter|Description|  
|---------------|-----------------|  
|`BasePath`|Required `String` parameter.<br /><br /> The base path to combine with the other paths. Can be a relative path, absolute path, or blank.|  
|`Paths`|Required <xref:Microsoft.Build.Framework.ITaskItem*>`[]` parameter.<br /><br /> A list of individual paths to combine with the BasePath to form the combined path. Paths can be relative or absolute.|  
|`CombinedPaths`|Optional <xref:Microsoft.Build.Framework.ITaskItem*>`[]` output parameter.<br /><br /> The combined path that is created by this task.|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../vs140/taskextension-base-class.md).  
  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)