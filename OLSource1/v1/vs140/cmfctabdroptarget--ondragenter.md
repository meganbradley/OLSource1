---
title: "CMFCTabDropTarget::OnDragEnter"
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
  - "CMFCTabDropTarget.OnDragEnter"
  - "OnDragEnter"
  - "CMFCTabDropTarget::OnDragEnter"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDragEnter method"
ms.assetid: 2837c799-fb08-4fc6-b6e6-ef6f64544ee8
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTabDropTarget::OnDragEnter
Called by the framework when the user drags an object into a tab window.  
  
## Syntax  
  
```  
virtual DROPEFFECT OnDragEnter(  
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
|[in] `point`|The location of the cursor in client coordinates.|  
  
## Return Value  
 The effect that results if the drop occurs at the location specified by `point`. It can be one or more of the following:  
  
-   `DROPEFFECT_NONE`  
  
-   `DROPEFFECT_COPY`  
  
-   `DROPEFFECT_MOVE`  
  
-   `DROPEFFECT_LINK`  
  
-   `DROPEFFECT_SCROLL`  
  
## Remarks  
 This method returns `DROPEFFECT_NONE` if the toolbar framework is not in customization mode or the Clipboard data format is unavailable. Otherwise, it returns the result of calling `CMFCBaseTabCtrl::OnDragEnter` with the provided parameters.  
  
 For more information about customization mode, see [CMFCToolBar::IsCustomizeMode](../vs140/cmfctoolbar--iscustomizemode.md). For more information about Clipboard data formats, see [COleDataObject::IsDataAvailable](../vs140/coledataobject--isdataavailable.md).  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCTabDropTarget Class](../vs140/cmfctabdroptarget-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::IsCustomizeMode](../vs140/cmfctoolbar--iscustomizemode.md)   
 [COleDataObject::IsDataAvailable](../vs140/coledataobject--isdataavailable.md)