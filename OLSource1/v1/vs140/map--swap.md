---
title: "map::swap"
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
  - "map.swap"
  - "map::swap"
  - "std.map.swap"
  - "map/std::map::swap"
  - "std::map::swap"
  - "swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap method"
ms.assetid: 0b46d3dd-7516-472a-a3bc-d29347833ef2
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::swap
Exchanges the elements of two maps.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The argument map providing the elements to be swapped with the target map.  
  
## Remarks  
 The member function invalidates no references, pointers, or iterators that designate elements in the two maps whose elements are being exchanged.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The original map m1 is: 10 20 30.**  
**After swapping with m2, map m1 is: 100 200.**  
**After swapping with m3, map m1 is: 300.**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)