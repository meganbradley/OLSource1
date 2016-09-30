---
title: "unordered_multimap::cend"
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
  - "unordered_multimap.cend"
  - "std::tr1::unordered_multimap::cend"
  - "unordered_multimap::cend"
  - "std.tr1.unordered_multimap.cend"
  - "unordered_map/std::tr1::unordered_multimap::cend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cend method"
ms.assetid: 938f650f-dee0-4b75-8676-e620c762d383
caps.latest.revision: 14
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_multimap::cend
Returns a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> iterator that addresses the location just beyond the last element in a range.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> forward-access iterator that points just beyond the end of the range.  
  
## Remarks  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is used to test whether an iterator has passed the end of its range.  
  
 You can use this member function in place of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> member function to guarantee that the return value is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to be a modifiable (non-<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>) container of any kind that supports <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The value returned by <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> should not be dereferenced.  
  
## Requirements  
 **Header:** \<unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_multimap Class](../vs140/unordered_multimap-class.md)   
 [unordered_multimap::begin](../vs140/unordered_multimap--begin.md)