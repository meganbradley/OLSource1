---
title: "COleClientItem::OnChangeItemPosition"
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
  - COleClientItem::OnChangeItemPosition
  - OnChangeItemPosition
  - COleClientItem.OnChangeItemPosition
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnChangeItemPosition method
  - COleClientItem class, overridables
ms.assetid: b8101c64-3165-4488-833b-fee026d450be
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleClientItem::OnChangeItemPosition
Called by the framework to notify the container that the OLE item's extent has changed during in-place activation.  
  
## Syntax  
  
```  
  
      virtual BOOL OnChangeItemPosition(  
   const CRect& rectPos   
);  
```  
  
#### Parameters  
 *rectPos*  
 Indicates the item's position relative to the container application's client area.  
  
## Return Value  
 Nonzero if the item's position is successfully changed; otherwise 0.  
  
## Remarks  
 The default implementation determines the new visible rectangle of the OLE item and calls [SetItemRects](../vs140/coleclientitem--setitemrects.md) with the new values. The default implementation calculates the visible rectangle for the item and passes that information to the server.  
  
 Override this function to apply special rules to the resize/move operation. If the application is written in MFC, this call results because the server called [COleServerDoc::RequestPositionChange](../vs140/coleserverdoc--requestpositionchange.md).  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerDoc::RequestPositionChange](../vs140/coleserverdoc--requestpositionchange.md)