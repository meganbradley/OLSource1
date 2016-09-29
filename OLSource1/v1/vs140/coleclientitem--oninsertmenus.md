---
title: "COleClientItem::OnInsertMenus"
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
  - "OnInsertMenus"
  - "COleClientItem::OnInsertMenus"
  - "COleClientItem.OnInsertMenus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleClientItem class, overridables"
  - "OnInsertMenus method"
ms.assetid: 13f13366-59fa-41ff-a6b4-7ce3f72a8388
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::OnInsertMenus
Called by the framework during in-place activation to insert the container application's menus into an empty menu.  
  
## Syntax  
  
```  
  
      virtual void OnInsertMenus(  
   CMenu* pMenuShared,  
   LPOLEMENUGROUPWIDTHS lpMenuWidths   
);  
```  
  
#### Parameters  
 `pMenuShared`  
 Points to an empty menu.  
  
 `lpMenuWidths`  
 Points to an array of six **LONG** values indicating how many menus are in each of the following menu groups: File, Edit, Container, Object, Window, Help. The container application is responsible for the File, Container, and Window menu groups, corresponding to elements 0, 2, and 4 of this array.  
  
## Remarks  
 This menu is then passed to the server, which inserts its own menus, creating a composite menu. This function can be called repeatedly to build several composite menus.  
  
 The default implementation inserts into `pMenuShared` the in-place container menus; that is, the File, Container, and Window menu groups. [CDocTemplate::SetContainerInfo](../vs140/cdoctemplate--setcontainerinfo.md) is used to set this menu resource. The default implementation also assigns the appropriate values to elements 0, 2, and 4 in `lpMenuWidths`, depending on the menu resource. Override this function if the default implementation is not appropriate for your application; for example, if your application does not use document templates for associating resources with document types. If you override this function, you should also override [OnSetMenu](../vs140/coleclientitem--onsetmenu.md) and [OnRemoveMenus](../vs140/coleclientitem--onremovemenus.md). This is an advanced overridable.  
  
 For more information, see [IOleInPlaceFrame::InsertMenus](http://msdn.microsoft.com/library/windows/desktop/ms683987) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::OnRemoveMenus](../vs140/coleclientitem--onremovemenus.md)   
 [COleClientItem::OnSetMenu](../vs140/coleclientitem--onsetmenu.md)