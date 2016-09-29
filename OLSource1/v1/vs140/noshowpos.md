---
title: "noshowpos"
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
  - "noshowpos"
  - "std::noshowpos"
  - "ios/std::noshowpos"
  - "std.noshowpos"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "noshowpos function"
  - "noshowpos"
ms.assetid: bc1058d3-2eab-41c0-93a8-d7b9dc1d896a
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# noshowpos
Causes positive numbers to not be explicitly signed.  
  
## Syntax  
  
```  
  
      ios  
      _  
      base& noshowpos(  
   ios_base& _Str  
);  
```  
  
#### Parameters  
 `_Str`  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from `ios_base`.  
  
## Return Value  
 A reference to the object from which _*Str* is derived.  
  
## Remarks  
 `noshowpos` is on by default.  
  
 The manipulator effectively calls `_Str.`[unsetf](../vs140/ios_base--unsetf.md)(`ios_base::showps`), then returns `_Str`.  
  
## Example  
 See [showpos](../vs140/showpos.md) for an example of using `noshowpos`.  
  
## Requirements  
 **Header:** <ios\>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)