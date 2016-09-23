---
title: "CreateProperty Task"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - http://schemas.microsoft.com/developer/msbuild/2003#CreateProperty
dev_langs: 
  - VB
  - CSharp
  - C++
  - jsharp
helpviewer_keywords: 
  - CreateProperty task [MSBuild]
  - MSBuild, CreateProperty task
ms.assetid: fbc31a88-62d4-43d2-b739-68ef3fac38f5
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CreateProperty Task
Populates properties with the values passed in. This allows values to be copied from one property or string to another.  
  
## Attributes  
 The following table describes the parameters of the `CreateProperty` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`Value`|Optional `String` output parameter.<br /><br /> Specifies the value to copy to the new property.|  
|`ValueSetByTask`|Optional `String` output parameter.<br /><br /> Contains the same value as the `Value` parameter. Use this parameter only when you want to avoid having the output property set by [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] when it skips the enclosing target because the outputs are up-to-date.|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension?qualifyHint=False> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task?qualifyHint=False> class. For a list of these additional parameters and their descriptions, see [TaskExtension Base Class](../vs140/taskextension-base-class.md).  
  
## Example  
 The following example uses the `CreateProperty` task to create the `NewFile` property using the combination of the values of the `SourceFilename` and `SourceFileExtension` property.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
  
    <PropertyGroup>  
        <SourceFilename>Module1</SourceFilename>  
        <SourceFileExtension>vb</SourceFileExtension>  
    </PropertyGroup>  
  
    <Target Name="CreateProperties">  
  
        <CreateProperty  
            Value="$(SourceFilename).$(SourceFileExtension)">  
            <Output  
                TaskParameter="Value"  
                PropertyName="NewFile" />  
        </CreateProperty>  
  
    </Target>  
  
</Project>  
```  
  
 After running the project, the value of the `NewFile` property is `Module1.vb`.  
  
## See Also  
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)   
 [MSBuild Tasks](../vs140/msbuild-tasks.md)