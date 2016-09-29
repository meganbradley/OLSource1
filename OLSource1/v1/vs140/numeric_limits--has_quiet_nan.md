---
title: "numeric_limits::has_quiet_NaN"
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
  - "std.numeric_limits.has_quiet_NaN"
  - "limits/std::numeric_limits::has_quiet_NaN"
  - "numeric_limits.has_quiet_NaN"
  - "std::numeric_limits::has_quiet_NaN"
  - "has_quiet_NaN"
  - "numeric_limits::has_quiet_NaN"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "has_quiet_NaN method"
ms.assetid: 29577877-0b68-4b57-831a-63a85202472d
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# numeric_limits::has_quiet_NaN
Tests whether a type has a representation for a quiet not a number (NAN), which is nonsignaling.  
  
## Syntax  
  
```  
  
static const bool has_quiet_NaN = false;  
  
```  
  
## Return Value  
 **true** if the **type** has a representation for a quiet NAN; **false** if not.  
  
## Remarks  
 A quiet NAN is an encoding for not a number, which does not signal its presence in an expression. The return value is **true** if [is_iec559](../vs140/numeric_limits--is_iec559.md) is true.  
  
## Example  
  
```  
// numeric_limits_has_quiet_nan.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <limits>  
  
using namespace std;  
  
int main( )  
{  
   cout << "Whether float objects have quiet_NaN: "  
        << numeric_limits<float>::has_quiet_NaN   
        << endl;  
   cout << "Whether double objects have quiet_NaN: "  
        << numeric_limits<double>::has_quiet_NaN   
        << endl;  
   cout << "Whether long int objects have quiet_NaN: "   
        << numeric_limits<long int>::has_quiet_NaN   
        << endl;  
}  
```  
  
 **Whether float objects have quiet_NaN: 1**  
**Whether double objects have quiet_NaN: 1**  
**Whether long int objects have quiet_NaN: 0**   
## Requirements  
 **Header:** \<limits>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)