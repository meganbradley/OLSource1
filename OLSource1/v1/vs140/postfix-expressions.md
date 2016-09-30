---
title: "Postfix Expressions"
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
  - "operators [C++], postfix"
  - "postfix expressions"
  - "expressions [C++], postfix"
ms.assetid: 7ac62a57-06df-422f-b012-a75b37d7cb9b
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Postfix Expressions
Postfix expressions consist of primary expressions or expressions in which postfix operators follow a primary expression. The postfix operators are listed in the following table.  
  
### Postfix Operators  
  
|Operator Name|Operator Notation|  
|-------------------|-----------------------|  
|[Subscript operator](../vs140/subscript-operator-.md)|**[ ]**|  
|[Function call operator](../vs140/function-call-operator----.md)|**( )**|  
|[Explicit type conversion operator](../vs140/explicit-type-conversion-operator----.md)|*type-name* **( )**|  
|[Member access operator](../vs140/member-access-operators--.-and---.md)|**.** or **–>**|  
|[Postfix increment operator](../vs140/postfix-increment-and-decrement-operators-----and---.md)|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
|[Postfix decrement operator](../vs140/postfix-increment-and-decrement-operators-----and---.md)|**––**|  
  
 The following syntax describes possible postfix expressions:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The *postfix-expression* above may be a primary expression or another postfix expression.  See **primary expressions**.  Postfix expressions group left to right, thus allowing the expressions to be chained together as follows:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In the above expression, func is a primary expression, func(1) is a function postfix expression, func(1)->GetData is a postfix expression specifying a member of the class, func(1)->GetData() is another function postfix expression, and the entire expression is a postfix expression incrementing the return value of GetData.  The meaning of the expression as a whole is "call func passing 1 as an argument and get a pointer to a class as a return value.  Then call GetValue() on that class, then increment the value returned.  
  
 The expressions listed above are assignment expressions, meaning that the result of these expressions must be an r-value.  
  
 The postfix expression form  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 indicates the invocation of the constructor.  If the simple-type-name is a fundamental type, the expression list must be a single expression, and this expression indicates a cast of the expression's value to the fundamental type.  This type of cast expression mimics a constructor.  Because this form allows fundamental types and classes to be constructed using the same syntax, this form is especially useful when defining template classes.  
  
 The *cast-keyword* is one of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  More information may be found in **dynamic_cast**, **static_cast** and **reinterpet_cast**.  
  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> operator is considered a postfix expression.  See **typeid operator**.  
  
## Formal and actual arguments  
 Calling programs pass information to called functions in "actual arguments." The called functions access the information using corresponding "formal arguments."  
  
 When a function is called, the following tasks are performed:  
  
-   All actual arguments (those supplied by the caller) are evaluated. There is no implied order in which these arguments are evaluated, but all arguments are evaluated and all side effects completed prior to entry to the function.  
  
-   Each formal argument is initialized with its corresponding actual argument in the expression list. (A formal argument is an argument that is declared in the function header and used in the body of a function.) Conversions are done as if by initialization — both standard and user-defined conversions are performed in converting an actual argument to the correct type. The initialization performed is illustrated conceptually by the following code:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
     The conceptual initializations prior to the call are:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
     Note that the initialization is performed as if using the equal-sign syntax instead of the parentheses syntax. A copy of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is made prior to passing the value to the function. (For more information, see [Initializers](../vs140/initializers.md) and [Conversions](../vs140/user-defined-type-conversions--c---.md), [Initialization Using Special Member Functions](assetId:///82223d73-64cb-4923-b678-78f9568ff3ca), and [Explicit Initialization](assetId:///c89724f8-ddd3-4d77-b86d-77fcd8bd8595).  
  
     Therefore, if the function prototype (declaration) calls for an argument of type **long**, and if the calling program supplies an actual argument of type <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, the actual argument is promoted using a standard type conversion to type **long** (see [Standard Conversions](../vs140/standard-conversions.md)).  
  
     It is an error to supply an actual argument for which there is no standard or user-defined conversion to the type of the formal argument.  
  
     For actual arguments of class type, the formal argument is initialized by calling the class's constructor. (See [Constructors](../vs140/constructors--c---.md) for more about these special class member functions.)  
  
-   The function call is executed.  
  
 The following program fragment demonstrates a function call:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 When <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is called from main, the formal parameter <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is initialized with the value of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is converted to type **long** to correspond to the correct type using a standard conversion), and the formal parameter <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is initialized with the value of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is converted to type **double** using a standard conversion).  
  
## Treatment of argument types  
 Formal arguments declared as const types cannot be changed within the body of a function. Functions can change any argument that is not of type **const**. However, the change is local to the function and does not affect the actual argument's value unless the actual argument was a reference to an object not of type **const**.  
  
 The following functions illustrate some of these concepts:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## Ellipses and default arguments  
 Functions can be declared to accept fewer arguments than specified in the function definition, using one of two methods: ellipsis (<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>) or default arguments.  
  
 Ellipses denote that arguments may be required but that the number and types are not specified in the declaration. This is normally poor C++ programming practice because it defeats one of the benefits of C++: type safety. Different conversions are applied to functions declared with ellipses than to those functions for which the formal and actual argument types are known:  
  
-   If the actual argument is of type **float**, it is promoted to type **double** prior to the function call.  
  
-   Any signed or unsigned <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, **short**, enumerated type, or bit field is converted to either a signed or an unsigned <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> using integral promotion.  
  
-   Any argument of class type is passed by value as a data structure; the copy is created by binary copying instead of by invoking the class's copy constructor (if one exists).  
  
 Ellipses, if used, must be declared last in the argument list. For more information about passing a variable number of arguments, see the discussion of [va_arg, va_start, and va_list](../vs140/va_arg--va_copy--va_end--va_start.md) in the *Run-Time Library Reference*.  
  
 For information on default arguments in CLR programming, see [... (Variable Argument Lists)](../vs140/variable-argument-lists--...---c---cli-.md).  
  
 Default arguments enable you to specify the value an argument should assume if none is supplied in the function call. The following code fragment shows how default arguments work. For more information about restrictions on specifying default arguments, see [Default Arguments](../vs140/default-arguments.md).  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The preceding program declares a function, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, that takes two arguments. However, the second argument, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, has a default value, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. In **main**, the first two calls to <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> allow the default second argument to supply a new line to terminate the printed string. The third call specifies an explicit value for the second argument. The output from the program is  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
## See Also  
 [Types of Expressions](../vs140/types-of-expressions.md)