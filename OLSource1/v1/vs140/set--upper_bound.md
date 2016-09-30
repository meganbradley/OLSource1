---
title: "set::upper_bound"
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
  - "set.upper_bound"
  - "set::upper_bound"
  - "std.set.upper_bound"
  - "upper_bound"
  - "std::set::upper_bound"
  - "set/std::set::upper_bound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "upper_bound method"
ms.assetid: efdc6f0e-ccbb-44cd-9776-f3ba0e213b45
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set::upper_bound
Returns an iterator to the first element in a set that with a key that is greater than a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The argument key to be compared with the sort key of an element from the set being searched.  
  
## Return Value  
 An **iterator** or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> that addresses the location of an element in a set that with a key that is greater than the argument key, or that addresses the location succeeding the last element in the set if no match is found for the key.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The first element of set s1 with a key greater than 20 is: 30.**  
**The set s1 doesn't have an element with a key greater than 30.**  
**The first element of s1 with a key greater than**  
**that of the initial element of s1 is: 20.**   
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [set Class](../vs140/set-class.md)   
 [set::lower_bound, set::upper_bound, and set::equal_range](../vs140/set--lower_bound--set--upper_bound--and-set--equal_range.md)   
 [Standard Template Library](../vs140/standard-template-library.md)