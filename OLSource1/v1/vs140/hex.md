---
title: "hex"
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
  - "std.hex"
  - "ios/std::hex"
  - "Hex"
  - "std::_Iosb::hex"
  - "std::hex"
  - "_Iosb.hex"
  - "xiosbase/std::_Iosb::hex"
  - "_Iosb::hex"
  - "std._Iosb.hex"
  - "hex"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "hex"
  - "Hex function"
ms.assetid: 227470c8-3e0d-42da-b9ad-f37ea372e5bc
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hex
Specifies that integer variables shall appear in base 16 notation.  
  
## Syntax  
  
```  
  
      ios  
      _  
      base& hex(  
   ios_base& _Str  
);  
```  
  
#### Parameters  
 `_Str`  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from `ios_base`.  
  
## Return Value  
 A reference to the object from which _*Str* is derived.  
  
## Remarks  
 By default, integer variables are displayed in base 10 notation. [dec](../vs140/dec.md) and [oct](../vs140/oct---ios--.md) also change the way integer variables appear.  
  
 The manipulator effectively calls `_Str`**.**[setf](../vs140/ios_base--setf.md)(`ios_base::hex`, **ios_base::basefield**), and then returns `_Str`.  
  
## Example  
 See [dec](../vs140/dec.md) for an example of how to use **hex**.  
  
## Requirements  
 **Header:** <ios\>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)