---
title: "Document Classes"
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
  - "vc.classes.document"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "document classes"
ms.assetid: 4bf19b02-0a4f-4319-b68e-cddcba2705cb
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Document Classes
Document class objects, created by document-template objects, manage the application's data. You will derive a class for your documents from one of these classes.  
  
 Document class objects interact with view objects. View objects represent the client area of a window, display a document's data, and allow users to interact with it. Documents and views are created by a document-template object.  
  
 [CDocument](../VS_csharp/cdocument-class.md)  
 The base class for application-specific documents. Derive your document class or classes from **CDocument**.  
  
 [COleDocument](../VS_csharp/coledocument-class.md)  
 Used for compound document implementation, as well as basic container support. Serves as a container for classes derived from [CDocItem](../VS_csharp/cdocitem-class.md). This class can be used as the base class for container documents and is the base class for `COleServerDoc`.  
  
 [COleLinkingDoc](../VS_csharp/colelinkingdoc-class.md)  
 A class derived from `COleDocument` that provides the infrastructure for linking. You should derive the document classes for your container applications from this class instead of from `COleDocument` if you want them to support links to embedded objects.  
  
 [CRichEditDoc](../VS_csharp/cricheditdoc-class.md)  
 Maintains the list of OLE client items that are in the rich edit control. Used with [CRichEditView](../VS_csharp/cricheditview-class.md) and [CRichEditCntrItem](../VS_csharp/cricheditcntritem-class.md).  
  
 [COleServerDoc](../VS_csharp/coleserverdoc-class.md)  
 Used as the base class for server-application document classes. `COleServerDoc` objects provide the bulk of server support through interactions with [COleServerItem](../VS_csharp/coleserveritem-class.md) objects. Visual editing capability is provided using the class library's document/view architecture.  
  
 [CHtmlEditDoc](../VS_csharp/chtmleditdoc-class.md)  
 Provides, with [CHtmlEditView](../VS_csharp/chtmleditview-class.md), the functionality of the WebBrowser HTML editing platform within the context of the MFC document-view architecture.  
  
## Related Classes  
 Document class objects can be persistent — in other words, they can write their state to a storage medium and read it back. MFC provides the `CArchive` class to facilitate transferring the document's data to a storage medium.  
  
 [CArchive](../VS_csharp/carchive-class.md)  
 Cooperates with a [CFile](../VS_csharp/cfile-class.md) object to implement persistent storage for objects through serialization (see [CObject::Serialize](../Topic/CObject::Serialize.md)).  
  
 Documents can also contain OLE objects. `CDocItem` is the base class of the server and client items.  
  
 [CDocItem](../VS_csharp/cdocitem-class.md)  
 Abstract base class of [COleClientItem](../VS_csharp/coleclientitem-class.md) and [COleServerItem](../VS_csharp/coleserveritem-class.md). Objects of classes derived from `CDocItem` represent parts of documents.  
  
## See Also  
 [Class Overview](../VS_csharp/class-library-overview.md)