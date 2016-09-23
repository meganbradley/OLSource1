---
title: "COleClientItem::Deactivate"
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
  - COleClientItem.Deactivate
  - COleClientItem::Deactivate
  - Deactivate
dev_langs: 
  - C++
helpviewer_keywords: 
  - Deactivate method
  - COleClientItem class, activation
ms.assetid: 114e621c-91b4-48fe-a96b-05f9f5a54024
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleClientItem::Deactivate
Call this function to deactivate the OLE item and free any associated resources.  
  
## Syntax  
  
```  
  
void Deactivate( );  
```  
  
## Remarks  
 You typically deactivate an in-place active OLE item when the user clicks the mouse on the client area outside the bounds of the item. Note that deactivating the OLE item will discard its undo state, making it impossible to call the [ReactivateAndUndo](../vs140/coleclientitem--reactivateandundo.md) member function.  
  
 If your application supports undo, do not call `Deactivate`; instead, call [DeactivateUI](../vs140/coleclientitem--deactivateui.md).  
  
 For more information, see [IOleInPlaceObject::InPlaceDeactivate](http://msdn.microsoft.com/library/windows/desktop/ms679700) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::ReactivateAndUndo](../vs140/coleclientitem--reactivateandundo.md)   
 [COleClientItem::DeactivateUI](../vs140/coleclientitem--deactivateui.md)