---
title: "CMFCTabCtrl::OnDragEnter"
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
  - "OnDragEnter"
  - "CMFCTabCtrl.OnDragEnter"
  - "CMFCTabCtrl::OnDragEnter"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDragEnter method"
ms.assetid: 7e401c61-df01-4fce-a07e-c3de9ac556bc
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTabCtrl::OnDragEnter
Called by the framework during a drag-and-drop operation when the cursor first enters the window of the current tab control.  
  
## Syntax  
  
```  
virtual DROPEFFECT OnDragEnter(  
   COleDataObject* pDataObject,  
   DWORD dwKeyState,  
   CPoint point  
);  
```  
  
#### Parameters  
 [in] `pDataObject`  
 Points to a data object that contains data that the user drags.  
  
 [in] `dwKeyState`  
 Contains the state of the modifier keys. This parameter is a bitwise combination (OR) of the following values: `MK_CONTROL`, `MK_SHIFT`, `MK_ALT`, `MK_LBUTTON`, `MK_MBUTTON`, and `MK_RBUTTON`. For more information, see the **Message Parameters** section of [About Mouse Input](http://msdn.microsoft.com/library/windows/desktop/ms645601).  
  
 [in] `point`  
 Contains the current location of the cursor in client coordinates.  
  
## Return Value  
 Always `DROPEFFECT_NONE`, which means that the drop target cannot accept the data.  
  
## Remarks  
 Use this method to support a drag-and-drop operation. Override this method to implement your own custom behavior.  
  
 By default, this method only calls `CMFCTabCtrl::OnDragOver`, which always returns `DROPEFFECT_NONE`.  
  
## Requirements  
 **Header:** afxtabctrl.h  
  
## See Also  
 [CMFCTabCtrl Class](../vs140/cmfctabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [About Mouse Input](http://msdn.microsoft.com/library/windows/desktop/ms645601)