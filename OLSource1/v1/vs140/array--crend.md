---
title: "array::crend"
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
  - "std::tr1::array::crend"
  - "std.tr1.array.crend"
  - "std.array.crend"
  - "tr1::array::crend"
  - "array::crend"
  - "tr1.array.crend"
  - "array.crend"
  - "std::array::crend"
  - "array/std::tr1::array::crend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "crend method"
ms.assetid: c3ebd3f2-0d9d-4d85-8394-506039d1668c
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array::crend
Returns a const iterator that addresses the location succeeding the last element in a reversed array.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A const reverse random-access iterator that addresses the location succeeding the last element in a reversed array (the location that had preceded the first element in the unreversed array).  
  
## Remarks  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is used with a reversed array just as [cend](../vs140/array--cend.md) is used with a array.  
  
 With the return value of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> (suitably decremented), the array object cannot be modified.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its array.  
  
 The value returned by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> should not be dereferenced.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **2**  
**1**   
## Requirements  
 **Header:** \<array>  
  
 **Namespace:** std  
  
## See Also  
 [\<array>](../vs140/-array-.md)   
 [array Class](../vs140/array-class--stl-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)