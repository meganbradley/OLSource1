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
 The following table describes the parameters of the `GetFrameworkPath` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`FrameworkVersion11Path`|Optional `String` output parameter.<br /><br /> Contains the path to the framework version 1.1 assemblies, if present. Otherwise returns `null`.|  
|`FrameworkVersion20Path`|Optional `String` output parameter.<br /><br /> Contains the path to the framework version 2.0 assemblies, if present. Otherwise returns `null`.|  
|`FrameworkVersion30Path`|Optional `String` output parameter.<br /><br /> Contains the path to the framework version 3.0 assemblies, if present. Otherwise returns `null`.|  
|`FrameworkVersion35Path`|Optional `String` output parameter.<br /><br /> Contains the path to the framework version 3.5 assemblies, if present. Otherwise returns `null`.|  
|`FrameworkVersion40Path`|Optional `String` output parameter.<br /><br /> Contains the path to the framework version 4.0 assemblies, if present. Otherwise returns `null`.|  
|`Path`|Optional `String` output parameter.<br /><br /> Contains the path to the latest framework assemblies, if any are available. Otherwise returns `null`.|  
  
## Remarks  
 If several versions of the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] are installed, this task returns the version that [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] is designed to run on.  
  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension*> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task*> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../vs140/taskextension-base-class.md).  
  
## Example  
 The following example uses the `GetFrameworkPath` task to store the path to the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] in the `FrameworkPath` property.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
    <Target Name="GetPath">  
        <GetFrameworkPath>  
            <Output  
                TaskParameter="Path"  
                PropertyName="FrameworkPath" />  
        </GetFrameworkPath>  
    </Target>  
</Project>  
```  
  
## See Also  
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)