---
title: "CMFCVisualManagerOffice2003::OnFillHeaderCtrlBackground"
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
  - OnFillHeaderCtrlBackground
  - CMFCVisualManagerOffice2003.OnFillHeaderCtrlBackground
  - CMFCVisualManagerOffice2003::OnFillHeaderCtrlBackground
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnFillHeaderCtrlBackground method
ms.assetid: 7fb77950-561f-498e-8f87-029d7dde4309
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCVisualManagerOffice2003::OnFillHeaderCtrlBackground
The framework calls this method when it fills the background of a header control.  
  
## Syntax  
  
```  
virtual void OnFillHeaderCtrlBackground(  
   CMFCHeaderCtrl* pCtrl,  
   CDC* pDC,  
   CRect rect  
);  
```  
  
#### Parameters  
 [in] `pCtrl`  
 A pointer to a [CMFCHeaderCtrl](../vs140/cmfcheaderctrl-class.md) object. The framework fills the background for this header control.  
  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `rect`  
 A rectangle that specifies the boundaries of the header control.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of a header control.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)