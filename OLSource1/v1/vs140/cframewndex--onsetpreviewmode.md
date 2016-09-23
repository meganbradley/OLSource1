---
title: "CFrameWndEx::OnSetPreviewMode"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - OnSetPreviewMode
  - CFrameWndEx::OnSetPreviewMode
  - CFrameWndEx.OnSetPreviewMode
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnSetPreviewMode method
ms.assetid: 239a4402-2cfb-45d9-a79e-9bdd9428a2ea
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CFrameWndEx::OnSetPreviewMode
Called by the framework to set the print preview mode for the frame.  
  
## Syntax  
  
```  
virtual void OnSetPreviewMode(  
   BOOL bPreview,  
   CPrintPreviewState* pState  
);  
```  
  
#### Parameters  
 [in] `bPreview`  
 `TRUE` to enable print preview; `FALSE` to disable print preview.  
  
 [in] `pState`  
 Pointer to a `CPrintPreviewState` frame state structure.  
  
## Remarks  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)