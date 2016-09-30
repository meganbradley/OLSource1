---
title: "map::key_comp"
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
  - "std::map::key_comp"
  - "key_comp"
  - "map.key_comp"
  - "map/std::map::key_comp"
  - "std.map.key_comp"
  - "map::key_comp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "key_comp method"
ms.assetid: e965d74a-6df6-4832-a3f1-4bade32dfcc5
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::key_comp
Retrieves a copy of the comparison object used to order keys in a map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns the function object that a map uses to order its elements.  
  
## Remarks  
 The stored object defines the member function  
  
 **bool operator**(**const Key&** <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, **const Key&** <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>);  
  
 which returns **true** if <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> precedes and is not equal to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in the sort order.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **kc1( 2,3 ) returns value of true, where kc1 is the function object of m1.**  
**kc2( 2,3 ) returns value of false, where kc2 is the function object of m2.**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)