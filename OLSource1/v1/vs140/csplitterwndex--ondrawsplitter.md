---
title: "CSplitterWndEx::OnDrawSplitter"
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
  - CSplitterWndEx.OnDrawSplitter
  - OnDrawSplitter
  - CSplitterWndEx::OnDrawSplitter
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnDrawSplitter method
ms.assetid: 77b4a2e8-4fef-45c1-98ea-dfaaae3859a1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSplitterWndEx::OnDrawSplitter
Called by the framework to draw a splitter window.  
  
## Syntax  
  
```  
virtual void OnDrawSplitter(  
   CDC* pDC,  
   ESplitType nType,  
   const CRect& rect   
);  
```  
  
#### Parameters  
 [in] `pDC`  
 Pointer to the device context. If this parameter is `NULL`, the framework redraws the active window.  
  
 [in] `nType`  
 One of the `CSplitterWnd::ESplitType` enumeration values that specifies the splitter window element to draw. Valid values are `splitBox`, `splitBar`, `splitIntersection`, and `splitBorder`.  
  
 [in] `rect`  
 A bounding rectangle that specifies the dimensions and location to draw the specified splitter window element.  
  
## Remarks  
  
## Requirements  
 **Header:** afxsplitterwndex.h  
  
## See Also  
 [CSplitterWndEx Class](../vs140/csplitterwndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)