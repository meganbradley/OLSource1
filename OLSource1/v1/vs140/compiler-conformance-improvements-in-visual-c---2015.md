---
title: "Compiler Conformance Improvements in Visual C++ 2015"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "cpp"
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: c4afde6f-3d75-40bf-986f-be57e3818e26
caps.latest.revision: 8
---
# Compiler Conformance Improvements in Visual C++ 2015
In Visual C++ 2015, ongoing improvements to compiler conformance can sometimes change how the compiler understands your existing source code. When this happens, you might encounter new or different errors during your build, or even behavioral differences in code that previously built and seemed to run correctly.  
  
 Fortunately, these differences  have little or no impact on most of your source code and when source code or other changes are needed to address these differences,  fixes are usually small and straight-forward. We've included many examples of previously-acceptable source code that might need to be changed *(before)* and the fixes to correct them *(after)*.  
  
 Although these differences can affect your source code or other build artifacts, they don't affect binary compatibility between updates to Visual C++ versions. A more-severe kind of change, the  *breaking change* can affect binary compatibility, but these kinds of binary compatibility breaks only occur between major versions of Visual C++. For example, between Visual C++ 2013 and Visual C++ 2015. For information on the breaking changes that occurred between Visual C++ 2013 and Visual C++ 2015, see [Breaking Changes in Visual C++ 2015](../vs140/breaking-changes-in-visual-c---2015.md).  
  
