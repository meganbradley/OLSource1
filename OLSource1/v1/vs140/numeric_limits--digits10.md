---
title: "numeric_limits::digits10"
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
  - "std::numeric_limits::digits10"
  - "limits/std::numeric_limits::digits10"
  - "numeric_limits::digits10"
  - "digits10"
  - "numeric_limits.digits10"
  - "std.numeric_limits.digits10"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "digits10 method"
ms.assetid: f5c08749-8c99-49af-a8db-7be483122536
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# numeric_limits::digits10
Returns the number of decimal digits that the type can represent without loss of precision.  
  
## Syntax  
  
```  
  
static const int digits10 = 0;  
  
```  
  
## Return Value  
 The number of decimal digits that the type can represent without loss of precision.  
  
## Example  
  
```  
// numeric_limits_digits10.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <limits>  
  
using namespace std;  
  
int main( )  
{  
   cout << numeric_limits<float>::digits10 <<endl;  
   cout << numeric_limits<double>::digits10 <<endl;  
   cout << numeric_limits<long double>::digits10 <<endl;  
   cout << numeric_limits<int>::digits10 <<endl;  
   cout << numeric_limits<__int64>::digits10 <<endl;  
   float f = (float)99999999;  
   cout.precision ( 10 );  
   cout << "The float is; " << f << endl;  
}  
```  
  
 **6**  
**15**  
**15**  
**9**  
**18**  
**The float is; 100000000**   
## Requirements  
 **Header:** \<limits>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)