---
title: "COleClientItem::OnChange"
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
  - "COleClientItem::OnChange"
  - "OLE_SAVED"
  - "OLE_CLOSED"
  - "COleClientItem.OnChange"
  - "OnChange"
  - "OLE_CHANGED_STATE"
  - "OLE_CHANGED"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OLE_SAVED"
  - "OLE_CLOSED"
  - "OnChange method"
  - "OLE_CHANGED"
  - "OLE_CHANGED_STATE"
ms.assetid: 27e57113-1d31-4ab9-bffd-ca3ceea6c3d2
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::OnChange
Called by the framework when the user modifies, saves, or closes the OLE item.  
  
## Syntax  
  
```  
  
      virtual void OnChange(  
   OLE_NOTIFICATION nCode,  
   DWORD dwParam   
);  
```  
  
#### Parameters  
 `nCode`  
 The reason the server changed this item. It can have one of the following values:  
  
-   `OLE_CHANGED` The OLE item's appearance has changed.  
  
-   `OLE_SAVED` The OLE item has been saved.  
  
-   `OLE_CLOSED` The OLE item has been closed.  
  
-   `OLE_CHANGED_STATE` The OLE item has changed from one state to another.  
  
 `dwParam`  
 If `nCode` is `OLE_SAVED` or `OLE_CLOSED`, this parameter is not used. If `nCode` is `OLE_CHANGED`, this parameter specifies the aspect of the OLE item that has changed. For possible values, see the `dwParam` parameter of [COleClientItem::Draw](../vs140/coleclientitem--draw.md). If `nCode` is `OLE_CHANGED_STATE`, this parameter is a **COleClientItem::ItemState** enumerated value and describes the state being entered. It can have one of the following values: `emptyState`, **loadedState**, `openState`, `activeState`, or `activeUIState`.  
  
## Remarks  
 (If the server application is written using the Microsoft Foundation Class Library, this function is called in response to the `Notify` member functions of `COleServerDoc` or `COleServerItem`.) The default implementation marks the container document as modified if `nCode` is `OLE_CHANGED` or `OLE_SAVED`.  
  
 For `OLE_CHANGED_STATE`, the current state returned from [GetItemState](../vs140/coleclientitem--getitemstate.md) will still be the old state, meaning the state that was current prior to this state change.  
  
 Override this function to respond to changes in the OLE item's state. Typically you update the item's appearance by invalidating the area in which the item is displayed. Call the base class implementation at the beginning of your override.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::GetItemState](../vs140/coleclientitem--getitemstate.md)   
 [COleServerItem::NotifyChanged](../vs140/coleserveritem--notifychanged.md)   
 [COleServerDoc::NotifyChanged](../vs140/coleserverdoc--notifychanged.md)   
 [COleServerDoc::NotifyClosed](../vs140/coleserverdoc--notifyclosed.md)   
 [COleServerDoc::NotifySaved](../vs140/coleserverdoc--notifysaved.md)