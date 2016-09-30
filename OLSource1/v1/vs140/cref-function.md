---
title: "cref Function"
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
  - "std::tr1::cref"
  - "cref"
  - "std.tr1.cref"
  - "functional/std::tr1::cref"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cref function [TR1]"
ms.assetid: c3681448-0150-46eb-b21b-99140476637c
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# cref Function
Constructs a const <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> from an argument.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The type of the argument to wrap.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The argument to wrap.  
  
## Remarks  
 The first function returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. You use it to wrap a const reference. The second function returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. You use it to rewrap a wrapped reference as a const reference.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **i = 1**  
**cref(i) = 1**  
**cref(neg)(i) = -1**   
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [ref](../vs140/ref-function.md)   
 [reference_wrapper](../vs140/reference_wrapper-class.md)