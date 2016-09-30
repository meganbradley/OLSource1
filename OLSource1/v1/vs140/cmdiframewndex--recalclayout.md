---
title: "CMDIFrameWndEx::RecalcLayout"
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
  - "CMDIFrameWndEx::RecalcLayout"
  - "CMDIFrameWndEx.RecalcLayout"
  - "RecalcLayout"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RecalcLayout method"
ms.assetid: 08929d06-9d1c-4b27-8b69-7cc179d256dc
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::RecalcLayout
Called by the framework to recalculate the layout of the frame window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Determines whether the active in-place item for the frame window receives notification of the layout change. If <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, the item is notified; otherwise <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method overrides [CFrameWnd::RecalcLayout](../vs140/cframewnd--recalclayout.md).  
  
## Requirements  
 **Header:** afxmdiframewndex.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)