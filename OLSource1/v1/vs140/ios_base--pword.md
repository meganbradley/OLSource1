---
title: "ios_base::pword"
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
  - "xiosbase/std::ios_base::pword"
  - "ios_base::pword"
  - "std.ios_base.pword"
  - "std::ios_base::pword"
  - "pword"
  - "ios_base.pword"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pword method"
ms.assetid: 9c56a91c-25ce-40ae-85a8-b1fcb4f41247
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ios_base::pword
Assigns a value to be stored as a `pword`.  
  
## Syntax  
  
```  
  
      void *& pword(  
   int _Idx  
);  
```  
  
#### Parameters  
 `_Idx`  
 The index of the value to store as a `pword`.  
  
## Remarks  
 The member function returns a reference to element _*Idx* of the extensible array with elements of type `void` pointer. All elements are effectively present and initially store the null pointer. The returned reference is invalid after the next call to `pword` for the object, after the object is altered by a call to **basic_ios::**[copyfmt](../vs140/basic_ios--copyfmt.md), or after the object is destroyed.  
  
 If _*Idx* is negative, or if unique storage is unavailable for the element, the function calls [setstate](../vs140/basic_ios--setstate.md)**(badbit)** and returns a reference that might not be unique.  
  
 To obtain a unique index, for use across all objects of type `ios_base`, call [xalloc](../vs140/ios_base--xalloc.md).  
  
## Example  
 See [xalloc](../vs140/ios_base--xalloc.md) for an example of using `pword`.  
  
## Requirements  
 **Header:** <ios\>  
  
 **Namespace:** std  
  
## See Also  
 [ios_base Class](../vs140/ios_base-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)