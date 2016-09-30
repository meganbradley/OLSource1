---
title: "Required and Optional Header Files"
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
  - "c.headers"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "include files, required in run time"
  - "header files, required in run time"
ms.assetid: f64d0bf5-e2c3-4b42-97d0-443b3d901d9f
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Required and Optional Header Files
The description of each run-time routine includes a list of the required and optional include, or header (.H), files for that routine. Required header files need to be included to obtain the function declaration for the routine or a definition used by another routine called internally. Optional header files are usually included to take advantage of predefined constants, type definitions, or inline macros. The following table lists some examples of optional header file contents:  
  
|Definition|Example|  
|----------------|-------------|  
|Macro definition|If a library routine is implemented as a macro, the macro definition may be in a header file other than the header file for the original routine. For instance, the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> macro is defined in the header file CTYPE.H, while the function <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is declared in STDLIB.H.|  
|Predefined Constant|Many library routines refer to constants that are defined in header files. For instance, the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> routine uses constants such as <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, which is defined in the header file FCNTL.H.|  
|Type definition|Some library routines return a structure or take a structure as an argument. For example, stream input/output routines use a structure of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, which is defined in STDIO.H.|  
  
 The run-time library header files provide function declarations in the ANSI/ISO C standard recommended style. The compiler performs type checking on any routine reference that occurs after its associated function declaration. Function declarations are especially important for routines that return a value of some type other than <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, which is the default. Routines that do not specify their appropriate return value in their declaration will be considered by the compiler to return an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, which can cause unexpected results. See [Type Checking](../vs140/type-checking--crt-.md) for more information.  
  
## See Also  
 [CRT Library Features](../vs140/crt-library-features.md)