---
title: "COleServerDoc::NotifyClosed"
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
  - "NotifyClosed"
  - "COleServerDoc::NotifyClosed"
  - "COleServerDoc.NotifyClosed"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleServerDoc class, operations"
  - "NotifyClosed method"
ms.assetid: 51063268-6f98-4ffa-89dc-27e8903234b2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerDoc::NotifyClosed
Call this function to notify the container(s) that the document has been closed.  
  
## Syntax  
  
```  
  
void NotifyClosed( );  
```  
  
## Remarks  
 When the user chooses the Close command from the File menu, `NotifyClosed` is called by `COleServerDoc`'s implementation of the [OnCloseDocument](../vs140/cdocument--onclosedocument.md) member function. In container applications written with the Microsoft Foundation Class Library, the [OnChange](../vs140/coleclientitem--onchange.md) member function of `COleClientItem` is called.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerDoc Class](../vs140/coleserverdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerDoc::NotifyChanged](../vs140/coleserverdoc--notifychanged.md)   
 [COleServerDoc::NotifySaved](../vs140/coleserverdoc--notifysaved.md)   
 [COleClientItem::OnChange](../vs140/coleclientitem--onchange.md)   
 [CDocument::OnCloseDocument](../vs140/cdocument--onclosedocument.md)