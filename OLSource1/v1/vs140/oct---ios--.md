---
title: "oct (&lt;ios&gt;)"
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
  - "Oct"
  - "std::oct"
  - "std.oct"
  - "ios/std::oct"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "oct function"
ms.assetid: ec0c769f-0dd0-414f-990c-6c682c2a454f
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# oct (&lt;ios&gt;)
Specifies that integer variables appear in base 8 notation.  
  
## Syntax  
  
```  
  
      ios  
      _  
      base& oct(  
   ios_base& _Str  
);  
```  
  
#### Parameters  
 `_Str`  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from `ios_base`.  
  
## Return Value  
 A reference to the object from which _*Str* is derived.  
  
## Remarks  
 By default, integer variables are displayed in base 10 notation. [dec](../vs140/dec.md) and [hex](../vs140/hex.md) also change the way integer variables appear.  
  
 The manipulator effectively calls `_Str.`[setf](../vs140/ios_base--setf.md)(`ios_base::oct`, `ios_base::basefield`), and then returns `_Str`.  
  
## Example  
 See [dec](../vs140/dec.md) for an example of how to use **oct**.  
  
## Requirements  
 **Header:** <ios\>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)