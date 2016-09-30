---
title: "MSBuild Error MSB3117"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "MSBuild.GenerateManifest.HostInBrowserInvalidFrameworkVersion"
helpviewer_keywords: 
  - "MSB3117"
ms.assetid: 18aec642-6000-4626-bf75-f3547769c780
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Error MSB3117
**MSB3117: Application is set to host in browser but the TargetFrameworkVersion is set to v2.0.**  
  
 A WPF Web Browser Application was deployed with the \<xref:Microsoft.Build.Tasks.Deployment.ManifestUtilities.ApplicationManifest.HostInBrowser*> property set to <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, but TargetFrameworkVersion was set to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. If you use this setting, you must also set the \<xref:Microsoft.Build.Tasks.GenerateApplicationManifest.TargetFrameworkVersion*> property to a value of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or higher.  
  
### To correct this error  
  
-   Set the \<xref:Microsoft.Build.Tasks.GenerateApplicationManifest.TargetFrameworkVersion*> property to a value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or higher.  
  
## See Also  
 \<xref:Microsoft.Build.Tasks.Deployment.ManifestUtilities.ApplicationManifest.HostInBrowser*>   
 \<xref:Microsoft.Build.Tasks.GenerateApplicationManifest.TargetFrameworkVersion*>   
 [Publish Page, Project Designer](../vs140/publish-page--project-designer.md)   
 [MSBuild Error MSB3116](../vs140/msbuild-error-msb3116.md)   
 [MSBuild Error MSB3118](../vs140/msbuild-error-msb3118.md)   
 [MSBuild Error MSB3174](../vs140/msbuild-error-msb3174.md)   
 [MSBuild Error MSB3185](../vs140/msbuild-error-msb3185.md)