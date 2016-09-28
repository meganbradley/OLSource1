---
title: "CFrameWndEx::OnNcActivate"
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
  - "CFrameWndEx::OnNcActivate"
  - "CFrameWndEx.OnNcActivate"
  - "OnNcActivate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnNcActivate method"
ms.assetid: ae1c53e6-5480-46a1-be0e-b016ef00a968
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWndEx::OnNcActivate
Called by the framework when the non-client area of the frame must be redrawn to indicate a change in the active state.  
  
## Syntax  
  
```  
afx_msg BOOL OnNcActivate(  
   BOOL bActive  
);  
```  
  
#### Parameters  
 [in] `bActive`  
 `TRUE` to draw the frame active; `FALSE` to draw the frame inactive.  
  
## Return Value  
 Nonzero to continue with default processing; 0 to prevent the non-client area from being deactivated.  
  
## Remarks  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)