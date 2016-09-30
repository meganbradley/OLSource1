---
title: "OLE Server Classes"
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
  - "vc.classes.ole"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OLE server applications, server classes"
  - "OLE server documents"
  - "COM components, classes"
  - "component classes"
ms.assetid: 8e9b67a2-c0ff-479c-a8d6-19b36c5e6fc6
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# OLE Server Classes
These classes are used by server applications. Server documents are derived from <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> rather than from **CDocument**. Note that because <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is derived from <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, server documents can also be containers that support linking.  
  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class represents a document or portion of a document that can be embedded in another document or linked to.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> support in-place editing while the object is in a container, and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> supports creation of document/view pairs so OLE objects from other applications can be edited.  
  
 [COleServerDoc](../vs140/coleserverdoc-class.md)  
 Used as the base class for server-application document classes. <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> objects provide the bulk of server support through interactions with <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> objects. Visual editing capability is provided using the class library's document/view architecture.  
  
 [CDocItem](../vs140/cdocitem-class.md)  
 Abstract base class of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. Objects of classes derived from <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> represent parts of documents.  
  
 [COleServerItem](../vs140/coleserveritem-class.md)  
 Used to represent the OLE interface to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> items. There is usually one <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object, which represents the embedded part of a document. In servers that support links to parts of documents, there can be many <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> objects, each of which represents a link to a portion of the document.  
  
 [COleIPFrameWnd](../vs140/coleipframewnd-class.md)  
 Provides the frame window for a view when a server document is being edited in place.  
  
 [COleResizeBar](../vs140/coleresizebar-class.md)  
 Provides the standard user interface for in-place resizing. Objects of this class are always used in conjunction with <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> objects.  
  
 [COleTemplateServer](../vs140/coletemplateserver-class.md)  
 Used to create documents using the framework's document/view architecture. A <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object delegates most of its work to an associated <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.  
  
 [COleException](../vs140/coleexception-class.md)  
 An exception resulting from a failure in OLE processing. This class is used by both containers and servers.  
  
## See Also  
 [Class Overview](../vs140/class-library-overview.md)