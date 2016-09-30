---
title: "reverse_iterator::operator"
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
  - "std::reverse_iterator::operator[]"
  - "reverse_iterator::operator[]"
  - "[]"
  - "operator[]"
  - "iterator/std::reverse_iterator::[]"
  - "std.reverse_iterator.operator[]"
  - "reverse_iterator.operator[]"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator [], iterators"
  - "[] operator, with specific standard C++ objects"
  - "operator[], iterators"
ms.assetid: e4d3cee2-dc00-4e02-a88e-0518219e9aa1
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# reverse_iterator::operator
Returns a reference to an element offset from the element addressed by a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> by a specified number of positions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The offset from the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> address.  
  
## Return Value  
 The reference to the element offset.  
  
## Remarks  
 The operator returns **\***(**\*this** + <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The vector vec is: ( 2 4 6 8 10 ).**  
**The vector vec reversed is: ( 10 8 6 4 2 ).**  
**The iterator pos points to: 8.**  
**The iterator rpos points to: 6.**  
**The iterator rpos now points to: 2.**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [reverse_iterator Class](../vs140/reverse_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)