---
title: "Two Choices for Precompiling Code"
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
  - "PCH files"
  - "PCH files, precompiling options"
  - ".pch files"
  - "precompiled header files, precompiling options"
  - "compiling source code, precompiling"
  - "precompiled header files"
  - "code, precompiling"
  - "precompiling code"
  - ".pch files, precompiling options"
  - "automatic precompiling"
ms.assetid: f50ac76f-e2a2-462d-bda5-0e2ab7cccdeb
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Two Choices for Precompiling Code
With Visual C++, you can precompile any C or C++ code; you are not limited to precompiling only header files.  
  
 Precompiling requires planning, but it offers significantly faster compilations if you precompile source code other than simple header files.  
  
 Precompile code when you know that your source files use common sets of header files but don't include them in the same order, or when you want to include source code in your precompilation.  
  
 The precompiled-header options are [/Yc (Create Precompiled Header File)](../vs140/-yc--create-precompiled-header-file-.md) and [/Yu (Use Precompiled Header File)](../vs140/-yu--use-precompiled-header-file-.md). Use **/Yc** to create a precompiled header. When used with the optional <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> pragma, **/Yc** lets you precompile both header files and source code. Select **/Yu** to use an existing precompiled header in the existing compilation. You can also use **/Fp** with the **/Yc** and **/Yu** options to provide an alternative name for the precompiled header.  
  
 The compiler option reference topics for **/Yu** and **/Yc** discuss how to access this functionality in the development environment.  
  
## More Information  
  
-   [When to Precompile Source Code](../vs140/when-to-precompile-source-code.md)  
  
-   [Precompiled Header Consistency Rules](../vs140/precompiled-header-consistency-rules.md)  
  
-   [Using Precompiled Headers in a Project](../vs140/using-precompiled-headers-in-a-project.md)  
  
 For further examples using precompiled headers, see the makefiles used to build the sample programs that ship with the Microsoft Foundation Class Library.  
  
## See Also  
 [Creating Precompiled Header Files](../vs140/creating-precompiled-header-files.md)