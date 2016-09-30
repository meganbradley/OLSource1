---
title: "Calling DLL Functions from Visual Basic Applications"
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
helpviewer_keywords: 
  - "functions [C++], calling DLL functions from Visual Basic"
  - "DLL functions [C++]"
  - "function calls [C++], DLL functions"
  - "DLLs [C++], calling"
  - "calling DLL functions from VB applications [C++]"
  - "__stdcall keyword [C++]"
  - "DLL functions [C++], calling"
ms.assetid: 282f7fbf-a0f2-4b9f-b277-1982710be56c
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Calling DLL Functions from Visual Basic Applications
For Visual Basic applications (or applications in other languages such as Pascal or Fortran) to call functions in a C/C++ DLL, the functions must be exported using the correct calling convention without any name decoration done by the compiler.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> creates the correct calling convention for the function (the called function cleans up the stack and parameters are passed from right to left) but decorates the function name differently. So, when **__declspec(dllexport)** is used on an exported function in a DLL, the decorated name is exported.  
  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> name decoration prefixes the symbol name with an underscore (_) and appends the symbol with an at sign (@) character followed by the number of bytes in the argument list (the required stack space). As a result, the function when declared as:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 is decorated as:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The C calling convention (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>) decorates the name as <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 To get the decorated name, use [/MAP](../vs140/-map--generate-mapfile-.md). Use of **__declspec(dllexport)** does the following:  
  
-   If the function is exported with the C calling convention (**_cdecl**), it strips the leading underscore (_) when the name is exported.  
  
-   If the function being exported does not use the C calling convention (for example, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>), it exports the decorated name.  
  
 Because there is no way to override where the stack cleanup occurs, you must use <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. To undecorate names with <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, you must specify them by using aliases in the EXPORTS section of the .def file. This is shown as follows for the following function declaration:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 In the .DEF file:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 For DLLs to be called by programs written in Visual Basic, the alias technique shown in this topic is needed in the .def file. If the alias is done in the Visual Basic program, use of aliasing in the .def file is not necessary. It can be done in the Visual Basic program by adding an alias clause to the [Declare](../vs140/declare-statement.md) statement.  
  
## What do you want to know more about?  
  
-   [Exporting from a DLL](../vs140/exporting-from-a-dll.md)  
  
-   [Exporting from a DLL using .DEF files](../vs140/exporting-from-a-dll-using-def-files.md)  
  
-   [Exporting from a DLL using __declspec(dllexport)](../vs140/exporting-from-a-dll-using-__declspec-dllexport-.md)  
  
-   [Exporting C++ functions for use in C-language executables](../vs140/exporting-c---functions-for-use-in-c-language-executables.md)  
  
-   [Determining which exporting method to use](../vs140/determining-which-exporting-method-to-use.md)  
  
-   [Decorated names](../vs140/decorated-names.md)  
  
## See Also  
 [DLLs in Visual C++](../vs140/dlls-in-visual-c--.md)