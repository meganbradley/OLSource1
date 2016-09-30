---
title: "Message Task"
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
  - "http://schemas.microsoft.com/developer/msbuild/2003#Message"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild, Message task"
  - "Message task [MSBuild]"
ms.assetid: 2293309d-42b6-46dc-9684-8c146f66bc28
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Message Task
Logs a message during a build.  
  
## Parameters  
 The folowing table describes the parameters of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter.\<br />\<br /> Specifies the importance of the message. This parameter can have a value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The default value is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter.\<br />\<br /> The error text to log.|  
  
## Remarks  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> task allows [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] projects to issue messages to loggers at different steps in the build process.  
  
 If the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter evaluates to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, the value of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameter will be logged and the build will continue to execute. If a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> parameter does not exist, the message text is logged. For more information on logging, see [MSBuild Logging](../vs140/obtaining-build-logs-with-msbuild.md).  
  
 By default, the message is sent to the MSBuild console logger. This can be changed by setting the \<xref:Microsoft.Build.Tasks.TaskExtension.Log*> parameter. The logger interprets the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameter.  
  
 In addition to the parameters listed above, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../vs140/taskextension-base-class.md).  
  
## Example  
 The following code example logs messages to all registered loggers.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)   
 [MSBuild Logging](../vs140/obtaining-build-logs-with-msbuild.md)