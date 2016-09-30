---
title: "Pointer-to-Member Operators: .* and -&gt;*"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - ".*"
  - "->*"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "expressions [C++], pointer"
  - "pointer-to-member operators"
  - ".* operator"
  - "expressions [C++], operators"
  - "->* operator"
ms.assetid: 2632be3f-1c81-4523-b56c-982a92a68688
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Pointer-to-Member Operators: .* and -&gt;*
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The pointer-to-member operators, .* and –>\*, return the value of a specific class member for the object specified on the left side of the expression.  The right side must specify a member of the class.  The following example shows how to use these operators:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 In the preceding example, a pointer to a member, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, is used to invoke the member function <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Another pointer to a member, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, is used to access the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> member.  
  
 The binary operator .* combines its first operand, which must be an object of class type, with its second operand, which must be a pointer-to-member type.  
  
 The binary operator –>* combines its first operand, which must be a pointer to an object of class type, with its second operand, which must be a pointer-to-member type.  
  
 In an expression containing the .* operator, the first operand must be of the class type of, and be accessible to, the pointer to member specified in the second operand or of an accessible type unambiguously derived from and accessible to that class.  
  
 In an expression containing the –>* operator, the first operand must be of the type "pointer to the class type" of the type specified in the second operand, or it must be of a type unambiguously derived from that class.  
  
## Example  
 Consider the following classes and program fragment:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The result of the .* or –>\* pointer-to-member operators is an object or function of the type specified in the declaration of the pointer to member. So, in the preceding example, the result of the expression <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is a pointer to a function that returns void. This result is an l-value if the second operand is an l-value.  
  
> [!NOTE]
>  If the result of one of the pointer-to-member operators is a function, then the result can be used only as an operand to the function call operator.  
  
## See Also  
 [C++ Operators](../vs140/c---operators.md)   
 [C++ Built-in Operators, Precedence and Associativity](../vs140/c---built-in-operators--precedence-and-associativity.md)