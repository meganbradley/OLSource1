---
title: "#if, #elif, #else, and #endif Directives (C-C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "#if, #elif, #else, and #endif Directives (C/C++)"
f1_keywords: 
  - "#else"
  - "#endif"
  - "#if"
  - "#elif"
  - "Defined"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "#elif directive"
  - "conditional compilation, directives"
  - "endif directive (#endif)"
  - "preprocessor, directives"
  - "#else directive"
  - "#endif directive"
  - "if directive (#if)"
  - "else directive (#else)"
  - "#if directive"
  - "elif directive (#elif)"
  - "defined directive"
ms.assetid: c77a175f-6ca8-47d4-8df9-7bac5943d01b
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# #if, #elif, #else, and #endif Directives (C-C++)
The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> directive, with the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> directives, controls compilation of portions of a source file. If the expression you write (after the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>) has a nonzero value, the line group immediately following the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> directive is retained in the translation unit.  
  
## Grammar  
 *conditional* :  
 *if-part elif-parts*opt*else-part*opt*endif-line*  
  
 *if-part* :  
 *if-line text*  
  
 *if-line* :  
 **#if**  *constant-expression*  
  
 **#ifdef**  *identifier*  
  
 **#ifndef**  *identifier*  
  
 *elif-parts* :  
 *elif-line text*  
  
 *elif-parts elif-line text*  
  
 *elif-line* :  
 **#elif**  *constant-expression*  
  
 *else-part* :  
 *else-line text*  
  
 *else-line* :  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 *endif-line* :  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 Each <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> directive in a source file must be matched by a closing <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> directive. Any number of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> directives can appear between the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> directives, but at most one <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> directive is allowed. The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> directive, if present, must be the last directive before <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> directives can nest in the text portions of other <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> directives. Each nested <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> directive belongs to the closest preceding <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> directive.  
  
 All conditional-compilation directives, such as <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and **#ifdef**, must be matched with closing <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> directives prior to the end of file; otherwise, an error message is generated. When conditional-compilation directives are contained in include files, they must satisfy the same conditions: There must be no unmatched conditional-compilation directives at the end of the include file.  
  
 Macro replacement is performed within the part of the command line that follows an <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> command, so a macro call can be used in the *constant-expression*.  
  
 The preprocessor selects one of the given occurrences of *text* for further processing. A block specified in *text* can be any sequence of text. It can occupy more than one line. Usually *text* is program text that has meaning to the compiler or the preprocessor.  
  
 The preprocessor processes the selected *text* and passes it to the compiler. If *text* contains preprocessor directives, the preprocessor carries out those directives. Only text blocks selected by the preprocessor are compiled.  
  
 The preprocessor selects a single *text* item by evaluating the constant expression following each <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> directive until it finds a true (nonzero) constant expression. It selects all text (including other preprocessor directives beginning with **#**) up to its associated <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
 If all occurrences of *constant-expression* are false, or if no <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> directives appear, the preprocessor selects the text block after the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> clause. If the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> clause is omitted and all instances of *constant-expression* in the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> block are false, no text block is selected.  
  
 The *constant-expression* is an integer constant expression with these additional restrictions:  
  
-   Expressions must have integral type and can include only integer constants, character constants, and the **defined** operator.  
  
-   The expression cannot use <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> or a type-cast operator.  
  
-   The target environment may not be able to represent all ranges of integers.  
  
-   The translation represents type <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> the same as type **long**, and <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> the same as <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
-   The translator can translate character constants to a set of code values different from the set for the target environment. To determine the properties of the target environment, check values of macros from LIMITS.H in an application built for the target environment.  
  
-   The expression must not perform any environmental inquiries and must remain insulated from implementation details on the target computer.  
  
 The preprocessor operator **defined** can be used in special constant expressions, as shown by the following syntax:  
  
 defined( <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> )  
  
 defined <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
  
 This constant expression is considered true (nonzero) if the *identifier* is currently defined; otherwise, the condition is false (0). An identifier defined as empty text is considered defined. The **defined** directive can be used in an <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> and an <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> directive, but nowhere else.  
  
 In the following example, the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> directives control compilation of one of three function calls:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The function call to <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> is compiled if the identifier <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> is defined. If the identifier <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> is defined, the function call to <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> is compiled. If neither identifier is defined, the call to <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> is compiled. Note that <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> are distinct identifiers in C and C++ because their cases are different.  
  
 The conditional compilation statements in the following example assume a previously defined symbolic constant named <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The first <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> block shows two sets of nested <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> directives. The first set of directives is processed only if <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> is true. Otherwise, the statements after #**else** are processed.  
  
 The <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> directives in the second example are used to make one of four choices, based on the value of <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>. The constant <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> is set to 0, 100, or 200, depending on the definition of <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> is greater than 5, then the statement  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 is compiled and <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> is not defined.  
  
 A common use for conditional compilation is to prevent multiple inclusions of the same header file. In C++, where classes are often defined in header files, constructs like the following can be used to prevent multiple definitions:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The preceding code checks to see if the symbolic constant <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> is defined. If so, the file has already been included and need not be reprocessed. If not, the constant <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> is defined to mark EXAMPLE.H as already processed.  
  
## See Also  
 [Preprocessor Directives](../vs140/preprocessor-directives.md)