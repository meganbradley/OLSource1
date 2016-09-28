---
title: "CMDIFrameWndEx::OnDrawMenuLogo"
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
  - "CMDIFrameWndEx.OnDrawMenuLogo"
  - "CMDIFrameWndEx::OnDrawMenuLogo"
  - "OnDrawMenuLogo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawMenuLogo method"
ms.assetid: 2022ec3f-3a8f-41ac-9555-1cd55ac8ca72
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::OnDrawMenuLogo
Called by the framework when a [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md)processes a `WM_PAINT` message.  
  
## Syntax  
  
```  
virtual void OnDrawMenuLogo(  
   CDC* ,  
   CMFCPopupMenu* ,  
   const CRect&    
);  
```  
  
## Remarks  
 Override this function to display a logo on the pop-up menu that belongs to the menu bar owned by the `CMDIFrameWndEx`-derived object. The default implementation does nothing.  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)