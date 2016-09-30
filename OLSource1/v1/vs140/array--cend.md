---
title: "array::cend"
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
  - "tr1::array::cend"
  - "array::cend"
  - "std::tr1::array::cend"
  - "std.tr1.array.cend"
  - "std.array.cend"
  - "std::array::cend"
  - "array.cend"
  - "array/std::tr1::array::cend"
  - "tr1.array.cend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cend method"
ms.assetid: 74d60967-e553-4d5e-af9a-b025c9874045
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array::cend
Returns a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> iterator that addresses the location just beyond the last element in a range.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A random-access iterator that points just beyond the end of the range.  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is used to test whether an iterator has passed the end of its range.  
  
 You can use this member function in place of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> member function to guarantee that the return value is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to be a modifiable (non-<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>) container of any kind that supports <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The value returned by <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> should not be dereferenced.  
  
## Requirements  
 **Header:** \<array>  
  
 **Namespace:** std  
  
## See Also  
 [\<array>](../vs140/-array-.md)   
 [array Class](../vs140/array-class--stl-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)