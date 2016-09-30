---
title: "CallTarget Task"
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
  - "CallTarget task [MSBuild]"
  - "MSBuild, CallTarget task"
ms.assetid: bb1fe2c4-4383-436f-8326-c24cc4a46150
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CallTarget Task
Invokes the specified targets within the project file.  
  
## Task Parameters  
 The following table describes the parameters of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> output parameter.\<br />\<br /> If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] engine is called once per target. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] engine is called once to build all targets. The default value is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Optional \<xref:Microsoft.Build.Framework.ITaskItem*><CodeContentPlaceHolder>8\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Contains the outputs of all built targets.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the target or targets to build.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter.\<br />\<br /> If <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, the cached result is returned if present.\<br />\<br /> **Note** When an MSBuild task is run, its output is cached in a scope (ProjectFileName, GlobalProperties)[TargetNames] as a list of build items.|  
  
## Remarks  
 If a target specified in <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> fails and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, the task continues to build the remaining targets.  
  
 If you want to build the default targets, use the [MSBuild Task](../vs140/msbuild-task.md) and set the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> parameter equal to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 In addition to the parameters listed above, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../vs140/taskextension-base-class.md).  
  
## Example  
 The following example calls <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> from inside <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)   
 [MSBuild Targets](../vs140/msbuild-targets.md)