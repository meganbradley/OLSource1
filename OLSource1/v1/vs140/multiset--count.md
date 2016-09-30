---
title: "multiset::count"
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
  - "multiset::count"
  - "std.multiset.count"
  - "set/std::multiset::count"
  - "multiset.count"
  - "count"
  - "std::multiset::count"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "count method"
ms.assetid: 044b1ea9-ce3a-4fd9-8c78-8249eaf824e0
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multiset::count
Returns the number of elements in a multiset whose key matches a parameter-specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The key of the elements to be matched from the multiset.  
  
## Return Value  
 The number of elements in the multiset whose sort key matches the parameter key.  
  
## Remarks  
 The member function returns the number of elements *x* in the range  
  
 [<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> (_*Key* ), <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> (\_*Key* ) ).  
  
## Example  
 The following example demonstrates the use of the multiset::count member function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The number of elements in ms1 with a sort key of 1 is: 2.**  
**The number of elements in ms1 with a sort key of 2 is: 1.**  
**The number of elements in ms1 with a sort key of 3 is: 0.**   
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [multiset Class](../vs140/multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)