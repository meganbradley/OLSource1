---
title: "numeric_limits::quiet_NaN"
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
  - "numeric_limits.quiet_NaN"
  - "std::numeric_limits::quiet_NaN"
  - "limits/std::numeric_limits::quiet_NaN"
  - "std.numeric_limits.quiet_NaN"
  - "numeric_limits::quiet_NaN"
  - "quiet_NaN"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "quiet_NaN method"
ms.assetid: 49ea170f-2233-4864-8b9f-cf2ec84cd51a
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# numeric_limits::quiet_NaN
Returns the representation of a quiet not a number (NAN) for the type.  
  
## Syntax  
  
```  
  
static Type quiet_NaN( ) throw( );  
  
```  
  
## Return Value  
 The representation of a quiet NAN for the type.  
  
## Remarks  
 The return value is meaningful only if [has_quiet_NaN](../vs140/numeric_limits--has_quiet_nan.md) is **true**.  
  
## Example  
  
```  
// numeric_limits_quiet_nan.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <limits>  
  
using namespace std;  
  
int main( )  
{  
   cout << "The quiet NaN for type float is:  "  
        << numeric_limits<float>::quiet_NaN( )  
        << endl;  
   cout << "The quiet NaN for type int is:  "  
        << numeric_limits<int>::quiet_NaN( )  
        << endl;  
   cout << "The quiet NaN for type long double is:  "  
        << numeric_limits<long double>::quiet_NaN( )  
        << endl;  
}  
```  
  
 **The quiet NaN for type float is:  1.#QNAN**  
**The quiet NaN for type int is:  0**  
**The quiet NaN for type long double is:  1.#QNAN**   
## Requirements  
 **Header:** \<limits>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)