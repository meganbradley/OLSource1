---
title: "Active Document Servers"
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
  - "active documents [C++], servers"
  - "servers [C++], active document"
  - "active document servers [C++]"
ms.assetid: 131fec1e-02a0-4305-a7ab-903b911232a7
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Active Document Servers
Active document servers such as Word, Excel, or PowerPoint host documents of other application types called active documents. Unlike OLE embedded objects (which are simply displayed within the page of another document), Active documents provide the full interface and complete native functionality of the server application that creates them. Users can create documents using the full power of their favorite applications (if they are active document enabled), yet can treat the resulting project as a single entity.  
  
 Active documents can have more than one page and are always in-place active. Active documents control part of the user interface, merging their menus with the **File** and **Help** menus of the container. They occupy the entire editing area of the container and control the views and the layout of the printer page (margins, footers, and so on).  
  
 MFC implements active document servers with document/view interfaces, command dispatch maps, printing, menu management, and registry management. Specific programming requirements are discussed in [active documents](../VS_csharp/active-documents.md).  
  
 MFC supports active documents with the [CDocObjectServer](../VS_csharp/cdocobjectserver-class.md) class, derived from [CCmdTarget](../VS_csharp/ccmdtarget-class.md), and [CDocObjectServerItem](../VS_csharp/cdocobjectserveritem-class.md), derived from [COleServerItem](../VS_csharp/coleserveritem-class.md). MFC supports active document containers with the [COleDocObjectItem](../VS_csharp/coledocobjectitem-class.md) class, derived from [COleClientItem](../VS_csharp/coleclientitem-class.md).  
  
 `CDocObjectServer` maps the active document interfaces and initializes and activates an active document. MFC also provides macros to handle command routing in ACTIVE documents. To use active documents in your application, include AfxDocOb.h in your StdAfx.h file.  
  
 A regular MFC server hooks up its own `COleServerItem`-derived class. The MFC Application Wizard generates this class for you if you select the **Mini-server** or **Full-server** check box to give your application server compound document support. If you also select the **Active document server** check box, the MFC Application Wizard generates a class derived from `CDocObjectServerItem` instead.  
  
 The `COleDocObjectItem` class allows an OLE container to become an active document container. You can use the MFC Application Wizard to create an active document container by selecting the **Active document container** checkbox in the Compound Document Support page of the MFC Application Wizard. For more information, see [Creating an Active Document Container Application](../VS_csharp/creating-an-active-document-container-application.md).  
  
## See Also  
 [Active Document Containment](../VS_csharp/active-document-containment.md)