---
title: "CMFCColorBar Class"
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
  - "CMFCColorBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCColorBar class"
  - "CMFCColorBar::m_ColorAutomatic data member"
  - "CMFCColorBar::m_bInternal data member"
  - "CMFCColorBar::m_bIsEnabled data member"
  - "CMFCColorBar::m_nNumColumnsVert data member"
  - "CMFCColorBar::m_nVertMargin data member"
  - "CMFCColorBar::m_strDocColors data member"
  - "CMFCColorBar::m_BoxSize data member"
  - "CMFCColorBar::m_pParentBtn data member"
  - "CMFCColorBar::m_bIsTearOff data member"
  - "CMFCColorBar::m_nHorzOffset data member"
  - "CMFCColorBar::m_pParentRibbonBtn data member"
  - "CMFCColorBar::m_nNumRowsHorz data member"
  - "CMFCColorBar::m_bStdColorDlg data member"
  - "CMFCColorBar::m_strAutoColor data member"
  - "CMFCColorBar::m_ColorNames data member"
  - "CMFCColorBar::m_strOtherColor data member"
  - "CMFCColorBar::m_lstDocColors data member"
  - "CMFCColorBar::m_pWndPropList data member"
  - "CMFCColorBar::m_ColorSelected data member"
  - "CMFCColorBar::m_nCommandID data member"
  - "CMFCColorBar::m_nHorzMargin data member"
  - "CMFCColorBar::m_nRowHeight data member"
  - "CMFCColorBar::m_Palette data member"
  - "CMFCColorBar::m_colors data member"
  - "CMFCColorBar::m_nVertOffset data member"
  - "CMFCColorBar::m_nNumColumns data member"
  - "CMFCColorBar::m_bShowDocColorsWhenDocked data member"
