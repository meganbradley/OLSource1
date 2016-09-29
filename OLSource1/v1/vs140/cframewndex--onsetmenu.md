---
title: "CFrameWndEx::OnSetMenu"
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
  - "CFrameWndEx::OnSetMenu"
  - "CFrameWndEx.OnSetMenu"
  - "OnSetMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnSetMenu method"
ms.assetid: f05251ce-b582-4a4a-b815-a5eeb0dab0e7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWndEx::OnSetMenu
Called by the framework to replace the frame window menu.  
  
## Syntax  
  
```  
afx_msg LRESULT OnSetMenu(  
   WPARAM wp,  
   LPARAM lp  
);  
BOOL OnSetMenu(  
   HMENU hmenu  
);  
```  
  
#### Parameters  
 [in] `wp`  
 Handle to the new frame window menu.  
  
 [in] `lp`  
 Handle to the new window menu.  
  
 [in] `hmenu`  
 Handle to the new frame window menu.  
  
## Return Value  
 `LRESULT` is the result from calling the default window procedure.  
  
 `BOOL` is `TRUE` if the event was handled; otherwise, `FALSE`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)