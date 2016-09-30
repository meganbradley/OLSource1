---
title: "CMFCColorMenuButton Class"
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
  - "CMFCColorMenuButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCColorMenuButton class"
ms.assetid: 42685704-e994-4f7b-9553-62283c27b754
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorMenuButton Class
The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> class supports a menu command or a toolbar button that starts a color picker dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCColorMenuButton::CMFCColorMenuButton](#cmfccolormenubutton__cmfccolormenubutton)|Constructs a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCColorMenuButton::EnableAutomaticButton](#cmfccolormenubutton__enableautomaticbutton)|Enables and disables an "automatic" button that is positioned above the regular color buttons. (The standard system automatic button is labeled **Automatic**.)|  
|[CMFCColorMenuButton::EnableDocumentColors](#cmfccolormenubutton__enabledocumentcolors)|Enables the display of document-specific colors instead of system colors.|  
|[CMFCColorMenuButton::EnableOtherButton](#cmfccolormenubutton__enableotherbutton)|Enables and disables an "other" button that is positioned below the regular color buttons. (The standard system "other" button is labeled **More Colors…**.)|  
|[CMFCColorMenuButton::EnableTearOff](#cmfccolormenubutton__enabletearoff)|Enables the ability to tear off a color pane.|  
|[CMFCColorMenuButton::GetAutomaticColor](#cmfccolormenubutton__getautomaticcolor)|Retrieves the current automatic color.|  
|[CMFCColorMenuButton::GetColor](#cmfccolormenubutton__getcolor)|Retrieves the current button's color.|  
|[CMFCColorMenuButton::GetColorByCmdID](#cmfccolormenubutton__getcolorbycmdid)|Retrieves the color that corresponds to a specified command ID.|  
|[CMFCColorMenuButton::OnChangeParentWnd](#cmfccolormenubutton__onchangeparentwnd)|Called by the framework when the parent window changes.|  
|[CMFCColorMenuButton::OpenColorDialog](#cmfccolormenubutton__opencolordialog)|Opens a color selection dialog box.|  
|[CMFCColorMenuButton::SetColor](#cmfccolormenubutton__setcolor)|Sets the color of the current color button.|  
|[CMFCColorMenuButton::SetColorByCmdID](#cmfccolormenubutton__setcolorbycmdid)|Sets the color of the specified color menu button.|  
|[CMFCColorMenuButton::SetColorName](#cmfccolormenubutton__setcolorname)|Sets a new name for the specified color.|  
|[CMFCColorMenuButton::SetColumnsNumber](#cmfccolormenubutton__setcolumnsnumber)|Sets the number of columns that are displayed by a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCColorMenuButton::CopyFrom](#cmfccolormenubutton__copyfrom)|Copies another toolbar button to the current button.|  
|[CMFCColorMenuButton::CreatePopupMenu](#cmfccolormenubutton__createpopupmenu)|Creates a color picker dialog box.|  
|[CMFCColorMenuButton::IsEmptyMenuAllowed](#cmfccolormenubutton__isemptymenuallowed)|Indicates whether empty menus are supported.|  
|[CMFCColorMenuButton::OnDraw](#cmfccolormenubutton__ondraw)|Called by the framework to display an image on a button.|  
|[CMFCColorMenuButton::OnDrawOnCustomizeList](#cmfccolormenubutton__ondrawoncustomizelist)|Called by the framework before a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object is displayed in the list of a toolbar customization dialog box.|  
  
## Remarks  
 To replace the original menu command or toolbar button with a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object, create the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object, set any appropriate [CMFCColorBar](../vs140/cmfccolorbar-class.md) styles, and then call the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> method of the [CMFCToolBar](../vs140/cmfctoolbar-class.md) class. If you customize a toolbar, call the [CMFCToolBarsCustomizeDialog::ReplaceButton](../vs140/cmfctoolbarscustomizedialog-class.md#cmfctoolbarscustomizedialog__replacebutton) method.  
  
 The color picker dialog box is created during the processing of the [CreatePopupMenu](#cmfccolormenubutton__createpopupmenu) event handler. The event handler notifies the parent frame with a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> message. The <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object sends the control ID that is assigned to the original menu command or toolbar button.  
  
## Example  
 The following example demonstrates how to create and configure a color menu button by using various methods in the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> class. In the example, a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object is first created and then used to construct an object of the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> class. The <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object is then configured by enabling its automatic and other buttons, and setting its color and the number of columns. This code is part of the [Word Pad sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_WordPad#5](../vs140/codesnippet/CPP/cmfccolormenubutton-class_1.h)]  
[!code[NVC_MFC_WordPad#6](../vs140/codesnippet/CPP/cmfccolormenubutton-class_2.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMFCToolBarButton](../vs140/cmfctoolbarbutton-class.md)  
  
 [CMFCToolBarMenuButton](../vs140/cmfctoolbarmenubutton-class.md)  
  
 [CMFCColorMenuButton](../vs140/cmfccolormenubutton-class.md)  
  
## Requirements  
 **Header:** afxcolormenubutton.h  
  
##  \<a name="cmfccolormenubutton__cmfccolormenubutton">\</a>  CMFCColorMenuButton::CMFCColorMenuButton  
 Constructs a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 A button command ID.  
  
 [in] <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The button text.  
  
 [in] <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 A pointer to the button's color palette.  
  
### Return Value  
  
### Remarks  
 The first constructor is the default constructor. The object's current color and automatic color are initialized to black (RGB(0, 0, 0)).  
  
 The second constructor initializes the button to the color that corresponds to the specified command ID.  
  
##  \<a name="cmfccolormenubutton__copyfrom">\</a>  CMFCColorMenuButton::CopyFrom  
 Copies one [CMFCToolBarMenuButton](../vs140/cmfctoolbarmenubutton-class.md)-derived object to another.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 Source button to copy.  
  
### Remarks  
 Override this method to copy objects that are derived from the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object.  
  
##  \<a name="cmfccolormenubutton__createpopupmenu">\</a>  CMFCColorMenuButton::CreatePopupMenu  
 Creates a color picker dialog box.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 An object that represents a color picker dialog box.  
  
### Remarks  
 This method is called by the framework when the user presses a color menu button.  
  
##  \<a name="cmfccolormenubutton__enableautomaticbutton">\</a>  CMFCColorMenuButton::EnableAutomaticButton  
 Enables and disables an "automatic" button that is positioned above the regular color buttons. (The standard system automatic button is labeled **Automatic**.)  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 Specifies the button text that is displayed when the button becomes automatic.  
  
 [in] <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 Specifies a new automatic color.  
  
 [in] <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 Specifies whether the button is automatic or not.  
  
### Remarks  
 The automatic button applies the current default color.  
  
##  \<a name="cmfccolormenubutton__enabledocumentcolors">\</a>  CMFCColorMenuButton::EnableDocumentColors  
 Enables the display of document-specific colors instead of system colors.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 Specifies the button text.  
  
 [in] <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> to display document-specific colors or <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> to display system colors.  
  
### Remarks  
 Use this method to display the current document colors or the system palette colors when the user clicks a color menu button.  
  
##  \<a name="cmfccolormenubutton__enableotherbutton">\</a>  CMFCColorMenuButton::EnableOtherButton  
 Enables and disables an "other" button that is positioned below the regular color buttons. (The standard system "other" button is labeled **More Colors…**.)  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 Specifies the button text.  
  
 [in] <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 Specify <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> to display the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> dialog box, or  <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> to display the standard system color dialog box.  
  
 [in] <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 Specify <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> to display the "other" button; otherwise, <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>. The default is <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfccolormenubutton__enabletearoff">\</a>  CMFCColorMenuButton::EnableTearOff  
 Enables the ability to tear off a color pane.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 Specifies the ID for the tear-off pane.  
  
 [in] <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 Specifies the number of columns in the vertically docked color pane while in tear-off state.  
  
 [in] <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 Specifies the number of rows for the horizontally docked color pane while in tear-off state.  
  
### Remarks  
 Call this method to enable the "tear-off" feature for the color pane that pops up when the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> button is pressed.  
  
##  \<a name="cmfccolormenubutton__getautomaticcolor">\</a>  CMFCColorMenuButton::GetAutomaticColor  
 Retrieves the current automatic color.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 An RGB color value that represents the current automatic color.  
  
### Remarks  
 Call this method to obtain the automatic color that is set by [CMFCColorMenuButton::EnableAutomaticButton](#cmfccolormenubutton__enableautomaticbutton).  
  
##  \<a name="cmfccolormenubutton__getcolor">\</a>  CMFCColorMenuButton::GetColor  
 Retrieves the current button's color.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 The color of the button.  
  
### Remarks  
  
##  \<a name="cmfccolormenubutton__getcolorbycmdid">\</a>  CMFCColorMenuButton::GetColorByCmdID  
 Retrieves the color that corresponds to a specified command ID.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 A command ID.  
  
### Return Value  
 The color that corresponds to the specified command ID.  
  
### Remarks  
 Use this method when you have several color buttons in an application. When the user clicks a color button, the button sends its command ID in a <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> message to its parent. The <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> method uses the command ID to retrieve the corresponding color.  
  
##  \<a name="cmfccolormenubutton__isemptymenuallowed">\</a>  CMFCColorMenuButton::IsEmptyMenuAllowed  
 Indicates whether empty menus are supported.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if empty menus are allowed; otherwise, zero.  
  
### Remarks  
 Empty menus are supported by default. Override this method to change this behavior in derived class.  
  
##  \<a name="cmfccolormenubutton__onchangeparentwnd">\</a>  CMFCColorMenuButton::OnChangeParentWnd  
 Called by the framework when the parent window changes.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 A pointer to the new parent window.  
  
### Remarks  
  
##  \<a name="cmfccolormenubutton__ondraw">\</a>  CMFCColorMenuButton::OnDraw  
 Called by the framework to display an image on a button.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 A rectangle that bounds the area to be redrawn.  
  
 [in] <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 Points to a list of toolbar images.  
  
 [in] <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> to specify that the toolbar is in a horizontal docked state; otherwise, <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>. The default is <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> to specify that the application is in customization mode; otherwise, <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>. The default is <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> to specify that the button is highlighted; otherwise, <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>. The default is <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> to specify that the button's border is displayed; otherwise, <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>. The default is <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> to specify that disabled buttons are grayed (dimmed) out; otherwise, <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>. The default is <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfccolormenubutton__ondrawoncustomizelist">\</a>  CMFCColorMenuButton::OnDrawOnCustomizeList  
 Called by the framework before a <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> object is displayed in the list of a toolbar customization dialog box.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 A rectangle that bounds the button to be drawn.  
  
 [in] <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> specifies that the button is in selected state; otherwise, <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>.  
  
### Return Value  
 The width of the button.  
  
### Remarks  
 This method is called by the framework when a <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> object is displayed in the list box during the toolbar customization process.  
  
##  \<a name="cmfccolormenubutton__opencolordialog">\</a>  CMFCColorMenuButton::OpenColorDialog  
 Opens a color selection dialog box.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 The default color that is selected in the color dialog box.  
  
 [out] <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 Returns the color that the user selects from the color dialog box.  
  
### Return Value  
 Nonzero if the user selects a new color; otherwise, zero.  
  
### Remarks  
 When the menu button is clicked, call this method to open a color dialog box. If the return value is nonzero, the color that the user selects is stored in the <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> parameter. Use the [EnableOtherButton](#cmfccolormenubutton__enableotherbutton) method to switch between the standard color dialog box and the [CMFCColorDialog](../vs140/cmfccolordialog-class.md) dialog box.  
  
##  \<a name="cmfccolormenubutton__setcolor">\</a>  CMFCColorMenuButton::SetColor  
 Sets the color of the current color button.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 An RGB color value.  
  
 [in] <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> to apply the <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> parameter color to any associated menu button or toolbar button; otherwise, <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>.  
  
### Remarks  
 Call this method to change the color of the current color button. If the <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> parameter is nonzero, the color of the corresponding button on any associated popup menu or toolbar is changed to the color specified by the <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> parameter.  
  
##  \<a name="cmfccolormenubutton__setcolorbycmdid">\</a>  CMFCColorMenuButton::SetColorByCmdID  
 Sets the color of the specified color menu button.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 The resource ID of a color menu button.  
  
 [in] <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
 An RGB color value.  
  
##  \<a name="cmfccolormenubutton__setcolorname">\</a>  CMFCColorMenuButton::SetColorName  
 Sets a new name for the specified color.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
 The RGB value of the color whose name changes.  
  
 [in] <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 The new name of the color.  
  
### Remarks  
  
##  \<a name="cmfccolormenubutton__setcolumnsnumber">\</a>  CMFCColorMenuButton::SetColumnsNumber  
 Sets the number of columns to display in a color selection control ( [CMFCColorBar](../vs140/cmfccolorbar-class.md) object).  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
 The number of columns to display.  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCColorBar](../vs140/cmfccolorbar-class.md)   
 [CMFCToolBar](../vs140/cmfctoolbar-class.md)   
 [CMFCToolbarCustomize](../vs140/cmfctoolbarscustomizedialog-class.md)   
 [CMFCColorButton](../vs140/cmfccolorbutton-class.md)