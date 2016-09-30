---
title: "binary_negate Class"
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
  - "xfunctional/std::binary_negate"
  - "std::binary_negate"
  - "binary_negate"
  - "std.binary_negate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "binary_negate class"
ms.assetid: 7b86f02c-af7e-4c7f-9df1-08addae4dd65
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# binary_negate Class
A template class providing a member function that negates the return value of a specified binary function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The binary function to be negated.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The left operand of the binary function to be negated.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The right operand of the binary function to be negated.  
  
## Return Value  
 The negation of the binary function.  
  
## Remarks  
 The template class stores a copy of a binary function object _                *Func*. It defines its member function <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> as returning **!**\_                *Func(_Left, _Right).*  
  
 The constructor of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is rarely used directly. The helper function [not2](../vs140/-functional--functions.md#not2_function) is usually preferred to declare and use the **binary_negator** adaptor predicate.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<functional>  
  
 std  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)