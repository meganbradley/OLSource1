---
title: "numeric_limits::radix"
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
  - "numeric_limits.radix"
  - "radix"
  - "numeric_limits::radix"
  - "std::numeric_limits::radix"
  - "limits/std::numeric_limits::radix"
  - "std.numeric_limits.radix"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "radix method"
ms.assetid: 438f601d-3c9d-4bb8-a7f9-f7141894bc26
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# numeric_limits::radix
Returns the integral base, referred to as radix, used for the representation of a type.  
  
## Syntax  
  
```  
  
static const int radix = 0;  
  
```  
  
## Return Value  
 The integral base for the representation of the type.  
  
## Remarks  
 The base is 2 for the predefined integer types, and the base to which the exponent is raised, or FLT_RADIX, for the predefined floating-point types.  
  
## Example  
  
```  
// numeric_limits_radix.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <limits>  
  
using namespace std;  
  
int main( )  
{  
   cout << "The base for type float is:  "  
        << numeric_limits<float>::radix  
        << endl;  
   cout << "The base for type int is:  "  
        << numeric_limits<int>::radix  
        << endl;  
   cout << "The base for type long double is:  "  
        << numeric_limits<long double>::radix  
        << endl;  
}  
```  
  
 **The base for type float is:  2**  
**The base for type int is:  2**  
**The base for type long double is:  2**   
## Requirements  
 **Header:** <limits\>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)