---
title: "modulus Struct"
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
  - "modulus"
  - "std::modulus"
  - "xfunctional/std::modulus"
  - "std.modulus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "modulus class"
  - "modulus struct"
ms.assetid: 86d342f7-b7b1-46a4-b0bb-6b7ae827369b
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# modulus Struct
A predefined function object that performs the modulus division operation ( <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>) on its arguments.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Any type that supports an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> that takes operands of the specified or inferred types.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The left operand of the modulus operation. The unspecialized template takes an lvalue reference argument of type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. The specialized template does perfect forwarding of lvalue and rvalue reference arguments of inferred type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The right operand of the modulus operation. The unspecialized template takes an lvalue reference argument of type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. The specialized template does perfect forwarding of lvalue and rvalue reference arguments of inferred type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Return Value  
 The result of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. The specialized template does perfect forwarding of the result, which has the type that's returned by <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> functor is restricted to integral types for the basic data types, or to user-defined types that implement <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)