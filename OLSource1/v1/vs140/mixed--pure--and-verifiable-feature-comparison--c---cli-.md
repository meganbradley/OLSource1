---
title: "Mixed, Pure, and Verifiable Feature Comparison (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Mixed, Pure, and Verifiable Feature Comparison (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "safe assemblies [C++], vs. pure"
  - "mixed assemblies [C++], vs. pure"
  - "safe assemblies [C++], vs. mixed"
  - "pure MSIL [C++]"
  - "verifiable assemblies [C++]"
  - "pure MSIL [C++], vs. safe"
  - "pure MSIL [C++], vs. mixed"
  - "pure MSIL [C++], compared to mixed and safe"
  - "verifiable assemblies [C++], vs. mixed"
  - "mixed assemblies [C++], vs. safe"
  - "verifiable assemblies [C++], vs. pure"
  - "pure assemblies [C++]"
  - "safe assemblies [C++]"
  - "mixed assemblies [C++]"
ms.assetid: 3f7a82ba-0e69-4927-ba0c-fbc3160e4394
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Mixed, Pure, and Verifiable Feature Comparison (C++-CLI)
This topic compares features among the different **/clr** compilation modes. For more information, see [/clr (Common Language Runtime Compilation)](../vs140/-clr--common-language-runtime-compilation-.md).  
  
## Feature Comparison  
  
|Feature|Mixed (/clr)|Pure (/clr:pure)|Safe (/clr:safe)|Related Information|  
|-------------|---------------------|-------------------------|-------------------------|-------------------------|  
|CRT library|supported|supported||[Run-Time Routines by Category](../vs140/run-time-routines-by-category.md)|  
|MFC/ATL|supported|||[MFC Reference](../vs140/mfc-desktop-applications.md) &#124; [ATL Class Overview](../vs140/atl-class-overview.md)|  
|Unmanaged Functions|supported|||[Mixed Assemblies](../vs140/mixed--native-and-managed--assemblies.md)|  
|Unmanaged Data|supported|supported||[Pure and Verifiable Code](../vs140/pure-and-verifiable-code--c---cli-.md)|  
|Callable from Unmanaged Functions|supported|||[Migrating to /clr:pure](../vs140/how-to--migrate-to--clr-pure--c---cli-.md)|  
|Supports calling unmanaged Functions|supported|C-style functions only|P/Invoke only|[Using C++ Interop Features](../vs140/using-c---interop--implicit-pinvoke-.md)|  
|Supports Reflection|DLLs only|supported|supported|[Reflection in C++](../vs140/reflection--c---cli-.md)|  
  
## See Also  
 [Pure and Verifiable Code](../vs140/pure-and-verifiable-code--c---cli-.md)