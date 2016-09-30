---
title: "CSplitterWndEx Class"
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
  - "CSplitterWndEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSplitterWndEx class"
  - "CSplitterWndEx constructor"
ms.assetid: 33e5eef3-05e1-4a07-a968-bf9207ce8598
caps.latest.revision: 23
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSplitterWndEx Class
Represents a customized splitter window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Default constructor.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CSplitterWndEx::OnDrawSplitter](#csplitterwndex__ondrawsplitter)|Called by the framework to draw a splitter window. (Overrides [CSplitterWnd::OnDrawSplitter](../vs140/csplitterwnd-class.md#csplitterwnd__ondrawsplitter).)|  
  
## Remarks  
 Override the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method to customize the appearance of the graphical components of a splitter window.  
  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> class is used together with the [OnDrawSplitterBorder](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondrawsplitterborder), [OnDrawSplitterBox](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondrawsplitterbox), and [OnFillSplitterBackground](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__onfillsplitterbackground) methods, which are implemented by a visual manager. To cause a visual manager to draw a splitter window in your application, replace declarations of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> class with the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> class. For frame window applications, the splitter window class is declared in the CMainFrame class that is located in mainfrm.h. For an example, see the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> sample in the Samples directory.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CSplitterWnd](../vs140/csplitterwnd-class.md)  
  
 [CSplitterWndEx](../vs140/csplitterwndex-class.md)  
  
## Requirements  
 **Header:** afxsplitterwndex.h  
  
##  \<a name="csplitterwndex__ondrawsplitter">\</a>  CSplitterWndEx::OnDrawSplitter  
 Called by the framework to draw a splitter window.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Pointer to the device context. If this parameter is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, the framework redraws the active window.  
  
 [in] <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 One of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> enumeration values that specifies the splitter window element to draw. Valid values are <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 A bounding rectangle that specifies the dimensions and location to draw the specified splitter window element.  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CSplitterWnd Class](../vs140/csplitterwnd-class.md)   
 [CMFCVisualManager](../vs140/cmfcvisualmanager-class.md)