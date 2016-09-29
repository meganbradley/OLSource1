---
title: "-HIGHENTROPYVA"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/HIGHENTROPYVA"
f1_keywords: 
  - "/HIGHENTROPYVA"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HIGHENTROPYVA editbin option"
  - "-HIGHENTROPYVA editbin option"
  - "/HIGHENTROPYVA editbin option"
ms.assetid: ef4b7c63-440d-40ca-b39d-edefb3217505
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -HIGHENTROPYVA
Specifies whether the executable image supports high-entropy 64-bit address space layout randomization (ASLR).  
  
```  
  
/HIGHENTROPYVA[:NO]  
```  
  
## Remarks  
 This option modifies the header of a .dll file or .exe file to indicate whether ASLR with 64-bit addresses is supported. When this option is set on an executable and all of the modules that it depends on, an operating system that supports 64-bit ASLR can rebase the segments of the executable image at load time by using randomized addresses in a 64-bit virtual address space. This large address space makes it more difficult for an attacker to guess the location of a particular memory region.  
  
 By default, the linker sets this option for 64-bit executable images. To set this option, the [/DYNAMICBASE](../vs140/-dynamicbase.md) option must also be set.  
  
## See Also  
 [EDITBIN Options](../vs140/editbin-options.md)   
 [/DYNAMICBASE](../vs140/-dynamicbase.md)   
 [Windows ISV Software Security Defenses](http://msdn.microsoft.com/library/bb430720.aspx)