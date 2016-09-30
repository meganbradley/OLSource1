---
title: "Function Procedures (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Function procedures"
  - "return values, function procedures"
  - "Visual Basic code, procedures"
  - "procedures, calling"
  - "procedures, Function procedures"
  - "syntax, function procedures"
ms.assetid: 1b9f632c-553b-4cb6-920a-ded117ead8c0
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Function Procedures (Visual Basic)
A <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> procedure is a series of [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] statements enclosed by the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statements. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> procedure performs a task and then returns control to the calling code. When it returns control, it also returns a value to the calling code.  
  
 Each time the procedure is called, its statements run, starting with the first executable statement after the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> statement and ending with the first <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> statement encountered.  
  
 You can define a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> procedure in a module, class, or structure. It is <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> by default, which means you can call it from anywhere in your application that has access to the module, class, or structure in which you defined it.  
  
 A <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> procedure can take arguments, such as constants, variables, or expressions, which are passed to it by the calling code.  
  
## Declaration Syntax  
 The syntax for declaring a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> procedure is as follows:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The *modifiers* can specify access level and information regarding overloading, overriding, sharing, and shadowing. For more information, see [Function Statement](../vs140/function-statement--visual-basic-.md).  
  
 You declare each parameter the same way you do for [Sub Procedures](../vs140/sub-procedures--visual-basic-.md).  
  
### Data Type  
 Every <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> procedure has a data type, just as every variable does. This data type is specified by the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> clause in the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> statement, and it determines the data type of the value the function returns to the calling code. The following sample declarations illustrate this.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 For more information, see "Parts" in [Function Statement (Visual Basic)](../vs140/function-statement--visual-basic-.md).  
  
## Returning Values  
 The value a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> procedure sends back to the calling code is called its return value. The procedure returns this value in one of two ways:  
  
-   It uses the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> statement to specify the return value, and returns control immediately to the calling program. The following example illustrates this.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
-   It assigns a value to its own function name in one or more statements of the procedure. Control does not return to the calling program until an <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> statement is executed. The following example illustrates this.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The advantage of assigning the return value to the function name is that control does not return from the procedure until it encounters an <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> statement. This allows you to assign a preliminary value and adjust it later if necessary.  
  
 For more information about returning values, see [Function Statement (Visual Basic)](../vs140/function-statement--visual-basic-.md). For information about returning arrays, see [Arrays in Visual Basic](../vs140/arrays-in-visual-basic.md).  
  
## Calling Syntax  
 You invoke a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> procedure by including its name and arguments either on the right side of an assignment statement or in an expression. You must provide values for all arguments that are not optional, and you must enclose the argument list in parentheses. If no arguments are supplied, you can optionally omit the parentheses.  
  
 The syntax for a call to a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> procedure is as follows:  
  
 *lvalue*  <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  *functionname* <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> *argumentlist* <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> *functionname* <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> *argumentlist* <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  *expression* <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  
 When you call a <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> procedure, you do not have to use its return value. If you do not, all the actions of the function are performed, but the return value is ignored. \<xref:Microsoft.VisualBasic.Interaction.MsgBox*> is often called in this manner.  
  
### Illustration of Declaration and Call  
 The following <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> procedure calculates the longest side, or hypotenuse, of a right triangle, given the values for the other two sides.  
  
 [!code[VbVbcnProcedures#1](../vs140/codesnippet/VisualBasic/function-procedures--visual-basic-_1.vb)]  
  
 The following example shows a typical call to <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
 [!code[VbVbcnProcedures#6](../vs140/codesnippet/VisualBasic/function-procedures--visual-basic-_2.vb)]  
  
## See Also  
 [Procedures in Visual Basic](../vs140/procedures-in-visual-basic.md)   
 [Sub Procedures](../vs140/sub-procedures--visual-basic-.md)   
 [Property Procedures](../vs140/property-procedures--visual-basic-.md)   
 [Operator Procedures](../vs140/operator-procedures--visual-basic-.md)   
 [Procedure Parameters and Arguments](../vs140/procedure-parameters-and-arguments--visual-basic-.md)   
 [Function Statement](../vs140/function-statement--visual-basic-.md)   
 [How to: Create a Procedure that Returns a Value](../vs140/how-to--create-a-procedure-that-returns-a-value--visual-basic-.md)   
 [How to: Return a Value from a Procedure](../vs140/how-to--return-a-value-from-a-procedure--visual-basic-.md)   
 [How to: Call a Procedure that Returns a Value](../vs140/how-to--call-a-procedure-that-returns-a-value--visual-basic-.md)