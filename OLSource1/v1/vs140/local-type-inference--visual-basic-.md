---
title: "Local Type Inference (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "local type inference"
  - "vb.TypeInfer"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Option Infer statement"
  - "local type inference [Visual Basic]"
  - "implicitly-typed local variables [Visual Basic]"
  - "variables [Visual Basic], type inference"
  - "inference [Visual Basic]"
  - "type inference [Visual Basic]"
ms.assetid: b8307f18-2e56-4ab3-a45a-826873f400f6
caps.latest.revision: 47
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Local Type Inference (Visual Basic)
The Visual Basic compiler uses *type inference* to determine the data types of local variables declared without an <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> clause. The compiler infers the type of the variable from the type of the initialization expression. This enables you to declare variables without explicitly stating a type, as shown in the following example. As a result of the declarations, both <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> are strongly typed as integers.  
  
 [!code[VbVbalrTypeInference#1](../vs140/codesnippet/VisualBasic/local-type-inference--visual-basic-_1.vb)]  
  
> [!NOTE]
>  If you do not want <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in the previous example to be typed as an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, you can specify another type by using a declaration like <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 Local type inference applies at procedure level. It cannot be used to declare variables at module level (within a class, structure, module, or interface but not within a procedure or block). If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in the previous example were a field of a class instead of a local variable in a procedure, the declaration would cause an error with <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> on, and would classify <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> as an <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> off. Similarly, local type inference does not apply to procedure level variables declared as <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Type Inference vs. Late Binding  
 Code that uses type inference resembles code that relies on late binding. However, type inference strongly types the variable instead of leaving it as <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. The compiler uses a variable's initializer to determine the variable's type at compile time to produce early-bound code. In the previous example, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, like <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, is typed as an <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 The behavior of early-bound variables differs from that of late-bound variables, for which the type is known only at run time. Knowing the type early enables the compiler to identify problems before execution, allocate memory precisely, and perform other optimizations. Early binding also enables the Visual Basic integrated development environment (IDE) to provide IntelliSense Help about the members of an object. Early binding is also preferred for performance. This is because all data stored in a late-bound variable must be wrapped as type <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, and accessing members of the type at run time makes the program slower.  
  
## Examples  
 Type inference occurs when a local variable is declared without an <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> clause and initialized. The compiler uses the type of the assigned initial value as the type of the variable. For example, each of the following lines of code declares a variable of type <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrTypeInference#2](../vs140/codesnippet/VisualBasic/local-type-inference--visual-basic-_2.vb)]  
  
 The following code demonstrates two equivalent ways to create an array of integers.  
  
 [!code[VbVbalrTypeInference#3](../vs140/codesnippet/VisualBasic/local-type-inference--visual-basic-_3.vb)]  
  
 It is convenient to use type inference to determine the type of a loop control variable. In the following code, the compiler infers that <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is an <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> because <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> from the previous example is an array of integers.  
  
 [!code[VbVbalrTypeInference#4](../vs140/codesnippet/VisualBasic/local-type-inference--visual-basic-_4.vb)]  
  
 Local type inference can be used in <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> statements to establish the type of the resource name, as the following example demonstrates.  
  
 [!code[VbVbalrTypeInference#7](../vs140/codesnippet/VisualBasic/local-type-inference--visual-basic-_5.vb)]  
  
 The type of a variable can also be inferred from the return values of functions, as the following example demonstrates. Both <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> are arrays of processes because <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> returns an array of processes.  
  
 [!code[VbVbalrTypeInference#5](../vs140/codesnippet/VisualBasic/local-type-inference--visual-basic-_6.vb)]  
  
## Option Infer  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> enables you specify whether local type inference is allowed in a particular file. To enable or to block the option, type one of the following statements at the start of the file.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
 If you do not specify a value for <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> in your code, the compiler default is <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>. For projects upgraded from [!INCLUDE[vb_orcas_long](../vs140/includes/vb_orcas_long_md.md)] or earlier, the compiler default is <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
 If the value set for <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> in a file conflicts with the value set in the IDE or on the command line, the value in the file has precedence.  
  
 For more information, see [Option Infer Statement](../vs140/option-infer-statement.md) and [Compile Page, Project Designer (Visual Basic)](../vs140/compile-page--project-designer--visual-basic-.md).  
  
## Restrictions  
 Type inference can be used only for non-static local variables; it cannot be used to determine the type of class fields, properties, or functions.  
  
## See Also  
 [Anonymous Types](../vs140/anonymous-types--visual-basic-.md)   
 [Early and Late Binding](../vs140/early-and-late-binding--visual-basic-.md)   
 [For Each...Next Statement (Visual Basic)](../vs140/for-each...next-statement--visual-basic-.md)   
 [For...Next Statement (Visual Basic)](../vs140/for...next-statement--visual-basic-.md)   
 [Option Infer Statement](../vs140/option-infer-statement.md)   
 [/optioninfer](../vs140/-optioninfer.md)   
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)