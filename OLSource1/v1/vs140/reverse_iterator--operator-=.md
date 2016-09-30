---
title: "reverse_iterator::operator+="
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
  - "operator+="
  - "std.reverse_iterator.operator+="
  - "xutility/std::reverse_iterator::operator+="
  - "reverse_iterator.operator+="
  - "+="
  - "reverse_iterator::operator+="
  - "std::reverse_iterator::operator+="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator +=, iterators"
  - "operator+=, iterators"
  - "+= operator, iterator"
  - "+= operator"
ms.assetid: 1a24f7f2-1bdb-4599-aa0b-fd8dc1e17d32
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# reverse_iterator::operator+=
Adds a specified offset from a reverse_iterator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The offset by which to increment the iterator.  
  
## Return Value  
 A reference to the element addressed by the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The vector vec is: ( 2 4 6 8 10 ).**  
**The vector vec reversed is: ( 10 8 6 4 2 ).**  
**The iterator rVPOS1 initially points to the first element**  
 **in the reversed sequence: 10.**  
**After the +2 offset, the iterator rVPOS1 now points**  
 **to the third element in the reversed sequence: 6.**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [reverse_iterator Class](../vs140/reverse_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)