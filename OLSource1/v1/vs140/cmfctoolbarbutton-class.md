---
title: "CMFCToolBarButton Class"
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
  - "CMFCToolBarButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCToolBarButton class"
ms.assetid: 8a6ecffb-86b0-4f5c-8211-a9146b463efd
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton Class
Provides button functionality to toolbars.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCToolBarButton::CMFCToolbarButton](#cmfctoolbarbutton__cmfctoolbarbutton)|Constructs and initializes a <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCToolBarButton::CanBeDropped](#cmfctoolbarbutton__canbedropped)|Specifies whether a user can position a button on a toolbar or menu during customization.|  
|[CMFCToolBarButton::CanBeStored](#cmfctoolbarbutton__canbestored)|Specifies whether the button can be stored.|  
|[CMFCToolBarButton::CanBeStretched](#cmfctoolbarbutton__canbestretched)|Specifies whether a user can stretch the button during customization.|  
|[CMFCToolBarButton::CompareWith](#cmfctoolbarbutton__comparewith)|Compares this instance with the provided <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> object.|  
|[CMFCToolBarButton::CopyFrom](#cmfctoolbarbutton__copyfrom)|Copies the properties of another toolbar button to the current button.|  
|[CMFCToolBarButton::CreateFromOleData](#cmfctoolbarbutton__createfromoledata)|Creates a <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> object from the provided <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>83\</CodeContentPlaceHolder>|Used by the framework to create a dynamic instance of this class type.|  
|[CMFCToolBarButton::EnableWindow](#cmfctoolbarbutton__enablewindow)|Enables or disables mouse and keyboard input.|  
|[CMFCToolBarButton::ExportToMenuButton](#cmfctoolbarbutton__exporttomenubutton)|Copies text from the toolbar button to a menu.|  
|[CMFCToolBarButton::GetClipboardFormat](#cmfctoolbarbutton__getclipboardformat)|Retrieves the global clipboard format for the application.|  
|[CMFCToolBarButton::GetHwnd](#cmfctoolbarbutton__gethwnd)|Retrieves the window handle that is associated with the toolbar button.|  
|[CMFCToolBarButton::GetImage](#cmfctoolbarbutton__getimage)|Retrieves the image index of the button.|  
|[CMFCToolBarButton::GetInvalidateRect](#cmfctoolbarbutton__getinvalidaterect)|Retrieves the region of the client area of the button that must be redrawn.|  
|[CMFCToolBarButton::GetParentWnd](#cmfctoolbarbutton__getparentwnd)|Retrieves the parent window of the button.|  
|[CMFCToolBarButton::GetProtectedCommands](#cmfctoolbarbutton__getprotectedcommands)|Retrieves the list of commands that the user cannot customize.|  
|[CMFCToolBarButton::GetTextSize](#cmfctoolbarbutton__gettextsize)|Retrieves the size of the button text.|  
|[CMFCToolBarButton::HasFocus](#cmfctoolbarbutton__hasfocus)|Determines whether the button has the current input focus.|  
|[CMFCToolBarButton::HaveHotBorder](#cmfctoolbarbutton__havehotborder)|Determines whether a border of the button is displayed when a user selects the button.|  
|[CMFCToolBarButton::IsDrawImage](#cmfctoolbarbutton__isdrawimage)|Determines whether an image is displayed on the button.|  
|[CMFCToolBarButton::IsDrawText](#cmfctoolbarbutton__isdrawtext)|Determines whether a text label is displayed on the button.|  
|[CMFCToolBarButton::IsDroppedDown](#cmfctoolbarbutton__isdroppeddown)|Determines whether the button displays a submenu.|  
|[CMFCToolBarButton::IsEditable](#cmfctoolbarbutton__iseditable)|Determines whether the button can be customized.|  
|[CMFCToolBarButton::IsExtraSize](#cmfctoolbarbutton__isextrasize)|Determines whether the button can be displayed with an extended border.|  
|[CMFCToolBarButton::IsFirstInGroup](#cmfctoolbarbutton__isfirstingroup)|Determines whether the button is in the first position in its button group.|  
|[CMFCToolBarButton::IsHidden](#cmfctoolbarbutton__ishidden)|Determines whether the button is hidden.|  
|[CMFCToolBarButton::IsHorizontal](#cmfctoolbarbutton__ishorizontal)|Determines whether the button is located on a horizontal toolbar.|  
|[CMFCToolBarButton::IsLastInGroup](#cmfctoolbarbutton__islastingroup)|Specifies whether the button is in the last position in its button group.|  
|[CMFCToolBarButton::IsLocked](#cmfctoolbarbutton__islocked)|Determines whether the button is on a locked (non-customizable) toolbar.|  
|[CMFCToolBarButton::IsOwnerOf](#cmfctoolbarbutton__isownerof)|Determines whether the button is the owner of the provided window handle.|  
|[CMFCToolBarButton::IsVisible](#cmfctoolbarbutton__isvisible)|Determines whether the toolbar button is visible.|  
|[CMFCToolBarButton::IsWindowVisible](#cmfctoolbarbutton__iswindowvisible)|Determines whether the underlying window handle of the button is visible.|  
|[CMFCToolBarButton::NotifyCommand](#cmfctoolbarbutton__notifycommand)|Specifies whether the button processes the                                         [WM_COMMAND](http://msdn.microsoft.com/library/windows/desktop/ms647591) message.|  
|[CMFCToolBarButton::OnAddToCustomizePage](#cmfctoolbarbutton__onaddtocustomizepage)|Called by the framework when the button is added to a **Customize** dialog box.|  
|[CMFCToolBarButton::OnBeforeDrag](#cmfctoolbarbutton__onbeforedrag)|Specifies whether the button can be dragged.|  
|[CMFCToolBarButton::OnBeforeDrop](#cmfctoolbarbutton__onbeforedrop)|Specifies whether a user can drop the button onto the target toolbar.|  
|[CMFCToolBarButton::OnCalculateSize](#cmfctoolbarbutton__oncalculatesize)|Called by the framework to calculate the size of the button for the specified device context and docking state.|  
|[CMFCToolBarButton::OnCancelMode](#cmfctoolbarbutton__oncancelmode)|Called by the framework to handle the                                         [WM_CANCELMODE](http://msdn.microsoft.com/library/windows/desktop/ms632615) message.|  
|[CMFCToolBarButton::OnChangeParentWnd](#cmfctoolbarbutton__onchangeparentwnd)|Called by the framework when the button is inserted into a new toolbar.|  
|[CMFCToolBarButton::OnClick](#cmfctoolbarbutton__onclick)|Called by the framework when the user clicks the mouse button.|  
|[CMFCToolBarButton::OnClickUp](#cmfctoolbarbutton__onclickup)|Called by the framework when the user releases the mouse button.|  
|[CMFCToolBarButton::OnContextHelp](#cmfctoolbarbutton__oncontexthelp)|Called by the framework when the parent toolbar handles a <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> message.|  
|[CMFCToolBarButton::OnCtlColor](#cmfctoolbarbutton__onctlcolor)|Called by the framework when the parent toolbar handles a <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> message.|  
|[CMFCToolBarButton::OnCustomizeMenu](#cmfctoolbarbutton__oncustomizemenu)|Allows the button to modify the provided menu when the application displays a shortcut menu on the parent toolbar.|  
|[CMFCToolBarButton::OnDblClk](#cmfctoolbarbutton__ondblclk)|Called by the framework when the parent toolbar handles a                                         [WM_LBUTTONDBLCLK](http://msdn.microsoft.com/library/windows/desktop/ms645606) message.|  
|[CMFCToolBarButton::OnDraw](#cmfctoolbarbutton__ondraw)|Called by the framework to draw the button by using the specified styles and options.|  
|[CMFCToolBarButton::OnDrawOnCustomizeList](#cmfctoolbarbutton__ondrawoncustomizelist)|Called by the framework to draw the button in the **Commands** pane of the **Customize** dialog box.|  
|[CMFCToolBarButton::OnGetCustomToolTipText](#cmfctoolbarbutton__ongetcustomtooltiptext)|Called by the framework to retrieve the custom tooltip text for the button.|  
|[CMFCToolBarButton::OnGlobalFontsChanged](#cmfctoolbarbutton__onglobalfontschanged)|Called by the framework when the global font has changed.|  
|[CMFCToolBarButton::OnMove](#cmfctoolbarbutton__onmove)|Called by the framework when the parent toolbar moves.|  
|[CMFCToolBarButton::OnShow](#cmfctoolbarbutton__onshow)|Called by the framework when the button becomes visible or invisible.|  
|[CMFCToolBarButton::OnSize](#cmfctoolbarbutton__onsize)|Called by the framework when the parent toolbar changes its size or position and this change requires the button to change size.|  
|[CMFCToolBarButton::OnToolHitTest](#cmfctoolbarbutton__ontoolhittest)|Called by the framework when the parent toolbar must determine whether a point is in the bounding rectangle of the button.|  
|[CMFCToolBarButton::OnUpdateToolTip](#cmfctoolbarbutton__onupdatetooltip)|Called by the framework when the parent toolbar updates its tooltip text.|  
|[CMFCToolBarButton::PrepareDrag](#cmfctoolbarbutton__preparedrag)|Called by the framework when the button is about to perform a drag-and-drop operation.|  
|[CMFCToolBarButton::Rect](#cmfctoolbarbutton__rect)|Retrieves the bounding rectangle of the button.|  
|[CMFCToolBarButton::ResetImageToDefault](#cmfctoolbarbutton__resetimagetodefault)|Sets to the default value the image that is associated with the button.|  
|[CMFCToolBarButton::SaveBarState](#cmfctoolbarbutton__savebarstate)|Saves the state of the toolbar button.|  
|[CMFCToolBarButton::Serialize](#cmfctoolbarbutton__serialize)|Reads this object from an archive or writes it to an archive. (Overrides [CObject::Serialize](../vs140/cobject-class.md#cobject__serialize).)|  
|[CMFCToolBarButton::SetACCData](#cmfctoolbarbutton__setaccdata)|Populates the provided <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> object with accessibility data from the toolbar button.|  
|[CMFCToolBarButton::SetClipboardFormatName](#cmfctoolbarbutton__setclipboardformatname)|Renames the global clipboard format.|  
|[CMFCToolBarButton::SetImage](#cmfctoolbarbutton__setimage)|Sets the image index of the button.|  
|[CMFCToolBarButton::SetProtectedCommands](#cmfctoolbarbutton__setprotectedcommands)|Sets the list of commands that the user cannot customize.|  
|[CMFCToolBarButton::SetRadio](#cmfctoolbarbutton__setradio)|Called by the framework when a button changes its checked state.|  
|[CMFCToolBarButton::SetRect](#cmfctoolbarbutton__setrect)|Sets the bounding rectangle of the button.|  
|[CMFCToolBarButton::SetStyle](#cmfctoolbarbutton__setstyle)|Sets the style of the button.|  
|[CMFCToolBarButton::SetVisible](#cmfctoolbarbutton__setvisible)|Specifies whether the button is visible.|  
|[CMFCToolBarButton::Show](#cmfctoolbarbutton__show)|Shows or hides the button.|  
  
### Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCToolBarButton::m_bImage](#cmfctoolbarbutton__m_bimage)|Specifies whether an image is displayed on the button.|  
|[CMFCToolBarButton::m_bText](#cmfctoolbarbutton__m_btext)|Specifies whether a text label is displayed on the button.|  
|[CMFCToolBarButton::m_bTextBelow](#cmfctoolbarbutton__m_btextbelow)|Specifies whether the text label is displayed underneath the image on the button.|  
|[CMFCToolBarButton::m_bUserButton](#cmfctoolbarbutton__m_buserbutton)|Specifies whether the button has a user-defined image.|  
|[CMFCToolBarButton::m_bWholeText](#cmfctoolbarbutton__m_bwholetext)|Specifies whether the button displays its full text label even if it does not fit in the bounding rectangle.|  
|[CMFCToolBarButton::m_bWrap](#cmfctoolbarbutton__m_bwrap)|Specifies whether the button next to a separator will be put on the next row.|  
|[CMFCToolBarButton::m_bWrapText](#cmfctoolbarbutton__m_bwraptext)|Specifies whether multi-line text labels are enabled.|  
|[CMFCToolBarButton::m_nID](#cmfctoolbarbutton__m_nid)|The command ID of the button.|  
|[CMFCToolBarButton::m_nStyle](#cmfctoolbarbutton__m_nstyle)|The style of the button.|  
|[CMFCToolBarButton::m_strText](#cmfctoolbarbutton__m_strtext)|The text label of the button.|  
  
## Remarks  
 A <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> object is a control that resides on a toolbar. Its behavior resembles that of an ordinary button. You can assign an image and a text label to this object. A toolbar button can also have a command ID. When the user clicks the toolbar button, the framework executes the command that this ID specifies.  
  
 Typically, toolbar buttons can be customized: the user can drag buttons from one toolbar to another, and copy, paste, delete, and edit text labels and images. To prevent the user from customizing the toolbar, you can lock the toolbar in one of two ways. Either set the <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> flag to <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> when you call [CMFCToolBar::LoadToolBar](../vs140/cmfctoolbar-class.md#cmfctoolbar__loadtoolbar), or add the command ID of an individual button to the global list of protected commands by using the [CMFCToolBarButton::SetProtectedCommands](#cmfctoolbarbutton__setprotectedcommands) method.  
  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> objects display images from the global collections of toolbar images in the application. These collections are maintained by the parent toolbar, [CMFCToolBar](../vs140/cmfctoolbar-class.md). For more information, see [CMFCToolBarImages](../vs140/cmfctoolbarimages-class.md).  
  
 When the user clicks a toolbar button, its parent toolbar processes the mouse message and communicates the appropriate actions to the button. If the button has a valid command ID, the parent toolbar sends the <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> message to the parent frame.  
  
 The <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> class is the base class for other toolbar button classes, such as [CMFCToolbarMenuButton](../vs140/cmfctoolbarmenubutton-class.md), [CMFCToolbarEditBoxButton](../vs140/cmfctoolbareditboxbutton-class.md), and [CMFCToolbarComboBoxButton](../vs140/cmfctoolbarcomboboxbutton-class.md).  
  
## Example  
 The following example demonstrates how to configure a <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> object by using various methods in the <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> class. The example illustrates how to enable the mouse and keyboard input, set the image index of the button, set the bounding rectangle of the button, and make the button visible. This code snippet is part of the [Tab Control sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_TabControl#1](../vs140/codesnippet/CPP/cmfctoolbarbutton-class_1.cpp)]  
[!code[NVC_MFC_TabControl#2](../vs140/codesnippet/CPP/cmfctoolbarbutton-class_2.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMFCToolBarButton](../vs140/cmfctoolbarbutton-class.md)  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
##  \<a name="cmfctoolbarbutton__canbedropped">\</a>  CMFCToolBarButton::CanBeDropped  
 Specifies whether a user can position a button on a toolbar or menu during customization.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in]  <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 Unused.  
  
### Return Value  
 This method returns <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>.  
  
### Remarks  
 By default, a toolbar button can be dropped on every customizable (that is, non-locked) toolbar.  
  
 The default implementation of this method returns <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>. Override this method and return <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> if you want to prevent the user from repositioning the button.  
  
##  \<a name="cmfctoolbarbutton__canbestored">\</a>  CMFCToolBarButton::CanBeStored  
 Determines whether the button can be stored.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 This method returns <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>.  
  
### Remarks  
 The framework uses this method to determine whether the button can participate in a drag-and-drop operation.  
  
 The default implementation returns <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>. Override this method if your button cannot be stored as part of a drag-and-drop operation. For more information about drag-and-drop operations, see [Drag and Drop (OLE)](../vs140/drag-and-drop--ole-.md).  
  
##  \<a name="cmfctoolbarbutton__canbestretched">\</a>  CMFCToolBarButton::CanBeStretched  
 Specifies whether a user can stretch the button during customization.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 This method returns <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method is used by the framework to determine whether the button can be stretched in customization mode.  
  
 The default implementation of this method returns <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>. Override this method to return <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> for a variable-width control such as a combo box or slider.  
  
 For more information about customization mode, see [CMFCToolBar::SetCustomizeMode](../vs140/cmfctoolbar-class.md#cmfctoolbar__setcustomizemode).  
  
##  \<a name="cmfctoolbarbutton__cmfctoolbarbutton">\</a>  CMFCToolBarButton::CMFCToolBarButton  
 Constructs and initializes a <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
 The command ID of the button.  
  
 [in] <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 The image index of the button in the collection of images.  
  
 [in] <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
 The text label of the button. Can be <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 A Boolean value that determines whether the button is user-defined. If this parameter is <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>, the button is user-defined. Otherwise, the button image is loaded from a resource.  
  
 [in] <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 A Boolean value that determines whether the button can be customized. If this parameter is <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>, the button cannot be customized. Otherwise, the button can be customized.  
  
##  \<a name="cmfctoolbarbutton__comparewith">\</a>  CMFCToolBarButton::CompareWith  
 Compares this instance with the provided <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
 Reference to the object to compare with this instance.  
  
### Return Value  
 Nonzero if the provided object equals the value of this instance; otherwise, 0.  
  
### Remarks  
 The default implementation determines whether the command ID of the provided object equals the command ID of this instance. Override this method if you must perform additional processing to determine whether two <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> objects are equal.  
  
##  \<a name="cmfctoolbarbutton__copyfrom">\</a>  CMFCToolBarButton::CopyFrom  
 Copies the properties of another toolbar button to the current button.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
 A reference to the source button from which to copy.  
  
### Remarks  
 Call this method to copy another toolbar button to this toolbar button.  
  
##  \<a name="cmfctoolbarbutton__createfromoledata">\</a>  CMFCToolBarButton::CreateFromOleData  
 Creates a <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> object from the provided <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
 The source OLE data object.  
  
### Return Value  
 The created <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> object.  
  
### Remarks  
 This method is used by the framework to perform data transfer in various formats. For example, the <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> method uses this method to perform drag-and-drop operations.  
  
##  \<a name="cmfctoolbarbutton__enablewindow">\</a>  CMFCToolBarButton::EnableWindow  
 Enables or disables mouse and keyboard input.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
 Set this parameter to <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> to enable input, or to <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> to disable input.  
  
### Remarks  
 This method calls the <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> function to enable or disable input. For more information, see                         [EnableWindow](http://msdn.microsoft.com/library/windows/desktop/ms646291) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cmfctoolbarbutton__exporttomenubutton">\</a>  CMFCToolBarButton::ExportToMenuButton  
 Copies text from the toolbar button to a menu.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
 A reference to the target menu button.  
  
### Return Value  
 This method returns <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>.  
  
### Remarks  
 The framework calls this method to copy the text from a toolbar button to a menu button. The default implementation copies the text label of the button. If the text label is empty, this method copies the tooltip text of the button.  
  
 The default implementation of this method returns <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>. Override this method if you want to take additional actions when the framework converts an object that is derived from [CMFCToolbarButton](../vs140/cmfctoolbarbutton-class.md) to a menu button.  
  
##  \<a name="cmfctoolbarbutton__getclipboardformat">\</a>  CMFCToolBarButton::GetClipboardFormat  
 Retrieves the global clipboard format for the application.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 The global <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> value for the application.  
  
### Remarks  
 The framework calls this method to retrieve the clipboard format for OLE data transfer operations. For example, the [CMFCToolBarButton::CreateFromOleData](#cmfctoolbarbutton__createfromoledata) method uses this method to copy data from a source OLE data object.  
  
 This method sets the global <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> value the first time this method is called. All subsequent calls to this method return this value.  
  
 To allow drag-and-drop operations to occur between applications, call the [CMFCToolBarButton::SetClipboardFormatName](#cmfctoolbarbutton__setclipboardformatname) method.  
  
 For more information about clipboards in MFC, see [Clipboard](../vs140/clipboard.md).  
  
##  \<a name="cmfctoolbarbutton__gethwnd">\</a>  CMFCToolBarButton::GetHwnd  
 Retrieves the window handle that is associated with the toolbar button.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 The window handle that is associated with the toolbar button or <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> if the toolbar button has no associated window handle.  
  
### Remarks  
 The default implementation of this method returns <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>. Override this method to return the window handle of your specific control.  
  
##  \<a name="cmfctoolbarbutton__getimage">\</a>  CMFCToolBarButton::GetImage  
 Retrieves the image index of the button.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 The index of the image associated with this button.  
  
### Remarks  
 If the button has a user-defined image (that is, if <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> was <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> in the constructor), the returned index specifies an image in the collection of user-defined images (see [CMFCToolBar::GetUserImages](../vs140/cmfctoolbar-class.md#cmfctoolbar__getuserimages)). Otherwise, the index specifies an image in the collection of images that are loaded from a resource file (see [CMFCToolBar::GetImages](../vs140/cmfctoolbar-class.md#cmfctoolbar__getimages)). For more information about resource files, see [Working with Resource Files](../vs140/working-with-resource-files.md).  
  
##  \<a name="cmfctoolbarbutton__getinvalidaterect">\</a>  CMFCToolBarButton::GetInvalidateRect  
 Retrieves the region of the client area of the button that must be redrawn.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> object that specifies the region that must be redrawn.  
  
### Remarks  
 The default implementation of this method returns the whole client area. Override this method if you want a different area to be redrawn.  
  
##  \<a name="cmfctoolbarbutton__getparentwnd">\</a>  CMFCToolBarButton::GetParentWnd  
 Retrieves the parent window of the button.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 The parent window of the button.  
  
##  \<a name="cmfctoolbarbutton__getprotectedcommands">\</a>  CMFCToolBarButton::GetProtectedCommands  
 Retrieves the list of commands that the user cannot customize.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 The list of protected commands.  
  
### Remarks  
 In customization mode, the framework disables toolbar button commands that are protected. The user cannot perform drag-and-drop and edit operations on disabled toolbar buttons.  
  
 Use the [CMFCToolBarButton::SetProtectedCommands](#cmfctoolbarbutton__setprotectedcommands) method to define the list of protected commands.  
  
##  \<a name="cmfctoolbarbutton__gettextsize">\</a>  CMFCToolBarButton::GetTextSize  
 Retrieves the size of the button text.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> object that contains the size, in pixels, of the button text.  
  
##  \<a name="cmfctoolbarbutton__hasfocus">\</a>  CMFCToolBarButton::HasFocus  
 Determines whether the button has the current input focus.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the button has the input focus; otherwise 0.  
  
### Remarks  
 The default implementation of this method returns nonzero if the button has the input focus or is a child or descendant window of the window that has the input focus. You can override this function to customize this behavior.  
  
##  \<a name="cmfctoolbarbutton__havehotborder">\</a>  CMFCToolBarButton::HaveHotBorder  
 Determines whether a border of the button is displayed when a user selects the button.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
 This method returns <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>.  
  
### Remarks  
 The framework calls this method to determine whether the toolbar button should display its border when a user selects it.  
  
 The default implementation returns <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>. You can override this method to customize this behavior.  
  
##  \<a name="cmfctoolbarbutton__isdrawimage">\</a>  CMFCToolBarButton::IsDrawImage  
 Determines whether an image is displayed on the button.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if an image is displayed on the button; otherwise 0.  
  
### Remarks  
 This method returns <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> if the toolbar button has no associated image ( [CMFCToolBarButton::GetImage](#cmfctoolbarbutton__getimage) returns -1) or if [CMFCToolBarButton::m_bImage](#cmfctoolbarbutton__m_bimage) is set to <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctoolbarbutton__isdrawtext">\</a>  CMFCToolBarButton::IsDrawText  
 Determines whether a text label is displayed on the button.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if a text label is displayed; otherwise 0.  
  
### Remarks  
 This method returns <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> if the toolbar button has no associated text label ( [m_strText](#cmfctoolbarbutton__m_strtext) is empty) or [m_bText](#cmfctoolbarbutton__m_btext) is set to <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctoolbarbutton__isdroppeddown">\</a>  CMFCToolBarButton::IsDroppedDown  
 Determines whether the button displays a submenu.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 This method returns <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>.  
  
### Remarks  
 The default implementation of this method returns <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>. Override this method to return <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> if your control displays a submenu.  
  
##  \<a name="cmfctoolbarbutton__iseditable">\</a>  CMFCToolBarButton::IsEditable  
 Determines whether the button can be customized.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if a button can be customized by the user; otherwise 0.  
  
### Remarks  
 The framework calls this method to determine whether the user can customize the toolbar button by using drag-and-drop or edit operations.  
  
 The default implementation returns <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> if the command ID of the button is a standard command (you can determine this by calling the <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> function) or if the command ID is in the list of protected commands. For more information about protected commands, see [CMFCToolBarButton::GetProtectedCommands](#cmfctoolbarbutton__getprotectedcommands) and [CMFCToolBarButton::SetProtectedCommands](#cmfctoolbarbutton__setprotectedcommands).  
  
 Override this method to customize its behavior.  
  
##  \<a name="cmfctoolbarbutton__isextrasize">\</a>  CMFCToolBarButton::IsExtraSize  
 Determines whether the button can be displayed with an extended border.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the toolbar button can be displayed with an extended border; otherwise 0.  
  
### Remarks  
 Several skins use extra size for the borders of toolbar buttons (for example, round buttons).  
  
 If the user moves this button from one toolbar to another, the framework calls the [OnChangeParentWnd](#cmfctoolbarbutton__onchangeparentwnd) method. The [OnChangeParentWnd](#cmfctoolbarbutton__onchangeparentwnd) method sets the extra size flag to that of the new parent toolbar (for more information, see [CMFCToolBar::IsButtonExtraSizeAvailable](../vs140/cmfctoolbar-class.md#cmfctoolbar__isbuttonextrasizeavailable)).  
  
##  \<a name="cmfctoolbarbutton__isfirstingroup">\</a>  CMFCToolBarButton::IsFirstInGroup  
 Determines whether the button is in the first position in its button group.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> if the button is the first button in its button group; otherwise <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method defines a *button group* as a neighboring set of buttons that are positioned on the same row and are bounded by separators or the border of the toolbar. This method returns <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> if the toolbar button refers to the **Customize** button. For more information about the **Customize** button, see [CMFCToolBar::GetCustomizeButton](../vs140/cmfctoolbar-class.md#cmfctoolbar__getcustomizebutton).  
  
 Call the [CMFCToolBarButton::IsLastInGroup](#cmfctoolbarbutton__islastingroup) method to determine whether the button is in the last position in its button group.  
  
##  \<a name="cmfctoolbarbutton__ishidden">\</a>  CMFCToolBarButton::IsHidden  
 Determines whether the button is hidden.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the button is hidden (invisible); otherwise 0.  
  
### Remarks  
 The framework calls this method when the parent toolbar is stretched to determine whether the toolbar button is visible.  
  
 If you set the button to be invisible by using the [CMFCToolBarButton::SetVisible](#cmfctoolbarbutton__setvisible) method, use [IsVisible](#cmfctoolbarbutton__isvisible) to determine whether the toolbar button is visible.  
  
 By default, all toolbar buttons are visible. Use the [Show](#cmfctoolbarbutton__show) method to hide or show toolbar buttons.  
  
##  \<a name="cmfctoolbarbutton__ishorizontal">\</a>  CMFCToolBarButton::IsHorizontal  
 Determines whether the button is located on a horizontal toolbar.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if a toolbar button is located on a horizontal toolbar; otherwise 0.  
  
### Remarks  
 The framework calls this method to determine the layout of toolbar buttons.  
  
 This method returns the <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> data member. The default value of the <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> data member is <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>; it is reset on each call to the [CMFCToolBarButton::OnDraw](#cmfctoolbarbutton__ondraw) method.  
  
##  \<a name="cmfctoolbarbutton__islastingroup">\</a>  CMFCToolBarButton::IsLastInGroup  
 Specifies whether the button is in the last position in its button group.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> if the button is the last button in its button group; otherwise <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method defines a *button group* as a neighboring set of buttons that are positioned on the same row and are bounded by separators or the border of the toolbar This method returns <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> if the toolbar button has no parent toolbar or the toolbar button refers to the **Customize** button. For more information about the **Customize** button, see [CMFCToolBar::GetCustomizeButton](../vs140/cmfctoolbar-class.md#cmfctoolbar__getcustomizebutton).  
  
 Call the [CMFCToolBarButton::IsFirstInGroup](#cmfctoolbarbutton__isfirstingroup) method to determine whether the button is in the first position in its button group.  
  
##  \<a name="cmfctoolbarbutton__islocked">\</a>  CMFCToolBarButton::IsLocked  
 Determines whether the button is on a locked (non-customizable) toolbar.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the button is on a locked toolbar; otherwise 0.  
  
### Remarks  
 The framework calls this method to determine whether the user can customize the toolbar button by using drag-and-drop or edit operations. Set the locked attribute on the parent toolbar by using the [CMFCToolBar::LoadToolBar,](../vs140/cmfctoolbar-class.md#cmfctoolbar__loadtoolbar) method. The framework passes the value of this attribute to the constructor of each toolbar button ( [CMFCToolbarButton](../vs140/cmfctoolbarbutton-class.md)) that it inserts into the parent toolbar.  
  
##  \<a name="cmfctoolbarbutton__isownerof">\</a>  CMFCToolBarButton::IsOwnerOf  
 Determines whether the button is the owner of the provided window handle.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>  
 A window handle.  
  
### Return Value  
 Nonzero if the button is the owner of the provided window handle; otherwise 0.  
  
### Remarks  
 This method returns nonzero if <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> either refers to the direct window handle or is a child of the window handle that is associated with the button. This method returns 0 if <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctoolbarbutton__isvisible">\</a>  CMFCToolBarButton::IsVisible  
 Determines whether the toolbar button is visible.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the toolbar button is visible; otherwise 0.  
  
### Remarks  
 You can show or hide the toolbar button by using the [SetVisible](#cmfctoolbarbutton__setvisible) method. Call the [CPane::AdjustSizeImmediate](../vs140/cpane-class.md#cpane__adjustsizeimmediate) method on the parent toolbar after you call [SetVisible](#cmfctoolbarbutton__setvisible) to recalculate the layout of a parent toolbar.  
  
##  \<a name="cmfctoolbarbutton__iswindowvisible">\</a>  CMFCToolBarButton::IsWindowVisible  
 Determines whether the underlying window handle of the button is visible.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the underlying window handle of the button is visible; otherwise 0.  
  
### Remarks  
 This method returns nonzero if the styles attribute of the underlying window handle contains the <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> style. This method returns <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> if the underlying window handle of the button is <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctoolbarbutton__m_bimage">\</a>  CMFCToolBarButton::m_bImage  
 Specifies whether an image is displayed on the button.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Remarks  
 If this data member is set to <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>, the framework displays the image that is associated with the toolbar button; otherwise the framework does not display the image. This member affects the return value of the [IsDrawImage](#cmfctoolbarbutton__m_bimage) method.  
  
##  \<a name="cmfctoolbarbutton__m_btext">\</a>  CMFCToolBarButton::m_bText  
 Specifies whether a text label is displayed on the button.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Remarks  
 If this data member is set to <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>, the framework displays the text label of the toolbar button; otherwise the framework does not display the text label. This member affects the return value of the [IsDrawText](#cmfctoolbarbutton__m_btext) method.  
  
##  \<a name="cmfctoolbarbutton__m_btextbelow">\</a>  CMFCToolBarButton::m_bTextBelow  
 Specifies whether the text label is displayed underneath the image on the button.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Remarks  
 If this member variable is set to <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>, the framework displays the text of the button underneath the image. The default value of this member is <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctoolbarbutton__m_buserbutton">\</a>  CMFCToolBarButton::m_bUserButton  
 Specifies whether the button has a user-defined image  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Remarks  
 This data member is set to <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> when the button has a user-defined image associated with it.  
  
##  \<a name="cmfctoolbarbutton__m_bwholetext">\</a>  CMFCToolBarButton::m_bWholeText  
 Specifies whether the button displays its full text label even if it does not fit in the bounding rectangle.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Remarks  
 If this data member is set to <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>, the framework displays the full text label by enlarging the button. Otherwise, the framework truncates and appends an ellipsis ( **...**) to the text label.  
  
##  \<a name="cmfctoolbarbutton__m_bwrap">\</a>  CMFCToolBarButton::m_bWrap  
 Specifies whether the button next to a separator will be put on the next row.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Remarks  
 The framework sets this data member to <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> when the toolbar button does not fit on the current row or when you specify a layout (for example, a specific number of toolbar buttons per row).  
  
 The framework places this button on the next row if this data member is set to <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> and the toolbar is docked horizontally or floating.  
  
 The default value of this data member is <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctoolbarbutton__m_bwraptext">\</a>  CMFCToolBarButton::m_bWrapText  
 Specifies whether multi-line text labels are enabled.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Remarks  
 If this static member variable is <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>, the framework enables all toolbars to display multi-line text labels on toolbar buttons.  
  
 The default value of this data member is <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctoolbarbutton__m_nid">\</a>  CMFCToolBarButton::m_nID  
 The command ID of the button.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Remarks  
 A command ID of -1 indicates that the button is a separator. All button separators have the <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> style. See [CMFCToolBarButton::m_nStyle](#cmfctoolbarbutton__m_nstyle) for more information about button styles.  
  
##  \<a name="cmfctoolbarbutton__m_nstyle">\</a>  CMFCToolBarButton::m_nStyle  
 The style of the button.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Remarks  
 See [ToolBar Control Styles](../vs140/toolbar-control-styles.md) for the list of available toolbar button styles.  
  
##  \<a name="cmfctoolbarbutton__m_strtext">\</a>  CMFCToolBarButton::m_strText  
 The text label of the button.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Remarks  
 This data member contains the text label of the button. The text label can be empty.  
  
##  \<a name="cmfctoolbarbutton__notifycommand">\</a>  CMFCToolBarButton::NotifyCommand  
 Specifies whether the button processes the                 [WM_COMMAND](http://msdn.microsoft.com/library/windows/desktop/ms647591) message.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>  
 The notification message that is associated with the command.  
  
### Return Value  
 This method returns <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>.  
  
### Remarks  
 The framework calls this method when it is about to send a                         [WM_COMMAND](http://msdn.microsoft.com/library/windows/desktop/ms647591) message to the parent window.  
  
 By default, this method returns <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>. Override this method to return <CodeContentPlaceHolder>179\</CodeContentPlaceHolder> if you want to process the <CodeContentPlaceHolder>180\</CodeContentPlaceHolder> message or <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> to indicate that the parent toolbar should handle the message.  
  
##  \<a name="cmfctoolbarbutton__onaddtocustomizepage">\</a>  CMFCToolBarButton::OnAddToCustomizePage  
 Called by the framework when the button is added to a **Customize** dialog box.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Remarks  
 The default implementation of this method does nothing. Override this method if you want to perform some action when the button is added to a **Customize** dialog box.  
  
##  \<a name="cmfctoolbarbutton__onbeforedrag">\</a>  CMFCToolBarButton::OnBeforeDrag  
 Specifies whether the button can be dragged.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>182\</CodeContentPlaceHolder> if the button can be dragged; otherwise <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>.  
  
### Remarks  
 The framework calls this method before the user starts to drag the button.  
  
 The default implementation of this method returns <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>. Override this method to return <CodeContentPlaceHolder>185\</CodeContentPlaceHolder> to disable dragging of the button.  
  
##  \<a name="cmfctoolbarbutton__onbeforedrop">\</a>  CMFCToolBarButton::OnBeforeDrop  
 Specifies whether a user can drop the button onto the target toolbar.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>  
 The target of the drag-and-drop operation.  
  
### Return Value  
 <CodeContentPlaceHolder>187\</CodeContentPlaceHolder> if the button can be dropped onto the provided target toolbar; otherwise <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>.  
  
### Remarks  
 The framework calls this method before the button is dropped onto a toolbar.  
  
 The default implementation of this method returns <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>. Override this method to return <CodeContentPlaceHolder>190\</CodeContentPlaceHolder> to disable the drop operation on the specified target.  
  
##  \<a name="cmfctoolbarbutton__oncalculatesize">\</a>  CMFCToolBarButton::OnCalculateSize  
 Called by the framework to calculate the size of the button for the specified device context and docking state.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>  
 The device context that displays the button.  
  
 [in] <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>  
 The default size of the button.  
  
 [in] <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>  
 The dock state of the parent toolbar. This parameter is <CodeContentPlaceHolder>194\</CodeContentPlaceHolder> if the toolbar is docked horizontally or is floating, or <CodeContentPlaceHolder>195\</CodeContentPlaceHolder> if the toolbar is docked vertically.  
  
### Return Value  
 A <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> structure that contains the dimensions of the button, in pixels.  
  
### Remarks  
 The framework calls this method to determine the size of the toolbar button for the specified device context and dock state.  
  
 The default implementation considers the text and image sizes (if they are displayed), the text and image positions (the text below or at the right-hand side of the image), and the toolbar dock state.  
  
 Override this method if you want to provide the size of a non-standard button (for example, an edit box button).  
  
##  \<a name="cmfctoolbarbutton__oncancelmode">\</a>  CMFCToolBarButton::OnCancelMode  
 Called by the framework to handle the                 [WM_CANCELMODE](http://msdn.microsoft.com/library/windows/desktop/ms632615) message.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Remarks  
 The default implementation of this method does nothing. Override this method if you want to handle the                         [WM_CANCELMODE](http://msdn.microsoft.com/library/windows/desktop/ms632615) message.  
  
##  \<a name="cmfctoolbarbutton__onchangeparentwnd">\</a>  CMFCToolBarButton::OnChangeParentWnd  
 Called by the framework when the button is inserted into a new toolbar.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>  
 The new parent window.  
  
### Remarks  
 The button is inserted into a toolbar, for example, when the user drags it from one toolbar to another toolbar.  
  
 The default implementation of this method does nothing.  
  
##  \<a name="cmfctoolbarbutton__onclick">\</a>  CMFCToolBarButton::OnClick  
 Called by the framework when the user clicks the mouse button.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>  
 The parent window of the toolbar button.  
  
 [in] <CodeContentPlaceHolder>199\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>200\</CodeContentPlaceHolder> if the message should be handled with a delay.  
  
### Return Value  
 This method returns <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>.  
  
### Remarks  
 The framework calls this method when the user clicks the toolbar button.  
  
 The default implementation does nothing and returns <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>. Override this method to return a nonzero value if the button processes the click message.  
  
##  \<a name="cmfctoolbarbutton__onclickup">\</a>  CMFCToolBarButton::OnClickUp  
 Called by the framework when the user releases the mouse button.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Return Value  
 This method returns <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>.  
  
### Remarks  
 The framework calls this method when the user releases the toolbar button.  
  
 The default implementation does nothing and returns <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>. Override this method to return a nonzero value if the button processes the click message.  
  
##  \<a name="cmfctoolbarbutton__oncontexthelp">\</a>  CMFCToolBarButton::OnContextHelp  
 Called by the framework when the parent toolbar handles a <CodeContentPlaceHolder>205\</CodeContentPlaceHolder> message.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>  
 The parent window of the toolbar button.  
  
### Return Value  
 This method returns <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>.  
  
### Remarks  
 The default implementation of this method does nothing and returns <CodeContentPlaceHolder>208\</CodeContentPlaceHolder>. Override this method to return a nonzero value if the button processes the help message.  
  
 For more information about the <CodeContentPlaceHolder>209\</CodeContentPlaceHolder> message, see [TN028: Context-Sensitive Help Support](../vs140/tn028--context-sensitive-help-support.md).  
  
##  \<a name="cmfctoolbarbutton__onctlcolor">\</a>  CMFCToolBarButton::OnCtlColor  
 Called by the framework when the parent toolbar handles a <CodeContentPlaceHolder>210\</CodeContentPlaceHolder> message.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>211\</CodeContentPlaceHolder>  
 The device context that displays the button.  
  
 [in] <CodeContentPlaceHolder>212\</CodeContentPlaceHolder>  
 The specific color notification.  
  
### Return Value  
 A handle to the brush object that the framework uses to paint the background of the button.  
  
### Remarks  
 The framework calls this method when the parent toolbar processes the <CodeContentPlaceHolder>213\</CodeContentPlaceHolder> message for a toolbar button that contains a Windows control. The framework does not call this method if the toolbar button is windowless.  
  
 The framework calls this method when the toolbar framework is in customization mode and the toolbar button is unlocked. For more information about customization mode, see [CMFCToolBar::SetCustomizeMode](../vs140/cmfctoolbar-class.md#cmfctoolbar__setcustomizemode). For more information about locking toolbar buttons, see [CMFCToolBarButton::IsLocked](#cmfctoolbarbutton__islocked).  
  
 The default implementation does nothing and returns <CodeContentPlaceHolder>214\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctoolbarbutton__oncustomizemenu">\</a>  CMFCToolBarButton::OnCustomizeMenu  
 Allows the button to modify the provided menu when the application displays a shortcut menu on the parent toolbar.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>  
 The menu to customize.  
  
### Return Value  
 This method returns <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>.  
  
### Remarks  
 The default implementation does nothing and returns <CodeContentPlaceHolder>217\</CodeContentPlaceHolder>. Override this method and return a nonzero value if you want to modify the contents of the provided menu.  
  
##  \<a name="cmfctoolbarbutton__ondblclk">\</a>  CMFCToolBarButton::OnDblClk  
 Called by the framework when the parent toolbar handles a                 [WM_LBUTTONDBLCLK](http://msdn.microsoft.com/library/windows/desktop/ms645606) message.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>  
 -   The parent window of the button.  
  
### Remarks  
 This method is called by the <CodeContentPlaceHolder>219\</CodeContentPlaceHolder> method when the parent toolbar handles a                         [WM_LBUTTONDBLCLK](http://msdn.microsoft.com/library/windows/desktop/ms645606) message.  
  
 The default implementation of this method does nothing.  
  
##  \<a name="cmfctoolbarbutton__ondraw">\</a>  CMFCToolBarButton::OnDraw  
 Called by the framework to draw the button by using the specified styles and options.  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>  
 The device context that displays the button.  
  
 [in] <CodeContentPlaceHolder>221\</CodeContentPlaceHolder>  
 The bounding rectangle of the button.  
  
 [in] <CodeContentPlaceHolder>222\</CodeContentPlaceHolder>  
 The collection of toolbar images that is associated with the button.  
  
 [in] <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>  
 The dock state of the parent toolbar. This parameter is <CodeContentPlaceHolder>224\</CodeContentPlaceHolder> when the button is docked horizontally and <CodeContentPlaceHolder>225\</CodeContentPlaceHolder> when the button is docked vertically.  
  
 [in] <CodeContentPlaceHolder>226\</CodeContentPlaceHolder>  
 Specifies whether the toolbar is in customization mode. This parameter is <CodeContentPlaceHolder>227\</CodeContentPlaceHolder> when the toolbar is in customization mode and <CodeContentPlaceHolder>228\</CodeContentPlaceHolder> when the toolbar is not in customization mode.  
  
 [in] <CodeContentPlaceHolder>229\</CodeContentPlaceHolder>  
 Specifies whether the button is highlighted. This parameter is <CodeContentPlaceHolder>230\</CodeContentPlaceHolder> when the button is highlighted and <CodeContentPlaceHolder>231\</CodeContentPlaceHolder> when the button is not highlighted.  
  
 [in] <CodeContentPlaceHolder>232\</CodeContentPlaceHolder>  
 Specifies whether the button should display its border. This parameter is <CodeContentPlaceHolder>233\</CodeContentPlaceHolder> when the button should display its border and <CodeContentPlaceHolder>234\</CodeContentPlaceHolder> when the button should not display its border.  
  
 [in] <CodeContentPlaceHolder>235\</CodeContentPlaceHolder>  
 Specifies whether to shade disabled buttons or use the disabled images collection. This parameter is <CodeContentPlaceHolder>236\</CodeContentPlaceHolder> when disabled buttons should be shaded and <CodeContentPlaceHolder>237\</CodeContentPlaceHolder> when this method should use the disabled images collection.  
  
### Remarks  
 Override this method to customize toolbar button drawing.  
  
##  \<a name="cmfctoolbarbutton__ondrawoncustomizelist">\</a>  CMFCToolBarButton::OnDrawOnCustomizeList  
 Called by the framework to draw the button in the **Commands** pane of the **Customize** dialog box.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>238\</CodeContentPlaceHolder>  
 The device context that displays the button.  
  
 [in] <CodeContentPlaceHolder>239\</CodeContentPlaceHolder>  
 The bounding rectangle of the button.  
  
 [in] <CodeContentPlaceHolder>240\</CodeContentPlaceHolder>  
 Specifies whether the button is selected. If this parameter is <CodeContentPlaceHolder>241\</CodeContentPlaceHolder>, the button is selected. If this parameter is <CodeContentPlaceHolder>242\</CodeContentPlaceHolder>, the button is not selected.  
  
### Return Value  
 The width, in pixels, of the button on the specified device context.  
  
### Remarks  
 This method is called by the customization dialog box ( **Commands** tab) when the button is about to display itself on the owner-draw list box.  
  
 The default implementation of this method displays the image and text label of the button if they are available. If the text label of the button is not available, the method displays the tooltip text.  
  
 Override this method to perform custom drawing.  
  
##  \<a name="cmfctoolbarbutton__ongetcustomtooltiptext">\</a>  CMFCToolBarButton::OnGetCustomToolTipText  
 Called by the framework to retrieve the custom tooltip text for the button.  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>243\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>244\</CodeContentPlaceHolder> object that receives the custom tooltip text.  
  
### Return Value  
 This method returns <CodeContentPlaceHolder>245\</CodeContentPlaceHolder>.  
  
### Remarks  
 The framework calls this method when it displays the tooltip for the toolbar button. If this method returns <CodeContentPlaceHolder>246\</CodeContentPlaceHolder>, the framework uses a default tooltip.  
  
 The default implementation does nothing and returns <CodeContentPlaceHolder>247\</CodeContentPlaceHolder>. Override this method and return a nonzero value to provide custom tooltip text for the toolbar button.  
  
##  \<a name="cmfctoolbarbutton__onglobalfontschanged">\</a>  CMFCToolBarButton::OnGlobalFontsChanged  
 Called by the framework when the global font has changed.  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
### Remarks  
 The default implementation of this method does nothing. Override this method to update the font that is used to display the button text.  
  
##  \<a name="cmfctoolbarbutton__onmove">\</a>  CMFCToolBarButton::OnMove  
 Called by the framework when the parent toolbar moves.  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Remarks  
 The default implementation of this method does nothing. Override this method to reposition the button when the parent toolbar moves.  
  
##  \<a name="cmfctoolbarbutton__onshow">\</a>  CMFCToolBarButton::OnShow  
 Called by the framework when the button becomes visible or invisible.  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>248\</CodeContentPlaceHolder>  
 Specifies whether the button is visible. If this parameter is <CodeContentPlaceHolder>249\</CodeContentPlaceHolder>, the button is visible. Otherwise, the button is not visible.  
  
### Remarks  
 The default implementation of this method does nothing. Override this method to update the visibility of the button.  
  
##  \<a name="cmfctoolbarbutton__onsize">\</a>  CMFCToolBarButton::OnSize  
 Called by the framework when the parent toolbar changes its size or position and this change causes the button to change size.  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>250\</CodeContentPlaceHolder>  
 The new width of the button.  
  
### Remarks  
 The default implementation of this method does nothing. Override this method to resize the button when the size or position of the parent toolbar changes.  
  
##  \<a name="cmfctoolbarbutton__ontoolhittest">\</a>  CMFCToolBarButton::OnToolHitTest  
 Called by the framework when the parent toolbar must determine whether a point is in the bounding rectangle of the button.  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>251\</CodeContentPlaceHolder>  
 The parent window of the button. Can be <CodeContentPlaceHolder>252\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>253\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>254\</CodeContentPlaceHolder> structure that contains information about a tool in a tooltip control.  
  
### Return Value  
 The result of <CodeContentPlaceHolder>255\</CodeContentPlaceHolder> if the button can retrieve a pointer to the parent frame window; otherwise <CodeContentPlaceHolder>256\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method calls one of the following methods if it can convert the parent window to a valid frame object:  
  
-   [CMDIFrameWndEx::OnMenuButtonToolHitTest](../vs140/cmdiframewndex-class.md#cmdiframewndex__onmenubuttontoolhittest)  
  
-   [CFrameWndEx::OnMenuButtonToolHitTest](../vs140/cframewndex-class.md#cframewndex__onmenubuttontoolhittest)  
  
-   [COleIPFrameWndEx::OnMenuButtonToolHitTest](../vs140/coleipframewndex-class.md#coleipframewndex__onmenubuttontoolhittest)  
  
##  \<a name="cmfctoolbarbutton__onupdatetooltip">\</a>  CMFCToolBarButton::OnUpdateToolTip  
 Called by the framework when the parent toolbar updates its tooltip text.  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>257\</CodeContentPlaceHolder>  
 The parent window.  
  
 [in] <CodeContentPlaceHolder>258\</CodeContentPlaceHolder>  
 The zero-based index of the button in the parent button collection.  
  
 [in] <CodeContentPlaceHolder>259\</CodeContentPlaceHolder>  
 The control that displays the tooltip text.  
  
 [out] <CodeContentPlaceHolder>260\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>261\</CodeContentPlaceHolder> object that receives the updated tooltip text.  
  
### Return Value  
 This method returns <CodeContentPlaceHolder>262\</CodeContentPlaceHolder>.  
  
### Remarks  
 The default implementation of this method does nothing and returns <CodeContentPlaceHolder>263\</CodeContentPlaceHolder>. Override this method to return a nonzero value if you provide a tooltip text string.  
  
##  \<a name="cmfctoolbarbutton__preparedrag">\</a>  CMFCToolBarButton::PrepareDrag  
 Called by the framework when the button is about to perform a drag-and-drop operation.  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>264\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>265\</CodeContentPlaceHolder> object that stores state information about the drag-and-drop operation.  
  
### Return Value  
 <CodeContentPlaceHolder>266\</CodeContentPlaceHolder> if the operation succeeds; otherwise <CodeContentPlaceHolder>267\</CodeContentPlaceHolder>.  
  
### Remarks  
 The framework calls this method to prepare the toolbar button to store its state in the provided <CodeContentPlaceHolder>268\</CodeContentPlaceHolder> object. This method stores its state by serializing itself to a shared file and then passing that file to the [COleDataSource::CacheGlobalData](../vs140/coledatasource-class.md#coledatasource__cacheglobaldata) method. For more information about toolbar button serialization, see [CMFCToolBarButton::Serialize](#cmfctoolbarbutton__serialize).  
  
 This method does nothing and returns <CodeContentPlaceHolder>269\</CodeContentPlaceHolder> if the button cannot be stored (the [CMFCToolBarButton::CanBeStored](#cmfctoolbarbutton__canbestored) method returns <CodeContentPlaceHolder>270\</CodeContentPlaceHolder>). It returns <CodeContentPlaceHolder>271\</CodeContentPlaceHolder> if an exception occurs during object serialization.  
  
 For more information about OLE drag-and-drop operations, see [Drag and Drop (OLE)](../vs140/drag-and-drop--ole-.md).  
  
##  \<a name="cmfctoolbarbutton__rect">\</a>  CMFCToolBarButton::Rect  
 Retrieves the bounding rectangle of the button.  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>272\</CodeContentPlaceHolder> object that contains the bounding rectangle of a button.  
  
##  \<a name="cmfctoolbarbutton__resetimagetodefault">\</a>  CMFCToolBarButton::ResetImageToDefault  
 Sets to the default value the image that is associated with the button.  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
### Remarks  
 This method retrieves the default image from its parent toolbar by using the [CMFCToolBar::GetDefaultImage](../vs140/cmfctoolbar-class.md#cmfctoolbar__getdefaultimage) method. If the button has no associated default image, this method sets the text label of the button according to its string resource by using the [CStringT::LoadString](../vs140/cstringt--loadstring.md) method. For more information about string resources, see [Working with Resource Files](../vs140/working-with-resource-files.md).  
  
 This method does nothing if the button has a user-defined image.  
  
##  \<a name="cmfctoolbarbutton__savebarstate">\</a>  CMFCToolBarButton::SaveBarState  
 Saves the state of the toolbar button.  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
### Remarks  
 The framework calls this method when it creates a <CodeContentPlaceHolder>273\</CodeContentPlaceHolder> object as the result of a drag-and-drop operation.  
  
 The default implementation of this method does nothing. Override this method to save the state of the toolbar button to an external data source.  
  
##  \<a name="cmfctoolbarbutton__serialize">\</a>  CMFCToolBarButton::Serialize  
 Reads this object from an archive or writes it to an archive.  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>274\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>275\</CodeContentPlaceHolder> object from which or to which to serialize.  
  
### Remarks  
 This method supports data transfer processes such as clipboard or drag-and-drop operations. It reads or writes properties of the button such as the ID, text label, and image ID from or to the provided <CodeContentPlaceHolder>276\</CodeContentPlaceHolder> object.  
  
 For serialization examples, see [Serialization: Serializing an Object](../vs140/serialization--serializing-an-object.md).  
  
##  \<a name="cmfctoolbarbutton__setaccdata">\</a>  CMFCToolBarButton::SetACCData  
 Populates the provided <CodeContentPlaceHolder>277\</CodeContentPlaceHolder> object with accessibility data from the toolbar button.  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>278\</CodeContentPlaceHolder>  
 The parent window of the toolbar button.  
  
 [in] <CodeContentPlaceHolder>279\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>280\</CodeContentPlaceHolder> object that is populated with the accessibility data of the toolbar button.  
  
### Return Value  
 This method returns <CodeContentPlaceHolder>281\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this method to return <CodeContentPlaceHolder>282\</CodeContentPlaceHolder> if your toolbar button does not provide accessibility data.  
  
##  \<a name="cmfctoolbarbutton__setclipboardformatname">\</a>  CMFCToolBarButton::SetClipboardFormatName  
 Renames the global clipboard format.  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>283\</CodeContentPlaceHolder>  
 The new name of the global clipboard format. Cannot be <CodeContentPlaceHolder>284\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method makes it possible for drag-and-drop operations to occur among multiple applications. Each application must supply the same clipboard format name.  
  
 You must call this method before the framework calls [CMFCToolBarButton::GetClipboardFormat](#cmfctoolbarbutton__getclipboardformat).  
  
##  \<a name="cmfctoolbarbutton__setimage">\</a>  CMFCToolBarButton::SetImage  
 Sets the image index of the button.  
  
<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>285\</CodeContentPlaceHolder>  
 The index of the image in the collection of toolbar images.  
  
### Remarks  
 If the toolbar button is a separator, <CodeContentPlaceHolder>286\</CodeContentPlaceHolder> refers to the new width of the separator button.  
  
 If <CodeContentPlaceHolder>287\</CodeContentPlaceHolder> is less than zero, this method disables drawing of the image and enables drawing of the text label of the button.  
  
##  \<a name="cmfctoolbarbutton__setprotectedcommands">\</a>  CMFCToolBarButton::SetProtectedCommands  
 Sets the list of commands that the user cannot customize.  
  
<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>288\</CodeContentPlaceHolder>  
 The list of protected commands.  
  
### Remarks  
 In customization mode, the framework disables toolbar button commands that are protected. The user cannot perform drag-and-drop and edit operations on disabled toolbar buttons.  
  
 Use the [CMFCToolBarButton::GetProtectedCommands](#cmfctoolbarbutton__getprotectedcommands) method to retrieve the list of protected commands.  
  
##  \<a name="cmfctoolbarbutton__setradio">\</a>  CMFCToolBarButton::SetRadio  
 Called by the framework when a button changes its checked state.  
  
<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
### Remarks  
 The default implementation of this method does nothing. Override this method to perform a custom action when the button changes its checked state.  
  
##  \<a name="cmfctoolbarbutton__setrect">\</a>  CMFCToolBarButton::SetRect  
 Sets the bounding rectangle of the button.  
  
<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>289\</CodeContentPlaceHolder>  
 The new bounding rectangle of the button.  
  
### Remarks  
 This method calls the [CMFCToolBarButton::OnMove](#cmfctoolbarbutton__onmove) method after it sets the new bounding rectangle.  
  
##  \<a name="cmfctoolbarbutton__setstyle">\</a>  CMFCToolBarButton::SetStyle  
 Sets the style of the button.  
  
<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>290\</CodeContentPlaceHolder>  
 The new style of the button.  
  
### Remarks  
 The default implementation sets the [CMFCToolBarButton::m_nStyle](#cmfctoolbarbutton__m_nstyle) data member to <CodeContentPlaceHolder>291\</CodeContentPlaceHolder>. Override this method if you want to perform additional processing to handle the change in style. See [ToolBar Control Styles](../vs140/toolbar-control-styles.md) for a list of valid style flags.  
  
##  \<a name="cmfctoolbarbutton__setvisible">\</a>  CMFCToolBarButton::SetVisible  
 Specifies whether the button is visible.  
  
<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>292\</CodeContentPlaceHolder>  
 A Boolean value that specifies whether to show or hide the button. If this parameter is <CodeContentPlaceHolder>293\</CodeContentPlaceHolder>, the button is shown. If the parameter is <CodeContentPlaceHolder>294\</CodeContentPlaceHolder>, the button is hidden.  
  
### Remarks  
 Use this function to hide or show a particular toolbar button. Call the [CPane::AdjustSizeImmediate](../vs140/cpane-class.md#cpane__adjustsizeimmediate) method after you call this method.  
  
##  \<a name="cmfctoolbarbutton__show">\</a>  CMFCToolBarButton::Show  
 Shows or hides the button.  
  
<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>295\</CodeContentPlaceHolder>  
 A Boolean value that specifies whether to show or hide the button. If this parameter is <CodeContentPlaceHolder>296\</CodeContentPlaceHolder>, the button is shown. If the parameter is <CodeContentPlaceHolder>297\</CodeContentPlaceHolder>, the button is hidden.  
  
### Remarks  
 The framework calls this method to update the visibility of toolbar buttons when their parent toolbar is resized. The framework calls this method with <CodeContentPlaceHolder>298\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>299\</CodeContentPlaceHolder> when the button no longer fits within the bounds of the toolbar. The framework calls this method with <CodeContentPlaceHolder>300\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>301\</CodeContentPlaceHolder> when after resizing the button again fits within the bounds of the toolbar.  
  
 Use the [CMFCToolBarButton::SetVisible](#cmfctoolbarbutton__setvisible) method to set the general visibility of the button.  
  
 This method calls the [CMFCToolBarButton::OnShow](#cmfctoolbarbutton__onshow) method after it updates the visibility state of the button.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCToolBar](../vs140/cmfctoolbar-class.md)   
 [CMFCToolBarImages](../vs140/cmfctoolbarimages-class.md)   
 [OnClick](#cmfctoolbarbutton__onclick)   
 [NotifyCommand](#cmfctoolbarbutton__notifycommand)