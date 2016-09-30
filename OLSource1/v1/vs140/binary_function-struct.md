---
title: "binary_function Struct"
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
  - "std.binary_function"
  - "functional/std::binary_function"
  - "std::binary_function"
  - "binary_function"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "binary_function class"
ms.assetid: 79b6d53d-644c-4add-b0ba-3a5f40f69c60
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# binary_function Struct
An empty base struct that defines types that may be inherited by derived classes that provides a binary function object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The template struct serves as a base for classes that define a member function of the form:  
  
 **result_type operator()**( **constfirst_argument_type&**,  
  
 **const second_argument_type&** ) **const**  
  
 All such binary functions can refer to their first argument type as **first_argument_type**, their second argument type as **second_argument_type**, and their return type as ***result_type***.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [binary_function Sample](../vs140/binary_function-structure-sample.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)