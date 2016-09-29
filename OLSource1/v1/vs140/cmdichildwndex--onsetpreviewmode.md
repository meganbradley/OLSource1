---
title: "CMDIChildWndEx::OnSetPreviewMode"
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
  - "CMDIChildWndEx.OnSetPreviewMode"
  - "CMDIChildWndEx::OnSetPreviewMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnSetPreviewMode method"
ms.assetid: fd32ab6a-95c4-48ca-8123-f72cec7df8b9
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIChildWndEx::OnSetPreviewMode
Called by the framework to enter or exit print preview mode.  
  
## Syntax  
  
```  
virtual void OnSetPreviewMode(  
   BOOL bPreview,  
   CPrintPreviewState* pState  
);  
```  
  
#### Parameters  
 [in] `bPreview`  
 If `TRUE`, enter print preview mode. If `FALSE`, exit print preview mode.  
  
 [in] `pState`  
 A pointer to the print preview state structure.  
  
## Requirements  
 **Header:** afxmdichildwndex.h  
  
## See Also  
 [CMDIChildWndEx Class](../vs140/cmdichildwndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)