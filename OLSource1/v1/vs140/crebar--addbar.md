---
title: "CReBar::AddBar"
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
  - "CReBar::AddBar"
  - "CReBar.AddBar"
  - "AddBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CReBar class, attributes"
  - "AddBar method"
ms.assetid: 2879d807-aa87-4e43-bb36-c8e0dfd2466e
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CReBar::AddBar
Call this member function to add a band to the rebar.  
  
## Syntax  
  
```  
  
      BOOL AddBar(  
   CWnd* pBar,  
   LPCTSTR pszText = NULL,  
   CBitmap* pbmp = NULL,  
   DWORD dwStyle = RBBS_GRIPPERALWAYS | RBBS_FIXEDBMP   
);  
BOOL AddBar(  
   CWnd* pBar,  
   COLORREF clrFore,  
   COLORREF clrBack,  
   LPCTSTR pszText = NULL,  
   DWORD dwStyle = RBBS_GRIPPERALWAYS   
);  
```  
  
#### Parameters  
 `pBar`  
 A pointer to a `CWnd` object that is the child window to be inserted into the rebar. The referenced object must have a **WS_CHILD**.  
  
 `lpszText`  
 A pointer to a string containing the text to appear on the rebar. **NULL** by default. The text contained in `lpszText` is not part of the child window; it is on the rebar itself.  
  
 `pbmp`  
 A pointer to a `CBitmap` object to be displayed on the rebar background. **NULL** by default.  
  
 `dwStyle`  
 A `DWORD` containing the style to apply to the rebar. See the **fStyle** function description in the Win32 structure [REBARBANDINFO](http://msdn.microsoft.com/library/windows/desktop/bb774393) for a complete list of band styles.  
  
 *clrFore*  
 A **COLORREF** value that represents the foreground color of the rebar.  
  
 *clrBack*  
 A **COLORREF** value that represents the background color of the rebar.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Example  
 [!code[NVC_MFC_CReBarCtrl#1](../vs140/codesnippet/CPP/crebar--addbar_1.cpp)]  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CReBar Class](../vs140/crebar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CReBarCtrl Class](../vs140/crebarctrl-class.md)