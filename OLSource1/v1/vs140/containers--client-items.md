---
title: "Containers: Client Items"
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
  - "OLE containers, client items"
  - "client items and OLE containers"
ms.assetid: 231528b5-0744-4f83-8897-083bf55ed087
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Containers: Client Items
This article explains what client items are and from what classes your application should derive its client items.  
  
 Client items are data items belonging to another application that are either contained in or referenced by an OLE container application's document. Client items whose data is contained within the document are embedded; those whose data is stored in another location referenced by the container document are linked.  
  
 The document class in an OLE application is derived from the class [COleDocument](../vs140/coledocument-class.md) rather than from **CDocument**. The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> class inherits from **CDocument** all the functionality necessary for using the document/view architecture on which MFC applications are based. <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> also defines an interface that treats a document as a collection of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> objects. Several <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member functions are provided for adding, retrieving, and deleting elements of that collection.  
  
 Every container application should derive at least one class from <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Objects of this class represent items, embedded or linked, in the OLE document. These objects exist for the life of the document containing them, unless they are deleted from the document.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is the base class for <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Objects of classes derived from these two act as intermediaries between the OLE item and the client and server applications, respectively. Each time a new OLE item is added to the document, the MFC framework adds a new object of your client application's <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>-derived class to the document's collection of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> objects.  
  
## See Also  
 [Containers](../vs140/containers.md)   
 [Containers: Compound Files](../vs140/containers--compound-files.md)   
 [Containers: User-Interface Issues](../vs140/containers--user-interface-issues.md)   
 [Containers: Advanced Features](../vs140/containers--advanced-features.md)   
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [COleServerItem Class](../vs140/coleserveritem-class.md)