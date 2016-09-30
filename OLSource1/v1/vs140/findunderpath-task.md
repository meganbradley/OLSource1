---
title: "FindUnderPath Task"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "http://schemas.microsoft.com/developer/msbuild/2003#FindUnderPath"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, FindUnderPath task"
  - "FindUnderPath task [MSBuild]"
ms.assetid: 3c6d58b0-36e8-47aa-bfca-b73dd2045d91
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FindUnderPath Task
Determines which items in the specified item collection have paths that are in or below the specified folder.  
  
## Parameters  
 The following table describes the parameters of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the files whose paths should be compared with the path specified by the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>6\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Contains the items that were found under the specified path.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>8\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Contains the items that were not found under the specified path.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Required \<xref:Microsoft.Build.Framework.ITaskItem*> parameter.\<br />\<br /> Specifies the folder path to use as the reference.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter.\<br />\<br /> If true, the paths of the output items are updated to be absolute paths.|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../vs140/taskextension-base-class.md).  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> task to determine if the files contained in the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> item have paths that exist under the path specified by the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> property. After the task completes, the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> item contains the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> file, and the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> item contains the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> file.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)   
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Concepts](../vs140/msbuild-concepts.md)