-   [Conformance Improvements in Visual C++ 2015](#VS_RTM)  
  
-   [Conformance Improvements in Update 1](#VS_Update1)  
  
-   [Conformance Improvements in Update 2](#VS_Update2)  
  
-   [Conformance Improvements in Update 3](#VS_Update3)  
  
##  \<a name="VS_RTM">\</a> Conformance Improvements in Visual C++ 2015  
  
-   /Zc:forScope- option  
  
     The compiler option **/Zc:forScope-** is deprecated and will be removed in a future release.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     The option was usually used in order to allow nonstandard code that uses loop variables after the point where, according to the standard, they should have gone out of scope. It was only necessary when you are compiling with the /Za option, since without /Za, using a for loop variable after the end of the loop is always allowed. If you don't care about standards conformance (for example, if your code isn't meant to portable to other compilers), you could turn off the /Za option (or set the Disable Language Extensions property to No). If you do care about writing portable, standards-compliant code, you should rewrite your code so that it conforms to the standard by moving the declaration of such variables to a point outside the loop.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
-   **/Zg compiler option**  
  
     The /Zg compiler option (Generate Function Prototypes) is no longer available. This compiler option was previously deprecated.  
  
-   You can no longer run unit tests with C++/CLI from the command-line with mstest.exe. Instead, use vstest.console.exe. See [VSTest.Console.exe command-line options](assetId:///52e1689d-b1a8-4589-bd98-99a55acd0a11).  
  
-   **mutable keyword**  
  
     The <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> storage class specifier is no longer allowed in places where previously it compiled without error. Now, the compiler gives error C2071 (illegal storage class). According to the standard, the mutable specifier can be applied only to names of class data members, and cannot be applied to names declared const or static, and cannot be applied to reference members.  
  
     For example, consider the following code:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     Previous versions of the Visual C++ compiler accepted this, but now the compiler gives the following error:  
  
 **error C2071: 'S::r': illegal storage class**     To fix the error, simply remove the redundant mutable keyword.  
  
-   **char_16_t and char32_t**  
  
     You can no longer use <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> as aliases in a typedef, because these types are now treated as built-in. It was common for users and library authors to define char16_t and char32_t as aliases of uint16_t and uint32_t, respectively.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
     To update your code, remove the typedef declarations and rename any other identifiers that collide with these names.  
  
-   **Non-type template parameters**  
  
     Certain code that involves non-type template parameters is now correctly checked for type compatibility when you provide explicit template arguments. For example, the following code compiled without error in previous versions of Visual C++.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
     The current compiler correctly gives an error, because the template parameter type doesn't match the template argument (the parameter is a pointer to a const member, but the function f is non-const):  
  
 **error C2893: Failed to specialize function template 'void S2::f(void)'note: With the following template arguments:note: 'C=S1'note: 'Function=S1::f'**     To address this error in your code, make sure that the type of the template argument you use matches the declared type of the template parameter.  
  
-   **__declspec(align)**  
  
     The compiler no longer accepts <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> on functions. This was always ignored, but now it produces a compiler error.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
     To fix this problem, remove <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> from the function declaration. Since it had no effect, removing it does not change anything.  
  
-   **Exception handling**  
  
     There are a couple of changes to exception handling. First, exception objects have to be either copyable or movable. The following code compiled in [!INCLUDE[cpp_dev12_long](../vs140/includes/cpp_dev12_long_md.md)], but does not compile in [!INCLUDE[cpp_dev14_long](../vs140/includes/cpp_dev14_long_md.md)]:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
     The problem is that the copy constructor is private, so the object cannot be copied as happens in the normal course of handling an exception. The same applies when the copy constructor is declared <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
     To update your code, make sure that the copy constructor for your exception object is public and not marked <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>.  
  
     Catching an exception by value also requires the exception object to be copyable. The following code compiled in [!INCLUDE[cpp_dev12_long](../vs140/includes/cpp_dev12_long_md.md)], but does not compile in [!INCLUDE[cpp_dev14_long](../vs140/includes/cpp_dev14_long_md.md)]:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
     You can fix this issue by changing the parameter type for the <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> to a reference.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
-   **String literals followed by macros**  
  
     The compiler now supports user defined literals. As a consequence, string literals followed by macros without any intervening whitespace are interpreted as user-defined literals, which might produce errors or unexpected results. For example, in previous compilers the following code compiled successfully:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
     The compiler interpreted this as a string literal "hello" followed by a macro, which is expanded "there", and then the two string literals were concatenated into one. In [!INCLUDE[cpp_dev14_long](../vs140/includes/cpp_dev14_long_md.md)], the compiler interprets this as a user-defined literal, but since there is no matching user-defined literal _x defined, it gives an error.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
     To fix this problem, add a space between the string literal and the macro.  
  
-   **Adjacent string literals**  
  
     Similarly to the previous, due to related changes in string parsing, adjacent string literals (either wide or narrow character string literals) without any whitespace were interpreted as a single concatenated string in previous releases of Visaul C++. In [!INCLUDE[cpp_dev14_long](../vs140/includes/cpp_dev14_long_md.md)], you must now add whitespace between the two strings. For example, the following code must be changed:  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
     Simply add a space in between the two strings.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
-   **Placement new and delete**  
  
     A change has been made to the delete operator in order to bring it into conformance with C++14 standard. Details of the standards change can be found at [C++ Sized Deallocation](http://isocpp.org/files/papers/n3778.html). The changes add a form of the global delete operator that takes a size parameter. The breaking change is that if you were previously using an operator delete with the same signature (to correspond with a placement new operator), you will receive a compiler error (C2956, which occurs at the point where the placement new is used, since that's the position in code where the compiler tries to identify an appropriate matching delete operator).  
  
     The function <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> was a placement delete operator corresponding to the placement new function "void \* operator new(size_t, size_t)" in C++11. With C++14 sized deallocation, this delete function is now a *usual deallocation function* (global delete operator). The standard requires that if the use of a placement new looks up a corresponding delete function and finds a usual deallocation function, the program is ill-formed.  
  
     For example, suppose your code defines both a placement new and a placement delete:  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
     The problem occurs because of the match in function signatures between a placement delete operator you've defined, and the new global sized delete operator. Consider whether you can use a different type other than size_t for any placement new and delete operators.  Note that the type of the size_t typedef is compiler-dependent; it is a typedef for unsigned int in Visual C++. A good solution is to use an enumerated type such as this:  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
     Then, change your definition of placement new and delete to use this type as the second argument instead of size_t. You’ll also need to update the calls to placement new to pass the new type (for example, by using <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> to convert from the integer value) and update the definition of new and delete to cast back to the integer type. You don’t need to use an enum for this; a class type with a size_t member would also work.  
  
     An alternative solution is that you might be able to eliminate the placement new altogether. If your code uses placement new to implement a memory pool where the placement argument is the size of the object being allocated or deleted, then sized deallocation feature might be suitable to replace your own custom memory pool code, and you can get rid of the placement functions and just use your own two-argument delete operator instead of the placement functions.  
  
     If you don't want to update your code immediately, you can revert to the old behavior by using the compiler option /Zc:sizedDealloc-. If you use this option, the two-argument delete functions don’t exist and won't cause a conflict with your placement delete operator.  
  
-   **Union data members**  
  
     Data members of unions can no longer have reference types. The following code compiled successfully in [!INCLUDE[cpp_dev12_long](../vs140/includes/cpp_dev12_long_md.md)], but produces an error in [!INCLUDE[cpp_dev14_long](../vs140/includes/cpp_dev14_long_md.md)].  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
     The preceding code produces the following errors:  
  
 **test.cpp(67): error C2625: 'U2::i': illegal union member; type 'int &' is reference type**  
**test.cpp(70): error C2625: 'U3::i': illegal union member; type 'int &' is reference type**     To address this issue, change reference types either to a pointer or a value. Changing the type to a pointer requires changes in the code that uses the union field. Changing the code to a value would change the data stored in the union, which affects other fields since fields in union types share the same memory. Depending on the size of the value, it might also change the size of the union.  
  
-   Anonymous unions are now more conformant to the standard. Previous versions of the compiler generated an explicit constructor and destructor for anonymous unions. These are deleted in [!INCLUDE[cpp_dev14_long](../vs140/includes/cpp_dev14_long_md.md)].  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
     The preceding code generates the following error in [!INCLUDE[cpp_dev14_long](../vs140/includes/cpp_dev14_long_md.md)]:  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
     To resolve this issue, provide your own definitions of the constructor and/or destructor.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
-   **Unions with anonymous structs**  
  
     In order to conform with the standard, the runtime behavior has changed for members of anonymous structures in unions. The constructor for anonymous structure members in a union is no longer implicitly called when such a union is created. Also, the destructor for anonymous structure members in a union is no longer implicitly called when the union goes out of scope. Consider the following code, in which a union U contains an anonymous structure that contains a member which is a named structure S that has a destructor.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
     In [!INCLUDE[cpp_dev12_long](../vs140/includes/cpp_dev12_long_md.md)], the constructor for S is called when the union is created, and the destructor for S is called when the stack for function f is cleaned up. But in [!INCLUDE[cpp_dev14_long](../vs140/includes/cpp_dev14_long_md.md)], the constructor and destructor are not called. The compiler gives a warning about this behavior change.  
  
 **warning C4587: 'U::s': behavior change: constructor is no longer implicitly calledwarning C4588: 'U::s': behavior change: destructor is no longer implicitly called**     To restore the original behavior, give the anonymous structure a name. The runtime behavior of non-anonymous structures is the same, regardless of the compiler version.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
     Alternatively, try moving the constructor and destructor code into new functions, and add calls to these functions from the constructor and destructor for the union.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
-   **Template resolution**  
  
     Changes have been made to name resolution for templates. In C++, when considering candidates for the resolution of a name, it can be the case that one or more names under consideration as potential matches produces an invalid template instantiation. These invalid instantiations do not normally cause compiler errors, a principle which is known as SFINAE (Substitution Failure Is Not An Error).  
  
     Now, if SFINAE requires the compiler to instantiate the specialization of a class template, then any errors that occur during this process are compiler errors. In previous versions, the compiler would ignore such errors. For example, consider the following code:  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
     If you compile with the current compiler, you get the following error:  
  
 **type_traits(1110): error C2139: 'D': an undefined class is not allowed as an argument to compiler intrinsic type trait '__is_base_of'**  
**..\t331.cpp(14): note: see declaration of 'D'**  
**..\t331.cpp(10): note: see reference to class template instantiation 'std::is_base_of\<T,U>' being compiled**  
 **with**  
 **[**  
 **T=D,**  
 **U=D**  
 **]**     This is because at the point of the first invocation of the is_base_of the class 'D' has not yet been defined.  
  
     In this case, the fix is not to use such type traits until the class has been defined. If you move the definitions of B and D to the beginning of the code file, the error is resolved. If the definitions are in header files, check the order of the include statements for the header files to make sure that any class definitions are compiled before the problematic templates are used.  
  
-   **Copy constructors**  
  
     In both [!INCLUDE[vs_dev12](../vs140/includes/vs_dev12_md.md)] and [!INCLUDE[vs_dev14](../vs140/includes/vs_dev14_md.md)], the compiler generates a copy constructor for a class if that class has a user-defined move constructor but no user-defined copy constructor. In Dev14, this implicitly generated copy constructor is also marked "= delete".  
  
##  \<a name="VS_Update1">\</a> Conformance Improvements in Update 1  
  
-   **Private virtual base classes and indirect inheritance**  
  
     Previous versions of the compiler allowed a derived class to call member functions of its *indirectly-derived*<CodeContentPlaceHolder>85\</CodeContentPlaceHolder> base classes. This old behavior was incorrect and does not conform to the C++ standard. The compiler no longer accepts code written in this way and issues compiler error C2280 as a result.  
  
 **error C2280: *'void \*S3::__delDtor(unsigned int)'*: attempting to reference a deleted function**     Example (before)  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
     Example (after)  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
     -or-  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
-   **Overloaded operator new and operator delete**  
  
     Previous versions of the compiler allowed non-member <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> and non-member <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> to be declared static, and to be declared in namespaces other than the global namespace.  This old behavior created a risk that the program would not call the <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> operator implementation that the programmer intended, resulting in silent bad runtime behavior. The compiler no longer accepts code written in this way and issues compiler error C2323 instead.  
  
 **error C2323: *'operator new'*: non-member operator new or delete functions may not be declared static or in a namespace other than the global namespace.**     Example (before)  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
     Example (after)  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
     Additionally, although the compiler doesn't give a specific diagnostic, inline operator new is considered ill-formed.  
  
-   **Calling 'operator *type*()' (user-defined conversion) on non-class types**  
  
     Previous versions of the compiler allowed 'operator *type*()' to be called on non-class types while silently ignoring it. This old behavior created a risk of silent bad code generation, resulting in unpredictable runtime behavior. The compiler no longer accepts code written in this way and issues compiler error C2228 instead.  
  
 **error C2228: left of '.operator *type*' must have class/struct/union**     Example (before)  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
     Example (after)  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
-   **Redundant typename in elaborated type specifiers**  
  
     Previous versions of the compiler allowed <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> in an elaborated type specifiers; code written in this way is semantically incorrect. The compiler no longer accepts code written in this way and issues compiler error C3406 instead.  
  
 **error C3406: 'typename' cannot be used in an elaborated type specifier**     Example (before)  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
     Example (after)  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
-   **Type deduction of arrays from an initializer list**  
  
     Previous versions of the compiler did not support type deduction of arrays from an initializer list. The compiler now supports this form of type deduction and, as a result, calls to function templates using initializer lists might now be ambiguous or a different overload might be chosen than in previous versions of the compiler. To resolve these issues, the program must now explicitly specify the overload that the programmer intended.  
  
     When this new behavior causes overload resolution to consider an additional candidate that is equally as good as the historic candidate, the call becomes ambiguous and the compiler issues compiler error C2668 as a result.  
  
 **error C2668: '*function*' : ambiguous call to overloaded function.**     Example 1: Ambiguous call to overloaded function (before)  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
     Example 1: ambiguous call to overloaded function (after)  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
     When this new behavior causes overload resolution to consider an additional candidate that is a better match than the historic candidate, the call resolves unambiguously to the new candidate, causing a change in program behavior that is probably different than the programmer intended.  
  
     Example 2: change in overload resolution (before)  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
     Example 2: change in overload resolution (after)  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
-   **Restoration of switch statement warnings**  
  
     A Previous version of the compiler removed previously-existing warnings related to <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> statements; these warnings have now been restored. The compiler now issues the restored warnings, and warnings related to specific cases (including the default case) are now issued on the line containing the offending case, rather than on the last line of the switch statement. As a result of now issuing those warnings on different lines than in the past, warnings previously suppressed by using <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> may no longer be suppressed as intended. To suppress these warnings as intended, it might be necessary to move the <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> directive to a line above the first potentially-offending case. The following are the restored warnings.  
  
 **warning C4060: switch statement contains no 'case' or 'default' labels warning C4061: enumerator '*bit1*' in switch of enum '*flags*' is not explicitly handled by a case label warning C4062: enumerator '*bit1*' in switch of enum '*flags*' is not handled warning C4063: case '*bit32*' is not a valid value for switch of enum '*flags*' warning C4064: switch of incomplete enum '*flags*' warning C4065: switch statement contains 'default' but no 'case' labels warning C4808: case '*value*' is not a valid value for switch condition of type '*bool*' Warning C4809: switch statement has redundant 'default' label; all possible 'case' labels are given**     Example of C4063 (before)  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
     Example of C4063 (after)  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
     Examples of the other restored warnings are provided in their documentation.  
  
-   **#include: use of parent-directory specifier '..' in pathname** (only affects /Wall /WX)  
  
     Previous versions of the compiler did not detect the use of the parent-directory specifier '..' in the pathname of  <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> directives. Code written in this way is usually intended to include headers that exist outside of the project by incorrectly using project-relative paths. This old behavior created a risk that the program could be compiled by including a different source file than the programmer intended, or that these relative paths would not be portable to other build environments. The compiler now detects and notifies the programmer of code written in this way and issues an optional compiler warning C4464, if enabled.  
  
 **warning C4464: relative include path contains '..'**     Example (before)  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
     Example (after)  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
     Additionally, although the compiler does not give a specific diagnostic, we also recommend that the parent-directory specifier ".." should note be used to specify your project's include directories.  
  
-   **#pragma optimize() extends past end of header file** (only affects /Wall /WX)  
  
     Previous versions of the compiler did not detect changes to  optimization flag settings that escape a header file included within a translation unit. The compiler now detects and notifies the programmer of code written in this way and issues an optional compiler warning C4426 at the location of the offending <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>, if enabled. This warning is only issued if the changes conflict with the optimization flags set by command-line arguments to the compiler.  
  
 **warning C4426: optimization flags changed after including header, may be due to #pragma optimize()**     Example (before)  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
     Example (after)  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
-   **Mismatched #pragma warning(push)** and **#pragma warning(pop)** (only affects /Wall /WX)  
  
     Previous versions of the compiler did not detect <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> state changes being paired with <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> state changes in a different source file, which is rarely intended. This old behavior created a risk that the program would be compiled with a different set of warnings enabled than the programmer intended, possibly resulting in silent bad runtime behavior. The compiler now detects and notifies the programmer of code written in this way and issues an optional compiler warning C5031 at the location of the matching <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>, if enabled. This warning includes a note referencing the location of the corresponding #pragma warning(push).  
  
 **warning C5031: #pragma warning(pop): likely mismatch, popping warning state pushed in different file**     Example (before)  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
     Example (after)  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
     Though uncommon, code written in this way is sometimes intentional. Code written in this way is sensitive to changes in <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> order; when possible, we recommend that source code files manage warning state in a self-contained way.  
  
-   **Unmatched #pragma warning(push)** (only affects /Wall /WX)  
  
     Previous versions of the compiler did not detect unmatched <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> state changes at the end of a translation unit. The compiler now detects and notifies the programmer of code written in this way and issues an optional compiler warning C5032 at the location of the unmatched #pragma warning(push), if enabled. This warning is only issued if there are no compilation errors in the translation unit.  
  
 **warning C5032: detected #pragma warning(push) with no corresponding #pragma warning(pop)**     Example (before)  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
     Example (after)  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
-   **Additional warnings might be issued as a result of improved #pragma warning state tracking**  
  
     Previous versions of the compiler tracked #pragma warning state changes insufficiently well to issue all intended warnings. This behavior created a risk that certain warnings would be effectively suppressed in circumstances different than the programmer intended. The compiler now tracks #pragma warning state more robustly -- especially related to #pragma warning state changes inside of templates -- and optionally issues new warnings C5031 and C5032 which are intended to help the programmer locate unintended uses of <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>.  
  
     As a result of improved #pragma warning state change tracking, warnings formerly incorrectly suppressed or warnings related to issues formerly misdiagnosed might now be issued.  
  
-   **Improved identification of unreachable code**  
  
     C++ Standard Library changes and improved ability to inline function calls over previous versions of the compiler might allow the compiler to prove that certain code is now unreachable. This new behavior can result in new and more-frequently issued instances of warning C4720.  
  
 **warning C4720: unreachable code**     In many cases, this warning might only be issued when compiling with optimizations enabled, since optimizations may inline more function calls, eliminate redundant code, or otherwise make it possible to determine that certain code is unreachable. We have observed that new instances of warning C4720 have frequently occurred in try/catch blocks, especially in relation to use of \<xref:find*>.  
  
     Example (before)  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
     Example (after)  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
##  \<a name="VS_Update2">\</a> Conformance Improvements in Update 2  
  
-   **Additional warnings and errors might be issued as a result of partial support for expression SFINAE**  
  
     Previous versions of the compiler did not parse certain kinds of expressions inside <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> specifiers due to lack of  support for expression SFINAE. This old behavior was incorrect and does not conform to the C++ standard. The compiler now parses these expressions and has partial support for expression SFINAE due to  ongoing conformance improvements. As a result, the compiler now issues warnings and errors found in  expressions that previous versions of the compiler did not parse.  
  
     When this new behavior parses a <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> expression that includes a type that has not yet been declared, the compiler issues compiler error C2039 as a result.  
  
 **error C2039: *'type'*: is not a member of *'<CodeContentPlaceHolder>105\</CodeContentPlaceHolder>decltype<CodeContentPlaceHolder>106\</CodeContentPlaceHolder>typename<CodeContentPlaceHolder>107\</CodeContentPlaceHolder>volatile<CodeContentPlaceHolder>108\</CodeContentPlaceHolder>volatile<CodeContentPlaceHolder>109\</CodeContentPlaceHolder>enum<CodeContentPlaceHolder>110\</CodeContentPlaceHolder>std::is_convertable<CodeContentPlaceHolder>111\</CodeContentPlaceHolder>std::is_convertable<>::value<CodeContentPlaceHolder>112\</CodeContentPlaceHolder>false<CodeContentPlaceHolder>113\</CodeContentPlaceHolder>std::is_convertable<>::value<CodeContentPlaceHolder>114\</CodeContentPlaceHolder>true<CodeContentPlaceHolder>115\</CodeContentPlaceHolder>std::is_convertable<>::value<CodeContentPlaceHolder>116\</CodeContentPlaceHolder>false<CodeContentPlaceHolder>117\</CodeContentPlaceHolder>/Wv:18<CodeContentPlaceHolder>118\</CodeContentPlaceHolder>/wd:4467<CodeContentPlaceHolder>119\</CodeContentPlaceHolder>#pragma warning(disable:4467)<CodeContentPlaceHolder>120\</CodeContentPlaceHolder>#include<CodeContentPlaceHolder>121\</CodeContentPlaceHolder>-Yc<CodeContentPlaceHolder>122\</CodeContentPlaceHolder>-Yu<CodeContentPlaceHolder>123\</CodeContentPlaceHolder>#include<CodeContentPlaceHolder>124\</CodeContentPlaceHolder>-I<CodeContentPlaceHolder>125\</CodeContentPlaceHolder>-Yc<CodeContentPlaceHolder>126\</CodeContentPlaceHolder>-Yu<CodeContentPlaceHolder>127\</CodeContentPlaceHolder>-I`) command line arguments when using PCH files.  
  
 **warning C4599: *'-I..'* : specified for *Ycc.h* at position *1* does not match *Yuc.h* at that position**     Example (before)  
  
<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
     Example (after)  
  
<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>