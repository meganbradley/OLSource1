---
title: "make_tuple Function"
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
  - "std.tr1.make_tuple"
  - "std::tr1::make_tuple"
  - "make_tuple"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "make_tuple function [TR1]"
ms.assetid: 54ad5240-3afe-40b6-97df-27bbc8b995fa
caps.latest.revision: 22
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# make_tuple Function
Makes a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> from element values.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The type of the Nth function parameter.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The value of the Nth function parameter.  
  
## Remarks  
 The template function returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, where each type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> when the corresponding type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>; otherwise, it is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 One advantage of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is that the types of objects that are being stored are determined automatically by the compiler and do not have to be explicitly specified. Don't use explicit template arguments such as <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> when you use <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> because it is unnecessarily verbose and adds complex rvalue reference problems that might cause compilation failure.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** \<tuple>  
  
 **Namespace:** std  
  
## See Also  
 [\<tuple>](../vs140/-tuple-.md)   
 [tie](../vs140/tie-function.md)