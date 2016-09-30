---
title: "ARM Assembler Diagnostic Messages"
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
ms.assetid: 52b38267-6023-4bdc-a0ef-863362f48eec
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ARM Assembler Diagnostic Messages
The Microsoft ARM assembler (*armasm*) emits diagnostic warnings and errors when it encounters them. This article describes the most commonly-encountered messages.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Diagnostic Messages  
  
### Errors  
 A2193: this instruction generates unpredictable behavior  
 The ARM architecture cannot guarantee what happens when this instruction is executed.  For details about the well-defined forms of this instruction, consult the [ARM Architecture Reference Manual](http://go.microsoft.com/fwlink/?LinkId=246464).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A2196: instruction cannot be encoded in 16 bits  
 The specified instruction cannot be encoded as a 16-bit Thumb instruction.  Specify a 32-bit instruction, or rearrange code to bring the target label into the range of a 16-bit instruction.  
  
 The assembler may attempt to encode a branch in 16 bits and fail with this error, even though a 32-bit branch is encodable. You can solve this problem by using the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> specifier to explicitly mark the branch as 32-bit.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A2202: Pre-UAL instruction syntax not allowed in THUMB region  
 Thumb code must use the Unified Assembler Language (UAL) syntax.  The old syntax is no longer accepted  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A2513: Rotation must be even  
 In ARM mode, there is an alternate syntax for specifying constants.  Instead of writing <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, you can write <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, which represents the constant value that is obtained by rotating the value <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> right by <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  When you use this syntax, you must make the value of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> even.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A2557: Incorrect number of bytes to write back  
 On the NEON structure load and store instructions (<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>), there is an alternate syntax for specifying writeback to the base register.  Instead of putting an exclamation point (!) after the address, you can specify an immediate value that indicates the offset to be added to the base register.  If you use this syntax, you must specify the exact number of bytes that were loaded or stored by the instruction.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Warnings  
 A4228: Alignment value exceeds AREA alignment; alignment not guaranteed  
 The alignment that is specified in an <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> directive is greater than the alignment of the enclosing <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  As a result, the assembler cannot guarantee that the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> directive will be honored.  
  
 To fix this, you can specify on the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> directive an <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> attribute that is equal to or greater than the desired alignment.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A4508: Use of this rotated constant is deprecated  
 In ARM mode, there is an alternate syntax for specifying constants.  Instead of writing <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, you can write <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, which represents the constant value that is obtained by rotating the value <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> right by <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  In some contexts, ARM has deprecated the use of these rotated constants. In these cases, use the basic <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> syntax instead.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A4509: This form of conditional instruction is deprecated  
 This form of conditional instruction has been deprecated by ARM in the ARMv8 architecture. We recommend that you change the code to use conditional branches. To see which conditional instructions are still supported, consult the [ARM Architecture Reference Manual](http://go.microsoft.com/fwlink/?LinkId=246464).  
  
 This warning is not emitted when the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> command-line switch is used.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
## See Also  
 [ARM Assembler Command Line Reference](../vs140/arm-assembler-command-line-reference.md)   
 [ARM Assembler Directives](../vs140/arm-assembler-directives.md)