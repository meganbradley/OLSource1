---
title: "numeric_limits::is_exact"
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
  - "std.numeric_limits.is_exact"
  - "numeric_limits::is_exact"
  - "is_exact"
  - "limits/std::numeric_limits::is_exact"
  - "numeric_limits.is_exact"
  - "std::numeric_limits::is_exact"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_exact method"
ms.assetid: e21f7383-a36b-404a-b7ed-95a6e5374b7d
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# numeric_limits::is_exact
Tests if the calculations done on a type are free of rounding errors.  
  
## Syntax  
  
```  
  
static const bool is_exact = false;  
  
```  
  
## Return Value  
 **true** if the calculations are free of rounding errors; **false** if not.  
  
## Remarks  
 All predefined integer types have exact representations for their values and return **false**. A fixed-point or rational representation is also considered exact, but a floating-point representation is not.  
  
## Example  
  
```  
// numeric_limits_is_exact.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <limits>  
  
using namespace std;  
  
int main( )  
{  
   cout << "Whether float objects have calculations "  
        << "free of rounding errors: "  
        << numeric_limits<float>::is_exact  
        << endl;  
   cout << "Whether double objects have calculations "  
        << "free of rounding errors: "  
        << numeric_limits<double>::is_exact  
        << endl;  
   cout << "Whether long int objects have calculations "  
        << "free of rounding errors: "  
        << numeric_limits<long int>::is_exact  
        << endl;  
   cout << "Whether unsigned char objects have calculations "  
        << "free of rounding errors: "  
        << numeric_limits<unsigned char>::is_exact  
        << endl;  
}  
```  
  
 **Whether float objects have calculations free of rounding errors: 0**  
**Whether double objects have calculations free of rounding errors: 0**  
**Whether long int objects have calculations free of rounding errors: 1**  
**Whether unsigned char objects have calculations free of rounding errors: 1**   
## Requirements  
 **Header:** <limits\>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)