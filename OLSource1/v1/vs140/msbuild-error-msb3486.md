---
title: "MSBuild Error MSB3486"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - MSBuild.SignFile.CertificateError
helpviewer_keywords: 
  - MSB3486
ms.assetid: 75d03d8e-3a28-4010-b602-61fe037dec74
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# MSBuild Error MSB3486
**MSB3486: Cannot get certificate from store '<certificate store\>'.**  
  
 The `ResolveKeySource` MSBuild task generates this error when the certificate matching the thumbprint of your project's .pfx file is not found in your personal certificate store.  
  
### To correct this error  
  
-   Make sure that the thumbprint of your project's .pfx file matches that of the certificate in your personal certificate store.  
  
## See Also  
 [<PackageFiles\> Element (ClickOnce Bootstrapper)](../vs140/-packagefiles--element--bootstrapper-.md)