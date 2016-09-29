---
title: "&lt;ctgmath&gt;"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: ff521893-f445-4dc8-a2f6-699185bb7024
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;ctgmath&gt;
In effect, includes the Standard C++ library headers <ccomplex\> and <cmath\>, which provide type-generic math macros equivalent to <tgmath.h>.  
  
## Syntax  
  
```  
#include <ctgmath>  
  
```  
  
## Remarks  
 The functionality of the Standard C library header <tgmath.h> is provided by overloads in <ccomplex\> and <cmath\>.  
  
 Including this header ensures that the names declared using external linkage in the Standard C library header are declared in the `std` namespace.  
  
## See Also  
 [<ccomplex\>](../VS_csharp/-ccomplex-.md)   
 [<cmath\>](../VS_csharp/-cmath-.md)   
 [Header Files](../VS_csharp/c---standard-library-header-files.md)   
 [Standard C++ Library Overview](../VS_csharp/c---standard-library-overview.md)   
 [Thread Safety in the Standard C++ Library](../VS_csharp/thread-safety-in-the-c---standard-library.md)