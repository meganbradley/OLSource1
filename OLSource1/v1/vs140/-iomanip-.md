---
title: "&lt;iomanip&gt;"
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
  - iomanip/std::<iomanip>
  - std::<iomanip>
  - <iomanip>
  - std.<iomanip>
dev_langs: 
  - C++
helpviewer_keywords: 
  - iomanip header
ms.assetid: 3681c346-4763-4037-bba4-cf0dc3447974
caps.latest.revision: 23
translation.priority.mt: 
  - de-de
  - ja-jp
---
# &lt;iomanip&gt;
Include the `iostreams` standard header `<iomanip>` to define several manipulators that each take a single argument.  
  
## Syntax  
  
```  
#include <iomanip>  
  
```  
  
## Remarks  
 Each of these manipulators returns an unspecified type, called **T1** through **T10**, that overloads both `basic_istream`<**Elem**, **Tr**>`::`[operator>>](../vs140/-istream--operators.md#operator_gt__gt_) and `basic_ostream`<**Elem**, **Tr**>`::`[operator<<](../vs140/-ostream--operators.md#operator_lt__lt_).  
  
### Manipulators  
  
|||  
|-|-|  
|[get_money](../vs140/-iomanip--functions.md#iomanip_get_money)|Obtains a monetary amount, optionally in international format.|  
|[get_time](../vs140/-iomanip--functions.md#iomanip_get_time)|Obtains a time in a time structure by using a specified format.|  
|[put_money](../vs140/-iomanip--functions.md#iomanip_put_money)|Provides a monetary amount, optionally in international format.|  
|[put_time](../vs140/-iomanip--functions.md#iomanip_put_time)|Provides a time in a time structure and a format string to use.|  
|[quoted](../vs140/-iomanip--functions.md#quoted)|Enables convenient round-tripping of strings with insertion and extraction operators.|  
|[resetiosflags](../vs140/-iomanip--functions.md#resetiosflags)|Clears the specified flags.|  
|[setbase](../vs140/-iomanip--functions.md#setbase)|Set base for integers.|  
|[setfill](../vs140/-iomanip--functions.md#setfill)|Sets the character that will be used to fill spaces in a right-justified display.|  
|[setiosflags](../vs140/-iomanip--functions.md#setiosflags)|Sets the specified flags.|  
|[setprecision](../vs140/-iomanip--functions.md#setprecision)|Sets the precision for floating-point values.|  
|[setw](../vs140/-iomanip--functions.md#setw)|Specifies the width of the display field.|  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)