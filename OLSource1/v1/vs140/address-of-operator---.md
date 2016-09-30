---
title: "Address-of Operator: &amp;"
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
  - "address-of"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "address-of operator (&)"
  - "& operator"
  - "& operator, address-of operator"
ms.assetid: 2828221a-15f6-4acc-87fe-25e34feebb88
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Address-of Operator: &amp;
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The unary address-of operator (**&**) takes the address of its operand. The operand of the address-of operator can be either a function designator or an l-value that designates an object that is not a bit field and is not declared with the **register** storage-class specifier.  
  
 The address-of operator can only be applied to variables with fundamental, structure, class, or union types that are declared at the file-scope level, or to subscripted array references. In these expressions, a constant expression that does not include the address-of operator can be added to or subtracted from the address-of expression.  
  
 When applied to functions or l-values, the result of the expression is a pointer type (an r-value) derived from the type of the operand. For example, if the operand is of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the result of the expression is of type pointer to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. The address-of operator, applied to **const** or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> objects, evaluates to **const** <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> **\*** or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> **\***, where <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is the type of the original object.  
  
 When the address-of operator is applied to a [qualified name](assetId:///3fefb16d-8120-4627-8b3f-3d90fbdcd1df), the result depends on whether the *qualified-name* specifies a static member. If so, the result is a pointer to the type specified in the declaration of the member. If the member is not static, the result is a pointer to the member *name* of the class indicated by *qualified-class-name*. (See [Primary Expressions](../vs140/primary-expressions.md) for more about *qualified-class-name*.) The following code fragment shows how the result differs, depending on whether the member is static:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In this example, the expression <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> yields type <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> instead of type <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> because <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is a static member.  
  
 The address of an overloaded function can be taken only when it is clear which version of the function is being referenced. See [Address of Overloaded Functions](../vs140/address-of-overloaded-functions.md) for information about how to obtain the address of a particular overloaded function.  
  
 Applying the address-of operator to a reference type gives the same result as applying the operator to the object to which the reference is bound. For example:  
  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The following example uses the address-of operator to pass a pointer argument to a function:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## See Also  
 [Expressions with Unary Operators](../vs140/expressions-with-unary-operators.md)   
 [C++ Operators](../vs140/c---operators.md)   
 [C++ Built-in Operators, Precedence and Associativity](../vs140/c---built-in-operators--precedence-and-associativity.md)   
 [Lvalue Reference Declarator: &](../vs140/lvalue-reference-declarator---.md)   
 [Indirection and Address-of Operators](../vs140/indirection-and-address-of-operators.md)