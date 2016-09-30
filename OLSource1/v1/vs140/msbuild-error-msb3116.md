---
title: "MSBuild Error MSB3116"
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
  - "MSBuild.GenerateManifest.HostInBrowserNotOnlineOnly"
helpviewer_keywords: 
  - "MSB3116"
ms.assetid: bf04c587-d0e2-4d68-bbff-da9a985ea70e
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Error MSB3116
**MSB3116: Application is marked to host in browser but is also marked for online and offline use. Please change your application to online only.**  
  
 When deploying a WPF Web Browser Application, you must set the \<xref:Microsoft.Build.Tasks.Deployment.ManifestUtilities.ApplicationManifest.HostInBrowser*> property to <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>. When \<xref:Microsoft.Build.Tasks.Deployment.ManifestUtilities.ApplicationManifest.HostInBrowser*> is set to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, you must set the \<xref:Microsoft.Build.Tasks.Deployment.ManifestUtilities.DeployManifest.Install*> property to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> (to make the installation available online only). If the latter condition is not met, you will receive this error message.  
  
### To correct this error  
  
-   Set the \<xref:Microsoft.Build.Tasks.Deployment.ManifestUtilities.DeployManifest.Install*> property to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## See Also  
 \<xref:Microsoft.Build.Tasks.Deployment.ManifestUtilities.ApplicationManifest.HostInBrowser*>   
 \<xref:Microsoft.Build.Tasks.Deployment.ManifestUtilities.DeployManifest.Install*>   
 [Publish Page, Project Designer](../vs140/publish-page--project-designer.md)