---
title: "GetFrameworkPath Task"
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
  - "http://schemas.microsoft.com/developer/msbuild/2003#GetFrameworkPath"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "GetFrameworkPath task [MSBuild]"
  - "MSBuild, GetFrameworkPath task"
ms.assetid: 5b7bcdd7-d4a0-442d-af29-8aadb3b10598
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# GetFrameworkPath Task
Retrieves the path to the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] assemblies.  
  
## Task Parameters  
 The following table describes the parameters of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Contains the path to the framework version 1.1 assemblies, if present. Otherwise returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Contains the path to the framework version 2.0 assemblies, if present. Otherwise returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Contains the path to the framework version 3.0 assemblies, if present. Otherwise returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Contains the path to the framework version 3.5 assemblies, if present. Otherwise returns <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Contains the path to the framework version 4.0 assemblies, if present. Otherwise returns <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> output parameter.\<br />\<br /> Contains the path to the latest framework assemblies, if any are available. Otherwise returns <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.|  
  
## Remarks  
 If several versions of the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] are installed, this task returns the version that [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] is designed to run on.  
  
 In addition to the parameters listed above, this task inherits parameters from the \<xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the \<xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../vs140/taskextension-base-class.md).  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> task to store the path to the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] in the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> property.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)