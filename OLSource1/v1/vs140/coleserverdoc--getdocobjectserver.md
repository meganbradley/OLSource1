---
title: "COleServerDoc::GetDocObjectServer"
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
  - "GetDocObjectServer"
  - "COleServerDoc.GetDocObjectServer"
  - "COleServerDoc::GetDocObjectServer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDocObjectServer method"
  - "COleServerDoc class, overridables"
ms.assetid: 388ad289-91f3-4651-a7b2-5015a0ce6e8f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerDoc::GetDocObjectServer
Override this function to create a new <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> item and return a pointer to it.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> interface that will connect this document to the server.  
  
## Return Value  
 A pointer to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; **NULL** if the operation failed.  
  
## Remarks  
 When a DocObject server is activated, the return of a non-**NULL** pointer shows that the client can support DocObjects. The default implementation returns **NULL**.  
  
 A typical implementation for a document that supports DocObjects will simply allocate a new <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object and return it to the caller. For example:  
  
 [!code[NVC_MFCOleServer#3](../vs140/codesnippet/CPP/coleserverdoc--getdocobjectserver_1.cpp)]  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerDoc Class](../vs140/coleserverdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocObjectServer::CDocObjectServer](../vs140/cdocobjectserver--cdocobjectserver.md)