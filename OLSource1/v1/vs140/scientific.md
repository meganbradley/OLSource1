---
title: "scientific"
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
  - "std::_Iosb::scientific"
  - "scientific"
  - "xiosbase/std::_Iosb::scientific"
  - "_Iosb.scientific"
  - "std::scientific"
  - "_Iosb::scientific"
  - "ios/std::scientific"
  - "std.scientific"
  - "std._Iosb.scientific"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "scientific function"
  - "scientific"
ms.assetid: cd3cf291-efd2-4147-9311-e510d1867205
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# scientific
Causes floating-point numbers to be displayed using scientific notation.  
  
## Syntax  
  
```  
  
      ios  
      _  
      base& scientific(  
   ios_base& _Str  
);  
```  
  
#### Parameters  
 `_Str`  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from `ios_base`.  
  
## Return Value  
 A reference to the object from which _*Str* is derived.  
  
## Remarks  
 By default, [fixed](../vs140/fixed.md) notation is in effect for floating-point numbers.  
  
 The manipulator effectively calls `_Str.`[setf](../vs140/ios_base--setf.md)(`ios_base::scientific`, `ios_base::floatfield`), and then returns `_Str`.  
  
## Example  
  
```  
// ios_scientific.cpp  
// compile with: /EHsc  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   float i = 100.23F;  
  
   cout << i << endl;  
   cout << scientific << i << endl;  
}  
```  
  
 **100.23**  
**1.002300e+002**   
## Requirements  
 **Header:** <ios\>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)