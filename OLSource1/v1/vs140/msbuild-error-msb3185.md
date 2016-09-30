---
title: "MSBuild Error MSB3185"
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
  - "MSBuild.GenerateManifest.NoEntryPoint"
helpviewer_keywords: 
  - "MSB3185"
ms.assetid: 032c63c5-d662-42ba-84e1-e3ccca8cee05
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Error MSB3185
**MSB3185: EntryPoint not specified for manifest.**  
  
 This error is generated when a manifest does not specify an entry point. This error can apply to both the application manifest and the deployment manifest.  
  
### To correct this error  
  
-   If using the GenerateApplicationManifest task, make sure that you specify a valid entry point or set the TargetFrameworkVersion property to "v3.5" or higher. For an application manifest, a valid entry point is an .exe file.  
  
-   If using the GenerateDeploymentManifest task, make sure that you specify valid entry points in your manifests. For a deployment manifest, a valid entry point is an application manifest.  
  
## See Also  
 \<xref:Microsoft.Build.Tasks.Deployment.ManifestUtilities.ApplicationManifest.HostInBrowser*>   
 \<xref:Microsoft.Build.Tasks.GenerateApplicationManifest.TargetFrameworkVersion*>   
 [Publish Page, Project Designer](../vs140/publish-page--project-designer.md)   
 [\<PackageFiles> Element (ClickOnce Bootstrapper)](../vs140/-packagefiles--element--bootstrapper-.md)   
 [MSBuild Error MSB3116](../vs140/msbuild-error-msb3116.md)   
 [MSBuild Error MSB3117](../vs140/msbuild-error-msb3117.md)   
 [MSBuild Error MSB3118](../vs140/msbuild-error-msb3118.md)   
 [MSBuild Error MSB3174](../vs140/msbuild-error-msb3174.md)