---
title: "reverse_iterator::reverse_iterator"
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
  - "reverse_iterator"
  - "reverse_iterator.reverse_iterator"
  - "reverse_iterator::reverse_iterator"
  - "std::reverse_iterator::reverse_iterator"
  - "xutility/std::reverse_iterator::reverse_iterator"
  - "std.reverse_iterator.reverse_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reverse_iterator method"
  - "reverse_iterator class, constructor"
ms.assetid: e52a9cfd-9657-43b8-a316-9ba5b115c108
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# reverse_iterator::reverse_iterator
Constructs a default <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> from an underlying iterator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The iterator that is to be adapted to a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Return Value  
 A default <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> adapting an underlying iterator.  
  
## Remarks  
 The identity which relates all reverse iterators to their underlying iterators is:  
  
 &\*(<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> ( *i* ) ) == &\*( *i* – 1 ).  
  
 In practice, this means that in the reversed sequence the reverse_iterator will refer to the element one position beyond (to the right of) the element that the iterator had referred to in the original sequence. So if an iterator addressed the element 6 in the sequence (2, 4, 6, 8), then the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> will address the element 4 in the reversed sequence (8, 6, 4, 2).  
  
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