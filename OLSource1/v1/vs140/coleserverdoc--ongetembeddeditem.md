---
title: "COleServerDoc::OnGetEmbeddedItem"
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
  - "OnGetEmbeddedItem"
  - "COleServerDoc::OnGetEmbeddedItem"
  - "COleServerDoc.OnGetEmbeddedItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleServerDoc class, overridables"
  - "OnGetEmbeddedItem method"
ms.assetid: 68418131-565b-4c39-b6e1-ef8759662865
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerDoc::OnGetEmbeddedItem
Called by the framework when a container application calls the server application to create or edit an embedded item.  
  
## Syntax  
  
```  
  
virtual COleServerItem* OnGetEmbeddedItem( ) = 0;  
```  
  
## Return Value  
 A pointer to an item representing the entire document; **NULL** if the operation failed.  
  
## Remarks  
 There is no default implementation. You must override this function to return an item that represents the entire document. This return value should be an object of a `COleServerItem`-derived class.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerDoc Class](../vs140/coleserverdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleLinkingDoc::OnGetLinkedItem](../vs140/colelinkingdoc--ongetlinkeditem.md)   
 [COleServerItem Class](../vs140/coleserveritem-class.md)