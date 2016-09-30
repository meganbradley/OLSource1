---
title: "Document-View Creation"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Document/View Creation"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "documents, creating"
  - "views, and frame windows"
  - "views, creating"
  - "tables [C++]"
  - "MFC, views"
  - "document/view architecture, creating document/view"
  - "object creators"
  - "MFC, documents"
  - "tables [C++], objects each MFC object creates"
ms.assetid: bda14f41-ed50-439d-af9e-591174e7dd64
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Document-View Creation
The framework supplies implementations of the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and **Open** commands (among others) on the **File** menu. Creation of a new document and its associated view and frame window is a cooperative effort among the application object, a document template, the newly created document, and the newly created frame window. The following table summarizes which objects create what.  
  
### Object Creators  
  
|Creator|Creates|  
|-------------|-------------|  
|Application object|Document template|  
|Document template|Document|  
|Document template|Frame window|  
|Frame window|View|  
  
## See Also  
 [Document Templates and the Document/View Creation Process](../vs140/document-templates-and-the-document-view-creation-process.md)   
 [Document Template Creation](../vs140/document-template-creation.md)   
 [Relationships Among MFC Objects](../vs140/relationships-among-mfc-objects.md)   
 [Creating New Documents, Windows, and Views](../vs140/creating-new-documents--windows--and-views.md)