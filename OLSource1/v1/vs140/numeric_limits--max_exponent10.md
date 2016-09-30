---
title: "numeric_limits::max_exponent10"
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
  - "std::numeric_limits::max_exponent10"
  - "numeric_limits::max_exponent10"
  - "numeric_limits.max_exponent10"
  - "limits/std::numeric_limits::max_exponent10"
  - "max_exponent10"
  - "std.numeric_limits.max_exponent10"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "max_exponent10 method"
ms.assetid: 11492b58-20fe-496e-818f-0f7304f1cbaa
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# numeric_limits::max_exponent10
Returns the maximum positive integral exponent that the floating-point type can represent as a finite value when a base of ten is raised to that power.  
  
## Syntax  
  
```  
  
static const int max_exponent10 = 0;  
  
```  
  
## Return Value  
 The maximum integral base 10 exponent representable by the type.  
  
## Remarks  
 The member function return is meaningful only for floating-point types. The `max_exponent` is the value FLT_MAX_10 for type **float**.  
  
## Example  
  
```  
// numeric_limits_max_exponent10.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <limits>  
  
using namespace std;  
  
int main( )  
{  
   cout << "The maximum base 10 exponent for type float is:  "  
           << numeric_limits<float>::max_exponent10  
           << endl;  
   cout << "The maximum base 10 exponent for type double is:  "  
           << numeric_limits<double>::max_exponent10  
           << endl;  
   cout << "The maximum base 10 exponent for type long double is:  "  
           << numeric_limits<long double>::max_exponent10  
           << endl;  
}  
```  
  
 **The maximum base 10 exponent for type float is:  38**  
**The maximum base 10 exponent for type double is:  308**  
**The maximum base 10 exponent for type long double is:  308**   
## Requirements  
 **Header:** \<limits>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)