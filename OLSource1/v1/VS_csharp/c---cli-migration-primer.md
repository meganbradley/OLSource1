---
title: "C++-CLI Migration Primer"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "C++/CLI Migration Primer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C++/CLI Version 2"
  - "upgrading Visual C++ applications, Managed Extensions for C++ to Visual C++ 2005 syntax"
  - "migration [C++], C++/CLI Version 2"
  - "Managed Extensions for C++, upgrading syntax"
  - "C++/CLI Version 2, managed extensions"
ms.assetid: 8ec926b5-73f6-4f0c-bcdf-5203d293849a
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# C++-CLI Migration Primer
This is a guide to moving your Visual C++ programs from Managed Extensions for C++ to [!INCLUDE[cpp_current_long](../VS_csharp/includes/cpp_current_long_md.md)]. For a checklist summary of syntactic changes, see [(NOTINBUILD)Managed Extensions for C++ Syntax Upgrade Checklist](assetId:///edbded88-7ef3-4757-bd9d-b8f48ac2aada).  
  
 C++/CLI extends a dynamic component programming paradigm to the ISO-C++ standard language. The new language offers a number of significant improvements over Managed Extensions. This section provides an enumerated listing of the Managed Extensions for C++ language features and their mapping to [!INCLUDE[cpp_current_long](../VS_csharp/includes/cpp_current_long_md.md)] where such a mapping exists, and points out those constructs for which no mapping exists.  
  
## In This Section  
 [Outline of Changes](../VS_csharp/outline-of-changes--c---cli-.md)  
 A high-level outline for quick reference, providing a listing of the changes under five general categories.  
  
 [Language Keywords](../VS_csharp/language-keywords--c---cli-.md)  
 Discusses changes in language keywords, including the removal of the double underscore and the introduction of both contextual and spaced keywords.  
  
 [The Managed Types](../VS_csharp/managed-types--c---cl-.md)  
 Looks at syntactic changes in the declaration of the Common Type System (CTS) – this includes changes in the declaration of classes, arrays (including the parameter array), enums, and so on.  
  
 [Member Declarations within a Class or Interface](../VS_csharp/member-declarations-within-a-class-or-interface--c---cli-.md)  
 Presents the changes involving class members such as scalar properties, index properties, operators, delegates, and events.  
  
 [Value Types and Their Behaviors](../VS_csharp/value-types-and-their-behaviors--c---cli-.md)  
 Focuses on value types and the new family of interior and pinning pointers. It also discusses a number of significant semantics changes such as the introduction of implicit boxing, immutability of boxed value types, and the removal of support for default constructors within value classes.  
  
 [General Language Changes](../VS_csharp/general-language-changes--c---cli-.md)  
 Details semantic changes such as support for cast notation, string literal behavior, and changes in the semantics between ISO-C++ and C++/CLI.  
  
## See Also  
 [Mixed Assemblies](../VS_csharp/mixed--native-and-managed--assemblies.md)   
 [New C++ Language Features](../VS_csharp/component-extensions-for-runtime-platforms.md)