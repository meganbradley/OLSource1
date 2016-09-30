---
title: "multiset::upper_bound"
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
  - "multiset::upper_bound"
  - "std::multiset::upper_bound"
  - "upper_bound"
  - "std.multiset.upper_bound"
  - "multiset.upper_bound"
  - "set/std::multiset::upper_bound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "upper_bound method"
ms.assetid: 091b1d52-5e26-4be1-9e1f-6165eaa945da
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multiset::upper_bound
Returns an iterator to the first element in a multiset with a key that is greater than a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The argument key to be compared with the sort key of an element from the multiset being searched.  
  
## Return Value  
 An **iterator** or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> that addresses the location of an element in a multiset with a key that is greater than the argument key, or that addresses the location succeeding the last element in the multiset if no match is found for the key.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The first element of multiset ms1 with a key greater than 20 is: 30.**  
**The multiset ms1 doesn't have an element with a key greater than 30.**  
**The first element of ms1 with a key greater than**  
**that of the initial element of ms1 is: 20.**   
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [multiset Class](../vs140/multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)