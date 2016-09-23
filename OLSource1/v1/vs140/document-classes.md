---
title: "Document Classes"
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
  - vc.classes.document
dev_langs: 
  - C++
helpviewer_keywords: 
  - document classes
ms.assetid: 4bf19b02-0a4f-4319-b68e-cddcba2705cb
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Document Classes
Document class objects, created by document-template objects, manage the application's data. You will derive a class for your documents from one of these classes.  
  
 Document class objects interact with view objects. View objects represent the client area of a window, display a document's data, and allow users to interact with it. Documents and views are created by a document-template object.  
  
 [CDocument](../vs140/cdocument-class.md)  
 The base class for application-specific documents. Derive your document class or classes from **CDocument**.  
  
 [COleDocument](../vs140/coledocument-class.md)  
 Used for compound document implementation, as well as basic container support. Serves as a container for classes derived from [CDocItem](../vs140/cdocitem-class.md). This class can be used as the base class for container documents and is the base class for `COleServerDoc`.  
  
 [COleLinkingDoc](../vs140/colelinkingdoc-class.md)  
 A class derived from `COleDocument` that provides the infrastructure for linking. You should derive the document classes for your container applications from this class instead of from `COleDocument` if you want them to support links to embedded objects.  
  
 [CRichEditDoc](../vs140/cricheditdoc-class.md)  
 Maintains the list of OLE client items that are in the rich edit control. Used with [CRichEditView](../vs140/cricheditview-class.md) and [CRichEditCntrItem](../vs140/cricheditcntritem-class.md).  
  
 [COleServerDoc](../vs140/coleserverdoc-class.md)  
 Used as the base class for server-application document classes. `COleServerDoc` objects provide the bulk of server support through interactions with [COleServerItem](../vs140/coleserveritem-class.md) objects. Visual editing capability is provided using the class library's document/view architecture.  
  
 [CHtmlEditDoc](../vs140/chtmleditdoc-class.md)  
 Provides, with [CHtmlEditView](../vs140/chtmleditview-class.md), the functionality of the WebBrowser HTML editing platform within the context of the MFC document-view architecture.  
  
## Related Classes  
 Document class objects can be persistent — in other words, they can write their state to a storage medium and read it back. MFC provides the `CArchive` class to facilitate transferring the document's data to a storage medium.  
  
 [CArchive](../vs140/carchive-class.md)  
 Cooperates with a [CFile](../vs140/cfile-class.md) object to implement persistent storage for objects through serialization (see [CObject::Serialize](../vs140/cobject--serialize.md)).  
  
 Documents can also contain OLE objects. `CDocItem` is the base class of the server and client items.  
  
 [CDocItem](../vs140/cdocitem-class.md)  
 Abstract base class of [COleClientItem](../vs140/coleclientitem-class.md) and [COleServerItem](../vs140/coleserveritem-class.md). Objects of classes derived from `CDocItem` represent parts of documents.  
  
## See Also  
 [Class Overview](../vs140/class-library-overview.md)