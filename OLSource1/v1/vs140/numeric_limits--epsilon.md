---
title: "numeric_limits::epsilon"
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
  - "std.numeric_limits.epsilon"
  - "std::numeric_limits::epsilon"
  - "epsilon"
  - "numeric_limits.epsilon"
  - "numeric_limits::epsilon"
  - "limits/std::numeric_limits::epsilon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "epsilon method"
ms.assetid: e1d9f59d-dd3c-4bc1-bcef-afbdb466d357
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# numeric_limits::epsilon
The function returns the difference between 1 and the smallest value greater than 1 that is representable for the data type.  
  
## Syntax  
  
```  
  
static Type epsilon( ) throw( );  
  
```  
  
## Return Value  
 The difference between 1 and the smallest value greater than 1 that is representable for the data type.  
  
## Remarks  
 The value is FLT_EPSILON for type **float**. `epsilon` for a type is the smallest positive floating-point number *N* such that *N* + `epsilon` + *N* is representable.  
  
## Example  
  
```  
// numeric_limits_epsilon.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <limits>  
  
using namespace std;  
  
int main( )  
{  
   cout << "The difference between 1 and the smallest "  
        << "value greater than 1\n for float objects is: "   
        << numeric_limits<float>::epsilon( )   
        << endl;  
   cout << "The difference between 1 and the smallest "  
        << "value greater than 1\n for double objects is: "   
        << numeric_limits<double>::epsilon( )   
        << endl;  
   cout << "The difference between 1 and the smallest "  
        << "value greater than 1\n for long double objects is: "   
        << numeric_limits<long double>::epsilon( )   
        << endl;  
}  
```  
  
 **The difference between 1 and the smallest value greater than 1**  
 **for float objects is: 1.19209e-007**  
**The difference between 1 and the smallest value greater than 1**  
 **for double objects is: 2.22045e-016**  
**The difference between 1 and the smallest value greater than 1**  
 **for long double objects is: 2.22045e-016**   
## Requirements  
 **Header:** \<limits>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)