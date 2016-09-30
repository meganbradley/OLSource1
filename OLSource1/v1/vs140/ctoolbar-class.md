---
title: "CToolBar Class"
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
  - "CToolBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Windows toolbar common controls [C++]"
  - "control bars [C++], CToolBar class"
  - "toolbars [C++], CToolBar class"
  - "buttons [C++], MFC toolbars"
  - "bitmaps [C++], button controls"
  - "CToolBar class"
  - "Windows common controls [C++], CToolBar class"
ms.assetid: e868da26-5e07-4607-9651-e2f863ad9059
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBar Class
Control bars that have a row of bitmapped buttons and optional separators.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CToolBar::CToolBar](#ctoolbar__ctoolbar)|Constructs a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CToolBar::CommandToIndex](#ctoolbar__commandtoindex)|Returns the index of a button with the given command ID.|  
|[CToolBar::Create](#ctoolbar__create)|Creates the Windows toolbar and attaches it to the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object.|  
|[CToolBar::CreateEx](#ctoolbar__createex)|Creates a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object with additional styles for the embedded <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object.|  
|[CToolBar::GetButtonInfo](#ctoolbar__getbuttoninfo)|Retrieves the ID, style, and image number of a button.|  
|[CToolBar::GetButtonStyle](#ctoolbar__getbuttonstyle)|Retrieves the style for a button.|  
|[CToolBar::GetButtonText](#ctoolbar__getbuttontext)|Retrieves the text that will appear on a button.|  
|[CToolBar::GetItemID](#ctoolbar__getitemid)|Returns the command ID of a button or separator at the given index.|  
|[CToolBar::GetItemRect](#ctoolbar__getitemrect)|Retrieves the display rectangle for the item at the given index.|  
|[CToolBar::GetToolBarCtrl](#ctoolbar__gettoolbarctrl)|Allows direct access to the underlying common control.|  
|[CToolBar::LoadBitmap](#ctoolbar__loadbitmap)|Loads the bitmap containing bitmap-button images.|  
|[CToolBar::LoadToolBar](#ctoolbar__loadtoolbar)|Loads a toolbar resource created with the resource editor.|  
|[CToolBar::SetBitmap](#ctoolbar__setbitmap)|Sets a bitmapped image.|  
|[CToolBar::SetButtonInfo](#ctoolbar__setbuttoninfo)|Sets the ID, style, and image number of a button.|  
|[CToolBar::SetButtons](#ctoolbar__setbuttons)|Sets button styles and an index of button images within the bitmap.|  
|[CToolBar::SetButtonStyle](#ctoolbar__setbuttonstyle)|Sets the style for a button.|  
|[CToolBar::SetButtonText](#ctoolbar__setbuttontext)|Sets the text that will appear on a button.|  
|[CToolBar::SetHeight](#ctoolbar__setheight)|Sets the height of the toolbar.|  
|[CToolBar::SetSizes](#ctoolbar__setsizes)|Sets the sizes of buttons and their bitmaps.|  
  
## Remarks  
 The buttons can act like pushbuttons, check-box buttons, or radio buttons. <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> objects are usually embedded members of frame-window objects derived from the class [CFrameWnd](../vs140/cframewnd-class.md) or [CMDIFrameWnd](../vs140/cmdiframewnd-class.md).  
  
 [CToolBar::GetToolBarCtrl](#ctoolbar__gettoolbarctrl), a member function new to MFC 4.0, allows you to take advantage of the Windows common control's support for toolbar customization and additional functionality. <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> member functions give you most of the functionality of the Windows common controls; however, when you call <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, you can give your toolbars even more of the characteristics of Windows 95/98 toolbars. When you call <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, it will return a reference to a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object. See [CToolBarCtrl](../vs140/ctoolbarctrl-class.md) for more information about designing toolbars using Windows common controls. For more general information about common controls, see                 [Common Controls](http://msdn.microsoft.com/library/windows/desktop/bb775493) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 Visual C++ provides you with two methods to create a toolbar. To create a toolbar resource using the Resource Editor, follow these steps:  
  
1.  Create a toolbar resource.  
  
2.  Construct the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object.  
  
3.  Call the [Create](#ctoolbar__create) (or [CreateEx](#ctoolbar__createex)) function to create the Windows toolbar and attach it to the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object.  
  
4.  Call [LoadToolBar](#ctoolbar__loadtoolbar) to load the toolbar resource.  
  
 Otherwise, follow these steps:  
  
1.  Construct the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object.  
  
2.  Call the [Create](#ctoolbar__create) (or [CreateEx](#ctoolbar__createex)) function to create the Windows toolbar and attach it to the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object.  
  
3.  Call [LoadBitmap](#ctoolbar__loadbitmap) to load the bitmap that contains the toolbar button images.  
  
4.  Call [SetButtons](#ctoolbar__setbuttons) to set the button style and associate each button with an image in the bitmap.  
  
 All the button images in the toolbar are taken from one bitmap, which must contain one image for each button. All images must be the same size; the default is 16 pixels wide and 15 pixels high. Images must be side by side in the bitmap.  
  
 The <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> function takes a pointer to an array of control IDs and an integer that specifies the number of elements in the array. The function sets each button's ID to the value of the corresponding element of the array and assigns each button an image index, which specifies the position of the button's image in the bitmap. If an array element has the value **ID_SEPARATOR**, no image index is assigned.  
  
 The order of the images in the bitmap is typically the order in which they are drawn on the screen, but you can use the [SetButtonInfo](#ctoolbar__setbuttoninfo) function to change the relationship between image order and drawing order.  
  
 All buttons in a toolbar are the same size. The default is 24 x 22 pixels, in accordance with                 *Windows Interface Guidelines for Software Design*. Any additional space between the image and button dimensions is used to form a border around the image.  
  
 Each button has one image. The various button states and styles (pressed, up, down, disabled, disabled down, and indeterminate) are generated from that one image. Although bitmaps can be any color, you can achieve the best results with images in black and shades of gray.  
  
> [!WARNING]
>  <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> supports bitmaps with a maximum of 16 colors. When you load an image into a toolbar editor, Visual Studio automatically converts the image to a 16-color bitmap, if necessary, and displays a warning message if the image was converted. If you use an image with more than 16 colors (using an external editor to edit the image), the application might behave unexpectedly.  
  
 Toolbar buttons imitate pushbuttons by default. However, toolbar buttons can also imitate check-box buttons or radio buttons. Check-box buttons have three states: checked, cleared, and indeterminate. Radio buttons have only two states: checked and cleared.  
  
 To set an individual button or separator style without pointing to an array, call [GetButtonStyle](#ctoolbar__getbuttonstyle) to retrieve the style, and then call [SetButtonStyle](#ctoolbar__setbuttonstyle) instead of <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is most useful when you want to change a button's style at run time.  
  
 To assign text to appear on a button, call [GetButtonText](#ctoolbar__getbuttontext) to retrieve the text to appear on the button, and then call [SetButtonText](#ctoolbar__setbuttontext) to set the text.  
  
 To create a check-box button, assign it the style **TBBS_CHECKBOX** or use a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object's <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> member function in an <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> handler. Calling <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> turns a pushbutton into a check-box button. Pass <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> an argument of 0 for unchecked, 1 for checked, or 2 for indeterminate.  
  
 To create a radio button, call a [CCmdUI](../vs140/ccmdui-class.md) object's [SetRadio](../vs140/ccmdui-class.md#ccmdui__setradio) member function from an <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> handler. Pass <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> an argument of 0 for unchecked or nonzero for checked. In order to provide a radio group's mutually exclusive behavior, you must have <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> handlers for all of the buttons in the group.  
  
 For more information on using <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, see the article [MFC Toolbar Implementation](../vs140/mfc-toolbar-implementation.md) and [Technical Note 31: Control Bars](../vs140/tn031--control-bars.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CControlBar](../vs140/ccontrolbar-class.md)  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxext.h  
  
##  \<a name="ctoolbar__commandtoindex">\</a>  CToolBar::CommandToIndex  
 This member function returns the index of the first toolbar button, starting at position 0, whose command ID matches <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 Command ID of a toolbar button.  
  
### Return Value  
 The index of the button, or –1 if no button has the given command ID.  
  
##  \<a name="ctoolbar__create">\</a>  CToolBar::Create  
 This member function creates a Windows toolbar (a child window) and associates it with the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 Pointer to the window that is the toolbar's parent.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 The toolbar style. Additional toolbar styles supported are:  
  
-   <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> Control bar is at top of the frame window.  
  
-   <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> Control bar is at bottom of the frame window.  
  
-   <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> Control bar is not repositioned when the parent is resized.  
  
-   <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> Control bar displays tool tips.  
  
-   **CBRS_SIZE_DYNAMIC** Control bar is dynamic.  
  
-   **CBRS_SIZE_FIXED** Control bar is fixed.  
  
-   **CBRS_FLOATING** Control bar is floating.  
  
-   <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> Status bar displays information about the button.  
  
-   **CBRS_HIDE_INPLACE** Control bar is not displayed to the user.  
  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 The toolbar's child-window ID.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 It also sets the toolbar height to a default value.  
  
### Example  
 [!code[NVC_MFCDocView#179](../vs140/codesnippet/CPP/ctoolbar-class_1.cpp)]  
  
##  \<a name="ctoolbar__createex">\</a>  CToolBar::CreateEx  
 Call this function to create a Windows toolbar (a child window) and associate it with the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 Pointer to the window that is the toolbar's parent.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 Additional styles for the creation of the embedded [CToolBarCtrl](../vs140/ctoolbarctrl-class.md) object. By default, this value is set to **TBSTYLE_FLAT**. For a complete list of toolbar styles, see <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 The toolbar style. See                                 [Toolbar Control and Button Styles](http://msdn.microsoft.com/library/windows/desktop/bb760439) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of appropriate styles.  
  
 *rcBorders*  
 A [CRect](../vs140/crect-class.md) object that defines the widths of the toolbar window borders. These borders are set to 0,0,0,0 by default, thereby resulting in a toolbar window with no borders.  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 The toolbar's child-window ID.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 It also sets the toolbar height to a default value.  
  
 Use <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, instead of [Create](#ctoolbar__create), when certain styles need to be present during the creation of the embedded tool bar control. For example, set <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> to **TBSTYLE_FLAT &#124; TBSTYLE_TRANSPARENT** to create a toolbar that resembles the Internet Explorer 4 toolbars.  
  
### Example  
 [!code[NVC_MFCDocView#180](../vs140/codesnippet/CPP/ctoolbar-class_2.cpp)]  
  
##  \<a name="ctoolbar__ctoolbar">\</a>  CToolBar::CToolBar  
 This member function constructs a <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> object and sets the default sizes.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 Call the [Create](#ctoolbar__create) member function to create the toolbar window.  
  
##  \<a name="ctoolbar__getbuttoninfo">\</a>  CToolBar::GetButtonInfo  
 This member function retrieves the control ID, style, and image index of the toolbar button or separator at the location specified by                 *nIndex.*  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 Index of the toolbar button or separator whose information is to be retrieved.  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 Reference to a **UINT** that is set to the command ID of the button.  
  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 Reference to a **UINT** that is set to the style of the button.  
  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 Reference to an integer that is set to the index of the button's image within the bitmap.  
  
### Remarks  
 Those values are assigned to the variables referenced by <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>. The image index is the position of the image within the bitmap that contains images for all the toolbar buttons. The first image is at position 0.  
  
 If <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> specifies a separator, <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> is set to the separator width in pixels.  
  
##  \<a name="ctoolbar__getbuttonstyle">\</a>  CToolBar::GetButtonStyle  
 Call this member function to retrieve the style of a button or separator on the toolbar.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 The index of the toolbar button or separator style to be retrieved.  
  
### Return Value  
 The style of the button or separator specified by <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>.  
  
### Remarks  
 A button's style determines how the button appears and how it responds to user input. See [SetButtonStyle](#ctoolbar__setbuttonstyle) for examples of button styles.  
  
##  \<a name="ctoolbar__getbuttontext">\</a>  CToolBar::GetButtonText  
 Call this member function to retrieve the text that appears on a button.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 Index of the text to be retrieved.  
  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 A reference to a [CString](../vs140/cstringt-class.md) object that will contain the text to be retrieved.  
  
### Return Value  
 A <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> object containing the button text.  
  
### Remarks  
 The second form of this member function fills a <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> object with the string text.  
  
##  \<a name="ctoolbar__getitemid">\</a>  CToolBar::GetItemID  
 This member function returns the command ID of the button or separator specified by <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 Index of the item whose ID is to be retrieved.  
  
### Return Value  
 The command ID of the button or separator specified by <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>.  
  
### Remarks  
 Separators return **ID_SEPARATOR**.  
  
##  \<a name="ctoolbar__getitemrect">\</a>  CToolBar::GetItemRect  
 This member function fills the <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> structure whose address is contained in <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> with the coordinates of the button or separator specified by <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 Index of the item (button or separator) whose rectangle coordinates are to be retrieved.  
  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 Address of the [RECT](../vs140/rect-structure.md) structure that will contain the item's coordinates.  
  
### Remarks  
 Coordinates are in pixels relative to the upper-left corner of the toolbar.  
  
 Use <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> to get the coordinates of a separator you want to replace with a combo box or other control.  
  
### Example  
  See the example for [CToolBar::SetSizes](#ctoolbar__setsizes).  
  
##  \<a name="ctoolbar__gettoolbarctrl">\</a>  CToolBar::GetToolBarCtrl  
 This member function allows direct access to the underlying common control.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 A reference to a <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> object.  
  
### Remarks  
 Use <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> to take advantage of the functionality of the Windows toolbar common control, and to take advantage of the support [CToolBarCtrl](../vs140/ctoolbarctrl-class.md) provides for toolbar customization.  
  
 For more information about using common controls, see the article [Controls](../vs140/controls--mfc-.md) and                         [Common Controls](http://msdn.microsoft.com/library/windows/desktop/bb775493) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFCDocViewSDI#15](../vs140/codesnippet/CPP/ctoolbar-class_3.cpp)]  
  
##  \<a name="ctoolbar__loadbitmap">\</a>  CToolBar::LoadBitmap  
 Call this member function to load the bitmap specified by <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 Pointer to the resource name of the bitmap to be loaded.  
  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 Resource ID of the bitmap to be loaded.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The bitmap should contain one image for each toolbar button. If the images are not of the standard size (16 pixels wide and 15 pixels high), call [SetSizes](#ctoolbar__setsizes) to set the button sizes and their images.  
  
> [!WARNING]
>  <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> supports bitmaps with a maximum of 16 colors. When you load an image into a toolbar editor, Visual Studio automatically converts the image to a 16-color bitmap, if necessary, and displays a warning message if the image was converted. If you use an image with more than 16 colors (using an external editor to edit the image), the application might behave unexpectedly.  
  
##  \<a name="ctoolbar__loadtoolbar">\</a>  CToolBar::LoadToolBar  
 Call this member function to load the toolbar specified by <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 Pointer to the resource name of the toolbar to be loaded.  
  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 Resource ID of the toolbar to be loaded.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 See [toolbar editor](../vs140/toolbar-editor.md) in for more information about creating a toolbar resource.  
  
### Example  
  See the example for [CToolBar::CreateEx](#ctoolbar__createex).  
  
##  \<a name="ctoolbar__setbitmap">\</a>  CToolBar::SetBitmap  
 Call this member function to set the bitmap image for the toolbar.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 *hbmImageWell*  
 Handle of a bitmap image that is associated with a toolbar.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 For example, call <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> to change the bitmapped image after the user takes an action on a document that changes the action of a button.  
  
##  \<a name="ctoolbar__setbuttoninfo">\</a>  CToolBar::SetButtonInfo  
 Call this member function to set the button's command ID, style, and image number.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 Zero-based index of the button or separator for which information is to be set.  
  
 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
 The value to which the button's command ID is set.  
  
 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
 The new button style. The following button styles are supported:  
  
-   **TBBS_BUTTON** Standard pushbutton (default)  
  
-   **TBBS_SEPARATOR** Separator  
  
-   **TBBS_CHECKBOX** Auto check-box button  
  
-   **TBBS_GROUP** Marks the start of a group of buttons  
  
-   **TBBS_CHECKGROUP** Marks the start of a group of check-box buttons  
  
-   **TBBS_DROPDOWN** Creates a drop-down list button.  
  
-   **TBBS_AUTOSIZE** The button's width will be calculated based on the text of the button, not on the size of the image.  
  
-   **TBBS_NOPREFIX** The button text will not have an accelerator prefix associated with it.  
  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 New index for the button's image within the bitmap.  
  
### Remarks  
 For separators, which have the style **TBBS_SEPARATOR**, this function sets the separator's width in pixels to the value stored in <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  You can also set button states using the <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> parameter; however, because button states are controlled by the [ON_UPDATE_COMMAND_UI](../vs140/on_update_command_ui.md) handler, any state you set using <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> will be lost during the next idle processing. See [How to Update User-Interface Objects](../vs140/how-to--update-user-interface-objects.md) and [TN031: Control Bars](../vs140/tn031--control-bars.md) for more information.  
  
 For information on bitmap images and buttons, see the [CToolBar](../vs140/ctoolbar-class.md) Overview and [CToolBar::LoadBitmap](#ctoolbar__loadbitmap).  
  
##  \<a name="ctoolbar__setbuttons">\</a>  CToolBar::SetButtons  
 This member function sets each toolbar button's command ID to the value specified by the corresponding element of the array <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 Pointer to an array of command Ids. It can be **NULL** to allocate empty buttons.  
  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
 Number of elements in the array pointed to by <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 If an element of the array has the value **ID_SEPARATOR**, a separator is created in the corresponding position of the toolbar. This function also sets each button's style to **TBBS_BUTTON** and each separator's style to **TBBS_SEPARATOR**, and assigns an image index to each button. The image index specifies the position of the button's image within the bitmap.  
  
 You do not need to account for separators in the bitmap because this function does not assign image indexes for separators. If your toolbar has buttons at positions 0, 1, and 3 and a separator at position 2, the images at positions 0, 1, and 2 in your bitmap are assigned to the buttons at positions 0, 1, and 3, respectively.  
  
 If <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> is **NULL**, this function allocates space for the number of items specified by <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>. Use [SetButtonInfo](#ctoolbar__setbuttoninfo) to set each item's attributes.  
  
##  \<a name="ctoolbar__setbuttonstyle">\</a>  CToolBar::SetButtonStyle  
 Call this member function to set the style of a button or separator, or to group buttons.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
 Index of the button or separator whose information is to be set.  
  
 <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
 The button style. The following button styles are supported:  
  
-   **TBBS_BUTTON** Standard pushbutton (default)  
  
-   **TBBS_SEPARATOR** Separator  
  
-   **TBBS_CHECKBOX** Auto check-box button  
  
-   **TBBS_GROUP** Marks the start of a group of buttons  
  
-   **TBBS_CHECKGROUP** Marks the start of a group of check-box buttons  
  
-   **TBBS_DROPDOWN** Creates a drop-down list button  
  
-   **TBBS_AUTOSIZE** The button's width will be calculated based on the text of the button, not on the size of the image  
  
-   **TBBS_NOPREFIX** The button text will not have an accelerator prefix associated with it  
  
### Remarks  
 A button's style determines how the button appears and how it responds to user input.  
  
 Before calling <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>, call the [GetButtonStyle](#ctoolbar__getbuttonstyle) member function to retrieve the button or separator style.  
  
> [!NOTE]
>  You can also set button states using the <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> parameter; however, because button states are controlled by the [ON_UPDATE_COMMAND_UI](../vs140/on_update_command_ui.md) handler, any state you set using <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> will be lost during the next idle processing. See [How to Update User-Interface Objects](../vs140/how-to--update-user-interface-objects.md) and [TN031: Control Bars](../vs140/tn031--control-bars.md) for more information.  
  
##  \<a name="ctoolbar__setbuttontext">\</a>  CToolBar::SetButtonText  
 Call this function to set the text on a button.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
 Index of the button whose text is to be set.  
  
 <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
 Points to the text to be set on a button.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Example  
  See the example for [CToolBar::GetToolBarCtrl](#ctoolbar__gettoolbarctrl).  
  
##  \<a name="ctoolbar__setheight">\</a>  CToolBar::SetHeight  
 This member function sets the toolbar's height to the value, in pixels, specified in <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
 The height in pixels of the toolbar.  
  
### Remarks  
 After calling [SetSizes](#ctoolbar__setsizes), use this member function to override the standard toolbar height. If the height is too small, the buttons will be clipped at the bottom.  
  
 If this function is not called, the framework uses the size of the button to determine the toolbar height.  
  
##  \<a name="ctoolbar__setsizes">\</a>  CToolBar::SetSizes  
 Call this member function to set the toolbar's buttons to the size, in pixels, specified in                 *sizeButton*.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 *sizeButton*  
 The size in pixels of each button.  
  
 <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
 The size in pixels of each image.  
  
### Remarks  
 The <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> parameter must contain the size, in pixels, of the images in the toolbar's bitmap. The dimensions in                         *sizeButton* must be sufficient to hold the image plus 7 pixels extra in width and 6 pixels extra in height. This function also sets the toolbar height to fit the buttons.  
  
 Call this member function only for toolbars that do not follow                         *Windows Interface Guidelines for Software Design* recommendations for button and image sizes.  
  
### Example  
 [!code[NVC_MFCListView#8](../vs140/codesnippet/CPP/ctoolbar-class_4.cpp)]  
  
## See Also  
 [MFC Sample CTRLBARS](../vs140/visual-c---samples.md)   
 [MFC Sample DLGCBR32](../vs140/visual-c---samples.md)   
 [MFC Sample DOCKTOOL](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/ccontrolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl](../vs140/ctoolbarctrl-class.md)   
 [CControlBar](../vs140/ccontrolbar-class.md)   
 [CToolBar::Create](#ctoolbar__create)   
 [CToolBar::LoadBitmap](#ctoolbar__loadbitmap)   
 [CToolBar::SetButtons](#ctoolbar__setbuttons)   
 [CCmdUI::SetCheck](../vs140/ccmdui-class.md#ccmdui__setcheck)   
 [CCmdUI::SetRadio](../vs140/ccmdui-class.md#ccmdui__setradio)