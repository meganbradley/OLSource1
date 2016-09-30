---
title: "unordered_set::cbegin"
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
  - "std.tr1.unordered_set.cbegin"
  - "std::tr1::unordered_set::cbegin"
  - "unordered_set/std::tr1::unordered_set::cbegin"
  - "unordered_set::cbegin"
  - "unordered_set.cbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cbegin method"
ms.assetid: bb9894f5-52cc-4a47-874d-ec62c2a6b2bf
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_set::cbegin
Returns a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> iterator that addresses the first element in the range.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> forward-access iterator that points at the first element of the range, or the location just beyond the end of an empty range (for an empty range, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>).  
  
## Remarks  
 With the return value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the elements in the range cannot be modified.  
  
 You can use this member function in place of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> member function to guarantee that the return value is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to be a modifiable (non-<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>) container of any kind that supports <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_set Class](../vs140/unordered_set-class.md)   
 [unordered_set::end](../vs140/unordered_set--end.md)