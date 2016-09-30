---
title: "CMFCToolTipCtrl Class"
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
  - "CMFCToolTipCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCToolTipCtrl class"
ms.assetid: 9fbfcfb1-a8ab-417f-ae29-9a9ca85ee58f
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolTipCtrl Class
An extended tooltip implementation based on the [CToolTipCtrl Class](../vs140/ctooltipctrl-class.md). A tooltip based on the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> class can display an icon, a label, and a description. You can customize its visual appearance by using a gradient fill, custom text and border colors, bold text, rounded corners, or a balloon style.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Default constructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCToolTipCtrl::GetIconSize](#cmfctooltipctrl__geticonsize)|Returns the size of an icon in a tooltip.|  
|[CMFCToolTipCtrl::GetParams](#cmfctooltipctrl__getparams)|Returns the display settings of a tooltip.|  
|[CMFCToolTipCtrl::OnDrawBorder](#cmfctooltipctrl__ondrawborder)|Draws the border of a tooltip.|  
|[CMFCToolTipCtrl::OnDrawDescription](#cmfctooltipctrl__ondrawdescription)||  
|[CMFCToolTipCtrl::OnDrawIcon](#cmfctooltipctrl__ondrawicon)|Displays an icon in a tooltip.|  
|[CMFCToolTipCtrl::OnDrawLabel](#cmfctooltipctrl__ondrawlabel)|Draws the label of a tooltip, or calculates the size of the label.|  
|[CMFCToolTipCtrl::OnDrawSeparator](#cmfctooltipctrl__ondrawseparator)|Draws the separator between the label and the description in a tooltip.|  
|[CMFCToolTipCtrl::OnFillBackground](#cmfctooltipctrl__onfillbackground)|Fills the tooltip background.|  
|[CMFCToolTipCtrl::SetDescription](#cmfctooltipctrl__setdescription)|Sets the description to be displayed by the tooltip.|  
|[CMFCToolTipCtrl::SetFixedWidth](#cmfctooltipctrl__setfixedwidth)||  
|[CMFCToolTipCtrl::SetHotRibbonButton](#cmfctooltipctrl__sethotribbonbutton)||  
|[CMFCToolTipCtrl::SetLocation](#cmfctooltipctrl__setlocation)||  
|[CMFCToolTipCtrl::SetParams](#cmfctooltipctrl__setparams)|Specifies the visual appearance of a tooltip by using a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 Use <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, and [CTooltipManager](../vs140/ctooltipmanager-class.md) objects together to implement customized tooltips in your application.  
  
 For example, to use balloon-style tooltips, follow these steps:  
  
 1. Use the [CWinAppEx::InitTooltipManager](../vs140/cwinappex-class.md) method to initialize the tooltip manager in your application.  
  
 2. Create a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> structure to specify the visual style that you want:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 3. Use the [CTooltipManager::SetTooltipParams](../vs140/ctooltipmanager-class.md#ctooltipmanager__settooltipparams) method to set the visual style for all tooltips in the application by using the styles defined in the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 You can also derive a new class from <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> to control tooltip behavior and rendering. To specify a new tooltip control class, use the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> method:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 To restore the default tooltip control class and reset the tooltip appearance to its default state, specify NULL in the runtime class and tooltip info parameters of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Example  
 The following example demonstrates how to construct a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object, set the description that the tooltip displays, and set the width of the tooltip control.  
  
 [!code[NVC_MFC_RibbonApp#41](../vs140/codesnippet/CPP/cmfctooltipctrl-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CToolTipCtrl](../vs140/ctooltipctrl-class.md)  
  
 [CMFCToolTipCtrl](../vs140/cmfctooltipctrl-class.md)  
  
## Requirements  
 **Header:** afxtooltipctrl.h  
  
##  \<a name="cmfctooltipctrl__cmfctooltipctrl">\</a>  CMFCToolTipCtrl::CMFCToolTipCtrl  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfctooltipctrl__geticonsize">\</a>  CMFCToolTipCtrl::GetIconSize  
 Returns the size of an icon in a tooltip.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 The size of the icon, in pixels.  
  
##  \<a name="cmfctooltipctrl__getparams">\</a>  CMFCToolTipCtrl::GetParams  
 Returns the display settings of a tooltip.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 The current tooltip display settings , which are stored in a [CMFCToolTipInfo](../vs140/cmfctooltipinfo-class.md) object.  
  
##  \<a name="cmfctooltipctrl__ondrawborder">\</a>  CMFCToolTipCtrl::OnDrawBorder  
 Draws the border of a tooltip.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 Pointer to a device context.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The bounding rectangle of the tooltip.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 Border color.  
  
### Remarks  
 Override this method in a derived class to customize the appearance of the tooltip border.  
  
##  \<a name="cmfctooltipctrl__ondrawdescription">\</a>  CMFCToolTipCtrl::OnDrawDescription  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctooltipctrl__ondrawicon">\</a>  CMFCToolTipCtrl::OnDrawIcon  
 Displays an icon in a tooltip.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in]  <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in]  <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 Coordinates of the icon.  
  
### Return Value  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> if the icon was drawn. Otherwise <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this method in a derived class to display a custom icon. You must also override [GetIconSize](#cmfctooltipctrl__geticonsize) to enable the tooltip to correctly calculate the layout of text and description.  
  
##  \<a name="cmfctooltipctrl__ondrawlabel">\</a>  CMFCToolTipCtrl::OnDrawLabel  
 Draws the label of a tooltip, or calculates the size of the label.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 Bounding rectangle of the label area.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, the label will not be drawn.  
  
### Return Value  
 Size of the label, in pixels.  
  
### Remarks  
 Override this method in a derived class if you want to customize the appearance of the tooltip label.  
  
##  \<a name="cmfctooltipctrl__ondrawseparator">\</a>  CMFCToolTipCtrl::OnDrawSeparator  
 Draws the separator between the label and the description in a tooltip.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in]  <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in]  <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 Horizontal coordinate of the left end of the separator.  
  
 [in]  <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 Horizontal coordinate of the right end of the separator.  
  
 [in]  <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 Vertical coordinate of the separator.  
  
### Remarks  
 The default implementation draws a line from the point (x1, y) to the point (x2, y).  
  
 Override this method in a derived class to customize the appearance of the separator.  
  
##  \<a name="cmfctooltipctrl__onfillbackground">\</a>  CMFCToolTipCtrl::OnFillBackground  
 Fills the tooltip background.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 Specifies the bounding rectangle of the area to fill.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 Tooltip foreground color.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 Color of borders and the delimiter line between label and description.  
  
### Remarks  
 The default implementation fills the rectangle that is specified by <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> with the color or pattern specified by the most recent call to [SetParams](#cmfctooltipctrl__setparams).  
  
 Override this method in a derived class if you want to customize the appearance of the tooltip.  
  
##  \<a name="cmfctooltipctrl__setdescription">\</a>  CMFCToolTipCtrl::SetDescription  
 Sets the description to be displayed by the tooltip.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 Description text.  
  
### Remarks  
 The description text is displayed on the tooltip under the separator.  
  
##  \<a name="cmfctooltipctrl__setfixedwidth">\</a>  CMFCToolTipCtrl::SetFixedWidth  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfctooltipctrl__sethotribbonbutton">\</a>  CMFCToolTipCtrl::SetHotRibbonButton  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfctooltipctrl__setlocation">\</a>  CMFCToolTipCtrl::SetLocation  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfctooltipctrl__setparams">\</a>  CMFCToolTipCtrl::SetParams  
 Specifies the visual appearance of a tooltip by using a [CMFCToolTipInfo](../vs140/cmfctooltipinfo-class.md) object.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 Pointer to a [CMFCToolTipInfo](../vs140/cmfctooltipinfo-class.md) object that contains  the display parameters.  
  
### Remarks  
 Whenever the tooltip is displayed, it is drawn by using the colors and visual styles that <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> specifies. The value of <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> is stored in the protected member <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, which can be accessed by a derived class that overrides [OnDrawBorder](#cmfctooltipctrl__ondrawborder), [OnDrawIcon](#cmfctooltipctrl__ondrawicon), [OnDrawLabel](#cmfctooltipctrl__ondrawlabel), [OnDrawSeparator](#cmfctooltipctrl__ondrawseparator), or [OnFillBackground](#cmfctooltipctrl__onfillbackground) to maintain the specified appearance.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CToolTipCtrl](../vs140/ctooltipctrl-class.md)   
 [CTooltipManager](../vs140/ctooltipmanager-class.md)   
 [CMFCToolTipInfo](../vs140/cmfctooltipinfo-class.md)   
 [CWinAppEx](../vs140/cwinappex-class.md)