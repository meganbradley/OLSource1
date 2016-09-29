---
title: "COleServerDoc::UpdateAllItems"
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
  - "COleServerDoc.UpdateAllItems"
  - "DVASPECT"
  - "UpdateAllItems"
  - "COleServerDoc::UpdateAllItems"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UpdateAllItems method"
  - "COleServerDoc class, operations"
  - "DVASPECT"
ms.assetid: 71567693-b1e2-415f-916c-07f157d37ea8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerDoc::UpdateAllItems
Call this function to notify all linked items connected to the document that the document has changed.  
  
## Syntax  
  
```  
  
      void UpdateAllItems(  
   COleServerItem* pSender,  
   LPARAM lHint = 0L,  
   CObject* pHint = NULL,  
   DVASPECT nDrawAspect = DVASPECT_CONTENT   
);  
```  
  
#### Parameters  
 `pSender`  
 Pointer to the item that modified the document, or **NULL** if all items are to be updated.  
  
 `lHint`  
 Contains information about the modification.  
  
 `pHint`  
 Pointer to an object storing information about the modification.  
  
 `nDrawAspect`  
 Determines how the item is to be drawn. This is a value from the `DVASPECT` enumeration. This parameter can have one of the following values:  
  
-   `DVASPECT_CONTENT` Item is represented in such a way that it can be displayed as an embedded object inside its container.  
  
-   `DVASPECT_THUMBNAIL` Item is rendered in a "thumbnail" representation so that it can be displayed in a browsing tool.  
  
-   `DVASPECT_ICON` Item is represented by an icon.  
  
-   `DVASPECT_DOCPRINT` Item is represented as if it were printed using the Print command from the File menu.  
  
## Remarks  
 You typically call this function after the user changes the server document. If an OLE item is linked to the document with an automatic link, the item is updated to reflect the changes. In container applications written with the Microsoft Foundation Class Library, the [OnChange](../vs140/coleclientitem--onchange.md) member function of `COleClientItem` is called.  
  
 This function calls the `OnUpdate` member function for each of the document's items except the sending item, passing `pHint`, `lHint`, and `nDrawAspect`. Use these parameters to pass information to the items about the modifications made to the document. You can encode information using `lHint` or you can define a `CObject`-derived class to store information about the modifications and pass an object of that class using `pHint`. Override the `OnUpdate` member function in your `COleServerItem`-derived class to optimize the updating of each item depending on whether its presentation has changed.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerDoc Class](../vs140/coleserverdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerDoc::NotifyChanged](../vs140/coleserverdoc--notifychanged.md)   
 [COleServerItem::OnUpdate](../vs140/coleserveritem--onupdate.md)   
 [COleServerDoc::NotifySaved](../vs140/coleserverdoc--notifysaved.md)   
 [COleClientItem::OnChange](../vs140/coleclientitem--onchange.md)