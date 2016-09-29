---
title: "Using Documents"
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
  - "documents [C++], C++ applications"
  - "data [MFC], reading"
  - "documents [C++]"
  - "files [C++], writing to"
  - "data [MFC], documents"
  - "files [C++]"
  - "views [C++], C++ applications"
  - "document/view architecture [C++], documents"
  - "reading data [C++], documents and views"
  - "printing [MFC], documents"
  - "writing to files [C++]"
ms.assetid: f390d6d8-d0e1-4497-9b6a-435f7ce0776c
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using Documents
Working together, documents and views:  
  
-   Contain, manage, and display your application-specific [data](../vs140/managing-data-with-document-data-variables.md).  
  
-   Provide an interface consisting of [document data variables](../vs140/managing-data-with-document-data-variables.md) for manipulating the data.  
  
-   Participate in [writing and reading files](../vs140/serializing-data-to-and-from-files.md).  
  
-   Participate in [printing](../vs140/role-of-the-view-in-printing.md).  
  
-   [Handle](../vs140/handling-commands-in-the-document.md) most of your application's commands and messages.  
  
 The document is particularly involved in managing data. Store your data, normally, in document class member variables. The view uses these variables to access the data for display and update. The document's default serialization mechanism manages reading and writing the data to and from files. Documents can also handle commands (but not Windows messages other than **WM_COMMAND**).  
  
## What do you want to know more about?  
  
-   [Deriving a document class from CDocument](../vs140/deriving-a-document-class-from-cdocument.md)  
  
-   [Managing data with document data variables](../vs140/managing-data-with-document-data-variables.md)  
  
-   [Serializing data to and from files](../vs140/serializing-data-to-and-from-files.md)  
  
-   [Bypassing the serialization mechanism](../vs140/bypassing-the-serialization-mechanism.md)  
  
-   [Handling commands in the document](../vs140/handling-commands-in-the-document.md)  
  
-   [The OnNewDocument member function](../vs140/cdocument--onnewdocument.md)  
  
-   [The DeleteContents member function](../vs140/cdocument--deletecontents.md)  
  
## See Also  
 [Document/View Architecture](../vs140/document-view-architecture.md)