---
title: "FindAppConfigFile Task"
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
  - "FindAppConfigFile task [MSBuild]"
  - "MSBuild, FindAppConfigFile task"
ms.assetid: e292de3e-7482-4426-83ce-d921061808bf
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FindAppConfigFile Task
Finds the app.config file, if any, in the provided lists.  
  
## Parameters  
 The following table describes the parameters of the `FindAppConfigFile` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`AppConfigFile`|Optional <xref:Microsoft.Build.Framework.ITaskItem*>`[]` output parameter.<br /><br /> Specifies the first matching item found in the list, if any.|  
|`PrimaryList`|Required <xref:Microsoft.Build.Framework.ITaskItem*>`[]` parameter.<br /><br /> Specifies the primary list to search through.|  
|`SecondaryList`|Required <xref:Microsoft.Build.Framework.ITaskItem*>`[]` parameter.<br /><br /> Specifies the secondary list to search through.|  
|`TargetPath`|Required `String` parameter.<br /><br /> Specifies the value to add as metadata.|  
  
## Remarks  
 In addition to having the parameters that are listed in the table, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../VS_csharp/taskextension-base-class.md).  
  
## See Also  
 [MSBuild Tasks](../VS_csharp/msbuild-tasks.md)   
 [MSBuild Task Reference](../VS_csharp/msbuild-task-reference.md)