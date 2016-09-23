---
title: "numeric_limits::is_specialized"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - is_specialized
  - numeric_limits::is_specialized
  - std::numeric_limits::is_specialized
  - limits/std::numeric_limits::is_specialized
  - numeric_limits.is_specialized
  - std.numeric_limits.is_specialized
dev_langs: 
  - C++
helpviewer_keywords: 
  - is_specialized method
ms.assetid: 2c40c3ce-526b-4e06-aa22-1da809e8ae21
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# numeric_limits::is_specialized
Tests if a type has an explicit specialization defined in the template class `numeric_limits`.  
  
## Syntax  
  
```  
  
static const bool is_specialized = false;  
  
```  
  
## Return Value  
 **true** if the type has an explicit specialization defined in the template class; **false** if not.  
  
## Remarks  
 All scalar types other than pointers have an explicit specialization defined for template class `numeric_limits`.  
  
## Example  
  
```  
// numeric_limits_is_specialized.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <limits>  
  
using namespace std;  
  
int main( )  
{  
   cout << "Whether float objects have an explicit "  
        << "specialization in the class: "  
        << numeric_limits<float>::is_specialized  
        << endl;  
   cout << "Whether float* objects have an explicit "  
        << "specialization in the class: "  
        << numeric_limits<float*>::is_specialized  
        << endl;  
   cout << "Whether int objects have an explicit "  
        << "specialization in the class: "  
        << numeric_limits<int>::is_specialized  
        << endl;  
   cout << "Whether int* objects have an explicit "  
        << "specialization in the class: "  
        << numeric_limits<int*>::is_specialized  
        << endl;  
}  
```  
  
 **Whether float objects have an explicit specialization in the class: 1**  
**Whether float\* objects have an explicit specialization in the class: 0**  
**Whether int objects have an explicit specialization in the class: 1**  
**Whether int\* objects have an explicit specialization in the class: 0**   
## Requirements  
 **Header:** <limits\>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)