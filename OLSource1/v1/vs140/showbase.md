---
title: "showbase"
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
  - "showbase"
  - "std._Iosb.showbase"
  - "std.showbase"
  - "_Iosb.showbase"
  - "std::_Iosb::showbase"
  - "ios/std::showbase"
  - "std::showbase"
  - "xiosbase/std::_Iosb::showbase"
  - "_Iosb::showbase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "showbase function"
  - "showbase"
ms.assetid: c5833ada-a42e-4f7f-8143-cac30afde42c
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# showbase
Indicates the notational base in which a number is displayed.  
  
## Syntax  
  
```  
  
      ios  
      _  
      base& showbase(  
   ios_base& _Str  
);  
```  
  
#### Parameters  
 `_Str`  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from `ios_base`.  
  
## Return Value  
 A reference to the object from which _*Str* is derived.  
  
## Remarks  
 The notational base of a number can be changed with [dec](../vs140/dec.md), [oct](../vs140/oct---ios--.md), or [hex](../vs140/hex.md).  
  
 The manipulator effectively calls `_Str.`[setf](../vs140/ios_base--setf.md)(`ios_base::showbase`), and then returns `_Str`.  
  
## Example  
  
```  
// ios_showbase.cpp  
// compile with: /EHsc  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   int j = 100;  
  
   cout << showbase << j << endl;   // dec is default  
   cout << hex << j << showbase << endl;  
   cout << oct << j << showbase << endl;  
  
   cout << dec << j << noshowbase << endl;  
   cout << hex << j << noshowbase << endl;  
   cout << oct << j << noshowbase << endl;  
}  
```  
  
 **100**  
**0x64**  
**0144**  
**100**  
**64**  
**144**   
## Requirements  
 **Header:** <ios\>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)