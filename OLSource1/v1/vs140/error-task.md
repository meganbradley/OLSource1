---
title: "Error Task"
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
  - "http://schemas.microsoft.com/developer/msbuild/2003#Error"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "Error task [MSBuild]"
  - "MSBuild, Error task"
ms.assetid: e96a90ee-a8ae-4e5b-8ef2-b5cf5fedd8b2
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Error Task
Stops a build and logs an error based on an evaluated conditional statement.  
  
## Parameters  
 The folowing table describes the parameters of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter.\<br />\<br /> The error code to associate with the error.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter.\<br />\<br /> The name of the file that contains the error. If no file name is provided, the file containing the Error task will be used.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter.\<br />\<br /> The Help keyword to associate with the error.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter.\<br />\<br /> The error text that [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] logs if the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter evaluates to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.|  
  
## Remarks  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> task allows [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] projects issue error text to loggers and stop build execution.  
  
 If the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameter evaluates to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, the build is stopped, and an error is logged. If a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameter does not exist, the error is logged and build execution stops. For more information on logging, see [MSBuild Logging](../vs140/obtaining-build-logs-with-msbuild.md).  
  
 In addition to the parameters listed above, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../vs140/taskextension-base-class.md).  
  
## Example  
 The following code example verifies that all required properties are set. If they are not set, the project raises an error event, and logs the value of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> parameter of the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> task.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)   
 [MSBuild Logging](../vs140/obtaining-build-logs-with-msbuild.md)