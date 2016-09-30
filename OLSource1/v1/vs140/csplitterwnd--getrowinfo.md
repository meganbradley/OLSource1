---
title: "CSplitterWnd::GetRowInfo"
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
  - "CSplitterWnd::GetRowInfo"
  - "CSplitterWnd.GetRowInfo"
  - "GetRowInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSplitterWnd class, operations"
  - "GetRowInfo method"
  - "splitter windows, rows"
ms.assetid: a08ef0c8-e921-4c80-9a8c-720ea1ad3e3e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSplitterWnd::GetRowInfo
Returns information on the specified row.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies a row.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Reference to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to be set to the current height of the row in pixels.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Reference to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to be set to the current minimum height of the row in pixels.  
  
## Remarks  
 Call this member function to obtain information about the specified row. The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter is filled with the current height of the specified row, and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is filled with the minimum height of the row.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CSplitterWnd Class](../vs140/csplitterwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSplitterWnd::SetRowInfo](../vs140/csplitterwnd--setrowinfo.md)   
 [CSplitterWnd::GetColumnInfo](../vs140/csplitterwnd--getcolumninfo.md)