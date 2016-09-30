---
title: "less_equal Struct"
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
  - "std::less_equal"
  - "xfunctional/std::less_equal"
  - "std.less_equal"
  - "less_equal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "less_equal function"
  - "less_equal struct"
ms.assetid: 32085782-c7e0-4310-9b40-8aa3c1bff211
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# less_equal Struct
A binary predicate that performs the less-than-or-equal-to operation ( <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) on its arguments.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Any type that supports an <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> that takes operands of the specified or inferred types.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The left operand of the less-than-or-equal-to operation. The unspecialized template takes an lvalue reference argument of type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. The specialized template does perfect forwarding of lvalue and rvalue reference arguments of inferred type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The right operand of the less-than-or-equal-to operation. The unspecialized template takes an lvalue reference argument of type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. The specialized template does perfect forwarding of lvalue and rvalue reference arguments of inferred type <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
## Return Value  
 The result of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. The specialized template does perfect forwarding of the result, which has the type returned by <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
## Remarks  
 The binary predicate <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>< <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>> provides a strict weak ordering of a set of element values of type <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> into equivalence classes, if and only if this type satisfies the standard mathematical requirements for being so ordered. The specializations for any pointer type yield a total ordering of elements, in that all elements of distinct values are ordered with respect to each other.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)