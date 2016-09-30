---
title: "-netcf"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/netcf"
f1_keywords: 
  - "/netcf"
  - "netcf"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "-netcf compiler option [Visual Basic]"
  - "netcf compiler option [Visual Basic]"
  - "/netcf compiler option [Visual Basic]"
ms.assetid: db7cfa59-c315-401c-a59b-0daf355343d6
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -netcf
Sets the compiler to target the [!INCLUDE[Compact](../vs140/includes/compact_md.md)].  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> option causes the [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compiler to target the [!INCLUDE[Compact](../vs140/includes/compact_md.md)] rather than the full [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)]. Language functionality that is present only in the full [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] is disabled.  
  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> option is designed to be used with [/sdkpath](../vs140/-sdkpath.md). The language features disabled by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> are the same language features not present in the files targeted with <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> option is not available from within the Visual Studio development environment; it is available only when compiling from the command line. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> option is set when a [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] device project is loaded.  
  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> option changes the following language features:  
  
-   The [End \<keyword> Statement](../vs140/end--keyword--statement--visual-basic-.md) keyword, which terminates execution of a program, is disabled. The following program compiles and runs without <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> but fails at compile time with <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
     [!code[VbVbalrCompiler#34](../vs140/codesnippet/VisualBasic/-netcf_1.vb)]  
  
-   Late binding, in all forms, is disabled. Compile-time errors are generated when recognized late-binding scenarios are encountered. The following program compiles and runs without <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> but fails at compile time with <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
     [!code[VbVbalrCompiler#35](../vs140/codesnippet/VisualBasic/-netcf_2.vb)]  
  
-   The [Auto](../vs140/auto--visual-basic-.md), [Ansi](../vs140/ansi--visual-basic-.md), and [Unicode](../vs140/unicode--visual-basic-.md) modifiers are disabled. The syntax of the [Declare Statement](../vs140/declare-statement.md) statement is also modified to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. The following code shows the effect of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> on a compilation.  
  
     [!code[VbVbalrCompiler#36](../vs140/codesnippet/VisualBasic/-netcf_3.vb)]  
  
-   Using Visual Basic 6.0 keywords that were removed from [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] generates a different error when <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is used. This affects the error messages for the following keywords:  
  
    -   <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
    -   <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
    -   <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
    -   <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
    -   <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
    -   <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
    -   <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
    -   <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
    -   <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
    -   <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
    -   <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
    -   <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  
    -   <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  
    -   <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
    -   <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  
    -   <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
## Example  
 The following code compiles <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> with the [!INCLUDE[Compact](../vs140/includes/compact_md.md)], using the versions of Mscorlib.dll and Microsoft.VisualBasic.dll found in the default installation directory of the [!INCLUDE[Compact](../vs140/includes/compact_md.md)] on the C drive. Typically, you would use the most recent version of the [!INCLUDE[Compact](../vs140/includes/compact_md.md)].  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)   
 [/sdkpath](../vs140/-sdkpath.md)