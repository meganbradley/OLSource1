---
title: "MSBuild Error MSB3161"
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
  - "MSBuild.GenerateBootstrapper.CircularDependency"
helpviewer_keywords: 
  - "MSB3161"
ms.assetid: 2871d071-7c3a-4103-8b14-6ee56564a7f7
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Error MSB3161
**MSB3161: A circular dependency was detected between the following built packages: '\<package>'**  
  
 This warning is generated when there is a circular dependency in the graph of the bootstrapper package dependencies (for example: A→B→C→A). In such cases the bootstrapper cannot determine which package to install first.  
  
### To correct this error  
  
-   Remove the circular dependency, either by changing the dependencies described in the bootstrapper package files or by not installing one of the interdependent packages.  
  
## See Also  
 [Product and Package Schema Reference](../vs140/product-and-package-schema-reference.md)   
 [\<PackageFiles> Element (ClickOnce Bootstrapper)](../vs140/-packagefiles--element--bootstrapper-.md)