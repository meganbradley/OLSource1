---
title: "AssignTargetPath Task"
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
ms.assetid: 0e830e31-3bcf-4259-b2a8-a5df49b92d51
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AssignTargetPath Task
This task accepts a list files and adds <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> attributes if they are not already specified.  
  
## Task Parameters  
 The following table describes the parameters of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> input parameter.\<br />\<br /> Contains the path to the folder that contains the target links.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>6\</CodeContentPlaceHolder> input parameter.\<br />\<br /> Contains the incoming list of files.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Optional\<br />\<br /> \<xref:Microsoft.Build.Framework.ITaskItem*> <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Contains the resulting list of files.|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../vs140/taskextension-base-class.md).  
  
## Example  
 The following example executes the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> task to configure a project.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)