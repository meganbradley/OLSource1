---
title: "CPane::MoveByAlignment"
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
  - "CPane::MoveByAlignment"
  - "CPane.MoveByAlignment"
  - "MoveByAlignment"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MoveByAlignment method"
ms.assetid: dc006322-3de2-433d-a49f-411e2aeda0e0
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::MoveByAlignment
Moves the pane and the virtual rectangle by the specified amount.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies pane alignment.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The amount, in pixels, by which to move the pane and the virtual rectangle.  
  
## Return Value  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> can be any of the following values:  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Enables the pane to be docked to the top of the client area of a frame window.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Enables the pane to be docked to the bottom of the client area of a frame window.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Enables the pane to be docked to the left side of the client area of a frame window.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Enables the pane to be docked to the right side of the client area of a frame window.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Enables the pane to be docked to any side of the client area of a frame window.|  
  
 If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> contains the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> flag, the pane and virtual rectangle are moved horizontally; otherwise, if <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> contains the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> flag, the pane and virtual rectangle are moved vertically.  
  
## Requirements  
 **Header:** afxpane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)