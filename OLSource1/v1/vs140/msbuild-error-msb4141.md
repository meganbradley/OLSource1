---
title: "MSBuild Error MSB4141"
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
  - "MSB4141"
ms.assetid: 0d190884-e64d-4d6b-817d-ce4644788fce
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Error MSB4141
**MSB4141: MSBuildToolsPath is not specified for the ToolsVersion "\<x.x>."**  
  
 A custom Toolset is defined but no value is specified for <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>.  
  
### To correct this error  
  
-   Specify a valid value for <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> when you define a custom Toolset in the registry or the [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] configuration file.  
  
## See Also  
 [Standard and Custom Toolset Configurations](../vs140/standard-and-custom-toolset-configurations.md)   
 [Project Element (MSBuild)](../vs140/project-element--msbuild-.md)   
 [Resources for Troubleshooting MSBuild Errors](../vs140/additional-msbuild-resources.md)