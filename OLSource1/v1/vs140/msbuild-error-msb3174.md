---
title: "MSBuild Error MSB3174"
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
  - MSBuild.GenerateManifest.InvalidValue
helpviewer_keywords: 
  - MSB3174
ms.assetid: 6f9a040c-7f21-40fd-bf74-03f99f265e79
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# MSBuild Error MSB3174
**MSB3174: Invalid value for '<file\>'.**  
  
 This error is generated when the build process encounters a general problem while checking the format of a manifest file. The error message refers to the manifest file name.  
  
 Setting any one of the following parameters incorrectly will generate this error message. Each parameter listed is a <xref:Microsoft.Build.Tasks.GenerateApplicationManifest?qualifyHint=False> or a <xref:Microsoft.Build.Tasks.GenerateDeploymentManifest?qualifyHint=False> property such as <xref:Microsoft.Build.Tasks.GenerateApplicationManifest.TargetFrameworkVersion?qualifyHint=False> or <xref:Microsoft.Build.Tasks.GenerateDeploymentManifest.MinimumRequiredVersion?qualifyHint=False>.  
  
 When the task is <xref:Microsoft.Build.Tasks.GenerateApplicationManifest?qualifyHint=False>, the following requirements apply:  
  
|Parameter|Requirements|  
|---------------|------------------|  
|<xref:Microsoft.Build.Tasks.GenerateManifestBase.AssemblyName?qualifyHint=False>|Must be a valid file name.|  
|<xref:Microsoft.Build.Tasks.GenerateManifestBase.AssemblyVersion?qualifyHint=False>|Has the same requirements as <xref:System.Version.#ctor?qualifyHint=False>. All octets must be greater than 0. Must specify all four octets. An empty string is acceptable.|  
|<xref:Microsoft.Build.Tasks.GenerateApplicationManifest.ClrVersion?qualifyHint=False>|Has the same requirements as <xref:System.Version.#ctor?qualifyHint=False>. All octets must be greater than 0. Must specify all four octets. An empty string is acceptable.|  
|<xref:Microsoft.Build.Tasks.GenerateApplicationManifest.OSVersion?qualifyHint=False>|Has the same requirements as <xref:System.Version.#ctor?qualifyHint=False>. All octets must be greater than 0. Must specify all four octets. An empty string is acceptable.|  
|<xref:Microsoft.Build.Tasks.GenerateManifestBase.Platform?qualifyHint=False>|Must be **AnyCPU**, **x86**, **x64**, or **Itanium**. An empty string is acceptable.|  
|<xref:Microsoft.Build.Tasks.GenerateApplicationManifest.ManifestType?qualifyHint=False>|Must be **Native** or **ClickOnce**.|  
|<xref:Microsoft.Build.Tasks.GenerateManifestBase.TargetCulture?qualifyHint=False>|Can be an empty string. Can also be a neutral culture (specified by the two-digit lowercase language code only, for example, "jp" for Japanese). Otherwise, this value has the same requirements as <xref:System.Globalization.CultureInfo.#ctor?qualifyHint=False>.|  
|<xref:Microsoft.Build.Tasks.GenerateApplicationManifest.TargetFrameworkVersion?qualifyHint=False>|Must have the format v*#*.*#*. Must be later than v2.0. An empty string is acceptable.|  
  
 When the task is <xref:Microsoft.Build.Tasks.GenerateDeploymentManifest?qualifyHint=False>, the following requirements apply:  
  
|Parameter|Requirements|  
|---------------|------------------|  
|<xref:Microsoft.Build.Tasks.GenerateManifestBase.AssemblyName?qualifyHint=False>|Must be a valid file name.|  
|<xref:Microsoft.Build.Tasks.GenerateManifestBase.AssemblyVersion?qualifyHint=False>|Has the same requirements as <xref:System.Version.#ctor?qualifyHint=False>. All octets must be greater than 0. Must specify all four octets. An empty string is acceptable.|  
|<xref:Microsoft.Build.Tasks.GenerateDeploymentManifest.MinimumRequiredVersion?qualifyHint=False>|Has the same requirements as <xref:System.Version.#ctor?qualifyHint=False>. All octets must be greater than 0. An empty string is acceptable.|  
|<xref:Microsoft.Build.Tasks.GenerateManifestBase.Platform?qualifyHint=False>|Must be **AnyCPU**, **x86**, **x64**, or **Itanium**. An empty string is acceptable.|  
|<xref:Microsoft.Build.Tasks.GenerateManifestBase.TargetCulture?qualifyHint=False>|Can be an empty string. Can also be a neutral culture (specified by the two-digit lowercase language code only, for example, "jp" for Japanese). Otherwise, this value has the same requirements as <xref:System.Globalization.CultureInfo.#ctor?qualifyHint=False>.|  
|<xref:Microsoft.Build.Tasks.GenerateDeploymentManifest.UpdateMode?qualifyHint=False>|Must be **Foreground** or **Background**. An empty string is acceptable.|  
|<xref:Microsoft.Build.Tasks.GenerateDeploymentManifest.UpdateUnit?qualifyHint=False>|Must be **Hours**, **Days**, or **Weeks**. An empty string is acceptable.|  
  
## See Also  
 <xref:Microsoft.Build.Tasks.Deployment.ManifestUtilities.ApplicationManifest.HostInBrowser?qualifyHint=False>   
 <xref:Microsoft.Build.Tasks.GenerateApplicationManifest.TargetFrameworkVersion?qualifyHint=False>   
 [Product and Package Schema Reference](../vs140/product-and-package-schema-reference.md)   
 [Publish Page, Project Designer](../vs140/publish-page--project-designer.md)   
 [MSBuild Error MSB3116](../vs140/msbuild-error-msb3116.md)   
 [MSBuild Error MSB3117](../vs140/msbuild-error-msb3117.md)   
 [MSBuild Error MSB3118](../vs140/msbuild-error-msb3118.md)   
 [MSBuild Error MSB3185](../vs140/msbuild-error-msb3185.md)