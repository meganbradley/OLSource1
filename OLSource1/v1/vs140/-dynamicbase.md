---
title: "-DYNAMICBASE"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/DYNAMICBASE"
f1_keywords: 
  - "/dynamicbase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "-DYNAMICBASE editbin option"
  - "DYNAMICBASE editbin option"
  - "/DYNAMICBASE editbin option"
ms.assetid: edb3df90-7b07-42fb-a94a-f5a4c1d325d6
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -DYNAMICBASE
Specifies whether an executable image can be randomly rebased at load time by using address space layout randomization (ASLR).  
  
## Syntax  
  
```  
  
/DYNAMICBASE[:NO]  
```  
  
## Remarks  
 By default, the linker sets the **/DYNAMICBASE** option.  
  
 This option modifies the header of an executable image to indicate whether the loader can randomly rebase the image at load time.  
  
 ASLR is supported on Windows Vista, Windows Server 2008, Windows 7, Windows 8, and Windows Server 2012.  
  
## See Also  
 [Editbin Options](../vs140/editbin-options.md)   
 [Windows ISV Software Security Defenses](http://msdn.microsoft.com/library/bb430720.aspx)