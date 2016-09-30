---
title: "reverse_iterator::operator+"
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
  - "+"
  - "operator+"
  - "reverse_iterator.operator+"
  - "std.reverse_iterator.operator+"
  - "xutility/std::reverse_iterator::operator+"
  - "std::reverse_iterator::operator+"
  - "reverse_iterator::operator+"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator +, iterators"
  - "+ operator, iterator"
  - "+ operator"
  - "operator+, iterators"
ms.assetid: bae7dde4-6501-42da-b524-ea7db95bbcf9
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# reverse_iterator::operator+
Adds an offset to an iterator and returns the new <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> addressing the inserted element at the new offset position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The offset to be added to the reverse iterator.  
  
## Return Value  
 A <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> addressing the offset element.  
  
## Remarks  
 This member function may only be used if the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> satisfies the requirements for a random-access iterator.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The vector vec is: ( 2 4 6 8 10 ).**  
**The vector vec reversed is: ( 10 8 6 4 2 ).**  
**The iterator rVPOS1 initially points to the first element**  
 **in the reversed sequence: 10.**  
**After the +2 offset, the iterator rVPOS2 points**  
 **to the 3rd element in the reversed sequence: 6.**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [reverse_iterator Class](../vs140/reverse_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)