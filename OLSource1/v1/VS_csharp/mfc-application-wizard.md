---
title: "MFC Application Wizard"
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
  - "vc.appwiz.mfc.exe.overview"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MFC Application Wizard"
  - "executable files, creating"
ms.assetid: 227ac090-921d-4b2f-be0a-66a5f4cab0d4
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MFC Application Wizard
The MFC Application Wizard generates an application that, when compiled, implements the basic features of a Windows executable (.exe) application. The MFC starter application includes C++ source (.cpp) files, resource (.rc) files, header (.h) files, and a project (.vcxproj) file. The code that is generated in these starter files is based on MFC.  
  
> [!NOTE]
>  Depending on the options that you select, the wizard creates additional files in your project. For example, if you select **Context-sensitive help** on the [Advanced Features](../VS_csharp/advanced-features--mfc-application-wizard.md) page, the wizard creates the files that are necessary to compile the project's Help files. For more information about the files that the wizard creates, see [File Types Created for Visual C++ Projects](../VS_csharp/file-types-created-for-visual-c---projects.md), and see the Readme.txt file in the project.  
  
## Overview  
 This wizard page describes the current application settings for the MFC application that you are creating. By default, the wizard creates a project as follows:  
  
-   [Application Type, MFC Application Wizard](../VS_csharp/application-type--mfc-application-wizard.md)  
  
    -   The project is created with tabbed multiple-document interface (MDI) support. For more information, see [SDI and MDI](../VS_csharp/sdi-and-mdi.md).  
  
    -   The project uses the [Document/View Architecture](../VS_csharp/document-view-architecture.md).  
  
    -   The project uses Unicode libraries.  
  
    -   The project is created using the Visual Studio project style and enables visual style switching.  
  
    -   The project uses MFC in a shared DLL. For more information, see [DLLs](../VS_csharp/dlls-in-visual-c--.md).  
  
-   [Compound Document Support, MFC Application Wizard](../VS_csharp/compound-document-support--mfc-application-wizard.md)  
  
    -   The project provides no support for compound documents.  
  
-   [Document Template Strings, MFC Application Wizard](../VS_csharp/document-template-strings--mfc-application-wizard.md)  
  
    -   The project uses the project name for the default document template strings.  
  
-   [Database Support, MFC Application Wizard](../VS_csharp/database-support--mfc-application-wizard.md)  
  
    -   The project provides no support for databases.  
  
-   [User Interface Features, MFC Application Wizard](../VS_csharp/user-interface-features--mfc-application-wizard.md)  
  
    -   The project implements standard Windows user interface features such as a system menu, a status bar, maximize and minimize boxes, an **About** box, a standard menu bar and docking toolbar, and child frames.  
  
-   [Advanced Features, MFC Application Wizard](../VS_csharp/advanced-features--mfc-application-wizard.md)  
  
    -   The project supports printing and print preview.  
  
    -   The project supports ActiveX controls. For more information, see [Sequence of Operations for Creating ActiveX Controls](../VS_csharp/sequence-of-operations-for-creating-activex-controls.md).  
  
    -   The project provides no support for [Automation](../VS_csharp/automation.md), [MAPI](../VS_csharp/mapi-support-in-mfc.md), [Windows Sockets](../VS_csharp/windows-sockets-in-mfc.md), or Active Accessibility.  
  
    -   The project supports an **Explorer** docking pane, an **Ouput** docking pane, and a **Properties** docking pane.  
  
-   [Generated Classes, MFC Application Wizard](../VS_csharp/generated-classes--mfc-application-wizard.md)  
  
    -   The project's view class is derived from the [CView Class](../VS_csharp/cview-class.md).  
  
    -   The project's application class is derived from the [CWinAppEx Class](../VS_csharp/cwinappex-class.md).  
  
    -   The project's document class is derived from the [CDocument Class](../VS_csharp/cdocument-class.md).  
  
    -   The project's main frame class is derived from the [CMDIFrameWndEx Class](../VS_csharp/cmdiframewndex-class.md).  
  
    -   The project's child frame class is derived from the [CMDIChildWndEx Class](../VS_csharp/cmdichildwndex-class.md).  
  
 To change these default settings, click the appropriate tab title in the left column of the wizard and make the changes on the page that appears.  
  
 After you create an MFC application project, you can add objects or controls to your project using Visual C++ [code wizards](../VS_csharp/adding-functionality-with-code-wizards--c---.md).  
  
## See Also  
 [Creating an MFC Application](../VS_csharp/creating-an-mfc-application.md)   
 [MFC Reference](../VS_csharp/mfc-desktop-applications.md)   
 [Using the Classes to Write Applications for Windows](../VS_csharp/using-the-classes-to-write-applications-for-windows.md)