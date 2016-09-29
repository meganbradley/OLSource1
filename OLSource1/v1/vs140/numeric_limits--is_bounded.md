---
title: "numeric_limits::is_bounded"
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
  - "numeric_limits::is_bounded"
  - "std.numeric_limits.is_bounded"
  - "limits/std::numeric_limits::is_bounded"
  - "std::numeric_limits::is_bounded"
  - "is_bounded"
  - "numeric_limits.is_bounded"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_bounded method"
ms.assetid: 0e82b308-7855-4d86-b10e-b9a7e1637739
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# numeric_limits::is_bounded
Tests if the set of values that a type may represent is finite.  
  
## Syntax  
  
```  
  
static const bool is_bounded = false;  
  
```  
  
## Return Value  
 **true** if the type has a bounded set of representable values; **false** if not.  
  
## Remarks  
 All predefined types have a bounded set of representable values and return **true**.  
  
## Example  
  
```  
// numeric_limits_is_bounded.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <limits>  
  
using namespace std;  
  
int main( )  
{  
   cout << "Whether float objects have bounded set "  
        << "of representable values: "  
        << numeric_limits<float>::is_bounded  
        << endl;  
   cout << "Whether double objects have bounded set "  
        << "of representable values: "  
        << numeric_limits<double>::is_bounded  
        << endl;  
   cout << "Whether long int objects have bounded set "  
        << "of representable values: "  
        << numeric_limits<long int>::is_bounded  
        << endl;  
   cout << "Whether unsigned char objects have bounded set "  
        << "of representable values: "  
        << numeric_limits<unsigned char>::is_bounded  
        << endl;  
}  
```  
  
 **Whether float objects have bounded set of representable values: 1**  
**Whether double objects have bounded set of representable values: 1**  
**Whether long int objects have bounded set of representable values: 1**  
**Whether unsigned char objects have bounded set of representable values: 1**   
## Requirements  
 **Header:** <limits\>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)