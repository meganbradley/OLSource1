---
title: "CMFCCaptionBar Class"
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
  - "CMFCCaptionBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCCaptionBar class"
ms.assetid: acb54d5f-14ff-4c96-aeb3-7717cf566d9a
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCCaptionBar Class
A <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object is a control bar that can display three elements: a button, a text label, and a bitmap. It can only display one element of each type at a time. You can align each element to the left or right edges of the control or to the center. You can also apply a flat or 3D style to the top and bottom borders of the caption bar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCCaptionBar::Create](#cmfccaptionbar__create)|Creates the caption bar control and attaches it to the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object.|  
|[CMFCCaptionBar::DoesAllowDynInsertBefore](#cmfccaptionbar__doesallowdyninsertbefore)|Indicates whether another pane can be dynamically inserted between the caption bar and its parent frame. (Overrides [CBasePane::DoesAllowDynInsertBefore](../vs140/cbasepane-class.md#cbasepane__doesallowdyninsertbefore).)|  
|[CMFCCaptionBar::EnableButton](#cmfccaptionbar__enablebutton)|Enables or disables the button on the caption bar.|  
|[CMFCCaptionBar::GetAlignment](#cmfccaptionbar__getalignment)|Returns the alignment of the specified element.|  
|[CMFCCaptionBar::GetBorderSize](#cmfccaptionbar__getbordersize)|Returns the border size of the caption bar.|  
|[CMFCCaptionBar::GetButtonRect](#cmfccaptionbar__getbuttonrect)|Retrieves the bounding rectangle of the button on the caption bar.|  
|[CMFCCaptionBar::GetMargin](#cmfccaptionbar__getmargin)|Returns the distance between the edge of the caption bar elements and the edge of the caption bar control.|  
|[CMFCCaptionBar::IsMessageBarMode](#cmfccaptionbar__ismessagebarmode)|Specifies whether the caption bar is in the message bar mode.|  
|[CMFCCaptionBar::RemoveBitmap](#cmfccaptionbar__removebitmap)|Removes the bitmap image from the caption bar.|  
|[CMFCCaptionBar::RemoveButton](#cmfccaptionbar__removebutton)|Removes the button from the caption bar.|  
|[CMFCCaptionBar::RemoveIcon](#cmfccaptionbar__removeicon)|Removes the icon from the caption bar.|  
|[CMFCCaptionBar::RemoveText](#cmfccaptionbar__removetext)|Removes the text label from the caption bar.|  
|[CMFCCaptionBar::SetBitmap](#cmfccaptionbar__setbitmap)|Sets the bitmap image for the caption bar.|  
|[CMFCCaptionBar::SetBorderSize](#cmfccaptionbar__setbordersize)|Sets the border size of the caption bar.|  
|[CMFCCaptionBar::SetButton](#cmfccaptionbar__setbutton)|Sets the button for the caption bar.|  
|[CMFCCaptionBar::SetButtonPressed](#cmfccaptionbar__setbuttonpressed)|Specifies whether the button stays pressed.|  
|[CMFCCaptionBar::SetButtonToolTip](#cmfccaptionbar__setbuttontooltip)|Sets the tooltip for the button.|  
|[CMFCCaptionBar::SetFlatBorder](#cmfccaptionbar__setflatborder)|Sets the border style of the caption bar.|  
|[CMFCCaptionBar::SetIcon](#cmfccaptionbar__seticon)|Sets the icon for a caption bar.|  
|[CMFCCaptionBar::SetImageToolTip](#cmfccaptionbar__setimagetooltip)|Sets the tooltip for the image for the caption bar.|  
|[CMFCCaptionBar::SetMargin](#cmfccaptionbar__setmargin)|Sets the distance between the edge of the caption bar element and the edge of the caption bar control.|  
|[CMFCCaptionBar::SetText](#cmfccaptionbar__settext)|Sets the text label for the caption bar.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCCaptionBar::OnDrawBackground](#cmfccaptionbar__ondrawbackground)|Called by the framework to fill the background of the caption bar.|  
|[CMFCCaptionBar::OnDrawBorder](#cmfccaptionbar__ondrawborder)|Called by the framework to draw the border of the caption bar.|  
|[CMFCCaptionBar::OnDrawButton](#cmfccaptionbar__ondrawbutton)|Called by the framework to draw the caption bar button.|  
|[CMFCCaptionBar::OnDrawImage](#cmfccaptionbar__ondrawimage)|Called by the framework to draw the caption bar image.|  
|[CMFCCaptionBar::OnDrawText](#cmfccaptionbar__ondrawtext)|Called by the framework to draw the caption bar text.|  
  
### Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCCaptionBar::m_clrBarBackground](#cmfccaptionbar__m_clrbarbackground)|The background color of the caption bar.|  
|[CMFCCaptionBar::m_clrBarBorder](#cmfccaptionbar__m_clrbarborder)|The color of the border of the caption bar.|  
|[CMFCCaptionBar::m_clrBarText](#cmfccaptionbar__m_clrbartext)|The color of the caption bar text.|  
  
## Remarks  
 To create a caption bar, follow these steps:  
  
1.  Construct the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object. Typically, you would add the caption bar to a frame window class.  
  
2.  Call the [Create](#cmfccaptionbar__create) method to create the caption bar control and attach it to the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object.  
  
3.  Call [SetButton](#cmfccaptionbar__setbutton), [SetText](#cmfccaptionbar__settext), [SetIcon](#cmfccaptionbar__seticon), and [SetBitmap](#cmfccaptionbar__setbitmap) to set the caption bar elements.  
  
 When you set the button element, you must assign a command ID to the button. When the user clicks the button, the caption bar routes the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> messages that have this ID to the parent frame window.  
  
 The caption bar can also work in message bar mode, which emulates the message bar that appears in Microsoft Office 2007 applications. In message bar mode, the caption bar displays a bitmap, a message, and a button (which typically opens a dialog box.) You can assign a tooltip to the bitmap.  
  
 To enable message bar mode, call [Create](#cmfccaptionbar__create) and set the fourth parameter (bIsMessageBarMode) to <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
## Example  
 The following example demonstrates how to use various methods in the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> class. The example shows how to create the caption bar control, set a 3D border of the caption bar, set the distance, in pixels, between the edge of the caption bar elements and the edge of the caption bar control, set the button for the caption bar, set the tooltip for the button, set the text label for the caption bar, set the bitmap image for the caption bar, and set the tooltip for the image in the caption bar. This code snippet is part of the [MS Office 2007 Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_MSOffice2007Demo#1](../vs140/codesnippet/CPP/cmfccaptionbar-class_1.h)]  
[!code[NVC_MFC_MSOffice2007Demo#2](../vs140/codesnippet/CPP/cmfccaptionbar-class_2.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CBasePane](../vs140/cbasepane-class.md)  
  
 [CPane](../vs140/cpane-class.md)  
  
 [CMFCCaptionBar](../vs140/cmfccaptionbar-class.md)  
  
## Requirements  
 **Header:** afxcaptionbar.h  
  
##  \<a name="cmfccaptionbar__create">\</a>  CMFCCaptionBar::Create  
 Creates the caption bar control and attaches it to the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The logical OR combination of the caption bar styles.  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 The parent window of the caption bar control.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 The ID of caption bar control.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 The height, in pixels, of the caption bar control. If it is -1, the height is calculated according to the height of the icon, the text and the button that the caption bar control displays.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> if the caption bar is in the message bar mode; <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> otherwise.  
  
### Return Value  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> if the caption bar control is created successfully; <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 You construct a <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object in two steps. First you call the constructor, and then you call the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> method, which creates the Windows control and attaches it to the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object.  
  
##  \<a name="cmfccaptionbar__doesallowdyninsertbefore">\</a>  CMFCCaptionBar::DoesAllowDynInsertBefore  
 Indicates whether another pane can be dynamically inserted between the caption bar and its parent frame.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> unless overridden.  
  
### Remarks  
  
##  \<a name="cmfccaptionbar__enablebutton">\</a>  CMFCCaptionBar::EnableButton  
 Enables or disables the button on the caption bar.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> to enable the button, <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> to disable the button.  
  
##  \<a name="cmfccaptionbar__getalignment">\</a>  CMFCCaptionBar::GetAlignment  
 Returns the alignment of the specified element.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 A caption bar element for which to retrieve alignment.  
  
### Return Value  
 The alignment of an element, such as a button, a bitmap, text, or an icon.  
  
### Remarks  
 The alignment of the element can be one of the following values:  
  
-   ALIGN_INVALID  
  
-   ALIGN_LEFT  
  
-   ALIGN_RIGHT  
  
-   ALIGN_CENTER  
  
##  \<a name="cmfccaptionbar__getbordersize">\</a>  CMFCCaptionBar::GetBorderSize  
 Returns the border size of the caption bar.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 The size, in pixels, of the border.  
  
##  \<a name="cmfccaptionbar__getbuttonrect">\</a>  CMFCCaptionBar::GetButtonRect  
 Retrieves the bounding rectangle of the button on the caption bar.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object that contains the coordinates of the bounding rectangle of the button on the caption bar.  
  
##  \<a name="cmfccaptionbar__getmargin">\</a>  CMFCCaptionBar::GetMargin  
 Returns the distance between the edge of the caption bar elements and the edge of the caption bar control.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 The distance, in pixels, between the edge of the caption bar elements and the edge of the caption bar control.  
  
##  \<a name="cmfccaptionbar__ismessagebarmode">\</a>  CMFCCaptionBar::IsMessageBarMode  
 Specifies whether the caption bar is in the message bar mode.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> if the caption bar is in the message bar mode; <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 In the message bar mode, the caption bar displays an image with a tooltip, a message text, and a button.  
  
##  \<a name="cmfccaptionbar__m_clrbarbackground">\</a>  CMFCCaptionBar::m_clrBarBackground  
 The background color of the caption bar.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
##  \<a name="cmfccaptionbar__m_clrbarborder">\</a>  CMFCCaptionBar::m_clrBarBorder  
 The color of the border of the caption bar.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
##  \<a name="cmfccaptionbar__m_clrbartext">\</a>  CMFCCaptionBar::m_clrBarText  
 The color of the caption bar text.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
##  \<a name="cmfccaptionbar__ondrawbackground">\</a>  CMFCCaptionBar::OnDrawBackground  
 Called by the framework to fill the background of the caption bar.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 A pointer to the device context of the caption bar.  
  
 [in] <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 The bounding rectangle to fill.  
  
### Remarks  
 The <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> method is called when the background of the caption bar is about to be filled. The default implementation fills the background by using the [m_clrBarBackground](#cmfccaptionbar__m_clrbarbackground) color.  
  
 Override this method in a <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> derived class to customize the appearance of the caption bar.  
  
##  \<a name="cmfccaptionbar__ondrawborder">\</a>  CMFCCaptionBar::OnDrawBorder  
 Called by the framework to draw the border of the caption bar.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 A device context that is used to display the borders.  
  
 [in] <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 The bounding rectangle.  
  
### Remarks  
 By default, the borders have the flat style.  
  
 Override this method in a <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> derived class to customize the appearance of the caption bar's borders.  
  
##  \<a name="cmfccaptionbar__ondrawbutton">\</a>  CMFCCaptionBar::OnDrawButton  
 Called by the framework to draw the caption bar button.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 A pointer to a device context that is used to display the button.  
  
 [in] <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 The bounding rectangle of the button.  
  
 [in] <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 The button's text label.  
  
 [in] <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> if the button is enabled; <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 Override this method in a <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> derived class to customize the appearance of the caption bar's button.  
  
##  \<a name="cmfccaptionbar__ondrawimage">\</a>  CMFCCaptionBar::OnDrawImage  
 Called by the framework to draw the caption bar image.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 A pointer to a device context that is used to display the image.  
  
 [in] <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 Specifies the bounding rectangle of the image.  
  
### Remarks  
 Override this method in a <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> derived class to customize the image appearance.  
  
##  \<a name="cmfccaptionbar__ondrawtext">\</a>  CMFCCaptionBar::OnDrawText  
 Called by the framework to draw the caption bar text.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 A pointer to a device context that is used to display the button.  
  
 [in] <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 The bounding rectangle of the text.  
  
 [in] <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 The text string to display.  
  
### Remarks  
 The default implementation displays the text by using <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> and [m_clrBarText](#cmfccaptionbar__m_clrbartext) color.  
  
 Override this method in a <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> derived class to customize the appearance of the caption bar's text.  
  
##  \<a name="cmfccaptionbar__removebitmap">\</a>  CMFCCaptionBar::RemoveBitmap  
 Removes the bitmap image from the caption bar.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
##  \<a name="cmfccaptionbar__removebutton">\</a>  CMFCCaptionBar::RemoveButton  
 Removes the button from the caption bar.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Remarks  
 The layout of caption bar elements are adjusted automatically.  
  
##  \<a name="cmfccaptionbar__removeicon">\</a>  CMFCCaptionBar::RemoveIcon  
 Removes the icon from the caption bar.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
##  \<a name="cmfccaptionbar__removetext">\</a>  CMFCCaptionBar::RemoveText  
 Removes the text label from the caption bar.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
##  \<a name="cmfccaptionbar__setbitmap">\</a>  CMFCCaptionBar::SetBitmap  
 Sets the bitmap image for the caption bar.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 The handle to the bitmap to set.  
  
 [in] <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 An RGB value that specifies the transparent color of the bitmap.  
  
 [in] <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>, the bitmap is stretched if it does not fit to the image bounding rectangle. Otherwise the bitmap is not stretched.  
  
 [in] <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 The alignment of the bitmap.  
  
### Remarks  
 Use this method to set a bitmap on a caption bar.  
  
 The previous bitmap is destroyed automatically. If the caption bar displays an icon because you called the [SetIcon](#cmfccaptionbar__seticon) method, the bitmap will not be displayed unless you remove the icon by calling [RemoveIcon](#cmfccaptionbar__removeicon).  
  
 The bitmap is aligned as specified by the <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> parameter.  This parameter can be one of the following <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> values:  
  
-   ALIGN_INVALID  
  
-   ALIGN_LEFT  
  
-   ALIGN_RIGHT  
  
-   ALIGN_CENTER  
  
##  \<a name="cmfccaptionbar__setbordersize">\</a>  CMFCCaptionBar::SetBorderSize  
 Sets the border size of the caption bar.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 The new size, in pixels, of the caption bar border.  
  
##  \<a name="cmfccaptionbar__setbutton">\</a>  CMFCCaptionBar::SetButton  
 Sets the button for the caption bar.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 The button's command label.  
  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 The button's command ID.  
  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 The button's alignment.  
  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> if the button displays a drop down arrow, <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cmfccaptionbar__setbuttonpressed">\</a>  CMFCCaptionBar::SetButtonPressed  
 Specifies whether the button stays pressed.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> if the button keeps its pressed state, <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cmfccaptionbar__setbuttontooltip">\</a>  CMFCCaptionBar::SetButtonToolTip  
 Sets the tooltip for the button.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
 The tooltip caption.  
  
 [in] <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 The tooltip description.  
  
##  \<a name="cmfccaptionbar__setflatborder">\</a>  CMFCCaptionBar::SetFlatBorder  
 Sets the border style of the caption bar.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> if the border of a caption bar is flat. <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> if the border is 3D.  
  
##  \<a name="cmfccaptionbar__seticon">\</a>  CMFCCaptionBar::SetIcon  
 Sets the icon for a caption bar.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 The handle to the icon to set.  
  
 [in] <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
 The alignment of the icon.  
  
### Remarks  
 Caption bars can display either icons or bitmaps. See [SetBitmap](#cmfccaptionbar__setbitmap) to find out how to display a bitmap. If you set both an icon and a bitmap, the icon is always displayed. Call [RemoveIcon](#cmfccaptionbar__removeicon) to remove an icon from the caption bar.  
  
 The icon is aligned according to the <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> parameter. It can be one of the following <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> values:  
  
-   ALIGN_INVALID  
  
-   ALIGN_LEFT  
  
-   ALIGN_RIGHT  
  
-   ALIGN_CENTER  
  
##  \<a name="cmfccaptionbar__setimagetooltip">\</a>  CMFCCaptionBar::SetImageToolTip  
 Sets the tooltip for the image in the caption bar.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
 The text of the tooltip.  
  
 [in] <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 The tooltip description.  
  
##  \<a name="cmfccaptionbar__setmargin">\</a>  CMFCCaptionBar::SetMargin  
 Sets the distance between the edge of the caption bar element and the edge of the caption bar control.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 The distance, in pixels, between the edge of the caption bar elements and the edge of the caption bar control.  
  
##  \<a name="cmfccaptionbar__settext">\</a>  CMFCCaptionBar::SetText  
 Sets the text label for the caption bar.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 The text string to set.  
  
 [in] <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 The text alignment.  
  
### Remarks  
 The text label is aligned as specified by the <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> parameter. It can be one of the following <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> values:  
  
-   ALIGN_INVALID  
  
-   ALIGN_LEFT  
  
-   ALIGN_RIGHT  
  
-   ALIGN_CENTER  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)