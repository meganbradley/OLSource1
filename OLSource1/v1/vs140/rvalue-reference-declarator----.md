---
title: "Rvalue Reference Declarator: &amp;&amp;"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "&&"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "&& rvalue reference declarator"
ms.assetid: eab0ce3a-c5a3-4992-aa70-6a8ab1f7491d
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Rvalue Reference Declarator: &amp;&amp;
Holds a reference to an rvalue expression.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Rvalue references enable you to distinguish an lvalue from an rvalue. Lvalue references and rvalue references are syntactically and semantically similar, but they follow somewhat different rules. For more information about lvalues and rvalues, see [LValues and RValues](../vs140/lvalues-and-rvalues--visual-c---.md). For more information about lvalue references, see [Reference Operator: &](../vs140/lvalue-reference-declarator---.md).  
  
 The following sections describe how rvalue references support the implementation of *move semantics* and *perfect forwarding*.  
  
## Move Semantics  
 Rvalue references support the implementation of *move semantics*, which can significantly increase the performance of your applications. Move semantics enables you to write code that transfers resources (such as dynamically allocated memory) from one object to another. Move semantics works because it enables resources to be transferred from temporary objects that cannot be referenced elsewhere in the program.  
  
 To implement move semantics, you typically provide a *move constructor,* and optionally a move assignment operator (<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>), to your class. Copy and assignment operations whose sources are rvalues then automatically take advantage of move semantics. Unlike the default copy constructor, the compiler does not provide a default move constructor. For more information about how to write a move constructor and how to use it in your application, see [How to: Write a Move Constructor](../vs140/move-constructors-and-move-assignment-operators--c---.md).  
  
 You can also overload ordinary functions and operators to take advantage of move semantics. [!INCLUDE[cpp_dev10_long](../vs140/includes/cpp_dev10_long_md.md)] introduces move semantics into the Standard Template Library (STL). For example, the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> class implements operations that perform move semantics. Consider the following example that concatenates several strings and prints the result:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Before [!INCLUDE[cpp_dev10_long](../vs140/includes/cpp_dev10_long_md.md)], each call to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> allocates and returns a new temporary <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object (an rvalue). <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> cannot append one string to the other because it does not know whether the source strings are lvalues or rvalues. If the source strings are both lvalues, they might be referenced elsewhere in the program and therefore must not be modified. By using rvalue references, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> can be modified to take rvalues, which cannot be referenced elsewhere in the program. Therefore, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> can now append one string to another. This can significantly reduce the number of dynamic memory allocations that the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> class must perform. For more information about the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> class, see [basic_string Class](../vs140/basic_string-class.md).  
  
 Move semantics also helps when the compiler cannot use Return Value Optimization (RVO) or Named Return Value Optimization (NRVO). In these cases, the compiler calls the move constructor if the type defines it. For more information about Named Return Value Optimization, see [Named Return Value Optimization in Visual C++ 2005](http://go.microsoft.com/fwlink/?LinkId=131571).  
  
 To better understand move semantics, consider the example of inserting an element into a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object. If the capacity of the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object is exceeded, the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object must reallocate memory for its elements and then copy each element to another memory location to make room for the inserted element. When an insertion operation copies an element, it creates a new element, calls the copy constructor to copy the data from the previous element to the new element, and then destroys the previous element. Move semantics enables you to move objects directly without having to perform expensive memory allocation and copy operations.  
  
 To take advantage of move semantics in the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> example, you can write a move constructor to move data from one object to another.  
  
 For more information about the introduction of move semantics into the STL in [!INCLUDE[cpp_dev10_long](../vs140/includes/cpp_dev10_long_md.md)], see [Standard C++ Library Reference](../vs140/c---standard-library-reference.md).  
  
## Perfect Forwarding  
 Perfect forwarding reduces the need for overloaded functions and helps avoid the forwarding problem. The *forwarding problem* can occur when you write a generic function that takes references as its parameters and it passes (or *forwards*) these parameters to another function. For example, if the generic function takes a parameter of type <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, then the called function cannot modify the value of that parameter. If the generic function takes a parameter of type <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, then the function cannot be called by using an rvalue (such as a temporary object or integer literal).  
  
 Ordinarily, to solve this problem, you must provide overloaded versions of the generic function that take both <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> for each of its parameters. As a result, the number of overloaded functions increases exponentially with the number of parameters. Rvalue references enable you to write one version of a function that accepts arbitrary arguments and forwards them to another function as if the other function had been called directly.  
  
 Consider the following example that declares four types, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>. The constructor for each type takes a different combination of <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> and non-<CodeContentPlaceHolder>40\</CodeContentPlaceHolder> lvalue references as its parameters.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Suppose you want to write a generic function that generates objects. The following example shows one way to write this function:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The following example shows a valid call to the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> function:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 However, the following example does not contain a valid call to the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> function because <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> takes lvalue references that are modifiable as its parameters, but it is called by using rvalues:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Ordinarily, to solve this problem, you must create an overloaded version of the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> function for every combination of <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> parameters. Rvalue references enable you to write one version of the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> function, as shown in the following example:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 This example uses rvalue references as the parameters to the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> function. The purpose of the [std::forward](../vs140/forward.md) function is to forward the parameters of the factory function to the constructor of the template class.  
  
 The following example shows the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> function that uses the revised <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> function to create instances of the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> classes. The revised <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> function forwards its parameters (either lvalues or rvalues) to the appropriate class constructor.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
## Additional Properties of Rvalue References  
 **You can overload a function to take an lvalue reference and an rvalue reference.**  
  
 By overloading a function to take a <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> lvalue reference or an rvalue reference, you can write code that distinguishes between non-modifiable objects (lvalues) and modifiable temporary values (rvalues). You can pass an object to a function that takes an rvalue reference unless the object is marked as <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>. The following example shows the function <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, which is overloaded to take an lvalue reference and an rvalue reference. The <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> function calls <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> with both lvalues and an rvalue.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 In this example, the first call to <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> passes a local variable (an lvalue) as its argument. The second call to <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> passes a temporary object as its argument. Because the temporary object cannot be referenced elsewhere in the program, the call binds to the overloaded version of <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> that takes an rvalue reference, which is free to modify the object.  
  
 **The compiler treats a named rvalue reference as an lvalue and an unnamed rvalue reference as an rvalue.**  
  
 When you write a function that takes an rvalue reference as its parameter, that parameter is treated as an lvalue in the body of the function. The compiler treats a named rvalue reference as an lvalue because a named object can be referenced by several parts of a program; it would be dangerous to allow multiple parts of a program to modify or remove resources from that object. For example, if multiple parts of a program try to transfer resources from the same object, only the first part will successfully transfer the resource.  
  
 The following example shows the function <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, which is overloaded to take an lvalue reference and an rvalue reference. The function <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> takes an rvalue reference as its parameter (a named rvalue reference) and returns an rvalue reference (an unnamed rvalue reference). In the call to <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> from <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>, overload resolution selects the version of <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> that takes an lvalue reference because the body of <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> treats its parameter as an lvalue. In the call to <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> from <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>, overload resolution selects the version of <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> that takes an rvalue reference because <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> returns an rvalue reference.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 In this example, the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> function passes an rvalue to <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>. The body of <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> treats its named parameter as an lvalue. The call from <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> binds the parameter to an lvalue reference (the first overloaded version of <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>).  
  
-   **You can cast an lvalue to an rvalue reference.**  
  
 The STL [std::move](../vs140/move.md) function enables you to convert an object to an rvalue reference to that object. Alternatively, you can use the <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> keyword to cast an lvalue to an rvalue reference, as shown in the following example:  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 **Function templates deduce their template argument types and then use reference collapsing rules.**  
  
 It is common to write a function template that passes (or *forwards*) its parameters to another function. It is important to understand how template type deduction works for function templates that take rvalue references.  
  
 If the function argument is an rvalue, the compiler deduces the argument to be an rvalue reference. For example, if you pass an rvalue reference to an object of type <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> to a template function that takes type <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> as its parameter, template argument deduction deduces <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> to be <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>. Therefore, the parameter has type <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>. If the function argument is an lvalue or <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> lvalue, the compiler deduces its type to be an lvalue reference or <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> lvalue reference of that type.  
  
 The following example declares one structure template and then specializes it for various reference types. The <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> function takes an rvalue reference as its parameter and forwards it to the appropriate specialized version of the <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> method. The <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> function demonstrates the various ways to call the <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> method.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 To resolve each call to the <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> function, the compiler first performs template argument deduction. The compiler then applies reference collapsing rules when it substitutes the deduced template arguments for the parameter types. For example, passing the local variable <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> to the <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> function causes the compiler to produce the following function signature:  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The compiler uses reference collapsing rules to reduce the signature to the following:  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 This version of the <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> function then forwards its parameter to the correct specialized version of the <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> method.  
  
 The following table summarizes the reference collapsing rules for template argument type deduction:  
  
|||  
|-|-|  
|Expanded type|Collapsed type|  
|<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>98\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>99\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>100\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>101\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>102\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>103\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>104\</CodeContentPlaceHolder>|  
  
 Template argument deduction is an important element of implementing perfect forwarding. The section Perfect Forwarding, which is presented earlier in this topic, describes perfect forwarding in more detail.  
  
## Summary  
 Rvalue references distinguish lvalues from rvalues. They can help you improve the performance of your applications by eliminating the need for unnecessary memory allocations and copy operations. They also enable you to write one version of a function that accepts arbitrary arguments and forwards them to another function as if the other function had been called directly.  
  
## See Also  
 [Expressions with Unary Operators](../vs140/expressions-with-unary-operators.md)   
 [Reference Operator: &](../vs140/lvalue-reference-declarator---.md)   
 [LValues and RValues](../vs140/lvalues-and-rvalues--visual-c---.md)   
 [How to: Write a Move Constructor](../vs140/move-constructors-and-move-assignment-operators--c---.md)   
 [Standard C++ Library Reference](../vs140/c---standard-library-reference.md)   
 [move](../vs140/move.md)   
 [forward](../vs140/forward.md)