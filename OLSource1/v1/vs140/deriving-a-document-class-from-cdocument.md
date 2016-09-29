---
title: "Deriving a Document Class from CDocument"
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
  - "CDocument class, deriving from"
  - "classes [C++], deriving from CDocument"
  - "document objects, derived"
  - "derived classes, functions often overridden"
  - "document classes, functions often overridden"
ms.assetid: e6a198e0-9799-43c0-83c5-04174d8b532c
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Deriving a Document Class from CDocument
Documents contain and manage your application's data. To use the MFC Application Wizard-supplied document class, you must do the following:  
  
-   Derive a class from **CDocument** for each type of document.  
  
-   Add member variables to store each document's data.  
  
-   Override **CDocument**'s `Serialize` member function in your document class. `Serialize` writes and reads the document's data to and from disk.  
  
## Other Document Functions Often Overridden  
 You may also want to override other **CDocument** member functions. In particular, you will often need to override [OnNewDocument](../vs140/cdocument--onnewdocument.md) and [OnOpenDocument](../vs140/cdocument--onopendocument.md) to initialize the document's data members and [DeleteContents](../vs140/cdocument--deletecontents.md) to destroy dynamically allocated data. For information about overridable members, see class [CDocument](../vs140/cdocument-class.md) in the *MFC Reference*.  
  
## See Also  
 [Using Documents](../vs140/using-documents.md)