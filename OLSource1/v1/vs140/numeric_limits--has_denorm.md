---
title: "numeric_limits::has_denorm"
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
  - "numeric_limits.has_denorm"
  - "limits/std::numeric_limits::has_denorm"
  - "has_denorm"
  - "numeric_limits::has_denorm"
  - "std.numeric_limits.has_denorm"
  - "std::numeric_limits::has_denorm"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "has_denorm method"
ms.assetid: 40c3cdd9-fd70-4a1b-9454-e38cf8ac4019
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# numeric_limits::has_denorm
Tests whether a type allows denormalized values.  
  
## Syntax  
  
```  
  
static const float_denorm_style has_denorm = denorm_absent;  
  
```  
  
## Return Value  
 An enumeration value of type **const** `float_denorm_style`, indicating whether the type allows denormalized values.  
  
## Remarks  
 The member stores **denorm_present** for a floating-point type that has denormalized values, effectively a variable number of exponent bits.  
  
## Example  
  
```  
// numeric_limits_has_denorm.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <limits>  
  
using namespace std;  
  
int main( )  
{  
   cout << "Whether float objects allow denormalized values: "  
        << numeric_limits<float>::has_denorm   
        << endl;  
   cout << "Whether double objects allow denormalized values: "  
        << numeric_limits<double>::has_denorm   
        << endl;  
   cout << "Whether long int objects allow denormalized values: "   
        << numeric_limits<long int>::has_denorm   
        << endl;  
}  
```  
  
 **Whether float objects allow denormalized values: 1**  
**Whether double objects allow denormalized values: 1**  
**Whether long int objects allow denormalized values: 0**   
## Requirements  
 **Header:** \<limits>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)