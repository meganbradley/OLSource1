---
title: "Microsoft Extensions to C and C++"
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
helpviewer_keywords: 
  - "or_eq operator"
  - "~ operator, extensions to C/C++"
  - "& operator, extensions to C/C++"
  - "&= operator"
  - "iso646.h header"
  - "Xor operator, Microsoft extensions to C/C++"
  - "!= operator"
  - "! operator, extension to C++"
  - "Or operator, Microsoft extensions to C/C++"
  - "^ operator, extensions to C/C++"
  - "^= operator, C++ extensions"
  - "xor_eq operator"
  - "and_eq operator"
  - "Microsoft extensions to C/C++"
  - "|= operator"
  - "|| operator"
  - "And operator, extensions to C/C++"
  - "NOT operator"
  - "&& operator"
  - "extensions, C language"
  - "Visual C++, extensions to C/C++"
  - "| operator, extensions"
  - "not_eq operator"
  - "Visual C, Microsoft extensions"
  - "extensions"
  - "compl method"
ms.assetid: e811a74a-45ba-4c00-b206-2f2321b8689a
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Microsoft Extensions to C and C++
Visual C++ extends the ANSI C and ANSI C++ standards as follows.  
  
## Keywords  
 Several keywords are added. In the list in [Keywords](../vs140/keywords--c---.md), the keywords that have two leading underscores are Visual C++ extensions.  
  
## Out of Class Definition of static const Integral (or enum) Members  
 Under the standard (**/Za**), you must make an out-of-class definition for data members, as shown here:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Under **/Ze**, the out-of-class definition is optional for static, const integral, and const enum data members. Only integrals and enums that are static and const can have initializers in a class; the initializing expression must be a const expression.  
  
 To avoid errors when an out-of-class definition is provided in a header file and the header file is included in multiple source files, use [selectany](../vs140/selectany.md). For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Casts  
 Both the C++ compiler and C compiler support these kinds of non-ANSI casts:  
  
-   Non-ANSI casts to produce l-values. For example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
    > [!NOTE]
    >  This extension is available in the C language only. You can use the following ANSI C standard form in C++ code to modify a pointer as if it is a pointer to a different type.  
  
     The preceding example could be rewritten as follows to conform to the ANSI C standard.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
-   Non-ANSI casts of a function pointer to a data pointer. For example:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
     To perform the same cast and also maintain ANSI compatibility, you can cast the function pointer to a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> before you cast it to a data pointer:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## Variable-Length Argument Lists  
 Both the C++ compiler and C compiler support a function declarator that specifies a variable number of arguments, followed by a function definition that provides a type instead:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## Single-Line Comments  
 The C compiler supports single-line comments, which are introduced by using two forward slash (//) characters:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
## Scope  
 The C compiler supports the following scope-related features.  
  
-   Redefinitions of extern items as static:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
-   Use of benign typedef redefinitions within the same scope:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
-   Function declarators have file scope:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
-   Use of block-scope variables that are initialized by using nonconstant expressions:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
## Data Declarations and Definitions  
 The C compiler supports the following data declaration and definition features.  
  
-   Mixed character and string constants in an initializer:  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
-   Bit fields that have base types other than **unsigned int** or **signed int**.  
  
-   Declarators that don't have a type:  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
-   Unsized arrays as the last field in structures and unions:  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
-   Unnamed (anonymous) structures:  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
-   Unnamed (anonymous) unions:  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
-   Unnamed members:  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
## Intrinsic Floating-Point Functions  
 Both the C++ compiler and C compiler support inline generation **x86 Specific >** of the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> functions **END x86 Specific** when **/Oi** is specified. For the C compiler, ANSI conformance is lost when these intrinsics are used, because they do not set the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> variable.  
  
## Passing a Non-Const Pointer Parameter to a Function that Expects a Reference to a Const Pointer Parameter  
 This is an extension to C++. This code will compile with **/Ze**:  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
## ISO646.H Not Enabled  
 Under **/Ze**, you have to include iso646.h if you want to use text forms of the following operators:  
  
-   && (and)  
  
-   &= (and_eq)  
  
-   & (bitand)  
  
-   &#124; (bitor)  
  
-   ~ (compl)  
  
-   ! (not)  
  
-   != (not_eq)  
  
-   &#124;&#124; (or)  
  
-   &#124;= (or_eq)  
  
-   ^ (xor)  
  
-   ^= (xor_eq)  
  
## Address of String Literal Has Type const char [], not const char (*) []  
 The following example will output char const (\*)[4] under **/Za**, but char const [4] under **/Ze**.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
## See Also  
 [/Za, /Ze (Disable Language Extensions)](../vs140/-za---ze--disable-language-extensions-.md)   
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)