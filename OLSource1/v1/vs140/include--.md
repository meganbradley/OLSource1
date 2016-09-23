---
title: "include()"
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
  - include()
dev_langs: 
  - C++
  - C
helpviewer_keywords: 
  - include() attribute
ms.assetid: 86c9dcb2-d9e0-4fd5-97d7-0bb3e23d6ecc
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# include()
**C++ Specific**  
  
 Disables automatic exclusion.  
  
## Syntax  
  
```  
include("Name1"[,"Name2", ...])  
```  
  
#### Parameters  
 `Name1`  
 First item to be forcibly included.  
  
 `Name2`  
 Second item to be forcibly included (if necessary).  
  
## Remarks  
 Type libraries may include definitions of items defined in system headers or other type libraries. `#import` attempts to avoid multiple definition errors by automatically excluding such items. If items have been excluded, as indicated by [Compiler Warning (level 3) C4192](../vs140/compiler-warning--level-3--c4192.md), and they should not have been, this attribute can be used to disable the automatic exclusion. This attribute can take any number of arguments, each being the name of the type-library item to be included.  
  
 **END C++ Specific**  
  
## See Also  
 [#import Attributes](../vs140/sharpimport-attributes--c---.md)   
 [The #import Directive](../vs140/sharpimport-directive--c---.md)