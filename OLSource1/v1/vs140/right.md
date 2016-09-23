---
title: "right"
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
  - std::_Iosb::right
  - Right
  - std::right
  - right
  - std._Iosb.right
  - std.right
  - _Iosb.right
  - xiosbase/std::_Iosb::right
  - ios/std::right
  - _Iosb::right
dev_langs: 
  - C++
helpviewer_keywords: 
  - right function
  - right
ms.assetid: 636162ba-9b5f-4c76-a7dc-819a550ae2b0
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# right
Causes text that is not as wide as the output width to appear in the stream flush with the right margin.  
  
## Syntax  
  
```  
  
      ios  
      _  
      base& right(  
   ios_base& _Str  
);  
```  
  
#### Parameters  
 `_Str`  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from `ios_base`.  
  
## Return Value  
 A reference to the object from which _*Str* is derived.  
  
## Remarks  
 [left](../vs140/left.md) also modifies the justification of text.  
  
 The manipulator effectively calls `_Str.`[setf](../vs140/ios_base--setf.md)(`ios_base::right`, `ios_base::adjustfield`), and then returns `_Str`.  
  
## Example  
  
```  
// ios_right.cpp  
// compile with: /EHsc  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   double f1= 5.00;  
   cout << f1 << endl;  
   cout.width( 20 );  
   cout << f1 << endl;  
   cout.width( 20 );  
   cout << left << f1 << endl;  
   cout.width( 20 );  
   cout << f1 << endl;  
   cout.width( 20 );  
   cout << right << f1 << endl;  
   cout.width( 20 );  
   cout << f1 << endl;  
}  
```  
  
 **5**  
 **5**  
**5**   
**5**   
 **5**  
 **5**   
## Requirements  
 **Header:** <ios\>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)