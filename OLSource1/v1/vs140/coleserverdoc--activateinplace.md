---
title: "COleServerDoc::ActivateInPlace"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - COleServerDoc::ActivateInPlace
  - ActivateInPlace
  - COleServerDoc.ActivateInPlace
dev_langs: 
  - C++
helpviewer_keywords: 
  - COleServerDoc class, operations
  - ActivateInPlace method
ms.assetid: 7b7a5524-64fd-46e7-b7fc-9ca2a5523572
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleServerDoc::ActivateInPlace
Activates the item for in-place editing.  
  
## Syntax  
  
```  
  
BOOL ActivateInPlace( );  
```  
  
## Return Value  
 Nonzero if successful; otherwise 0, which indicates that the item is fully open.  
  
## Remarks  
 This function performs all operations necessary for in-place activation. It creates an in-place frame window, activates it and sizes it to the item, sets up shared menus and other controls, scrolls the item into view, and sets the focus to the in-place frame window.  
  
 This function is called by the default implementation of [COleServerItem::OnShow](../vs140/coleserveritem--onshow.md). Call this function if your application supports another verb for in-place activation (such as Play).  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerDoc Class](../vs140/coleserverdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerItem::OnShow](../vs140/coleserveritem--onshow.md)