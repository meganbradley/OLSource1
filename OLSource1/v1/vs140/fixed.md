---
title: "fixed"
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
  - "xiosbase/std::_Iosb::fixed"
  - "std::_Iosb::fixed"
  - "std::fixed"
  - "_Iosb::fixed"
  - "ios/std::fixed"
  - "_Iosb.fixed"
  - "fixed"
  - "std._Iosb.fixed"
  - "std.fixed"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "fixed function"
  - "fixed"
ms.assetid: f1f0f104-fb24-4f1d-980b-d5ac0eca5aa9
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# fixed
Specifies that a floating-point number is displayed in fixed-decimal notation.  
  
## Syntax  
  
```  
  
      ios  
      _  
      base& fixed(  
   ios_base& _Str  
);  
```  
  
#### Parameters  
 `_Str`  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from `ios_base`.  
  
## Return Value  
 A reference to the object from which _*Str* is derived.  
  
## Remarks  
 **fixed** is the default display notation for floating-point numbers. [scientific](../vs140/scientific.md) causes floating-point numbers to be displayed using scientific notation.  
  
 The manipulator effectively calls *_Str.*[setf](../vs140/ios_base--setf.md)(`ios_base::fixed`, **ios_base::floatfield**), and then returns `_Str`.  
  
## Example  
  
```  
// ios_fixed.cpp  
// compile with: /EHsc  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   float i = 1.1F;  
  
   cout << i << endl;   // fixed is the default  
   cout << scientific << i << endl;  
   cout.precision( 1 );  
   cout << fixed << i << endl;  
}  
```  
  
 **1.1**  
**1.100000e+000**  
**1.1**   
## Requirements  
 **Header:** <ios\>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)