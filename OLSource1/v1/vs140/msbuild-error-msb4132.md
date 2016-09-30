---
title: "MSBuild Error MSB4132"
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
  - "MSB4132"
ms.assetid: 4ac265a7-0f8d-4fec-ba6e-cd70cbd5d89e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Error MSB4132
**MSB4132: The tools version "'\<version>'" is unrecognized.**  
  
 [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] could find a Toolset that corresponds to the specified value of <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>.  
  
### To correct this error  
  
-   Specify a valid value for <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> in the project tag, or on the command line when you use the MSBuild **/ToolsVersion** switch.  
  
## See Also  
 \<xref:Microsoft.Build.Tasks.MSBuild.ToolsVersion*>   
 [Resources for Troubleshooting MSBuild Errors](../vs140/additional-msbuild-resources.md)