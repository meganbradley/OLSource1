---
title: "FindInList Task"
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
  - "FindInList task [MSBuild]"
  - "MSBuild, FindInList task"
ms.assetid: d49b9f84-52a2-4242-9269-b741a7a7e9f7
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FindInList Task
In a specified list, finds an item that has the matching itemspec.  
  
## Parameters  
 The following table describes the parameters of the [FindInList Task](../vs140/findinlist-task.md).  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> parameter.\<br />\<br /> If <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, the search is case-sensitive; otherwise, it is not. Default value is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter.\<br />\<br /> If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, return the last match; otherwise, return the first match. Default value is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>9\</CodeContentPlaceHolder> read-only output parameter.\<br />\<br /> The first matching item found in the list, if any.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Required <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter.\<br />\<br /> The itemspec to search for.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Required \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameter.\<br />\<br /> The list in which to search for the itemspec.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameter.\<br />\<br /> If <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, match against just the file name part of the itemspec; otherwise, match against the whole itemspec. Default value is <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../vs140/taskextension-base-class.md).  
  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)