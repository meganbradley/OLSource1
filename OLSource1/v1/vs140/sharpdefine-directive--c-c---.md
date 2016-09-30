---
title: "#define Directive (C-C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "#define Directive (C/C++)"
f1_keywords: 
  - "#define"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "define directive (#define), syntax"
  - "preprocessor, directives"
  - "define directive (#define)"
  - "#define directive, syntax"
  - "#define directive"
ms.assetid: 33cf25c6-b24e-40bf-ab30-9008f0391710
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# #define Directive (C-C++)
The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> creates a *macro*, which is the association of an identifier or parameterized identifier with a token string. After the macro is defined, the compiler can substitute the token string for each occurrence of the identifier in the source file.  
  
## Syntax  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> *identifier* *token-string*opt  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> *identifier* <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> *identifier*opt<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>*...*<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>*identifier*opt<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>*token-string*opt  
  
## Remarks  
 The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> directive causes the compiler to substitute *token-string* for each occurrence of *identifier* in the source file. The *identifier* is replaced only when it forms a token. That is, *identifier* is not replaced if it appears in a comment, in a string, or as part of a longer identifier. For more information, see [Tokens](../vs140/tokens--c---.md).  
  
 The *token-string* argument consists of a series of tokens, such as keywords, constants, or complete statements. One or more white-space characters must separate *token-string* from *identifier*. This white space is not considered part of the substituted text, nor is any white space that follows the last token of the text.  
  
 A <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> without a *token-string* removes occurrences of *identifier* from the source file. The *identifier* remains defined and can be tested by using the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> directives.  
  
 The second syntax form defines a function-like macro with parameters. This form accepts an optional list of parameters that must appear in parentheses. After the macro is defined, each subsequent occurrence of *identifier*( *identifier*opt, ..., *identifier*opt ) is replaced with a version of the *token-string* argument that has actual arguments substituted for formal parameters.  
  
 Formal parameter names appear in *token-string* to mark the locations where actual values are substituted. Each parameter name can appear multiple times in *token-string*, and the names can appear in any order. The number of arguments in the call must match the number of parameters in the macro definition. Liberal use of parentheses guarantees that complex actual arguments are interpreted correctly.  
  
 The formal parameters in the list are separated by commas. Each name in the list must be unique, and the list must be enclosed in parentheses. No spaces can separate *identifier* and the opening parenthesis. Use line concatenation — place a backslash (<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>) immediately before the newline character — for long directives on multiple source lines. The scope of a formal parameter name extends to the new line that ends *token-string*.  
  
 When a macro has been defined in the second syntax form, subsequent textual instances followed by an argument list indicate a macro call. The actual arguments that follows an instance of *identifier* in the source file are matched to the corresponding formal parameters in the macro definition. Each formal parameter in *token-string* that is not preceded by a stringizing (<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>), charizing (<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>), or token-pasting (<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>) operator, or not followed by a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> operator, is replaced by the corresponding actual argument. Any macros in the actual argument are expanded before the directive replaces the formal parameter. (The operators are described in [Preprocessor Operators](../vs140/preprocessor-operators.md).)  
  
 The following examples of macros with arguments illustrate the second form of the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> syntax:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Arguments with side effects sometimes cause macros to produce unexpected results. A given formal parameter may appear more than one time in *token-string*. If that formal parameter is replaced by an expression with side effects, the expression, with its side effects, may be evaluated more than one time. (See the examples under [Token-Pasting Operator (##)](../vs140/token-pasting-operator--sharpsharp-.md).)  
  
 The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> directive causes an identifier's preprocessor definition to be forgotten. See [The #undef Directive](../vs140/sharpundef-directive--c-c---.md) for more information.  
  
 If the name of the macro being defined occurs in *token-string* (even as a result of another macro expansion), it is not expanded.  
  
 A second <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> for a macro with the same name generates a warning unless the second token sequence is identical to the first.  
  
 **Microsoft Specific**  
  
 Microsoft C/C++ lets you redefine a macro if the new definition is syntactically identical to the original definition. In other words, the two definitions can have different parameter names. This behavior differs from [!INCLUDE[vcpransi](../vs140/includes/vcpransi_md.md)] C, which requires that the two definitions be lexically identical.  
  
 For example, the following two macros are identical except for the parameter names. [!INCLUDE[vcpransi](../vs140/includes/vcpransi_md.md)] C does not allow such a redefinition, but Microsoft C/C++ compiles it without error.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 On the other hand, the following two macros are not identical and will generate a warning in Microsoft C/C++.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **END Microsoft Specific**  
  
 This example illustrates the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> directive:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The first statement defines the identifier <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> as the integer constant 80 and defines <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> in terms of <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and the integer constant 10. Each occurrence of <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is replaced by (<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>). In turn, each occurrence of <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is replaced by the expression (<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>). The parentheses around <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> are important because they control the interpretation in statements such as the following:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 After the preprocessing stage the statement becomes:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 which evaluates to 1800. Without parentheses, the result is:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 which evaluates to 280.  
  
 **Microsoft Specific**  
  
 Defining macros and constants with the [/D](../vs140/-d--preprocessor-definitions-.md) compiler option has the same effect as using a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> preprocessing directive at the start of your file. Up to 30 macros can be defined by using the /D option.  
  
 **END Microsoft Specific**  
  
## See Also  
 [Preprocessor Directives](../vs140/preprocessor-directives.md)