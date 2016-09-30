---
title: "CBasePane::PaneFromPoint"
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
  - "CBasePane::PaneFromPoint"
  - "PaneFromPoint"
  - "CBasePane.PaneFromPoint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PaneFromPoint method"
ms.assetid: a7f4ea80-b395-4187-9286-049f708672a3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::PaneFromPoint
Returns the pane that contains the given point.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the point, in screen coordinates, to check.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Increase the search area by this amount. A pane will satisfy the search criteria if the given point falls in the increased area.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to ignore the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter; otherwise, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 If not <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, the method searches only panes of the specified type.  
  
## Return Value  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>-derived object that contains the given point, or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> if no pane was found.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)