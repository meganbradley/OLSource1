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
  
```  
[ <attributelist> ] [ Optional ] [{ ByVal | ByRef }] [ ParamArray ]   
parametername[( )] [ As parametertype ] [ = defaultvalue ]  
```  
  
## Parts  
 `attributelist`  
 Optional. List of attributes that apply to this parameter. You must enclose the [Attribute List](../VS_csharp/attribute-list--visual-basic-.md) in angle brackets ("`<`" and "`>`").  
  
 `Optional`  
 Optional. Specifies that this parameter is not required when the procedure is called.  
  
 `ByVal`  
 Optional. Specifies that the procedure cannot replace or reassign the variable element underlying the corresponding argument in the calling code.  
  
 `ByRef`  
 Optional. Specifies that the procedure can modify the underlying variable element in the calling code the same way the calling code itself can.  
  
 `ParamArray`  
 Optional. Specifies that the last parameter in the parameter list is an optional array of elements of the specified data type. This lets the calling code pass an arbitrary number of arguments to the procedure.  
  
 `parametername`  
 Required. Name of the local variable representing the parameter.  
  
 `parametertype`  
 Required if `Option Strict` is `On`. Data type of the local variable representing the parameter.  
  
 `defaultvalue`  
 Required for `Optional` parameters. Any constant or constant expression that evaluates to the data type of the parameter. If the type is `Object`, or a class, interface, array, or structure, the default value can only be `Nothing`.  
  
## Remarks  
 Parameters are surrounded by parentheses and separated by commas. A parameter can be declared with any data type. If you do not specify `parametertype`, it defaults to `Object`.  
  
 When the calling code calls the procedure, it passes an *argument* to each required parameter. For more information, see [Differences Between Parameters and Arguments](../VS_csharp/differences-between-parameters-and-arguments--visual-basic-.md).  
  
 The argument the calling code passes to each parameter is a pointer to an underlying element in the calling code. If this element is *nonvariable* (a constant, literal, enumeration, or expression), it is impossible for any code to change it. If it is a *variable* element (a declared variable, field, property, array element, or structure element), the calling code can change it. For more information, see [Differences Between Variable and Nonvariable Arguments](../VS_csharp/differences-between-modifiable-and-nonmodifiable-arguments--visual-basic-.md).  
  
 If a variable element is passed `ByRef`, the procedure can change it as well. For more information, see [Differences Between Passing an Argument By Value and By Reference](../VS_csharp/differences-between-passing-an-argument-by-value-and-by-reference--visual-basic-.md).  
  
## Rules  
  
-   **Parentheses.** If you specify a parameter list, you must enclose it in parentheses. If there are no parameters, you can still use parentheses enclosing an empty list. This improves the readability of your code by clarifying that the element is a procedure.  
  
-   **Optional Parameters.** If you use the `Optional` modifier on a parameter, all subsequent parameters in the list must also be optional and be declared by using the `Optional` modifier.  
  
     Every optional parameter declaration must supply the `defaultvalue` clause.  
  
     For more information, see [Optional Parameters](../VS_csharp/optional-parameters--visual-basic-.md).  
  
-   **Parameter Arrays.** You must specify `ByVal` for a `ParamArray` parameter.  
  
     You cannot use both `Optional` and `ParamArray` in the same parameter list.  
  
     For more information, see [Parameter Arrays](../VS_csharp/parameter-arrays--visual-basic-.md).  
  
-   **Passing Mechanism.** The default mechanism for every argument is `ByVal`, which means the procedure cannot change the underlying variable element. However, if the element is a reference type, the procedure can modify the contents or members of the underlying object, even though it cannot replace or reassign the object itself.  
  
-   **Parameter Names.** If the parameter's data type is an array, follow `parametername` immediately by parentheses. For more information on parameter names, see [Declared Element Names](../VS_csharp/declared-element-names--visual-basic-.md).  
  
## Example  
 The following example shows a `Function` procedure that defines two parameters.  
  
 [!code[VbVbalrStatements#2](../VS_csharp/codesnippet/VisualBasic/parameter-list--visual-basic-_1.vb)]  
  
## See Also  
 <xref:System.Runtime.InteropServices.DllImportAttribute*>   
 [Function Statement](../VS_csharp/function-statement--visual-basic-.md)   
 [Sub Statement](../VS_csharp/sub-statement--visual-basic-.md)   
 [Declare Statement](../VS_csharp/declare-statement.md)   
 [Structure Statement](../VS_csharp/structure-statement.md)   
 [Option Strict Statement](../VS_csharp/option-strict-statement.md)   
 [Attributes (C# and Visual Basic)](../VS_csharp/attributes--csharp-and-visual-basic-.md)   
 [How to: Break and Combine Statements in Code](../VS_csharp/how-to--break-and-combine-statements-in-code--visual-basic-.md)