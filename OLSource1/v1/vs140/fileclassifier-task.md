---
title: "FileClassifier Task"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - VB
  - CSharp
  - C++
  - jsharp
helpviewer_keywords: 
  - classifying a resource set to embed in an assembly [WPF MSBuild]
  - non-localizable resources [WPF MSBuild], classifying to embed in an assembly
  - FileClassifier task [WPF MSBuild]
ms.assetid: 14e03310-fcc0-4bb2-a84d-cda12be66367
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# FileClassifier Task
The <xref:Microsoft.Build.Tasks.Windows.FileClassifier?qualifyHint=False> task classifies a set of source resources as those that will be embedded into an assembly. If a resource is not localizable, it is embedded into the main application assembly; otherwise, it is embedded into a satellite assembly.  
  
## Task Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`CLREmbeddedResource`|Unused.|  
|`CLRResourceFiles`|Unused.|  
|`CLRSatelliteEmbeddedResource`|Unused.|  
|`Culture`|Optional **String** parameter.<br /><br /> Specifies the culture for the build. This value can be **null** if the build is non-localizable. If **null**, the default value is the lowercase value that **CultureInfo.InvariantCulture** returns.|  
|`MainEmbeddedFiles`|Optional **ITaskItem[]** output parameter.<br /><br /> Specifies the non-localizable resources that are embedded into the main assembly.|  
|`OutputType`|Required **String** parameter.<br /><br /> Specifies the type of file to embed the specified source files into. The valid values are **exe**, **winexe**, or **library**.|  
|`SatelliteEmbeddedFiles`|Optional **ITaskItem[]** output parameter.<br /><br /> Specifies the localizable files that are embedded into the satellite assembly for the culture specified by the **Culture** parameter.|  
|`SourceFiles`|Required **ITaskItem[]** parameter.<br /><br /> Specifies the list of files to classify.|  
  
## Remarks  
 If the **Culture** parameter is not set, all resources that are specified by using the **SourceFiles** parameter are non-localizable; otherwise, they are localizable, unless they are associated with a **Localizable** attribute that is set to **false**.  
  
## Example  
 The following example classifies a single source file as a resource and then embeds it in a satellite assembly for the French-Canadian (fr-CA) culture.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
  <UsingTask  
    TaskName="Microsoft.Build.Tasks.Windows.FileClassifier"   
    AssemblyFile="C:\Program Files\Reference Assemblies\Microsoft\Framework\v3.0\PresentationBuildTasks.dll" />  
  <ItemGroup>  
    <Resource Include="Resource1.bmp" />  
  </ItemGroup>  
  <Target Name="FileClassifierTask">  
    <FileClassifier  
      SourceFiles="Resource1.bmp"  
      Culture="fr-CA"  
      OutputType="exe" />  
  </Target>  
</Project>  
```  
  
## See Also  
 [WPF MSBuild Reference](../vs140/wpf-msbuild-reference.md)   
 [WPF MSBuild Task Reference](../vs140/wpf-msbuild-task-reference.md)   
 [MSBuild Reference](../vs140/msbuild-reference.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)   
 [Building a WPF Application (WPF)](assetId:///a58696fd-bdad-4b55-9759-136dfdf8b91c)