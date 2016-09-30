---
title: "MSBuild Error MSB3143"
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
  - "MSBuild.GenerateBootstrapper.CopyPackageError"
helpviewer_keywords: 
  - "MSB3143"
ms.assetid: b4278c8c-31df-4b4f-9ef9-7b9327e8ee77
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Error MSB3143
**MSB3143: An error occurred trying to copy '\<file>' for item '\<package>': '\<error>'**  
  
 This error occurs when bootstrapper packages are copied to the build output directory. Possible causes for this error could be:  
  
-   You do not have permission to copy to the build output directory.  
  
-   The disk is full.  
  
 These are the same potential reasons that file.copy or directory.createdirectory fail.  
  
## See Also  
 [Product and Package Schema Reference](../vs140/product-and-package-schema-reference.md)   
 [\<PackageFiles> Element (ClickOnce Bootstrapper)](../vs140/-packagefiles--element--bootstrapper-.md)