---
title: "ResourcesGenerator Task"
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
  - "embedding resources into a .resources file [WPF MSBuild]"
  - "ResourcesGenerator task [WPF MSBuild]"
  - "ResourcesGenerator task [WPF MSBuild], parameters"
ms.assetid: e782bbac-9ee6-472b-8171-3ee008c77b4e
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ResourcesGenerator Task
The \<xref:Microsoft.Build.Tasks.Windows.ResourcesGenerator*> task embeds one or more resources (.jpg, .ico, .bmp, [!INCLUDE[TLA2#tla_xaml](../vs140/includes/tla2sharptla_xaml_md.md)] in binary format, and other extension types) into a .resources file.  
  
## Task Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`OutputPath`|Required **String** parameter.<br /><br /> Specifies the path of the output directory. If the path is not an absolute path, it is treated as a path that is relative to the root project directory.|  
|`OutputResourcesFile`|Required **ITaskItem[]** output parameter.<br /><br /> Specifies the path and name of the generated .resources file. If the path is not an absolute path, the .resources file is generated relative to the root project directory.|  
|`ResourcesFiles`|Required **ITaskItem[]** parameter.<br /><br /> Specifies one or more resources to embed in the generated .resources file.|  
  
## Example  
 The following example generates a .resources file with a single .bmp resource. The .bmp resource is generated to a directory that is relative to the project root directory.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
  <UsingTask   
    TaskName="Microsoft.Build.Tasks.Windows.ResourcesGenerator"   
    AssemblyFile="C:\Program Files\Reference Assemblies\Microsoft\Framework\v3.0\PresentationBuildTasks.dll" />  
  <Target Name="ResourcesGeneratorTask">  
    <ResourcesGenerator  
      ResourceFiles="Resource1.bmp"  
      OutputPath="myresources"  
      OutputResourcesFile="myresources\my.resources" />  
  </Target>  
</Project>  
```  
  
## See Also  
 [WPF MSBuild Reference](../vs140/wpf-msbuild-reference.md)   
 [WPF MSBuild Task Reference](../vs140/wpf-msbuild-task-reference.md)   
 [MSBuild Reference](../vs140/msbuild-reference.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)   
 [Building a WPF Application (WPF)](assetId:///a58696fd-bdad-4b55-9759-136dfdf8b91c)