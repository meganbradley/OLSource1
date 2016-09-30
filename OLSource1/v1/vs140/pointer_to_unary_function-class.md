---
title: "pointer_to_unary_function Class"
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
  - "xfunctional/std::pointer_to_unary_function"
  - "pointer_to_unary_function"
  - "std.pointer_to_unary_function"
  - "std::pointer_to_unary_function"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pointer_to_unary_function function"
  - "pointer_to_unary_function class"
ms.assetid: 05600207-b916-4759-beca-6b6facd2d6f6
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# pointer_to_unary_function Class
Converts a unary function pointer into an adaptable unary function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The binary function to be converted.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The object that the                         *\*_pfunc* is called on.  
  
## Return Value  
 The template class stores a copy of **_pfunc**. It defines its member function <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> as returning (\* **_pfunc**)(_                *Left*).  
  
## Remarks  
 A unary function pointer is a function object and may be passed to any Standard Template Library algorithm that is expecting a unary function as a parameter, but it is not adaptable. To use it with an adaptor, such as binding a value to it or using it with a negator, it must be supplied with the nested types **argument_type** and **result_type** that make such an adaptation possible. The conversion by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> allows the function adaptors to work with binary function pointers.  
  
## Example  
 The constructor of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is rarely used directly. See the helper function [ptr_fun](../vs140/-functional--functions.md#ptr_fun_function) for an example of how to declare and use the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> adaptor predicate.  
  
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)