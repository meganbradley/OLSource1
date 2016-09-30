---
title: "ARM Assembler Command-Line Reference"
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
ms.assetid: f7b89478-1ab5-4995-8cde-a805f0462c45
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ARM Assembler Command-Line Reference
This article provides command-line information about the Microsoft ARM assembler, *armasm*, which compiles ARMv7 Thumb assembly language into the Microsoft implementation of the Common Object File Format (COFF). The linker can link COFF code with object code that is produced by the ARM assembler or by the C compiler, together with object libraries that are created by the librarian.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 -errors <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Redirect error and warning messages to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 -i <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Add the specified directories to the include search path.  
  
 -predefine <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specify a SETA, SETL, or SETS directive to predefine a symbol. Example: **armasm.exe -predefine "COUNT SETA 150" source.asm**. For more information, see the [ARM assembler tools guide](http://go.microsoft.com/fwlink/?LinkId=246102).  
  
 -nowarn  
 Disable all warning messages.  
  
 -ignore <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Disable the specified warning. For possible values, see the section about warnings.  
  
 -help  
 Print the command-line help message.  
  
 -machine <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Specify the machine type to set in the PE header.  Possible values for <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> are:  
**ARM**—Sets the machine type to IMAGE_FILE_MACHINE_ARMNT. This is the default.   
**THUMB**—Sets the machine type to IMAGE_FILE_MACHINE_THUMB.  
  
 -oldit  
 Generate ARMv7-style IT blocks.  By default, ARMv8-compatible IT blocks are generated.  
  
 -via <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Read additional command-line arguments from <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 -16  
 Assemble source as 16-bit Thumb instructions.  This is the default.  
  
 -32  
 Assemble source as 32-bit ARM instructions.  
  
 -g  
 Generate debugging information.  
  
 -errorReport: <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Specify how internal assembler errors are reported to Microsoft.  Possible values for <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> are:   
**none**—Do not send reports.   
**prompt**—Prompt the user to send reports immediately.   
**queue**—Prompt the user to send reports at the next admin logon. This is the default.   
**send**—Send reports automatically.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The name of the source file.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The name of the object (output) file.  
  
 The following example demonstrates how to use armasm in a typical scenario. First, use armasm to build an assembly language source (.asm) file to an object (.obj) file. Then, use the CL command-line C compiler to compile a source (.c) file, and also specify the linker option to link the ARM object file.  
  
 **armasm myasmcode.asm -o myasmcode.obj**  
  
 **cl myccode.c /link myasmcode.obj**  
  
## See Also  
 [ARM Assembler Diagnostic Messages](../vs140/arm-assembler-diagnostic-messages.md)   
 [ARM Assembler Directives](../vs140/arm-assembler-directives.md)