---
title: "MSBuild Error MSB4133"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "MSB4133"
ms.assetid: 5f18937a-fda1-4315-81f9-7cee02802a6d
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Error MSB4133
**MSB4133: A default tools version "\<x.x.>" was specified, but its definition could not be found.**  
  
 [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] cannot find the Toolset that is defined in the project file as the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>.  
  
### To correct this error  
  
-   Make sure that <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is specified correctly, and that this Toolset is defined either in the registry or in the [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] configuration file.  
  
## See Also  
 \<xref:Microsoft.Build.BuildEngine.Toolset*>   
 [Project Element (MSBuild)](../vs140/project-element--msbuild-.md)   
 [Resources for Troubleshooting MSBuild Errors](../vs140/additional-msbuild-resources.md)