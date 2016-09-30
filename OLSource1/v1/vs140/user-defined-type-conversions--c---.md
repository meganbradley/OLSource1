---
title: "User-Defined Type Conversions (C++)"
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
  - "explicit_cpp"
  - "explicit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "constructors [C++], and constants"
  - "conversion functions"
  - "explicit keyword"
  - "type conversion"
  - "constructors [C++], drawbacks"
  - "conversion constructors"
  - "type conversion [C++], explicit conversion"
  - "coercion"
  - "conversions [C++], explicit"
  - "objects [C++], converting"
  - "conversion functions, rules for declaring"
  - "declaring functions, conversion functions"
  - "functions [C++], conversion"
  - "converting objects"
  - "constructors [C++], conversion"
  - "conversions [C++], by constructors"
  - "data type conversion [C++], explicit"
ms.assetid: d40e4310-a190-4e95-a34c-22c5c20aa0b9
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# User-Defined Type Conversions (C++)
A *conversion* produces a new value of some type from a value of a different type. *Standard conversions* are built into the C++ language and support its built-in types, and you can create *user-defined conversions* to perform conversions to, from, or between user-defined types.  
  
 The standard conversions perform conversions between built-in types, between pointers or references to types related by inheritance, to and from void pointers, and to the null pointer. For more information, see [Standard Conversions](../vs140/standard-conversions.md). User-defined conversions perform conversions between user-defined types, or between user-defined types and built-in types. You can implement them as [conversion constructors](#ConvCTOR) or as [conversion functions](#ConvFunc).  
  
 Conversions can either be explicit—when the programmer calls for one type to be converted to another, as in a cast or direct initialization—or implicit—when the language or program calls for a different type than the one given by the programmer.  
  
 Implicit conversions are attempted when:  
  
-   An argument supplied to a function does not have the same type as the matching parameter.  
  
-   The value returned from a function does not have the same type as the function return type.  
  
-   An initializer expression does not have the same type as the object it is initializing.  
  
-   An expression that controls a conditional statement, looping construct, or switch does not have the result type that's required to control it.  
  
-   An operand supplied to an operator does not have the same type as the matching operand-parameter. For built-in operators, both operands must have the same type, and are converted to a common type that can represent both. For more information, see [Arithmetic Conversions](../vs140/arithmetic-conversions.md). For user-defined operators, each operand must have the same type as the matching operand-parameter.  
  
 When one standard conversion can't complete an implicit conversion, the compiler can use a user-defined conversion, followed optionally by an additional standard conversion, to complete it.  
  
 When two or more user-defined conversions that perform the same conversion are available at a conversion site, the conversion is said to be ambiguous. Such ambiguities are an error because the compiler can't determine which one of the available conversions it should choose. However, it's not an error just to define multiple ways of performing the same conversion because the set of available conversions can be different at different locations in the source code—for example, depending on which header files are included in a source file. As long as only one conversion is available at the conversion site, there is no ambiguity. There are several ways that ambiguous conversions can arise, but the most common ones are:  
  
-   Multiple inheritance. The conversion is defined in more than one base class. For more information, see [(NOTINBUILD) Ambiguity](assetId:///0b399cab-40a7-4e79-9278-05f40139a0e1).  
  
-   Ambiguous function call. The conversion is defined as a conversion constructor of the target type and as a conversion function of the source type. For more information, see [conversion functions](#ConvFunc).  
  
 You can usually resolve an ambiguity just by qualifying the name of the involved type more fully or by performing an explicit cast to clarify your intent.  
  
 Both conversion constructors and conversion functions obey member-access control rules, but the accessibility of the conversions is only considered if and when an unambiguous conversion can be determined. This means that a conversion can be ambiguous even if the access level of a competing conversion would prevent it from being used. For more information about member accessibility, see [Member Access Control](../vs140/member-access-control--c---.md).  
  
## The explicit keyword and problems with implicit conversion  
 By default when you create a user-defined conversion, the compiler can use it to perform implicit conversions. Sometimes this is what you want, but other times the simple rules that guide the compiler in making implicit conversions can lead it to accept code that you don't want it to.  
  
 One well-known example of an implicit conversion that can cause problems is the conversion to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. There are many reasons that you might want to create a class type that can be used in a Boolean context—for example, so that it can be used to control an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statement or loop—but when the compiler performs a user-defined conversion to a built-in type, the compiler is allowed to apply an additional standard conversion afterwards. The intent of this additional standard conversion is to allow for things like promotion from <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, but it also opens the door for less-obvious conversions—for example, from <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, which allows your class type to be used in integer contexts you never intended. This particular problem is known as the *Safe Bool Problem*. This kind of problem is where the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> keyword can help.  
  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> keyword tells the compiler that the specified conversion can't be used to perform implicit conversions. If you wanted the syntactic convenience of implicit conversions before the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> keyword was introduced, you had to either accept the unintended consequences that implicit conversion sometimes created or use less-convenient, named conversion functions as a workaround. Now, by using the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> keyword, you can create convenient conversions that can only be used to perform explicit casts or direct initialization, and that won't lead to the kind of problems exemplified by the Safe Bool Problem.  
  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> keyword can be applied to conversion constructors since C++98, and to conversion functions since C++11. The following sections contain more information about how to use the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> keyword.  
  
##  \<a name="ConvCTOR">\</a> Conversion constructors  
 Conversion constructors define conversions from user-defined or built-in types to a user-defined type. The following example demonstrates a conversion constructor that converts from the built-in type <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to a user-defined type <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Notice that the first call to the function <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, which takes an argument of type <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, doesn't require a conversion because its argument is the correct type. However, on the second call to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, a conversion is needed because the type of the argument, a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> with a value of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, is not what the function expects. The function can't use this value directly, but because there's a conversion from the type of the argument—<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>—to the type of the matching parameter—<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>—a temporary value of type <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is constructed from the argument and used to complete the function call. In the third call to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, notice that the argument is not a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, but is instead a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> with a value of <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>—and yet the function call can still be completed because the compiler can perform a standard conversion—in this case, from <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>—and then perform the user-defined conversion from <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> to complete the necessary conversion.  
  
### Declaring conversion constructors  
 The following rules apply to declaring a conversion constructor:  
  
-   The target type of the conversion is the user-defined type that's being constructed.  
  
-   Conversion constructors typically take exactly one argument, which is of the source type. However, a conversion constructor can specify additional parameters if each additional parameter has a default value. The source type remains the type of the first parameter.  
  
-   Conversion constructors, like all constructors, do not specify a return type. Specifying a return type in the declaration is an error.  
  
-   Conversion constructors can be explicit.  
  
### Explicit conversion constructors  
 By declaring a conversion constructor to be <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, it can only be used to perform direct initialization of an object or to perform an explicit cast. This prevents functions that accept an argument of the class type from also implicitly accepting arguments of the conversion constructor's source type, and prevents the class type from being copy-initialized from a value of the source type. The following example demonstrates how to define an explicit conversion constructor, and the effect it has on what code is well-formed.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In this example, notice that you can still use the explicit conversion constructor to perform direct initialization of <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>. If instead you were to copy-initialize <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, it would be an error. The first call to <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is unaffected because the argument is the correct type. The second call to <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is an error, because the conversion constructor can't be used to perform implicit conversions. The third call to <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is legal because of the explicit cast to <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, but notice that the compiler still helped complete the cast by inserting an implicit cast from <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
 Although the convenience of allowing implicit conversions can be tempting, doing so can introduce hard-to-find bugs. The rule of thumb is to make all conversion constructors explicit except when you're sure that you want a specific conversion to occur implicitly.  
  
##  \<a name="ConvFunc">\</a> Conversion functions  
 Conversion functions define conversions from a user-defined type to other types. These functions are sometimes referred to as "cast operators" because they, along with conversion constructors, are called when a value is cast to a different type. The following example demonstrates a conversion function that converts from the user-defined type, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, to a built-in type, <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Notice that the member variable <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> is made private and that a public conversion function to type <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> is introduced just to return the value of <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>. In the function <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, an implicit conversion occurs when the value of <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> is streamed to standard output by using the stream insertion operator <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>. Because no stream-insertion operator is defined for the user-defined type <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, but there is one for built-in type <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, the compiler can use the conversion function from <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> to satisfy the stream-insertion operator.  
  
 Conversion functions are inherited by derived classes. Conversion functions in a derived class only override an inherited conversion function when they convert to exactly the same type. For example, a user-defined conversion function of the derived class <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> does not override—or even influence—a user-defined conversion function of the base class <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, even though the standard conversions define a conversion relationship between <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
### Declaring conversion functions  
 The following rules apply to declaring a conversion function:  
  
-   The target type of the conversion must be declared prior to the declaration of the conversion function. Classes, structures, enumerations, and typedefs cannot be declared within the declaration of the conversion function.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
-   Conversion functions take no arguments. Specifying any parameters in the declaration is an error.  
  
-   Conversion functions have a return type that is specified by the name of the conversion function, which is also the name of the conversion's target type. Specifying a return type in the declaration is an error.  
  
-   Conversion functions can be virtual.  
  
-   Conversion functions can be explicit.  
  
### Explicit conversion functions  
 When a conversion function is declared to be explicit, it can only be used to perform an explicit cast. This prevents functions that accept an argument of the conversion function's target type from also implicitly accepting arguments of the class type, and prevents instances of the target type from being copy-initialized from a value of the class type. The following example demonstrates how to define an explicit conversion function and the effect it has on what code is well-formed.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Here the conversion function <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> has been made explicit, and an explicit cast to type <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> has been introduced in the function <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> to perform the conversion. If this cast were omitted, the compiler would be unable to locate a suitable stream-insertion operator <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> for type <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> and an error would occur.  
  
## See Also  
 [Special Member Functions](../vs140/special-member-functions--c---.md)