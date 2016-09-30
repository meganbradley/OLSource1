---
title: "bit_and Function"
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
  - "bit_and"
  - "functional/std::bit_and"
  - "std.bit_and"
  - "std::bit_and"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bit_and function"
ms.assetid: f82603ca-520e-4f21-83d1-d48956fb6a32
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bit_and Function
A predefined function object that performs the bitwise AND operation (binary <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>) on its arguments.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Any type that supports an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> that takes operands of the specified or inferred types.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The left operand of the bitwise AND operation. The unspecialized template takes an lvalue reference argument of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. The specialized template does perfect forwarding of lvalue and rvalue reference arguments of inferred type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The right operand of the bitwise AND operation. The unspecialized template takes an lvalue reference argument of type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The specialized template does perfect forwarding of lvalue and rvalue reference arguments of inferred type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Return Value  
 The result of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. The specialized template does perfect forwarding of the result, which has the type that's returned by <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> functor is restricted to integral types for the basic data types, or to user-defined types that implement binary <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [\<functional>](../vs140/-functional-.md)   
 [lvalues and rvalues](../vs140/lvalues-and-rvalues--visual-c---.md)   
 [Standard Template Library](../vs140/standard-template-library.md)