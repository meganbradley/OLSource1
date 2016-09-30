---
title: "CMFCPropertyGridToolTipCtrl Class"
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
  - "CMFCPropertyGridToolTipCtrl::PreTranslateMessage"
  - "~CMFCPropertyGridToolTipCtrl"
  - "PreTranslateMessage"
  - "CMFCPropertyGridToolTipCtrl.~CMFCPropertyGridToolTipCtrl"
  - "CMFCPropertyGridToolTipCtrl"
  - "CMFCPropertyGridToolTipCtrl.PreTranslateMessage"
  - "CMFCPropertyGridToolTipCtrl::~CMFCPropertyGridToolTipCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCPropertyGridToolTipCtrl class"
  - "CMFCPropertyGridToolTipCtrl class, destructor"
  - "PreTranslateMessage method"
  - "~CMFCPropertyGridToolTipCtrl destructor"
ms.assetid: 84b436e5-6695-4da0-9569-1a875e087711
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridToolTipCtrl Class
Implements a tooltip control that the [CMFCPropertyGridCtrl Class](../vs140/cmfcpropertygridctrl-class.md) uses to display tooltips.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|||  
|-|-|  
|Name|Description|  
|[CMFCPropertyGridToolTipCtrl::CMFCPropertyGridToolTipCtrl](#cmfcpropertygridtooltipctrl__cmfcpropertygridtooltipctrl)|Constructs a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|||  
|-|-|  
|Name|Description|  
|[CMFCPropertyGridToolTipCtrl::Create](#cmfcpropertygridtooltipctrl__create)|Creates a window for the tooltip control.|  
|[CMFCPropertyGridToolTipCtrl::Deactivate](#cmfcpropertygridtooltipctrl__deactivate)|Deactivates and hides the tooltip control.|  
|[CMFCPropertyGridToolTipCtrl::GetLastRect](#cmfcpropertygridtooltipctrl__getlastrect)|Returns the coordinates of the last position of the tooltip control.|  
|[CMFCPropertyGridToolTipCtrl::Hide](#cmfcpropertygridtooltipctrl__hide)|Hides the tooltip control.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Used by class [CWinApp](../vs140/cwinapp-class.md) to translate window messages before they are dispatched to the                                         [TranslateMessage](http://msdn.microsoft.com/library/windows/desktop/ms644955) and                                         [DispatchMessage](http://msdn.microsoft.com/library/windows/desktop/ms644934) Windows functions. (Overrides [CWnd::PreTranslateMessage](../vs140/cwnd-class.md#cwnd__pretranslatemessage).)|  
|[CMFCPropertyGridToolTipCtrl::SetTextMargin](#cmfcpropertygridtooltipctrl__settextmargin)|Sets the spacing between the tooltip text and the border of the tooltip window.|  
|[CMFCPropertyGridToolTipCtrl::Track](#cmfcpropertygridtooltipctrl__track)|Displays the tooltip control.|  
  
## Remarks  
 Tooltips are displayed when the pointer rests on a property name. The [CMFCPropertyGridToolTipCtrl](../vs140/cmfcpropertygridtooltipctrl-class.md) class displays a tooltip so that it is easily readable by the user. Usually, the position of a tooltip is determined by the position of the pointer. By using this class, the tooltip appears over the property name and resembles the natural property extension, so that the property name is fully visible.  
  
 MFC automatically creates this control and uses it in the [CMFCPropertyGridCtrl Class](../vs140/cmfcpropertygridctrl-class.md).  
  
## Example  
 The following example demonstrates how to construct an object of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> class, and how to display the tooltip control.  
  
 [!code[NVC_MFC_RibbonApp#23](../vs140/codesnippet/CPP/cmfcpropertygridtooltipctrl-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CMFCPropertyGridToolTipCtrl](../vs140/cmfcpropertygridtooltipctrl-class.md)  
  
## Requirements  
 **Header:** afxpropertygridtooltipctrl.h  
  
##  \<a name="cmfcpropertygridtooltipctrl__cmfcpropertygridtooltipctrl">\</a>  CMFCPropertyGridToolTipCtrl::CMFCPropertyGridToolTipCtrl  
 Constructs a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="cmfcpropertygridtooltipctrl__create">\</a>  CMFCPropertyGridToolTipCtrl::Create  
 Creates a window for the tooltip control.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 A pointer to the parent window.  
  
### Return Value  
 TRUE if the window was successfully created; otherwise, FALSE.  
  
##  \<a name="cmfcpropertygridtooltipctrl__deactivate">\</a>  CMFCPropertyGridToolTipCtrl::Deactivate  
 Deactivates and hides the tooltip control.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 This method sets the last position and text to empty values, so that future calls to [CMFCPropertyGridToolTipCtrl::Track](#cmfcpropertygridtooltipctrl__track) display the tooltip.  
  
##  \<a name="cmfcpropertygridtooltipctrl__getlastrect">\</a>  CMFCPropertyGridToolTipCtrl::GetLastRect  
 Returns the coordinates of the last position of the tooltip control.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Contains the last position of the tooltip control.  
  
##  \<a name="cmfcpropertygridtooltipctrl__hide">\</a>  CMFCPropertyGridToolTipCtrl::Hide  
 Hides the tooltip control.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="cmfcpropertygridtooltipctrl__settextmargin">\</a>  CMFCPropertyGridToolTipCtrl::SetTextMargin  
 Sets the spacing between the tooltip text and the border of the tooltip window.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Specifies the spacing between the tooltip control text and the border of the tooltip window. The default value is 10 pixels.  
  
##  \<a name="cmfcpropertygridtooltipctrl__track">\</a>  CMFCPropertyGridToolTipCtrl::Track  
 Displays the tooltip control.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Specifies the position and size of the tooltip control.  
  
 [in] <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Specifies the text to be shown in the tooltip.  
  
### Remarks  
 This method displays the tooltip control at the position and size specified by <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. If the position, size, and text have not changed since the last time this method was called, this method has no effect.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)