---
title: "Details of ATL Support Added by the ATL Wizard"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vc.codewiz.atl.support
dev_langs: 
  - C++
helpviewer_keywords: 
  - MFC, ATL support
  - ATL, MFC projects
ms.assetid: aa66bad0-008f-4886-94c1-2a0a0d04bce4
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Details of ATL Support Added by the ATL Wizard
When you [add ATL support to an existing MFC executable or DLL](../vs140/adding-atl-support-to-your-mfc-project.md), Visual C++ makes the following modifications to the existing MFC project (in this example, the project is called `MFCEXE`):  
  
-   Two new files (an .idl file and an .rgs file, used to register the server) are added.  
  
-   In the main application header and implementation files (Mfcexe.h and Mfcexe.cpp), a new class (derived from **CAtlMFCModule**) is added. In addition to the new class, code is added to `InitInstance` for registration. Code is also added to the `ExitInstance` function for revoking the class object. In the header file, Finally, two new header files (Initguid.h and Mfcexe_i.c) are included in the implementation file, declaring and initializing the new GUIDs for the **CAtlMFCModule**-derived class.  
  
-   To register the server properly, an entry for the new .rgs file is added to the project's resource file.  
  
## Notes for DLL Projects  
 When you add ATL support to an MFC DLL project, you will see some differences. Code is added to the **DLLRegisterServer** and **DLLUnregisterServer** functions for registering and unregistering the DLL. Code is also added to [DllCanUnloadNow](../vs140/catldllmodulet--dllcanunloadnow.md) and [DllGetClassObject](../vs140/catldllmodulet--dllgetclassobject.md).  
  
## See Also  
 [ATL Support in an MFC Project](../vs140/adding-atl-support-to-your-mfc-project.md)   
 [Adding Functionality with Code Wizards](../vs140/adding-functionality-with-code-wizards--c---.md)   
 [Adding a Class](../vs140/adding-a-class--visual-c---.md)   
 [Adding a Member Function](../vs140/adding-a-member-function--visual-c---.md)   
 [Adding a Member Variable](../vs140/adding-a-member-variable---visual-c---.md)   
 [Overriding a Virtual Function](../vs140/overriding-a-virtual-function--visual-c---.md)   
 [MFC Message Handler](../vs140/adding-an-mfc-message-handler.md)   
 [Navigating the Class Structure](../vs140/navigating-the-class-structure--visual-c---.md)