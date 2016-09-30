---
title: "ptr_fun Function"
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
  - "std.ptr_fun"
  - "ptr_fun"
  - "xfunctional/std::ptr_fun"
  - "std::ptr_fun"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ptr_fun function"
  - "ptr_fun"
ms.assetid: 1b4045ed-ef88-482f-bfe6-fb621d2f50bb
caps.latest.revision: 21
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ptr_fun Function
Helper template functions used to convert unary and binary function pointers, respectively, into unary and binary adaptable functions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The unary or binary function pointer to be converted to an adaptable function.  
  
## Return Value  
 The first template function returns the unary function [pointer_to_unary_function](../vs140/pointer_to_unary_function-class.md) <<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, **Result**>(*<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>).  
  
 The second template function returns binary function [pointer_to_binary_function](../vs140/pointer_to_binary_function-class.md) \<**Arg1**, **Arg2**, **Result**>(*<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>).  
  
## Remarks  
 A function pointer is a function object and may be passed to any Standard Template Library algorithm that is expecting a function as a parameter, but it is not adaptable. To use it with an adaptor, such as binding a value to it or using it with a negator, it must be supplied with the nested types that make such an adaptation possible. The conversion of unary and binary function pointers by the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> helper function allows the function adaptors to work with unary and binary function pointers.  
  
## Example  
 [!code[functional_ptr_fun#1](../vs140/codesnippet/CPP/ptr_fun-function_1.cpp)]  
  
## Output  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)