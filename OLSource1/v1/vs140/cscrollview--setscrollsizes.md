---
title: "CScrollView::SetScrollSizes"
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
  - "SetScrollSizes"
  - "CScrollView.SetScrollSizes"
  - "CScrollView::SetScrollSizes"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CScrollView class, operations"
  - "SetScrollSizes method"
ms.assetid: f07e1903-80d3-4162-937a-5f12b75f671a
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CScrollView::SetScrollSizes
Call <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> when the view is about to be updated.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The mapping mode to set for this view. Possible values include:  
  
|Mapping Mode|Logical Unit|Positive y-axis Extends...|  
|------------------|------------------|---------------------------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|1 pixel|Downward|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|0.01 mm|Upward|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|1/1440 in|Upward|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|0.001 in|Upward|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|0.1 mm|Upward|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|0.01 in|Upward|  
  
 All of these modes are defined by Windows. Two standard mapping modes, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, are not used for <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. The class library provides the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> member function for scaling the view to window size. Column three in the table above describes the coordinate orientation.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The total size of the scroll view. The **cx** member contains the horizontal extent. The **cy** member contains the vertical extent. Sizes are in logical units. Both **cx** and **cy** must be greater than or equal to 0.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The horizontal and vertical amounts to scroll in each direction in response to a mouse click in a scroll-bar shaft. The **cx** member contains the horizontal amount. The **cy** member contains the vertical amount.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The horizontal and vertical amounts to scroll in each direction in response to a mouse click in a scroll arrow. The **cx** member contains the horizontal amount. The **cy** member contains the vertical amount.  
  
## Remarks  
 Call it in your override of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> member function to adjust scrolling characteristics when, for example, the document is initially displayed or when it changes size.  
  
 You will typically obtain size information from the view's associated document by calling a document member function, perhaps called <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, that you supply with your derived document class. The following code shows this approach:  
  
 [!code[NVC_MFCDocView#166](../vs140/codesnippet/CPP/cscrollview--setscrollsizes_1.cpp)]  
  
 Alternatively, you might sometimes need to set a fixed size, as in the following code:  
  
 [!code[NVC_MFCDocView#167](../vs140/codesnippet/CPP/cscrollview--setscrollsizes_2.cpp)]  
  
 You must set the mapping mode to any of the Windows mapping modes except <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. If you want to use an unconstrained mapping mode, call the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> member function instead of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
## Example  
 [!code[NVC_MFCDocView#168](../vs140/codesnippet/CPP/cscrollview--setscrollsizes_3.cpp)]  
  
 [!code[NVC_MFCDocView#169](../vs140/codesnippet/CPP/cscrollview--setscrollsizes_4.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CScrollView Class](../vs140/cscrollview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CScrollView::SetScaleToFitSize](../vs140/cscrollview--setscaletofitsize.md)   
 [CScrollView::GetDeviceScrollSizes](../vs140/cscrollview--getdevicescrollsizes.md)   
 [CScrollView::GetTotalSize](../vs140/cscrollview--gettotalsize.md)