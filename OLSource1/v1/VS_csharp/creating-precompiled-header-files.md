---
title: "Creating Precompiled Header Files"
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
helpviewer_keywords: 
  - "precompiled header files, creating"
  - "PCH files, creating"
  - "cl.exe compiler, precompiling code"
  - ".pch files, creating"
ms.assetid: e2cdb404-a517-4189-9771-c869c660cb1b
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Creating Precompiled Header Files
The Microsoft C and C++ compilers provide options for precompiling any C or C++ code, including inline code. Using this performance feature, you can compile a stable body of code, store the compiled state of the code in a file, and, during subsequent compilations, combine the precompiled code with code that is still under development. Each subsequent compilation is faster because the stable code does not need to be recompiled.  
  
 This section covers the following precompiled header issues:  
  
-   [When to Precompile Source Code](../VS_csharp/when-to-precompile-source-code.md)  
  
-   [Two Choices for Precompiling Code](../VS_csharp/two-choices-for-precompiling-code.md)  
  
-   [Precompiled Header Consistency Rules](../VS_csharp/precompiled-header-consistency-rules.md)  
  
-   [Using Precompiled Headers in a Project](../VS_csharp/using-precompiled-headers-in-a-project.md)  
  
 For reference information on the compiler options related to precompiled headers, see [/Y (Precompiled Headers)](../VS_csharp/-y--precompiled-headers-.md).  
  
## See Also  
 [C/C++ Building Reference](../VS_csharp/c-c---building-reference.md)   
 [Compiler Options](../VS_csharp/compiler-options.md)