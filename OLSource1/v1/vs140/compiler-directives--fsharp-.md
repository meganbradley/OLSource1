---
title: "Compiler Directives (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "#line_FS"
  - "#light_FS"
  - "#else_FS"
  - "#endif_FS"
  - "#if_FS"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "#endif directive [F#]"
  - "preprocessor directives [F#]"
  - "#line directive [F#]"
  - "#light directive [F#]"
  - "#if directive [F#]"
  - "directives [F#]"
  - "#else directive [F#]"
  - "compiler directives [F#]"
ms.assetid: 3c8fc5c0-5b3e-4096-9772-68fd3b7c7a11
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Directives (F#)
This topic describes processor directives and compiler directives.  
  
## Preprocessor Directives  
 A preprocessor directive is prefixed with the # symbol and appears on a line by itself. It is interpreted by the preprocessor, which runs before the compiler itself.  
  
 The following table lists the preprocessor directives that are available in F#.  
  
|Directive|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder> *symbol*|Supports conditional compilation. Code in the section after the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is included if the *symbol* is defined.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Supports conditional compilation. Marks a section of code to include if the symbol used with the previous <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is not defined.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Supports conditional compilation. Marks the end of a conditional section of code.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>[line] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>[line] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>[line] <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Indicates the original source code line and file name, for debugging. This feature is provided for tools that generate F# source code.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Disables a compiler warning or warnings. To disable a warning, find its number from the compiler output and include it in quotation marks. Omit the "FS" prefix. To disable multiple warning numbers on the same line, include each number in quotation marks, and separate each string by a space. For example:\<br />\<br /> <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>\<br />\<br /> The effect of disabling a warning applies to the entire file, including portions of the file that precede the directive.|  
  
## Conditional Compilation Directives  
 Code that is deactivated by one of these directives appears dimmed in the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Code Editor.  
  
> [!NOTE]
>  The behavior of the conditional compilation directives is not the same as it is in other languages. For example, you cannot use Boolean expressions involving symbols, and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> have no special meaning. Symbols that you use in the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> directive must be defined by the command line or in the project settings; there is no <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> preprocessor directive.  
  
 The following code illustrates the use of the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> directives. In this example, the code contains two versions of the definition of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. When <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is defined by using the [-define compiler option](../vs140/compiler-options--fsharp-.md), the code between the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> directive and the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> directive is activated. Otherwise, the code between <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is activated.  
  
 [!code[FsLangRef2#7301](../vs140/codesnippet/FSharp/compiler-directives--fsharp-_1.fs)]  
  
 There is no <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> preprocessor directive in F#. You must use the compiler option or project settings to define the symbols used by the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> directive.  
  
 Conditional compilation directives can be nested. Indentation is not significant for preprocessor directives.  
  
## Line Directives  
 When building, the compiler reports errors in F# code by referencing line numbers on which each error occurs. These line numbers start at 1 for the first line in a file. However, if you are generating F# source code from another tool, the line numbers in the generated code are generally not of interest, because the errors in the generated F# code most likely arise from another source. The <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> directive provides a way for authors of tools that generate F# source code to pass information about the original line numbers and source files to the generated F# code.  
  
 When you use the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> directive, file names must be enclosed in quotation marks. Unless the verbatim token (<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>) appears in front of the string, you must escape backslash characters by using two backslash characters instead of one in order to use them in the path. The following are valid line tokens. In these examples, assume that the original file <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> results in an automatically generated F# code file when it is run through a tool, and that the code at the location of these directives is generated from some tokens at line 25 in file <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
 [!code[FsLangRef2#7303](../vs140/codesnippet/FSharp/compiler-directives--fsharp-_2.fs)]  
  
 These tokens indicate that the F# code generated at this location is derived from some constructs at or near line <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
## Compiler Directives  
 Compiler directives resemble preprocessor directives, because they are prefixed with a # sign, but instead of being interpreted by the preprocessor, they are left for the compiler to interpret and act on.  
  
 The following table lists the compiler directive that is available in F#.  
  
|Directive|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder> ["on"&#124;"off"]|Enables or disables lightweight syntax, for compatibility with other versions of ML. By default, lightweight syntax is enabled. Verbose syntax is always enabled. Therefore, you can use both lightweight syntax and verbose syntax. The directive <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> by itself is equivalent to <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>. If you specify <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, you must use verbose syntax for all language constructs. Syntax in the documentation for F# is presented with the assumption that you are using lightweight syntax. For more information, see [Verbose Syntax](../vs140/verbose-syntax--fsharp-.md).|  
  
 For interpreter (fsi.exe) directives, see [F# Interpreter (fsi.exe) Reference](../vs140/fsharp-interactive--fsi.exe--reference.md).  
  
## See Also  
 [F# Language Reference](../vs140/fsharp-language-reference.md)   
 [Compiler Options (F#)](../vs140/compiler-options--fsharp-.md)