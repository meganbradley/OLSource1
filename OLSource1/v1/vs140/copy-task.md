---
title: "Copy Task"
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
  - "http://schemas.microsoft.com/developer/msbuild/2003#Copy"
  - "MSBuild.Copy.SourceFileNotFound"
  - "MSBuild.Copy.Retrying"
  - "MSBuild.Copy.ExceededRetries"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, Copy task"
  - "Copy task [MSBuild]"
ms.assetid: a46ba9da-3e4e-4890-b4ea-09a099b6bc40
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Copy Task
Copies files to a new location in the file system.  
  
## Parameters  
 The following table describes the parameters of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>4\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Contains the items that were successfully copied.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the list of files to copy the source files to. This list is expected to be a one-to-one mapping with the list specified in the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter. That is, the first file specified in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> will be copied to the first location specified in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, and so forth.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*> parameter.\<br />\<br /> Specifies the directory to which you want to copy the files. This must be a directory, not a file. If the directory does not exist, it is created automatically.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter.\<br />\<br /> Overwrite files even if they are marked as read only files|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies how many times to attempt to copy, if all previous attempts have failed. Defaults to zero.\<br />\<br /> **Note:** The use of retries can mask a synchronization problem in your build process.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the delay between any necessary retries. Defaults to the RetryDelayMillisecondsDefault argument, which is passed to the CopyTask constructor.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> parameter.\<br />\<br /> If <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, skips the copying of files that are unchanged between the source and destination. The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> task considers files to be unchanged if they have the same size and the same last modified time. **Note:**  If you set this parameter to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, you should not use dependency analysis on the containing target, because that only runs the task if the last-modified times of the source files are newer than the last-modified times of the destination files.|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Required \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>23\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the files to copy.|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> parameter.\<br />\<br /> If <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, creates Hard Links for the copied files instead of copying the files.|  
  
## Warnings  
 Warnings are logged, including:  
  
-   <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  
## Remarks  
 Either the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> or the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> parameter must be specified, but not both. If both are specified, the task fails and an error is logged.  
  
 In addition to the parameters listed above, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../vs140/taskextension-base-class.md).  
  
## Example  
 The following example copies the items in the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> item collection into the folder c:\MyProject\Destination.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following example demonstrates how to do a recursive copy. This project copies all of the files recursively from c:\MySourceTree into c:\MyDestinationTree, while maintaining the directory structure.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)