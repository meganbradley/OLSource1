---
title: "CWnd::GetSafeOwner"
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
  - "GetSafeOwner"
  - "CWnd.GetSafeOwner"
  - "CWnd::GetSafeOwner"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSafeOwner method"
  - "modal window owner"
  - "ownership, window"
  - "dialog window owner"
ms.assetid: b90dd3af-dc98-48a3-838b-a563e993523f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetSafeOwner
Call this member function to retrieve the owner window that should be used for dialog boxes or other modal windows.  
  
## Syntax  
  
```  
  
      static CWnd* GetSafeOwner(  
   CWnd* pParent = NULL,  
   HWND* pWndTop = NULL  
);  
```  
  
#### Parameters  
 `pParent`  
 A pointer to a parent `CWnd` window. May be **NULL**.  
  
 *pWndTop*  
 A pointer to the window that is currently on top. May be **NULL**.  
  
## Return Value  
 A pointer to the safe owner for the given window.  
  
## Remarks  
 The safe owner is the first non-child parent window of `pParent`. If `pParent` is **NULL**, the thread's main window (retrieved via [AfxGetMainWnd](../vs140/afxgetmainwnd.md)) is used to find an owner.  
  
> [!NOTE]
>  The framework itself uses this function to determine the correct owner window for dialog boxes and property sheets where the owner is not specified.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [AfxGetMainWnd](../vs140/afxgetmainwnd.md)