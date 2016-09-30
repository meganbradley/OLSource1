---
title: "GetFrameworkSdkPath Task"
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
  - "http://schemas.microsoft.com/developer/msbuild/2003#GetFrameworkSdkPath"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "GetFrameworkSdkPath task [MSBuild]"
  - "MSBuild, GetFrameworkSdkPath task"
ms.assetid: 2ef82b98-02b6-40cf-a9b5-f0e882fb5064
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# GetFrameworkSdkPath Task
Retrieves the path to the [!INCLUDE[winsdklong](../vs140/includes/winsdklong_md.md)].  
  
## Task Parameters  
 The following table describes the parameters of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> read-only output parameter.\<br />\<br /> Returns the path to the .NET SDK version 2.0, if present. Otherwise returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> read-only output parameter.\<br />\<br /> Returns the path to the .NET SDK version 3.5, if present. Otherwise returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> read-only output parameter.\<br />\<br /> Returns the path to the .NET SDK version 4.0, if present. Otherwise returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Contains the path to the latest .NET SDK, if any version is present. Otherwise returns <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../vs140/taskextension-base-class.md).  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> task to store the path to the [!INCLUDE[winsdkshort](../vs140/includes/winsdkshort_md.md)] in the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> property.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)