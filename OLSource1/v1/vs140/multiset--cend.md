---
title: "multiset::cend"
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
  - "std.multiset.cend"
  - "multiset::cend"
  - "multiset.cend"
  - "std::multiset::cend"
  - "set/std::multiset::cend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cend method"
ms.assetid: 79e46bdb-c773-4cbc-9212-e099b104dd49
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multiset::cend
Returns a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> iterator that addresses the location just beyond the last element in a range.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> bidirectional-access iterator that points just beyond the end of the range.  
  
## Remarks  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is used to test whether an iterator has passed the end of its range.  
  
 You can use this member function in place of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> member function to guarantee that the return value is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to be a modifiable (non-<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>) container of any kind that supports <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The value returned by <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> should not be dereferenced.  
  
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [multiset Class](../vs140/multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)