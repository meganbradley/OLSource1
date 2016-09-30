---
title: "Touch Task"
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
  - "http://schemas.microsoft.com/developer/msbuild/2003#Touch"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, Touch task"
  - "Touch task [MSBuild]"
ms.assetid: 8a978645-1393-4904-ae69-42afabd8c109
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Touch Task
Sets the access and modification times of files.  
  
## Parameters  
 The following table describes the parameters of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter.\<br />\<br /> If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, creates any files that do not already exist.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Required \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the collection of files to touch.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter.\<br />\<br /> If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, forces a file touch even if the files are read-only.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies a time other than the current time. The format must be a format that is acceptable to the \<xref:System.DateTime.Parse*> method.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>13\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Contains the collection of items that were successfully touched.|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../vs140/taskextension-base-class.md).  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> task to change the access and modification times of the files specified in the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> item collection, and puts the list of successfully touched files in the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> item collection.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)