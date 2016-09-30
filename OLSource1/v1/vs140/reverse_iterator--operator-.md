---
title: "reverse_iterator::operator-"
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
  - "std::reverse_iterator::operator-"
  - "-"
  - "operator-"
  - "reverse_iterator.operator-"
  - "xutility/std::reverse_iterator::operator-"
  - "reverse_iterator::operator-"
  - "std.reverse_iterator.operator-"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator-"
  - "- operator"
  - "- operator, with specific objects"
ms.assetid: c60c44ca-898b-406c-a879-89eac0987125
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# reverse_iterator::operator-
Subtracts an offset from a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and returns a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> addressing the element at the offset position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The offset to be subtracted from the reverse_iterator.  
  
## Return Value  
 A <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> addressing the offset element.  
  
## Remarks  
 This member function may only be used if the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> satisfies the requirements for a random-access iterator.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The vector vec is: ( 3 6 9 12 15 ).**  
**The vector vec reversed is: ( 15 12 9 6 3 ).**  
**The iterator rVPOS1 initially points to the last element**  
 **in the reversed sequence: 3.**  
**After the -2 offset, the iterator rVPOS2 points**  
 **to the 2nd element from the last in the reversed sequence: 9.**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [reverse_iterator Class](../vs140/reverse_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)