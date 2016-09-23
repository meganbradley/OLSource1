---
title: "-ALLOWISOLATION"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
H1: /ALLOWISOLATION
f1_keywords: 
  - /ALLOWISOLATION
dev_langs: 
  - C++
helpviewer_keywords: 
  - -ALLOWISOLATION editbin option
  - /ALLOWISOLATION editbin option
  - ALLOWISOLATION editbin option
ms.assetid: 91430344-f64f-491a-a5a5-7ea3b21cbe68
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# -ALLOWISOLATION
Specifies behavior for manifest lookup.  
  
## Syntax  
  
```  
  
/ALLOWISOLATION[:NO]  
```  
  
## Remarks  
 **/ALLOWISOLATION** causes the operating system to do manifest lookups and loads.  
  
 **/ALLOWISOLATION** is the default.  
  
 **/ALLOWISOLATION:NO** indicates that executables are loaded as if there were no manifest, and causes [EDITBIN](../vs140/editbin-reference.md) to set the `IMAGE_DLLCHARACTERISTICS_NO_ISOLATION` bit in the optional header's `DllCharacteristics` field.  
  
 When isolation is disabled for an executable, the Windows loader doesn't try to find an application manifest for the newly created process. The new process doesn't have a default activation context, even if there is a manifest in the executable itself or if there is a manifest that has the name *executable-name*.exe.manifest.  
  
## See Also  
 [EDITBIN Options](../vs140/editbin-options.md)   
 [/ALLOWISOLATION (Manifest Lookup)](../vs140/-allowisolation--manifest-lookup-.md)   
 [Manifest Files Reference](http://msdn.microsoft.com/library/aa375632.aspx)