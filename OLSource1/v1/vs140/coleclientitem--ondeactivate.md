---
title: "COleClientItem::OnDeactivate"
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
  - COleClientItem::OnDeactivate
  - COleClientItem.OnDeactivate
  - OnDeactivate
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnDeactivate method
  - COleClientItem class, overridables
ms.assetid: 99ecb116-098c-43f4-a242-3372ebc141fa
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleClientItem::OnDeactivate
Called by the framework when the OLE item transitions from the in-place active state (`activeState`) to the loaded state, meaning that it is deactivated after an in-place activation.  
  
## Syntax  
  
```  
  
virtual void OnDeactivate( );  
```  
  
## Remarks  
 Note that this function is called to indicate that the OLE item is closed, not that its user interface has been removed from the container application. When that happens, the [OnDeactivateUI](../vs140/coleclientitem--ondeactivateui.md) member function is called.  
  
 The default implementation calls the [OnChange](../vs140/coleclientitem--onchange.md) member function with **OLE_CHANGEDSTATE** as a parameter. Override this function to perform custom processing when an in-place active item is deactivated. For example, if you support the undo command in your container application, you can override this function to discard the undo state, indicating that the last operation performed on the OLE item cannot be undone once the item is deactivated.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::OnGetWindowContext](../vs140/coleclientitem--ongetwindowcontext.md)   
 [COleClientItem::OnDeactivateUI](../vs140/coleclientitem--ondeactivateui.md)   
 [COleClientItem::OnActivateUI](../vs140/coleclientitem--onactivateui.md)   
 [COleClientItem::OnActivate](../vs140/coleclientitem--onactivate.md)   
 [COleClientItem::CanActivate](../vs140/coleclientitem--canactivate.md)   
 [CDocTemplate::SetContainerInfo](../vs140/cdoctemplate--setcontainerinfo.md)