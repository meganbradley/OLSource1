---
title: "numeric_limits::traps"
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
  - "numeric_limits.traps"
  - "limits/std::numeric_limits::traps"
  - "traps"
  - "std.numeric_limits.traps"
  - "std::numeric_limits::traps"
  - "numeric_limits::traps"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "traps method"
ms.assetid: e18c9183-4951-426d-8062-74047bc714c3
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# numeric_limits::traps
Tests whether trapping that reports on arithmetic exceptions is implemented for a type.  
  
## Syntax  
  
```  
  
static const bool traps = false;  
  
```  
  
## Return Value  
 **true** if trapping is implemented for the type; **false** if it is not.  
  
## Example  
  
```  
// numeric_limits_traps.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <limits>  
  
using namespace std;  
  
int main( )  
{  
   cout << "Whether float types have implemented trapping: "  
        << numeric_limits<float>::traps  
        << endl;  
   cout << "Whether double types have implemented trapping: "  
        << numeric_limits<double>::traps  
        << endl;  
   cout << "Whether long int types have implemented trapping: "  
        << numeric_limits<long int>::traps  
        << endl;  
   cout << "Whether unsigned char types have implemented trapping: "  
        << numeric_limits<unsigned char>::traps  
        << endl;  
}  
```  
  
 **Whether float types have implemented trapping: 1**  
**Whether double types have implemented trapping: 1**  
**Whether long int types have implemented trapping: 0**  
**Whether unsigned char types have implemented trapping: 0**   
## Requirements  
 **Header:** <limits\>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)