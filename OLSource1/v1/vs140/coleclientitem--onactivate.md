---
title: "COleClientItem::OnActivate"
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
  - "COleClientItem.OnActivate"
  - "COleClientItem::OnActivate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnActivate method"
  - "COleClientItem class, overridables"
ms.assetid: 10bfc777-597e-4345-a366-4df5ada12012
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::OnActivate
Called by the framework to notify the item that it has just been activated in place.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Note that this function is called to indicate that the server is running, not to indicate that its user interface has been installed in the container application. At this point, the object does not have an active user interface (is not <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>). It has not installed its menus or toolbar. The [OnActivateUI](../vs140/coleclientitem--onactivateui.md) member function is called when that happens.  
  
 The default implementation calls the [OnChange](../vs140/coleclientitem--onchange.md) member function with **OLE_CHANGEDSTATE** as a parameter. Override this function to perform custom processing when an item becomes in-place active.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::OnDeactivate](../vs140/coleclientitem--ondeactivate.md)   
 [COleClientItem::OnDeactivateUI](../vs140/coleclientitem--ondeactivateui.md)   
 [COleClientItem::OnActivateUI](../vs140/coleclientitem--onactivateui.md)   
 [COleClientItem::CanActivate](../vs140/coleclientitem--canactivate.md)