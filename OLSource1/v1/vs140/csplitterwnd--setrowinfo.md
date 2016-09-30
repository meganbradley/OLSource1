---
title: "CSplitterWnd::SetRowInfo"
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
  - "CSplitterWnd::SetRowInfo"
  - "SetRowInfo"
  - "CSplitterWnd.SetRowInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSplitterWnd class, operations"
  - "splitter windows, columns"
  - "SetRowInfo method"
ms.assetid: 5a1edd20-c2dc-447b-a44e-dd7594887889
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSplitterWnd::SetRowInfo
Call to set the specified row information.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies a splitter window row.  
  
 *cyIdeal*  
 Specifies an ideal height for the splitter window row in pixels.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies a minimum height for the splitter window row in pixels.  
  
## Remarks  
 Call this member function to set a new minimum height and ideal height for a row. The row minimum value determines when the row will be too small to be fully displayed.  
  
 When the framework displays the splitter window, it lays out the panes in columns and rows according to their ideal dimensions, working from the upper-left to the lower-right corner of the splitter window's client area.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CSplitterWnd Class](../vs140/csplitterwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSplitterWnd::GetRowInfo](../vs140/csplitterwnd--getrowinfo.md)   
 [CSplitterWnd::SetColumnInfo](../vs140/csplitterwnd--setcolumninfo.md)   
 [CSplitterWnd::RecalcLayout](../vs140/csplitterwnd--recalclayout.md)