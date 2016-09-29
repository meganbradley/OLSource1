---
title: "Release Builds"
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
  - "debugging [C++], release builds"
  - "release builds"
  - "debug builds, converting to release build"
ms.assetid: fa9a78fa-f4b5-4722-baf4-aec655c4ff0f
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Release Builds
A release build uses optimizations. When you use optimizations to create a release build, the compiler will not produce symbolic debugging information. The absence of symbolic debugging information, along with the fact that code is not generated for TRACE and ASSERT calls, means that the size of your executable file is reduced and will therefore be faster.  
  
 This section presents information on why and when you would want to change from a debug build to a release build. It also discusses some of the problems you may encounter when changing from a debug to a release build:  
  
-   [Creating a Release Build](../VS_csharp/how-to--create-a-release-build.md)  
  
-   [Common Problems When Creating a Release Build](../VS_csharp/common-problems-when-creating-a-release-build.md)  
  
-   [Fixing Release Build Problems](../VS_csharp/fixing-release-build-problems.md)  
  
    -   [Examining ASSERT Statements](../VS_csharp/using-verify-instead-of-assert.md)  
  
    -   [Using the Debug Build To Check for Memory Overwrite](../VS_csharp/using-the-debug-build-to-check-for-memory-overwrite.md)  
  
    -   [Debugging a Release Build](../VS_csharp/how-to--debug-a-release-build.md)  
  
    -   [Checking for Memory Overwrites](../VS_csharp/checking-for-memory-overwrites.md)  
  
## See Also  
 [Building C++ Projects in Visual Studio](../VS_csharp/building-c---projects-in-visual-studio.md)   
 [C/C++ Building Reference](../VS_csharp/c-c---building-reference.md)