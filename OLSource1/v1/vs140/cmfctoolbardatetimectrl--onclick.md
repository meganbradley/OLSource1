---
title: "CMFCToolBarDateTimeCtrl::OnClick"
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
  - OnClick
  - CMFCToolBarDateTimeCtrl.OnClick
  - CMFCToolBarDateTimeCtrl::OnClick
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnClick method
ms.assetid: 886eba07-fd1d-4e9d-945f-ba2692b351bd
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBarDateTimeCtrl::OnClick
Called by the framework when the user clicks the control.  
  
## Syntax  
  
```  
virtual BOOL OnClick(  
   CWnd* pWnd,  
   BOOL bDelay = TRUE  
);  
```  
  
#### Parameters  
 [in] `pWnd`  
 Unused.  
  
 [in] `bDelay`  
 Unused.  
  
## Return Value  
 Nonzero if the button processes the click message; otherwise 0.  
  
## Remarks  
 This method overrides the base class implementation, [CMFCToolBarButton::OnClick](../vs140/cmfctoolbarbutton--onclick.md), by returning a nonzero value if the internal `CMFCToolBarDateTimeCtrlImpl` object is visible.  
  
## Requirements  
 **Header:** afxtoolbardatetimectrl.h  
  
## See Also  
 [CMFCToolBarDateTimeCtrl Class](../vs140/cmfctoolbardatetimectrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton::OnClick](../vs140/cmfctoolbarbutton--onclick.md)   
 [CMFCToolBarDateTimeCtrlImpl Class](assetId:///4fcddcbc-b374-4c27-bfb4-09fb0ca2eac5)