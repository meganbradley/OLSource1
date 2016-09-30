---
title: "CSplitterWnd::Create"
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
  - "CSplitterWnd.Create"
  - "CSplitterWnd::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method [C++]"
  - "splitter windows, creating"
  - "CSplitterWnd class, construction"
ms.assetid: fe64c958-e4c5-4225-9943-d289bbf673c2
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSplitterWnd::Create
To create a dynamic splitter window, call the **Create** member function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The parent frame window of the splitter window.  
  
 *nMaxRows*  
 The maximum number of rows in the splitter window. This value must not exceed 2.  
  
 *nMaxCols*  
 The maximum number of columns in the splitter window. This value must not exceed 2.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the minimum size at which a pane may be displayed.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to a [CCreateContext](../vs140/ccreatecontext-structure.md) structure. In most cases, this can be the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> passed to the parent frame window.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the window style.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The child window ID of the window. The ID can be **AFX_IDW_PANE_FIRST** unless the splitter window is nested inside another splitter window.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 You can embed a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in a parent [CFrameWnd](../vs140/cframewnd-class.md) or [CMDIChildWnd](../vs140/cmdichildwnd-class.md) object by taking the following steps:  
  
1.  Embed a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> member variable in the parent frame.  
  
2.  Override the parent frame's [CFrameWnd::OnCreateClient](../vs140/cframewnd--oncreateclient.md) member function.  
  
3.  Call the **Create** member function from within the overridden <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 When you create a splitter window from within a parent frame, pass the parent frame's <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter to the splitter window. Otherwise, this parameter can be **NULL**.  
  
 The initial minimum row height and column width of a dynamic splitter window are set by the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter. These minimums, which determine whether a pane is too small to be shown in its entirety, can be changed with the [SetRowInfo](../vs140/csplitterwnd--setrowinfo.md) and [SetColumnInfo](../vs140/csplitterwnd--setcolumninfo.md) member functions.  
  
 For more on dynamic splitter windows, see "Splitter Windows" in the article [Multiple Document Types, Views, and Frame Windows](../vs140/multiple-document-types--views--and-frame-windows.md), [Technical Note 29](../vs140/tn029--splitter-windows.md), and the [CSplitterWnd](../vs140/csplitterwnd-class.md) class overview.  
  
## Example  
 [!code[NVC_MFCWindowing#125](../vs140/codesnippet/CPP/csplitterwnd--create_1.cpp)]  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CSplitterWnd Class](../vs140/csplitterwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSplitterWnd::CreateStatic](../vs140/csplitterwnd--createstatic.md)   
 [CFrameWnd::OnCreateClient](../vs140/cframewnd--oncreateclient.md)   
 [CSplitterWnd::SetRowInfo](../vs140/csplitterwnd--setrowinfo.md)   
 [CSplitterWnd::SetColumnInfo](../vs140/csplitterwnd--setcolumninfo.md)   
 [CSplitterWnd::CreateView](../vs140/csplitterwnd--createview.md)