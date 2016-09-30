---
title: "CMFCColorButton Class"
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
  - "CMFCColorButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCColorButton::m_Color data member"
  - "CMFCColorButton::m_bAutoSetFocus data member"
  - "CMFCColorButton::m_pPopup data member"
  - "CMFCColorButton::m_nColumns data member"
  - "CMFCColorButton class"
  - "CMFCColorButton::m_strAutoColorText data member"
  - "CMFCColorButton::m_bAltColorDlg data member"
  - "CMFCColorButton::m_strDocColorsText data member"
  - "CMFCColorButton::m_strOtherText data member"
  - "CMFCColorButton::m_pPalette data member"
  - "CMFCColorButton::m_lstDocColors data member"
  - "CMFCColorButton::m_ColorAutomatic data member"
ms.assetid: 9fdf34ae-4cc5-4c5e-9d89-1c50e8a73699
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorButton Class
The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and [CMFCColorBar](../vs140/cmfccolorbar-class.md) classes are used together to implement a color picker control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCColorButton](#cmfccolorbutton__cmfccolorbutton)|Constructs a new <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[EnableAutomaticButton](#cmfccolorbutton__enableautomaticbutton)|Enables and disables an "automatic" button that is positioned above the regular color buttons. (The standard system automatic button is labeled **Automatic**.)|  
|[EnableOtherButton](#cmfccolorbutton__enableotherbutton)|Enables and disables an "other" button that is positioned below the regular color buttons. (The standard system "other" button is labeled **More Colors…**.)|  
|[GetAutomaticColor](#cmfccolorbutton__getautomaticcolor)|Retrieves the current automatic color.|  
|[GetColor](#cmfccolorbutton__getcolor)|Retrieves a button's color.|  
|[SetColor](#cmfccolorbutton__setcolor)|Sets a button's color.|  
|[SetColorName](#cmfccolorbutton__setcolorname)|Sets a color name.|  
|[SetColumnsNumber](#cmfccolorbutton__setcolumnsnumber)|Sets the number of columns on the color picker dialog box.|  
|[SetDocumentColors](#cmfccolorbutton__setdocumentcolors)|Specifies a list of document-specific colors that are displayed on the color picker dialog box.|  
|[SetPalette](#cmfccolorbutton__setpalette)|Specifies a palette of standard display colors.|  
|[SizeToContent](#cmfccolorbutton__sizetocontent)|Changes the size of the button control, depending on its text and image size.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IsDrawXPTheme](#cmfccolorbutton__isdrawxptheme)|Indicates whether the current color button is displayed in the visual style of Windows XP.|  
|[OnDraw](#cmfccolorbutton__ondraw)|Called by the framework to display an image of the button.|  
|[OnDrawBorder](#cmfccolorbutton__ondrawborder)|Called by the framework to display the button's border.|  
|[OnDrawFocusRect](#cmfccolorbutton__ondrawfocusrect)|Called by the framework to display a focus rectangle when the button has a focus.|  
|[OnShowColorPopup](#cmfccolorbutton__onshowcolorpopup)|Called by the framework when the color picker dialog box is about to be displayed.|  
|[RebuildPalette](#cmfccolorbutton__rebuildpalette)|Initializes the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> protected data member to the specified palette or the default system palette.|  
|[UpdateColor](#cmfccolorbutton__updatecolor)|Called by the framework when the user selects a color from the palette of the color picker dialog box.|  
  
### Data Members  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|A Boolean. If <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, the framework displays the [CMFCColorDialog](../vs140/cmfccolordialog-class.md) color dialog box when the *other* button is clicked, or if <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, the system color dialog box. The default value is <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. For more information, see [CMFCColorButton::EnableOtherButton](#cmfccolorbutton__enableotherbutton).|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|A Boolean. If <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, the framework sets the focus on the color menu when the menu is displayed, or if <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, does not change the focus. The default value is <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.|  
|[m_bEnabledInCustomizeMode](#cmfccolorbutton__m_benabledincustomizemode)|Indicates whether customization mode is enabled for the color button.|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|A                                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value. Contains the currently selected color.|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|A                                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value. Contains the currently selected default color.|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|A [CArray](../vs140/carray-class.md) of                                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) values. Contains the currently available colors.|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|A [CList](../vs140/clist-class.md) of                                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) values. Contains the current document colors.|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|An integer. Contains the number of columns to display in the grid of colors in a color selection menu.|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|A pointer to a [CPalette](../vs140/cpalette-class.md). Contains the colors that are available in the current color selection menu.|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|A pointer to a [CMFCColorPopupMenu Class](../vs140/cmfccolorpopupmenu-class.md) object. The color selection menu that is displayed when you click the color button.|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|A string. The label of the "automatic" button in a color selection menu.|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|A string. The label of the button in a color selection menu that displays the document colors.|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|A string. The label of the "other" button in a color selection menu.|  
  
## Remarks  
 By default, the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> class behaves as a push button that opens a color picker dialog box. The color picker dialog box contains an array of small color buttons and an "other" button that displays a custom color picker. (The standard system "other" button is labeled **More Colors…**.) When a user selects a new color, the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object reflects the change and displays the selected color.  
  
 Create a color button control either directly in your code, or by using the **ClassWizard** tool and a dialog box template. If you create a color button control directly, add a <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> variable to your application, and then call the constructor and <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> methods of the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object. If you use the **ClassWizard**, add a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> variable to your application, and then change the type of the variable from <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.  
  
 The color picker dialog box ( [CMFCColorBar](../vs140/cmfccolorbar-class.md)) is displayed by the [OnShowColorPopup](#cmfccolorbutton__onshowcolorpopup) method when the framework calls the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> event handler. The [OnShowColorPopup](#cmfccolorbutton__onshowcolorpopup) method can be overridden to support custom color selection.  
  
 The <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object notifies its parent that a color is changing by sending it a <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> notification. The parent uses the [GetColor](#cmfccolorbutton__getcolor) method to retrieve the current color.  
  
## Example  
 The following example demonstrates how to configure a color button by using various methods in the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> class. The methods set the color of the color button and its number of columns, and enable the automatic and the other buttons. This example is part of the [Status Bar Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_StatusBarDemo#10](../vs140/codesnippet/CPP/cmfccolorbutton-class_1.h)]  
[!code[NVC_MFC_StatusBarDemo#11](../vs140/codesnippet/CPP/cmfccolorbutton-class_2.cpp)]  
  
## Requirements  
 **Header:** afxcolorbutton.h  
  
##  \<a name="cmfccolorbutton__cmfccolorbutton">\</a>  CMFCColorButton::CMFCColorButton  
 Constructs a new <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="cmfccolorbutton__enableautomaticbutton">\</a>  CMFCColorButton::EnableAutomaticButton  
 Enable or disable the "automatic" button of a color picker control and set the automatic (default) color.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 Specifies the automatic button's text.  
  
 [in] <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 An RGB value that specifies the automatic button's default color.  
  
 [in] <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 Specifies whether the automatic button is enabled or disabled.  
  
### Remarks  
  
##  \<a name="cmfccolorbutton__enableotherbutton">\</a>  CMFCColorButton::EnableOtherButton  
 Enable or disable the "other" button, which appears below regular color buttons.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 Specifies the button's text.  
  
 [in] <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 Specifies whether the [CMFCColorDialog](../vs140/cmfccolordialog-class.md) dialog box or the system color dialog box is opened when the user clicks the button.  
  
 [in] <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 Specifies whether the "other" button is enabled or disabled.  
  
### Remarks  
 Click the "other" button to display a color dialog box. If the                         *bAltColorDlg* parameter is <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, the [CMFCColorDialog Class](../vs140/cmfccolordialog-class.md) is displayed; otherwise, the system color dialog box is displayed.  
  
##  \<a name="cmfccolorbutton__getautomaticcolor">\</a>  CMFCColorButton::GetAutomaticColor  
 Retrieves the current automatic (default) color.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 An RGB value representing the current automatic color.  
  
### Remarks  
 The current automatic color is set by the [EnableAutomaticButton](#cmfccolorbutton__enableautomaticbutton) method.  
  
##  \<a name="cmfccolorbutton__getcolor">\</a>  CMFCColorButton::GetColor  
 Retrieves the currently selected color.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 An RGB value.  
  
### Remarks  
  
##  \<a name="cmfccolorbutton__isdrawxptheme">\</a>  CMFCColorButton::IsDrawXPTheme  
 Indicates whether the current color button is displayed in the visual style of Windows XP.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> if visual styles are supported and the current color button is displayed in the visual style of Windows XP; otherwise, <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfccolorbutton__m_benabledincustomizemode">\</a>  CMFCColorButton::m_bEnabledInCustomizeMode  
 Sets a color button to customization mode.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 If you need to add a color button to a customization dialog's page (or allow the user to make another color selection during customization), enable the button by setting the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> member to <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>. By default, this member is set to <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfccolorbutton__ondraw">\</a>  CMFCColorButton::OnDraw  
 Called by the framework to render an image of the button.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 Points to the device context that is used to render the image of the button.  
  
 [in] <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 A rectangle that bounds the button.  
  
 [in] <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 Specifies the visual state of the button.  
  
### Remarks  
 Override this method to customize the rendering process.  
  
##  \<a name="cmfccolorbutton__ondrawborder">\</a>  CMFCColorButton::OnDrawBorder  
 Called by the framework to display the border of the button.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 Points to the device context used to draw the border.  
  
 [in] <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 A rectangle in the device context that is specified by the the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> parameter that defines the boundaries of the button to be drawn.  
  
 [in] <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 Specifies the visual state of the button.  
  
### Remarks  
 Override this function to customize the color button's border appearance.  
  
##  \<a name="cmfccolorbutton__ondrawfocusrect">\</a>  CMFCColorButton::OnDrawFocusRect  
 Called by the framework to display a focus rectangle when the button has focus.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 Points to the device context used to draw the focus rectangle.  
  
 [in] <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 A rectangle in the device context specified by the <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> parameter that defines the boundaries of the button.  
  
### Remarks  
 Override this method to customize appearance of the focus rectangle.  
  
##  \<a name="cmfccolorbutton__onshowcolorpopup">\</a>  CMFCColorButton::OnShowColorPopup  
 Called before the popup color bar is displayed.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfccolorbutton__rebuildpalette">\</a>  CMFCColorButton::RebuildPalette  
 Initializes the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> protected data member to the specified palette or the default system palette.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>|A pointer to a logical palette or <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>, the default system palette is used.|  
  
##  \<a name="cmfccolorbutton__setcolor">\</a>  CMFCColorButton::SetColor  
 Specifies the color of the button.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 An RGB value.  
  
### Remarks  
  
##  \<a name="cmfccolorbutton__setcolorname">\</a>  CMFCColorButton::SetColorName  
 Specifies the name of a color.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 The color's RGB value.  
  
 [in] <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 The color's name.  
  
### Remarks  
 The list of color names is global per application. Consequently, this method transfers its parameters to [CMFCColorBar::SetColorName](../vs140/cmfccolorbar-class.md#cmfccolorbar__setcolorname).  
  
##  \<a name="cmfccolorbutton__setcolumnsnumber">\</a>  CMFCColorButton::SetColumnsNumber  
 Defines the number of columns that are displayed in the table of colors that is presented to the user during the user's color selection process.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 Specifies the number of columns.  
  
### Remarks  
 The user can select a color from a popup color bar that displays a table of predefined colors. Use this method to define the number of columns in the table.  
  
##  \<a name="cmfccolorbutton__setdocumentcolors">\</a>  CMFCColorButton::SetDocumentColors  
 Specifies a set of colors and the set's name. The set of colors is displayed using a [CMFCColorBar](../vs140/cmfccolorbar-class.md) object.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 Specifies the label to be displayed with the set of document colors.  
  
 [in] <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 A reference to a list of RGB values.  
  
### Remarks  
 A <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> object maintains a list of RGB values that are transferred to a [CMFCColorBar](../vs140/cmfccolorbar-class.md) object. When the color bar is displayed, these colors are shown in a special section whose label is specified by the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> parameter.  
  
##  \<a name="cmfccolorbutton__setpalette">\</a>  CMFCColorButton::SetPalette  
 Specifies the standard colors to display on the popup color bar.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 A pointer to a color palette.  
  
### Remarks  
  
##  \<a name="cmfccolorbutton__sizetocontent">\</a>  CMFCColorButton::SizeToContent  
 Resizes the button control to fit its text and image.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 If nonzero, the new size of the button control is calculated but the actual size is not changed.  
  
### Return Value  
 A <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> object that specifies a new button control size.  
  
### Remarks  
  
##  \<a name="cmfccolorbutton__updatecolor">\</a>  CMFCColorButton::UpdateColor  
 Called by the framework when the user selects a color from the color bar that displays when the user clicks the color button.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 A color selected by the user.  
  
### Remarks  
 The <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> function changes the currently selected button's color and notifies its parent by sending a <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> message with a <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> standard notification. Use the [GetColor](#cmfccolorbutton__getcolor) method to retrieve the selected color.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCButton](../vs140/cmfcbutton-class.md)   
 [CMFCColorBar](../vs140/cmfccolorbar-class.md)   
 [CMFCColorButton::OnShowColorPopup](#cmfccolorbutton__onshowcolorpopup)   
 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449)   
 [CPalette Class](../vs140/cpalette-class.md)   
 [CArray Class](../vs140/carray-class.md)   
 [CList Class](../vs140/clist-class.md)   
 [CString](../vs140/cstringt-class.md)