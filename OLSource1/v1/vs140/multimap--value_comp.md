---
title: "multimap::value_comp"
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
  - "value_comp"
  - "std.multimap.value_comp"
  - "multimap::value_comp"
  - "multimap.value_comp"
  - "std::multimap::value_comp"
  - "map/std::multimap::value_comp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value_comp method"
ms.assetid: 66ffcc61-11a2-4367-b8bd-f34342ba74d3
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::value_comp
The member function returns a function object that determines the order of elements in a multimap by comparing their key values.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns the comparison function object that a multimap uses to order its elements.  
  
## Remarks  
 For a multimap *m*, if two elements *e*1(*k*1, *d*1) and *e*2(*k*2, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>2) are objects of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, where *k*1 and *k*2 are their keys of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>1 and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>2 are their data of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, then *m.*<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>(*e*1, *e*2) is equivalent to *m.*<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>(*k*1, *k*2).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The element ( 1,10 ) precedes the element ( 2,5 ).**  
**The element ( 2,5 ) does not precede the element ( 1,10 ).**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)