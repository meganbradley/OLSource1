---
title: "CFrameWndEx::OnClose"
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
  - "CFrameWndEx.OnClose"
  - "CFrameWndEx::OnClose"
  - "OnClose"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnClose method"
ms.assetid: f432ef51-77df-4464-97c4-c393b1753a48
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWndEx::OnClose
The framework calls this method to close the frame.  
  
## Syntax  
  
```  
afx_msg void OnClose();  
```  
  
## Remarks  
 If the frame is in print preview mode, it sends a Windows message to close the print preview; otherwise, if the frame hosts an OLE client, the client is deactivated.  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)