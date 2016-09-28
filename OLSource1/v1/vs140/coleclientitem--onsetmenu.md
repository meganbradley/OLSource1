---
title: "COleClientItem::OnSetMenu"
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
  - "COleClientItem::OnSetMenu"
  - "COleClientItem.OnSetMenu"
  - "OnSetMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnSetMenu method"
  - "COleClientItem class, overridables"
ms.assetid: 707d4d21-e7a8-4651-a457-bbc5b68f6e6c
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::OnSetMenu
Called by the framework two times when in-place activation begins and ends; the first time to install the composite menu and the second time (with `holemenu` equal to **NULL**) to remove it.  
  
## Syntax  
  
```  
  
      virtual void OnSetMenu(  
   CMenu* pMenuShared,  
   HOLEMENU holemenu,  
   HWND hwndActiveObject   
);  
```  
  
#### Parameters  
 `pMenuShared`  
 Pointer to the composite menu constructed by calls to the [OnInsertMenus](../vs140/coleclientitem--oninsertmenus.md) member function and the `InsertMenu` function.  
  
 `holemenu`  
 Handle to the menu descriptor returned by the **OleCreateMenuDescriptor** function, or **NULL** if the dispatching code is to be removed.  
  
 *hwndActiveObject*  
 Handle to the editing window for the OLE item. This is the window that will receive editing commands from OLE.  
  
## Remarks  
 The default implementation installs or removes the composite menu and then calls the [OleSetMenuDescriptor](http://msdn.microsoft.com/library/windows/desktop/ms692831) function to install or remove the dispatching code. Override this function if the default implementation is not appropriate for your application. If you override this function, you should probably override [OnInsertMenus](../vs140/coleclientitem--oninsertmenus.md) and [OnRemoveMenus](../vs140/coleclientitem--onremovemenus.md) as well. This is an advanced overridable.  
  
 For more information, see [OleCreateMenuDescriptor](http://msdn.microsoft.com/library/windows/desktop/ms691415), [OleSetMenuDescriptor](http://msdn.microsoft.com/library/windows/desktop/ms692831), and [IOleInPlaceFrame::SetMenu](http://msdn.microsoft.com/library/windows/desktop/ms693713) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::OnInsertMenus](../vs140/coleclientitem--oninsertmenus.md)   
 [COleClientItem::OnRemoveMenus](../vs140/coleclientitem--onremovemenus.md)