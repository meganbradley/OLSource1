---
title: "numeric_limits::max_exponent"
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
  - "max_exponent"
  - "limits/std::numeric_limits::max_exponent"
  - "std.numeric_limits.max_exponent"
  - "numeric_limits.max_exponent"
  - "std::numeric_limits::max_exponent"
  - "numeric_limits::max_exponent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "max_exponent method"
ms.assetid: a1b46ca1-e521-4755-8c4e-c49fc824e8a3
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# numeric_limits::max_exponent
Returns the maximum positive integral exponent that the floating-point type can represent as a finite value when a base of radix is raised to that power.  
  
## Syntax  
  
```  
  
static const int max_exponent = 0;  
  
```  
  
## Return Value  
 The maximum integral radix-based exponent representable by the type.  
  
## Remarks  
 The member function return is meaningful only for floating-point types. The `max_exponent` is the value FLT_MAX_EXP for type **float**.  
  
## Example  
  
```  
// numeric_limits_max_exponent.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <limits>  
  
using namespace std;  
  
int main( )  
{  
   cout << "The maximum radix-based exponent for type float is:  "  
        << numeric_limits<float>::max_exponent  
        << endl;  
   cout << "The maximum radix-based exponent for type double is:  "  
        << numeric_limits<double>::max_exponent  
        << endl;  
   cout << "The maximum radix-based exponent for type long double is:  "  
        << numeric_limits<long double>::max_exponent  
        << endl;  
}  
```  
  
 **The maximum radix-based exponent for type float is:  128**  
**The maximum radix-based exponent for type double is:  1024**  
**The maximum radix-based exponent for type long double is:  1024**   
## Requirements  
 **Header:** \<limits>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)