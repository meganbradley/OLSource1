---
title: "CMDIFrameWndEx::InsertPane"
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
  - "CMDIFrameWndEx.InsertPane"
  - "CMDIFrameWndEx::InsertPane"
  - "InsertPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InsertPane method"
ms.assetid: 39f99e98-4af2-45b8-8f4c-8dc559d8541f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::InsertPane
Registers the specified pane with the docking manager.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the pane to be inserted.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the pane before or after which to insert the pane.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is inserted after <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is inserted before <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Return Value  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> if the method successfully registers the pane, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> if the pane was already registered with the docking manager.  
  
## Remarks  
 Use this method to tell the docking manager about a pane specified by <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. The docking manager will align this pane according to the pane's alignment and position in the docking manager's internal list.  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDockingManager Class](../vs140/cdockingmanager-class.md)