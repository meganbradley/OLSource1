---
title: "reverse_iterator::base"
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
  - "reverse_iterator::base"
  - "base"
  - "iterator/std::reverse_iterator::base"
  - "std.reverse_iterator.base"
  - "reverse_iterator.base"
  - "std::reverse_iterator::base"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "base method"
ms.assetid: 71e56694-4538-4f16-a1b6-f9f6d47edfc4
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# reverse_iterator::base
Recovers the underlying iterator from its <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The iterator underlying the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 The identity that relates all reverse iterators to their underlying iterators is:  
  
 &\*(<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> ( *i* ) ) == &\*( *i* – 1 ).  
  
 In practice, this means that in the reversed sequence the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> will refer to the element one position beyond (to the right of) the element that the iterator had referred to in the original sequence. So if an iterator addressed the element 6 in the sequence (2, 4, 6, 8), then the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> will address the element 4 in the reversed sequence (8, 6, 4, 2).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [reverse_iterator Class](../vs140/reverse_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)