---
title: "CDockablePane::HitTest"
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
  - "HitTest"
  - "CDockablePane.HitTest"
  - "CDockablePane::HitTest"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HitTest method"
ms.assetid: a917d587-1b35-4b25-8c4e-787394894249
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePane::HitTest
Specifies the location in a pane where the user clicks a mouse.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the point to test.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> should be returned if the point is on the pane's caption; otherwise, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Return Value  
 One of the following values:  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is not in the dockable pane.  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is in the client area of the dockable pane.  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is in the caption area of the dockable pane.  
  
-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is on the close button.  
  
-   <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is on the pin button.  
  
## Requirements  
 **Header:** afxDockablePane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)