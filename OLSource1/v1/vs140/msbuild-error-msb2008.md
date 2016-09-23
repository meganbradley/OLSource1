---
title: "MSBuild Error MSB2008"
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
  - MSBuild.UnrecognizedChildElement
helpviewer_keywords: 
  - MSB2008
ms.assetid: 3c2afda0-a116-4b2f-af0c-c0f0d1541325
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# MSBuild Error MSB2008
**The Visual Studio project system cannot convert "{0}" projects. It can only be used to convert C# and VB client projects.**  
  
 Only valid [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] and [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] projects can be converted using [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)].  
  
### To correct this error  
  
-   If the project is a [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] or [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] project, check whether the project file has been modified or corrupted. If it has been modified or corrupted, open the project in the version of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] in which it was created, save it, and then attempt to convert it again.  
  
-   If the project is not a [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] or [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] project, use the appropriate tool to convert it.  
  
## See Also  
 [Resources for Troubleshooting MSBuild Errors](../vs140/additional-msbuild-resources.md)