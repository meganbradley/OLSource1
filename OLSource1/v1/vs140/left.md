---
title: "left"
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
  - std::_Iosb::left
  - Left
  - left
  - ios/std::left
  - std::left
  - std._Iosb.left
  - _Iosb::left
  - xiosbase/std::_Iosb::left
  - std.left
  - _Iosb.left
dev_langs: 
  - C++
helpviewer_keywords: 
  - left
  - left function
ms.assetid: b6ee767c-f452-4bde-95f8-be9542347b60
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# left
Causes text that is not as wide as the output width to appear in the stream flush with the left margin.  
  
## Syntax  
  
```  
  
      ios  
      _  
      base& left(  
   ios_base& _Str  
);  
```  
  
#### Parameters  
 `_Str`  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from `ios_base`.  
  
## Return Value  
 A reference to the object from which _*Str* is derived.  
  
## Remarks  
 The manipulator effectively calls `_Str.`[setf](../vs140/ios_base--setf.md)(`ios_base::left`, **ios_base::adjustfield**), and then returns `_Str`.  
  
## Example  
  
```  
// ios_left.cpp  
// compile with: /EHsc  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   double f1= 5.00;  
   cout.width( 20 );   
   cout << f1 << endl;  
   cout << left << f1 << endl;  
}  
```  
  
  **5**  
**5**   
## Requirements  
 **Header:** <ios\>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)