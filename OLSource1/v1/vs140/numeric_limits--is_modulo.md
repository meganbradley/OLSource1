---
title: "numeric_limits::is_modulo"
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
  - "limits/std::numeric_limits::is_modulo"
  - "std::numeric_limits::is_modulo"
  - "numeric_limits::is_modulo"
  - "numeric_limits.is_modulo"
  - "is_modulo"
  - "std.numeric_limits.is_modulo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_modulo method"
ms.assetid: 1b78eb80-9d67-40ef-97ec-ee5ada40e9f6
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# numeric_limits::is_modulo
Tests if a **type** has a modulo representation.  
  
## Syntax  
  
```  
  
static const bool is_modulo = false;  
  
```  
  
## Return Value  
 **true** if the type has a modulo representation; **false** if not.  
  
## Remarks  
 A modulo representation is a representation where all results are reduced modulo some value. All predefined unsigned integer types have a modulo representation.  
  
## Example  
  
```  
// numeric_limits_is_modulo.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <limits>  
  
using namespace std;  
  
int main( )  
{  
   cout << "Whether float objects have a modulo representation: "  
        << numeric_limits<float>::is_modulo  
        << endl;  
   cout << "Whether double objects have a modulo representation: "  
        << numeric_limits<double>::is_modulo  
        << endl;  
   cout << "Whether signed char objects have a modulo representation: "  
        << numeric_limits<signed char>::is_modulo  
        << endl;  
   cout << "Whether unsigned char objects have a modulo representation: "  
        << numeric_limits<unsigned char>::is_modulo  
        << endl;  
}  
```  
  
 **Whether float objects have a modulo representation: 0**  
**Whether double objects have a modulo representation: 0**  
**Whether signed char objects have a modulo representation: 1**  
**Whether unsigned char objects have a modulo representation: 1**   
## Requirements  
 **Header:** <limits\>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)