---
title: "CMDIFrameWndEx::OnSizeMDIClient"
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
  - "OnSizeMDIClient"
  - "CMDIFrameWndEx::OnSizeMDIClient"
  - "CMDIFrameWndEx.OnSizeMDIClient"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnSizeMDIClient method"
ms.assetid: f2d3a7b3-af24-4b79-bafb-165e068c8c0c
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::OnSizeMDIClient
Called by the framework when the size of the client MDI window is changing.  
  
## Syntax  
  
```  
virtual void OnSizeMDIClient(  
   const CRect& rectOld,  
   const CRect& rectNew  
);  
```  
  
#### Parameters  
 [in] `rectOld`  
 The current size of the MDI client window.  
  
 [in] `rectNew`  
 The new size of the MDI client window.  
  
## Remarks  
  
## Requirements  
 **Header:** afxmdiframewndex.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)