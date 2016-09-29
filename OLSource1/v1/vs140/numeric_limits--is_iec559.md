---
title: "numeric_limits::is_iec559"
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
  - "limits/std::numeric_limits::is_iec559"
  - "std::numeric_limits::is_iec559"
  - "numeric_limits::is_iec559"
  - "is_iec559"
  - "numeric_limits.is_iec559"
  - "std.numeric_limits.is_iec559"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_iec559 method"
ms.assetid: 163af9d0-6cbb-4a8b-96b4-5961d992a7f6
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# numeric_limits::is_iec559
Tests if a type conforms to IEC 559 standards.  
  
## Syntax  
  
```  
  
static const bool is_iec559 = false;  
  
```  
  
## Return Value  
 **true** if the type conforms to the IEC 559 standards; **false** if not.  
  
## Remarks  
 The IEC 559 is an international standard for representing floating-point values and is also known as IEEE 754 in the USA.  
  
## Example  
  
```  
// numeric_limits_is_iec559.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <limits>  
  
using namespace std;  
  
int main( )  
{  
   cout << "Whether float objects conform to iec559 standards: "  
        << numeric_limits<float>::is_iec559  
        << endl;  
   cout << "Whether double objects conform to iec559 standards: "  
        << numeric_limits<double>::is_iec559  
        << endl;  
   cout << "Whether int objects conform to iec559 standards: "  
        << numeric_limits<int>::is_iec559  
        << endl;  
   cout << "Whether unsigned char objects conform to iec559 standards: "  
        << numeric_limits<unsigned char>::is_iec559  
        << endl;  
}  
```  
  
 **Whether float objects conform to iec559 standards: 1**  
**Whether double objects conform to iec559 standards: 1**  
**Whether int objects conform to iec559 standards: 0**  
**Whether unsigned char objects conform to iec559 standards: 0**   
## Requirements  
 **Header:** \<limits>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)