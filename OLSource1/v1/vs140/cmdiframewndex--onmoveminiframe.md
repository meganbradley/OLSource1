---
title: "CMDIFrameWndEx::OnMoveMiniFrame"
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
  - "CMDIFrameWndEx.OnMoveMiniFrame"
  - "OnMoveMiniFrame"
  - "CMDIFrameWndEx::OnMoveMiniFrame"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnMoveMiniFrame method"
ms.assetid: 84b3117d-2166-4033-8ba1-244afc2cc880
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::OnMoveMiniFrame
Called by the framework to move a mini-frame window.  
  
## Syntax  
  
```  
virtual BOOL OnMoveMiniFrame(  
   CWnd* pFrame  
);  
```  
  
#### Parameters  
 [in] `pFrame`  
 A pointer to a mini-frame window.  
  
## Return Value  
 `TRUE` if the method succeeds, otherwise `FALSE`.  
  
## Requirements  
 **Header:** afxmdiframewndex.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)