---
title: "UnregisterAssembly Task"
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
  - http://schemas.microsoft.com/developer/msbuild/2003#UnregisterAssembly
dev_langs: 
  - VB
  - CSharp
  - C++
  - jsharp
helpviewer_keywords: 
  - MSBuild, UnregisterAssembly task
  - UnregisterAssembly task [MSBuild]
ms.assetid: 04f549dd-3591-4dda-9c3a-cf6ede9df2c3
caps.latest.revision: 25
translation.priority.ht: 
  - de-de
  - ja-jp
---
# UnregisterAssembly Task
Unregisters the specified assemblies for COM interop purposes. Performs the reverse of the [RegisterAssembly task](../vs140/registerassembly-task.md).  
  
## Parameters  
 The following table describes the parameters of the `UnregisterAssembly` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`Assemblies`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` parameter.<br /><br /> Specifies the assemblies to be unregistered.|  
|`AssemblyListFile`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False> parameter.<br /><br /> Contains information about the state between the `RegisterAssembly` task and the `UnregisterAssembly` task. This prevents the task from attempting to unregister an assembly that failed to register in the `RegisterAssembly` task.<br /><br /> If this parameter is specified, the `Assemblies` and `TypeLibFiles` parameters are ignored.|  
|`TypeLibFiles`|Optional <xref:Microsoft.Build.Framework.ITaskItem?qualifyHint=False>`[]` output parameter.<br /><br /> Unregisters the specified type library from the specified assembly. **Note:**  This parameter is only necessary if the type library file name is different than the assembly name.|  
  
## Remarks  
 It is not required that the assembly exists for this task to be successful. If you attempt to unregister an assembly that does not exist, the task will succeed with a warning. This occurs because it is the job of this task to remove the assembly registration from the registry. If the assembly does not exist, it is not in the registry, and therefore, the task succeeded.  
  
 In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.AppDomainIsolatedTaskExtension?qualifyHint=False> class, which itself inherits from the <xref:System.MarshalByRefObject?qualifyHint=False> class. The `MarshalByRefObject` class provides the same functionality as the <xref:Microsoft.Build.Utilities.Task?qualifyHint=False> class, but it can be instantiated in its own application domain.  
  
## Example  
 The following example uses the `UnregisterAssembly` task to unregister the assembly at the path specified by the `OutputPath` and `FileName` properties, if it exists.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
    <PropertyGroup>  
        <OutputPath>\Output\</OutputPath>  
        <FileName>MyFile.dll</FileName>  
    </PropertyGroup>  
    <Target Name="UnregisterAssemblies">  
        <UnregisterAssembly  
            Condition="Exists('$(OutputPath)$(FileName)')"  
            Assemblies="$(OutputPath)$(FileName)" />  
    </Target>  
  
</Project>  
```  
  
## See Also  
 [RegisterAssembly Task](../vs140/registerassembly-task.md)   
 [MSBuild Tasks](../vs140/msbuild-tasks.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)