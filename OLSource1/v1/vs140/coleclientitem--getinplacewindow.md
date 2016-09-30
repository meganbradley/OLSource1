---
title: "COleClientItem::GetInPlaceWindow"
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
  - "COleClientItem.GetInPlaceWindow"
  - "GetInPlaceWindow"
  - "COleClientItem::GetInPlaceWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetInPlaceWindow method"
  - "COleClientItem class, activation"
ms.assetid: 884974cf-3ff6-459f-bc5d-7a0e91b45459
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::GetInPlaceWindow
Call the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function to get a pointer to the window in which the item has been opened for in-place editing.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to the item's in-place editing window; **NULL** if the item is not active or if its server is unavailable.  
  
## Remarks  
 This function should be called only for items that are in-place active.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::Activate](../vs140/coleclientitem--activate.md)   
 [COleClientItem::Deactivate](../vs140/coleclientitem--deactivate.md)   
 [COleClientItem::SetItemRects](../vs140/coleclientitem--setitemrects.md)