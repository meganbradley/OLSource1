---
title: "CFrameWndEx::OnCloseMiniFrame"
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
  - "OnCloseMiniFrame"
  - "CFrameWndEx::OnCloseMiniFrame"
  - "CFrameWndEx.OnCloseMiniFrame"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnCloseMiniFrame method"
ms.assetid: e4a7d642-3adb-411f-847e-bfa3e7e471cd
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWndEx::OnCloseMiniFrame
Called by the framework when the user clicks the **Close** button on a floating mini frame window.  
  
## Syntax  
  
```  
virtual BOOL OnCloseMiniFrame(  
   CPaneFrameWnd* pWnd  
);  
```  
  
## Return Value  
 `TRUE` if a floating mini frame window can be closed. `FALSE` otherwise.  
  
## Remarks  
 The default implementation does nothing. Override this method if you want to process the hiding of a floating mini frame window.  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)