---
title: "CMDIFrameWndEx::ShowPane"
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
  - "CMDIFrameWndEx::ShowPane"
  - "ShowPane"
  - "CMDIFrameWndEx.ShowPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ShowPane method"
ms.assetid: 5a6f8822-77ff-4bc6-a67b-7873640d294b
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::ShowPane
Shows or hides the specified pane.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the pane to be shown or hidden.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to show the pane. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to hide the pane.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to delay the recalculation of the docking layout. <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to recalculate the docking layout immediately.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to show the pane should as active. <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to show the pane as inactive.  
  
## Remarks  
 Call this method to show or hide the pane. Do not use <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> for docking panes.  
  
## Example  
 The following example shows how <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is used in the [VisualStudioDemo Sample: MFC Visual Studio Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#16](../vs140/codesnippet/CPP/cmdiframewndex--showpane_1.cpp)]  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)