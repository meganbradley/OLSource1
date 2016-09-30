---
title: "Function Call Operator: ()"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "( ) function call operator"
  - "function calls, C++ functions"
  - "() function call operator"
  - "postfix operators"
  - "function calls, operator"
  - "functions [C++], function-call operator"
  - "function call operator ( )"
ms.assetid: 50c92e59-a4bf-415a-a6ab-d66c679ee80a
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Function Call Operator: ()
A postfix-expression followed by the function-call operator, **( )**, specifies a function call.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The arguments to the function-call operator are zero or more expressions separated by commas — the actual arguments to the function.  
  
 The *postfix-expression* must evaluate to a function address (for example, a function identifier or the value of a function pointer), and *argument-expression-list* is a list of expressions (separated by commas) whose values (the arguments) are passed to the function. The *argument-expression-list* argument can be empty.  
  
 The *postfix-expression* must be of one of these types:  
  
-   Function returning type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. An example declaration is  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
-   Pointer to a function returning type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. An example declaration is  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
-   Reference to a function returning type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. An example declaration is  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
-   Pointer-to-member function dereference returning type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. Example function calls are  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Example  
 The following example calls the standard library function <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> with three arguments:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 **Welcome to C++**   
## Function call results  
 A function call evaluates to an r-value unless the function is declared as a reference type. Functions with reference return type evaluate to l-values, and can be used on the left side of an assignment statement as follows:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The preceding code defines a class called <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, which contains private data objects that represent *x* and *y* coordinates. These data objects must be modified and their values retrieved. This program is only one of several designs for such a class; use of the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> functions is another possible design.  
  
 Functions that return class types, pointers to class types, or references to class types can be used as the left operand to member-selection operators. Therefore, the following code is legal:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Functions can be called recursively. For more information about function declarations, see [Function Specifiers](../vs140/function-specifiers.md) and [Member Functions](../vs140/member-functions--c---.md). Related material is in [Program and Linkage](../vs140/program-and-linkage---c---.md).  
  
## See Also  
 [Postfix Expressions](../vs140/postfix-expressions.md)   
 [C++ Operators](../vs140/c---operators.md)   
 [C++ Built-in Operators, Precedence and Associativity](../vs140/c---built-in-operators--precedence-and-associativity.md)   
 [Function Call](../vs140/function-call--c-.md)   
 [(NOTINBUILD) Function Declarations](assetId:///3f9b4e14-60d2-47c1-acd8-4fa8fc988be7)