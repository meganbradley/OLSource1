---
title: "CMFCTabDropTarget::OnDragOver"
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
  - OnDragOver
  - CMFCTabDropTarget.OnDragOver
  - CMFCTabDropTarget::OnDragOver
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnDragOver method
ms.assetid: 21d9962a-d713-4488-bc82-5b3cc30e6cbd
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCTabDropTarget::OnDragOver
Called by the framework when the user drags an object onto the tab window that has focus.  
  
## Syntax  
  
```  
virtual DROPEFFECT OnDragOver(  
   CWnd* pWnd,  
   COleDataObject* pDataObject,  
   DWORD dwKeyState,  
   CPoint point  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] `pWnd`|Unused.|  
|[in] `pDataObject`|A pointer to the object that the user drags.|  
|[in] `dwKeyState`|Contains the state of the modifier keys. This is a combination of any number of the following: `MK_CONTROL`, `MK_SHIFT`, `MK_ALT`, `MK_LBUTTON`, `MK_MBUTTON`, and `MK_RBUTTON`.|  
|[in] `point`|The location of the mouse pointer in client coordinates.|  
  
## Return Value  
 The effect that results if the drop occurs at the location specified by `point`. It can be one or more of the following:  
  
-   `DROPEFFECT_NONE`  
  
-   `DROPEFFECT_COPY`  
  
-   `DROPEFFECT_MOVE`  
  
-   `DROPEFFECT_LINK`  
  
-   `DROPEFFECT_SCROLL`  
  
## Remarks  
 This method makes the tab that is under the cursor when a drag operation occurs active. It returns `DROPEFFECT_NONE` if the toolbar framework is not in customization mode or the Clipboard data format is unavailable. Otherwise, it returns the result of calling `CMFCBaseTabCtrl::OnDragOver` with the provided parameters.  
  
 For more information about customization mode, see [CMFCToolBar::IsCustomizeMode](../vs140/cmfctoolbar--iscustomizemode.md). For more information about Clipboard data formats, see [COleDataObject::IsDataAvailable](../vs140/coledataobject--isdataavailable.md).  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCTabDropTarget Class](../vs140/cmfctabdroptarget-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [COleDataObject::IsDataAvailable](../vs140/coledataobject--isdataavailable.md)