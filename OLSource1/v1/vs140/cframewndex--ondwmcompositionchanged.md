---
title: "CFrameWndEx::OnDWMCompositionChanged"
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
  - CFrameWndEx::OnDWMCompositionChanged
  - OnDWMCompositionChanged
  - CFrameWndEx.OnDWMCompositionChanged
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnDWMCompositionChanged method
ms.assetid: 63a20f60-b6d5-4984-a540-6d614823f5d7
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CFrameWndEx::OnDWMCompositionChanged
Called by the framework when Desktop Window Manager (DWM) composition has been enabled or disabled.  
  
## Syntax  
  
```  
afx_msg LRESULT OnDWMCompositionChanged(  
   WPARAM wp,  
   LPARAM lp  
);  
```  
  
#### Parameters  
 [in] `wp`  
 This parameter is not used.  
  
 [in] `lp`  
 This parameter is not used.  
  
## Return Value  
 Always returns 0.  
  
## Remarks  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)