---
title: "CSplitterWnd::SetColumnInfo"
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
  - "SetColumnInfo"
  - "CSplitterWnd.SetColumnInfo"
  - "CSplitterWnd::SetColumnInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSplitterWnd class, operations"
  - "splitter windows, columns"
  - "SetColumnInfo method"
ms.assetid: a79989fc-3a57-4b6d-839a-108c333b6a6d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSplitterWnd::SetColumnInfo
Call to set the specified column information.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies a splitter window column.  
  
 *cxIdeal*  
 Specifies an ideal width for the splitter window column in pixels.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies a minimum width for the splitter window column in pixels.  
  
## Remarks  
 Call this member function to set a new minimum width and ideal width for a column. The column minimum value determines when the column will be too small to be fully displayed.  
  
 When the framework displays the splitter window, it lays out the panes in columns and rows according to their ideal dimensions, working from the upper-left to the lower-right corner of the splitter window's client area.  
  
## Example  
 [!code[NVC_MFCWindowing#6](../vs140/codesnippet/CPP/csplitterwnd--setcolumninfo_1.cpp)]  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CSplitterWnd Class](../vs140/csplitterwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSplitterWnd::GetRowInfo](../vs140/csplitterwnd--getrowinfo.md)   
 [CSplitterWnd::RecalcLayout](../vs140/csplitterwnd--recalclayout.md)