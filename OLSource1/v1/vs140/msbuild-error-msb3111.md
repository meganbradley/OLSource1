---
title: "MSBuild Error MSB3111"
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
  - "MSBuild.GenerateManifest.ConfigBindingRedirectsWithPartialTrust"
helpviewer_keywords: 
  - "MSB3111"
ms.assetid: f01286a1-ba27-4733-a431-35ffe9a31356
caps.latest.revision: 9
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Error MSB3111
**MSB3111: Use of app.config binding redirects requires full trust.**  
  
 This warning is generated when the build process detects that the application tried to redirect some of its assemblies to another version inside the app.config file. This will not work for partially trusted applications.  
  
## See Also  
 [Product and Package Schema Reference](../vs140/product-and-package-schema-reference.md)