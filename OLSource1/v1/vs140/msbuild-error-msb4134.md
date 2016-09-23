---
title: "MSBuild Error MSB4134"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - MSB4134
ms.assetid: 2e4e6beb-c0c9-40ef-b75c-1c16244eba10
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# MSBuild Error MSB4134
**MSB4134: DefaultToolsVersion cannot be set after a project has been loaded into the Engine.**  
  
 This error occurs when an attempt to change the value of `DefaultToolsVersion` is made after [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] already has built a project.  
  
### To correct this error  
  
-   Change the value of `DefaultToolsVersion` before you build a project.  
  
## See Also  
 <xref:Microsoft.Build.Utilities.Task.BuildEngine?qualifyHint=False>   
 <xref:Microsoft.Build.Utilities.Task.BuildEngine2?qualifyHint=False>   
 [Project Element (MSBuild)](../vs140/project-element--msbuild-.md)   
 [Resources for Troubleshooting MSBuild Errors](../vs140/additional-msbuild-resources.md)