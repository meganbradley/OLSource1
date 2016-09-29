---
title: "MSBuild Error MSB3182"
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
  - "MSBuild.GenerateManifest.TargetPathTooLong"
helpviewer_keywords: 
  - "MSB3182"
ms.assetid: b257a206-b12b-453b-97d8-2cb9a0d3dcc9
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Error MSB3182
**MSB3182: File name '\<file>' exceeds '\<length>' characters.**  
  
 This warning is generated when the value of the `TargetPath` property is too long. It can apply both to the application and deployment manifest.  
  
### To correct this error  
  
-   Edit the value of the `TargetPath` property to make it shorter.  
  
## See Also  
 [\<PackageFiles> Element (ClickOnce Bootstrapper)](../vs140/-packagefiles--element--bootstrapper-.md)