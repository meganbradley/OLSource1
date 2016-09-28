---
title: "numeric_limits::round_style"
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
  - "round_style"
  - "std::numeric_limits::round_style"
  - "numeric_limits::round_style"
  - "std.numeric_limits.round_style"
  - "numeric_limits.round_style"
  - "limits/std::numeric_limits::round_style"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rounding numbers"
  - "round_style method"
  - "rounding numbers, setting limits"
ms.assetid: f4813d6a-08c3-4cb7-bef1-00ca64de23a2
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# numeric_limits::round_style
Returns a value that describes the various methods that an implementation can choose for rounding a floating-point value to an integer value.  
  
## Syntax  
  
```  
  
static const float_round_style round_style = round_toward_zero;  
  
```  
  
## Return Value  
 A value from the `float_round_style` enumeration that describes the rounding style.  
  
## Remarks  
 The member stores a value that describes the various methods that an implementation can choose for rounding a floating-point value to an integer value.  
  
 The round style is hard coded in this implementation, so even if the program starts up with a different rounding mode, that value will not change.  
  
## Example  
  
```  
// numeric_limits_round_style.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <float.h>  
#include <limits>  
  
using namespace std;  
  
int main( )  
{  
   cout << "The rounding style for a double type is: "   
        << numeric_limits<double>::round_style << endl;  
   _controlfp_s(NULL,_RC_DOWN,_MCW_RC );  
   cout << "The rounding style for a double type is now: "   
        << numeric_limits<double>::round_style << endl;  
   cout << "The rounding style for an int type is: "   
        << numeric_limits<int>::round_style << endl;  
}  
```  
  
 **The rounding style for a double type is: 1**  
**The rounding style for a double type is now: 1**  
**The rounding style for an int type is: 0**   
## Requirements  
 **Header:** <limits\>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)