---
title: "CFrameWndEx::OnActivateApp"
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
  - "CFrameWndEx::OnActivateApp"
  - "CFrameWndEx.OnActivateApp"
  - "OnActivateApp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnActivateApp method"
ms.assetid: 481bc560-8135-46fb-9be9-cd8092c861be
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWndEx::OnActivateApp
Called by the framework when the application is either selected or deselected.  
  
## Syntax  
  
```  
afx_msg void OnActivateApp(  
   BOOL bActive,  
   DWORD dwThreadID  
);  
```  
  
#### Parameters  
 [in] `bActive`  
 `TRUE` if the application is selected; `FALSE` if the application is not selected.  
  
 [in] `dwThreadID`  
 This parameter is not used.  
  
## Remarks  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)