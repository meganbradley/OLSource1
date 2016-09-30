---
title: "CMDIFrameWndEx::OnSetPreviewMode"
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
  - "OnSetPreviewMode"
  - "CMDIFrameWndEx::OnSetPreviewMode"
  - "CMDIFrameWndEx.OnSetPreviewMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnSetPreviewMode method"
ms.assetid: a599ac4b-fa71-4a55-8ca4-8c8c98b96284
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::OnSetPreviewMode
Sets the application's main frame window print-preview mode.  
  
## Syntax  
  
```  
virtual void OnSetPreviewMode(  
   BOOL bPreview,  
   CPrintPreviewState* pState  
);  
```  
  
#### Parameters  
 [in] `bPreview`  
 If `TRUE`, sets print-preview mode. If `FALSE`, cancels preview mode.  
  
 [in] `pState`  
 A pointer to a `CPrintPreviewState` structure.  
  
## Remarks  
 This method overrides [CFrameWnd::OnSetPreviewMode](../vs140/cframewnd--onsetpreviewmode.md).  
  
## Requirements  
 **Header:** afxmdiframewndex.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)