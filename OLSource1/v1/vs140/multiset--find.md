---
title: "multiset::find"
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
  - "find"
  - "set/std::multiset::find"
  - "std.multiset.find"
  - "multiset.find"
  - "multiset::find"
  - "std::multiset::find"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "find method"
ms.assetid: fdbb8af1-6c59-4eb6-a145-535add79278d
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multiset::find
Returns an iterator that refers to the location of an element in a multiset that has a key equivalent to a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The key value to be matched by the sort key of an element from the multiset being searched.  
  
## Return Value  
 An iterator that refers to the location of an element with a specified key, or the location succeeding the last element in the multiset (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) if no match is found for the key.  
  
## Remarks  
 The member function returns an iterator that refers to an element in the multiset whose key is equivalent to the argument <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> under a binary predicate that induces an ordering based on a less than comparability relation.  
  
 If the return value of **find** is assigned to a **const_iterator**, the multiset object cannot be modified. If the return value of **find** is assigned to an **iterator**, the multiset object can be modified  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
 **The starting multiset s1 is:2 elements: (40) (45)Inserting the following vector data into s1:6 elements: (43) (41) (46) (42) (44) (44)The modified multiset s1 is:8 elements: (40) (41) (42) (43) (44) (44) (45) (46)Trying find() on value 45Element found: (45)Trying find() on value 6Element not found.**   
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [multiset Class](../vs140/multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)