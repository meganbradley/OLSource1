---
title: "CMFCToolBarEditBoxButton::OnUpdateToolTip"
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
  - "OnUpdateToolTip"
  - "CMFCToolBarEditBoxButton::OnUpdateToolTip"
  - "CMFCToolBarEditBoxButton.OnUpdateToolTip"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnUpdateToolTip method"
ms.assetid: 8125391c-e6b4-47b9-8d0f-1f7186a515d1
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarEditBoxButton::OnUpdateToolTip
Called by the framework when the parent toolbar updates its tooltip text.  
  
## Syntax  
  
```  
virtual BOOL OnUpdateToolTip(  
   CWnd* pWndParent,  
   int iButtonIndex,  
   CToolTipCtrl& wndToolTip,  
   CString& str  
);  
```  
  
#### Parameters  
 [in] `pWndParent`  
 Unused.  
  
 [in] `iButtonIndex`  
 Unused.  
  
 [in] `wndToolTip`  
 The control that displays the tooltip text.  
  
 [out] `str`  
 A `CString` object that receives the updated tooltip text.  
  
## Return Value  
 Nonzero if the method updates the tooltip text; otherwise 0.  
  
## Remarks  
 This method extends the base class implementation ([CMFCToolBarButton::OnUpdateToolTip](../vs140/cmfctoolbarbutton--onupdatetooltip.md)) by displaying the tooltip text that is associated with the edit part of the button. If the internal `CEdit` object is `NULL` or the window handle of the `CEdit` object does not identify an existing window, this method does nothing and returns `FALSE`.  
  
## Requirements  
 **Header:** afxtoolbareditboxbutton.h  
  
## See Also  
 [CMFCToolBarEditBoxButton Class](../vs140/cmfctoolbareditboxbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton::OnUpdateToolTip](../vs140/cmfctoolbarbutton--onupdatetooltip.md)   
 [CEdit Class](../vs140/cedit-class.md)