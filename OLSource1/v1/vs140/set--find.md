---
title: "set::find"
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
  - "std.set.find"
  - "Find"
  - "set::find"
  - "set.find"
  - "std::set::find"
  - "set/std::set::find"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "find method"
ms.assetid: 11aa5a57-db54-4ada-bbda-80dc27a23114
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set::find
Returns an iterator that refers to the location of an element in a set that has a key equivalent to a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The key value to be matched by the sort key of an element from the set being searched.  
  
## Return Value  
 An iterator that refers to the location of an element with a specified key, or the location succeeding the last element in the set (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) if no match is found for the key.  
  
## Remarks  
 The member function returns an iterator that refers to an element in the set whose key is equivalent to the argument <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> under a binary predicate that induces an ordering based on a less than comparability relation.  
  
 If the return value of **find** is assigned to a **const_iterator**, the set object cannot be modified. If the return value of **find** is assigned to an **iterator**, the set object can be modified  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
 **The starting set s1 is:2 elements: (40) (45)Inserting the following vector data into s1:6 elements: (43) (41) (46) (42) (44) (44)The modified set s1 is:7 elements: (40) (41) (42) (43) (44) (45) (46)Trying find() on value 45Element found: (45)Trying find() on value 6Element not found.**   
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [set Class](../vs140/set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)