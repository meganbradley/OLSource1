---
title: "Extension DLLs: Overview"
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
  - "AFXDLL library"
  - "MFC DLLs [C++], extension DLLs"
  - "DLLs [C++], extension"
  - "shared DLL versions [C++]"
  - "extension DLLs [C++], about extension DLLs"
ms.assetid: eb5e10b7-d615-4bc7-908d-e3e99b7b1d5f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Extension DLLs: Overview
An MFC extension DLL is a DLL that typically implements reusable classes derived from existing Microsoft Foundation Class Library classes. Extension DLLs are built using the dynamic-link library version of MFC (also known as the shared version of MFC). Only MFC executables (either applications or regular DLLs) that are built with the shared version of MFC can use an extension DLL. With an extension DLL, you can derive new custom classes from MFC and then offer this extended version of MFC to applications that call your DLL.  
  
 Extension DLLs can also be used for passing MFC-derived objects between the application and the DLL. The member functions associated with the passed object exist in the module where the object was created. Because these functions are properly exported when using the shared DLL version of MFC, you can freely pass MFC or MFC-derived object pointers between an application and the extension DLLs it loads.  
  
 For an example of a DLL that fulfills the basic requirements of an extension DLL, see the MFC sample [DLLHUSK](assetId:///dfcaa6ff-b8e2-4efd-8100-ee3650071f90). In particular, look at the Testdll1.cpp and Testdll2.cpp files.  
  
 Note that the term AFXDLL is no longer used in the Visual C++ documentation. An extension DLL has the same characteristics as the former AFXDLL.  
  
## What do you want to do?  
  
-   [Initialize an extension DLL](../VS_csharp/initializing-extension-dlls.md)  
  
## What do you want to know more about?  
  
-   [Extension DLLs](../VS_csharp/extension-dlls.md)  
  
-   [Using Database, OLE, and Sockets Extension DLLs in Regular DLLs](../VS_csharp/using-database--ole--and-sockets-extension-dlls-in-regular-dlls.md)  
  
-   [Non-MFC DLLs: Overview](../VS_csharp/non-mfc-dlls--overview.md)  
  
-   [Regular DLLs statically linked to MFC](../VS_csharp/regular-dlls-statically-linked-to-mfc.md)  
  
-   [Regular DLLs dynamically linked to MFC](../VS_csharp/regular-dlls-dynamically-linked-to-mfc.md)  
  
-   [Creating an MFC DLL](../VS_csharp/mfc-dll-wizard.md)  
  
## See Also  
 [Kinds of DLLs](../VS_csharp/kinds-of-dlls.md)