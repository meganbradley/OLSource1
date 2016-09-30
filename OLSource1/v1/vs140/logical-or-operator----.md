---
title: "Logical OR Operator: ||"
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
  - "||"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OR operator, logical"
  - "|| operator"
  - "OR operator"
  - "logical OR operator"
ms.assetid: 31837c99-2655-4bf3-8ded-f13b7a9dc533
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Logical OR Operator: ||
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The logical OR operator (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) returns the boolean value **true** if either or both operands is **true** and returns **false** otherwise. The operands are implicitly converted to type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> prior to evaluation, and the result is of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Logical OR has left-to-right associativity.  
  
 The operands to the logical OR operator need not be of the same type, but they must be of integral or pointer type. The operands are commonly relational or equality expressions.  
  
 The first operand is completely evaluated and all side effects are completed before continuing evaluation of the logical OR expression.  
  
 The second operand is evaluated only if the first operand evaluates to false (0). This eliminates needless evaluation of the second operand when the logical OR expression is true.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In the above example, if <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is equal to either <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, the second argument to the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function evaluates to true and the value 1 is printed. Otherwise, it evaluates to false and the value 0 is printed. As soon as one of the conditions evaluates to true, evaluation ceases.  
  
## Operator Keyword for &#124;&#124;  
 The **or** operator is the text equivalent of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. There are two ways to access the **or** operator in your programs: include the header file <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, or compile with the [/Za](../vs140/-za---ze--disable-language-extensions-.md) (Disable language extensions) compiler option.  
  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Logical Operators](../vs140/logical-operators.md)   
 [C++ Operators](../vs140/c---operators.md)   
 [C++ Built-in Operators, Precedence and Associativity](../vs140/c---built-in-operators--precedence-and-associativity.md)   
 [C Logical Operators](../vs140/c-logical-operators.md)