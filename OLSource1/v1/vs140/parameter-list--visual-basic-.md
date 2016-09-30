---
title: "Parameter List (Visual Basic)"
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
  - "Visual Basic code, procedures"
  - "parameters, Visual Basic"
  - "parameters, lists"
  - "parameter lists"
  - "Visual Basic code, parameter lists"
  - "arguments [Visual Basic], Visual Basic"
  - "procedures, parameter lists"
ms.assetid: 5d737319-0c34-4df9-a23d-188fc840becd
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Parameter List (Visual Basic)
Specifies the parameters a procedure expects when it is called. Multiple parameters are separated by commas. The following is the syntax for one parameter.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Optional. List of attributes that apply to this parameter. You must enclose the [Attribute List](../vs140/attribute-list--visual-basic-.md) in angle brackets ("<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>" and "<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>").  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Optional. Specifies that this parameter is not required when the procedure is called.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Optional. Specifies that the procedure cannot replace or reassign the variable element underlying the corresponding argument in the calling code.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Optional. Specifies that the procedure can modify the underlying variable element in the calling code the same way the calling code itself can.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Optional. Specifies that the last parameter in the parameter list is an optional array of elements of the specified data type. This lets the calling code pass an arbitrary number of arguments to the procedure.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Required. Name of the local variable representing the parameter.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Required if <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. Data type of the local variable representing the parameter.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Required for <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameters. Any constant or constant expression that evaluates to the data type of the parameter. If the type is <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, or a class, interface, array, or structure, the default value can only be <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
## Remarks  
 Parameters are surrounded by parentheses and separated by commas. A parameter can be declared with any data type. If you do not specify <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, it defaults to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
 When the calling code calls the procedure, it passes an *argument* to each required parameter. For more information, see [Differences Between Parameters and Arguments](../vs140/differences-between-parameters-and-arguments--visual-basic-.md).  
  
 The argument the calling code passes to each parameter is a pointer to an underlying element in the calling code. If this element is *nonvariable* (a constant, literal, enumeration, or expression), it is impossible for any code to change it. If it is a *variable* element (a declared variable, field, property, array element, or structure element), the calling code can change it. For more information, see [Differences Between Variable and Nonvariable Arguments](../vs140/differences-between-modifiable-and-nonmodifiable-arguments--visual-basic-.md).  
  
 If a variable element is passed <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, the procedure can change it as well. For more information, see [Differences Between Passing an Argument By Value and By Reference](../vs140/differences-between-passing-an-argument-by-value-and-by-reference--visual-basic-.md).  
  
## Rules  
  
-   **Parentheses.** If you specify a parameter list, you must enclose it in parentheses. If there are no parameters, you can still use parentheses enclosing an empty list. This improves the readability of your code by clarifying that the element is a procedure.  
  
-   **Optional Parameters.** If you use the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> modifier on a parameter, all subsequent parameters in the list must also be optional and be declared by using the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> modifier.  
  
     Every optional parameter declaration must supply the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> clause.  
  
     For more information, see [Optional Parameters](../vs140/optional-parameters--visual-basic-.md).  
  
-   **Parameter Arrays.** You must specify <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> for a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> parameter.  
  
     You cannot use both <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> in the same parameter list.  
  
     For more information, see [Parameter Arrays](../vs140/parameter-arrays--visual-basic-.md).  
  
-   **Passing Mechanism.** The default mechanism for every argument is <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, which means the procedure cannot change the underlying variable element. However, if the element is a reference type, the procedure can modify the contents or members of the underlying object, even though it cannot replace or reassign the object itself.  
  
-   **Parameter Names.** If the parameter's data type is an array, follow <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> immediately by parentheses. For more information on parameter names, see [Declared Element Names](../vs140/declared-element-names--visual-basic-.md).  
  
## Example  
 The following example shows a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> procedure that defines two parameters.  
  
 [!code[VbVbalrStatements#2](../vs140/codesnippet/VisualBasic/parameter-list--visual-basic-_1.vb)]  
  
## See Also  
 \<xref:System.Runtime.InteropServices.DllImportAttribute*>   
 [Function Statement](../vs140/function-statement--visual-basic-.md)   
 [Sub Statement](../vs140/sub-statement--visual-basic-.md)   
 [Declare Statement](../vs140/declare-statement.md)   
 [Structure Statement](../vs140/structure-statement.md)   
 [Option Strict Statement](../vs140/option-strict-statement.md)   
 [Attributes (C# and Visual Basic)](../vs140/attributes--csharp-and-visual-basic-.md)   
 [How to: Break and Combine Statements in Code](../vs140/how-to--break-and-combine-statements-in-code--visual-basic-.md)