---
title: "ARM Assembler Directives"
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
ms.assetid: 9cfa8896-ec10-4e77-855a-3135c40d7d2a
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ARM Assembler Directives
For the most part, the Microsoft ARM assembler uses the ARM assembly language, which is documented in Chapter 7 of the [ARM assembler tools guide](http://go.microsoft.com/fwlink/?LinkId=246102). However, the Microsoft implementations of some assembly directives differ from the ARM assembly directives. This article explains the differences.  
  
## Microsoft Implementations of ARM Assembly Directives  
 AREA  
 The Microsoft ARM assembler supports these AREA attributes: ALIGN, CODE, CODEALIGN, DATA, NOINIT, READONLY, READWRITE, THUMB, ARM.  
  
 All except THUMB and ARM work as documented in the [ARM assembler tools guide](http://go.microsoft.com/fwlink/?LinkId=246102).  
  
 In the Microsoft ARM assembler, THUMB indicates that a CODE section contains Thumb code, and is the default for CODE sections.  ARM indicates that the section contains ARM code.  
  
 ATTR  
 Not supported.  
  
 CODE16  
 Not supported because it implies pre-UAL Thumb syntax, which the Microsoft ARM assembler does not allow.  Use the THUMB directive instead, along with UAL syntax.  
  
 COMMON  
 Specification of an alignment for the common region is not supported.  
  
 DCDO  
 Not supported.  
  
 DN, QN, SN  
 Specification of a type or a lane on the register alias is not supported.  
  
 ENTRY  
 Not supported.  
  
 EQU  
 Specification of a type for the defined symbol is not supported.  
  
 EXPORT and GLOBAL  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is the symbol to be exported.  <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, if specified, can be either <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to indicate that the symbol points to data or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to indicate that the symbol points to code.  
  
 GLOBAL is a synonym for EXPORT.  
  
 EXPORTAS  
 Not supported.  
  
 FRAME  
 Not supported.  
  
 FUNCTION and PROC  
 Although the assembly syntax supports the specification of a custom calling convention on procedures by listing the registers that are caller-save and those that are callee-save, the Microsoft ARM assembler accepts the syntax but ignores the register lists.  The debug information that is produced by the assembler supports only the default calling convention.  
  
 IMPORT and EXTERN  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is the name of the symbol to be imported.  
  
 If WEAK <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is specified, it indicates that <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is a weak external. If no definition for it is found at link time, then all references to it bind instead to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 If TYPE  <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is specified, then <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> indicates how the linker should attempt to resolve <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  These values for <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> are possible:   
1—Do not perform a library search for <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
2—Perform a library search for <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
3—<CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is an alias for <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> (default)  
  
 EXTERN is a synonym for IMPORT, except that <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is imported only if there are references to it in the current assembly.  
  
 MACRO  
 The use of a variable to hold the condition code of a macro is not supported. Default values for macro parameters are not supported.  
  
 NOFP  
 Not supported.  
  
 OPT, TTL, SUBT  
 Not supported because the Microsoft ARM assembler does not produce listings.  
  
 PRESERVE8  
 Not supported.  
  
 RELOC  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> can only follow an instruction or a data definition directive. There is no "anonymous symbol" that can be relocated.  
  
 REQUIRE  
 Not supported.  
  
 REQUIRE8  
 Not supported.  
  
 THUMBX  
 Not supported because the Microsoft ARM assembler does not support the Thumb-2EE instruction set.  
  
## See Also  
 [ARM Assembler Command Line Reference](../vs140/arm-assembler-command-line-reference.md)   
 [ARM Assembler Diagnostic Messages](../vs140/arm-assembler-diagnostic-messages.md)