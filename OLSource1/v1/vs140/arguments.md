---
title: "Arguments"
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
  - "arguments [C++], function"
  - "function parameters"
  - "functions [C], parameters"
  - "function parameters, about function parameters"
  - "function arguments"
  - "function calls, arguments"
ms.assetid: 14cf0389-2265-41f0-9a96-f2223eb406ca
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Arguments
The arguments in a function call have this form:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In a function call, *expression-list* is a list of expressions (separated by commas). The values of these latter expressions are the arguments passed to the function. If the function takes no arguments, *expression-list* should contain the keyword <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 An argument can be any value with fundamental, structure, union, or pointer type. All arguments are passed by value. This means a copy of the argument is assigned to the corresponding parameter. The function does not know the actual memory location of the argument passed. The function uses this copy without affecting the variable from which it was originally derived.  
  
 Although you cannot pass arrays or functions as arguments, you can pass pointers to these items. Pointers provide a way for a function to access a value by reference. Since a pointer to a variable holds the address of the variable, the function can use this address to access the value of the variable. Pointer arguments allow a function to access arrays and functions, even though arrays and functions cannot be passed as arguments.  
  
 The order in which arguments are evaluated can vary under different compilers and different optimization levels. However, the arguments and any side effects are completely evaluated before the function is entered. See [Side Effects](../vs140/side-effects.md) for information on side effects.  
  
 The *expression-list* in a function call is evaluated and the usual arithmetic conversions are performed on each argument in the function call. If a prototype is available, the resulting argument type is compared to the prototype's corresponding parameter. If they do not match, either a conversion is performed, or a diagnostic message is issued. The parameters also undergo the usual arithmetic conversions.  
  
 The number of expressions in *expression-list* must match the number of parameters, unless the function's prototype or definition explicitly specifies a variable number of arguments. In this case, the compiler checks as many arguments as there are type names in the list of parameters and converts them, if necessary, as described above. See [Calls with a Variable Number of Arguments](../vs140/calls-with-a-variable-number-of-arguments.md) for more information.  
  
 If the prototype's parameter list contains only the keyword <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the compiler expects zero arguments in the function call and zero parameters in the definition. A diagnostic message is issued if it finds any arguments.  
  
## Example  
 This example uses pointers as arguments:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In this example, the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function is declared in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to have two arguments, represented respectively by identifiers <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, both of which are pointers to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> values. The parameters <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> in the prototype-style definition are also declared as pointers to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> type values.  
  
 In the function call  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 the address of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is stored in <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and the address of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is stored in <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. Now two names, or "aliases," exist for the same location. References to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> are effectively references to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. The assignments within <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> actually exchange the contents of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. Therefore, no <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> statement is necessary.  
  
 The compiler performs type checking on the arguments to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> because the prototype of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> includes argument types for each parameter. The identifiers within the parentheses of the prototype and definition can be the same or different. What is important is that the types of the arguments match those of the parameter lists in both the prototype and the definition.  
  
## See Also  
 [Function Calls](../vs140/function-calls.md)