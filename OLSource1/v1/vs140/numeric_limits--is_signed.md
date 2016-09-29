---
title: "numeric_limits::is_signed"
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
  - "std.numeric_limits.is_signed"
  - "numeric_limits.is_signed"
  - "limits/std::numeric_limits::is_signed"
  - "numeric_limits::is_signed"
  - "std::numeric_limits::is_signed"
  - "is_signed"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_signed method"
ms.assetid: f827517f-52d9-4403-b77f-d31206fb6459
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# numeric_limits::is_signed
Tests if a type has a signed representation.  
  
## Syntax  
  
```  
  
static const bool is_signed = false;  
  
```  
  
## Return Value  
 **true** if the type has a signed representation; **false** if not.  
  
## Remarks  
 The member stores true for a type that has a signed representation, which is the case for all predefined floating-point and signed integer types.  
  
## Example  
  
```  
// numeric_limits_is_signaled.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <limits>  
  
using namespace std;  
  
int main( )  
{  
   cout << "Whether float objects have a signed representation: "  
        << numeric_limits<float>::is_signed  
        << endl;  
   cout << "Whether double objects have a signed representation: "  
        << numeric_limits<double>::is_signed  
        << endl;  
   cout << "Whether signed char objects have a signed representation: "  
        << numeric_limits<signed char>::is_signed  
        << endl;  
   cout << "Whether unsigned char objects have a signed representation: "  
        << numeric_limits<unsigned char>::is_signed  
        << endl;  
}  
```  
  
 **Whether float objects have a signed representation: 1**  
**Whether double objects have a signed representation: 1**  
**Whether signed char objects have a signed representation: 1**  
**Whether unsigned char objects have a signed representation: 0**   
## Requirements  
 **Header:** <limits\>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)