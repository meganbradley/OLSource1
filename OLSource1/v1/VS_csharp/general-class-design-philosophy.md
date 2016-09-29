---
title: "General Class Design Philosophy"
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
  - "vc.classes.mfc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "designing classes"
  - "MFC [C++], Windows API"
  - "Visual C, Windows API calls"
  - "classes [C++], MFC class design"
  - "Windows API [C++], and MFC"
ms.assetid: e6861ae0-1581-4d9c-9ddf-63f9afcdb913
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# General Class Design Philosophy
Microsoft Windows was designed long before the C++ language became popular. Because thousands of applications use the C-language Windows application programming interface (API), that interface will be maintained for the foreseeable future. Any C++ Windows interface must therefore be built on top of the procedural C-language API. This guarantees that C++ applications will be able to coexist with C applications.  
  
 The Microsoft Foundation Class Library is an object-oriented interface to Windows that meets the following design goals:  
  
-   Significant reduction in the effort to write an application for Windows.  
  
-   Execution speed comparable to that of the C-language API.  
  
-   Minimum code size overhead.  
  
-   Ability to call any Windows C function directly.  
  
-   Easier conversion of existing C applications to C++.  
  
-   Ability to leverage from the existing base of C-language Windows programming experience.  
  
-   Easier use of the Windows API with C++ than with C.  
  
-   Easier to use yet powerful abstractions of complicated features such as ActiveX controls, database support, printing, toolbars, and status bars.  
  
-   True Windows API for C++ that effectively uses C++ language features.  
  
 For more on the design of the MFC Library, see:  
  
-   [The Application Framework](../VS_csharp/application-framework.md)  
  
-   [Relationship to the C-Language API](../VS_csharp/relationship-to-the-c-language-api.md)  
  
## See Also  
 [Class Overview](../VS_csharp/class-library-overview.md)