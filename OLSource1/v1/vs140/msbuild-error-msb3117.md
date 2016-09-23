---
title: "MSBuild Error MSB3117"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - MSBuild.GenerateManifest.HostInBrowserInvalidFrameworkVersion
helpviewer_keywords: 
  - MSB3117
ms.assetid: 18aec642-6000-4626-bf75-f3547769c780
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# MSBuild Error MSB3117
**MSB3117: Application is set to host in browser but the TargetFrameworkVersion is set to v2.0.**  
  
 A WPF Web Browser Application was deployed with the <xref:Microsoft.Build.Tasks.Deployment.ManifestUtilities.ApplicationManifest.HostInBrowser?qualifyHint=False> property set to `True`, but TargetFrameworkVersion was set to `v2.0` or `v3.0`. If you use this setting, you must also set the <xref:Microsoft.Build.Tasks.GenerateApplicationManifest.TargetFrameworkVersion?qualifyHint=False> property to a value of `v3.5` or higher.  
  
### To correct this error  
  
-   Set the <xref:Microsoft.Build.Tasks.GenerateApplicationManifest.TargetFrameworkVersion?qualifyHint=False> property to a value of `v3.5` or higher.  
  
## See Also  
 <xref:Microsoft.Build.Tasks.Deployment.ManifestUtilities.ApplicationManifest.HostInBrowser?qualifyHint=False>   
 <xref:Microsoft.Build.Tasks.GenerateApplicationManifest.TargetFrameworkVersion?qualifyHint=False>   
 [Publish Page, Project Designer](../vs140/publish-page--project-designer.md)   
 [MSBuild Error MSB3116](../vs140/msbuild-error-msb3116.md)   
 [MSBuild Error MSB3118](../vs140/msbuild-error-msb3118.md)   
 [MSBuild Error MSB3174](../vs140/msbuild-error-msb3174.md)   
 [MSBuild Error MSB3185](../vs140/msbuild-error-msb3185.md)