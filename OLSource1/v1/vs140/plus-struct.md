---
title: "plus Struct"
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
  - "xfunctional/std::plus"
  - "std.plus"
  - "plus"
  - "std::plus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "plus class"
  - "plus struct"
ms.assetid: 4594abd5-b2f2-4fac-9b6b-fc9a2723f8cf
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# plus Struct
A predefined function object that performs the addition operation (binary <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>) on its arguments.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A type that supports a binary <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> that takes operands of the specified or inferred types.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The left operand of the addition operation. The unspecialized template takes an lvalue reference argument of type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. The specialized template does perfect forwarding of lvalue and rvalue reference arguments of inferred type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The right operand of the addition operation. The unspecialized template takes an lvalue reference argument of type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. The specialized template does perfect forwarding of lvalue and rvalue reference arguments of inferred type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Return Value  
 The result of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. The specialized template does perfect forwarding of the result, which has the type that's returned by binary <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)