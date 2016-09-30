---
title: "unary_negate Class"
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
  - "unary_negate"
  - "std::unary_negate"
  - "std.unary_negate"
  - "xfunctional/std::unary_negate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unary_negate class"
ms.assetid: e3b86eec-3205-49b9-ab83-f55225af4e0c
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unary_negate Class
A template class providing a member function that negates the return value of a specified unary function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The unary function to be negated.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The operand of the unary function to be negated.  
  
## Return Value  
 The negation of the unary function.  
  
## Remarks  
 The template class stores a copy of a unary function object _                *Func.* It defines its member function <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> as returning **!**\_                *Func(_Left).*  
  
 The constructor of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is rarely used directly. The helper function [not1](../vs140/-functional--functions.md#not1_function) provides an easier way to declare and use the **unary_negator** adaptor predicate.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)