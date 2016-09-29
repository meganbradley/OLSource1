---
title: "Initializing Documents and Views"
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
  - "initializing documents"
  - "documents, initializing"
  - "views, initializing"
  - "initializing objects, document objects"
  - "initializing views"
ms.assetid: 33cb8643-8a16-478c-bc26-eccc734e3661
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Initializing Documents and Views
Documents are created in two different ways, so your document class must support both ways. First, the user can create a new, empty document with the File New command. In that case, initialize the document in your override of the [OnNewDocument](../vs140/cdocument--onnewdocument.md) member function of class [CDocument](../vs140/cdocument-class.md). Second, the user can use the Open command on the File menu to create a new document whose contents are read from a file. In that case, initialize the document in your override of the [OnOpenDocument](../vs140/cdocument--onopendocument.md) member function of class **CDocument**. If both initializations are the same, you can call a common member function from both overrides, or `OnOpenDocument` can call `OnNewDocument` to initialize a clean document and then finish the open operation.  
  
 Views are created after their documents are created. The best time to initialize a view is after the framework has finished creating the document, frame window, and view. You can initialize your view by overriding the [OnInitialUpdate](../vs140/cview--oninitialupdate.md) member function of [CView](../vs140/cview-class.md). If you need to reinitialize or adjust anything each time the document changes, you can override [OnUpdate](../vs140/cview--onupdate.md).  
  
## See Also  
 [Initializing and Cleaning Up Documents and Views](../vs140/initializing-and-cleaning-up-documents-and-views.md)