---
title: "Using the Classes to Write Applications for Windows"
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
  - "Windows applications [C++], MFC application framework"
  - "MFC [C++], application development"
  - "applications [OLE], MFC application framework"
  - "MFC ActiveX controls, creating"
  - "OLE applications [C++], MFC application framework"
  - "database applications [C++], creating"
ms.assetid: 73f63470-857d-43dd-9a54-b38b7be0f1b7
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using the Classes to Write Applications for Windows
Taken together, the classes in the Microsoft Foundation Class (MFC) Library make up an "application framework," on which you build an application for the Windows operating system. At a very general level, the framework defines the skeleton of an application and supplies standard user-interface implementations that can be placed onto the skeleton. Your job as programmer is to fill in the rest of the skeleton, which are those things that are specific to your application. You can get a head start by using the MFC Application Wizard to create the files for a very thorough starter application. You use the Microsoft Visual C++ resource editors to design your user-interface elements visually, Class View commands to connect those elements to code, and the class library to implement your application-specific logic.  
  
 Version 3.0 and later of the MFC framework supports programming for Win32 platforms, including Microsoft Windows 95 and later, and Windows NT versions 3.51 and later. MFC Win32 support includes multithreading. Use version 1.5*x* if you need to do 16-bit programming.  
  
 This family of articles presents a broad overview of the application framework. It also explores the major objects that make up your application and how they are created. Among the topics covered in these articles are the following:  
  
-   [The framework](../vs140/framework--mfc-.md).  
  
-   Division of labor between the framework and your code, as described in [Building on the Framework](../vs140/building-on-the-framework.md).  
  
-   [The application class](../vs140/cwinapp--the-application-class.md), which encapsulates application-level functionality.  
  
-   How [document templates](../vs140/document-templates-and-the-document-view-creation-process.md) create and manage documents and their associated views and frame windows.  
  
-   Class [CWnd](../vs140/window-objects.md), the root base class of all windows.  
  
-   [Graphic objects](../vs140/graphic-objects.md), such as pens and brushes.  
  
 Other parts of the framework include:  
  
-   [Window Objects: Overview](../vs140/window-objects.md)  
  
-   [Message handling and mapping](../vs140/message-handling-and-mapping.md)  
  
-   [CObject, The Root Base Class in MFC](../vs140/using-cobject.md)  
  
-   [Document/View Architecture](../vs140/document-view-architecture.md)  
  
-   [Dialog Boxes](../vs140/dialog-boxes.md)  
  
-   [Controls](../vs140/controls--mfc-.md)  
  
-   [Control Bars](../vs140/control-bars.md)  
  
-   [OLE](../vs140/ole-in-mfc.md)  
  
-   [Memory Management](../vs140/memory-management.md)  
  
     Besides giving you an advantage in writing applications for the Windows operating system, MFC also makes it much easier to write applications that specifically use OLE linking and embedding technology. You can make your application an OLE visual editing container, an OLE visual editing server, or both, and you can add Automation so that other applications can use objects from your application or even drive it remotely.  
  
-   [MFC ActiveX Controls](../vs140/mfc-activex-controls.md)  
  
     The OLE control development kit (CDK) is now fully integrated with the framework. This article family supplies an overview of ActiveX control development with MFC. (ActiveX controls were formerly known as OLE controls.)  
  
-   [Database Programming](../vs140/data-access-programming--mfc-atl-.md)  
  
     MFC also supplies two sets of database classes that simplify writing data-access applications. Using the ODBC database classes, you can connect to databases through an Open Database Connectivity (ODBC) driver, select records from tables, and display record information in an on-screen form. Using the Data Access Object (DAO) classes, you can work with databases through the Microsoft Jet database engine or external (non-Jet) data sources, including ODBC data sources.  
  
     In addition, MFC is fully enabled for writing applications that use Unicode and multibyte character sets (MBCS), specifically double-byte character sets (DBCS).  
  
 For a general guide to MFC documentation, see [General MFC Topics](../vs140/general-mfc-topics.md).  
  
## See Also  
 [General MFC Topics](../vs140/general-mfc-topics.md)