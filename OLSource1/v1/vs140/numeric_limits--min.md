---
title: "numeric_limits::min"
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
  - "std.numeric_limits.min"
  - "std::numeric_limits::min"
  - "limits/std::numeric_limits::min"
  - "numeric_limits::min"
  - "min"
  - "numeric_limits.min"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "min method"
ms.assetid: 161e39f4-dec8-4df2-8249-5160658f38f3
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# numeric_limits::min
Returns the minimum normalized value for a type.  
  
## Syntax  
  
```  
  
static Type min( ) throw( );  
  
```  
  
## Return Value  
 The minimum normalized value for the type.  
  
## Remarks  
 The minimum normalized value is INT_MIN for type `int` and FLT_MIN for type `float`. The return value is meaningful if [is_bounded](../vs140/numeric_limits--is_bounded.md) is `true` or if [is_signed](../vs140/numeric_limits--is_signed.md) is `false`.  
  
## Example  
  
```  
// numeric_limits_min.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <limits>  
  
using namespace std;  
  
int main( )  
{  
   cout << "The minimum value for type float is:  "  
        << numeric_limits<float>::min( )  
        << endl;  
   cout << "The minimum value for type double is:  "  
        << numeric_limits<double>::min( )  
        << endl;  
   cout << "The minimum value for type int is:  "  
        << numeric_limits<int>::min( )  
        << endl;  
   cout << "The minimum value for type short int is:  "  
        << numeric_limits<short int>::min( )  
        << endl;  
}  
```  
  
 **The minimum value for type float is:  1.17549e-038**  
**The minimum value for type double is:  2.22507e-308**  
**The minimum value for type int is:  -2147483648**  
**The minimum value for type short int is:  -32768**   
## Requirements  
 **Header:** \<limits>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)