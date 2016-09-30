---
title: "__asm"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "__asm"
  - "__asm_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__asm keyword [C++], vs. asm blocks"
  - "__asm keyword [C++]"
ms.assetid: 77ff3bc9-a492-4b5e-85e1-fa4e414e79cd
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __asm
**Microsoft Specific**  
  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keyword invokes the inline assembler and can appear wherever a C or C++ statement is legal. It cannot appear by itself. It must be followed by an assembly instruction, a group of instructions enclosed in braces, or, at the very least, an empty pair of braces. The term "<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> block" here refers to any instruction or group of instructions, whether or not in braces.  
  
> [!NOTE]
>  Visual C++ support for the Standard C++ <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> keyword is limited to the fact that the compiler will not generate an error on the keyword. However, an <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> block will not generate any meaningful code. Use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 Syntax:  
  
 __asm *assembly-instruction* [ ; ]  
  
 __asm { *assembly-instruction-list* } [ ; ]  
  
## Grammar  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>opt  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>opt  
  
 *assembly-instruction-list*:  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>opt  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>opt  
  
 If used without braces, the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> keyword means that the rest of the line is an assembly-language statement. If used with braces, it means that each line between the braces is an assembly-language statement. For compatibility with previous versions, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is a synonym for <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
 Since the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> keyword is a statement separator, you can put assembly instructions on the same line.  
  
 Before Visual C++ 2005, the instruction  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 did not cause native code to be generated when compiled with **/clr**; the compiler translated the instruction to a CLR break instruction.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> now results in native code generation for the function. If you want a function to cause a break point in your code and if you want that function compiled to MSIL, use [__debugbreak](../vs140/__debugbreak.md).  
  
## Example  
 The following code fragment is a simple <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> block enclosed in braces:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Alternatively, you can put <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> in front of each assembly instruction:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Because the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> keyword is a statement separator, you can also put assembly instructions on the same line:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 All three examples generate the same code, but the first style (enclosing the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> block in braces) has some advantages. The braces clearly separate assembly code from C or C++ code and avoid needless repetition of the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> keyword. Braces can also prevent ambiguities. If you want to put a C or C++ statement on the same line as an <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> block, you must enclose the block in braces. Without the braces, the compiler cannot tell where assembly code stops and C or C++ statements begin. Finally, because the text in braces has the same format as ordinary MASM text, you can easily cut and paste text from existing MASM source files.  
  
 Unlike braces in C and C++, the braces enclosing an <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> block don't affect variable scope. You can also nest <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> blocks; nesting does not affect variable scope.  
  
 **END Microsoft Specific**  
  
## See Also  
 [Keywords](../vs140/keywords--c---.md)   
 [Inline Assembler](../vs140/inline-assembler.md)