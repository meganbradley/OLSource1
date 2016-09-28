---
title: "CScrollView::CheckScrollBars"
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
  - "CScrollView::CheckScrollBars"
  - "CScrollView.CheckScrollBars"
  - "CheckScrollBars"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CheckScrollBars method"
ms.assetid: bbd1d08d-5dc4-48d4-8f2f-4217d43deb2a
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CScrollView::CheckScrollBars
Call this member function to determine if the scroll view has horizontal and vertical bars.  
  
## Syntax  
  
```  
  
      void CheckScrollBars(  
   BOOL& bHasHorzBar,  
   BOOL& bHasVertBar   
) const;  
```  
  
#### Parameters  
 *bHasHorzBar*  
 Indicates the application has a horizontal scroll bar.  
  
 *bHasVertBar*  
 Indicates the application has a vertical scroll bar.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CScrollView::GetDeviceScrollPosition](../vs140/cscrollview--getdevicescrollposition.md)   
 [CScrollView::GetDeviceScrollPosition](../vs140/cscrollview--getdevicescrollposition.md)