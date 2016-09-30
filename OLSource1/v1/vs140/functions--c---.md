---
title: "Functions (C++)"
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
  - "defaults, arguments"
  - "function definitions"
  - "function definitions, about function definitions"
  - "default arguments"
  - "declarators, functions"
ms.assetid: 33ba01d5-75b5-48d2-8eab-5483ac7d2274
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Functions (C++)
A function is a block of code that performs some operation. A function can optionally define input parameters that enable callers to pass arguments into the function. A function can optionally return a value as output. Functions are useful for encapsulating common operations in a single reusable block, ideally with a name that clearly describes what the function does. The following function accepts two integers from a caller and returns their sum; <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> are *parameters* of type <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The function can invoked, or *called*, from any number of places in the program. The values that are passed to the function are the *arguments*, whose types must be compatible with the parameter types in the function definition.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 There is no practical limit to function length, but good design aims for functions that perform a single well-defined task. Complex algorithms should be broken up into easy-to-understand simpler functions whenever possible.  
  
 Functions that are defined at class scope are called member functions. In C++, unlike other languages, a function can also be defined at namespace scope (including the implicit global namespace). Such functions are called *free functions* or *non-member functions*; they are used extensively in the Standard Library.  
  
## Parts of a function declaration  
 A minimal function *declaration* consists of the return type, function name, and parameter list (which may be empty), along with optional keywords that provide additional instructions to the compiler. A function definition consists of a declaration, plus the *body*, which is all the code between the curly braces. A function declaration followed by a semicolon may appear in multiple places in a program. It must appear prior to any calls to that function in each translation unit. The function definition must appear only once in the program, according to the One Definition Rule (ODR).  
  
 The required parts of a function declaration are:  
  
1.  The return type, which specifies the type of the value that the function returns, or  <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> if no value is returned. In C++11, auto is a valid return type that instructs the compiler to infer the type from the return statement. In C++14, decltype(auto) is also allowed. For more information, see Type Deduction in Return Types below.  
  
2.  The function name, which must begin with a letter or underscore and cannot contain spaces. In general, leading underscores in the Standard Library function names indicate private member functions, or non-member functions that are not intended for use by your code.  
  
3.  The parameter list, a brace delimited, comma-separated set of zero or more parameters that specify the type and optionally a local name by which the values may be accessed inside the function body.  
  
 Optional parts of a function declaration are:  
  
1.  <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, which indicates that the return value of the function is a constant value can be computed at compile time.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
2.  Its <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> specification, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
     For more information, see [Program and Linkage  (C++)](../vs140/program-and-linkage---c---.md).  
  
3.  <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, which instructs the compiler to replace every call to the function with the function code itself. inlining can help performance in scenarios where a function executes quickly and is invoked repeatedly in a performance-critical section of code.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
     For more information, see [Inline Functions (C++)](../vs140/inline-functions--c---.md).  
  
4.  <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, which specifies whether or not the function can throw an exception. In the following example, the function does not throw an exception if the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> expression evaluates to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
     For more information, see [noexcept (C++)](../vs140/noexcept--c---.md).  
  
5.  (Member functions only) The cv-qualifiers, which specify whether the function is <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
6.  (Member functions only) <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> specifies that a function can be overridden in a derived class. <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> means that a function in a derived class is overriding a virtual function. <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> means a function cannot be overridden in any further derived class. For more information, see [Virtual Functions](../vs140/virtual-functions.md).  
  
7.  (member functions only) <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> applied to a member function means that the function is not associated with any object instances of the class.  
  
8.  (Non-static member functions only) The ref-qualifier, which specifies to the compiler which overload of a function to choose when the implicit object parameter (*this) is an rvalue reference vs. an lvalue reference.  
  
 The following figure shows the parts of a function definition. The shaded area is the function body.  
  
 ![Parts of a function definition](../vs140/media/vc38ru1.gif "vc38RU1")  
Parts of a Function Definition  
  
## Function definitions  
 Variables declared inside the body are called local variables or locals. They go out of scope when the function exits; therefore, a function should never return a reference to a local!  
  
## Function Templates  
 A function template is similar to a class template; it generates concrete functions based on the template arguments. In many cases, the template is able to infer the type arguments and therefore it isn't necessary to explicitly specify them.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 For more information, see [Function Templates](../vs140/function-templates.md)  
  
