---
title: "CMFCButton Class"
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
  - "CMFCButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCButton::CreateObject method"
  - "CMFCButton::DrawItem method"
  - "CMFCButton::PreTranslateMessage method"
  - "CMFCButton constructor"
  - "CMFCButton::OnDrawParentBackground method"
  - "CMFCButton class"
ms.assetid: 4b32f57c-7a53-4734-afb9-d47e3359f62e
caps.latest.revision: 35
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCButton Class
The <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> class adds functionality to the [CButton](../vs140/cbutton-class.md) class such as aligning button text, combining button text and an image, selecting a cursor, and specifying a tool tip.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|Default constructor.|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCButton::CleanUp](#cmfcbutton__cleanup)|Resets internal variables and frees allocated resources such as images, bitmaps, and icons.|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|Used by the framework to create a dynamic instance of this class type.|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|Called by the framework when a visual aspect of an owner-drawn button has changed. (Overrides [CButton::DrawItem](../vs140/cbutton-class.md#cbutton__drawitem).)|  
|[CMFCButton::EnableFullTextTooltip](#cmfcbutton__enablefulltexttooltip)|Specifies whether to display the full text of a tooltip in a large tooltip window or a truncated version of the text in a small tooltip window.|  
|[CMFCButton::EnableMenuFont](#cmfcbutton__enablemenufont)|Specifies whether the button text font is the same as the application menu font.|  
|[CMFCButton::EnableWindowsTheming](#cmfcbutton__enablewindowstheming)|Specifies whether the style of the button border corresponds to the current Windows theme.|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|Used by the framework to obtain a pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) object that is associated with this class type.|  
|[CMFCButton::GetToolTipCtrl](#cmfcbutton__gettooltipctrl)|Returns a reference to the underlying tooltip control.|  
|[CMFCButton::IsAutoCheck](#cmfcbutton__isautocheck)|Indicates whether a check box or radio button is an automatic button.|  
|[CMFCButton::IsAutorepeatCommandMode](#cmfcbutton__isautorepeatcommandmode)|Indicates whether a button is set to auto-repeat mode.|  
|[CMFCButton::IsCheckBox](#cmfcbutton__ischeckbox)|Indicates whether a button is a check box button.|  
|[CMFCButton::IsChecked](#cmfcbutton__ischecked)|Indicates whether the current button is checked.|  
|[CMFCButton::IsHighlighted](#cmfcbutton__ishighlighted)|Indicates whether a button is highlighted.|  
|[CMFCButton::IsPressed](#cmfcbutton__ispressed)|Indicates whether a button is pushed and highlighted.|  
|[CMFCButton::IsPushed](#cmfcbutton__ispushed)|Indicates whether a button is pushed.|  
|[CMFCButton::IsRadioButton](#cmfcbutton__isradiobutton)|Indicates whether a button is a radio button.|  
|[CMFCButton::IsWindowsThemingEnabled](#cmfcbutton__iswindowsthemingenabled)|Indicates whether the style of the button border corresponds to the current Windows theme.|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|Draws the background of a button's parent in the specified area. (Overrides [AFX_GLOBAL_DATA::DrawParentBackground](../vs140/afx_global_data--drawparentbackground.md).)|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|Translates window messages before they are dispatched to the                                         [TranslateMessage](http://msdn.microsoft.com/library/windows/desktop/ms644955) and                                         [DispatchMessage](http://msdn.microsoft.com/library/windows/desktop/ms644934) Windows functions. (Overrides [CWnd::PreTranslateMessage](../vs140/cwnd-class.md#cwnd__pretranslatemessage).)|  
|[CMFCButton::SetAutorepeatMode](#cmfcbutton__setautorepeatmode)|Sets a button to auto-repeat mode.|  
|[CMFCButton::SetCheckedImage](#cmfcbutton__setcheckedimage)|Sets the image for a checked button.|  
|[CMFCButton::SetFaceColor](#cmfcbutton__setfacecolor)|Sets the background color for the button text.|  
|[CMFCButton::SetImage](#cmfcbutton__setimage)|Sets the image for a button.|  
|[CMFCButton::SetMouseCursor](#cmfcbutton__setmousecursor)|Sets the cursor image.|  
|[CMFCButton::SetMouseCursorHand](#cmfcbutton__setmousecursorhand)|Sets the cursor to the image of a hand.|  
|[CMFCButton::SetStdImage](#cmfcbutton__setstdimage)|Uses a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object to set the button image.|  
|[CMFCButton::SetTextColor](#cmfcbutton__settextcolor)|Sets the color of the button text for a button that is not selected.|  
|[CMFCButton::SetTextHotColor](#cmfcbutton__settexthotcolor)|Sets the color of the button text for a button that is selected.|  
|[CMFCButton::SetTooltip](#cmfcbutton__settooltip)|Associates a tooltip with a button.|  
|[CMFCButton::SizeToContent](#cmfcbutton__sizetocontent)|Resizes a button to contain its button text and image.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCButton::OnDraw](#cmfcbutton__ondraw)|Called by the framework to draw a button.|  
|[CMFCButton::OnDrawBorder](#cmfcbutton__ondrawborder)|Called by the framework to draw the border of a button.|  
|[CMFCButton::OnDrawFocusRect](#cmfcbutton__ondrawfocusrect)|Called by the framework to draw the focus rectangle for a button.|  
|[CMFCButton::OnDrawText](#cmfcbutton__ondrawtext)|Called by the framework to draw the button text.|  
|[CMFCButton::OnFillBackground](#cmfcbutton__onfillbackground)|Called by the framework to draw the background of the button text.|  
|[CMFCButton::SelectFont](#cmfcbutton__selectfont)|Retrieves the font that is associated with the specified device context.|  
  
### Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCButton::m_bDrawFocus](#cmfcbutton__m_bdrawfocus)|Indicates whether to draw a focus rectangle around a button.|  
|[CMFCButton::m_bHighlightChecked](#cmfcbutton__m_bhighlightchecked)|Indicates whether to highlight a BS_CHECKBOX-style button when the cursor hovers over it.|  
|[CMFCButton::m_bRightImage](#cmfcbutton__m_brightimage)|Indicates whether to display an image on the right side of the button.|  
|[CMFCButton::m_bTransparent](#cmfcbutton__m_btransparent)|Indicates whether the button is transparent.|  
|[CMFCButton::m_nAlignStyle](#cmfcbutton__m_nalignstyle)|Specifies the alignment of the button text.|  
|[CMFCButton::m_nFlatStyle](#cmfcbutton__m_nflatstyle)|Specifies the style of the button, such as borderless, flat, semi-flat, or 3D.|  
  
## Remarks  
 Other types of buttons are derived from the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> class, such as the [CMFCURLLinkButton](../vs140/cmfclinkctrl-class.md) class, which supports hyperlinks, and the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> class, which supports a color picker dialog box.  
  
 The style of a <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object can be *3D*, *flat*, *semi-flat* or *no border*. Button text can be aligned at the left, top, or center of a button. At run time, you can control whether the button displays text, an image, or text and an image. You can also specify that a particular cursor image be displayed when the cursor hovers over a button.  
  
 Create a button control either directly in your code, or by using the **MFC Class Wizard** tool and a dialog box template. If you create a button control directly, add a <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> variable to your application, and then call the constructor and <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> methods of the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object. If you use the **MFC Class Wizard**, add a <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> variable to your application, and then change the type of the variable from <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>.  
  
 To handle notification messages in a dialog box application, add a message map entry and an event handler for each notification. The notifications sent by a <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object are the same as those sent by a <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> object.  
  
## Example  
 The following example demonstrates how to configure the properties of the button by using various methods in the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> class. The example is part of the [New Controls sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_NewControls#28](../vs140/codesnippet/CPP/cmfcbutton-class_1.h)]  
[!code[NVC_MFC_NewControls#31](../vs140/codesnippet/CPP/cmfcbutton-class_2.cpp)]  
[!code[NVC_MFC_NewControls#32](../vs140/codesnippet/CPP/cmfcbutton-class_3.cpp)]  
[!code[NVC_MFC_NewControls#33](../vs140/codesnippet/CPP/cmfcbutton-class_4.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CButton](../vs140/cbutton-class.md)  
  
 [CMFCButton](../vs140/cmfcbutton-class.md)  
  
## Requirements  
 **Header:** afxbutton.h  
  
##  \<a name="cmfcbutton__cleanup">\</a>  CMFCButton::CleanUp  
 Resets internal variables and frees allocated resources such as images, bitmaps, and icons.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="cmfcbutton__enablefulltexttooltip">\</a>  CMFCButton::EnableFullTextTooltip  
 Specifies whether to display the full text of a tooltip in a large tooltip window or a truncated version of the text in a small tooltip window.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> to display all of the text; <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> to display truncated text.  
  
### Remarks  
  
##  \<a name="cmfcbutton__enablemenufont">\</a>  CMFCButton::EnableMenuFont  
 Specifies whether the button text font is the same as the application menu font.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> to use the application menu font as the button text font; <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> to use the system font. The default is <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> to immediately redraw the screen; otherwise, <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>. The default is <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>.  
  
### Remarks  
 If you do not use this method to specify the button text font, you can specify the font with the [CWnd::SetFont](../vs140/cwnd-class.md#cwnd__setfont) method. If you do not specify a font at all, the framework sets a default font.  
  
##  \<a name="cmfcbutton__enablewindowstheming">\</a>  CMFCButton::EnableWindowsTheming  
 Specifies whether the style of the button border corresponds to the current Windows theme.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> to use the current Windows theme to draw button borders; <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> to not use the Windows theme. The default is <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method affects all buttons in your application that are derived from the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> class.  
  
##  \<a name="cmfcbutton__gettooltipctrl">\</a>  CMFCButton::GetToolTipCtrl  
 Returns a reference to the underlying tooltip control.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 A reference to the underlying tooltip control.  
  
### Remarks  
  
##  \<a name="cmfcbutton__isautocheck">\</a>  CMFCButton::IsAutoCheck  
 Indicates whether a check box or radio button is an automatic button.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> if the button has style BS_AUTOCHECKBOX or BS_AUTORADIOBUTTON; otherwise, <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcbutton__isautorepeatcommandmode">\</a>  CMFCButton::IsAutorepeatCommandMode  
 Indicates whether a button is set to auto-repeat mode.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 TRUE if the button is set to auto-repeat mode; otherwise, FALSE.  
  
### Remarks  
 Use the [CMFCButton::SetAutorepeatMode](#cmfcbutton__setautorepeatmode) method to set a button to auto-repeat mode.  
  
##  \<a name="cmfcbutton__ischeckbox">\</a>  CMFCButton::IsCheckBox  
 Indicates whether a button is a check box button.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 TRUE if the button has either BS_CHECKBOX or BS_AUTOCHECKBOX style; otherwise, FALSE.  
  
### Remarks  
  
##  \<a name="cmfcbutton__ischecked">\</a>  CMFCButton::IsChecked  
 Indicates whether the current button is checked.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> if the current button is checked; otherwise, <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>.  
  
### Remarks  
 The framework uses different ways to indicate that different kinds of buttons are checked. For example, a radio button is checked when it contains a dot; a check box is checked when it contains an **X**.  
  
##  \<a name="cmfcbutton__ishighlighted">\</a>  CMFCButton::IsHighlighted  
 Indicates whether a button is highlighted.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 TRUE if the button is highlighted; otherwise, FALSE.  
  
### Remarks  
 A button becomes highlighted when the mouse hovers over the button.  
  
##  \<a name="cmfcbutton__ispressed">\</a>  CMFCButton::IsPressed  
 Indicates whether a button is pushed and highlighted.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 TRUE if the button is pressed; otherwise, FALSE.  
  
### Remarks  
  
##  \<a name="cmfcbutton__ispushed">\</a>  CMFCButton::IsPushed  
 Indicates whether a button is pushed.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 TRUE if the button is pushed; otherwise, FALSE.  
  
### Remarks  
  
##  \<a name="cmfcbutton__isradiobutton">\</a>  CMFCButton::IsRadioButton  
 Indicates whether a button is a radio button.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 TRUE if the button style is BS_RADIOBUTTON or BS_AUTORADIOBUTTON; otherwise, FALSE.  
  
### Remarks  
  
##  \<a name="cmfcbutton__iswindowsthemingenabled">\</a>  CMFCButton::IsWindowsThemingEnabled  
 Indicates whether the style of the button border corresponds to the current Windows theme.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> if the style of the button border corresponds to the current Windows theme; otherwise, <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcbutton__m_bdrawfocus">\</a>  CMFCButton::m_bDrawFocus  
 Indicates whether to draw a focus rectangle around a button.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Remarks  
 Set the <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> member to <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> to specify that the framework will draw a focus rectangle around the button's text and image if the button receives focus.  
  
 The <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> constructor initializes this member to <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcbutton__m_bhighlightchecked">\</a>  CMFCButton::m_bHighlightChecked  
 Indicates whether to highlight a BS_CHECKBOX-style button when the cursor hovers over it.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Remarks  
 Set the <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> member to <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> to specify that the framework will highlight a BS_CHECKBOX-style button when the mouse hovers over it.  
  
##  \<a name="cmfcbutton__m_brightimage">\</a>  CMFCButton::m_bRightImage  
 Indicates whether to display an image on the right side of the button.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Remarks  
 Set the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> member to <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> to specify that the framework will display the button's image to the right of the button's text label.  
  
##  \<a name="cmfcbutton__m_btransparent">\</a>  CMFCButton::m_bTransparent  
 Indicates whether the button is transparent.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Remarks  
 Set the <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> member to <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> to specify that the framework will make the button transparent. The <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> constructor initializes this member to <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcbutton__m_nalignstyle">\</a>  CMFCButton::m_nAlignStyle  
 Specifies the alignment of the button text.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Remarks  
 Use one of the following <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> enumeration values to specify the alignment of the button text:  
  
|Value|Description|  
|-----------|-----------------|  
|ALIGN_CENTER|(Default) Aligns the button text to the center of the button.|  
|ALIGN_LEFT|Aligns the button text to the left side of the button.|  
|ALIGN_RIGHT|Aligns the button text to the right side of the button.|  
  
 The <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> constructor initializes this member to ALIGN_CENTER.  
  
##  \<a name="cmfcbutton__m_nflatstyle">\</a>  CMFCButton::m_nFlatStyle  
 Specifies the style of the button, such as borderless, flat, semi-flat, or 3D.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Remarks  
 The following table lists the <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> enumeration values that specify the appearance of a button.  
  
|Value|Description|  
|-----------|-----------------|  
|BUTTONSTYLE_3D|(Default) The button appears to have high, three-dimensional sides. When the button is clicked, the button appears to be pressed into a deep indentation.|  
|BUTTONSTYLE_FLAT|When the mouse does not pause over the button, the button appears to be two-dimensional and does not have raised sides. When the mouse pauses over the button, the button appears to have low, three-dimensional sides. When the button is clicked, the button appears to be pressed into a shallow indentation.|  
|BUTTONSTYLE_SEMIFLAT|The button appears to have low, three-dimensional sides. When the button is clicked, the button appears to be pressed into a deep indentation.|  
|BUTTONSTYLE_NOBORDERS|The button does not have raised sides and always appears two-dimensional. The button does not appear to be pressed into an indentation when it is clicked.|  
  
 The <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> constructor initializes this member to <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>.  
  
### Example  
 The following example demonstrates how to set the values of the <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> member variable in the <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> class. This example is part of the [New Controls sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_NewControls#28](../vs140/codesnippet/CPP/cmfcbutton-class_1.h)]  
[!code[NVC_MFC_NewControls#29](../vs140/codesnippet/CPP/cmfcbutton-class_5.cpp)]  
  
##  \<a name="cmfcbutton__ondraw">\</a>  CMFCButton::OnDraw  
 Called by the framework to draw a button.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 A reference to a rectangle that bounds the button.  
  
 [in] <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
 The current button state. For more information, see the <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> member of the [DRAWITEMSTRUCT Structure](../vs140/drawitemstruct-structure.md) topic.  
  
### Remarks  
 Override this method to use your own code to draw a button.  
  
##  \<a name="cmfcbutton__ondrawborder">\</a>  CMFCButton::OnDrawBorder  
 Called by the framework to draw the border of a button.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
 A reference to a rectangle that bounds the button.  
  
 [in] <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 The current button state. For more information, see the <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> member of the [DRAWITEMSTRUCT Structure](../vs140/drawitemstruct-structure.md) topic.  
  
### Remarks  
 Override this method to use your own code to draw the border.  
  
##  \<a name="cmfcbutton__ondrawfocusrect">\</a>  CMFCButton::OnDrawFocusRect  
 Called by the framework to draw the focus rectangle for a button.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 A reference to a rectangle that bounds the button.  
  
### Remarks  
 Override this method to use your own code to draw the focus rectangle.  
  
##  \<a name="cmfcbutton__ondrawtext">\</a>  CMFCButton::OnDrawText  
 Called by the framework to draw the button text.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 A reference to a rectangle that bounds the button.  
  
 [in] <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
 The text to draw.  
  
 [in] <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
 Flags that specify how to format the text. For more information, see the <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> parameter of the [CDC::DrawText](../vs140/cdc-class.md#cdc__drawtext) method.  
  
 [in] <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
 (Reserved.)  
  
### Remarks  
 Override this method to use your own code to draw the button text.  
  
##  \<a name="cmfcbutton__onfillbackground">\</a>  CMFCButton::OnFillBackground  
 Called by the framework to draw the background of the button text.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
 A reference to a rectangle that bounds the button.  
  
### Remarks  
 Override this method to use your own code to draw the background of a button.  
  
##  \<a name="cmfcbutton__selectfont">\</a>  CMFCButton::SelectFont  
 Retrieves the font that is associated with the specified device context.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
### Return Value  
 Override this method to use your own code to retrieve the font.  
  
### Remarks  
  
##  \<a name="cmfcbutton__setautorepeatmode">\</a>  CMFCButton::SetAutorepeatMode  
 Sets a button to auto-repeat mode.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
 A nonnegative number that specifies the interval between messages that are sent to the parent window. The interval is measured in milliseconds and its default value is 500 milliseconds. Specify zero to disable auto-repeat message mode.  
  
### Remarks  
 This method causes the button to constantly send WM_COMMAND messages to the parent window until the button is released, or the <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> parameter is set to zero.  
  
##  \<a name="cmfcbutton__setcheckedimage">\</a>  CMFCButton::SetCheckedImage  
 Sets the image for a checked button.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
 Handle to the icon that contains the bitmap and mask for the new image.  
  
 [in] <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> to specify that bitmap resources be destroyed automatically; otherwise, <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>. The default is <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
 Handle to the icon that contains the image for the selected state.  
  
 [in] <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
 Handle to the bitmap that contains the image for the non-selected state.  
  
 [in] <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
 Handle to the bitmap that contains the image for the selected state.  
  
 [in] <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 Specifies a transparent color for the button background; that is, the face of the button. <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> to use the color value RGB(192, 192, 192); <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> to use the color value defined by <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 Resource ID for the non-selected image.  
  
 [in] <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
 Resource ID for the selected image.  
  
 [in] <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
 Handle to the icon for the disabled image.  
  
 [in] <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  
 Handle to the bitmap that contains the disabled image.  
  
 [in] <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
 Resource ID of the disabled bitmap.  
  
 [in] <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> to use only 32-bit images that use the alpha channel; <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>, to not use only alpha channel images. The default is <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcbutton__setfacecolor">\</a>  CMFCButton::SetFaceColor  
 Sets the background color for the button text.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
 An RGB color value.  
  
 [in] <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> to redraw the screen immediately; otherwise, <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>.  
  
### Remarks  
 Use this method to define a new fill color for the button background (face). Note that the background is not filled when the [CMFCButton::m_bTransparent](#cmfcbutton__m_btransparent) member variable is <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcbutton__setimage">\</a>  CMFCButton::SetImage  
 Sets the image for a button.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>  
 Handle to the icon that contains the bitmap and mask for the new image.  
  
 [in] <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> to specify that bitmap resources be destroyed automatically; otherwise, <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>. The default is <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
 Handle to the icon that contains the image for the selected state.  
  
 [in] <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>  
 Handle to the bitmap that contains the image for the non-selected state.  
  
 [in] <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>  
 Handle to the bitmap that contains the image for the selected state.  
  
 [in] <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>  
 Resource ID for the non-selected image.  
  
 [in] <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>  
 Resource ID for the selected image.  
  
 [in] <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>  
 Specifies a transparent color for the button background; that is, the face of the button. <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> to use the color value RGB(192, 192, 192); <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> to use the color value defined by <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
 Handle to the icon for the disabled image.  
  
 [in] <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>  
 Handle to the bitmap that contains the disabled image.  
  
 [in] <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>  
 Resource ID of the disabled bitmap.  
  
 [in] <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> to use only 32-bit images that use the alpha channel; <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>, to not use only alpha channel images. The default is <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>.  
  
### Remarks  
  
### Example  
 The following example demonstrates how to use various versions of the <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> method in the <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> class. The example is part of the [New Controls sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_NewControls#28](../vs140/codesnippet/CPP/cmfcbutton-class_1.h)]  
[!code[NVC_MFC_NewControls#31](../vs140/codesnippet/CPP/cmfcbutton-class_2.cpp)]  
  
##  \<a name="cmfcbutton__setmousecursor">\</a>  CMFCButton::SetMouseCursor  
 Sets the cursor image.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>  
 The handle of a cursor.  
  
### Remarks  
 Use this method to associate a cursor image, such as the hand cursor, with the button. The cursor is loaded from the application resources.  
  
### Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> method in the <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> class. The example is part of the code in the [New Controls sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_NewControls#28](../vs140/codesnippet/CPP/cmfcbutton-class_1.h)]  
[!code[NVC_MFC_NewControls#30](../vs140/codesnippet/CPP/cmfcbutton-class_6.cpp)]  
  
##  \<a name="cmfcbutton__setmousecursorhand">\</a>  CMFCButton::SetMouseCursorHand  
 Sets the cursor to the image of a hand.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Remarks  
 Use this method to associate the cursor image of a hand with the button. The cursor is loaded from the application resources.  
  
##  \<a name="cmfcbutton__setstdimage">\</a>  CMFCButton::SetStdImage  
 Uses a <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> object to set the button image.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  
 One of the button image identifiers that is defined in the <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> enumeration. The image values specify images such as arrows, pins, and radio buttons.  
  
 [in] <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>  
 One of the button image state identifiers that is defined in the <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> enumeration. The image states specify button colors such as black, gray, light gray, white, and dark gray. The default value is <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>  
 One of the button image identifiers that is defined in the <CodeContentPlaceHolder>180\</CodeContentPlaceHolder> enumeration. The image indicates that the button is disabled. The default value is the first button image ( <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>).  
  
### Remarks  
  
##  \<a name="cmfcbutton__settextcolor">\</a>  CMFCButton::SetTextColor  
 Sets the color of the button text for a button that is not selected.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>  
 An RGB color value.  
  
### Remarks  
  
##  \<a name="cmfcbutton__settexthotcolor">\</a>  CMFCButton::SetTextHotColor  
 Sets the color of the button text for a button that is selected.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>  
 An RGB color value.  
  
### Remarks  
  
##  \<a name="cmfcbutton__settooltip">\</a>  CMFCButton::SetTooltip  
 Associates a tooltip with a button.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>  
 Pointer to the text for the tooltip. Specify NULL to disable the tooltip.  
  
### Remarks  
  
##  \<a name="cmfcbutton__sizetocontent">\</a>  CMFCButton::SizeToContent  
 Resizes a button to contain its button text and image.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> to calculate, but not change, the new size of the button; <CodeContentPlaceHolder>187\</CodeContentPlaceHolder> to change the size of the button. The default is <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>.  
  
### Return Value  
 A <CodeContentPlaceHolder>189\</CodeContentPlaceHolder> object that contains the new size of the button.  
  
### Remarks  
 By default, this method calculates a new size that includes a horizontal margin of 10 pixels and a vertical margin of 5 pixels.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCURLLinkButton](../vs140/cmfclinkctrl-class.md)   
 [CMFCColorButton](../vs140/cmfccolorbutton-class.md)   
 [CMFCMenuButton](../vs140/cmfcmenubutton-class.md)