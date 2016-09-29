---
title: "CSplitterWnd::RecalcLayout"
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
  - "CSplitterWnd::RecalcLayout"
  - "CSplitterWnd.RecalcLayout"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RecalcLayout method"
  - "CSplitterWnd class, operations"
  - "recalculating splitter window layouts"
  - "splitter windows, layout"
ms.assetid: 7c82215c-8ad0-4843-8599-816194557461
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSplitterWnd::RecalcLayout
Call to redisplay the splitter window after adjusting row or column size.  
  
## Syntax  
  
```  
  
virtual void RecalcLayout( );  
```  
  
## Remarks  
 Call this member function to correctly redisplay the splitter window after you have adjusted row and column sizes with the [SetRowInfo](../vs140/csplitterwnd--setrowinfo.md) and [SetColumnInfo](../vs140/csplitterwnd--setcolumninfo.md) member functions. If you change row and column sizes as part of the creation process before the splitter window is visible, it is not necessary to call this member function.  
  
 The framework calls this member function whenever the user resizes the splitter window or moves a split.  
  
## Example  
 See the example for [CSplitterWnd::SetColumnInfo](../vs140/csplitterwnd--setcolumninfo.md).  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CSplitterWnd Class](../vs140/csplitterwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSplitterWnd::SetRowInfo](../vs140/csplitterwnd--setrowinfo.md)   
 [CSplitterWnd::SetColumnInfo](../vs140/csplitterwnd--setcolumninfo.md)