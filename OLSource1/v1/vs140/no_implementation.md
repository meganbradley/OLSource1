---
title: "no_implementation"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - no_implementation
dev_langs: 
  - C++
  - C
helpviewer_keywords: 
  - no_implementation attribute
ms.assetid: bdc67785-e131-409c-87bc-f4d2f4abb07b
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# no_implementation
**C++ Specific**  
  
 Suppresses the generation of the .tli header, which contains the implementations of the wrapper member functions.  
  
## Syntax  
  
```  
no_implementation  
```  
  
## Remarks  
 If this attribute is specified, the .tlh header, with the declarations to expose type-library items, will be generated without an `#include` statement to include the .tli header file.  
  
 This attribute is used in conjunction with [implementation_only](../vs140/implementation_only.md).  
  
 **END C++ Specific**  
  
## See Also  
 [#import Attributes](../vs140/sharpimport-attributes--c---.md)   
 [The #import Directive](../vs140/sharpimport-directive--c---.md)