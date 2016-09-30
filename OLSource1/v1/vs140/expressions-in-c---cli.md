---
title: "Expressions in C++-CLI"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Expressions in C++/CLI"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "Visual C++, expressions"
  - "debugger, expressions"
  - "expressions [C++], managed code"
ms.assetid: 3d29f568-0df8-4c58-9e90-ea8ad2bcf50a
caps.latest.revision: 26
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expressions in C++-CLI
The managed expression evaluator accepts most expressions written in [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)]. The following topics offer specific information and discuss some of the expression types that are not supported:  
  
-   Identifiers and Types  
  
-   Function Evaluation  
  
-   Operators  
  
-   Overloaded Operators  
  
-   Strings  
  
-   Casts  
  
-   Object Comparison and Assignment  
  
-   typeof and sizeof Operators  
  
-   Boxing  
  
-   Property Evaluation  
  
 The expression evaluator ignores access qualifiers, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. You can call a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method from the **Watch** window, for example.  
  
 The expression evaluator performs all evaluations in an implicit unsafe context, whether the code being executed is safe or unsafe.  
  
 The debugger uses autoexpand rules to display the contents of a data type in meaningful form. If you need to, you can add custom autoexpand elements to display your own custom data types. For more information, see [Displaying Elements of a Custom Data Type](../vs140/create-custom-views-of-.managed-objects.md).  
  
## Identifiers and Types  
 Debugger expressions can use any identifier visible within the current scope. If the debugger is halted in function <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, for example, you can use any identifier visible within <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, including constants, variable names, and function names.  
  
 The debugger can correctly display any variable of a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> type. For variables of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> type, the debugger correctly displays the value based on the derived-most type. If you have an object <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, derived from type <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, you can evaluate <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and get the correct value for an object of type <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 You can assign a new value to any left-hand-side expression that is an l-value of a primitive type. Assignments to class and array types are not supported.  
  
## Function Evaluation  
 The debugger supports the evaluation of functions, including overloaded functions. Therefore, you can enter either of the following expressions, and the debugger will call the correct version of the overloaded function:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Evaluating a function in the debugger actually calls and executes the code for that function. If the function has side effects, such as allocating memory or changing the value of a global variable, evaluating the function in a debugger window will change the state of your program, which can produce unexpected results.  
  
 When you set a breakpoint on an overloaded function, the location of the breakpoint depends on how you specify the function. If you specify only the function name, the debugger will set one breakpoint on each overload of that function name. If you specify the complete signature, the function name and full argument list, the debugger sets one breakpoint on the specified overload.  
  
## Operators  
 The debugger correctly evaluates most built-in operators, including:  
  
-   Relational operators: (*expr1* >*expr2*, *expr1* < *expr2*, *expr1* \<= *expr2*, *expr1* => *expr2*, *expr1* == *expr2*, *expr1* != *expr2*).  
  