## Function parameters and arguments  
 A function has a comma-separated parameter list of zero or more types, each of which has a name by which it can be accessed inside the function body. A function template may specify additional type or value parameters. The caller passes arguments, which are concrete values whose types are compatible with the parameter list.  
  
 By default, arguments are passed to the function by value, which means the function receives a copy of the object being passed. For large objects, making a copy can be expensive and is not always necessary. To cause arguments to be passed by reference (specifically lvalue reference), add a reference quaitifer to the parameter:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 When a function modifies an argument that is passed by reference, it modifies the original object, not a local copy. To prevent a function from modifying such an argument, qualify the parameter as const&:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 **C++ 11:**  To explicitly handle arguments that are passed by rvalue-reference OR by lvalue-reference, use a double-ampersand on the parameter to indicate a universal reference:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A function declared with the single keyword <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> in the parameter declaration list takes no arguments, as long as the keyword <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is the first and only member of the argument declaration list. Arguments of type <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> elsewhere in the list produce errors. For example:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Note that, while it is illegal to specify a <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> argument except as outlined here, types derived from type <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> (such as pointers to <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> and arrays of <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>) can appear anywhere the argument declaration list.  
  
### Default Arguments  
 The last parameter or parameters in a function signature may be assigned a default argument, which means that the caller may leave out the argument when calling the function unless they want to specify some other value.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 For more information, see [Default Arguments](../vs140/default-arguments.md) and [Default Arguments for Class Templates](../vs140/default-arguments-for-class-templates.md).  
  
## Function return types  
 A function may not return another function, or a built-in array; however it can return pointers to these types, or a *lambda*, which produces a function object. Except for these cases, a function may return a value of any type that is in scope, or it may return no value, in which case the return type is <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
### Trailing return types  
 An "ordinary" return type is located on the left side of the function signature. A *trailing return type* is located on the right most side of the signature and is preceded by the -> operator. Trailing return types are especially useful in function templates when the type of the return value depends on template parameters.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 When <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> is used in conjunction with a trailing return type, it just serves as a placeholder for whatever the decltype expression produces, and does not itself perform type deduction.  
  
###  \<a name="type_deduction">\</a> Type deduction in return types (C++14)  
 In C++14, you can use <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> to instruct the compiler to infer the return type from the function body without having to provide a trailing return type. Note that <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> always deduces to a return-by-value. Use <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> to instruct the compiler to deduce a reference.  
  
 In this example, <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> will be deduced as a non-const value copy of the sum of lhs and rhs.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Note that <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> also does not preserve the const-ness of the type it deduces. For forwarding functions whose return value needs to preserve the const-ness or ref-ness of its arguments, you can use the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> keyword, which uses the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> type inference rules and preserves all the type information. <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> may be used as an ordinary return value on the left side, or as a trailing return value.  
  
 The following example (based on code from [N3493](http://www.open-std.org/JTC1/SC22/WG21/docs/papers/2013/n3493.html)), shows <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> being used to enable perfect forwarding of function arguments in a return type that isn't known until the template is instantiated.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
## Function local variables  
 A variable that is declared inside a function body is called a *local variable* or simply a *local*. Non-static locals are only visible inside the function body and, if they are declared on the stack go out of scope when the function exits. When you construct a local variable and return it by value, the compiler can usually perform the return value optimization to avoid unnecessary copy operations. If you return a local variable by reference, the compiler will issue a warning because any attempt by the caller to use that reference will occur after the local has been destroyed.  
  
 Local static objects are destroyed during termination specified by <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>. If a static object was not constructed because the program's flow of control bypassed its declaration, no attempt is made to destroy that object.  
  
### Static local variables  
 In C++ a local variable may be declared as static. The variable is only visible inside the function body, but a single copy of the variable exists for all instances of the function.  
  
## Function pointers  
 C++ supports function pointers in the same manner as the C language. However a more type-safe alternative is usually to use a function object.  
  
 It is recommended that <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> be used to declare an alias for the function pointer type if declaring a function that returns a function pointer type.  For example  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 If this is not done, the proper syntax for the function declaration may be deduced from the declarator syntax for the function pointer by replacing the identifier (<CodeContentPlaceHolder>58\</CodeContentPlaceHolder> in the above example) with the functions name and argument list, as follows:  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The preceding declaration is equivalent to the declaration using typedef above.  
  
## See Also  
 [Function Overloading](../vs140/function-overloading.md)   
 [Functions with Variable Argument Lists  (C++)](../vs140/functions-with-variable-argument-lists---c---.md)   
 [Explicitly Defaulted and Deleted Functions](../vs140/explicitly-defaulted-and-deleted-functions.md)   
 [Argument-Dependent Name (Koenig) Lookup on Functions](../vs140/argument-dependent-name--koenig--lookup-on-functions.md)   
 [Default Arguments](../vs140/default-arguments.md)   
 [Inline Functions (C++)](../vs140/inline-functions--c---.md)