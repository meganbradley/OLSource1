---
title: "CMFCToolTipInfo Class"
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
  - "CMFCToolTipInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCToolTipInfo class"
ms.assetid: f9d3d7f8-1f08-4342-a7b2-683860e5d2a5
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolTipInfo Class
Stores information about the visual appearance of tooltips.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCToolTipInfo::operator=](#cmfctooltipinfo__operator_eq)||  
  
### Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCToolTipInfo::m_bBallonTooltip](#cmfctooltipinfo__m_bballoontooltip)|A Boolean variable that indicates whether the tooltip has a balloon appearance.|  
|[CMFCToolTipInfo::m_bBoldLabel](#cmfctooltipinfo__m_bboldlabel)|A Boolean variable that indicates whether tooltip labels are displayed in a bold font.|  
|[CMFCToolTipInfo::m_bDrawDescription](#cmfctooltipinfo__m_bdrawdescription)|A Boolean variable that indicates whether the tooltip contains a description.|  
|[CMFCToolTipInfo::m_bDrawIcon](#cmfctooltipinfo__m_bdrawicon)|A Boolean variable that indicates whether the tooltip contains an icon.|  
|[CMFCToolTipInfo::m_bDrawSeparator](#cmfctooltipinfo__m_bdrawseparator)|A Boolean variable that indicates whether a separator is displayed between the tooltip label and the tooltip description.|  
|[CMFCToolTipInfo::m_bRoundedCorners](#cmfctooltipinfo__m_broundedcorners)|A Boolean variable that indicates whether the tooltip has rounded corners.|  
|[CMFCToolTipInfo::m_bVislManagerTheme](#cmfctooltipinfo__m_bvislmanagertheme)|A Boolean variable that indicates whether the appearance of the tooltip should be controlled by a visual manager (see [CMFCVisualManager](../vs140/cmfcvisualmanager-class.md)).|  
|[CMFCToolTipInfo::m_clrBorder](#cmfctooltipinfo__m_clrborder)|The color of the tooltip border.|  
|[CMFCToolTipInfo::m_clrFill](#cmfctooltipinfo__m_clrfill)|The color of the tooltip background.|  
|[CMFCToolTipInfo::m_clrFillGradient](#cmfctooltipinfo__m_clrfillgradient)|The color of the gradient fill in the tooltip.|  
|[CMFCToolTipInfo::m_clrText](#cmfctooltipinfo__m_clrtext)|The text color in the tooltip.|  
|[CMFCToolTipInfo::m_nGradientAngle](#cmfctooltipinfo__m_ngradientangle)|The angle of the gradient fill in the tooltip.|  
|[CMFCToolTipInfo::m_nMaxDescrWidth](#cmfctooltipinfo__m_nmaxdescrwidth)|The maximum possible width, in pixels, of the description in the tooltip.|  
  
## Remarks  
 Use [CMFCToolTipCtrl](../vs140/cmfctooltipctrl-class.md), <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, and [CTooltipManager](../vs140/ctooltipmanager-class.md) together to implement customized tooltips in your application. For an example of how to use these tooltip classes, see the [CMFCToolTipCtrl](../vs140/cmfctooltipctrl-class.md) topic.  
  
## Example  
 The following example demonstrates how to set the values of the various member variables in the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFC_RibbonApp#42](../vs140/codesnippet/CPP/cmfctooltipinfo-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CMFCToolTipInfo](../vs140/cmfctooltipinfo-class.md)  
  
## Requirements  
 **Header:** afxtooltipctrl.h  
  
##  \<a name="cmfctooltipinfo__m_bballoontooltip">\</a>  CMFCToolTipInfo::m_bBalloonTooltip  
 Specifies the display style of all tooltips.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> indicates that tooltips use the balloon style, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> indicates that tooltips use the rectangular style.  
  
##  \<a name="cmfctooltipinfo__m_bboldlabel">\</a>  CMFCToolTipInfo::m_bBoldLabel  
 Specifies whether the font of the tooltip text is bold.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 Set this member to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to display tooltip text with bold font, or <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> to display tooltip labels with non-bold font.  
  
##  \<a name="cmfctooltipinfo__m_bdrawdescription">\</a>  CMFCToolTipInfo::m_bDrawDescription  
 Specifies whether each tooltip displays description text.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 Set this member to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> to display the description, or <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> to hide the description. You can specify the description on a tooltip by calling [CMFCToolTipCtrl::SetDescription](../vs140/cmfctooltipctrl-class.md#cmfctooltipctrl__setdescription)  
  
##  \<a name="cmfctooltipinfo__m_bdrawicon">\</a>  CMFCToolTipInfo::m_bDrawIcon  
 Specifies whether all tooltips display icons.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 Set this member to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> to display an icon on each tooltip, or <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> to display tooltips without icons.  
  
##  \<a name="cmfctooltipinfo__m_bdrawseparator">\</a>  CMFCToolTipInfo::m_bDrawSeparator  
 Specifies whether each tooltip has a separator between its label and its description.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 Set this member to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> to display separator between tooltip label and description, or <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> to display tooltips with no separator.  
  
##  \<a name="cmfctooltipinfo__m_broundedcorners">\</a>  CMFCToolTipInfo::m_bRoundedCorners  
 Specifies whether all tooltips have rounded corners.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 Set this member to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> to display rounded corners on tooltips, or <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> to display rectangular corners on tooltips.  
  
##  \<a name="cmfctooltipinfo__m_clrborder">\</a>  CMFCToolTipInfo::m_clrBorder  
 Specifies the color of the borders on all tooltips.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="cmfctooltipinfo__m_clrfill">\</a>  CMFCToolTipInfo::m_clrFill  
 Specifies the color of tooltip backgrounds.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
 If [CMFCToolTipInfo::m_clrFillGradient](#cmfctooltipinfo__m_clrfillgradient) is -1, the tooltip background color is <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. Otherwise, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> specifies the color of the beginning of the gradient and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> specifies the color of the end of the gradient. [CMFCToolTipInfo::m_nGradientAngle](#cmfctooltipinfo__m_ngradientangle) determines the direction of the gradient.  
  
##  \<a name="cmfctooltipinfo__m_clrfillgradient">\</a>  CMFCToolTipInfo::m_clrFillGradient  
 Specifies the end color for a gradient background for tooltips.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 If <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is -1, there is no gradient. Otherwise, the gradient initial color is specified by [CMFCToolTipInfo::m_clrFill](#cmfctooltipinfo__m_clrfill) and the gradient finish color is specified by <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>. [CMFCToolTipInfo::m_nGradientAngle](#cmfctooltipinfo__m_ngradientangle) determines the direction of the gradient.  
  
##  \<a name="cmfctooltipinfo__m_clrtext">\</a>  CMFCToolTipInfo::m_clrText  
 Specifies text color of all tooltips.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
##  \<a name="cmfctooltipinfo__m_ngradientangle">\</a>  CMFCToolTipInfo::m_nGradientAngle  
 Specifies the angle at which a gradient is drawn on the background of tooltips.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> specifies the angle, in degrees, that the gradient on the background of tooltips is offset from horizontal. If <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is 0, the gradient is drawn from left to right. If <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is between 1 and 360, the gradient is rotating clockwise by that number of degrees. If <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is -1, which is the default value, the gradient is drawn from top to bottom. This is the same as setting <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> to 90.  
  
 [CMFCToolTipInfo::m_clrFill](#cmfctooltipinfo__m_clrfill)  <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> specifies the color of the beginning of the gradient and [CMFCToolTipInfo::m_clrFillGradient](#cmfctooltipinfo__m_clrfillgradient) <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> specifies the color of the end of the gradient. If <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> is -1, there is no gradient.  
  
##  \<a name="cmfctooltipinfo__m_nmaxdescrwidth">\</a>  CMFCToolTipInfo::m_nMaxDescrWidth  
 Specifies the maximum width of the description that it displayed in each tooltip. If the description width exceeds the specified value, the text is wrapped.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
##  \<a name="cmfctooltipinfo__m_bvislmanagertheme">\</a>  CMFCToolTipInfo::m_bVislManagerTheme  
 Specifies whether the visual manager of the application controls the appearance of all tooltips.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Remarks  
 If <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, every tooltip requests a new [CMFCToolTipInfo](../vs140/cmfctooltipinfo-class.md) from the visual manager of the application before they appear on the screen, and uses the values in that object to determine their appearance. The other members of your [CMFCToolTipInfo](../vs140/cmfctooltipinfo-class.md) are ignored.  
  
##  \<a name="cmfctooltipinfo__operator_eq">\</a>  CMFCToolTipInfo::operator=  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CTooltipManager](../vs140/ctooltipmanager-class.md)   
 [CMFCToolTipCtrl](../vs140/cmfctooltipctrl-class.md)