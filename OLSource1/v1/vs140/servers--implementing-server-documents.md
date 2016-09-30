---
title: "Servers: Implementing Server Documents"
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
  - "OLE server applications, managing server documents"
  - "OLE server applications, implementing OLE servers"
  - "servers, server documents"
  - "server documents, implementing"
ms.assetid: cca1451a-ad09-47ed-b56e-bccd78fc86d1
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Servers: Implementing Server Documents
This article explains the steps you must take to successfully implement a server document if you did not specify the OLE Server option in the application wizard.  
  
#### To define a server document class  
  
1.  Derive your document class from <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> instead of **CDocument**.  
  
2.  Create a server item class derived from <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
3.  Implement the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> member function of your server document class.  
  
     <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is called when the user of a container application creates or edits an embedded item. It should return an item representing the entire document. This should be an object of your <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>-derived class.  
  
4.  Override the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> member function to serialize the contents of the document. You do not need to serialize the list of server items unless you are using them to represent the native data in your document. For more information, see *Implementing Server Items* in the article [Servers: Server Items](../vs140/servers--server-items.md).  
  
 When a server document is created, the framework automatically registers the document with the OLE system DLLs. This allows the DLLs to identify the server documents.  
  
 For more information, see [COleServerItem](../vs140/coleserveritem-class.md) and [COleServerDoc](../vs140/coleserverdoc-class.md) in the *Class Library Reference*.  
  
## See Also  
 [Servers](../vs140/servers.md)   
 [Servers: Server Items](../vs140/servers--server-items.md)   
 [Servers: Implementing a Server](../vs140/servers--implementing-a-server.md)   
 [Servers: Implementing In-Place Frame Windows](../vs140/servers--implementing-in-place-frame-windows.md)