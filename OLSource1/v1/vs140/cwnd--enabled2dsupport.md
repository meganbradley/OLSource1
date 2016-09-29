---
title: "CWnd::EnableD2DSupport"
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
  - "EnableD2DSupport"
  - "afxwin/CWnd::EnableD2DSupport"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableD2DSupport method"
ms.assetid: ba908947-5ee6-457c-b447-12c0573fbe57
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::EnableD2DSupport
Enables or disables window D2D support. Call this method before the main window is initialized.  
  
## Syntax  
  
```  
void EnableD2DSupport(  
   BOOL bEnable = TRUE,  
   BOOL bUseDCRenderTarget = FALSE  
);  
```  
  
#### Parameters  
 `bEnable`  
 Specifies whether to turn on, or off D2D support.  
  
 `bUseDCRenderTarget`  
 Species whether to use the Device Context (DC) render target, CDCRenderTarget. If FALSE, CHwndRenderTarget is used.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)