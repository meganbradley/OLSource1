---
title: "Warning Task"
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
  - "http://schemas.microsoft.com/developer/msbuild/2003#Warning"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "Warning task [MSBuild]"
  - "MSBuild, Warning task"
ms.assetid: 96ba5507-8b43-4f54-a1d7-9b15644dd56c
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Warning Task
Logs a warning during a build based on an evaluated conditional statement.  
  
## Parameters  
 The folowing table describes the parameters of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter.\<br />\<br /> The warning code to associate with the warning.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the relevant file, if any. If no file is provided, the file containing the Warning task is used.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter.\<br />\<br /> The Help keyword to associate with the warning.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter.\<br />\<br /> The warning text that [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] logs if the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter evaluates to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.|  
  
## Remarks  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> task allows [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] projects to check for the presence of a required configuration or property before proceeding with the next build step.  
  
 If the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameter of the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> task evaluates to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, the value of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> parameter is logged and the build continues to execute. If a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> parameter does not exisit, the warning text is logged. For more information on logging, see [MSBuild Logging](../vs140/obtaining-build-logs-with-msbuild.md).  
  
 In addition to the parameters listed above, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../vs140/taskextension-base-class.md).  
  
## Example  
 The following code example checks for properties that are set on the command line. If there are no properties set, the project raises a warning event, and logs the value of the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> parameter of the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> task.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Logging](../vs140/obtaining-build-logs-with-msbuild.md)   
 [MSBuild File Format](../vs140/msbuild-project-file-schema-reference.md)