-   Boolean operators: (*expr1* && *expr2*, *expr1* &#124;&#124; *expr2*).  
  
-   Conditional operator:  (*expr1* ? *expr2* : *expr3*) .  
  
-   Arithmetical operators: ( *expr1* + *expr2*, *expr1* - *expr2*,*expr1* \* *expr2*, *expr1* / *expr2*, *expr1* % *expr2*).  
  
-   Bitwise operators: (*expr1* & *expr2*, *expr1* ^ *expr2*, *expr1* &#124; *expr2*, *expr1* ~ *expr2*).  
  
-   Shift operators. Examples: (*expr1* >>*expr2*, *expr1* <\<*expr2*, *expr1* >>> *expr2*).  
  
-   Assignment operators: ( *lvalue* = *expr2*, *lvalue* \*= *expr2*, *lvalue* /= *expr2*, *lvalue* %= *expr2*, *lvalue* += *expr2*, *lvalue* -= *expr2*, *lvalue* <\<= *expr2*, *lvalue* >>=*expr2*, *lvalue* &= *expr2*, *lvalue* ^= *expr2*, *lvalue* &#124;= *expr2* ).  
  
-   Unary operators. Examples: ( +*expr1*, - *expr1*, *expr1*++, ++*expr1*, *expr1*--, --*expr1* ).  
  
 You can use the comma operator to enter a series of expressions: *expr1*, *expr*2,*expr3*.  
  
## Overloaded Operators  
 Most overloaded operators work in the debugger.  
  
 Overloaded infix operators +, -, /, %, and & work:  
  
-   *expr1* + *expr2*  
  
-   *expr1* *expr2*  
  
-   *expr1* / *expr2*  
  
-   *expr1* % *expr2*  
  
-   *expr1* & *expr2*  
  
 Overloaded infix operators =, &&, &, &#124;&#124;, &#124;, and ^ do not work:  
  
-   *expr1* = *expr2*  
  
-   *expr1* && *expr2*  
  
-   *expr1* & *expr2*  
  
-   *expr1* &#124;&#124; *expr2*  
  
-   *expr1* &#124; *expr2*  
  
-   *expr1* ^ *expr2*  
  
 Overloaded relational operators ==, !=, >, \<, >=, and \<= do not work for C++:  
  
-   *expr1* == *expr2*  
  
-   *expr1* != *expr2*  
  
-   *expr1* > *expr2*  
  
-   *expr1* \< *expr2*  
  
-   *expr1* >= *expr2*  
  
-   *expr1* <= *expr2*  
  
 Overloaded infix operators &#124;, ^, <\<, >>, >, \<, >=, and <= do not work:  
  
-   *expr1* &#124; *expr2*  
  
-   *expr1* ^ *expr2*  
  
-   *expr1* <\< *expr2*  
  
-   *expr1* >> *expr2*  
  
-   *expr1* > *expr2*  
  
-   *expr1* \< *expr2*  
  
-   *expr1* >= *expr2*  
  
-   *expr1* <= *expr2*  
  
 Overloaded prefix operators +, -, ++, --, !, and ~ work:  
  
-   +*expr1*  
  
-   -*expr1*  
  
-   ++*expr1*  
  
-   --*expr1*  
  
-   !*expr1*  
  
-   ~*expr1*  
  
 Overloaded suffix operators ++ and -- work:  
  
-   *expr1*++  
  
-   *expr1*--  
  
 The overload operator [] works:  
  
-   *x*[*expr2*]  
  
## Multidimensional Arrays  
 The C++ expression evaluator uses C#-style syntax for multidimensional arrays. For example:  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
 Using normal C++ syntax generates an error:  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> error: index '0' out of bound for pointer/array 'c'  
  
## Strings  
 The debugger recognizes the indexed operator when it is used with strings as well as arrays. So, for example, you can enter:  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
 The **Watch** window will display the correct value:  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
## Casts  
 Simple cast expressions work in the debugger:  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
 Casts that involve pointers will not work in the debugger:  
  
 User-defined casts do not work in the debugger for [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)].  
  
## Object Comparison and Assignment  
 Object comparison and assignment in the debugger does not work for [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)].  
  
## typeof and sizeof Operators  
 The debugger supports the typeof and sizeof operator by transforming it into the equivalent .NET Framework function.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  *expression* <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
 is transformed into:  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
 The debugger then evaluates this transformed expression.  
  
 The debugger does not support the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> operator.  
  
## Boxing and Unboxing  
 The debugger expression evaluator does not support boxing and unboxing in [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)]. For more information, see [Boxing and Unboxing](../vs140/boxing-and-unboxing--csharp-programming-guide-.md). If you have an integer variable <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> that has been converted into an object through boxing, the debugger will evaluate <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> as an integer, not as an object. The results may not be what you expect.  
  
## Property Evaluation  
 The debugger can evaluate properties in any variable window. However, evaluating a property in the debugger can have side effects that produce unexpected and undesired results. To protect against side effects caused by accidental evaluation, you can turn property evaluation off in the **Options** dialog box.  
  
## WebMethods  
 You cannot call WebMethods from debugger windows.  
  
## See Also  
 [Expressions in the Debugger](../vs140/expressions-in-the-debugger.md)