---
title: "MFC Application Architecture Classes"
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
  - "MFC [C++], classes"
  - "MFC [C++], application development"
  - "classes [C++], MFC"
  - "application architecture classes"
ms.assetid: 71b2de54-b44d-407e-9c71-9baf954e18d9
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MFC Application Architecture Classes
Classes in this category contribute to the architecture of a framework application. They supply functionality common to most applications. You fill in the framework to add application-specific functionality. Typically, you do so by deriving new classes from the architecture classes, and then adding new members or overriding existing member functions.  
  
 [Application wizards](../VS_csharp/mfc-application-wizard.md) generate several types of applications, all of which use the application framework in differing ways. SDI (single document interface) and MDI (multiple document interface) applications make full use of a part of the framework called document/view architecture. Other types of applications, such as dialog-based applications, form-based applications, and DLLs, use only some of document/view architecture features.  
  
 Document/view applications contain one or more sets of documents, views, and frame windows. A document-template object associates the classes for each document/view/frame set.  
  
 Although you do not have to use document/view architecture in your MFC application, there are a number of advantages to doing so. The MFC OLE container and server support is based on document/view architecture, as is support for printing and print preview.  
  
 All MFC applications have at least two objects: an application object derived from [CWinApp](../VS_csharp/cwinapp-class.md), and some sort of main window object, derived (often indirectly) from [CWnd](../VS_csharp/cwnd-class.md). (Most often, the main window is derived from [CFrameWnd](../VS_csharp/cframewnd-class.md), [CMDIFrameWnd](../VS_csharp/cmdiframewnd-class.md), or [CDialog](../VS_csharp/cdialog-class.md), all of which are derived from `CWnd`.)  
  
 Applications that use document/view architecture contain additional objects. The principal objects are:  
  
-   An application object derived from class [CWinApp](../VS_csharp/cwinapp-class.md), as mentioned before.  
  
-   One or more document class objects derived from class [CDocument](../VS_csharp/cdocument-class.md). Document class objects are responsible for the internal representation of the data manipulated in the view. They may be associated with a data file.  
  
-   One or more view objects derived from class [CView](../VS_csharp/cview-class.md). Each view is a window that is attached to a document and associated with a frame window. Views display and manipulate the data contained in a document class object.  
  
 Document/view applications also contain frame windows (derived from [CFrameWnd](../VS_csharp/cframewnd-class.md)) and document templates (derived from [CDocTemplate](../VS_csharp/cdoctemplate-class.md)).  
  
## See Also  
 [Class Overview](../VS_csharp/class-library-overview.md)