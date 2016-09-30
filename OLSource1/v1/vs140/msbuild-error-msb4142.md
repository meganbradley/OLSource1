---
title: "MSBuild Error MSB4142"
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
  - "MSB4142"
ms.assetid: 56121c76-f952-43d1-ba23-1d1792fef0bc
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Error MSB4142
**MSB4142: MSBuildToolsPath is not the same as MSBuildBinPath for the ToolsVersion "\<x.x>".**  
  
 The Toolset definition specifies different values for <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
### To correct this error  
  
-   Make sure that the values for <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> are the same in your Toolset definition.  
  
## See Also  
 [Standard and Custom Toolset Configurations](../vs140/standard-and-custom-toolset-configurations.md)   
 [Project Element (MSBuild)](../vs140/project-element--msbuild-.md)   
 [Resources for Troubleshooting MSBuild Errors](../vs140/additional-msbuild-resources.md)