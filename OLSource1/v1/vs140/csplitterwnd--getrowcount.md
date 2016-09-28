---
title: "CSplitterWnd::GetRowCount"
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
  - "CSplitterWnd::GetRowCount"
  - "GetRowCount"
  - "CSplitterWnd.GetRowCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetRowCount method"
  - "CSplitterWnd class, operations"
  - "splitter windows, rows"
  - "counting rows in splitter windows"
ms.assetid: 583d42a5-b18c-4ea7-ad85-ffe904080a41
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSplitterWnd::GetRowCount
Returns the current pane row count.  
  
## Syntax  
  
```  
  
int GetRowCount( ) const;  
```  
  
## Return Value  
 Returns the current number of rows in the splitter window. For a static splitter window, this will also be the maximum number of rows.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CSplitterWnd Class](../vs140/csplitterwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSplitterWnd::GetColumnCount](../vs140/csplitterwnd--getcolumncount.md)