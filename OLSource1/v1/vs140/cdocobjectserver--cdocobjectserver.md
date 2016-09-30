---
title: "CDocObjectServer::CDocObjectServer"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CDocObjectServer"
  - "CDocObjectServer::CDocObjectServer"
  - "CDocObjectServer.CDocObjectServer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDocObjectServer class, constructor"
ms.assetid: 51510e3e-4b4f-495a-a0f9-28fae3252874
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocObjectServer::CDocObjectServer
Constructs and initializes a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *pOwner*  
 A pointer to the client site document that is the client for the DocObject server.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> interface implemented by the container.  
  
## Remarks  
 When a DocObject is active, the client site OLE interface (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) is what allows the DocObject server to communicate with its client (the container). When a DocObject server is activated, it first checks that the container implements the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> interface. If so, [COleServerDoc::GetDocObjectServer](../vs140/coleserverdoc--getdocobjectserver.md) is called to see if the container supports DocObjects. By default, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returns **NULL**. You must override <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to construct a new <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object or a derived object of your own, with pointers to the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> container and its <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> interface as arguments to the constructor.  
  
## Requirements  
 **Header:** afxdocob.h  
  
## See Also  
 [CDocObjectServer Class](../vs140/cdocobjectserver-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocObjectServerItem Class](../vs140/cdocobjectserveritem-class.md)   
 [COleServerDoc::GetDocObjectServer](../vs140/coleserverdoc--getdocobjectserver.md)