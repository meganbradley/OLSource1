---
title: "CSplitterWnd::OnInvertTracker"
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
  - "CSplitterWnd.OnInvertTracker"
  - "CSplitterWnd::OnInvertTracker"
  - "OnInvertTracker"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSplitterWnd class, overridables"
  - "OnInvertTracker method"
  - "splitter windows, images"
ms.assetid: 191b4b51-72f7-4b79-a05f-acade256d74c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSplitterWnd::OnInvertTracker
Renders the image of a split window to be the same size and shape as the frame window.  
  
## Syntax  
  
```  
  
      virtual void OnInvertTracker(  
   const CRect& rect   
);  
```  
  
#### Parameters  
 `rect`  
 Reference to a `CRect` object specifying the tracking rectangle.  
  
## Remarks  
 This member function is called by the framework during resizing of splitters. Override `OnInvertTracker` for advanced customization of the imagery of the splitter window. The default imagery is similar to the splitter in Microsoft Works for Windows or Microsoft Windows 95/98, in that the intersections of the splitter bars are blended together.  
  
 For more on dynamic splitter windows, see "Splitter Windows" in the article [Multiple Document Types, Views, and Frame Windows](../vs140/multiple-document-types--views--and-frame-windows.md), [Technical Note 29](../vs140/tn029--splitter-windows.md), and the [CSplitterWnd](../vs140/csplitterwnd-class.md) class overview.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CSplitterWnd Class](../vs140/csplitterwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSplitterWnd::OnDrawSplitter](../vs140/csplitterwnd--ondrawsplitter.md)