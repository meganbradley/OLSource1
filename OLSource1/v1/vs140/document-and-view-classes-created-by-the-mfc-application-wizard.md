---
title: "Document and View Classes Created by the MFC Application Wizard"
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
  - "document classes"
  - "document classes, created by application wizards"
  - "application wizards [C++], document/view classes created"
  - "view classes, created by application wizards"
ms.assetid: 70c34a60-2701-4981-acea-c08a5787d8e6
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Document and View Classes Created by the MFC Application Wizard
The MFC Application Wizard gives you a head start on your program development by creating skeletal document and view classes for you. You can then [map commands and messages to these classes](../vs140/mapping-messages-to-functions.md) and use the Visual C++ source code editor to write their member functions.  
  
 The document class created by the MFC Application Wizard is derived from class [CDocument](../vs140/cdocument-class.md). The view class is derived from [CView](../vs140/cview-class.md). The names that the Application Wizard gives these classes and the files that contain them are based on the project name you supply in the Application Wizard dialog box. In the Application Wizard, you can use the Generated Classes page to alter the default names.  
  
 Some applications might need more than one document class, view class, or frame-window class. For more information, see [Multiple Document Types, Views, and Frame Windows](../vs140/multiple-document-types--views--and-frame-windows.md).  
  
## See Also  
 [Document/View Architecture](../vs140/document-view-architecture.md)