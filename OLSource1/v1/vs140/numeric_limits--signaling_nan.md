---
title: "numeric_limits::signaling_NaN"
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
  - "std.numeric_limits.signaling_NaN"
  - "signaling_NaN"
  - "std::numeric_limits::signaling_NaN"
  - "numeric_limits::signaling_NaN"
  - "limits/std::numeric_limits::signaling_NaN"
  - "numeric_limits.signaling_NaN"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "signaling_NaN method"
ms.assetid: 400f255f-dbc2-4f6b-927a-e0035031f795
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# numeric_limits::signaling_NaN
Returns the representation of a signaling not a number (NAN) for the type.  
  
## Syntax  
  
```  
  
static Type signaling_NaN( ) throw( );  
  
```  
  
## Return Value  
 The representation of a signaling NAN for the type.  
  
## Remarks  
 The return value is meaningful only if [has_signaling_NaN](../vs140/numeric_limits--has_signaling_nan.md) is **true**.  
  
## Example  
  
```  
// numeric_limits_signaling_nan.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <limits>  
  
using namespace std;  
  
int main( )  
{  
   cout << "The signaling NaN for type float is:  "  
        << numeric_limits<float>::signaling_NaN( )  
        << endl;  
   cout << "The signaling NaN for type int is:  "  
        << numeric_limits<int>::signaling_NaN( )  
        << endl;  
   cout << "The signaling NaN for type long double is:  "  
        << numeric_limits<long double>::signaling_NaN( )  
        << endl;  
}  
```  
  
## Sample Output  
 The following is output on x86.  
  
```  
The signaling NaN for type float is:  1.#QNAN  
The signaling NaN for type int is:  0  
The signaling NaN for type long double is:  1.#QNAN  
```  
  
## Requirements  
 **Header:** \<limits>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)