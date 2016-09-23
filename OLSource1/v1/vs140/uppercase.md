---
title: "uppercase"
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
  - _Iosb::uppercase
  - uppercase
  - std._Iosb.uppercase
  - _Iosb.uppercase
  - std::_Iosb::uppercase
  - UpperCase
  - std.uppercase
  - xiosbase/std::_Iosb::uppercase
  - std::uppercase
  - ios/std::uppercase
dev_langs: 
  - C++
helpviewer_keywords: 
  - uppercase
  - uppercase function
ms.assetid: a0241a12-bcc3-4512-8693-4f4adacdb826
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# uppercase
Specifies that hexadecimal digits and the exponent in scientific notation appear in uppercase.  
  
## Syntax  
  
```  
  
      ios  
      _  
      base& uppercase(  
   ios_base& _Str  
);  
```  
  
#### Parameters  
 `_Str`  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from `ios_base`.  
  
## Return Value  
 A reference to the object from which `_Str` is derived.  
  
## Remarks  
 By default, [nouppercase](../vs140/nouppercase.md) is in effect.  
  
 The manipulator effectively calls `_Str.`[setf](../vs140/ios_base--setf.md)([ios_base::uppercase](../vs140/ios_base--fmtflags.md)), and then returns `_Str`.  
  
## Example  
  
```  
// ios_uppercase.cpp  
// compile with: /EHsc  
#include <iostream>  
  
int main( void )   
{  
   using namespace std;  
  
   double i = 1.23e100;  
   cout << i << endl;  
   cout << uppercase << i << endl;  
  
   int j = 10;  
   cout << hex << nouppercase << j << endl;  
   cout << hex << uppercase << j << endl;  
}  
```  
  
 **1.23e+100**  
**1.23E+100**  
**a**  
**A**   
## Requirements  
 **Header:** <ios\>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)