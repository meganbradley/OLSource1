---
title: "COleServerDoc::NotifySaved"
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
  - "NotifySaved"
  - "COleServerDoc.NotifySaved"
  - "COleServerDoc::NotifySaved"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleServerDoc class, operations"
  - "NotifySaved method"
ms.assetid: 3a591331-c22d-4f1f-b284-8e4ad61e9c16
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerDoc::NotifySaved
Call this function after the user saves the server document.  
  
## Syntax  
  
```  
  
void NotifySaved( );  
```  
  
## Remarks  
 When the user chooses the Save command from the File menu, `NotifySaved` is called for you by `COleServerDoc`'s implementation of [OnSaveDocument](../vs140/cdocument--onsavedocument.md). This function notifies the OLE system DLLs, which in turn notify the containers. In container applications written with the Microsoft Foundation Class Library, the [OnChange](../vs140/coleclientitem--onchange.md) member function of `COleClientItem` is called.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerDoc Class](../vs140/coleserverdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerDoc::NotifyChanged](../vs140/coleserverdoc--notifychanged.md)   
 [COleServerDoc::NotifyClosed](../vs140/coleserverdoc--notifyclosed.md)   
 [COleClientItem::OnChange](../vs140/coleclientitem--onchange.md)   
 [CDocument::OnSaveDocument](../vs140/cdocument--onsavedocument.md)