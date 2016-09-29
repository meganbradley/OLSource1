---
title: "Naming Conventions for MFC DLLs"
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
  - "MFC libraries [C++], naming conventions"
  - "naming conventions [C++], MFC DLLs"
  - "MFC DLLs [C++], naming conventions"
  - "libraries [C++], MFC DLL names"
  - "shared DLL versions [C++]"
  - "DLLs [C++], naming conventions"
  - "DLLs [C++], library names"
ms.assetid: 0db9c3f3-87d3-40e8-8964-250f9d2a2209
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Naming Conventions for MFC DLLs
The DLLs and libraries included in MFC follow a structured naming convention. This makes it easier to know which DLL or library you should be using for which purpose.  
  
 The import libraries needed to build applications or extension DLLs that use these DLLs have the same base name as the DLL but have a .lib file name extension.  
  
### Shared DLL Naming Convention  
  
|DLL|Description|  
|---------|-----------------|  
|MFCx0.DLL|MFC DLL, ANSI Release version|  
|MFCx0U.DLL|MFC DLL, Unicode Release version|  
|MFCx0D.DLL|MFC DLL, ANSI Debug version|  
|MFCx0UD.DLL|MFC DLL, Unicode Debug version|  
  
 If you are dynamically linking to the shared DLL version of MFC, whether it is from an application or from an extension DLL, you must include MFCx0.DLL with your product. If you require Unicode support in your application, include MFCx0U.DLL instead.  
  
 If you are statically linking your DLL to MFC, you must link it with one of the static MFC libraries. These versions are named according to the convention [N&#124;U]AFXCW[D].LIB. For more information, see the table "Static-Link Library Naming Conventions" in [Library Naming Conventions](../vs140/library-naming-conventions.md) (MFC).  
  
 For a list of Visual C++ DLLs that can be distributed with your applications, see Redist.txt in your Visual Studio installation.  
  
## What do you want to know more about?  
  
-   [The naming convention for libraries](../vs140/library-naming-conventions.md)  
  
## See Also  
 [DLLs in Visual C++](../vs140/dlls-in-visual-c--.md)