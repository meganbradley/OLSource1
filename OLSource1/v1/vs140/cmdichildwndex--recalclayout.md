---
title: "CMDIChildWndEx::RecalcLayout"
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
  - CMDIChildWndEx.RecalcLayout
  - CMDIChildWndEx::RecalcLayout
  - RecalcLayout
dev_langs: 
  - C++
helpviewer_keywords: 
  - RecalcLayout method
ms.assetid: 17bdc997-7244-44bc-8333-ce9679841391
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMDIChildWndEx::RecalcLayout
Recalculates the layout of the window.  
  
## Syntax  
  
```  
virtual void RecalcLayout(  
   BOOL bNotify = TRUE  
);  
```  
  
#### Parameters  
 [in] `bNotify`  
 If `TRUE`, the active in-place item for the window receives notification of the layout change.  
  
## Requirements  
 **Header:** afxmdichildwndex.h  
  
## See Also  
 [CMDIChildWndEx Class](../vs140/cmdichildwndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)