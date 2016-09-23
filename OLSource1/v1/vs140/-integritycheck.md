---
title: "-INTEGRITYCHECK"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
H1: /INTEGRITYCHECK
f1_keywords: 
  - /INTEGRITYCHECK
dev_langs: 
  - C++
helpviewer_keywords: 
  - -INTEGRITYCHECK editbin options
  - /INTEGRITYCHECK editbin options
  - INTEGRITYCHECK editbin options
ms.assetid: 2a293705-4396-421b-a5a5-693b4b867a85
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# -INTEGRITYCHECK
Specifies that the digital signature of the binary image must be checked at load time.  
  
```  
  
/INTEGRITYCHECK[:NO]  
```  
  
## Remarks  
 In the header of the DLL file or executable file, this option sets a flag that requires a digital signature check by the memory manager to load the image in Windows. Versions of Windows prior to Windows Vista ignore this flag. This option must be set for 64-bit DLLs that implement kernel-mode code, and is recommended for all device drivers. For more information, see [Kernel-Mode Code Signing Walkthrough](http://go.microsoft.com/fwlink/?linkid=237093) on the MSDN website.  
  
## See Also  
 [EDITBIN Options](../vs140/editbin-options.md)