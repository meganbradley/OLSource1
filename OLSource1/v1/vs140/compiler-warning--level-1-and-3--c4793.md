---
title: "Compiler Warning (level 1 and 3) C4793"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C4793"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C6634"
  - "C6635"
  - "C6640"
  - "C6630"
  - "C6639"
  - "C6636"
  - "C6638"
  - "C6631"
  - "C6637"
  - "C4793"
ms.assetid: 819ada53-1d9c-49b8-a629-baf8c12314e6
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1 and 3) C4793
'function' : function is compiled as native code: 'reason'  
  
 The compiler cannot compile *function* into managed code, even though the [/clr](../vs140/-clr--common-language-runtime-compilation-.md) compiler option is specified. Instead, the compiler emits warning C4793 and an explanatory continuation message, and then compiles *function* into native code. The continuation message contains the *reason* text that explains why *function* cannot be compiled to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 This is a level 1 warning when you specify the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> compiler option.  
  
 The following table lists all possible continuation messages.  
  
|Reason message|Remarks|  
|--------------------|-------------|  
|Aligned data types are not supported in managed code|The CLR must be able to allocate data as needed, which might not be possible if the data is aligned with declarations such as [__m128](../vs140/__m128.md) or [align](../vs140/align--c---.md).|  
|Functions that use '__ImageBase' are not supported in managed code|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is a special linker symbol that is typically used only by low-level native code to load a DLL.|  
|varargs are not supported by the '/clr' compiler option|Native functions cannot call managed functions that have [variable argument lists](../vs140/variable-argument-lists.md) (varargs) because the functions have different stack layout requirements. However, if you specify the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> compiler option, variable argument lists are supported because the assembly can contain only managed functions. For more information, see [Pure and Verifiable Code](../vs140/pure-and-verifiable-code--c---cli-.md).|  
|The 64-bit CLR does not support data declared with the __ptr32 modifier|A pointer must be the same size as a native pointer on the current platform. For more information, see [__ptr32, \__ptr64](../vs140/__ptr32--__ptr64.md).|  
|The 32-bit CLR does not support data declared with the __ptr64 modifier|A pointer must be the same size as a native pointer on the current platform. For more information, see [__ptr32, \__ptr64](../vs140/__ptr32--__ptr64.md).|  
|One or more intrinsics is not supported in managed code|The name of the intrinsic is not available at the time the message is emitted. However, an intrinsic that causes this message typically represents a low-level machine instruction.|  
|Inline native assembly ('__asm') is not supported in managed code|[Inline assembly code](../vs140/__asm.md) can contain arbitrary native code, which cannot be managed.|  
|A non-__clrcall virtual function thunk must be compiled as native|A non-[__clrcall](../vs140/__clrcall.md) virtual function thunk must use an unmanaged address.|  
|A function using '_setjmp' must be compiled as native|The CLR must be able to control program execution. However, the [setjmp](../vs140/using-setjmp-longjmp.md) function bypasses regular program execution by saving and restoring low-level information such as registers and execution state.|  
  
## Example  
 The following sample generates C4793.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **warning C4793: 'asmfunc' : function is compiled as native code:**  
 **Inline native assembly ('__asm') is not supported in managed code**   
## Example  
 The following sample generates C4793.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **warning C4793: 'f' : function is compiled as native code:**  
 **A function using '_setjmp' must be compiled as native**