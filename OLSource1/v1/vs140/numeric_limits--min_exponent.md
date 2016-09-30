---
title: "numeric_limits::min_exponent"
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
  - "numeric_limits::min_exponent"
  - "numeric_limits.min_exponent"
  - "limits/std::numeric_limits::min_exponent"
  - "std::numeric_limits::min_exponent"
  - "min_exponent"
  - "std.numeric_limits.min_exponent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "min_exponent method"
ms.assetid: 01cbd52c-b20d-493c-b333-33be89da9475
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# numeric_limits::min_exponent
Returns the maximum negative integral exponent that the floating-point type can represent as a finite value when a base of radix is raised to that power.  
  
## Syntax  
  
```  
  
static const int min_exponent = 0;  
  
```  
  
## Return Value  
 The minimum integral radix-based exponent representable by the type.  
  
## Remarks  
 The member function is meaningful only for floating-point types. The `min_exponent` is the value FLT_MIN_EXP for type **float**.  
  
## Example  
  
```  
// numeric_limits_min_exponent.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <limits>  
  
using namespace std;  
  
int main( )  
{  
   cout << "The minimum radix-based exponent for type float is:  "  
        << numeric_limits<float>::min_exponent  
        << endl;  
   cout << "The minimum radix-based exponent for type double is:  "  
        << numeric_limits<double>::min_exponent  
        << endl;  
   cout << "The minimum radix-based exponent for type long double is:  "  
         << numeric_limits<long double>::min_exponent  
        << endl;  
}  
```  
  
 **The minimum radix-based exponent for type float is:  -125**  
**The minimum radix-based exponent for type double is:  -1021**  
**The minimum radix-based exponent for type long double is:  -1021**   
## Requirements  
 **Header:** \<limits>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)