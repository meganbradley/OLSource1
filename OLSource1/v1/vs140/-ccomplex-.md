---
title: "&lt;ccomplex&gt;"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "<ccomplex>"
dev_langs: 
  - "C++"
ms.assetid: a9fcb5f0-88e3-464b-a5fd-d1afb8cd7e6f
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;ccomplex&gt;
Includes the STL header [<complex\>](../vs140/-complex-.md), which effectively includes the Standard C library header <complex.h> and adds the associated names to the `std` namespace.  
  
## Syntax  
  
```cpp  
#include <ccomplex>  
  
```  
  
## Remarks  
 Including this header ensures that the names declared using external linkage in the Standard C library header are declared in the `std` namespace.  
  
 The name `clog`, which is declared in <complex.h>, is not defined in the `std` namespace because of potential conflicts with the `clog` that is declared in [<iostream\>](../vs140/-iostream-.md).  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [Standard C++ Library Overview](../vs140/c---standard-library-overview.md)