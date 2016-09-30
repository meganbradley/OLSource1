---
title: "multiset::end"
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
  - "std.multiset.end"
  - "end"
  - "std::multiset::end"
  - "set/std::multiset::end"
  - "multiset::end"
  - "multiset.end"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "end method"
ms.assetid: 946699fc-2d34-4e76-bd5b-0fe084aa64e0
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multiset::end
Returns the past-the-end iterator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The past-the-end iterator. If the multiset is empty, then <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Remarks  
 **end** is used to test whether an iterator has passed the end of its multiset.  
  
 The value returned by **end** should not be dereferenced.  
  
 For a code example, see [multiset::find](../vs140/multiset--find.md).  
  
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [multiset Class](../vs140/multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)