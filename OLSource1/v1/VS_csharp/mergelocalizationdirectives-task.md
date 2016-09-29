---
title: "MergeLocalizationDirectives Task"
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
  - "localizing XAML [WPF MSBuild], moving comments and attributes to a separate file"
  - "MergeLocalizationDirectives task [WPF MSBuild], parameters"
  - "MergeLocalizationDirectives task [WPF MSBuild]"
  - "moving localization comments and attributes to a separate file [WPF MSBuild]"
ms.assetid: 9095b4f1-88da-4194-914b-ee1456826830
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MergeLocalizationDirectives Task
The <xref:Microsoft.Build.Tasks.Windows.MergeLocalizationDirectives*> task merges the localization attributes and comments of one or more [!INCLUDE[TLA2#tla_xaml](../VS_csharp/includes/tla2sharptla_xaml_md.md)] binary format files into a single file for the whole assembly.  
  
## Task Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`GeneratedLocalizationFiles`|Required **ITaskItem[]** parameter.<br /><br /> Specifies the list of localization directives files for individual files in [!INCLUDE[TLA2#tla_xaml](../VS_csharp/includes/tla2sharptla_xaml_md.md)] binary format.|  
|`OutputFile`|Required **String** output parameter.<br /><br /> Specifies the output path of the compiled localization-directives assembly.|  
  
## Remarks  
 You can add localization attributes and comments to [!INCLUDE[TLA#tla_xaml](../VS_csharp/includes/tlasharptla_xaml_md.md)] content. With [!INCLUDE[TLA#tla_wpf](../VS_csharp/includes/tlasharptla_wpf_md.md)] localization support, you can strip out localization attributes and comments, and put them in a .loc file that is separate from the generated assembly. You can do this by using the **LocalizationPropertyStorage** attribute. For more information about localization attributes and comments, and **LocalizationPropertyStorage**, see [Localization Attributes and Comments](assetId:///ead2d9ac-b709-4ec1-a924-39927a29d02f).  
  
## Example  
 The following example merges the localization comments of several [!INCLUDE[TLA2#tla_xaml](../VS_csharp/includes/tla2sharptla_xaml_md.md)] binary format files into a single .loc file.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
  <UsingTask   
    TaskName="Microsoft.Build.Tasks.Windows.MergeLocalizationDirectives"   
    AssemblyFile="C:\Program Files\Reference Assemblies\Microsoft\Framework\v3.0\PresentationBuildTasks.dll" />  
  <Target Name="MergeLocalizationDirectivesTask">  
    <MergeLocalizationDirectives   
      GeneratedLocalizationFiles="obj\debug\page1.loc;obj\debug\page2.loc;obj\debug\page3.loc"  
      OutputFile="obj\debug\WPFMSBuildSample.loc" />  
  </Target>  
</Project>  
```  
  
## See Also  
 [WPF MSBuild Reference](../VS_csharp/wpf-msbuild-reference.md)   
 [WPF MSBuild Task Reference](../VS_csharp/wpf-msbuild-task-reference.md)   
 [MSBuild Reference](../VS_csharp/msbuild-reference.md)   
 [MSBuild Task Reference](../VS_csharp/msbuild-task-reference.md)   
 [Building a WPF Application (WPF)](assetId:///a58696fd-bdad-4b55-9759-136dfdf8b91c)