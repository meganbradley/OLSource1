---
title: "COleClientItem::OnRemoveMenus"
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
  - "COleClientItem.OnRemoveMenus"
  - "COleClientItem::OnRemoveMenus"
  - "OnRemoveMenus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnRemoveMenus method"
  - "COleClientItem class, overridables"
ms.assetid: 3229aa10-7cdb-42b6-b69c-5282d0792344
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::OnRemoveMenus
Called by the framework to remove the container's menus from the specified composite menu when in-place activation ends.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to the composite menu constructed by calls to the [OnInsertMenus](../vs140/coleclientitem--oninsertmenus.md) member function.  
  
## Remarks  
 The default implementation removes from <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> the in-place container menus, that is, the File, Container, and Window menu groups. Override this function if the default implementation is not appropriate for your application; for example, if your application does not use document templates for associating resources with document types. If you override this function, you should probably override [OnInsertMenus](../vs140/coleclientitem--oninsertmenus.md) and [OnSetMenu](../vs140/coleclientitem--onsetmenu.md) as well. This is an advanced overridable.  
  
 The submenus on <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> may be shared by more than one composite menu if the server has repeatedly called <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Therefore you should not delete any submenus in your override of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; you should only detach them.  
  
 For more information, see [IOleInPlaceFrame::RemoveMenus](http://msdn.microsoft.com/library/windows/desktop/ms688685) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::OnInsertMenus](../vs140/coleclientitem--oninsertmenus.md)   
 [COleClientItem::OnSetMenu](../vs140/coleclientitem--onsetmenu.md)