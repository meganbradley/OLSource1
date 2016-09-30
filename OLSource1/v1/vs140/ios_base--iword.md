---
title: "ios_base::iword"
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
  - "iword"
  - "ios_base.iword"
  - "std.ios_base.iword"
  - "std::ios_base::iword"
  - "xiosbase/std::ios_base::iword"
  - "ios_base::iword"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "iword method"
ms.assetid: ce7f10de-1ae7-4174-a916-72033fb928f5
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ios_base::iword
Assigns a value to be stored as an `iword`.  
  
## Syntax  
  
```  
  
      long& iword(  
   int idx  
);  
```  
  
#### Parameters  
 `idx`  
 The index of the value to store as an `iword`.  
  
## Remarks  
 The member function returns a reference to element `idx` of the extensible array with elements of type **long**. All elements are effectively present and initially store the value zero. The returned reference is invalid after the next call to `iword` for the object, after the object is altered by a call to **basic_ios::**[copyfmt](../vs140/basic_ios--copyfmt.md), or after the object is destroyed.  
  
 If `idx` is negative or if unique storage is unavailable for the element, the function calls [setstate](../vs140/basic_ios--setstate.md)**(badbit)** and returns a reference that might not be unique.  
  
 To obtain a unique index, for use across all objects of type `ios_base`, call [xalloc](../vs140/ios_base--xalloc.md).  
  
## Example  
 See [xalloc](../vs140/ios_base--xalloc.md) for a sample of how to use `iword`.  
  
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [ios_base Class](../vs140/ios_base-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)