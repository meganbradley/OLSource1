---
title: "CMFCRibbonSlider Class"
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
  - "CMFCRibbonSlider"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonSlider class"
ms.assetid: 9351ac34-f234-4e42-91e2-763f1989c8ff
caps.latest.revision: 42
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonSlider Class
The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> class implements a slider control that you can add to a ribbon bar or ribbon status bar. The ribbon slider control resembles the zoom sliders that appear in Office 2007 applications.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonSlider::CMFCPRibbonSlider](#cmfcribbonslider__cmfcribbonslider)|Constructs and initializes a ribbon slider control.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonSlider::GetPos](#cmfcribbonslider__getpos)|Returns the current position of the slider control.|  
|[CMFCRibbonSlider::GetRangeMax](#cmfcribbonslider__getrangemax)|Returns the maximum value of the slider.|  
|[CMFCRibbonSlider::GetRangeMin](#cmfcribbonslider__getrangemin)|Returns the minimum value of the slider.|  
|[CMFCRibbonSlider::GetRegularSize](#cmfcribbonslider__getregularsize)|Returns the regular size of the ribbon element. (Overrides [CMFCRibbonBaseElement::GetRegularSize](../vs140/cmfcribbonbaseelement-class.md#cmfcribbonbaseelement__getregularsize).)|  
|[CMFCRibbonSlider::GetZoomIncrement](#cmfcribbonslider__getzoomincrement)|Returns the size of the zoom increment for the slider control.|  
|[CMFCRibbonSlider::HasZoomButtons](#cmfcribbonslider__haszoombuttons)|Specifies whether the slider has zoom buttons.|  
|[CMFCRibbonSlider::OnDraw](#cmfcribbonslider__ondraw)|Called by the framework to draw the ribbon element. (Overrides [CMFCRibbonBaseElement::OnDraw](../vs140/cmfcribbonbaseelement-class.md#cmfcribbonbaseelement__ondraw).)|  
|[CMFCRibbonSlider::SetPos](#cmfcribbonslider__setpos)|Sets the current position of the slider control.|  
|[CMFCRibbonSlider::SetRange](#cmfcribbonslider__setrange)|Specifies the range of the slider control by setting the minimum and maximum values.|  
|[CMFCRibbonSlider::SetZoomButtons](#cmfcribbonslider__setzoombuttons)|Shows or hides the zoom buttons.|  
|[CMFCRibbonSlider::SetZoomIncrement](#cmfcribbonslider__setzoomincrement)|Sets size of the zoom increment for the slider control.|  
  
## Remarks  
 You can use the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> method to configure the range of zoom increments for the slider. You can set current position of the slider by using the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> method.  
  
 You can display circular zoom buttons on the left and right side of the slider control by using the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> method. By default, the slider is horizontal, the left zoom button displays a minus sign and the right zoom button displays a plus sign.  
  
 The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> method defines the increment to add to or subtract from the current position when a user clicks the zoom buttons.  
  
## Example  
 The following example demonstrates how to use various methods in the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> class to set the properties of the slider. The example shows how to construct a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object, display zoom buttons, set the current position of the slider control, and set the range of values for the slider control.  
  
 [!code[NVC_MFC_RibbonApp#12](../vs140/codesnippet/CPP/cmfcribbonslider-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMFCRibbonBaseElement](../vs140/cmfcribbonbaseelement-class.md)  
  
 [CMFCRibbonSlider](../vs140/cmfcribbonslider-class.md)  
  
## Requirements  
 **Header:** afxribbonslider.h  
  
##  \<a name="cmfcribbonslider__cmfcribbonslider">\</a>  CMFCRibbonSlider::CMFCRibbonSlider  
 Construct a ribbon slider.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 Slider ID.  
  
 [in]. <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 Slider width in pixels.  
  
### Remarks  
 Constructs a ribbon slider that is <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> pixels wide in the panel category where the slider is added. By default, the slider is horizontal.  
  
##  \<a name="cmfcribbonslider__getpos">\</a>  CMFCRibbonSlider::GetPos  
 Returns the current position of the slider control.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 The current position of the slider control, which is a position relative to the beginning of the slider.  
  
##  \<a name="cmfcribbonslider__getrangemax">\</a>  CMFCRibbonSlider::GetRangeMax  
 Obtains the maximum increment of the slider that the slider can travel on the slider control.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 The maximum increment of the slider that the slider can travel on the slider control.  
  
##  \<a name="cmfcribbonslider__getrangemin">\</a>  CMFCRibbonSlider::GetRangeMin  
 Returns the minimum increment that the slider can travel on the slider control.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The minimum increment that the slider can travel on the slider control.  
  
##  \<a name="cmfcribbonslider__getregularsize">\</a>  CMFCRibbonSlider::GetRegularSize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonslider__getzoomincrement">\</a>  CMFCRibbonSlider::GetZoomIncrement  
 Obtain the zoom increment for the slider control.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 The zoom increment for the slider control.  
  
##  \<a name="cmfcribbonslider__haszoombuttons">\</a>  CMFCRibbonSlider::HasZoomButtons  
 Specifies whether the slider has zoom buttons.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> if the slider has zoom buttons; <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cmfcribbonslider__ondraw">\</a>  CMFCRibbonSlider::OnDraw  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcribbonslider__setpos">\</a>  CMFCRibbonSlider::SetPos  
 Set the current position of the slider control.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Specifies the position to set for the slider. The position is relative to the beginning of the slider.  
  
 [in] <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, the slider will be redrawn.  
  
##  \<a name="cmfcribbonslider__setrange">\</a>  CMFCRibbonSlider::SetRange  
 Set the range of values for the slider control.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 Specifies minimum value of the slider control.  
  
 [in] <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 Specifies maximum value of the slider control.  
  
### Remarks  
 Specifies the range of values for the slider control by setting the minimum and maximum values.  
  
##  \<a name="cmfcribbonslider__setzoombuttons">\</a>  CMFCRibbonSlider::SetZoomButtons  
 Display or hide zoom buttons.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in]. <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> to display zoom buttons; <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> to hide them.  
  
##  \<a name="cmfcribbonslider__setzoomincrement">\</a>  CMFCRibbonSlider::SetZoomIncrement  
 Set the zoom increment for the slider control.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 Specifies the zoom increment of the slider control.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCRibbonBaseElement Class](../vs140/cmfcribbonbaseelement-class.md)