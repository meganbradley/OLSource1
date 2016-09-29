---
title: "MSBuild Error MSB3118"
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
  - "MSBuild.GenerateManifest.UseApplicationTrustInvalidFrameworkVersion"
helpviewer_keywords: 
  - "MSB3118"
ms.assetid: 9bf5b430-0cfb-4da5-a7f7-04d69f20cce1
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Error MSB3118
**MSB3118: Application is set to use application trust, but TargetFrameworkVersion is not v3.5.**  
  
 This error occurs when you set the <xref:Microsoft.Build.Tasks.GenerateApplicationManifest.UseApplicationTrust*> property to `True` and set the <xref:Microsoft.Build.Tasks.GenerateApplicationManifest.TargetFrameworkVersion*> property to a version lower than `v3.5` (for example, `v2.0`).  
  
### To correct this error  
  
-   Set the <xref:Microsoft.Build.Tasks.GenerateApplicationManifest.TargetFrameworkVersion*> property to `v3.5` or higher.  
  
## See Also  
 <xref:Microsoft.Build.Tasks.Deployment.ManifestUtilities.ApplicationManifest.UseApplicationTrust*>   
 <xref:Microsoft.Build.Tasks.GenerateApplicationManifest.UseApplicationTrust*>   
 <xref:Microsoft.Build.Tasks.GenerateApplicationManifest.TargetFrameworkVersion*>   
 <xref:Microsoft.Build.Tasks.Deployment.ManifestUtilities.ApplicationManifest.HostInBrowser*>   
 [Publish Page, Project Designer](../vs140/publish-page--project-designer.md)   
 [MSBuild Error MSB3116](../vs140/msbuild-error-msb3116.md)   
 [MSBuild Error MSB3117](../vs140/msbuild-error-msb3117.md)   
 [MSBuild Error MSB3119](../vs140/msbuild-error-msb3119.md)   
 [MSBuild Error MSB3174](../vs140/msbuild-error-msb3174.md)   
 [MSBuild Error MSB3185](../vs140/msbuild-error-msb3185.md)