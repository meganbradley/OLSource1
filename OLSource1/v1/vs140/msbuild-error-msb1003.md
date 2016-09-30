---
title: "MSBuild Error MSB1003"
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
  - "MSBuild.MissingProjectError"
helpviewer_keywords: 
  - "MSB1003"
ms.assetid: db4aa779-af86-4bb6-b86f-9a31866f70f5
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Error MSB1003
**Specify a project or solution file. The current working directory does not contain a project or solution file.**  
  
 If a project or solution file is not specified on the command line, [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] searches the current working directory for a file that has a file extension that ends in "proj" or "sln" and uses that file. The current working directory does not contain a file that has a file extension that ends in "proj" or "sln".  
  
### To correct this error  
  
-   Go to the directory that contains the project file you want to build.  
  
-   Specify either the full or relative path to the project file. For example, type <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  
-   If the project or solution file has a file extension that does not end in "proj", change the file extension so that it does end in "proj".  
  
## See Also  
 [MSBuild Command Line Reference](../vs140/msbuild-command-line-reference.md)   
 [MSBuild](../vs140/msbuild.md)   
 [MSBuild Project File Schema Reference](../vs140/msbuild-project-file-schema-reference.md)