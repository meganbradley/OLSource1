---
title: "Sequential-Evaluation Operator"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "operators [C++], sequential-evaluation"
  - "sequential-evaluation operator"
  - "comma operator"
ms.assetid: 587514f4-c8e2-44e9-81a8-7a553ce1453a
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Sequential-Evaluation Operator
The sequential-evaluation operator, also called the "comma operator," evaluates its two operands sequentially from left to right.  
  
## Syntax  
 *expression*:  
 *assignment-expression*  
  
 *expression*  **,**  *assignment-expression*  
  
 The left operand of the sequential-evaluation operator is evaluated as a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> expression. The result of the operation has the same value and type as the right operand. Each operand can be of any type. The sequential-evaluation operator does not perform type conversions between its operands, and it does not yield an l-value. There is a sequence point after the first operand, which means all side effects from the evaluation of the left operand are completed before beginning evaluation of the right operand. See [Sequence Points](../vs140/c-sequence-points.md) for more information.  
  
 The sequential-evaluation operator is typically used to evaluate two or more expressions in contexts where only one expression is allowed.  
  
 Commas can be used as separators in some contexts. However, you must be careful not to confuse the use of the comma as a separator with its use as an operator; the two uses are completely different.  
  
## Example  
 This example illustrates the sequential-evaluation operator:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In this example, each operand of the **for** statement's third expression is evaluated independently. The left operand <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is evaluated first; then the right operand, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, is evaluated.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In the function call to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, three arguments, separated by commas, are passed: <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. In the function call to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, parentheses force the compiler to interpret the first comma as the sequential-evaluation operator. This function call passes two arguments to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The first argument is the result of the sequential-evaluation operation <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, which has the value and type of the expression <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>; the second argument is <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
## See Also  
 [Comma Operator: ,](../vs140/comma-operator---.md)