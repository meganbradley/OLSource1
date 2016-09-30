---
title: "CSplitterWnd::CreateStatic"
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
  - "CreateStatic"
  - "CSplitterWnd.CreateStatic"
  - "CSplitterWnd::CreateStatic"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "static splitter windows"
  - "splitter windows, constructing"
  - "CSplitterWnd class, construction"
  - "CreateStatic method"
ms.assetid: d3f22381-146f-4080-8aa3-3d5dba6223dd
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSplitterWnd::CreateStatic
To create a static splitter window, call the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The parent frame window of the splitter window.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The number of rows. This value must not exceed 16.  
  
 *nCols*  
 The number of columns. This value must not exceed 16.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the window style.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The child window ID of the window. The ID can be **AFX_IDW_PANE_FIRST** unless the splitter window is nested inside another splitter window.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 A <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is usually embedded in a parent <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or [CMDIChildWnd](../vs140/cmdichildwnd-class.md) object by taking the following steps:  
  
1.  Embed a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> member variable in the parent frame.  
  
2.  Override the parent frame's <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> member function.  
  
3.  Call the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> member function from within the overridden [CFrameWnd::OnCreateClient](../vs140/cframewnd--oncreateclient.md).  
  
 A static splitter window contains a fixed number of panes, often from different classes.  
  
 When you create a static splitter window, you must at the same time create all its panes. The [CreateView](../vs140/csplitterwnd--createview.md) member function is usually used for this purpose, but you can create other nonview classes as well.  
  
 The initial minimum row height and column width for a static splitter window is 0. These minimums, which determine when a pane is too small to be shown in its entirety, can be changed with the [SetRowInfo](../vs140/csplitterwnd--setrowinfo.md) and [SetColumnInfo](../vs140/csplitterwnd--setcolumninfo.md) member functions.  
  
 To add scroll bars to a static splitter window, add the **WS_HSCROLL** and **WS_VSCROLL** styles to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 See "Splitter Windows" in the article [Multiple Document Types, Views, and Frame Windows](../vs140/multiple-document-types--views--and-frame-windows.md), [Technical Note 29](../vs140/tn029--splitter-windows.md), and the [CSplitterWnd](../vs140/csplitterwnd-class.md) class overview for more on static splitter windows.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CSplitterWnd Class](../vs140/csplitterwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSplitterWnd::Create](../vs140/csplitterwnd--create.md)   
 [CFrameWnd::OnCreateClient](../vs140/cframewnd--oncreateclient.md)   
 [CSplitterWnd::SetRowInfo](../vs140/csplitterwnd--setrowinfo.md)   
 [CSplitterWnd::SetColumnInfo](../vs140/csplitterwnd--setcolumninfo.md)   
 [CSplitterWnd::CreateView](../vs140/csplitterwnd--createview.md)