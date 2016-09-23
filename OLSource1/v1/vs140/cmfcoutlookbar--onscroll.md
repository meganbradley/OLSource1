---
title: "CMFCOutlookBar::OnScroll"
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
  - OnScroll
  - CMFCOutlookBar::OnScroll
  - CMFCOutlookBar.OnScroll
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnScroll method
ms.assetid: 85655e3f-4411-46b1-96b5-cbf8f1bd9c31
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCOutlookBar::OnScroll
Called by the framework if the Outlook bar is scrolling up or down.  
  
## Syntax  
  
```  
virtual void OnScroll(  
    BOOL bDown  
);  
```  
  
#### Parameters  
 [in] `bDown`  
 `TRUE` if the Outlook bar is scrolling down, or `FALSE` if it is scrolling up.  
  
## Remarks  
  
## Requirements  
 **Header:** afxoutlookbar.h  
  
## See Also  
 [CMFCOutlookBar Class](../vs140/cmfcoutlookbar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)