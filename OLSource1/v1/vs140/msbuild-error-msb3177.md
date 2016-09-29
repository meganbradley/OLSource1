---
title: "MSBuild Error MSB3177"
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
  - "MSBuild.GenerateManifest.AllowPartiallyTrustedCallers"
helpviewer_keywords: 
  - "MSB3177"
ms.assetid: 0b2417d5-3bc3-4169-b69c-a4a3cbf47882
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Error MSB3177
**MSB3177: Reference '<reference\>' does not allow partially trusted callers.**  
  
 This warning is generated during application manifest generation when the application is a partially trusted application and if *reference* was added as a project reference, has a strong name, and does not have the APTCA attribute.  
  
### To correct this error  
  
-   Add the APTCA attribute to the referenced assembly, or stop using it, if the former is not possible.  
  
## See Also  
 [<PackageFiles\> Element (ClickOnce Bootstrapper)](../vs140/-packagefiles--element--bootstrapper-.md)