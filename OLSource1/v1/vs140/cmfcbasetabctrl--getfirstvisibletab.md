---
title: "CMFCBaseTabCtrl::GetFirstVisibleTab"
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
  - CMFCBaseTabCtrl.GetFirstVisibleTab
  - GetFirstVisibleTab
  - CMFCBaseTabCtrl::GetFirstVisibleTab
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetFirstVisibleTab method
ms.assetid: a96c7092-7814-4e39-86ec-11fdc46c2be9
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCBaseTabCtrl::GetFirstVisibleTab
Retrieves a pointer to the first visible tab.  
  
## Syntax  
  
```  
virtual CWnd* GetFirstVisibleTab(  
   int& iTabNum  
);  
virtual CWnd* GetFirstVisibleTab(  
   int iStartFrom,  
   int& iTabNum  
);  
```  
  
#### Parameters  
 [out] `iTabNum`  
 A reference to an integer. This method writes the zero-based index of the first visible tab to this parameter.  
  
 [in] `iStartFrom`  
 The zero-based index of the first tab to check.  
  
## Return Value  
 A pointer to the first visible tab if successful; otherwise `NULL`.  
  
## Remarks  
 If this method fails, it writes the value -1 to `iStartFrom`.  
  
 If `iStartFrom` is larger than or equal to the number of tabs in the tab control, `GetFirstVisibleTab` automatically fails.  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)