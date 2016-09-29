---
title: "numeric_limits::is_integer"
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
  - "numeric_limits::is_integer"
  - "limits/std::numeric_limits::is_integer"
  - "std.numeric_limits.is_integer"
  - "std::numeric_limits::is_integer"
  - "numeric_limits.is_integer"
  - "is_integer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_integer method"
ms.assetid: 68415f50-088a-4142-8076-07df3675fe0d
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# numeric_limits::is_integer
Tests if a type has an integer representation.  
  
## Syntax  
  
```  
  
static const bool is_integer = false;  
  
```  
  
## Return Value  
 **true** if the type has an integer representation; **false** if not.  
  
## Remarks  
 All predefined integer types have an integer representation.  
  
## Example  
  
```  
// numeric_limits_is_integer.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <limits>  
  
using namespace std;  
  
int main( )  
{  
   cout << "Whether float objects have an integral representation: "  
        << numeric_limits<float>::is_integer  
        << endl;  
   cout << "Whether double objects have an integral representation: "  
        << numeric_limits<double>::is_integer  
        << endl;  
   cout << "Whether int objects have an integral representation: "  
        << numeric_limits<int>::is_integer  
        << endl;  
   cout << "Whether unsigned char objects have an integral representation: "  
        << numeric_limits<unsigned char>::is_integer  
        << endl;  
}  
```  
  
 **Whether float objects have an integral representation: 0**  
**Whether double objects have an integral representation: 0**  
**Whether int objects have an integral representation: 1**  
**Whether unsigned char objects have an integral representation: 1**   
## Requirements  
 **Header:** <limits\>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)