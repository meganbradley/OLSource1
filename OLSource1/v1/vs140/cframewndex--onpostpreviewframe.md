---
title: "CFrameWndEx::OnPostPreviewFrame"
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
  - "CFrameWndEx::OnPostPreviewFrame"
  - "CFrameWndEx.OnPostPreviewFrame"
  - "OnPostPreviewFrame"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnPostPreviewFrame method"
ms.assetid: 7cbd3b92-118c-4ea5-af4e-2ea13a0bdbdb
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWndEx::OnPostPreviewFrame
Called by the framework when the user changes the print preview mode.  
  
## Syntax  
  
```  
afx_msg LRESULT OnPostPreviewFrame(  
   WPARAM wParam,  
   LPARAM lParam  
);  
```  
  
#### Parameters  
 [in] `wParam`  
 This parameter is not used.  
  
 [in] `lParam`  
 `TRUE` when the frame is in print preview mode; `FALSE` when print preview mode is off.  
  
## Return Value  
 Always returns 0.  
  
## Remarks  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)