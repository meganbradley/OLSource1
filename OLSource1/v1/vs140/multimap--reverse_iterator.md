---
title: "multimap::reverse_iterator"
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
  - "multimap.reverse_iterator"
  - "std::multimap::reverse_iterator"
  - "map/std::multimap::reverse_iterator"
  - "multimap::reverse_iterator"
  - "std.multimap.reverse_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reverse_iterator typedef"
  - "reverse_iterator method"
ms.assetid: 1a34cc82-77dd-42ee-b704-ba57ba23a8b3
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::reverse_iterator
A type that provides a bidirectional iterator that can read or modify an element in a reversed multimap.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 A type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is use to iterate through the multimap in reverse.  
  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> defined by multimap points to objects of [value_type](../vs140/multimap--value_type.md), which are of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>*\<***const Key**, **Type***>*. The value of the key is available through the first member pair and the value of the mapped element is available through the second member of the pair.  
  
 To dereference a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> pointing to an element in a multimap, use the -> operator.  
  
 To access the value of the key for the element, use <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> -> **first**, which is equivalent to (\*<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>).**first**. To access the value of the mapped datum for the element, use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> -> **second**, which is equivalent to (\*<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>).**first**.  
  
## Example  
 See the example for [rbegin](../vs140/multimap--rbegin.md) for an example of how to declare and use <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)