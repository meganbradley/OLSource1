---
title: "COleServerItem::SetItemName"
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
  - "SetItemName"
  - "COleServerItem.SetItemName"
  - "COleServerItem::SetItemName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleServerItem class, status"
  - "SetItemName method"
ms.assetid: 3f952d9b-800a-459d-8b9d-9f7db8ccf01a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerItem::SetItemName
Call this function when you create a linked item to set its name.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the new name of the item.  
  
## Remarks  
 The name must be unique within the document. When a server application is called to edit a linked item, the application uses this name to find the item. You do not need to call this function for embedded items.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerItem Class](../vs140/coleserveritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerItem::GetItemName](../vs140/coleserveritem--getitemname.md)   
 [COleLinkingDoc::OnGetLinkedItem](../vs140/colelinkingdoc--ongetlinkeditem.md)