---
title: "CMFCVisualManager::OnNcPaint"
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
  - CMFCVisualManager::OnNcPaint
  - CMFCVisualManager.OnNcPaint
  - OnNcPaint
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnNcPaint method
ms.assetid: 8f279d75-b200-44bd-ab1c-2ce2e3f90c34
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCVisualManager::OnNcPaint
The framework calls this method when it draws the non-client area.  
  
## Syntax  
  
```  
virtual BOOL OnNcPaint(  
   CWnd* pWnd,  
   const CObList& lstSysButtons,  
   CRect rectRedraw  
);  
```  
  
#### Parameters  
 [in] `pWnd`  
 A pointer to the window whose non-client area the framework draws.  
  
 [in] `lstSysButtons`  
 A list of system buttons. These are also known as caption buttons.  
  
 [in] `rectRedraw`  
 A rectangle that specifies the boundaries of the non-client area.  
  
## Return Value  
 A reserved value. The default implementation returns `FALSE`.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of the window frame and caption buttons.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)