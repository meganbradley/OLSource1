---
title: "CToolBarCtrl Class"
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
  - "CToolBarCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CToolBarCtrl class"
  - "Windows common controls [C++], CToolBarCtrl"
  - "toolbar controls [MFC], CToolBarCtrl class"
  - "tool tips [C++], notifications"
ms.assetid: 8f2f8ad2-05d7-4975-8715-3f2eed795248
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl Class
Provides the functionality of the Windows toolbar common control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CToolBarCtrl::CToolBarCtrl](#ctoolbarctrl__ctoolbarctrl)|Constructs a <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CToolBarCtrl::AddBitmap](#ctoolbarctrl__addbitmap)|Adds one or more bitmap button images to the list of button images available for a toolbar control.|  
|[CToolBarCtrl::AddButtons](#ctoolbarctrl__addbuttons)|Adds one or more buttons to a toolbar control.|  
|[CToolBarCtrl::AddString](#ctoolbarctrl__addstring)|Adds a new string, passed as a resource ID, to the toolbar's internal list of strings.|  
|[CToolBarCtrl::AddStrings](#ctoolbarctrl__addstrings)|Adds a new string or strings, passed as a pointer to a buffer of null-separated strings, to the toolbar's internal list of strings.|  
|[CToolBarCtrl::AutoSize](#ctoolbarctrl__autosize)|Resizes a toolbar control.|  
|[CToolBarCtrl::ChangeBitmap](#ctoolbarctrl__changebitmap)|Changes the bitmap for a button in the current toolbar control.|  
|[CToolBarCtrl::CheckButton](#ctoolbarctrl__checkbutton)|Checks or clears a given button in a toolbar control.|  
|[CToolBarCtrl::CommandToIndex](#ctoolbarctrl__commandtoindex)|Retrieves the zero-based index for the button associated with the specified command identifier.|  
|[CToolBarCtrl::Create](#ctoolbarctrl__create)|Creates a toolbar control and attaches it to a <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> object.|  
|[CToolBarCtrl::CreateEx](#ctoolbarctrl__createex)|Creates a toolbar control with the specified Windows extended styles and attaches it to a <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> object.|  
|[CToolBarCtrl::Customize](#ctoolbarctrl__customize)|Displays the Customize Toolbar dialog box.|  
|[CToolBarCtrl::DeleteButton](#ctoolbarctrl__deletebutton)|Deletes a button from the toolbar control.|  
|[CToolBarCtrl::EnableButton](#ctoolbarctrl__enablebutton)|Enables or disables the specified button in a toolbar control.|  
|[CToolBarCtrl::GetAnchorHighlight](#ctoolbarctrl__getanchorhighlight)|Retrieves the anchor highlight setting for a toolbar.|  
|[CToolBarCtrl::GetBitmap](#ctoolbarctrl__getbitmap)|Retrieves the index of the bitmap associated with a button in a toolbar.|  
|[CToolBarCtrl::GetBitmapFlags](#ctoolbarctrl__getbitmapflags)|Gets flags associated with the toolbar's bitmap.|  
|[CToolBarCtrl::GetButton](#ctoolbarctrl__getbutton)|Retrieves information about the specified button in a toolbar control.|  
|[CToolBarCtrl::GetButtonCount](#ctoolbarctrl__getbuttoncount)|Retrieves a count of the buttons currently in the toolbar control.|  
|[CToolBarCtrl::GetButtonInfo](#ctoolbarctrl__getbuttoninfo)|Retrieves the information for a button in a toolbar.|  
|[CToolBarCtrl::GetButtonSize](#ctoolbarctrl__getbuttonsize)|Retrieves the current width and height of toolbar buttons, in pixels.|  
|[CToolBarCtrl::GetColorScheme](#ctoolbarctrl__getcolorscheme)|Retrieves the color scheme of the current toolbar control.|  
|[CToolBarCtrl::GetDisabledImageList](#ctoolbarctrl__getdisabledimagelist)|Retrieves the image list that a toolbar control uses to display disabled buttons.|  
|[CToolBarCtrl::GetDropTarget](#ctoolbarctrl__getdroptarget)|Retrieves the                                         [IDropTarget](http://msdn.microsoft.com/library/windows/desktop/ms679679) interface for a toolbar control.|  
|[CToolBarCtrl::GetExtendedStyle](#ctoolbarctrl__getextendedstyle)|Retrieves the extended styles for a toolbar control.|  
|[CToolBarCtrl::GetHotImageList](#ctoolbarctrl__gethotimagelist)|Retrieves the image list that a toolbar control uses to display "hot" buttons. A hot button appears highlighted when the mouse pointer is above it.|  
|[CToolBarCtrl::GetHotItem](#ctoolbarctrl__gethotitem)|Retrieves the index of the hot item in a toolbar.|  
|[CToolBarCtrl::GetImageList](#ctoolbarctrl__getimagelist)|Retrieves the image list that a toolbar control uses to display buttons in their default state.|  
|[CToolBarCtrl::GetInsertMark](#ctoolbarctrl__getinsertmark)|Retrieves the current insertion mark for the toolbar.|  
|[CToolBarCtrl::GetInsertMarkColor](#ctoolbarctrl__getinsertmarkcolor)|Retrieves the color used to draw the insertion mark for the toolbar.|  
|[CToolBarCtrl::GetItemRect](#ctoolbarctrl__getitemrect)|Retrieves the bounding rectangle of a button in a toolbar control.|  
|[CToolBarCtrl::GetMaxSize](#ctoolbarctrl__getmaxsize)|Retrieves the total size of all of the visible buttons and separators in the toolbar.|  
|[CToolBarCtrl::GetMaxTextRows](#ctoolbarctrl__getmaxtextrows)|Retrieves the maximum number of text rows displayed on a toolbar button.|  
|[CToolBarCtrl::GetMetrics](#ctoolbarctrl__getmetrics)|Retrieves the metrics of a toolbar control.|  
|[CToolBarCtrl::GetPadding](#ctoolbarctrl__getpadding)|Retrieves the horizontal and vertical padding of the current toolbar control.|  
|[CToolBarCtrl::GetPressedImageList](#ctoolbarctrl__getpressedimagelist)|Retrieves the image list that the current toolbar control uses to represent buttons in the pressed state.|  
|[CToolBarCtrl::GetRect](#ctoolbarctrl__getrect)|Retrieves the bounding rectangle for a specified toolbar button.|  
|[CToolBarCtrl::GetRows](#ctoolbarctrl__getrows)|Retrieves the number of rows of buttons currently displayed in the toolbar.|  
|[CToolBarCtrl::GetState](#ctoolbarctrl__getstate)|Retrieves information about the state of the specified button in a toolbar control, such as whether it is enabled, pressed, or checked.|  
|[CToolBarCtrl::GetString](#ctoolbarctrl__getstring)|Retrieves a toolbar string.|  
|[CToolBarCtrl::GetStyle](#ctoolbarctrl__getstyle)|Retrieves the styles currently in use for a toolbar control.|  
|[CToolBarCtrl::GetToolTips](#ctoolbarctrl__gettooltips)|Retrieves the handle of the tool tip control, if any, associated with the toolbar control.|  
|[CToolBarCtrl::HideButton](#ctoolbarctrl__hidebutton)|Hides or shows the specified button in a toolbar control.|  
|[CToolBarCtrl::HitTest](#ctoolbarctrl__hittest)|Determines where a point lies in a toolbar control.|  
|[CToolBarCtrl::Indeterminate](#ctoolbarctrl__indeterminate)|Sets or clears the indeterminate (gray) state of the specified button in a toolbar control.|  
|[CToolBarCtrl::InsertButton](#ctoolbarctrl__insertbutton)|Inserts a button in a toolbar control.|  
|[CToolBarCtrl::InsertMarkHitTest](#ctoolbarctrl__insertmarkhittest)|Retrieves the insertion mark information for a point in a toolbar.|  
|[CToolBarCtrl::IsButtonChecked](#ctoolbarctrl__isbuttonchecked)|Tells whether the specified button in a toolbar control is checked.|  
|[CToolBarCtrl::IsButtonEnabled](#ctoolbarctrl__isbuttonenabled)|Tells whether the specified button in a toolbar control is enabled.|  
|[CToolBarCtrl::IsButtonHidden](#ctoolbarctrl__isbuttonhidden)|Tells whether the specified button in a toolbar control is hidden.|  
|[CToolBarCtrl::IsButtonHighlighted](#ctoolbarctrl__isbuttonhighlighted)|Checks the highlight state of the toolbar button.|  
|[CToolBarCtrl::IsButtonIndeterminate](#ctoolbarctrl__isbuttonindeterminate)|Tells whether the state of the specified button in a toolbar control is indeterminate (gray).|  
|[CToolBarCtrl::IsButtonPressed](#ctoolbarctrl__isbuttonpressed)|Tells whether the specified button in a toolbar control is pressed.|  
|[CToolBarCtrl::LoadImages](#ctoolbarctrl__loadimages)|Loads bitmaps into a toolbar control's image list.|  
|[CToolBarCtrl::MapAccelerator](#ctoolbarctrl__mapaccelerator)|Maps an accelerator character to a toolbar button.|  
|[CToolBarCtrl::MarkButton](#ctoolbarctrl__markbutton)|Sets the highlight state of a given button in a toolbar control.|  
|[CToolBarCtrl::MoveButton](#ctoolbarctrl__movebutton)|Moves a button from one index to another.|  
|[CToolBarCtrl::PressButton](#ctoolbarctrl__pressbutton)|Presses or releases the specified button in a toolbar control.|  
|[CToolBarCtrl::ReplaceBitmap](#ctoolbarctrl__replacebitmap)|Replaces the existing bitmap in the current toolbar control with a new bitmap.|  
|[CToolBarCtrl::RestoreState](#ctoolbarctrl__restorestate)|Restores the state of the toolbar control.|  
|[CToolBarCtrl::SaveState](#ctoolbarctrl__savestate)|Saves the state of the toolbar control.|  
|[CToolBarCtrl::SetAnchorHighlight](#ctoolbarctrl__setanchorhighlight)|Sets the anchor highlight setting for a toolbar.|  
|[CToolBarCtrl::SetBitmapSize](#ctoolbarctrl__setbitmapsize)|Sets the size of the bitmapped images to be added to a toolbar control.|  
|[CToolBarCtrl::SetButtonInfo](#ctoolbarctrl__setbuttoninfo)|Sets the information for an existing button in a toolbar.|  
|[CToolBarCtrl::SetButtonSize](#ctoolbarctrl__setbuttonsize)|Sets the size of the buttons to be added to a toolbar control.|  
|[CToolBarCtrl::SetButtonStructSize](#ctoolbarctrl__setbuttonstructsize)|Specifies the size of the <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> structure.|  
|[CToolBarCtrl::SetButtonWidth](#ctoolbarctrl__setbuttonwidth)|Sets the minimum and maximum button widths in the toolbar control.|  
|[CToolBarCtrl::SetCmdID](#ctoolbarctrl__setcmdid)|Sets the command identifier to be sent to the owner window when the specified button is pressed.|  
|[CToolBarCtrl::SetColorScheme](#ctoolbarctrl__setcolorscheme)|Sets the color scheme of the current toolbar control.|  
|[CToolBarCtrl::SetDisabledImageList](#ctoolbarctrl__setdisabledimagelist)|Sets the image list that the toolbar control will use to display disabled buttons.|  
|[CToolBarCtrl::SetDrawTextFlags](#ctoolbarctrl__setdrawtextflags)|Sets the flags in the Win32 function                                         [DrawText](http://msdn.microsoft.com/library/windows/desktop/dd162498), which is used to draw the text in the specified rectangle, formatted according to how the flags are set.|  
|[CToolBarCtrl::SetExtendedStyle](#ctoolbarctrl__setextendedstyle)|Sets the extended styles for a toolbar control.|  
|[CToolBarCtrl::SetHotImageList](#ctoolbarctrl__sethotimagelist)|Sets the image list that the toolbar control will use to display "hot" buttons.|  
|[CToolBarCtrl::SetHotItem](#ctoolbarctrl__sethotitem)|Sets the hot item in a toolbar.|  
|[CToolBarCtrl::SetImageList](#ctoolbarctrl__setimagelist)|Sets the image list that the toolbar will use to display buttons that are in their default state.|  
|[CToolBarCtrl::SetIndent](#ctoolbarctrl__setindent)|Sets the indentation for the first button in a toolbar control.|  
|[CToolBarCtrl::SetInsertMark](#ctoolbarctrl__setinsertmark)|Sets the current insertion mark for the toolbar.|  
|[CToolBarCtrl::SetInsertMarkColor](#ctoolbarctrl__setinsertmarkcolor)|Sets the color used to draw the insertion mark for the toolbar.|  
|[CToolBarCtrl::SetMaxTextRows](#ctoolbarctrl__setmaxtextrows)|Sets the maximum number of text rows displayed on a toolbar button.|  
|[CToolBarCtrl::SetMetrics](#ctoolbarctrl__setmetrics)|Sets the metrics of a toolbar control.|  
|[CToolBarCtrl::SetOwner](#ctoolbarctrl__setowner)|Sets the window to receive notification messages from the toolbar control.|  
|[CToolBarCtrl::SetPadding](#ctoolbarctrl__setpadding)|Sets the horizontal and vertical padding of the current toolbar control.|  
|[CToolBarCtrl::SetPressedImageList](#ctoolbarctrl__setpressedimagelist)|Sets the image list that the current toolbar control uses to represent buttons in the pressed state.|  
|[CToolBarCtrl::SetRows](#ctoolbarctrl__setrows)|Sets the number of rows of buttons displayed in the toolbar.|  
|[CToolBarCtrl::SetState](#ctoolbarctrl__setstate)|Sets the state for the specified button in a toolbar control.|  
|[CToolBarCtrl::SetStyle](#ctoolbarctrl__setstyle)|Sets the styles for a toolbar control.|  
|[CToolBarCtrl::SetToolTips](#ctoolbarctrl__settooltips)|Associates a tool tip control with the toolbar control.|  
|[CToolBarCtrl::SetWindowTheme](#ctoolbarctrl__setwindowtheme)|Sets the visual style of a toolbar control.|  
  
## Remarks  
 This control (and therefore the <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> class) is available only to programs running under Windows 95/98 and Windows NT version 3.51 and later.  
  
 A Windows toolbar common control is a rectangular child window that contains one or more buttons. These buttons can display a bitmap image, a string, or both. When the user chooses a button, it sends a command message to the toolbar's owner window. Typically, the buttons in a toolbar correspond to items in the application's menu; they provide a more direct way for the user to access an application's commands.  
  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> objects contain several important internal data structures: a list of button image bitmaps or an image list, a list of button label strings, and a list of <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> structures which associate an image and/or string with the position, style, state, and command ID of the button. Each of the elements of these data structures is referred to by a zero-based index. Before you can use a <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> object, you must set up these data structures. The list of strings can only be used for button labels; you cannot retrieve strings from the toolbar.  
  
 To use a <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> object, you will typically follow these steps:  
  
1.  Construct the <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> object.  
  
2.  Call [Create](#ctoolbarctrl__create) to create the Windows toolbar common control and attach it to the <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> object. Indicate the style of toolbar by using styles, such as **TBSTYLE_TRANSPARENT** for a transparent toolbar or **TBSTYLE_DROPDOWN** for a toolbar that supports drop-down style buttons.  
  
3.  Identify how you want the buttons on the toolbar displayed:  
  
    -   To use bitmap images for buttons, add the button bitmaps to the toolbar by calling [AddBitmap](#ctoolbarctrl__addbitmap).  
  
    -   To use images displayed from an image list for buttons, specify the image list by calling [SetImageList](#ctoolbarctrl__setimagelist), [SetHotImageList](#ctoolbarctrl__sethotimagelist), or [SetDisabledImageList](#ctoolbarctrl__setdisabledimagelist).  
  
    -   To use string labels for buttons, add the strings to the toolbar by calling [AddString](#ctoolbarctrl__addstring) and/or [AddStrings](#ctoolbarctrl__addstrings).  
  
4.  Add button structures to the toolbar by calling [AddButtons](#ctoolbarctrl__addbuttons).  
  
5.  If you want tool tips for a toolbar button in an owner window that is not a <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>, you need to handle the **TTN_NEEDTEXT** messages in the toolbar's owner window as described in [Handling Tool Tip Notifications](../vs140/handling-tool-tip-notifications.md). If the parent window of the toolbar is derived from <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>, tool tips are displayed without any extra effort from you because <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> provides a default handler.  
  
6.  If you want your user to be able to customize the toolbar, handle customization notification messages in the owner window as described in [Handling Customization Notifications](../vs140/handling-customization-notifications.md).  
  
 You can use [SaveState](#ctoolbarctrl__savestate) to save the current state of a toolbar control in the registry and [RestoreState](#ctoolbarctrl__restorestate) to restore the state based on information previously stored in the registry. In addition to saving the toolbar state between uses of the application, applications typically store the state before the user begins customizing the toolbar in case the user later wants to restore the toolbar to its original state.  
  
## Support for Internet Explorer Version 4.0 and Later  
 To support functionality introduced in Internet Explorer, version 4.0 and later, MFC provides image list support and transparent and flat styles for toolbar controls.  
  
 A transparent toolbar allows the client under the toolbar to show through. To create a transparent toolbar, use both **TBSTYLE_FLAT** and **TBSTYLE_TRANSPARENT** styles. Transparent toolbars feature hot tracking; that is, when the mouse pointer moves over a hot button on the toolbar, the button's appearance changes. Toolbars created with just the **TBSTYLE_FLAT** style will contain buttons that are not transparent.  
  
 Image list support allows a control greater flexibility for default behavior, hot images, and disabled images. Use [GetImageList](#ctoolbarctrl__getimagelist), [GetHotImageList](#ctoolbarctrl__gethotimagelist), and [GetDisabledImageList](#ctoolbarctrl__getdisabledimagelist) with the transparent toolbar to manipulate the image according to its state:  
  
 For more information on using <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>, see [Controls](../vs140/controls--mfc-.md) and [Using CToolBarCtrl](../vs140/using-ctoolbarctrl.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxcmn.h  
  
##  \<a name="ctoolbarctrl__addbitmap">\</a>  CToolBarCtrl::AddBitmap  
 Adds one or more button images to the list of button images stored in the toolbar control.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 Number of button images in the bitmap.  
  
 <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
 Resource identifier of the bitmap that contains the button image or images to add.  
  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 Pointer to the <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> object that contains the button image or images to add.  
  
### Return Value  
 Zero-based index of the first new image if successful; otherwise – 1.  
  
### Remarks  
 You can use the Windows API                         [CreateMappedBitmap](http://msdn.microsoft.com/library/windows/desktop/bb787467) to map colors before adding the bitmap to the toolbar. If you pass a pointer to a **CBitMap** object, you must ensure that the bitmap is not destroyed until after the toolbar is destroyed.  
  
##  \<a name="ctoolbarctrl__addbuttons">\</a>  CToolBarCtrl::AddButtons  
 Adds one or more buttons to a toolbar control.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 Number of buttons to add.  
  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 Address of an array of <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> structures that contains information about the buttons to add. There must be the same number of elements in the array as buttons specified by <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>.  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
### Remarks  
 The <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> pointer points to an array of <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> structures. Each <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> structure associates the button being added with the button's style, image and/or string, command ID, state, and user-defined data:  
  
 <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
  
 The members are as follows:  
  
 **iBitmap**  
 Zero-based index of button image, -1 if no image for this button.  
  
 **idCommand**  
 Command identifier associated with the button. This identifier is sent in a **WM_COMMAND** message when the button is chosen. If the **fsStyle** member has the <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> value, this member must be zero.  
  
 **fsState**  
 Button state flags. It can be a combination of the values listed below:  
  
-   <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> The button has the **TBSTYLE_CHECKED** style and is being pressed.  
  
-   <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> The button accepts user input. A button that does not have this state does not accept user input and is grayed.  
  
-   <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> The button is not visible and cannot receive user input.  
  
-   <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> The button is grayed.  
  
-   <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> The button is being pressed.  
  
-   <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> A line break follows the button. The button must also have the <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> state.  
  
 **fsStyle**  
 Button style. It can be a combination of the values listed below:  
  
-   <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> Creates a standard push button.  
  
-   <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> Creates a button that toggles between the pressed and unpressed states each time the user clicks it. The button has a different background color when it is in the pressed state.  
  
-   <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> Creates a check button that stays pressed until another button in the group is pressed.  
  
-   <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> Creates a button that stays pressed until another button in the group is pressed.  
  
-   <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> Creates a separator, providing a small gap between button groups. A button that has this style does not receive user input.  
  
 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
 User-defined data.  
  
 **iString**  
 Zero-based index of the string to use as the button's label, -1 if there is no string for this button.  
  
 The image and/or string whose index you provide must have previously been added to the toolbar control's list using [AddBitmap](#ctoolbarctrl__addbitmap), [AddString](#ctoolbarctrl__addstring), and/or [AddStrings](#ctoolbarctrl__addstrings).  
  
##  \<a name="ctoolbarctrl__addstring">\</a>  CToolBarCtrl::AddString  
 Adds a new string, passed as a resource ID, to the toolbar's internal list of strings.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 *nStringID*  
 Resource identifier of the string resource to add to the toolbar control's string list.  
  
### Return Value  
 The zero-based index of the first new string added if successful; otherwise –1.  
  
##  \<a name="ctoolbarctrl__addstrings">\</a>  CToolBarCtrl::AddStrings  
 Adds a new string or strings to the list of strings available for a toolbar control.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 *lpszStrings*  
 Address of a buffer that contains one or more null-terminated strings to add to the toolbar's string list. The last string must be terminated with two null characters.  
  
### Return Value  
 The zero-based index of the first new string added if successful; otherwise –1.  
  
### Remarks  
 Strings in the buffer must be separated by a null character. You must ensure that the last string has two null terminators. To properly format a constant string, you might write it as:  
  
 [!code[NVC_MFCControlLadenDialog#72](../vs140/codesnippet/CPP/ctoolbarctrl-class_1.cpp)]  
  
 or:  
  
 [!code[NVC_MFCControlLadenDialog#73](../vs140/codesnippet/CPP/ctoolbarctrl-class_2.cpp)]  
  
 You should not pass a <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> object to this function since it is not possible to have more than one null character in a <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>.  
  
##  \<a name="ctoolbarctrl__autosize">\</a>  CToolBarCtrl::AutoSize  
 Resizes the entire toolbar control.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 You should call this function when the size of the parent window changes or when the size of the toolbar changes (such as when you set the button or bitmap size, or add strings).  
  
##  \<a name="ctoolbarctrl__changebitmap">\</a>  CToolBarCtrl::ChangeBitmap  
 Changes the bitmap for a button in the current toolbar control.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>|Command identifier of the button that is to receive a new bitmap.|  
|[in] <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>|Zero-based index of an image in the current toolbar control's image list.|  
  
### Return Value  
 <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>.  
  
### Remarks  
 If this method is successful, the system displays the specified image in the specified button.  
  
 This method sends the                         [TB_CHANGEBITMAP](http://msdn.microsoft.com/library/windows/desktop/bb787301) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 The following code example changes the bitmap for the **File Save** button to the bitmap for the **About** button.  
  
 [!code[NVC_MFC_CToolBarCtrl_s1#1](../vs140/codesnippet/CPP/ctoolbarctrl-class_3.cpp)]  
  
##  \<a name="ctoolbarctrl__checkbutton">\</a>  CToolBarCtrl::CheckButton  
 Checks or clears a given button in a toolbar control.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
 Command identifier of the button to check or clear.  
  
 *bCheck*  
 **TRUE** to check the button, **FALSE** to clear it.  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
### Remarks  
 When a button has been checked, it appears to have been pressed. If you want to change more than one button state, consider calling [SetState](#ctoolbarctrl__setstate) instead.  
  
##  \<a name="ctoolbarctrl__commandtoindex">\</a>  CToolBarCtrl::CommandToIndex  
 Retrieves the zero-based index for the button associated with the specified command identifier.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
 Command ID whose button index you want to find.  
  
### Return Value  
 The zero-based index for the button associated with the command ID.  
  
### Remarks  
  
##  \<a name="ctoolbarctrl__create">\</a>  CToolBarCtrl::Create  
 Creates a toolbar control and attaches it to a <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
 Specifies the toolbar control's style. Toolbars must always have the **WS_CHILD** style. In addition, you can specify any combination of toolbar styles and window styles as described under **Remarks**.  
  
 <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
 Optionally specifies the toolbar control's size and position. It can be either a [CRect](../vs140/crect-class.md) object or a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure.  
  
 <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>  
 Specifies the toolbar control's parent window. It must not be **NULL**.  
  
 <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>  
 Specifies the toolbar control's ID.  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
### Remarks  
 You construct a <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> in two steps. First, call the constructor, and then call **Create**, which creates the toolbar control and attaches it to the <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> object. Apply the following window styles to a toolbar control.  
  
-   **WS_CHILD** Always  
  
-   **WS_VISIBLE** Usually  
  
-   **WS_DISABLED** Rarely  
  
 See                         [CreateWindow](http://msdn.microsoft.com/library/windows/desktop/ms632679) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a description of window styles.  
  
 Optionally, apply a combination of                         [common control styles](http://msdn.microsoft.com/library/windows/desktop/bb775498), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 Apply a combination of toolbar styles to either the control or the buttons themselves. The styles are described in the topic                         [Toolbar Control and Button Styles](http://msdn.microsoft.com/library/windows/desktop/bb760439) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 To use extended toolbar styles, call [SetExtendedStyle](#ctoolbarctrl__setextendedstyle) after you call **Create**. To create a toolbar with extended window styles, call [CToolBarCtrl::CreateEx](#ctoolbarctrl__createex) instead of **Create**.  
  
 The toolbar control automatically sets the size and position of the toolbar window. The height is based on the height of the buttons in the toolbar. The width is the same as the width of the parent window's client area. The <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> styles determine whether the toolbar is positioned along the top or bottom of the client area. By default, a toolbar has the <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> style.  
  
##  \<a name="ctoolbarctrl__createex">\</a>  CToolBarCtrl::CreateEx  
 Creates a control (a child window) and associates it with the <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
 Specifies the extended style of the control being created. For a list of extended Windows styles, see the <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> parameter for                                 [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>  
 Specifies the toolbar control's style. Toolbars must always have the **WS_CHILD** style. In addition, you can specify any combination of toolbar styles and window styles as described in the **Remarks** section of [Create](#ctoolbarctrl__create).  
  
 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
 A reference to a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure describing the size and position of the window to be created, in client coordinates of <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>  
 A pointer to the window that is the control's parent.  
  
 <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>  
 The control's child-window ID.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 Use <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> instead of [Create](#ctoolbarctrl__create) to apply extended Windows styles, specified by the Windows extended style preface **WS_EX_**.  **CreateEx** creates the control with the extended Windows styles specified by <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>. Set extended styles specific to a control using [SetExtendedStyle](#ctoolbarctrl__setextendedstyle). For example, use <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> to set such styles as **WS_EX_CONTEXTHELP**, but use <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> to set such styles as **TBSTYLE_EX_DRAWDDARROWS**. For more information, see the styles described in                         [Toolbar Extended Styles](http://msdn.microsoft.com/library/windows/desktop/bb760430) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctoolbarctrl__ctoolbarctrl">\</a>  CToolBarCtrl::CToolBarCtrl  
 Constructs a <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 You must call [Create](#ctoolbarctrl__create) to make the toolbar usable.  
  
##  \<a name="ctoolbarctrl__customize">\</a>  CToolBarCtrl::Customize  
 Displays the Customize Toolbar dialog box.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Remarks  
 This dialog box allows the user to customize the toolbar by adding and deleting buttons. To support customization, your toolbar's parent window must handle the customization notification messages as described in [Handling Customization Notifications](../vs140/handling-customization-notifications.md). Your toolbar must also have been created with the <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> style, as described in [CToolBarCtrl::Create](#ctoolbarctrl__create).  
  
 For more information, see Knowledge Base article Q241850 : PRB: Call to CToolBarCtrl::Customize Does Not Keep the Customize Dialog Visible.  
  
##  \<a name="ctoolbarctrl__deletebutton">\</a>  CToolBarCtrl::DeleteButton  
 Deletes a button from the toolbar control.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>  
 Zero-based index of the button to delete.  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
### Remarks  
  
##  \<a name="ctoolbarctrl__enablebutton">\</a>  CToolBarCtrl::EnableButton  
 Enables or disables the specified button in a toolbar control.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>  
 Command identifier of the button to enable or disable.  
  
 <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>  
 **TRUE** to enable the button; **FALSE** to disable the button.  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
### Remarks  
 When a button has been enabled, it can be pressed and checked. If you want to change more than one button state, consider calling [SetState](#ctoolbarctrl__setstate) instead.  
  
##  \<a name="ctoolbarctrl__getanchorhighlight">\</a>  CToolBarCtrl::GetAnchorHighlight  
 Retrieves the anchor highlight setting for a toolbar.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 If nonzero, anchor highlighting is enabled. If zero, anchor highlighting is disabled.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TB_GETANCHORHIGHLIGHT](http://msdn.microsoft.com/library/windows/desktop/bb787313), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctoolbarctrl__getbitmap">\</a>  CToolBarCtrl::GetBitmap  
 Retrieves the index of the bitmap associated with a button in a toolbar.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  
 Command identifier of the button whose bitmap index is to be retrieved.  
  
### Return Value  
 Returns the index of the bitmap if successful, or zero otherwise.  
  
### Remarks  
 Implements the functionality of                         [TB_GETBITMAP](http://msdn.microsoft.com/library/windows/desktop/bb787315) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctoolbarctrl__getbitmapflags">\</a>  CToolBarCtrl::GetBitmapFlags  
 Retrieves the bitmap flags from the toolbar.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 A **UINT** that has the **TBBF_LARGE** flag set if the display can support large toolbar bitmaps, clear otherwise.  
  
### Remarks  
 You should call it after creating the toolbar but before adding bitmaps to the toolbar. The return value indicates whether the display supports large bitmaps or not. If the display supports large bitmaps and if you choose to use them, call [SetBitmapSize](#ctoolbarctrl__setbitmapsize) and [SetButtonSize](#ctoolbarctrl__setbuttonsize) before adding your large bitmap using [AddBitmap](#ctoolbarctrl__addbitmap).  
  
##  \<a name="ctoolbarctrl__getbutton">\</a>  CToolBarCtrl::GetButton  
 Retrieves information about the specified button in a toolbar control.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>  
 Zero-based index of the button for which to retrieve information.  
  
 <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>  
 Address of the <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> structure that is to receive a copy of the button information. See [CToolBarCtrl::AddButtons](#ctoolbarctrl__addbuttons) for information about the <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> structure.  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
##  \<a name="ctoolbarctrl__getbuttoncount">\</a>  CToolBarCtrl::GetButtonCount  
 Retrieves a count of the buttons currently in the toolbar control.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 The count of the buttons.  
  
##  \<a name="ctoolbarctrl__getbuttoninfo">\</a>  CToolBarCtrl::GetButtonInfo  
 Retrieves the information for a button in a toolbar.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>  
 The button identifier.  
  
 <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>  
 A pointer to a                                 [TBBUTTONINFO](http://msdn.microsoft.com/library/windows/desktop/bb760478) structure that receives the button information.  
  
### Return Value  
 The zero-based index of the button, if successful; otherwise -1.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TB_GETBUTTONINFO](http://msdn.microsoft.com/library/windows/desktop/bb787321), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctoolbarctrl__getbuttonsize">\</a>  CToolBarCtrl::GetButtonSize  
 Gets the size of a toolbar button.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> value that contains the width and height values in the LOWORD and HIWORD, respectively.  
  
##  \<a name="ctoolbarctrl__getbuttontext">\</a>  CToolBarCtrl::GetButtonText  
 Retrieves the display text of a specified button on the current toolbar control.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>|The identifier for the button whose display text is retrieved.|  
  
### Return Value  
 A [CString](../vs140/using-cstring.md) that contains the display text of the specified button.  
  
### Remarks  
 This method sends the                         [TB_GETBUTTONTEXT](http://msdn.microsoft.com/library/windows/desktop/bb787325) message, which is described in the Windows SDK.  
  
##  \<a name="ctoolbarctrl__getcolorscheme">\</a>  CToolBarCtrl::GetColorScheme  
 Retrieves the color scheme of the current toolbar control.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[out] <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>|Pointer to a                                         [COLORSCHEME](http://msdn.microsoft.com/library/windows/desktop/bb775502) structure that receives the color scheme information. When this method returns, the structure describes the highlight color and shadow color of the toolbar control.|  
  
### Return Value  
 <CodeContentPlaceHolder>184\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method sends the                         [TB_GETCOLORSCHEME](http://msdn.microsoft.com/library/windows/desktop/bb787327) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctoolbarctrl__getdisabledimagelist">\</a>  CToolBarCtrl::GetDisabledImageList  
 Retrieves the image list that a toolbar control uses to display disabled buttons.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to a [CImageList](../vs140/cimagelist-class.md) object, or **NULL** if no disabled image list is set.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TB_GETDISABLEDIMAGELIST](http://msdn.microsoft.com/library/windows/desktop/bb787329), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. The MFC implementation of <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> uses a <CodeContentPlaceHolder>187\</CodeContentPlaceHolder> object containing the toolbar control's button images, rather than a handle to an image list.  
  
##  \<a name="ctoolbarctrl__getdroptarget">\</a>  CToolBarCtrl::GetDropTarget  
 Retrieves the                 [IDropTarget](http://msdn.microsoft.com/library/windows/desktop/ms679679) interface for a toolbar control.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>  
 A pointer to an                                 [IDropTarget](http://msdn.microsoft.com/library/windows/desktop/ms679679) interface pointer. If an error occurs, a **NULL** pointer is placed in this address.  
  
### Return Value  
 Returns an <CodeContentPlaceHolder>189\</CodeContentPlaceHolder> value indicating success or failure of the operation.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TB_GETOBJECT](http://msdn.microsoft.com/library/windows/desktop/bb787343), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctoolbarctrl__getextendedstyle">\</a>  CToolBarCtrl::GetExtendedStyle  
 Retrieves the extended styles for a toolbar control.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>190\</CodeContentPlaceHolder> that represents the extended styles currently in use for the toolbar control. For a list of styles, see                         [Toolbar Extended Styles](http://msdn.microsoft.com/library/windows/desktop/bb760430), in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TB_GETEXTENDEDSTYLE](http://msdn.microsoft.com/library/windows/desktop/bb787331), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctoolbarctrl__gethotimagelist">\</a>  CToolBarCtrl::GetHotImageList  
 Retrieves the image list that a toolbar control uses to display "hot" buttons. A hot button appears highlighted when the mouse pointer is above it.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to a [CImageList](../vs140/cimagelist-class.md) object, or **NULL** if no disabled image list is set.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TB_GETHOTIMAGELIST](http://msdn.microsoft.com/library/windows/desktop/bb787334), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. A hot button appears highlighted when the mouse pointer is above it.  
  
##  \<a name="ctoolbarctrl__gethotitem">\</a>  CToolBarCtrl::GetHotItem  
 Retrieves the index of the hot item in a toolbar.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Return Value  
 The zero-based index of the hot item in a toolbar.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TB_GETHOTITEM](http://msdn.microsoft.com/library/windows/desktop/bb787336), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctoolbarctrl__getimagelist">\</a>  CToolBarCtrl::GetImageList  
 Retrieves the image list that a toolbar control uses to display buttons in their default state.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to a [CImageList](../vs140/cimagelist-class.md) object, or **NULL** if no image list is set.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TB_GETIMAGELIST](http://msdn.microsoft.com/library/windows/desktop/bb787337), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctoolbarctrl__getinsertmark">\</a>  CToolBarCtrl::GetInsertMark  
 Retrieves the current insertion mark for the toolbar.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>  
 A pointer to a                                 [TBINSERTMARK](http://msdn.microsoft.com/library/windows/desktop/bb760480) structure that receives the insertion mark.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TB_GETINSERTMARK](http://msdn.microsoft.com/library/windows/desktop/bb787338), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctoolbarctrl__getinsertmarkcolor">\</a>  CToolBarCtrl::GetInsertMarkColor  
 Retrieves the color used to draw the insertion mark for the toolbar.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Return Value  
 A **COLORREF** value that contains the current insertion mark color.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TB_GETINSERTMARKCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb787339), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctoolbarctrl__getitemrect">\</a>  CToolBarCtrl::GetItemRect  
 Retrieves the bounding rectangle of a button in a toolbar control.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>  
 Zero-based index of the button for which to retrieve information.  
  
 <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>  
 Address of a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure or a [CRect](../vs140/crect-class.md) object that receives the coordinates of the bounding rectangle.  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
### Remarks  
 This function does not retrieve the bounding rectangle for buttons whose state is set to <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>.  
  
##  \<a name="ctoolbarctrl__getmaxsize">\</a>  CToolBarCtrl::GetMaxSize  
 Retrieves the total size of all of the visible buttons and separators in the toolbar.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>  
 A pointer to a                                 [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure that receives the size of the items.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TB_GETMAXSIZE](http://msdn.microsoft.com/library/windows/desktop/bb787341), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctoolbarctrl__getmaxtextrows">\</a>  CToolBarCtrl::GetMaxTextRows  
 Retrieves the maximum number of text rows displayed on a toolbar button.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Return Value  
 The maximum number of text rows displayed on a toolbar button.  
  
##  \<a name="ctoolbarctrl__getmetrics">\</a>  CToolBarCtrl::GetMetrics  
 Retrieves the metrics of the <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>  
 A pointer to the                                 [TBMETRICS](http://msdn.microsoft.com/library/windows/desktop/bb760482) structure of the <CodeContentPlaceHolder>198\</CodeContentPlaceHolder> object.  
  
### Remarks  
 This member function emulates the functionality of the                         [TB_GETMETRICS](http://msdn.microsoft.com/library/windows/desktop/bb787342) message, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctoolbarctrl__getpadding">\</a>  CToolBarCtrl::GetPadding  
 Retrieves the horizontal and vertical padding of the current toolbar control.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[out] <CodeContentPlaceHolder>199\</CodeContentPlaceHolder>|An integer that receives the horizontal padding of the toolbar control, in pixels.|  
|[out] <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>|An integer that receives the vertical padding of the toolbar control, in pixels.|  
  
### Return Value  
 <CodeContentPlaceHolder>201\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method sends the                         [TB_GETPADDING](http://msdn.microsoft.com/library/windows/desktop/bb787344) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctoolbarctrl__getpressedimagelist">\</a>  CToolBarCtrl::GetPressedImageList  
 Retrieves the image list that the current toolbar control uses to represent buttons in the pressed state.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to a [CImageList](../vs140/cimagelist-class.md) that contains the image list for the current control, or <CodeContentPlaceHolder>203\</CodeContentPlaceHolder> if no such image list is set.  
  
### Remarks  
 This method sends the                         [TB_GETPRESSEDIMAGELIST](http://msdn.microsoft.com/library/windows/desktop/bb787345) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctoolbarctrl__getrect">\</a>  CToolBarCtrl::GetRect  
 Retrieves the bounding rectangle for a specified toolbar button.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>  
 The button identifier.  
  
 <CodeContentPlaceHolder>205\</CodeContentPlaceHolder>  
 A pointer to a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure to receive the bounding rectangle information.  
  
### Return Value  
 **TRUE** if successful; otherwise **FALSE**.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TB_GETRECT](http://msdn.microsoft.com/library/windows/desktop/bb787346), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctoolbarctrl__getrows">\</a>  CToolBarCtrl::GetRows  
 Retrieves the number of rows of buttons currently displayed by the toolbar control.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Return Value  
 Number of rows of buttons currently displayed on the toolbar.  
  
### Remarks  
 Note that the number of rows will always be one unless the toolbar was created with the <CodeContentPlaceHolder>206\</CodeContentPlaceHolder> style.  
  
##  \<a name="ctoolbarctrl__getstate">\</a>  CToolBarCtrl::GetState  
 Retrieves information about the state of the specified button in a toolbar control, such as whether it is enabled, pressed, or checked.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>  
 Command identifier of the button for which to retrieve information.  
  
### Return Value  
 The button state information if successful or – 1 otherwise. The button state information can be a combination of the values listed in [CToolBarCtrl::AddButtons](#ctoolbarctrl__addbuttons).  
  
### Remarks  
 This function is especially handy if you want to retrieve more than one of the button states. To just retrieve one state, use one of the following member functions: [IsButtonEnabled](#ctoolbarctrl__isbuttonenabled), [IsButtonChecked](#ctoolbarctrl__isbuttonchecked), [IsButtonPressed](#ctoolbarctrl__isbuttonpressed), [IsButtonHidden](#ctoolbarctrl__isbuttonhidden), or [IsButtonIndeterminate](#ctoolbarctrl__isbuttonindeterminate). However, the <CodeContentPlaceHolder>208\</CodeContentPlaceHolder> member function is the only way to detect the <CodeContentPlaceHolder>209\</CodeContentPlaceHolder> button state.  
  
##  \<a name="ctoolbarctrl__getstring">\</a>  CToolBarCtrl::GetString  
 Retrieves a toolbar string.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 *nString*  
 Index of the string.  
  
 *lpstrString*  
 Pointer to a buffer used to return the string.  
  
 *cchMaxLen*  
 Length of the buffer in bytes.  
  
 <CodeContentPlaceHolder>210\</CodeContentPlaceHolder>  
 The string.  
  
### Return Value  
 The length of the string if successful, -1 if not.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TB_GETSTRING](http://msdn.microsoft.com/library/windows/desktop/bb787349), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctoolbarctrl__getstyle">\</a>  CToolBarCtrl::GetStyle  
 Gets the styles currently applied to a toolbar control.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>211\</CodeContentPlaceHolder> containing a combination of                         [toolbar control styles](http://msdn.microsoft.com/library/windows/desktop/bb760439), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctoolbarctrl__gettooltips">\</a>  CToolBarCtrl::GetToolTips  
 Retrieves the handle of the tool tip control, if any, associated with the toolbar control.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the [CToolTipCtrl](../vs140/ctooltipctrl-class.md) object associated with this toolbar or **NULL** if the toolbar has no associated tool tip control.  
  
### Remarks  
 Since the toolbar control normally creates and maintains its own tool tip control, most programs don't need to call this function.  
  
##  \<a name="ctoolbarctrl__hittest">\</a>  CToolBarCtrl::HitTest  
 Determines where a point lies in a toolbar control.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>212\</CodeContentPlaceHolder>  
 A pointer to a                                 [POINT](http://msdn.microsoft.com/library/windows/desktop/dd162805) structure that contains the x-coordinate of the hit test in the **x** member and the y-coordinate of the hit test in the **y** member. The coordinates are relative to the toolbar's client area.  
  
### Return Value  
 An integer value indicating the location of a point on a toolbar. If the value is zero or a positive value, this return value is the zero-based index of the nonseparator item in which the point lies.  
  
 If the return value is negative, the point does not lie within a button. The absolute value of the return value is the index of a separator item or the nearest nonseparator item.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TB_HITTEST](http://msdn.microsoft.com/library/windows/desktop/bb787360), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctoolbarctrl__hidebutton">\</a>  CToolBarCtrl::HideButton  
 Hides or shows the specified button in a toolbar control.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>  
 Command identifier of the button to hide or show.  
  
 <CodeContentPlaceHolder>214\</CodeContentPlaceHolder>  
 **TRUE** to hide the button, **FALSE** to show it.  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
### Remarks  
 If you want to change more than one button state, consider calling [SetState](#ctoolbarctrl__setstate) instead.  
  
##  \<a name="ctoolbarctrl__indeterminate">\</a>  CToolBarCtrl::Indeterminate  
 Sets or clears the indeterminate state of the specified button in a toolbar control.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>  
 Command identifier of the button whose indeterminate state is to be set or cleared.  
  
 *bIndeterminate*  
 **TRUE** to set the indeterminate state for the specified button, **FALSE** to clear it.  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
### Remarks  
 Indeterminate buttons are displayed grayed, such as the way the bold button on the toolbar of a word processor would look when the text selected contains both bold and regular characters. If you want to change more than one button state, consider calling [SetState](#ctoolbarctrl__setstate) instead.  
  
##  \<a name="ctoolbarctrl__insertbutton">\</a>  CToolBarCtrl::InsertButton  
 Inserts a button in a toolbar control.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>  
 Zero-based index of a button. This function inserts the new button to the left of this button.  
  
 <CodeContentPlaceHolder>217\</CodeContentPlaceHolder>  
 Address of a <CodeContentPlaceHolder>218\</CodeContentPlaceHolder> structure containing information about the button to insert. See [CToolBarCtrl::AddButtons](#ctoolbarctrl__addbuttons) for a description of the <CodeContentPlaceHolder>219\</CodeContentPlaceHolder> structure.  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
### Remarks  
 The image and/or string whose index you provide must have previously been added to the toolbar control's list using [AddBitmap](#ctoolbarctrl__addbitmap), [AddString](#ctoolbarctrl__addstring), and/or [AddStrings](#ctoolbarctrl__addstrings).  
  
##  \<a name="ctoolbarctrl__insertmarkhittest">\</a>  CToolBarCtrl::InsertMarkHitTest  
 Retrieves the insertion mark information for a point in a toolbar.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>  
 A pointer to a                                 [POINT](http://msdn.microsoft.com/library/windows/desktop/dd162805) structure that contains the hit test coordinates, relative to the client area of the toolbar.  
  
 <CodeContentPlaceHolder>221\</CodeContentPlaceHolder>  
 A pointer to a                                 [TBINSERTMARK](http://msdn.microsoft.com/library/windows/desktop/bb760480) structure that receives the insertion mark information.  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TB_INSERTMARKHITTEST](http://msdn.microsoft.com/library/windows/desktop/bb787367), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctoolbarctrl__isbuttonchecked">\</a>  CToolBarCtrl::IsButtonChecked  
 Determines whether the specified button in a toolbar control is checked.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>222\</CodeContentPlaceHolder>  
 Command identifier of the button in the toolbar.  
  
### Return Value  
 Nonzero if the button is checked; otherwise zero.  
  
### Remarks  
 Consider calling [GetState](#ctoolbarctrl__getstate) if you want to retrieve more than one button state.  
  
##  \<a name="ctoolbarctrl__isbuttonenabled">\</a>  CToolBarCtrl::IsButtonEnabled  
 Determines whether the specified button in a toolbar control is enabled.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>  
 Command identifier of the button in the toolbar.  
  
### Return Value  
 Nonzero if the button is enabled; otherwise zero.  
  
### Remarks  
 Consider calling [GetState](#ctoolbarctrl__getstate) if you want to retrieve more than one button state.  
  
##  \<a name="ctoolbarctrl__isbuttonhidden">\</a>  CToolBarCtrl::IsButtonHidden  
 Determines whether the specified button in a toolbar control is hidden.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>224\</CodeContentPlaceHolder>  
 Command identifier of the button in the toolbar.  
  
### Return Value  
 Nonzero if the button is hidden; otherwise zero.  
  
### Remarks  
 Consider calling [GetState](#ctoolbarctrl__getstate) if you want to retrieve more than one button state.  
  
##  \<a name="ctoolbarctrl__isbuttonhighlighted">\</a>  CToolBarCtrl::IsButtonHighlighted  
 Checks the highlight state of a toolbar button.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>  
 The command ID for the toolbar button.  
  
### Return Value  
 Positive integer if the button is highlighted, 0 if the button is not highlighted, or -1 if an error occurs.  
  
##  \<a name="ctoolbarctrl__isbuttonindeterminate">\</a>  CToolBarCtrl::IsButtonIndeterminate  
 Determines whether the specified button in a toolbar control is indeterminate.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>226\</CodeContentPlaceHolder>  
 Command identifier of the button in the toolbar.  
  
### Return Value  
 Positive integer if the button is indeterminate, zero if the button is not indeterminate, or -1 if an error occurs.  
  
### Remarks  
 Indeterminate buttons are displayed dimmed, such as the way the bold button on the toolbar of a word processor looks when the selected text contains both bold and regular characters. Consider calling [GetState](#ctoolbarctrl__getstate) if you want to retrieve more than one button state.  
  
##  \<a name="ctoolbarctrl__isbuttonpressed">\</a>  CToolBarCtrl::IsButtonPressed  
 Determines whether the specified button in a toolbar control is pressed.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>227\</CodeContentPlaceHolder>  
 Command identifier of the button in the toolbar.  
  
### Return Value  
 Nonzero if the button is pressed, otherwise zero.  
  
### Remarks  
 Consider calling [GetState](#ctoolbarctrl__getstate) if you want to retrieve more than one button state.  
  
##  \<a name="ctoolbarctrl__loadimages">\</a>  CToolBarCtrl::LoadImages  
 Loads bitmaps into a toolbar control's image list.  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Parameters  
 *iBitmapID*  
 ID of a bitmap that contains the images to be loaded. To specify your own bitmap resource, set this parameter to the ID of a bitmap resource and set <CodeContentPlaceHolder>228\</CodeContentPlaceHolder> to **NULL**. Your bitmap resource will be added to the image list as a single image. You can add standard, system-defined bitmaps by setting                                 *hinst* to **HINST_COMMCTRL** and setting this parameter to one of the following IDs:  
  
|Bitmap ID|Description|  
|---------------|-----------------|  
|IDB_HIST_LARGE_COLOR|Explorer bitmaps in large size|  
|IDB_HIST_SMALL_COLOR|Explorer bitmaps in small size|  
|IDB_STD_LARGE_COLOR|Standard bitmaps in large size|  
|IDB_STD_SMALL_COLOR|Standard bitmaps in small size|  
|IDB_VIEW_LARGE_COLOR|View bitmaps in large size|  
|IDB_VIEW_SMALL_COLOR|View bitmaps in small size|  
  
 *hinst*  
 Program instance handle to the calling application. This parameter can be **HINST_COMMCTRL** to load a standard image list.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TB_LOADIMAGES](http://msdn.microsoft.com/library/windows/desktop/bb787381), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctoolbarctrl__mapaccelerator">\</a>  CToolBarCtrl::MapAccelerator  
 Maps an accelerator character to a toolbar button.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>229\</CodeContentPlaceHolder>  
 Accelerator character to be mapped. This character is the same character that is underlined in the button's text.  
  
 *pIDBtn*  
 A pointer to a **UINT** that receives the command identifier of the button that corresponds to the accelerator specified in <CodeContentPlaceHolder>230\</CodeContentPlaceHolder>.  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TB_MAPACCELERATOR](http://msdn.microsoft.com/library/windows/desktop/bb787383), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctoolbarctrl__markbutton">\</a>  CToolBarCtrl::MarkButton  
 Sets the highlight state of a given button in a toolbar control.  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>231\</CodeContentPlaceHolder>  
 The button identifier.  
  
 <CodeContentPlaceHolder>232\</CodeContentPlaceHolder>  
 Specifies the highlight state to be set. By default, **TRUE**. If set to **FALSE**, the button is set to its default state.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TB_MARKBUTTON](http://msdn.microsoft.com/library/windows/desktop/bb787385), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctoolbarctrl__movebutton">\</a>  CToolBarCtrl::MoveButton  
 Moves a button from one index to another.  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
### Parameters  
 *nOldPos*  
 The zero-based index of the button to be moved.  
  
 *nNewPos*  
 The zero-based index of the button's destination.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TB_MOVEBUTTON](http://msdn.microsoft.com/library/windows/desktop/bb787387), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctoolbarctrl__pressbutton">\</a>  CToolBarCtrl::PressButton  
 Presses or releases the specified button in a toolbar control.  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>233\</CodeContentPlaceHolder>  
 Command identifier of the button to press or release.  
  
 [in] <CodeContentPlaceHolder>234\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>235\</CodeContentPlaceHolder> to press the specified button; <CodeContentPlaceHolder>236\</CodeContentPlaceHolder> to release the specified button. The default value is <CodeContentPlaceHolder>237\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>238\</CodeContentPlaceHolder> if the method is successful; otherwise, <CodeContentPlaceHolder>239\</CodeContentPlaceHolder>.  
  
### Remarks  
 If you want to change more than one button state, consider calling [SetState](#ctoolbarctrl__setstate) instead.  
  
 This method sends the                         [TB_PRESSBUTTON](http://msdn.microsoft.com/library/windows/desktop/bb787389) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctoolbarctrl__replacebitmap">\</a>  CToolBarCtrl::ReplaceBitmap  
 Replaces the existing bitmap in the current toolbar control with a new bitmap.  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>240\</CodeContentPlaceHolder>|Pointer to a                                         [TBREPLACEBITMAP](http://msdn.microsoft.com/library/windows/desktop/bb760484) structure that describes the bitmap to be replaced and the new bitmap.|  
  
### Return Value  
 <CodeContentPlaceHolder>241\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>242\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method sends the                         [TB_REPLACEBITMAP](http://msdn.microsoft.com/library/windows/desktop/bb787391) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 The following code example replaces the bitmap for the standard toolbar with a different bitmap.  
  
 [!code[NVC_MFC_CToolBarCtrl_s1#2](../vs140/codesnippet/CPP/ctoolbarctrl-class_4.cpp)]  
  
##  \<a name="ctoolbarctrl__restorestate">\</a>  CToolBarCtrl::RestoreState  
 Restores the state of the toolbar control from the location in the registry specified by the parameters.  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>243\</CodeContentPlaceHolder>  
 Identifies a currently open key in the registry or any of the following predefined reserved handle values:  
  
-   **HKEY_CLASSES_ROOT**  
  
-   **HKEY_CURRENT_USER**  
  
-   **HKEY_LOCAL_MACHINE**  
  
-   **HKEY_USERS**  
  
 <CodeContentPlaceHolder>244\</CodeContentPlaceHolder>  
 Points to a null-terminated string containing the name of the subkey with which a value is associated. This parameter can be null or a pointer to an empty string. If the parameter is **NULL**, the value will be added to the key identified by the <CodeContentPlaceHolder>245\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>246\</CodeContentPlaceHolder>  
 Points to a string containing the name of the value to retrieve. If a value with this name is not already present in the key, the function adds it to the key.  
  
##  \<a name="ctoolbarctrl__savestate">\</a>  CToolBarCtrl::SaveState  
 Saves the state of the toolbar control in the location in the registry specified by the parameters.  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>247\</CodeContentPlaceHolder>  
 Identifies a currently open key in the registry or any of the following predefined reserved handle values:  
  
-   **HKEY_CLASSES_ROOT**  
  
-   **HKEY_CURRENT_USER**  
  
-   **HKEY_LOCAL_MACHINE**  
  
-   **HKEY_USERS**  
  
 <CodeContentPlaceHolder>248\</CodeContentPlaceHolder>  
 Points to a null-terminated string containing the name of the subkey with which a value is associated. This parameter can be null or a pointer to an empty string. If the parameter is **NULL**, the value will be added to the key identified by the <CodeContentPlaceHolder>249\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>250\</CodeContentPlaceHolder>  
 Points to a string containing the name of the value to set. If a value with this name is not already present in the key, the function adds it to the key.  
  
##  \<a name="ctoolbarctrl__setanchorhighlight">\</a>  CToolBarCtrl::SetAnchorHighlight  
 Sets the anchor highlight setting for a toolbar.  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>251\</CodeContentPlaceHolder>  
 Specifies if anchor highlighting is enabled or disabled. If this value is nonzero, anchor highlighting will be enabled. If this value is zero, anchor highlighting will be disabled  
  
### Return Value  
 The previous anchor setting. If highlighting was enabled, this value is nonzero. If highlighting was not enabled, this value is zero.  
  
### Remarks  
 This method implements the behavior of the Win32 message                         [TB_SETANCHORHIGHLIGHT](http://msdn.microsoft.com/library/windows/desktop/bb787396), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctoolbarctrl__setbitmapsize">\</a>  CToolBarCtrl::SetBitmapSize  
 Sets the size of the actual bitmapped images to be added to a toolbar control.  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>252\</CodeContentPlaceHolder>  
 Width and height, in pixels, of the bitmapped images.  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
### Remarks  
 This function must be called only before adding any bitmaps to the toolbar. If the application does not explicitly set the bitmap size, it defaults to 16 by 15 pixels.  
  
##  \<a name="ctoolbarctrl__setbuttoninfo">\</a>  CToolBarCtrl::SetButtonInfo  
 Sets the information for an existing button in a toolbar.  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>253\</CodeContentPlaceHolder>  
 The button identifier.  
  
 <CodeContentPlaceHolder>254\</CodeContentPlaceHolder>  
 A pointer to a                                 [TBBUTTONINFO](http://msdn.microsoft.com/library/windows/desktop/bb760478) structure that receives the button information.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The member function implements the behavior of the Win32 message                         [TB_SETBUTTONINFO](http://msdn.microsoft.com/library/windows/desktop/bb787413), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctoolbarctrl__setbuttonsize">\</a>  CToolBarCtrl::SetButtonSize  
 Sets the size of the buttons in the toolbar control.  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>255\</CodeContentPlaceHolder>  
 Width and height, in pixels, of the buttons.  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
### Remarks  
 The button size must always be at least as large as the bitmap size it encloses. This function must be called only before adding any bitmaps to the toolbar. If the application does not explicitly set the button size, it defaults to 24 by 22 pixels.  
  
### Example  
  See the example for [CToolBar::GetToolBarCtrl](../vs140/ctoolbar-class.md#ctoolbar__gettoolbarctrl).  
  
##  \<a name="ctoolbarctrl__setbuttonstructsize">\</a>  CToolBarCtrl::SetButtonStructSize  
 Specifies the size of the <CodeContentPlaceHolder>256\</CodeContentPlaceHolder> structure.  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>257\</CodeContentPlaceHolder>  
 Size, in bytes, of the <CodeContentPlaceHolder>258\</CodeContentPlaceHolder> structure.  
  
### Remarks  
 If you wanted to store extra data in the <CodeContentPlaceHolder>259\</CodeContentPlaceHolder> structure, you could either derive a new structure from <CodeContentPlaceHolder>260\</CodeContentPlaceHolder>, adding the members you needed, or create a new structure that contains a <CodeContentPlaceHolder>261\</CodeContentPlaceHolder> structure as its first member. You would then call this function to tell the toolbar control the size of the new structure.  
  
 See [CToolBarCtrl::AddButtons](#ctoolbarctrl__addbuttons) for more information on the <CodeContentPlaceHolder>262\</CodeContentPlaceHolder> structure.  
  
##  \<a name="ctoolbarctrl__setbuttonwidth">\</a>  CToolBarCtrl::SetButtonWidth  
 Sets the minimum and maximum button widths in the toolbar control.  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>263\</CodeContentPlaceHolder>  
 Minimum button width, in pixels. Toolbar buttons will never be narrower than this value.  
  
 *cxMax*  
 Maximum button width, in pixels. If button text is too wide, the control displays it with ellipsis points.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TB_SETBUTTONWIDTH](http://msdn.microsoft.com/library/windows/desktop/bb787417), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctoolbarctrl__setcmdid">\</a>  CToolBarCtrl::SetCmdID  
 Sets the command identifier that will be sent to the owner window when the specified button is pressed.  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>264\</CodeContentPlaceHolder>  
 The zero-based index of the button whose command ID is to be set.  
  
 <CodeContentPlaceHolder>265\</CodeContentPlaceHolder>  
 The command ID to set the selected button to.  
  
### Return Value  
 Returns nonzero if successful; otherwise zero.  
  
##  \<a name="ctoolbarctrl__setcolorscheme">\</a>  CToolBarCtrl::SetColorScheme  
 Sets the color scheme of the current toolbar control.  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>266\</CodeContentPlaceHolder>|Pointer to a                                         [COLORSCHEME](http://msdn.microsoft.com/library/windows/desktop/bb775502) structure that describes the highlight color and shadow color of the toolbar control.|  
  
### Remarks  
 This method has no effect if a [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] visual theme is set.  
  
 This method sends the                         [TB_SETCOLORSCHEME](http://msdn.microsoft.com/library/windows/desktop/bb787421) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 The following code example sets the color scheme for the current toolbar control. The code example makes the left and top edges of each tool button red and the right and bottom edges blue. When the user presses the button, the button's red edges turn blue and its blue edges turn red.  
  
 [!code[NVC_MFC_CToolBarCtrl_s1#3](../vs140/codesnippet/CPP/ctoolbarctrl-class_5.cpp)]  
  
##  \<a name="ctoolbarctrl__setdisabledimagelist">\</a>  CToolBarCtrl::SetDisabledImageList  
 Sets the image list that the toolbar control will use to display disabled buttons.  
  
<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>267\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>268\</CodeContentPlaceHolder> object containing the images to be used by the toolbar control to display disabled button images.  
  
### Return Value  
 A pointer to a [CImageList](../vs140/cimagelist-class.md) object that was previously used by the toolbar control to display disabled button images.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TB_SETDISABLEDIMAGELIST](http://msdn.microsoft.com/library/windows/desktop/bb787423), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. The MFC implementation of <CodeContentPlaceHolder>269\</CodeContentPlaceHolder> uses a <CodeContentPlaceHolder>270\</CodeContentPlaceHolder> object containing the toolbar control's disabled button images, rather than a handle to an image list.  
  
##  \<a name="ctoolbarctrl__setdrawtextflags">\</a>  CToolBarCtrl::SetDrawTextFlags  
 Sets the flags in the Win32 function                 [DrawText](http://msdn.microsoft.com/library/windows/desktop/dd162498), which is used to draw the text in the specified rectangle, formatted according to how the flags are set.  
  
<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>271\</CodeContentPlaceHolder>  
 A combination of one or more of the DT_ flags, specified in the Win32 function                                 [DrawText](http://msdn.microsoft.com/library/windows/desktop/dd162498), that indicates which bits in <CodeContentPlaceHolder>272\</CodeContentPlaceHolder> will be used when drawing the text.  
  
 <CodeContentPlaceHolder>273\</CodeContentPlaceHolder>  
 A combination of one or more of the DT_ flags, specified in the Win32 function <CodeContentPlaceHolder>274\</CodeContentPlaceHolder>, that indicate how the button text will be drawn. This value is passed to <CodeContentPlaceHolder>275\</CodeContentPlaceHolder> when the button text is drawn.  
  
### Return Value  
 A <CodeContentPlaceHolder>276\</CodeContentPlaceHolder> containing the previous text drawing flags.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TB_SETDRAWTEXTFLAGS](http://msdn.microsoft.com/library/windows/desktop/bb787425), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. This member function sets the flags in the Win32 function <CodeContentPlaceHolder>277\</CodeContentPlaceHolder>, which draws text in the specified rectangle, formatted according to how the flags are set.  
  
##  \<a name="ctoolbarctrl__setextendedstyle">\</a>  CToolBarCtrl::SetExtendedStyle  
 Sets the extended styles for a toolbar control.  
  
<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>278\</CodeContentPlaceHolder>  
 A value specifying the new extended styles. This parameter can be a combination of the toolbar extended styles.  
  
### Return Value  
 A <CodeContentPlaceHolder>279\</CodeContentPlaceHolder> that represents the previous extended styles. For a list of styles, see                         [Toolbar Extended Styles](http://msdn.microsoft.com/library/windows/desktop/bb760430), in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TB_SETEXTENDEDSTYLE](http://msdn.microsoft.com/library/windows/desktop/bb787427), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctoolbarctrl__sethotimagelist">\</a>  CToolBarCtrl::SetHotImageList  
 Sets the image list that the toolbar control will use to display "hot" buttons.  
  
<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>280\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>281\</CodeContentPlaceHolder> object containing the images to be used by the toolbar control to display hot button images.  
  
### Return Value  
 A pointer to a [CImageList](../vs140/cimagelist-class.md) object that was previously used by the toolbar control to display hot button images.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TB_SETHOTIMAGELIST](http://msdn.microsoft.com/library/windows/desktop/bb787429), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 The MFC implementation of <CodeContentPlaceHolder>282\</CodeContentPlaceHolder> uses a <CodeContentPlaceHolder>283\</CodeContentPlaceHolder> object containing the toolbar control's hot button images, rather than a handle to an image list. A hot button appears highlighted when the pointer is above it.  
  
##  \<a name="ctoolbarctrl__sethotitem">\</a>  CToolBarCtrl::SetHotItem  
 Sets the hot item in a toolbar.  
  
<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
### Parameters  
 *nHot*  
 The zero-based index number of the item that will be made hot. If this value is -1, none of the items will be hot.  
  
### Return Value  
 The index of the previous hot item, or -1 if there was no hot item.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TB_SETHOTITEM](http://msdn.microsoft.com/library/windows/desktop/bb787431), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctoolbarctrl__setimagelist">\</a>  CToolBarCtrl::SetImageList  
 Sets the image list that the toolbar will use to display buttons that are in their default state.  
  
<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>284\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>285\</CodeContentPlaceHolder> object containing the images to be used by the toolbar control to display button images in their default state.  
  
### Return Value  
 A pointer to a [CImageList](../vs140/cimagelist-class.md) object that was previously used by the toolbar control to display button images in their default state.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TB_SETIMAGELIST](http://msdn.microsoft.com/library/windows/desktop/bb787433), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 The MFC implementation of <CodeContentPlaceHolder>286\</CodeContentPlaceHolder> uses a <CodeContentPlaceHolder>287\</CodeContentPlaceHolder> object containing the toolbar control's button images, rather than a handle to an image list.  
  
##  \<a name="ctoolbarctrl__setindent">\</a>  CToolBarCtrl::SetIndent  
 Sets the indentation for the first button in a toolbar control.  
  
<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
### Parameters  
 *iIndent*  
 The value specifying the indentation, in pixels.  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
##  \<a name="ctoolbarctrl__setinsertmark">\</a>  CToolBarCtrl::SetInsertMark  
 Sets the current insertion mark for the toolbar.  
  
<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>288\</CodeContentPlaceHolder>  
 A pointer to the                                 [TBINSERTMARK](http://msdn.microsoft.com/library/windows/desktop/bb760480) structure that contains the insertion mark.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TB_SETINSERTMARK](http://msdn.microsoft.com/library/windows/desktop/bb787437), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctoolbarctrl__setinsertmarkcolor">\</a>  CToolBarCtrl::SetInsertMarkColor  
 Sets the color used to draw the insertion mark for the toolbar.  
  
<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>289\</CodeContentPlaceHolder>  
 A **COLORREF** value that contains the new insertion mark color.  
  
### Return Value  
 A **COLORREF** value that contains the previous insertion mark color.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [TB_SETINSERTMARKCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb787439), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctoolbarctrl__setmaxtextrows">\</a>  CToolBarCtrl::SetMaxTextRows  
 Sets the maximum number of text rows displayed on a toolbar button.  
  
<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
### Parameters  
 *iMaxRows*  
 Maximum number of rows to be set.  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
##  \<a name="ctoolbarctrl__setmetrics">\</a>  CToolBarCtrl::SetMetrics  
 Sets the metrics of the <CodeContentPlaceHolder>290\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>291\</CodeContentPlaceHolder>  
 A pointer to the                                 [TBMETRICS](http://msdn.microsoft.com/library/windows/desktop/bb760482) structure of the <CodeContentPlaceHolder>292\</CodeContentPlaceHolder> object.  
  
### Remarks  
 This member function emulates the functionality of the                         [TB_SETMETRICS](http://msdn.microsoft.com/library/windows/desktop/bb787446) message, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctoolbarctrl__setowner">\</a>  CToolBarCtrl::SetOwner  
 Sets the owner window for the toolbar control.  
  
<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>293\</CodeContentPlaceHolder>  
 Pointer to the <CodeContentPlaceHolder>294\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>295\</CodeContentPlaceHolder>-derived object that will be the new owner window for the toolbar control.  
  
### Remarks  
 The owner window is the window that receives notifications from the toolbar.  
  
##  \<a name="ctoolbarctrl__setpadding">\</a>  CToolBarCtrl::SetPadding  
 Sets the horizontal and vertical padding of the current toolbar control.  
  
<CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>296\</CodeContentPlaceHolder>|Specifies the horizontal padding of the toolbar control, in pixels.|  
|[in] <CodeContentPlaceHolder>297\</CodeContentPlaceHolder>|Specifies the vertical padding of the toolbar control, in pixels.|  
  
### Return Value  
 A <CodeContentPlaceHolder>298\</CodeContentPlaceHolder> whose low word contains the previous horizontal padding value, and whose high word contains the previous vertical padding value. The padding values are measured in pixels.  
  
### Remarks  
 This method sends the                         [TB_SETPADDING](http://msdn.microsoft.com/library/windows/desktop/bb787448) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 The following code example sets the horizontal and vertical padding of the current toolbar control to 20 pixels.  
  
 [!code[NVC_MFC_CToolBarCtrl_s1#4](../vs140/codesnippet/CPP/ctoolbarctrl-class_6.cpp)]  
  
##  \<a name="ctoolbarctrl__setpressedimagelist">\</a>  CToolBarCtrl::SetPressedImageList  
 Sets the image list that the current toolbar control uses to represent buttons in the pressed state.  
  
<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>299\</CodeContentPlaceHolder>|The zero-based index of the image list. Set this parameter to zero if you use only one image list.|  
|[in] <CodeContentPlaceHolder>300\</CodeContentPlaceHolder>|Pointer to a [CImageList](../vs140/cimagelist-class.md) that contains the new image list.|  
  
### Return Value  
 Pointer to a [CImageList](../vs140/cimagelist-class.md) that contains the previous image list for the current control, or <CodeContentPlaceHolder>301\</CodeContentPlaceHolder> if no such image list was set.  
  
### Remarks  
 This method sends the                         [TB_SETPRESSEDIMAGELIST](http://msdn.microsoft.com/library/windows/desktop/bb787453) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 The following code example sets the pressed image list to be the same as the default image list.  
  
 [!code[NVC_MFC_CToolBarCtrl_s1#5](../vs140/codesnippet/CPP/ctoolbarctrl-class_7.cpp)]  
  
##  \<a name="ctoolbarctrl__setrows">\</a>  CToolBarCtrl::SetRows  
 Asks the toolbar control to resize itself to the requested number of rows.  
  
<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>302\</CodeContentPlaceHolder>  
 Requested number of rows.  
  
 <CodeContentPlaceHolder>303\</CodeContentPlaceHolder>  
 Tells whether to use more rows or fewer rows if the toolbar cannot be resized to the requested number of rows.  
  
 <CodeContentPlaceHolder>304\</CodeContentPlaceHolder>  
 Points to the [CRect](../vs140/crect-class.md) object or                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure that will receive the new bounding rectangle of the toolbar.  
  
### Remarks  
 If the toolbar cannot resize itself to the requested number or rows, it will resize itself to either the next larger or next smaller valid size, depending on the value of <CodeContentPlaceHolder>305\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>306\</CodeContentPlaceHolder> is **TRUE**, the new number of rows will be larger than the number requested. If <CodeContentPlaceHolder>307\</CodeContentPlaceHolder> is **FALSE**, the new number of rows will be smaller than the number requested.  
  
 A given number of rows is valid for the toolbar if the buttons can be arranged such that all of the rows have the same number of buttons (except perhaps the last row). For example, a toolbar that contains four buttons could not be sized to three rows because the last two rows would have to be shorter. If you attempted to size it to three rows, you would get four rows if <CodeContentPlaceHolder>308\</CodeContentPlaceHolder> was **TRUE** and two rows if <CodeContentPlaceHolder>309\</CodeContentPlaceHolder> was **FALSE**.  
  
 If there are separators in the toolbar, the rules for when a given number of rows is valid are more complicated. The layout is computed such that button groups (buttons with a separator before the first and the last button in the group) are never broken up on several rows unless the group cannot fit on one row.  
  
 If a group does not fit on one row, the next group will start on the next row even if it would fit on the row where the large group ended. The purpose of this rule is to make the separation between large groups more noticeable. The resulting vertical separators are counted as rows.  
  
 Note also that the <CodeContentPlaceHolder>310\</CodeContentPlaceHolder> member function will always chose the layout that results in the smallest toolbar size. Creating a toolbar with the <CodeContentPlaceHolder>311\</CodeContentPlaceHolder> style and then resizing the control will simply apply the method outlined above given the width of the control.  
  
 This function can only be called for toolbars that were created with the <CodeContentPlaceHolder>312\</CodeContentPlaceHolder> style.  
  
##  \<a name="ctoolbarctrl__setstate">\</a>  CToolBarCtrl::SetState  
 Sets the state for the specified button in a toolbar control.  
  
<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>313\</CodeContentPlaceHolder>  
 Command identifier of the button.  
  
 <CodeContentPlaceHolder>314\</CodeContentPlaceHolder>  
 State flags. It can be a combination of the values listed for button states in [CToolBarCtrl::AddButtons](#ctoolbarctrl__addbuttons).  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
### Remarks  
 This function is especially handy if you want to set more than one of the button states. To just set one state, use one of the following member functions: [EnableButton](#ctoolbarctrl__enablebutton), [CheckButton](#ctoolbarctrl__checkbutton), [HideButton](#ctoolbarctrl__hidebutton), [Indeterminate](#ctoolbarctrl__indeterminate), or [PressButton](#ctoolbarctrl__pressbutton).  
  
##  \<a name="ctoolbarctrl__setstyle">\</a>  CToolBarCtrl::SetStyle  
 Sets the styles for a toolbar control.  
  
<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>315\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>316\</CodeContentPlaceHolder> containing a combination of                                 [toolbar control styles](http://msdn.microsoft.com/library/windows/desktop/bb760439), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ctoolbarctrl__settooltips">\</a>  CToolBarCtrl::SetToolTips  
 Associates a tool tip control with a toolbar control.  
  
<CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
### Parameters  
 *pTip*  
 Pointer to the [CToolTipCtrl](../vs140/ctooltipctrl-class.md) object.  
  
##  \<a name="ctoolbarctrl__setwindowtheme">\</a>  CToolBarCtrl::SetWindowTheme  
 Sets the visual style of the <CodeContentPlaceHolder>317\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>318\</CodeContentPlaceHolder>  
 A pointer to a Unicode string that contains the toolbar visual style to set.  
  
### Return Value  
 The return value is not used.  
  
### Remarks  
 This member function emulates the functionality of the                         [TB_SETWINDOWTHEME](http://msdn.microsoft.com/library/windows/desktop/bb787465) message, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## See Also  
 [MFC Sample CMNCTRL1](../vs140/visual-c---samples.md)   
 [MFC Sample MFCIE](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBar](../vs140/ctoolbar-class.md)