---
title: "CMFCRibbonBar::Create"
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
  - CMFCRibbonBar::Create
  - CMFCRibbonBar.Create
  - Create
dev_langs: 
  - C++
helpviewer_keywords: 
  - Create method
ms.assetid: fbb4c188-4077-42b8-9559-86b32ca5d03c
caps.latest.revision: 30
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCRibbonBar::Create
Creates a window for the ribbon bar.  
  
## Syntax  
  
```  
BOOL Create(  
   CWnd* pParentWnd,  
   DWORD dwStyle = WS_CHILD | WS_VISIBLE | CBRS_TOP,  
   UINT nID = AFX_IDW_RIBBON_BAR   
);  
```  
  
#### Parameters  
 [in] `pParentWnd`  
 Pointer to the parent window for the ribbon bar.  
  
 [in] `dwStyle`  
 A logical combination of styles for the new window.  
  
 [in] `nID`  
 ID of the new window.  
  
## Return Value  
 `TRUE` if the window was created; otherwise `FALSE`.  
  
## Remarks  
  
## Example  
 The following example demonstrates how to use the `Create` method of the `CMFCRibbonBar` class.  
  
 [!code[NVC_MFC_RibbonApp#1](../vs140/codesnippet/CPP/cmfcribbonbar--create_1.cpp)]
  
  
## Requirements  
 **Header:** afxribbonbar.h  
  
## See Also  
 [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)