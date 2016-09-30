---
title: "CSplitterWnd::OnDrawSplitter"
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
  - "OnDrawSplitter"
  - "CSplitterWnd.OnDrawSplitter"
  - "CSplitterWnd::OnDrawSplitter"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawSplitter method"
  - "drawing, splitter windows"
  - "CSplitterWnd class, overridables"
  - "splitter windows, images"
ms.assetid: c4b973c7-db3b-48e4-9acb-2e7d26930a7f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSplitterWnd::OnDrawSplitter
Renders an image of a split window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the device context in which to draw. If <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is **NULL**, then [CWnd::RedrawWindow](../vs140/cwnd--redrawwindow.md) is called by the framework and no split window is drawn.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A value of the **enum ESplitType**, which can be one of the following:  
  
-   **splitBox** The splitter drag box.  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> The bar that appears between the two split windows.  
  
-   **splitIntersection** The intersection of the split windows. This element will not be called when running on Windows 95/98.  
  
-   **splitBorder** The split window borders.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A reference to a [CRect](../vs140/crect-class.md) object specifying the size and shape of the split windows.  
  
## Remarks  
 This member function is called by the framework to draw and specify the exact characteristics of a splitter window. Override <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> for advanced customization of the imagery for the various graphical components of a splitter window. The default imagery is similar to the splitter in Microsoft Works for Windows or Microsoft Windows 95/98, in that the intersections of the splitter bars are blended together.  
  
 For more on dynamic splitter windows, see "Splitter Windows" in the article [Multiple Document Types, Views, and Frame Windows](../vs140/multiple-document-types--views--and-frame-windows.md), [Technical Note 29](../vs140/tn029--splitter-windows.md), and the [CSplitterWnd](../vs140/csplitterwnd-class.md) class overview.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CSplitterWnd Class](../vs140/csplitterwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSplitterWnd::OnInvertTracker](../vs140/csplitterwnd--oninverttracker.md)