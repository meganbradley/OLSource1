---
title: "multimap::key_comp"
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
  - "multimap.key_comp"
  - "key_comp"
  - "multimap::key_comp"
  - "std.multimap.key_comp"
  - "map/std::multimap::key_comp"
  - "std::multimap::key_comp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "key_comp method"
ms.assetid: 77be75d9-f5d3-4254-b083-2210ec0e227c
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::key_comp
Retrieves a copy of the comparison object used to order keys in a multimap.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns the function object that a multimap uses to order its elements.  
  
## Remarks  
 The stored object defines the member function  
  
 **bool operator**(**const Key&** *x*, **const Key&** *y*);  
  
 which returns true if *x* strictly precedes *y* in the sort order.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **kc1( 2,3 ) returns value of true, where kc1 is the function object of m1.**  
**kc2( 2,3 ) returns value of false, where kc2 is the function object of m2.**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)