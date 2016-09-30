---
title: "COleServerItem::IsLinkedItem"
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
  - "COleServerItem::IsLinkedItem"
  - "IsLinkedItem"
  - "COleServerItem.IsLinkedItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleServerItem class, status"
  - "IsLinkedItem method"
ms.assetid: 1abee630-f5a8-4349-95be-f5a262e5e78b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerItem::IsLinkedItem
Call this function to see if the OLE item is a linked item.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the item is a linked item; otherwise 0.  
  
## Remarks  
 An item is linked if the item is valid and is not returned in the document's list of embedded items. A linked item might or might not be connected to a container.  
  
 It is common to use the same class for both linked and embedded items. <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> allows you to make linked items behave differently than embedded items, although many times the code is common.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerItem Class](../vs140/coleserveritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerItem::IsConnected](../vs140/coleserveritem--isconnected.md)   
 [COleLinkingDoc::OnGetLinkedItem](../vs140/colelinkingdoc--ongetlinkeditem.md)