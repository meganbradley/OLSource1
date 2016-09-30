---
title: "equal_to Struct"
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
  - "std::equal_to"
  - "equal_to"
  - "xfunctional/std::equal_to"
  - "std.equal_to"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "equal_to function"
  - "equal_to struct"
ms.assetid: 8e4f2b50-b2db-48e3-b4cc-6cc03362c2a6
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# equal_to Struct
A binary predicate that performs the equality operation (            <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>) on its arguments.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>,                     <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>,                     <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Any type that supports an                         <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> that takes operands of the specified or inferred types.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The left operand of the equality operation. The unspecialized template takes an lvalue reference argument of type                         <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. The specialized template does perfect forwarding of lvalue and rvalue reference arguments of inferred type                         <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The right operand of the equality operation. The unspecialized template takes an lvalue reference argument of type                         <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. The specialized template does perfect forwarding of lvalue and rvalue reference arguments of inferred type                         <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Return Value  
 The result of                 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. The specialized template does perfect forwarding of the result, which has the type that's returned by                 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## Remarks  
 The objects of type                 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> must be equality-comparable. This requires that the                 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> defined on the set of objects satisfies the mathematical properties of an equivalence relation. All of the built-in numeric and pointer types satisfy this requirement.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The vector v1 = ( 0 1 4 5 8 9 )**  
**The vector v2 = ( -0 1 -4 5 -8 9 )**  
**The result of the element-wise equal_to comparison**  
**between v1 & v2 is: ( 1 1 0 1 0 1 )**