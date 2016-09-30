---
title: "CControlBar::CalcDynamicLayout"
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
  - "LM_COMMIT"
  - "LM_VERTDOCK"
  - "LM_LENGTHY"
  - "CalcDynamicLayout"
  - "CControlBar.CalcDynamicLayout"
  - "LM_MRUNWIDTH"
  - "LM_HORZ"
  - "CControlBar::CalcDynamicLayout"
  - "LM_STRETCH"
  - "LM_HORZDOCK"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CControlBar class, attributes"
  - "LM_VERTDOCK constant"
  - "LM_HORZ constant"
  - "LM_STRETCH constant"
  - "LM_HORZDOCK constant"
  - "CalcDynamicLayout method"
  - "LM_MRUNWIDTH constant"
  - "LM_COMMIT constant"
  - "LM_LENGTHY constant"
ms.assetid: 03050a3c-0f34-4482-91fd-397b33e5b4a7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CControlBar::CalcDynamicLayout
The framework calls this member function to calculate the dimensions of a dynamic toolbar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The requested dimension of the control bar, either horizontal or vertical, depending on <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The following predefined flags are used to determine the height and width of the dynamic control bar. Use the bitwise-OR (&#124;) operator to combine the flags.  
  
|Layout mode flags|What it means|  
|-----------------------|-------------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Indicates whether the control bar should be stretched to the size of the frame. Set if the bar is not a docking bar (not available for docking). Not set when the bar is docked or floating (available for docking). If set, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> ignores <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and returns dimensions based on the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> state. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> works similarly to the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter used in [CalcFixedLayout](../vs140/ccontrolbar--calcfixedlayout.md); see that member function for more information about the relationship between stretching and orientation.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Indicates that the bar is horizontally or vertically oriented. Set if the bar is horizontally oriented, and if it is vertically oriented, it is not set. <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> works similarly to the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter used in [CalcFixedLayout](../vs140/ccontrolbar--calcfixedlayout.md); see that member function for more information about the relationship between stretching and orientation.|  
|**LM_MRUWIDTH**|Most Recently Used Dynamic Width. Ignores <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameter and uses the remembered most recently used width.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Horizontal Docked Dimensions. Ignores <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameter and returns the dynamic size with the largest width.|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Vertical Docked Dimensions. Ignores <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> parameter and returns the dynamic size with the largest height.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Set if <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> indicates height (Y-direction) instead of width.|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Resets **LM_MRUWIDTH** to current width of floating control bar.|  
  
## Return Value  
 The control bar size, in pixels, of a [CSize](../vs140/csize-class.md) object.  
  
## Remarks  
 Override this member function to provide your own dynamic layout in classes you derive from <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. MFC classes derived from <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, such as [CToolbar](../vs140/ctoolbar-class.md), override this member function and provide their own implementation.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CControlBar Class](../vs140/ccontrolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CControlBar::CalcFixedLayout](../vs140/ccontrolbar--calcfixedlayout.md)   
 [CToolBar Class](../vs140/ctoolbar-class.md)