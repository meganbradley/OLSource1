---
title: "-Gd, -Gr, -Gv, -Gz (Calling Convention)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Gd, /Gr, /Gv, /Gz (Calling Convention)"
f1_keywords: 
  - "/gr"
  - "/Gv"
  - "/gz"
  - "/Gd"
  - "VC.Project.VCCLCompilerTool.CallingConvention"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "-Gd compiler option [C++]"
  - "-Gv compiler option [C++]"
  - "/Gv compiler option [C++]"
  - "-Gr compiler option [C++]"
  - "Gd compiler option [C++]"
  - "Gr compiler option [C++]"
  - "/Gz compiler option [C++]"
  - "-Gz compiler option [C++]"
  - "/Gd compiler option [C++]"
  - "Gz compiler option [C++]"
  - "Gv compiler option [C++]"
  - "/Gr compiler option [C++]"
ms.assetid: fd3110cb-2d77-49f2-99cf-a03f9ead00a3
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Gd, -Gr, -Gv, -Gz (Calling Convention)
These options determine the order in which function arguments are pushed onto the stack, whether the caller function or called function removes the arguments from the stack at the end of the call, and the name-decorating convention that the compiler uses to identify individual functions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 **/Gd**, the default setting, specifies the [__cdecl](../vs140/__cdecl.md) calling convention for all functions except C++ member functions and functions that are marked [__stdcall](../vs140/__stdcall.md), [__fastcall](../vs140/__fastcall.md), or [__vectorcall](../vs140/__vectorcall.md).  
  
 **/Gr** specifies the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> calling convention for all functions except C++ member functions, functions named <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, and functions that are marked <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. All <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> functions must have prototypes. This calling convention is only available in compilers that target x86, and is ignored by compilers that target other architectures.  
  
 **/Gz** specifies the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> calling convention for all functions except C++ member functions, functions named <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, and functions that are marked <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. All <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> functions must have prototypes. This calling convention is only available in compilers that target x86, and is ignored by compilers that target other architectures.  
  
 **/Gv** specifies the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> calling convention for all functions except C++ member functions, functions named main, functions with a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> variable argument list, or functions that are marked with a conflicting <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> attribute. This calling convention is only available on x86 and x64 architectures that support /arch:SSE2 and above, and is ignored by compilers that target the ARM architecture.  
  
 Functions that take a variable number of arguments must be marked <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 **/Gd**, **/Gr**, **/Gv** and **/Gz** are not compatible with [/clr:safe](../vs140/-clr--common-language-runtime-compilation-.md) or **/clr:pure**.  
  
> [!NOTE]
>  By default for x86 processors, C++ member functions use [__thiscall](../vs140/__thiscall.md).  
  
 For all processors, a member function that is explicitly marked as <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> uses the specified calling convention if it is not ignored on that architecture. A member function that takes a variable number of arguments always uses the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> calling convention.  
  
 These compiler options have no effect on the name decoration of C++ methods and functions. Unless declared as <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, C++ methods and functions use a different name-decorating scheme. For more information, see [Decorated Names](../vs140/decorated-names.md).  
  
 For more information about calling conventions, see [Calling Conventions](../vs140/calling-conventions.md).  
  
## __cdecl Specifics  
 On x86 processors, all function arguments are passed on the stack from right to left. On ARM and x64 architectures, some arguments are passed by register and the rest are passed on the stack from right to left. The calling routine pops the arguments from the stack.  
  
 For C, the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> naming convention uses the function name preceded by an underscore ( <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> ); no case translation is performed. Unless declared as <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, C++ functions use a different name-decorating scheme. For more information, see [Decorated Names](../vs140/decorated-names.md).  
  
## __fastcall Specifics  
 Some of a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> function's arguments are passed in registers (for x86 processors, ECX, and EDX), and the rest are pushed onto the stack from right to left. The called routine pops these arguments from the stack before it returns. Typically, **/Gr** decreases execution time.  
  
> [!NOTE]
>  Be careful when you use the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> calling convention for any function that's written in inline assembly language. Your use of registers could conflict with the compiler's use.  
  
 For C, the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> naming convention uses the function name preceded by an at sign (<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>) followed by the size of the function's arguments in bytes. No case translation is done. The compiler uses this template for the naming convention:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 When you use the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> naming convention, use the standard include files. Otherwise, you will get unresolved external references.  
  
## __stdcall Specifics  
 A <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> function's arguments are pushed onto the stack from right to left, and the called function pops these arguments from the stack before it returns.  
  
 For C, the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> naming convention uses the function name preceded by an underscore ( <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> ) and followed by an at sign (@) and the size of the function's arguments in bytes. No case translation is performed. The compiler uses this template for the naming convention:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## __vectorcall Specifics  
 A <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> function’s integer arguments are passed by value, using up to two (on x86) or four (on x64) integer registers, and up to six XMM registers for floating-point and vector values, and the rest are passed on the stack from right to left. The called function cleans off the stack before it returns. Vector and floating-point return values are returned in XMM0.  
  
 For C, the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> naming convention uses the function name followed by two at signs (@@) and the size of the function's arguments in bytes. No case translation is performed. The compiler uses this template for the naming convention:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  Select the **C/C++** folder.  
  
3.  Select the **Advanced** property page.  
  
4.  Modify the **Calling Convention** property.  
  
### To set this compiler option programmatically  
  
-   See \<xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.CallingConvention*>.  
  
## See Also  
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)