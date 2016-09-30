---
title: "AssignCulture Task"
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
  - "http://schemas.microsoft.com/developer/msbuild/2003#AssignCulture"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, AssignCulture task"
  - "AssignCulture task [MSBuild]"
ms.assetid: 8f8314cc-82a6-4f16-a62d-b9f0d1d5e274
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AssignCulture Task
This task accepts a list of items that may contain a valid .NET culture identifier string as part of the file name, and produces items that have a metadata named <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> containing the corresponding culture identifier. For example, the file name Form1.fr-fr.resx has an embedded culture identifier "fr-fr", so this task will produce an item that has the same filename with the metadata <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> equal to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. The task also produces a list of filenames with the culture removed from the filename.  
  
## Task Parameters  
 The following table describes the parameters of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>6\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Contains the list of items received in the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter, with a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> metadata entry added to each item.\<br />\<br /> If the incoming item from the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter already contains a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> metadata entry, the original metadata entry is used.\<br />\<br /> The task only assigns a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> metadata entry if the file name contains a valid culture identifier. The culture identifier must be between the last two dots in the filename.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>13\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Contains the subset of the items from the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> parameter that have a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> metadata entry.|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>17\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Contains the subset of the items from the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> parameter that do not have a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> metadata entry.|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>21\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Contains the same list of items that is produced in the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> parameter, except with the culture removed from the file name.\<br />\<br /> The task only removes the culture from the file name if it is a valid culture identifier.|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Required \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>24\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the list of files with embedded culture names to assign a culture to.|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../vs140/taskextension-base-class.md).  
  
## Example  
 The following example executes the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> task with the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> item collection.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following table describes the value of the output items after task execution. Item metadata is shown in parenthesis after the item.  
  
|Item collection|Contents|  
|---------------------|--------------|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> (no additional metadata)|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder> (no additional metadata)|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>no additional metadata)|  
  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)