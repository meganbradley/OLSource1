---
title: "MSBuild Error MSB3146"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "MSBuild.GenerateBootstrapper.MissingDependency"
helpviewer_keywords: 
  - "MSB3146"
ms.assetid: 717fd649-3024-427d-a068-cff8034ffc0a
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Error MSB3146
**MSB3146: Item '\<package>' is required by '\<package>', but was not included.**  
  
 This error occurs when one bootstrapper package depends on another, but you have selected to install only the dependent package. For example, package B depends on package A, but only B is installed.  
  
### To correct this error  
  
-   Include the required package.