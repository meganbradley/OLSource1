---
title: "CMFCTabCtrl::OnDragOver"
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
  - "CMFCTabCtrl.OnDragOver"
  - "OnDragOver"
  - "CMFCTabCtrl::OnDragOver"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCTabCtrl::OnDragOver"
  - "OnDragOver method"
ms.assetid: a9eda309-f37d-485f-b6fc-1389f4746824
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTabCtrl::OnDragOver
Called by the framework during a drag operation when the mouse is moved over the drop target window.  
  
## Syntax  
  
```  
virtual DROPEFFECT OnDragOver(  
   COleDataObject* pDataObject,  
   DWORD dwKeyState,  
   CPoint point  
);  
```  
  
#### Parameters  
 [in] `pDataObject`  
 Pointer to a [COleDataObject](../vs140/coledataobject-class.md) object that is being dragged over the drop target.  
  
 [in] `dwKeyState`  
 The state of the modifier keys, which is a bitwise combination (OR) of `MK_CONTROL`, `MK_SHIFT`, `MK_ALT`, `MK_LBUTTON`, `MK_MBUTTON`, and `MK_RBUTTON`. For more information, see "Message Parameters" in [About Mouse Input](http://msdn.microsoft.com/library/windows/desktop/ms645601).  
  
 [in] `point`  
 The current mouse position.  
  
## Return Value  
 Always `DROPEFFECT_NONE`.  
  
## Remarks  
 Override this method with your custom implementation. For more information, see the [CView::OnDragOver](../vs140/cview--ondragover.md) method.  
  
## Requirements  
 **Header:** afxtabctrl.h  
  
## See Also  
 [CMFCTabCtrl Class](../vs140/cmfctabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [About Mouse Input](http://msdn.microsoft.com/library/windows/desktop/ms645601)