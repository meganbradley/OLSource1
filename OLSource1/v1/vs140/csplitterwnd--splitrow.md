---
title: "CSplitterWnd::SplitRow"
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
  - "CSplitterWnd.SplitRow"
  - "CSplitterWnd::SplitRow"
  - "SplitRow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSplitterWnd class, overridables"
  - "splitter windows, rows"
  - "SplitRow method"
ms.assetid: c89dc71a-0f78-40fb-a106-319754b81f39
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSplitterWnd::SplitRow
Indicates where a frame window splits horizontally.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *cyBefore*  
 The position, in pixels, before which the split occurs.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This member function is called when a horizontal splitter window is created. <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> indicates the default location where the split occurs.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is called by the framework to implement the logic of the dynamic splitter window (that is, if the splitter window has the **SPLS_DYNAMIC_SPLIT** style). It can be customized, along with the virtual function [CreateView](../vs140/csplitterwnd--createview.md), to implement more advanced dynamic splitters.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CSplitterWnd Class](../vs140/csplitterwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSplitterWnd::SplitColumn](../vs140/csplitterwnd--splitcolumn.md)   
 [CSplitterWnd::CreateView](../vs140/csplitterwnd--createview.md)   
 [CSplitterWnd::RecalcLayout](../vs140/csplitterwnd--recalclayout.md)