---
title: "COleClientItem::OnActivateUI"
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
  - "COleClientItem.OnActivateUI"
  - "COleClientItem::OnActivateUI"
  - "OnActivateUI"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnActivateUI method"
  - "COleClientItem class, overridables"
ms.assetid: 9c5554d2-e7bd-4ccc-b772-22d5c16f99bc
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::OnActivateUI
The framework calls <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> when the object has entered the active UI state.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The object has now installed its tool bar and menus.  
  
 The default implementation remembers the server's <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> for later **GetServerWindow** calls.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::OnDeactivate](../vs140/coleclientitem--ondeactivate.md)   
 [COleClientItem::OnDeactivateUI](../vs140/coleclientitem--ondeactivateui.md)   
 [COleClientItem::OnActivate](../vs140/coleclientitem--onactivate.md)   
 [COleClientItem::CanActivate](../vs140/coleclientitem--canactivate.md)