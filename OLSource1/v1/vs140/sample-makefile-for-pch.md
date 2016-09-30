---
title: "Sample Makefile for PCH"
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
  - "pch"
dev_langs: 
  - "C++"
ms.assetid: daf68983-77dc-45db-8701-aa89ad18910d
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Sample Makefile for PCH
The following makefile uses macros and an !IF, !ELSE, !ENDIF flow-of-control command structure to simplify its adaptation to your project.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Aside from the STABLEHDRS, BOUNDRY, and UNSTABLEHDRS macros shown in the figure "Structure of a Makefile That Uses a Precompiled Header File" in [PCH Files in the Build Process](../vs140/pch-files-in-the-build-process.md), this makefile provides a CLFLAGS macro and a LINKFLAGS macro. You must use these macros to list compiler and linker options that apply whether you build a debug or final version of the application's executable file. There is also a LIBS macro where you list the libraries your project requires.  
  
 The makefile also uses !IF, !ELSE, !ENDIF to detect whether you define a DEBUG symbol on the NMAKE command line:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This feature makes it possible for you to use the same makefile during development and for the final versions of your program — use DEBUG=0 for the final versions. The following command lines are equivalent:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 For more information on makefiles, see [NMAKE Reference](../vs140/nmake-reference.md). Also see [Compiler Options](../vs140/compiler-options.md) and the [Linker Options](../vs140/linker-options.md).  
  
## See Also  
 [Using Precompiled Headers in a Project](../vs140/using-precompiled-headers-in-a-project.md)