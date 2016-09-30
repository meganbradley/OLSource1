---
title: "Breaking Changes in Visual C++ 2015 Update 1"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 1c0b1c2b-e1cf-4767-885b-b98df9b3730e
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Breaking Changes in Visual C++ 2015 Update 1
When you upgrade to Visual C++ 2015 Update 1 you might encounter compilation and/or runtime errors in code that previously compiled and ran correctly. Changes in compiler or runtime behavior that cause such problems are known as *breaking changes*, and typically they're required by modifications in the C++ language standard, function signatures, or the layout of objects in memory.  
  
 The rest of this article describes specific breaking changes in Visual C++ 2015 Update 1, and in this article the terms "new behavior" or "now" refer to that version. The terms "old behavior" and "previous" refer to the initial release of Visual Studio 2015 and earlier releases. For information on breaking changes that occurred between Visual Studio 2013 and Visual Studio 2015, see [Breaking Changes in Visual C++ 2015](../vs140/breaking-changes-in-visual-c---2015.md).  
  
-   [Compiler Breaking Changes](#BK_compiler)  
  
##  \<a name="BK_compiler">\</a> Visual C++ Compiler  
  
-   **Private virtual base classes and indirect inheritance**  
  
     Previous versions of the compiler allowed a derived class to call member functions of its *indirectly-derived*<CodeContentPlaceHolder>25\</CodeContentPlaceHolder> base classes. This old behavior was incorrect and does not conform to the C++ standard. The compiler no longer accepts code written in this way and issues compiler error C2280 as a result.  
  
 **error C2280: *'void \*S3::__delDtor(unsigned int)'*: attempting to reference a deleted function**     Example (before)  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     Example (after)  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     -or-  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
-   **Overloaded operator new and operator delete**  
  
     Previous versions of the compiler allowed non-member <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and non-member <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> to be declared static, and to be declared in namespaces other than the global namespace.  This old behavior created a risk that the program would not call the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> operator implementation that the programmer intended, resulting in silent bad runtime behavior. The compiler no longer accepts code written in this way and issues compiler error C2323 instead.  
  
 **error C2323: *'operator new'*: non-member operator new or delete functions may not be declared static or in a namespace other than the global namespace.**     Example (before)  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
     Example (after)  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
     Additionally, although the compiler doesn't give a specific diagnostic, inline operator new is considered ill-formed.  
  
-   **Calling 'operator *type*()' (user-defined conversion) on non-class types**  
  
     Previous versions of the compiler allowed 'operator *type*()' to be called on non-class types while silently ignoring it. This old behavior created a risk of silent bad code generation, resulting in unpredictable runtime behavior. The compiler no longer accepts code written in this way and issues compiler error C2228 instead.  
  
 **error C2228: left of '.operator *type*' must have class/struct/union**     Example (before)  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
     Example (after)  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
-   **Redundant typename in elaborated type specifiers**  
  
     Previous versions of the compiler allowed <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> in an elaborated type specifiers; code written in this way is semantically incorrect. The compiler no longer accepts code written in this way and issues compiler error C3406 instead.  
  
 **error C3406: 'typename' cannot be used in an elaborated type specifier**     Example (before)  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
     Example (after)  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
-   **Type deduction of arrays from an initializer list**  
  
     Previous versions of the compiler did not support type deduction of arrays from an initializer list. The compiler now supports this form of type deduction and, as a result, calls to function templates using initializer lists might now be ambiguous or a different overload might be chosen than in previous versions of the compiler. To resolve these issues, the program must now explicitly specify the overload that the programmer intended.  
  
     When this new behavior causes overload resolution to consider an additional candidate that is equally as good as the historic candidate, the call becomes ambiguous and the compiler issues compiler error C2668 as a result.  
  
 **error C2668: '*function*' : ambiguous call to overloaded function.**     Example 1: Ambiguous call to overloaded function (before)  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
     Example 1: ambiguous call to overloaded function (after)  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
     When this new behavior causes overload resolution to consider an additional candidate that is a better match than the historic candidate, the call resolves unambiguously to the new candidate, causing a change in program behavior that is probably different than the programmer intended.  
  
     Example 2: change in overload resolution (before)  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
     Example 2: change in overload resolution (after)  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
-   **Restoration of switch statement warnings**  
  
     A Previous version of the compiler removed previously-existing warnings related to <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> statements; these warnings have now been restored. The compiler now issues the restored warnings, and warnings related to specific cases (including the default case) are now issued on the line containing the offending case, rather than on the last line of the switch statement. As a result of now issuing those warnings on different lines than in the past, warnings previously suppressed by using <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> may no longer be suppressed as intended. To suppress these warnings as intended, it might be necessary to move the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> directive to a line above the first potentially-offending case. The following are the restored warnings.  
  
 **warning C4060: switch statement contains no 'case' or 'default' labels warning C4061: enumerator '*bit1*' in switch of enum '*flags*' is not explicitly handled by a case label warning C4062: enumerator '*bit1*' in switch of enum '*flags*' is not handled warning C4063: case '*bit32*' is not a valid value for switch of enum '*flags*' warning C4064: switch of incomplete enum '*flags*' warning C4065: switch statement contains 'default' but no 'case' labels warning C4808: case '*value*' is not a valid value for switch condition of type '*bool*' Warning C4809: switch statement has redundant 'default' label; all possible 'case' labels are given**     Example of C4063 (before)  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
     Example of C4063 (after)  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
     Examples of the other restored warnings are provided in their documentation.  
  
-   **#include: use of parent-directory specifier '..' in pathname** (only affects /Wall /WX)  
  
     Previous versions of the compiler did not detect the use of the parent-directory specifier '..' in the pathname of  <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> directives. Code written in this way is usually intended to include headers that exist outside of the project by incorrectly using project-relative paths. This old behavior created a risk that the program could be compiled by including a different source file than the programmer intended, or that these relative paths would not be portable to other build environments. The compiler now detects and notifies the programmer of code written in this way and issues an optional compiler warning C4464, if enabled.  
  
 **warning C4464: relative include path contains '..'**     Example (before)  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
     Example (after)  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
     Additionally, although the compiler does not give a specific diagnostic, we also recommend that the parent-directory specifier ".." should note be used to specify your project's include directories.  
  
-   **#pragma optimize() extends past end of header file** (only affects /Wall /WX)  
  
     Previous versions of the compiler did not detect changes to  optimization flag settings that escape a header file included within a translation unit. The compiler now detects and notifies the programmer of code written in this way and issues an optional compiler warning C4426 at the location of the offending <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, if enabled. This warning is only issued if the changes conflict with the optimization flags set by command-line arguments to the compiler.  
  
 **warning C4426: optimization flags changed after including header, may be due to #pragma optimize()**     Example (before)  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
     Example (after)  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
-   **Mismatched #pragma warning(push)** and **#pragma warning(pop)** (only affects /Wall /WX)  
  
     Previous versions of the compiler did not detect <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> state changes being paired with <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> state changes in a different source file, which is rarely intended. This old behavior created a risk that the program would be compiled with a different set of warnings enabled than the programmer intended, possibly resulting in silent bad runtime behavior. The compiler now detects and notifies the programmer of code written in this way and issues an optional compiler warning C5031 at the location of the matching <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, if enabled. This warning includes a note referencing the location of the corresponding #pragma warning(push).  
  
 **warning C5031: #pragma warning(pop): likely mismatch, popping warning state pushed in different file**     Example (before)  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
     Example (after)  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
     Though uncommon, code written in this way is sometimes intentional. Code written in this way is sensitive to changes in <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> order; when possible, we recommend that source code files manage warning state in a self-contained way.  
  
-   **Unmatched #pragma warning(push)** (only affects /Wall /WX)  
  
     Previous versions of the compiler did not detect unmatched <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> state changes at the end of a translation unit. The compiler now detects and notifies the programmer of code written in this way and issues an optional compiler warning C5032 at the location of the unmatched #pragma warning(push), if enabled. This warning is only issued if there are no compilation errors in the translation unit.  
  
 **warning C5032: detected #pragma warning(push) with no corresponding #pragma warning(pop)**     Example (before)  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
     Example (after)  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
-   **Additional warnings might be issued as a result of improved #pragma warning state tracking**  
  
     Previous versions of the compiler tracked #pragma warning state changes insufficiently well to issue all intended warnings. This behavior created a risk that certain warnings would be effectively suppressed in circumstances different than the programmer intended. The compiler now tracks #pragma warning state more robustly -- especially related to #pragma warning state changes inside of templates -- and optionally issues new warnings C5031 and C5032 which are intended to help the programmer locate unintended uses of <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
     As a result of improved #pragma warning state change tracking, warnings formerly incorrectly suppressed or warnings related to issues formerly misdiagnosed might now be issued.  
  
-   **Improved identification of unreachable code**  
  
     C++ Standard Library changes and improved ability to inline function calls over previous versions of the compiler might allow the compiler to prove that certain code is now unreachable. This new behavior can result in new and more-frequently issued instances of warning C4720.  
  
 **warning C4720: unreachable code**     In many cases, this warning might only be issued when compiling with optimizations enabled, since optimizations may inline more function calls, eliminate redundant code, or otherwise make it possible to determine that certain code is unreachable. We have observed that new instances of warning C4720 have frequently occurred in try/catch blocks, especially in relation to use of \<xref:find*>.  
  
     Example (before)  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
     Example (after)  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>