---
title: "MSBuild Error MSB3150"
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
  - "MSBuild.GenerateBootstrapper.NoStringsForCulture"
helpviewer_keywords: 
  - "MSB3150"
ms.assetid: 90d86aef-f4df-4070-8ecc-173eb40668aa
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Error MSB3150
**MSB3150: No string resources available for building a bootstrapper with culture '{0}'.**  
  
 This error occurs when setup.xml was found but did not contain the strings node. The XML file has likely been corrupted.  
  
### To correct this error  
  
-   Go to **Control Panel**, select **Add or Remove Programs**, and repair the Visual Studio SDK, or copy the files to the appropriate directory (<SDK install path\>\bootstrapper\engine\\<culture\>\setup.xml).