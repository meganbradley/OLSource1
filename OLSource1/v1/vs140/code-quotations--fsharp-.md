---
title: "Code Quotations (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "code quotations [F#]"
  - "quotations [F#]"
ms.assetid: 6f055397-a1f0-4f9a-927c-f0d7c6951155
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Code Quotations (F#)
This topic describes *code quotations*, a language feature that enables you to generate and work with F# code expressions programmatically. This feature lets you generate an abstract syntax tree that represents F# code. The abstract syntax tree can then be traversed and processed according to the needs of your application. For example, you can use the tree to generate F# code or generate code in some other language.  
  
## Quoted Expressions  
 A *quoted expression* is an F# expression in your code that is delimited in such a way that it is not compiled as part of your program, but instead is compiled into an object that represents an F# expression. You can mark a quoted expression in one of two ways: either with type information or without type information. If you want to include type information, you use the symbols<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to delimit the quoted expression. If you do not need type information, you use the symbols <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. The following code shows typed and untyped quotations.  
  
 [!code[FsLangRef3#501](../vs140/codesnippet/FSharp/code-quotations--fsharp-_1.fs)]  
  
 Traversing a large expression tree is faster if you do not include type information. The resulting type of an expression quoted with the typed symbols is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, where the type parameter has the type of the expression as determined by the F# compiler's type inference algorithm. When you use code quotations without type information, the type of the quoted expression is the non-generic type [Expr](../vs140/quotations.expr-class--fsharp-.md). You can call the [Raw](../vs140/expr.raw--t--property--fsharp-.md) property on the typed <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> class to obtain the untyped <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.  
  
 There are a variety of static methods that allow you to generate F# expression objects programmatically in the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> class without using quoted expressions.  
  
 Note that a code quotation must include a complete expression. For a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> binding, for example, you need both the definition of the bound name and an additional expression that uses the binding. In verbose syntax, this is an expression that follows the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> keyword. At the top-level in a module, this is just the next expression in the module, but in a quotation, it is explicitly required.  
  
 Therefore, the following expression is not valid.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 But the following expressions are valid.  
  
 [!code[FsLangRef3#502](../vs140/codesnippet/FSharp/code-quotations--fsharp-_2.fs)]  
  
 To use code quotations, you must add an import declaration (by using the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> keyword) that opens the [Microsoft.FSharp.Quotations](../vs140/microsoft.fsharp.quotations-namespace--fsharp-.md) namespace.  
  
 The F# PowerPack provides support for evaluating and executing F# expression objects.  
  
## Expr Type  
 An instance of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> type represents an F# expression. Both the generic and the non-generic <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> types are documented in the F# library documentation. For more information, see [Microsoft.FSharp.Quotations Namespace (F#)](../vs140/microsoft.fsharp.quotations-namespace--fsharp-.md) and [Quotations.Expr Class (F#)](../vs140/quotations.expr-class--fsharp-.md).  
  
## Splicing Operators  
 Splicing enables you to combine literal code quotations with expressions that you have created programmatically or from another code quotation. The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> operators enable you to add an F# expression object into a code quotation. You use the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> operator to insert a typed expression object into a typed quotation; you use the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> operator to insert an untyped expression object into an untyped quotation. Both operators are unary prefix operators. Thus if <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is an untyped expression of type <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, the following code is valid.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 And if <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is a typed quotation of type <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, the following code is valid.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
  
### Description  
 The following example illustrates the use of code quotations to put F# code into an expression object and then print the F# code that represents the expression. A function <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is defined that contains a recursive function <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> that displays an F# expression object (of type <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>) in a friendly format. There are several active patterns in the [Microsoft.FSharp.Quotations.Patterns](../vs140/quotations.patterns-module--fsharp-.md) and [Microsoft.FSharp.Quotations.DerivedPatterns](../vs140/quotations.derivedpatterns-module--fsharp-.md) modules that can be used to analyze expression objects. This example does not include all the possible patterns that might appear in an F# expression. Any unrecognized pattern triggers a match to the wildcard pattern (<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>) and is rendered by using the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> method, which, on the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> type, lets you know the active pattern to add to your match expression.  
  
### Code  
 [!code[FsLangRef3#601](../vs140/codesnippet/FSharp/code-quotations--fsharp-_3.fs)]  
  
### Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Example  
  
### Description  
 You can also use the three active patterns in the [ExprShape module](../vs140/quotations.exprshape-module--fsharp-.md) to traverse expression trees with fewer active patterns. These active patterns can be useful when you want to traverse a tree but you do not need all the information in most of the nodes. When you use these patterns, any F# expression matches one of the following three patterns: <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> if the expression is a variable, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> if the expression is a lambda expression, or <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> if the expression is anything else. If you traverse an expression tree by using the active patterns as in the previous code example, you have to use many more patterns to handle all possible F# expression types, and your code will be more complex. For more information, see [ExprShape.ShapeVar&#124;ShapeLambda&#124;ShapeCombination Active Pattern (F#)](../vs140/exprshape.shapevar-shapelambda-shapecombination-active-pattern--fsharp-.md).  
  
 The following code example can be used as a basis for more complex traversals. In this code, an expression tree is created for an expression that involves a function call, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>. The [SpecificCall](../vs140/derivedpatterns.specificcall-active-pattern--fsharp-.md) active pattern is used to detect any call to <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> in the expression tree. This active pattern assigns the arguments of the call to the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> value. In this case, there are only two, so these are pulled out and the function is called recursively on the arguments. The results are inserted into a code quotation that represents a call to <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> by using the splice operator (<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>). The <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> function from the previous example is used to display the results.  
  
 The code in the other active pattern branches just regenerates the same expression tree, so the only change in the resulting expression is the change from <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
### Code  
 [!code[FsLangRef3#701](../vs140/codesnippet/FSharp/code-quotations--fsharp-_4.fs)]  
  
### Output  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 [F# Language Reference](../vs140/fsharp-language-reference.md)