ms.assetid: 4756ee40-25a5-4cee-af7f-acab7993d1c7
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorBar Class
The <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> class represents a docking control bar that can select colors in a document or application.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Protected Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCColorBar::CMFCColorBar](#cmfccolorbar__cmfccolorbar)|Constructs a <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCColorBar::ContextToSize](#cmfccolorbar__contexttosize)|Calculates the vertical and horizontal margins that are required to contain the buttons on the color bar control and then adjusts the location of those buttons.|  
|[CMFCColorBar::CreateControl](#cmfccolorbar__createcontrol)|Creates a color bar control window, attaches it to the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object, and resizes the control to contain the specified palette of colors.|  
|[CMFCColorBar::Create](#cmfccolorbar__create)|Creates a color bar control window and attaches it to the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object.|  
|[CMFCColorBar::EnableAutomaticButton](#cmfccolorbar__enableautomaticbutton)|Shows or hides the automatic button.|  
|[CMFCColorBar::EnableOtherButton](#cmfccolorbar__enableotherbutton)|Enables or disables the display of a dialog box that lets the user select more colors.|  
|[CMFCColorBar::GetColor](#cmfccolorbar__getcolor)|Retrieves the currently selected color.|  
|[CMFCColorBar::GetCommandID](#cmfccolorbar__getcommandid)|Retrieves the command ID of the current color bar control.|  
|[CMFCColorBar::GetHighlightedColor](#cmfccolorbar__gethighlightedcolor)|Retrieves the color that signifies that a color button has the focus; that is, the button is *hot*.|  
|[CMFCColorBar::GetHorzMargin](#cmfccolorbar__gethorzmargin)|Retrieves the horizontal margin, which is the space between the left or right color cell and the client area boundary.|  
|[CMFCColorBar::GetVertMargin](#cmfccolorbar__getvertmargin)|Retrieves the vertical margin, which is the space between the top or bottom color cell and the client area boundary.|  
|[CMFCColorBar::IsTearOff](#cmfccolorbar__istearoff)|Indicates whether the current color bar is dockable.|  
|[CMFCColorBar::SetColor](#cmfccolorbar__setcolor)|Sets the color that is currently selected.|  
|[CMFCColorBar::SetColorName](#cmfccolorbar__setcolorname)|Sets a new name for a specified color.|  
|[CMFCColorBar::SetCommandID](#cmfccolorbar__setcommandid)|Sets a new command ID for a color bar control.|  
|[CMFCColorBar::SetDocumentColors](#cmfccolorbar__setdocumentcolors)|Sets the list of colors that are used in the current document.|  
|[CMFCColorBar::SetHorzMargin](#cmfccolorbar__sethorzmargin)|Sets the horizontal margin, which is the space between the left or right color cell and the client area boundary.|  
|[CMFCColorBar::SetVertMargin](#cmfccolorbar__setvertmargin)|Sets the vertical margin, which is the space between the top or bottom color cell and the client area boundary.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCColorBar::AdjustLocations](#cmfccolorbar__adjustlocations)|Adjusts the positions of the color buttons on the color bar control.|  
|[CMFCColorBar::AllowChangeTextLabels](#cmfccolorbar__allowchangetextlabels)|Indicates whether the text label of color buttons can change.|  
|[CMFCColorBar::AllowShowOnList](#cmfccolorbar__allowshowonlist)|Indicates whether the color bar control object can appear in a toolbar list during the customization process.|  
|[CMFCColorBar::CalcSize](#cmfccolorbar__calcsize)|Called by the framework as part of the layout calculation process.|  
|[CMFCColorBar::CreatePalette](#cmfccolorbar__createpalette)|Initalizes a palette with the colors in a specified array of colors.|  
|[CMFCColorBar::GetColorGridSize](#cmfccolorbar__getcolorgridsize)|Calculates the number of rows and columns in the grid of a color bar control.|  
|[CMFCColorBar::GetExtraHeight](#cmfccolorbar__getextraheight)|Calculates the additional height that the current color bar requires to display miscellaneous user interface elements such as the **Other** button, document colors, and so on.|  
|[CMFCColorBar::InitColors](#cmfccolorbar__initcolors)|Initializes an array of colors with the colors in a specified palette or the system default palette.|  
|[CMFCColorBar::OnKey](#cmfccolorbar__onkey)|Called by the framework when a user presses a keyboard button.|  
|[CMFCColorBar::OnSendCommand](#cmfccolorbar__onsendcommand)|Called by the framework to close a hierarchy of popup controls.|  
|[CMFCColorBar::OnUpdateCmdUI](#cmfccolorbar__onupdatecmdui)|Called by the framework to enable or disable a user-interface item of a color bar control before the item is displayed.|  
|[CMFCColorBar::OpenColorDialog](#cmfccolorbar__opencolordialog)|Opens a color dialog box.|  
|[CMFCColorBar::Rebuild](#cmfccolorbar__rebuild)|Completely redraws the color bar control.|  
|[CMFCColorBar::SelectPalette](#cmfccolorbar__selectpalette)|Sets the logical palette of the specified device context to the palette of the parent button of the current color bar control.|  
|[CMFCColorBar::SetPropList](#cmfccolorbar__setproplist)|Sets the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> protected data member to the specified pointer to a property grid control.|  
|[CMFCColorBar::ShowCommandMessageString](#cmfccolorbar__showcommandmessagestring)|Requests the frame window that owns the color bar control to update the message line in the status bar.|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|A Boolean field that determines whether mouse events are processed. Typically, mouse events are processed when this field is <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> and customization mode is <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|A Boolean that indicates whether a control is enabled.|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|A Boolean that indicates whether the color bar control supports docking.|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|A [CSize](../vs140/csize-class.md) object that specifies the size of a cell in a color bar grid.|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|A Boolean that indicates whether to show document colors when the color bar is docked. For more information, see [CMFCColorBar::SetDocumentColors](#cmfccolorbar__setdocumentcolors).|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|A Boolean that indicates whether to show the standard system color dialog box or the [CMFCColorDialog](../vs140/cmfccolordialog-class.md) dialog box. For more information, see [CMFCColorBar::EnableOtherButton](#cmfccolorbar__enableotherbutton).|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|A                                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) that stores the current automatic color. For more information, see [CMFCColorBar::EnableOtherButton](#cmfccolorbar__enableotherbutton).|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|An [CMap](../vs140/cmap-class.md) object that associates a set of RGB colors with their names.|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|A [CArray](../vs140/carray-class.md) of                                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) values that contains the colors that are displayed in the color bar control.|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|A                                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value that is the color that the user has currently selected from the color bar control.|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|A [CList](../vs140/clist-class.md) of                                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) values that contains the colors that are currently used in a document.|  
|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|An unsigned integer that is the command ID of a color button.|  
|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|An integer that is the horizontal margin between the color buttons in a grid of colors.|  
|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|An integer that is the horizontal offset to the center of the color button. This value is significant if the button displays text or an image in addition to a color.|  
|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|An integer that is the number of columns in a color bar control grid of colors.|  
|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|An integer that is the number of columns in a vertically oriented grid of colors.|  
|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|An integer that is the number of columns in a horizontally oriented grid of colors.|  
|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|An integer that is the height of a row of color buttons in a grid of colors.|  
|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|An integer that is the vertical margin between the color buttons in a grid of colors.|  
|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|An integer that is the vertical offset to the center of the color button. This value is significant if the button displays text or an image in addition to a color.|  
|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|A [CPalette](../vs140/cpalette-class.md) of the colors that are used in the color bar control.|  
|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|A pointer to a [CMFCColorButton](../vs140/cmfccolorbutton-class.md) object that is the parent of the current button. This value is significant if the color button is in a hierarchy of toolbar controls or is in a color property grid control.|  
|<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>|A pointer to a [CMFCRibbonColorButton](../vs140/cmfcribboncolorbutton-class.md) object that is on the ribbon and is the parent button of the current button. This value is significant if the color button is in a hierarchy of toolbar controls or is in a color property grid control.|  
|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|A pointer to a [CMFCPropertyGridCtrl](../vs140/cmfcpropertygridctrl-class.md) object.|  
|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|A [CString](../vs140/cstringt-class.md) that is the text that is displayed on the **Automatic** button. For more information, see [CMFCColorBar::EnableAutomaticButton](#cmfccolorbar__enableautomaticbutton).|  
|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|A [CString](../vs140/cstringt-class.md) that is the text that is displayed on the document colors button. For more information, see [CMFCColorBar::SetDocumentColors](#cmfccolorbar__setdocumentcolors).|  
|<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|A [CString](../vs140/cstringt-class.md) that is the text that is displayed on the *other* button. For more information, see [CMFCColorBar::EnableOtherButton](#cmfccolorbar__enableotherbutton).|  
  
## Remarks  
 Usually, you do not create a <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> object directly. Instead, the [CMFCColorMenuButton](../vs140/cmfccolormenubutton-class.md) (used in menus and toolbars) or the [CMFCColorButton](../vs140/cmfccolorbutton-class.md) creates the <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> object.  
  
 The <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> class provides the following functionality:  
  
-   Automatically adjusts the list of document colors.  
  
-   Saves and restores its state, together with the document state.  
  
-   Manages the "automatic" button.  
  
-   Uses the [CMFCColorPickerCtrl](../vs140/cmfccolorpickerctrl-class.md) control to select a custom color.  
  
-   Supports a "tear-off" state (if it is created by using the [CMFCColorMenuButton](../vs140/cmfccolormenubutton-class.md)).  
  
 To incorporate the <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> functionality into your application:  
  
1.  Create a regular menu button and assign it an ID, for example ID_CHAR_COLOR.  
  
2.  In your frame window class, override the [CFrameWndEx::OnShowPopupMenu](../vs140/cframewndex-class.md#cframewndex__onshowpopupmenu) method and replace the regular menu button with a [CMFCColorMenuButton](../vs140/cmfccolormenubutton-class.md) object (by calling [CMFCToolBar::ReplaceButton](../vs140/cmfctoolbar-class.md#cmfctoolbar__replacebutton)).  
  
3.  Set all the styles and enable or disable the features of the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> object during [CMFCColorMenuButton](../vs140/cmfccolormenubutton-class.md) creation. The <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> object dynamically creates the <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> object after the framework calls the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> method.  
  
 When the user clicks a color bar control button, the framework uses the <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> macro to notify the parent of the color bar control. In the macro, the command ID parameter is the value that you assigned to the color bar control button in step 1 (ID_CHAR_COLOR in this example). For more information, see the [CMFCColorMenuButton](../vs140/cmfccolormenubutton-class.md), [CMFCColorButton](../vs140/cmfccolorbutton-class.md), [CMFCColorPickerCtrl](../vs140/cmfccolorpickerctrl-class.md), [CMFCFrameWnd](../vs140/cframewndex-class.md), and [CMFCToolBar](../vs140/cmfctoolbar-class.md) classes.  
  
## Example  
 The following example demonstrates how to configure a color bar by using various methods in the <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> class. The methods set the horizontal and vertical margins, enable the other button, create a color bar control window, and sets the currently selected color. This example is part of the [New Controls sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_NewControls#1](../vs140/codesnippet/CPP/cmfccolorbar-class_1.h)]  
[!code[NVC_MFC_NewControls#2](../vs140/codesnippet/CPP/cmfccolorbar-class_2.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CBasePane](../vs140/cbasepane-class.md)  
  
 [CPane](../vs140/cpane-class.md)  
  
 [CMFCBaseToolBar](../vs140/cmfcbasetoolbar-class.md)  
  
 [CMFCToolBar](../vs140/cmfctoolbar-class.md)  
  
 [CMFCPopupMenuBar](../vs140/cmfcpopupmenubar-class.md)  
  
 [CMFCColorBar](../vs140/cmfccolorbar-class.md)  
  
## Requirements  
 **Header:** afxcolorbar.h  
  
##  \<a name="cmfccolorbar__adjustlocations">\</a>  CMFCColorBar::AdjustLocations  
 Adjusts the positions of the color buttons on the color bar control.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 This method is called by the framework during <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> message processing.  
  
##  \<a name="cmfccolorbar__allowchangetextlabels">\</a>  CMFCColorBar::AllowChangeTextLabels  
 Indicates whether the text label of color buttons can change.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 Always <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>.  
  
### Remarks  
 By default, this method always returns <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>, which means text labels cannot be modified. Override this method to enable modifying text labels.  
  
##  \<a name="cmfccolorbar__allowshowonlist">\</a>  CMFCColorBar::AllowShowOnList  
 Indicates whether the color bar control object can appear in a toolbar list during the customization process.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 Always <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>.  
  
### Remarks  
 By default, this method always returns <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>, which means the framework can display the color bar control during the customization process. Override this method to implement a different behavior.  
  
##  \<a name="cmfccolorbar__calcsize">\</a>  CMFCColorBar::CalcSize  
 Called by the framework as part of the layout calculation process.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> to specify that the color bar control is docked vertically; <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> to specify that the color bar control is docked horizontally.  
  
### Return Value  
 The size of the array of color buttons in a color bar control.  
  
##  \<a name="cmfccolorbar__cmfccolorbar">\</a>  CMFCColorBar::CMFCColorBar  
 Constructs a <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 An array of colors that the framework displays on the color bar control.  
  
 [in] <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 The initially selected color.  
  
 [in] <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 The text label of the *automatic* (default) color button, or <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>.  
  
 The standard label for the automatic button is **Automatic**.  
  
 [in] <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 The text label of the *other* button, which displays more color choices, or <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>.  
  
 The standard label for the other button is **More Colors...**.  
  
 [in] <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 The text label of the document colors button. The document colors palette lists all the colors that the document currently uses.  
  
 [in] <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 A list of colors that the document currently uses.  
  
 [in] <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 The number of columns that the array of colors has.  
  
 [in] <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 The number of rows that the color bar has when it is docked horizontally.  
  
 [in] <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
 The number of columns that the color bar has when it is docked vertically.  
  
 [in] <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 The default color that the framework applies when you click the automatic button.  
  
 [in] <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 The color bar control command ID.  
  
 [in] <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 A pointer to a parent button.  
  
 [in] <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
 An existing <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> object to be copied into the new <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> object.  
  
 [in] <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
 The command ID.  
  
##  \<a name="cmfccolorbar__contexttosize">\</a>  CMFCColorBar::ContextToSize  
 Calculates the vertical and horizontal margins that are required to contain the buttons on the color bar control, and adjusts the location of those buttons.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>107\</CodeContentPlaceHolder> to specify that the shape of the buttons on a color bar control are square; otherwise, <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>. The default value is <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>.|  
|[in] <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>111\</CodeContentPlaceHolder> to specify that the content on the face of a color bar control button is centered; otherwise, <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>. The default value is <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>.|  
  
### Remarks  
  
##  \<a name="cmfccolorbar__create">\</a>  CMFCColorBar::Create  
 Creates a color bar control window and attaches it to the <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
 Pointer to the parent window.  
  
 [in] <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
 A bitwise combination (OR) of [window styles](../vs140/window-styles.md).  
  
 [in] <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
 The command ID.  
  
 [in] <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 Pointer to a palette of colors. The default is <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 The number of columns in the color bar control. The default is 0.  
  
 [in] <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
 The number of rows in the color bar control when it is docked horizontally. The default is 0.  
  
 [in] <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
 The number of columns in the color bar control when it is docked vertically. The default is 0.  
  
### Return Value  
 <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>.  
  
### Remarks  
 To construct a <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> object, call the class constructor then this method. The <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> method creates the Windows control and initializes a list of colors.  
  
##  \<a name="cmfccolorbar__createcontrol">\</a>  CMFCColorBar::CreateControl  
 Creates a color bar control window, attaches it to the <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> object, and resizes the control window to contain the specified palette of colors.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
 Pointer to the parent window. Cannot be <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
 A bounding rectangle that specifies where to draw the color bar control.  
  
 [in] <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
 The control ID.  
  
 [in] <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
 The ideal number of columns in the color bar control. This method modifies that number to fit the specified palette of colors. The default is -1, which means this parameter is not specified.  
  
 [in] <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 Pointer to a palette of colors, or <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>. If this parameter is <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>, this method calculates the size of the color bar control as if 20 colors were specified. The default is <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> if this method succeeds; otherwise <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method uses the <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> parameters to calculate the appropriate number or rows and columns in the color bar control, and then calls the [CMFCColorBar::Create](#cmfccolorbar__create) method.  
  
##  \<a name="cmfccolorbar__createpalette">\</a>  CMFCColorBar::CreatePalette  
 Initializes a palette with the colors in a specified array of colors.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>|An array of colors.|  
|[in] <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>|A palette of colors.|  
  
### Return Value  
 <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfccolorbar__enableautomaticbutton">\</a>  CMFCColorBar::EnableAutomaticButton  
 Shows or hides the automatic button.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
 The text label of the *automatic* (default) color button, or <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>.  
  
 The standard label for the automatic button is **Automatic**.  
  
 [in] <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
 The default color that the framework applies when you click the automatic button.  
  
 [in] <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> to enable the automatic button; <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> to disable the automatic button. The default value is <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>.  
  
### Remarks  
 The text label of the automatic button is deleted if the <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> parameter is <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> or the <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> parameter is <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfccolorbar__enableotherbutton">\</a>  CMFCColorBar::EnableOtherButton  
 Enables or disables the display of a dialog box that lets the user select more colors.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>  
 The text label of the *other* button, which displays more color choices, or <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>.  
  
 The standard label for this button is **More Colors...**.  
  
 [in] <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> to display the [CMFCColorDialog](../vs140/cmfccolordialog-class.md) dialog box; <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> to display the standard [CColorDialog](../vs140/ccolordialog-class.md) dialog box. The default value is <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> to enable the                                button; <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> to disable the button. The default value is <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfccolorbar__getcolor">\</a>  CMFCColorBar::GetColor  
 Retrieves the currently selected color.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 The currently selected color.  
  
##  \<a name="cmfccolorbar__getcolorgridsize">\</a>  CMFCColorBar::GetColorGridSize  
 Calculates the number of rows and columns in the grid of a color bar control.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>168\</CodeContentPlaceHolder> to perform the calculation for a vertically docked color bar control; otherwise, perform the calculation for a horizontally docked control.|  
  
### Return Value  
 A [CSize](../vs140/csize-class.md) object whose <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> component contains the number of columns and whose <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> component contains the number of rows.  
  
##  \<a name="cmfccolorbar__getcommandid">\</a>  CMFCColorBar::GetCommandID  
 Retrieves the command ID of the current color bar control.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 A command ID.  
  
### Remarks  
 When the user selects a new color, the framework sends the command ID in a <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> message to notify the parent of the <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> object.  
  
##  \<a name="cmfccolorbar__getextraheight">\</a>  CMFCColorBar::GetExtraHeight  
 Calculates the additional height that the current color bar requires to display miscellaneous user interface elements, such as the **Other** button or document colors.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>|If the color bar control contains document colors, the number of columns to display in the grid of document colors. Otherwise, this value is not used.|  
  
### Return Value  
 The calculated extra height that is required.  
  
##  \<a name="cmfccolorbar__gethighlightedcolor">\</a>  CMFCColorBar::GetHighlightedColor  
 Retrieves the color that signifies that a color button has the focus; that is, the button is *hot*.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 An RGB value.  
  
### Remarks  
  
##  \<a name="cmfccolorbar__gethorzmargin">\</a>  CMFCColorBar::GetHorzMargin  
 Retrieves the horizontal margin, which is the space between the left or right color cell and the client area boundary.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 The horizontal margin.  
  
##  \<a name="cmfccolorbar__getvertmargin">\</a>  CMFCColorBar::GetVertMargin  
 Retrieves the vertical margin, which is the space between the top or bottom color cell and the client area boundary.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
 The vertical margin.  
  
##  \<a name="cmfccolorbar__initcolors">\</a>  CMFCColorBar::InitColors  
 Initializes an array of colors with the colors in a specified palette, or with the system default palette.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>|A pointer to a palette object, or <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>. If this parameter is <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>, this method uses the default palette of the operating system.|  
|[in] <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>|An array of colors.|  
  
### Return Value  
 The number of elements in the array of colors.  
  
##  \<a name="cmfccolorbar__istearoff">\</a>  CMFCColorBar::IsTearOff  
 Indicates whether the current color bar is dockable.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> if the current color bar control is dockable; otherwise, <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>.  
  
### Remarks  
 If the color bar control is dockable, it can be torn off a control bar and docked at another location.  
  
##  \<a name="cmfccolorbar__onkey">\</a>  CMFCColorBar::OnKey  
 Called by the framework when a user presses a keyboard button.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>  
 The virtual-key code for the key that a user pressed.  
  
### Return Value  
 <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> if this method processes the specified key; otherwise, <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfccolorbar__onsendcommand">\</a>  CMFCColorBar::OnSendCommand  
 Called by the framework to close a hierarchy of pop-up controls.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>|Pointer to a control that resides on a toolbar.|  
  
### Return Value  
 <CodeContentPlaceHolder>184\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfccolorbar__onupdatecmdui">\</a>  CMFCColorBar::OnUpdateCmdUI  
 Called by the framework to enable or disable a user-interface item of a color bar control before the item is displayed.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>  
 Pointer to a window that contains a user-interface item to update.  
  
 [in] <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>188\</CodeContentPlaceHolder> to disable the user-interface item if no handler is defined in a message map; otherwise, <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>.  
  
### Remarks  
 When a user of your application clicks a user-interface item, the item must know whether it should be displayed as enabled or disabled. The target of the command message provides this information by implementing an <CodeContentPlaceHolder>190\</CodeContentPlaceHolder> command handler. Use this method to help process the command. For more information, see [CCmdUI Class](../vs140/ccmdui-class.md).  
  
##  \<a name="cmfccolorbar__opencolordialog">\</a>  CMFCColorBar::OpenColorDialog  
 Opens a color dialog box.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>  
 The color that is selected by default when the color dialog box opens.  
  
 [out] <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>  
 The color that a user selected.  
  
### Return Value  
 <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> if the user selected a color; <CodeContentPlaceHolder>194\</CodeContentPlaceHolder> if the user canceled the color dialog box.  
  
### Remarks  
  
##  \<a name="cmfccolorbar__rebuild">\</a>  CMFCColorBar::Rebuild  
 Completely redraws the color bar control.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
##  \<a name="cmfccolorbar__selectpalette">\</a>  CMFCColorBar::SelectPalette  
 Sets the logical palette of the specified device context to the palette of the parent button of the current color bar control.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>|Pointer to the device context of the parent button of the current color bar control.|  
  
### Return Value  
 Pointer to the palette that is replaced by the palette of the parent button of the current color bar control.  
  
##  \<a name="cmfccolorbar__setcolor">\</a>  CMFCColorBar::SetColor  
 Sets the color that is currently selected.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>  
 An RGB color value.  
  
##  \<a name="cmfccolorbar__setcolorname">\</a>  CMFCColorBar::SetColorName  
 Sets a new name for a specified color.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>  
 The RGB value of a color.  
  
 [in] <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>  
 The new name for the specified color.  
  
### Remarks  
 This method changes the name of the specified color in all <CodeContentPlaceHolder>199\</CodeContentPlaceHolder> objects in your application.  
  
##  \<a name="cmfccolorbar__setcommandid">\</a>  CMFCColorBar::SetCommandID  
 Sets a new command ID for a color bar control.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>  
 A command ID.  
  
### Remarks  
 Call this method to modify the command ID of a color bar control and to notify the parent window of the control that the ID has changed.  
  
##  \<a name="cmfccolorbar__setdocumentcolors">\</a>  CMFCColorBar::SetDocumentColors  
 Sets the list of colors that are used in the current document.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>  
 A caption that is displayed when the color bar control is not docked.  
  
 [in] <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>  
 A list of colors that replaces the current document colors.  
  
 [in] <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>204\</CodeContentPlaceHolder> to show document colors when the color bar control is docked; otherwise, <CodeContentPlaceHolder>205\</CodeContentPlaceHolder>. The default value is <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>.  
  
### Remarks  
 *Document colors* are the colors that are currently used in a document. The framework automatically maintains a list of document colors, but you can use this method to modify the list.  
  
##  \<a name="cmfccolorbar__sethorzmargin">\</a>  CMFCColorBar::SetHorzMargin  
 Sets the horizontal margin, which is the space between the left or right color cell and the boundary of the client area.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>  
 The horizontal margin, in pixels.  
  
### Remarks  
 By default, the [CMFCColorBar::CMFCColorBar](#cmfccolorbar__cmfccolorbar) constructor sets the horizontal margin to 4 pixels.  
  
##  \<a name="cmfccolorbar__setproplist">\</a>  CMFCColorBar::SetPropList  
 Sets the <CodeContentPlaceHolder>208\</CodeContentPlaceHolder> protected data member to the specified pointer to a property grid control.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>209\</CodeContentPlaceHolder>|Pointer to property grid control object.|  
  
##  \<a name="cmfccolorbar__setvertmargin">\</a>  CMFCColorBar::SetVertMargin  
 Sets the vertical margin, which is the space between the top or bottom color cell and the client area boundary.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>210\</CodeContentPlaceHolder>  
 The vertical margin, in pixels.  
  
### Remarks  
 By default, the [CMFCColorBar::CMFCColorBar](#cmfccolorbar__cmfccolorbar) constructor sets the vertical margin to 4 pixels.  
  
##  \<a name="cmfccolorbar__showcommandmessagestring">\</a>  CMFCColorBar::ShowCommandMessageString  
 Requests the frame window that owns the color bar control to update the message line in the status bar.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>211\</CodeContentPlaceHolder>  
 A command ID. (This parameter is ignored.)  
  
### Remarks  
 This method sends the <CodeContentPlaceHolder>212\</CodeContentPlaceHolder> message to the owner of the color bar control.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)