---
title: "back_insert_iterator::operator*"
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
  - "back_insert_iterator.operator*"
  - "operator*"
  - "iterator/std::back_insert_iterator::operator*"
  - "back_insert_iterator::operator*"
  - "std::back_insert_iterator::operator*"
  - "std.back_insert_iterator.operator*"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "* operator"
  - "operator*"
  - "* operator, with specific iterator expressions"
ms.assetid: 63ab6117-8945-4c5d-8e6a-65b471e64a05
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# back_insert_iterator::operator*
Dereferencing operator used to implement the output iterator expression \**i* = *x*.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A reference to the element inserted at the back of the container.  
  
## Remarks  
 Used to implement the output iterator expression **\*Iter** = **value**. If **Iter** is an iterator that addresses an element in a sequence, then **\*Iter** = **value** replaces that element with value and does not change the total number of elements in the sequence.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The vector vec is: ( 1 2 3 ).**  
**After the insertions, the vector vec becomes: ( 1 2 3 10 20 ).**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [back_insert_iterator Class](../vs140/back_insert_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)