---
title: "FormatUrl Task"
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
  - "MSBuild, FormatUrl task"
  - "FormatUrl task [MSBuild]"
ms.assetid: 81114b67-520f-43b5-8891-224f68a78516
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FormatUrl Task
Converts a URL to a correct URL format.  
  
## Parameters  
 The following table describes the parameters of the `FormatUrl` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`InputUrl`|Optional `String` parameter.<br /><br /> Specifies the URL to format.|  
|`OutputUrl`|Optional `String` output parameter.<br /><br /> Specifies the formatted URL.|  
  
## Remarks  
 In addition to the having the parameters that are listed in the table, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../VS_csharp/taskextension-base-class.md).  
  
## See Also  
 [MSBuild Tasks](../VS_csharp/msbuild-tasks.md)   
 [MSBuild Task Reference](../VS_csharp/msbuild-task-reference.md)