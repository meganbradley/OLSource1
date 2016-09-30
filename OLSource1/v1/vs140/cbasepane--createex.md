---
title: "CBasePane::CreateEx"
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
  - "CreateEx"
  - "CBasePane::CreateEx"
  - "CBasePane.CreateEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateEx method"
ms.assetid: 6196c8e8-89a7-4960-9044-cac9e4c5f41c
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::CreateEx
Creates the pane control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The extended styles (see [CWnd::CreateEx](../vs140/cwnd--createex.md) for more information).  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The window class name.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The window name.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The window style (see [CWnd::CreateEx](../vs140/cwnd--createex.md)).  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The initial rectangle.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A pointer to the parent window.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies the pane ID. Must be unique.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Style flags for panes.  
  
 [in] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A pointer to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
## Return Value  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> if the pane is created successfully; otherwise <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Remarks  
 Creates a window of class <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. If you specify <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, this method clears the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> style bit and sets <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, because the library does not support panes with captions.  
  
 You can use any combination of child window styles and MFC control bar (CBRS_) styles.  
  
 The library adds several new styles for panes. The following table describes the new styles:  
  
|Style|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|The pane can float.|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|The pane supports auto-hide mode|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|The pane can be resized. **Important:**  This style is not implemented.|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|The pane can be closed.|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|The pane can be rolled up when it floats.|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|When one pane docks to another pane that has this style, a regular tabbed window is created. (For more information, see [CTabbedPane Class](../vs140/ctabbedpane-class.md).)|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|When one pane docks to another pane that has this style, an Outlook-style tabbed window is created. (For more information, see [CMFCOutlookBar Class](../vs140/cmfcoutlookbar-class.md).)|  
  
 To use the new styles, specify them in <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)