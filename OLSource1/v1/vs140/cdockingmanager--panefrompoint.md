---
title: "CDockingManager::PaneFromPoint"
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
  - "PaneFromPoint"
  - "CDockingManager.PaneFromPoint"
  - "CDockingManager::PaneFromPoint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PaneFromPoint method"
ms.assetid: f1dec025-30b2-4fea-9106-7b7357a7f0f1
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingManager::PaneFromPoint
Returns the pane that contains the given point.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the point, in screen coordinates, to check.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The value to inflate the window rectangle of each checked pane. A pane satisfies the search criteria if the given point is in this inflated region.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to ignore the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter; otherwise, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 If not <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, the method searches only the panes of the specified type.  
  
 [in] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to check only visible panes; otherwise, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 [out] <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 If a pane is found at the specified point, this parameter contains the side of the pane that was closest to the specified point. For more information, see the Remarks section.  
  
 [in] <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 If not <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, the method ignores panes specified by this parameter.  
  
## Return Value  
 The [CBasePane](../vs140/cbasepane-class.md)-derived object that contains the given point, or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> if no pane was found.  
  
## Remarks  
 When the function returns and a pane was found, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> contains the alignment of the specified point. For example, if the point was closest to the top of the pane, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxDockingManager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)