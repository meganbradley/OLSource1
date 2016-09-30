---
title: "Move Task"
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
  - "MSBuild, Move task"
  - "Move task [MSBuild]"
ms.assetid: d1405347-1309-4f18-b565-905408093d59
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Move Task
Moves files to a new location.  
  
## Parameters  
 The folowing table describes the parameters of the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>2\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Specifies the list of files to move the source files to. This list is expected to be a one-to-one mapping to the list that is specified in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter. That is, the first file specified in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> will be moved to the first location specified in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, and so forth.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*> parameter.\<br />\<br /> Specifies the directory to which you want to move the files.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>8\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Contains the items that were successfully moved.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter.\<br />\<br /> If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, overwrites files even if they are marked as read-only files.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Required \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the files to move.|  
  
## Remarks  
 Either the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> parameter or the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameter must be specified, but not both. If both are specified, the task fails and an error is logged.  
  
 In addition to having the parameters that are listed in the table, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../vs140/taskextension-base-class.md).  
  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)