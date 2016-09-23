---
title: "MSBuild Error MSB3141"
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
  - MSBuild.GenerateBootstrapper.MissingVerificationInformation
  - vsdeploy.chm:13141
helpviewer_keywords: 
  - MSB3141
ms.assetid: f32ce5fd-bb82-4a8b-aebe-61efef89cdc1
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# MSBuild Error MSB3141
**MSB3141: No 'PublicKey' or 'Hash' attribute specified for file '<file\>' in item '<package\>'."**  
  
 This error occurs when you attempt to use HomeSite for the bootstrapper packages. However, the bootstrapper manifest does not contain the correct information for file verification (either a public key or a hash) at run time.  
  
### To correct this error  
  
-   Download the package file for which the information is missing and copy it into the bootstrapper cache.  
  
## See Also  
 [<PackageFiles\> Element (ClickOnce Bootstrapper)](../vs140/-packagefiles--element--bootstrapper-.md)