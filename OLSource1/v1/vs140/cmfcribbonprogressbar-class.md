---
title: "CMFCRibbonProgressBar Class"
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
  - "CMFCRibbonProgressBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonProgressBar class"
ms.assetid: de3d9f2e-ed59-480e-aa7d-08a33ab36c67
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonProgressBar Class
Implements a control that visually indicates the progress of a lengthy operation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonProgressBar::CMFCRibbonProgressBar](#cmfcribbonprogressbar__cmfcribbonprogressbar)|Constructs and initializes a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonProgressBar::GetPos](#cmfcribbonprogressbar__getpos)|Returns the current progress.|  
|[CMFCRibbonProgressBar::GetRangeMax](#cmfcribbonprogressbar__getrangemax)|Returns the maximum value of the current range.|  
|[CMFCRibbonProgressBar::GetRangeMin](#cmfcribbonprogressbar__getrangemin)|Returns the minimum value of the current range.|  
|[CMFCRibbonProgressBar::GetRegularSize](#cmfcribbonprogressbar__getregularsize)|Returns the regular size of the ribbon element. (Overrides [CMFCRibbonBaseElement::GetRegularSize](../vs140/cmfcribbonbaseelement-class.md#cmfcribbonbaseelement__getregularsize).)|  
|[CMFCRibbonProgressBar::IsInfiniteMode](#cmfcribbonprogressbar__isinfinitemode)|Specifies whether the progress bar is working in infinite mode.|  
|[CMFCRibbonProgressBar::OnDraw](#cmfcribbonprogressbar__ondraw)|Called by the framework to draw the ribbon element. (Overrides [CMFCRibbonBaseElement::OnDraw](../vs140/cmfcribbonbaseelement-class.md#cmfcribbonbaseelement__ondraw).)|  
|[CMFCRibbonProgressBar::SetInfiniteMode](#cmfcribbonprogressbar__setinfinitemode)|Sets the progress bar to work in infinite mode.|  
|[CMFCRibbonProgressBar::SetPos](#cmfcribbonprogressbar__setpos)|Sets the current progress.|  
|[CMFCRibbonProgressBar::SetRange](#cmfcribbonprogressbar__setrange)|Sets the minimum and maximum values.|  
  
## Remarks  
 A <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> can operate in two modes: regular and infinite. In regular mode, the progress bar is filled from left to right and stops when it reaches the maximum value. In infinite mode, the progress bar is repeatedly filled from the minimum value to the maximum value. You might use infinite mode to indicate that an operation is ongoing, but that the completion time is unknown.  
  
## Example  
 The following example demonstrates how to use various methods in the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> class. The example shows how to set the progress bar to work in infinite mode (where the completion time of an operation is unknown), set the minimum and maximum values for the progress bar, and set the current position of the progress bar. This code snippet is part of the [MS Office 2007 Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_MSOffice2007Demo#11](../vs140/codesnippet/CPP/cmfcribbonprogressbar-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMFCRibbonBaseElement](../vs140/cmfcribbonbaseelement-class.md)  
  
 [CMFCRibbonProgressBar](../vs140/cmfcribbonprogressbar-class.md)  
  
## Requirements  
 **Header:** afxRibbonProgressBar.h  
  
##  \<a name="cmfcribbonprogressbar__cmfcribbonprogressbar">\</a>  CMFCRibbonProgressBar::CMFCRibbonProgressBar  
 Constructs and initializes a [CMFCRibbonProgressBar](../vs140/cmfcribbonprogressbar-class.md) object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Specifies the command ID for the ribbon progress bar.  
  
 [in] <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Specifies the width, in pixels, of the ribbon progress bar.  
  
 [in] <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Specifies the height, in pixels, of the ribbon progress bar.  
  
##  \<a name="cmfcribbonprogressbar__getpos">\</a>  CMFCRibbonProgressBar::GetPos  
 Returns the current position of the progress bar.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 A value representing the current position of the progress bar.  
  
### Remarks  
 The range being set must be within the range specified by the [CMFCRibbonProgressBar::SetRange](#cmfcribbonprogressbar__setrange) method.  
  
##  \<a name="cmfcribbonprogressbar__getrangemax">\</a>  CMFCRibbonProgressBar::GetRangeMax  
 Returns the progress bar's current maximum value.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 The maximum value of the current range.  
  
### Remarks  
  
##  \<a name="cmfcribbonprogressbar__getrangemin">\</a>  CMFCRibbonProgressBar::GetRangeMin  
 Returns the progress bar's current minimum range value.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The minimum value of the current range.  
  
##  \<a name="cmfcribbonprogressbar__getregularsize">\</a>  CMFCRibbonProgressBar::GetRegularSize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonprogressbar__isinfinitemode">\</a>  CMFCRibbonProgressBar::IsInfiniteMode  
 Specifies whether the progress bar is working in infinite mode.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> if the progress bar is in infinite mode; otherwise, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
### Remarks  
 In infinite mode, the progress bar fills repeatedly from the minimum value to the maximum value. You might use infinite mode to indicate that an operation is ongoing, but that the completion time is unknown.  
  
##  \<a name="cmfcribbonprogressbar__ondraw">\</a>  CMFCRibbonProgressBar::OnDraw  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcribbonprogressbar__setinfinitemode">\</a>  CMFCRibbonProgressBar::SetInfiniteMode  
 Sets the progress bar to work in infinite mode.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> to specify that the progress bar is in infinite mode; otherwise, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
### Remarks  
 Usually, if the progress bar is in infinite mode, it is telling the user that an operation is ongoing, but that the completion time is unknown. Thus, the progress bar fills repeatedly from the minimum value to the maximum value.  
  
##  \<a name="cmfcribbonprogressbar__setpos">\</a>  CMFCRibbonProgressBar::SetPos  
 Sets the current position of the progress bar.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 Specifies the position to which the progress bar is set.  
  
 [in] <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Specifies whether the progress bar should be redrawn.  
  
### Remarks  
 The range being set must be within the range specified by the [CMFCRibbonProgressBar::SetRange](#cmfcribbonprogressbar__setrange) method.  
  
##  \<a name="cmfcribbonprogressbar__setrange">\</a>  CMFCRibbonProgressBar::SetRange  
 Sets the minimum and maximum values for the progress bar.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 Specifies the minimum value of the range.  
  
 [in] <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Specifies the maximum value of the range.  
  
### Remarks  
 Use this method to define the range of the progress bar by setting minimum and maximum values.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCRibbonBaseElement Class](../vs140/cmfcribbonbaseelement-class.md)   
 [CMFCRibbonBar](../vs140/cmfcribbonbar-class.md)