---
title: "CMFCTabDropTarget::OnDragLeave"
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
  - CMFCTabDropTarget.OnDragLeave
  - CMFCTabDropTarget::OnDragLeave
  - OnDragLeave
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnDragLeave method
ms.assetid: 9fd4dca7-e376-4d92-bae7-a835c42bb39a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCTabDropTarget::OnDragLeave
Called by the framework when the user drags an object outside of the tab window that has focus.  
  
## Syntax  
  
```  
virtual void OnDragLeave(  
   CWnd* pWnd  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] `pWnd`|Unused.|  
  
## Remarks  
 This method calls the `CMFCBaseTabCtrl::OnDragLeave` method to perform the drag operation.  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCTabDropTarget Class](../vs140/cmfctabdroptarget-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)