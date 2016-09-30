---
title: "Considerations for Writing Prolog-Epilog Code"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
H1: "Considerations for Writing Prolog/Epilog Code"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "stack frame layout"
  - "prolog code"
  - "epilog code"
  - "__LOCAL_SIZE constant"
  - "stack, stack frame layout"
ms.assetid: c7814de2-bb5c-4f5f-96d0-bcfd2ad3b182
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Considerations for Writing Prolog-Epilog Code
## Microsoft Specific  
 Before writing your own prolog and epilog code sequences, it is important to understand how the stack frame is laid out. It is also useful to know how to use the **__LOCAL_SIZE** symbol.  
  
##  \<a name="_pluslang_c.2b2b_.stack_frame_layout">\</a> Stack Frame Layout  
 This example shows the standard prolog code that might appear in a 32-bit function:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> variable represents the number of bytes needed on the stack for local variables, and the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> variable is a placeholder that represents the list of registers to be saved on the stack. After pushing the registers, you can place any other appropriate data on the stack. The following is the corresponding epilog code:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The stack always grows down (from high to low memory addresses). The base pointer (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>) points to the pushed value of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. The locals area begins at <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. To access local variables, calculate an offset from <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> by subtracting the appropriate value from <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
##  \<a name="_pluslang___local_size">\</a> __LOCAL_SIZE  
 The compiler provides a symbol, **__LOCAL_SIZE**, for use in the inline assembler block of function prolog code. This symbol is used to allocate space for local variables on the stack frame in custom prolog code.  
  
 The compiler determines the value of **__LOCAL_SIZE**. Its value is the total number of bytes of all user-defined local variables and compiler-generated temporary variables. **__LOCAL_SIZE** can be used only as an immediate operand; it cannot be used in an expression. You must not change or redefine the value of this symbol. For example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The following example of a naked function containing custom prolog and epilog sequences uses the **__LOCAL_SIZE** symbol in the prolog sequence:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### END Microsoft Specific  
  
## See Also  
 [Naked Function Calls](../vs140/naked-function-calls.md)