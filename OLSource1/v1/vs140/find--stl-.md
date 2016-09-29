---
title: "find (STL)"
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
  - "algorithm/std::find"
  - "Find"
  - "std::find"
  - "std.find"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "find algorithm"
  - "algorithms [C++], find"
  - "find function"
ms.assetid: 021e9ef9-8817-409f-92ee-cd7104867361
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# find (STL)
Locates the position of the first occurrence of an element in a range that has a specified value.  
  
## Syntax  
  
```  
template<class InputIterator, class T>  
InputIterator find(InputIterator first, InputIterator last,   
      const T& val);  
```  
  
#### Parameters  
 `first`  
 An input iterator addressing the position of the first element in the range to be searched for the specified value.  
  
 `last`  
 An input iterator addressing the position one past the final element in the range to be searched for the specified value.  
  
 `val`  
 The value to be searched for.  
  
## Return Value  
 An input iterator addressing the first occurrence of the specified value in the range being searched. If no element is found with an equivalent value, returns `last`.  
  
## Remarks  
 The `operator==` used to determine the match between an element and the specified value must impose an equivalence relation between its operands.  
  
 For a code example using `find()`, see [find_if()](../vs140/find_if.md).  
  
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [<algorithm\>](../vs140/-algorithm-.md)   
 [adjacent_find](../vs140/adjacent_find.md)   
 [find_if](../vs140/find_if.md)   
 [find_if_not](../vs140/find_if_not.md)   
 [find_end](../vs140/find_end.md)   
 [mismatch](../vs140/mismatch.md)   
 [search](../vs140/search.md)