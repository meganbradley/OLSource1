---
title: "CMFCToolBar Class"
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
  - "CMFCToolBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCToolBar class"
ms.assetid: e7679c01-fb94-44c0-98c6-3af955292fb5
caps.latest.revision: 46
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar Class
The <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> class resembles [CToolBar](../vs140/ctoolbar-class.md), but provides additional support for user interface features. These include flat toolbars, toolbars with hot images, large icons, pager buttons, locked toolbars, rebar controls, text under images, background images, and tabbed toolbars. The <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> class also contains built-in support for user customization of toolbars and menus, drag-and-drop between toolbars and menus, combo box buttons, edit box buttons, color pickers, and roll-up buttons.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>172\</CodeContentPlaceHolder>|Default constructor.|  
|<CodeContentPlaceHolder>173\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCToolBar::AddBasicCommand](#cmfctoolbar__addbasiccommand)|Adds a menu command to the list of commands that are always displayed when a user opens a menu.|  
|[CMFCToolBar::AddCommandUsage](#cmfctoolbar__addcommandusage)|Increments by one the counter that is associated with the given command.|  
|[CMFCToolBar::AddToolBarForImageCollection](#cmfctoolbar__addtoolbarforimagecollection)|Adds images from the user interface resources to the collection of images in the application.|  
|[CMFCToolBar::AdjustLayout](#cmfctoolbar__adjustlayout)|Recalculates the size and position of a toolbar. (Overrides [CBasePane::AdjustLayout](../vs140/cbasepane-class.md#cbasepane__adjustlayout)).|  
|[CMFCToolBar::AdjustSize](#cmfctoolbar__adjustsize)|Recalculates the size of the toolbar.|  
|[CMFCToolBar::AllowChangeTextLabels](#cmfctoolbar__allowchangetextlabels)|Specifies whether text labels can be shown under images on the toolbar buttons.|  
|[CMFCToolBar::AreTextLabels](#cmfctoolbar__aretextlabels)|Specifies whether text labels under images are currently displayed on the toolbar buttons.|  
|[CMFCToolBar::AutoGrayInactiveImages](#cmfctoolbar__autograyinactiveimages)|Enable or disables the automatic generation of inactive button images.|  
|[CMFCToolBar::ButtonToIndex](#cmfctoolbar__buttontoindex)|Returns the index of a specified [CMFCToolBarButton](../vs140/cmfctoolbarbutton-class.md) object in this toolbar.|  
|[CMFCToolBar::CalcFixedLayout](#cmfctoolbar__calcfixedlayout)|Calculates the horizontal size of the toolbar. (Overrides [CBasePane::CalcFixedLayout](../vs140/cbasepane-class.md#cbasepane__calcfixedlayout).)|  
|[CMFCToolBar::CalcSize](#cmfctoolbar__calcsize)|Called by the framework as part of the layout calculation process. (Overrides [CPane::CalcSize](../vs140/cpane-class.md#cpane__calcsize).)|  
|[CMFCToolBar::CanHandleSiblings](#cmfctoolbar__canhandlesiblings)|Determines whether the toolbar and its sibling are positioned on the same pane.|  
|[CMFCToolBar::CleanUpImages](#cmfctoolbar__cleanupimages)|Frees the system resources allocated for toolbar images.|  
|[CMFCToolBar::CleanUpLockedImages](#cmfctoolbar__cleanuplockedimages)|Frees the system resources allocated for locked toolbar images.|  
|[CMFCToolBar::CanBeClosed](#cmfctoolbar__canbeclosed)|Specifies whether a user can close the toolbar. (Overrides [CBasePane::CanBeClosed](../vs140/cbasepane-class.md#cbasepane__canbeclosed).)|  
|[CMFCToolBar::CanBeRestored](#cmfctoolbar__canberestored)|Determines whether the system can restore a toolbar to its original state after customization.|  
|[CMFCToolBar::CanFocus](#cmfctoolbar__canfocus)|Specifies whether the pane can receive focus. (Overrides [CBasePane::CanFocus](../vs140/cbasepane-class.md#cbasepane__canfocus).)|  
|[CMFCToolBar::CanHandleSiblings](#cmfctoolbar__canhandlesiblings)|Determines whether the toolbar and its sibling are positioned on the same pane.|  
|[CMFCToolBar::CommandToIndex](#cmfctoolbar__commandtoindex)|Returns the index of the button in the toolbar with a specified command ID.|  
|[CMFCToolBar::Create](#cmfctoolbar__create)|Creates a <CodeContentPlaceHolder>174\</CodeContentPlaceHolder> object.|  
|[CMFCToolBar::CreateEx](#cmfctoolbar__createex)|Creates a <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> object that uses additional style options, such as large icons.|  
|[CMFCToolBar::Deactivate](#cmfctoolbar__deactivate)|Deactivates the toolbar.|  
|[CMFCToolBar::EnableCustomizeButton](#cmfctoolbar__enablecustomizebutton)|Enables or disables the **Add or Remove Buttons** button that appears on the end of the toolbar.|  
|[CMFCToolBar::EnableDocking](#cmfctoolbar__enabledocking)|Enables docking of the pane to the main frame. (Overrides [CBasePane::EnableDocking](../vs140/cbasepane-class.md#cbasepane__enabledocking).)|  
|[CMFCToolBar::EnableLargeIcons](#cmfctoolbar__enablelargeicons)|Enables or disables large icons on toolbar buttons.|  
|[CMFCToolBar::EnableQuickCustomization](#cmfctoolbar__enablequickcustomization)|Enables or disables the quick customization of toolbars so that the user can press the **Alt** key and drag a button to a new location.|  
|[CMFCToolBar::EnableReflections](#cmfctoolbar__enablereflections)|Enables or disables command reflection.|  
|[CMFCToolBar::EnableTextLabels](#cmfctoolbar__enabletextlabels)|Enables or disables text labels under toolbar button images.|  
|[CMFCToolBar::FromHandlePermanent](#cmfctoolbar__fromhandlepermanent)|Retrieves a pointer to the <CodeContentPlaceHolder>176\</CodeContentPlaceHolder> object that contains the given window handle.|  
|[CMFCToolBar::GetAllButtons](#cmfctoolbar__getallbuttons)|Returns a read-only list of buttons in a toolbar.|  
|[CMFCToolBar::GetAllToolbars](#cmfctoolbar__getalltoolbars)|Returns a read-only list of all toolbars in the application.|  
|[CMFCToolBar::GetBasicCommands](#cmfctoolbar__getbasiccommands)|Returns a read-only list of the basic commands defined in the application.|  
|[CMFCToolBar::GetButton](#cmfctoolbar__getbutton)|Returns a pointer to the <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> object that has a specified toolbar button index.|  
|[CMFCToolBar::GetButtonInfo](#cmfctoolbar__getbuttoninfo)|Returns the command ID, style, and image index of the button at a specified index.|  
|[CMFCToolBar::GetButtonSize](#cmfctoolbar__getbuttonsize)|Returns the dimensions of each button on the toolbar.|  
|[CMFCToolBar::GetButtonStyle](#cmfctoolbar__getbuttonstyle)|Returns the current style of the toolbar button that is located at the specified index.|  
|[CMFCToolBar::GetButtonText](#cmfctoolbar__getbuttontext)|Returns the text label of a button that has a specified index.|  
|[CMFCToolBar::GetColdImages](#cmfctoolbar__getcoldimages)|Returns a pointer to the collection of cold toolbar button images in the application.|  
|[CMFCToolBar::GetColumnWidth](#cmfctoolbar__getcolumnwidth)|Returns the width of the toolbar buttons.|  
|[CMFCToolBar::GetCommandButtons](#cmfctoolbar__getcommandbuttons)|Returns a list of buttons that have a specified command ID from all toolbars in the application.|  
|[CMFCToolBar::GetCount](#cmfctoolbar__getcount)|Returns the number of buttons and separators on the toolbar.|  
|[CMFCToolBar::GetCustomizeButton](#cmfctoolbar__getcustomizebutton)|Retrieves a pointer to the <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> object that is associated with the toolbar.|  
|[CMFCToolBar::GetDefaultImage](#cmfctoolbar__getdefaultimage)|Returns the index of the default image for a toolbar button with a specified command ID.|  
|[CMFCToolBar::GetDisabledImages](#cmfctoolbar__getdisabledimages)|Returns a pointer to the collection of images that are used for disabled toolbar buttons in the application.|  
|[CMFCToolBar::GetDisabledMenuImages](#cmfctoolbar__getdisabledmenuimages)|Returns a pointer to the collection of images that are used for disabled menu buttons in the application.|  
|[CMFCToolBar::GetDroppedDownMenu](#cmfctoolbar__getdroppeddownmenu)|Retrieves a pointer to the menu button object that is currently displaying its sub-menu.|  
|[CMFCToolBar::GetGrayDisabledButtons](#cmfctoolbar__getgraydisabledbuttons)|Specifies whether the images of disabled buttons are dimmed versions of the regular button images, or taken from the collection of disabled button images.|  
|[CMFCToolBar::GetHighlightedButton](#cmfctoolbar__gethighlightedbutton)|Returns a pointer to the toolbar button that is currently highlighted.|  
|[CMFCToolBar::GetHotBorder](#cmfctoolbar__gethotborder)|Determines whether the toolbar buttons are hot-tracked.|  
|[CMFCToolBar::GetHotTextColor](#cmfctoolbar__gethottextcolor)|Returns the text color of the highlighted toolbar buttons.|  
|[CMFCToolBar::GetHwndLastFocus](#cmfctoolbar__gethwndlastfocus)|Returns a handle to the window that had the input focus just before the toolbar did.|  
|[CMFCToolBar::GetIgnoreSetText](#cmfctoolbar__getignoresettext)|Specifies whether calls to set button labels are ignored.|  
|[CMFCToolBar::GetImageSize](#cmfctoolbar__getimagesize)|Returns the current size of toolbar button images.|  
|[CMFCToolBar::GetImages](#cmfctoolbar__getimages)|Returns a pointer to the collection of default button images in the application.|  
|[CMFCToolBar::GetImagesOffset](#cmfctoolbar__getimagesoffset)|Returns the index offset used to find the toolbar button images for this toolbar in the global list of toolbar button images.|  
|[CMFCToolBar::GetInvalidateItemRect](#cmfctoolbar__getinvalidateitemrect)|Retrieves the region of the client area that must be redrawn for the button at the given index.|  
|[CMFCToolBar::GetItemID](#cmfctoolbar__getitemid)|Returns the command ID of the toolbar button at a specified index.|  
|[CMFCToolBar::GetItemRect](#cmfctoolbar__getitemrect)|Returns the bounding rectangle of the button at a specified index.|  
|[CMFCToolBar::GetLargeColdImages](#cmfctoolbar__getlargecoldimages)|Returns a pointer to the collection of large cold toolbar button images in the application.|  
|[CMFCToolBar::GetLargeDisabledImages](#cmfctoolbar__getlargedisabledimages)|Returns a pointer to the collection of large disabled toolbar button images in the application.|  
|[CMFCToolBar::GetLargeImages](#cmfctoolbar__getlargeimages)|Returns a pointer to the collection of large toolbar button images in the application.|  
|[CMFCToolBar::GetLockedColdImages](#cmfctoolbar__getlockedcoldimages)|Returns a pointer to the collection of locked cold images in the toolbar.|  
|[CMFCToolBar::GetLockedDisabledImages](#cmfctoolbar__getlockeddisabledimages)|Returns a pointer to the collection of locked disabled images in the toolbar.|  
|[CMFCToolBar::GetLockedImages](#cmfctoolbar__getlockedimages)|Returns a pointer to the collection of locked button images in the toolbar.|  
|[CMFCToolBar::GetLockedImageSize](#cmfctoolbar__getlockedimagesize)|Returns the default size of locked toolbar images.|  
|[CMFCToolBar::GetLockedMenuImages](#cmfctoolbar__getlockedmenuimages)|Returns a pointer to the collection of locked toolbar menu images in the toolbar.|  
|[CMFCToolBar::GetMenuButtonSize](#cmfctoolbar__getmenubuttonsize)|Returns the size of menu buttons in the application.|  
|[CMFCToolBar::GetMenuImageSize](#cmfctoolbar__getmenuimagesize)|Returns the size of menu button images in the application.|  
|[CMFCToolBar::GetMenuImages](#cmfctoolbar__getmenuimages)|Returns a pointer to the collection of menu button images in the application.|  
|[CMFCToolBar::GetOrigButtons](#cmfctoolbar__getorigbuttons)|Retrieves the collection of non-customized buttons of the toolbar.|  
|[CMFCToolBar::GetOrigResetButtons](#cmfctoolbar__getorigresetbuttons)|Retrieves the collection of non-customized reset buttons of the toolbar.|  
|[CMFCToolBar::GetResourceID](#cmfctoolbar__getresourceid)|Retrieves the resource ID of the toolbar.|  
|[CMFCToolBar::GetRouteCommandsViaFrame](#cmfctoolbar__getroutecommandsviaframe)|Determines which object, the parent frame or the owner, sends commands to the toolbar.|  
|[CMFCToolBar::GetRowHeight](#cmfctoolbar__getrowheight)|Returns the height of toolbar buttons.|  
|[CMFCToolBar::GetShowTooltips](#cmfctoolbar__getshowtooltips)|Specifies whether tool tips are displayed for toolbar buttons.|  
|[CMFCToolBar::GetSiblingToolBar](#cmfctoolbar__getsiblingtoolbar)|Retrieves the sibling of the toolbar.|  
|[CMFCToolBar::GetUserImages](#cmfctoolbar__getuserimages)|Returns a pointer to the collection of user-defined toolbar button images in the application.|  
|[CMFCToolBar::HitTest](#cmfctoolbar__hittest)|Returns the index of the toolbar button that is located at the specified position.|  
|[CMFCToolBar::InsertButton](#cmfctoolbar__insertbutton)|Inserts a button into the toolbar.|  
|[CMFCToolBar::InsertSeparator](#cmfctoolbar__insertseparator)|Inserts a separator into the toolbar.|  
|[CMFCToolBar::InvalidateButton](#cmfctoolbar__invalidatebutton)|Invalidates the client area of the toolbar button that exists at the provided index.|  
|[CMFCToolBar::IsAddRemoveQuickCustomize](#cmfctoolbar__isaddremovequickcustomize)|Determines whether a user can add or remove toolbar buttons by using the **Customize** menu option.|  
|[CMFCToolBar::IsAltCustomizeMode](#cmfctoolbar__isaltcustomizemode)|Specifies whether *quick customization* is being used to drag a button.|  
|[CMFCToolBar::IsAutoGrayInactiveImages](#cmfctoolbar__isautograyinactiveimages)|Specifies whether the automatic generation of inactive (non-highlighted) button images is enabled.|  
|[CMFCToolBar::IsBasicCommand](#cmfctoolbar__isbasiccommand)|Determines whether a command is on the list of basic commands.|  
|[CMFCToolBar::IsButtonExtraSizeAvailable](#cmfctoolbar__isbuttonextrasizeavailable)|Determines whether the toolbar can display buttons that have extended borders.|  
|[CMFCToolBar::IsButtonHighlighted](#cmfctoolbar__isbuttonhighlighted)|Determines whether a button on the toolbar is highlighted.|  
|[CMFCToolBar::IsCommandPermitted](#cmfctoolbar__iscommandpermitted)|Determines whether a command is permitted.|  
|[CMFCToolBar::IsCommandRarelyUsed](#cmfctoolbar__iscommandrarelyused)|Determines whether a command is rarely used (see [SetCommandUsageOptions](#cmfctoolbar__setcommandusageoptions)).|  
|[CMFCToolBar::IsCustomizeMode](#cmfctoolbar__iscustomizemode)|Specifies whether the toolbar framework is in customization mode.|  
|[CMFCToolBar::IsDragButton](#cmfctoolbar__isdragbutton)|Determines whether a toolbar button is being dragged.|  
|[CMFCToolBar::IsExistCustomizeButton](#cmfctoolbar__isexistcustomizebutton)|Determines whether the toolbar contains the **Customize** button.|  
|[CMFCToolBar::IsFloating](#cmfctoolbar__isfloating)|Determines whether the toolbar is floating.|  
|[CMFCToolBar::IsLargeIcons](#cmfctoolbar__islargeicons)|Specifies whether toolbars in the application currently display large icons.|  
|[CMFCToolBar::IsLastCommandFromButton](#cmfctoolbar__islastcommandfrombutton)|Determines whether the most recently executed command was sent from the specified toolbar button.|  
|[CMFCToolBar::IsLocked](#cmfctoolbar__islocked)|Determines whether the toolbar is locked.|  
|[CMFCToolBar::IsOneRowWithSibling](#cmfctoolbar__isonerowwithsibling)|Determines whether the toolbar and its sibling toolbar are positioned on the same row.|  
|[CMFCToolBar::IsUserDefined](#cmfctoolbar__isuserdefined)|Specifies whether the toolbar is user-defined.|  
|[CMFCToolBar::LoadBitmap](#cmfctoolbar__loadbitmap)|Loads toolbar images from application resources.|  
|[CMFCToolBar::LoadBitmapEx](#cmfctoolbar__loadbitmapex)|Loads toolbar images from application resources. Includes large images.|  
|[CMFCToolBar::LoadParameters](#cmfctoolbar__loadparameters)|Loads global toolbar options from the Windows registry.|  
|[CMFCToolBar::LoadState](#cmfctoolbar__loadstate)|Loads the toolbar state information from the Windows registry. (Overrides [CPane::LoadState](../vs140/cpane-class.md#cpane__loadstate).)|  
|[CMFCToolBar::LoadToolBar](#cmfctoolbar__loadtoolbar)|Loads the toolbar from application resources.|  
|[CMFCToolBar::LoadToolBarEx](#cmfctoolbar__loadtoolbarex)|Loads the toolbar from application resources by using the <CodeContentPlaceHolder>179\</CodeContentPlaceHolder> helper class to enable the application to use large images.|  
|[CMFCToolBar::OnChangeHot](#cmfctoolbar__onchangehot)|Called by the framework when a user selects a button on the toolbar.|  
|[CMFCToolBar::OnFillBackground](#cmfctoolbar__onfillbackground)|Called by the framework from [CBasePane::DoPaint](../vs140/cbasepane-class.md#cbasepane__dopaint) to fill the toolbar background.|  
|[CMFCToolBar::OnReset](#cmfctoolbar__onreset)|Restores the toolbar to its original state.|  
|[CMFCToolBar::OnSetAccData](#cmfctoolbar__onsetaccdata)|(Overrides [CBasePane::OnSetAccData](../vs140/cbasepane-class.md#cbasepane__onsetaccdata).)|  
|[CMFCToolBar::OnSetDefaultButtonText](#cmfctoolbar__onsetdefaultbuttontext)|Restores the text of a toolbar button to its default state.|  
|<CodeContentPlaceHolder>180\</CodeContentPlaceHolder>|Used internally.|  
|[CMFCToolBar::RemoveAllButtons](#cmfctoolbar__removeallbuttons)|Removes all buttons from the toolbar.|  
|[CMFCToolBar::RemoveButton](#cmfctoolbar__removebutton)|Removes the button with the specified index from the toolbar.|  
|[CMFCToolBar::RemoveStateFromRegistry](#cmfctoolbar__removestatefromregistry)|Deletes the state information for the toolbar from the Windows registry.|  
|[CMFCToolBar::ReplaceButton](#cmfctoolbar__replacebutton)|Replaces a toolbar button with another toolbar button.|  
|[CMFCToolBar::ResetAll](#cmfctoolbar__resetall)|Restores all toolbars to their original states.|  
|[CMFCToolBar::ResetAllImages](#cmfctoolbar__resetallimages)|Clears all toolbar image collections in the application.|  
|[CMFCToolBar::RestoreOriginalstate](#cmfctoolbar__restoreoriginalstate)|Restores the original state of a toolbar.|  
|[CMFCToolBar::SaveState](#cmfctoolbar__savestate)|Saves the state information for the toolbar in the Windows registry. (Overrides [CPane::SaveState](../vs140/cpane-class.md#cpane__savestate).)|  
|<CodeContentPlaceHolder>181\</CodeContentPlaceHolder>|(Overrides <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>.)|  
|[CMFCToolBar::SetBasicCommands](#cmfctoolbar__setbasiccommands)|Sets the list of commands that are always displayed when a user opens a menu.|  
|[CMFCToolBar::SetButtonInfo](#cmfctoolbar__setbuttoninfo)|Sets the command ID, style, and image ID of a toolbar button.|  
|[CMFCToolBar::SetButtonStyle](#cmfctoolbar__setbuttonstyle)|Sets the style of the toolbar button at the given index.|  
|[CMFCToolBar::SetButtonText](#cmfctoolbar__setbuttontext)|Sets the text label of a toolbar button.|  
|[CMFCToolBar::SetButtons](#cmfctoolbar__setbuttons)|Sets the buttons for the toolbar.|  
|[CMFCToolBar::SetCommandUsageOptions](#cmfctoolbar__setcommandusageoptions)|Specifies when rarely used commands do not appear in the menu of the application.|  
|[CMFCToolBar::SetCustomizeMode](#cmfctoolbar__setcustomizemode)|Enables or disables customization mode for all toolbars in the application.|  
|[CMFCToolBar::SetGrayDisabledButtons](#cmfctoolbar__setgraydisabledbuttons)|Specifies whether the disabled buttons on the toolbar are dimmed or if disabled images are used for the disabled buttons.|  
|[CMFCToolBar::SetHeight](#cmfctoolbar__setheight)|Sets the height of the toolbar.|  
|[CMFCToolBar::SetHotBorder](#cmfctoolbar__sethotborder)|Specifies whether toolbar buttons are hot-tracked.|  
|[CMFCToolBar::SetHotTextColor](#cmfctoolbar__sethottextcolor)|Sets the text color for hot toolbar buttons.|  
|[CMFCToolBar::SetLargeIcons](#cmfctoolbar__setlargeicons)|Specifies whether toolbar buttons display large icons.|  
|[CMFCToolBar::SetLockedSizes](#cmfctoolbar__setlockedsizes)|Sets the sizes of locked buttons and locked images on the toolbar.|  
|[CMFCToolBar::SetMenuSizes](#cmfctoolbar__setmenusizes)|Sets the size of toolbar menu buttons and their images.|  
|[CMFCToolBar::SetNonPermittedCommands](#cmfctoolbar__setnonpermittedcommands)|Sets the list of commands that cannot be executed by the user.|  
|[CMFCToolBar::SetOneRowWithSibling](#cmfctoolbar__setonerowwithsibling)|Positions the toolbar and its sibling on the same row.|  
|[CMFCToolBar::SetPermament](#cmfctoolbar__setpermament)|Specifies whether a user can close the toolbar.|  
|[CMFCToolBar::SetRouteCommandsViaFrame](#cmfctoolbar__setroutecommandsviaframe)|Specifies whether the parent frame or the owner sends commands to the toolbar.|  
|[CMFCToolBar::SetShowTooltips](#cmfctoolbar__setshowtooltips)|Specifies whether the framework displays tool tips.|  
|[CMFCToolBar::SetSiblingToolBar](#cmfctoolbar__setsiblingtoolbar)|Specifies the sibling of the toolbar.|  
|[CMFCToolBar::SetSizes](#cmfctoolbar__setsizes)|Specifies the sizes of buttons and images on all toolbars.|  
|[CMFCToolBar::SetToolBarBtnText](#cmfctoolbar__settoolbarbtntext)|Specifies properties of a button on the toolbar.|  
|[CMFCToolBar::SetTwoRowsWithSibling](#cmfctoolbar__settworowswithsibling)|Positions the toolbar and its sibling on separate rows.|  
|[CMFCToolBar::SetUserImages](#cmfctoolbar__setuserimages)|Sets the collection of user-defined images in the application.|  
|[CMFCToolBar::StretchPane](#cmfctoolbar__stretchpane)|Stretches the toolbar vertically or horizontally. (Overrides [CBasePane::StretchPane](../vs140/cbasepane-class.md#cbasepane__stretchpane).)|  
|[CMFCToolBar::TranslateChar](#cmfctoolbar__translatechar)|Executes a button command if the specified key code corresponds to a valid keyboard shortcut.|  
|[CMFCToolBar::UpdateButton](#cmfctoolbar__updatebutton)|Updates the state of the specified button.|  
|[CMFCToolBar::WrapToolBar](#cmfctoolbar__wraptoolbar)|Repositions toolbar buttons within the given dimensions.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCToolBar::AllowShowOnList](#cmfctoolbar__allowshowonlist)|Determines whether the toolbar is displayed in the list on the **Toolbars** pane of the **Customize** dialog box.|  
|[CMFCToolBar::CalcMaxButtonHeight](#cmfctoolbar__calcmaxbuttonheight)|Calculates the maximum height of a button in the toolbar.|  
|[CMFCToolBar::DoPaint](#cmfctoolbar__dopaint)|Repaints a toolbar.|  
|[CMFCToolBar::DrawButton](#cmfctoolbar__drawbutton)|Repaints a toolbar button.|  
|[CMFCToolBar::DrawSeparator](#cmfctoolbar__drawseparator)|Repaints a separator on a toolbar.|  
|[CMFCToolBar::OnUserToolTip](#cmfctoolbar__onusertooltip)|Called by the framework when the tooltip for a button is about to be displayed.|  
  
### Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCToolBar::m_bDontScaleImages](#cmfctoolbar__m_bdontscaleimages)|Specifies whether to scale or not toolbar images in high DPI mode.|  
|[CMFCToolBar::m_dblLargeImageRatio](#cmfctoolbar__m_dbllargeimageratio)|Specifies the ratio between the dimension (height or width) of large images and the dimension of regular images.|  
  
## Remarks  
 To incorporate a <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> object into your application, follow these steps:  
  
1.  Add a <CodeContentPlaceHolder>184\</CodeContentPlaceHolder> object to the main frame window.  
  
2.  When you process the <CodeContentPlaceHolder>185\</CodeContentPlaceHolder> message for the main frame window, call either [CMFCToolBar::Create](#cmfctoolbar__create) or [CMFCToolBar::CreateEx](#cmfctoolbar__createex) to create the toolbar and specify its style.  
  
3.  Call [CBasePane::EnableDocking](../vs140/cbasepane-class.md#cbasepane__enabledocking) to specify the docking style.  
  
 To insert a special button, such as a combo box or drop-down toolbar, reserve a dummy button in the parent resource, and replace the dummy button at runtime by using [CMFCToolBar::ReplaceButton](#cmfctoolbar__replacebutton). For more information, see [How to Put Controls on Toolbars](../vs140/walkthrough--putting-controls-on-toolbars.md).  
  
 <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> is the base class for the MFC Library classes [CMFCMenuBar](../vs140/cmfcmenubar-class.md), [CMFCPopupMenuBar](../vs140/cmfcpopupmenubar-class.md), and [CMFCDropDownToolBar](../vs140/cmfcdropdowntoolbar-class.md).  
  
## Example  
 The following example demonstrates how to use various methods in the <CodeContentPlaceHolder>187\</CodeContentPlaceHolder> class. The example shows how to set the text of the window label of the tool bar, set the borders, set the style of the pane, and enable the **Add or Remove Buttons** button that appears on the end of the toolbar. This code snippet is part of the [IE Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_IEDemo#6](../vs140/codesnippet/CPP/cmfctoolbar-class_1.h)]  
[!code[NVC_MFC_IEDemo#8](../vs140/codesnippet/CPP/cmfctoolbar-class_2.cpp)]  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CBasePane](../vs140/cbasepane-class.md)  
  
 [CPane](../vs140/cpane-class.md)  
  
 [CMFCBaseToolBar](../vs140/cmfcbasetoolbar-class.md)  
  
 [CMFCToolBar](../vs140/cmfctoolbar-class.md)  
  
##  \<a name="cmfctoolbar__addbasiccommand">\</a>  CMFCToolBar::AddBasicCommand  
 Adds a menu command to the list of commands that are always displayed when a user opens a menu.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>  
 Specifies the command to add.  
  
### Remarks  
 A basic command is always displayed when the menu is opened. This method is meaningful when the user chooses to view recently used commands.  
  
 Use the [CMFCToolBar::SetBasicCommands](#cmfctoolbar__setbasiccommands) method to set the list of commands that are always displayed when a user opens a menu. Use the [GetBasicCommands](#cmfctoolbar__getbasiccommands) method to retrieve the list of basic commands that is used by your application.  
  
##  \<a name="cmfctoolbar__addcommandusage">\</a>  CMFCToolBar::AddCommandUsage  
 Increments by one the counter that is associated with the given command.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>  
 Specifies the command counter to increment.  
  
### Remarks  
 The framework calls this method when the user selects a menu item.  
  
 The framework uses command counters to display recently used menu items.  
  
 This method increments the command counter by using the [CMFCCmdUsageCount::AddCmd](../vs140/cmfccmdusagecount-class.md#cmfccmdusagecount__addcmd) method.  
  
##  \<a name="cmfctoolbar__addtoolbarforimagecollection">\</a>  CMFCToolBar::AddToolBarForImageCollection  
 Adds images from the user interface resources to the collection of images in the application.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>  
 Resource ID of a toolbar with images to load.  
  
 [in] <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>  
 Resource ID of a bitmap with toolbar images.  
  
 [in] <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>  
 Resource ID of a bitmap with "cold" toolbar images.  
  
 [in] <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>  
 Resource ID of a bitmap with menu images.  
  
 [in] <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>  
 Resource ID of a bitmap with disabled toolbar images.  
  
 [in] <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>  
 Resource ID of a bitmap with disabled menu images.  
  
### Return Value  
 <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> if the method succeeds; <CodeContentPlaceHolder>197\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>198\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>199\</CodeContentPlaceHolder> do not specify valid resources, or another error occurs.  
  
### Remarks  
 Call this method to load a bitmap with toolbar images and add it to the collection of toolbar images. This method creates a temporary toolbar object and calls [CMFCToolBar::LoadToolBar](#cmfctoolbar__loadtoolbar).  
  
##  \<a name="cmfctoolbar__adjustlayout">\</a>  CMFCToolBar::AdjustLayout  
 Recalculates the size and position of a toolbar.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 Call this method when the toolbar has been created to recalculate its size and position.  
  
 The framework calls this method every time that the layout of the toolbar must be changed. For example, the layout must change when the user moves another control bar, resizes an application window, or customizes the toolbar.  
  
 Override this method to provide your own dynamic layout in classes that you derive from [CMFCToolar](../vs140/cmfctoolbar-class.md).  
  
##  \<a name="cmfctoolbar__adjustsize">\</a>  CMFCToolBar::AdjustSize  
 Recalculates the size of the toolbar.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 This method makes sure that the toolbar fits in the bounds of the parent frame. This method does nothing if the toolbar has no parent frame.  
  
 The [CMFCToolBar::AdjustLayout](#cmfctoolbar__adjustlayout) method calls this method to recalculate the size if the parent of the toolbar is not a <CodeContentPlaceHolder>200\</CodeContentPlaceHolder> object.  
  
##  \<a name="cmfctoolbar__allowchangetextlabels">\</a>  CMFCToolBar::AllowChangeTextLabels  
 Specifies whether text labels can be shown under images on the toolbar buttons.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>201\</CodeContentPlaceHolder> if it is allowed to display text labels below images; otherwise <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method is called by the customization dialog box to determine whether to enable a **Show text labels** check-box on the **Toolbars** page for the selected toolbar.  
  
 The default implementation returns <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>.  
  
 Override this method in an object derived from [CMFCToolBar](../vs140/cmfctoolbar-class.md) and return <CodeContentPlaceHolder>204\</CodeContentPlaceHolder> when you do not want the user to decide whether text labels are displayed on toolbar buttons under the images.  
  
##  \<a name="cmfctoolbar__allowshowonlist">\</a>  CMFCToolBar::AllowShowOnList  
 Determines whether the toolbar is displayed in the list of toolbars on the **Toolbars** pane of the **Customize** dialog box.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>205\</CodeContentPlaceHolder> if the toolbar object can be displayed in the list box on the toolbar customization page; otherwise <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method is called by the framework to determine whether the list on the toolbar customization page should include a particular object derived from [CMFCToolBar](../vs140/cmfctoolbar-class.md).  
  
 The default implementation always returns <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>. Override this method when you do not want a toolbar to appear in the toolbars list in the customization dialog box.  
  
##  \<a name="cmfctoolbar__aretextlabels">\</a>  CMFCToolBar::AreTextLabels  
 Specifies whether text labels under images are currently displayed on the toolbar buttons.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>208\</CodeContentPlaceHolder> if the toolbar buttons display text labels below images; otherwise <CodeContentPlaceHolder>209\</CodeContentPlaceHolder>.  
  
### Remarks  
 Use [EnableTextLabels](#cmfctoolbar__enabletextlabels) to specify whether the text is displayed. The default value is <CodeContentPlaceHolder>210\</CodeContentPlaceHolder>. Call [CMFCToolBar::AllowChangeTextLabels](#cmfctoolbar__allowchangetextlabels) to specify whether the user can change this setting in the customization dialog box.  
  
##  \<a name="cmfctoolbar__autograyinactiveimages">\</a>  CMFCToolBar::AutoGrayInactiveImages  
 Enable or disables the automatic generation of inactive button images.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>211\</CodeContentPlaceHolder>  
 A Boolean value that specifies whether to dim inactive images. If this parameter is <CodeContentPlaceHolder>212\</CodeContentPlaceHolder>, inactive images are dimmed. Otherwise, inactive images are not dimmed.  
  
 [in] <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>  
 Specifies the luminance percentage for inactive images. If <CodeContentPlaceHolder>214\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>, this value is ignored.  
  
 [in] <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>  
 A Boolean value that specifies whether to redraw all toolbars in the application. If this parameter is <CodeContentPlaceHolder>217\</CodeContentPlaceHolder>, this method redraws all toolbars.  
  
### Remarks  
 If <CodeContentPlaceHolder>218\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>219\</CodeContentPlaceHolder>, the framework uses <CodeContentPlaceHolder>220\</CodeContentPlaceHolder> to generate inactive images from the regular images. Otherwise, you must provide the set of inactive images by using the [CMFCToolBar::GetColdImages](#cmfctoolbar__getcoldimages) method. By default, this option is disabled.  
  
 For more information about the <CodeContentPlaceHolder>221\</CodeContentPlaceHolder> parameter, see [CMFCToolBarImages::GrayImages](../vs140/cmfctoolbarimages-class.md#cmfctoolbarimages__grayimages).  
  
##  \<a name="cmfctoolbar__buttontoindex">\</a>  CMFCToolBar::ButtonToIndex  
 Returns the index of a specified [CMFCToolBarButton](../vs140/cmfctoolbarbutton-class.md) object in this toolbar.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>222\</CodeContentPlaceHolder>  
 A pointer to the toolbar button object.  
  
### Return Value  
 Index of <CodeContentPlaceHolder>223\</CodeContentPlaceHolder> in the internal list of toolbar buttons; or -1 if the specified button is not on this toolbar.  
  
##  \<a name="cmfctoolbar__calcfixedlayout">\</a>  CMFCToolBar::CalcFixedLayout  
 Calculates the horizontal size of the toolbar.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>224\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>225\</CodeContentPlaceHolder> to stretch the toolbar to the size of the parent frame.  
  
 [in] <CodeContentPlaceHolder>226\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>227\</CodeContentPlaceHolder> to orient the toolbar horizontally; <CodeContentPlaceHolder>228\</CodeContentPlaceHolder> to orient the toolbar vertically.  
  
### Return Value  
 A <CodeContentPlaceHolder>229\</CodeContentPlaceHolder> object that specifies the size of the toolbar.  
  
### Remarks  
 This method calculates the size of the toolbar by using the <CodeContentPlaceHolder>230\</CodeContentPlaceHolder> method. It passes the <CodeContentPlaceHolder>231\</CodeContentPlaceHolder> flag for the <CodeContentPlaceHolder>232\</CodeContentPlaceHolder> parameter if <CodeContentPlaceHolder>233\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>234\</CodeContentPlaceHolder>. It passes the <CodeContentPlaceHolder>235\</CodeContentPlaceHolder> flag if <CodeContentPlaceHolder>236\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>237\</CodeContentPlaceHolder>.  
  
 See the VisualStudioDemo sample for an example that uses this method.  
  
##  \<a name="cmfctoolbar__calcmaxbuttonheight">\</a>  CMFCToolBar::CalcMaxButtonHeight  
 Calculates the maximum height of buttons in the toolbar.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 The maximum height of buttons.  
  
### Remarks  
 This method calculates the maximum height among all toolbar buttons on the toolbar. The height may vary depending on factors such as the current toolbar docking state.  
  
 Override this method in a class derived from [CMFCToolBar](../vs140/cmfctoolbar-class.md) to provide your own height calculation.  
  
##  \<a name="cmfctoolbar__calcsize">\</a>  CMFCToolBar::CalcSize  
 Called by the framework as part of the layout calculation process.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>238\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>239\</CodeContentPlaceHolder> to specify that the toolbar is docked vertically; <CodeContentPlaceHolder>240\</CodeContentPlaceHolder> to specify that the toolbar is docked horizontally.  
  
### Return Value  
 A <CodeContentPlaceHolder>241\</CodeContentPlaceHolder> object that specifies the overall size of the buttons on the toolbar.  
  
### Remarks  
 This method considers the attributes that affect the size of each button, such as the area of the text label and the border size.  
  
 If the toolbar contains no buttons, this method returns the reserved size of a single button by using the [CMFCToolBar::GetButtonSize](#cmfctoolbar__getbuttonsize) method.  
  
##  \<a name="cmfctoolbar__canbeclosed">\</a>  CMFCToolBar::CanBeClosed  
 Specifies whether a user can close the toolbar.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>242\</CodeContentPlaceHolder> if the toolbar can be closed by the user; otherwise <CodeContentPlaceHolder>243\</CodeContentPlaceHolder>.  
  
### Remarks  
 The framework calls this method to determine whether the user can close a toolbar. If the method returns <CodeContentPlaceHolder>244\</CodeContentPlaceHolder>, the framework enables the SC_CLOSE command in the system menu of the toolbar and the user can close the toolbar by using a check box in the list of toolbars in the customization dialog box.  
  
 The default implementation returns <CodeContentPlaceHolder>245\</CodeContentPlaceHolder>. Override this method in a class derived from [CMFCToolBar](../vs140/cmfctoolbar-class.md) to make toolbar objects that cannot be closed by the user.  
  
##  \<a name="cmfctoolbar__canberestored">\</a>  CMFCToolBar::CanBeRestored  
 Determines whether the system can restore a toolbar to its original state after customization.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>246\</CodeContentPlaceHolder> if the toolbar can be restored from the application resources; otherwise <CodeContentPlaceHolder>247\</CodeContentPlaceHolder>.  
  
### Remarks  
 The framework calls this method to determine whether a toolbar can be returned to its original state after customization. The original state is loaded from the application resources.  
  
 If <CodeContentPlaceHolder>248\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>249\</CodeContentPlaceHolder>, the **Toolbars** page of the customization dialog box enables the **Reset** button for the selected toolbar.  
  
 The default implementation returns <CodeContentPlaceHolder>250\</CodeContentPlaceHolder> if the original resource ID of the toolbar when it was loaded is non-zero. Usually, only user-defined toolbars cannot be restored.  
  
 You can override the <CodeContentPlaceHolder>251\</CodeContentPlaceHolder> method to customize this behavior in derived classes.  
  
##  \<a name="cmfctoolbar__canfocus">\</a>  CMFCToolBar::CanFocus  
 Specifies whether the pane can receive focus.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 This method returns <CodeContentPlaceHolder>252\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method overrides the base class implementation, [CBasePane::CanFocus](../vs140/cbasepane-class.md#cbasepane__canfocus), because toolbar objects cannot receive focus.  
  
##  \<a name="cmfctoolbar__canhandlesiblings">\</a>  CMFCToolBar::CanHandleSiblings  
 Determines whether the toolbar and its sibling are positioned on the same pane.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>253\</CodeContentPlaceHolder> if the toolbar has a sibling and the toolbar and its sibling are positioned on the same pane; otherwise <CodeContentPlaceHolder>254\</CodeContentPlaceHolder>.  
  
### Remarks  
 The internal CMFCCustomizeButton::CreatePopupMenu method calls this method to determine how to show the **Customize** pop-up menu. If this method returns <CodeContentPlaceHolder>255\</CodeContentPlaceHolder>, the framework displays the **Show Buttons on One Row** or **Show Buttons on Two Rows** buttons.  
  
 You typically do not have to use this method. To enable the **Customize** button that appears on the toolbar, call the [CMFCToolBar::EnableCustomizeButton](#cmfctoolbar__enablecustomizebutton) method. To enable the **Show Buttons on One Row** or **Show Buttons on Two Rows** buttons, call [CMFCToolBar::SetSiblingToolBar](#cmfctoolbar__setsiblingtoolbar).  
  
##  \<a name="cmfctoolbar__cleanupimages">\</a>  CMFCToolBar::CleanUpImages  
 Frees the system resources allocated for toolbar images.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Remarks  
 The framework calls this method when an application shuts down.  
  
##  \<a name="cmfctoolbar__cleanuplockedimages">\</a>  CMFCToolBar::CleanUpLockedImages  
 Frees the system resources allocated for locked toolbar images.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Remarks  
 Call this method when the visual style of your application changes. See the VisualStudioDemo sample for an example that uses this method.  
  
##  \<a name="cmfctoolbar__commandtoindex">\</a>  CMFCToolBar::CommandToIndex  
 Returns the index of the button in the toolbar with a specified command ID.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>256\</CodeContentPlaceHolder>  
 Specifies the command ID.  
  
 [in] <CodeContentPlaceHolder>257\</CodeContentPlaceHolder>  
 Specifies the initial index to start from.  
  
### Return Value  
 Zero-based index of the toolbar button if the method was successful; -1 if there is no button with the specified ID.  
  
### Remarks  
 A [CMFCToolBar](../vs140/cmfctoolbar-class.md) object maintains an internal list of the buttons on the toolbar. Call this function to retrieve the index of a button in the list given the command ID of the button.  
  
 If <CodeContentPlaceHolder>258\</CodeContentPlaceHolder> is greater than 0, this method ignores any button on the toolbar that has an index less than <CodeContentPlaceHolder>259\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctoolbar__create">\</a>  CMFCToolBar::Create  
 Creates a <CodeContentPlaceHolder>260\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>261\</CodeContentPlaceHolder>  
 A pointer to the parent window of the toolbar.  
  
 [in] <CodeContentPlaceHolder>262\</CodeContentPlaceHolder>  
 The toolbar style. See                                 [Toolbar Control and Button Styles](http://msdn.microsoft.com/library/windows/desktop/bb760439) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for the list of styles.  
  
 [in] <CodeContentPlaceHolder>263\</CodeContentPlaceHolder>  
 The ID of the child window of the toolbar.  
  
### Return Value  
 <CodeContentPlaceHolder>264\</CodeContentPlaceHolder> if this method succeeds; otherwise <CodeContentPlaceHolder>265\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method creates a control bar and attaches it to the toolbar. It creates the control bar with the <CodeContentPlaceHolder>266\</CodeContentPlaceHolder> style. Call [CreateEx](#cmfctoolbar__createex) if you want a different control bar style.  
  
##  \<a name="cmfctoolbar__createex">\</a>  CMFCToolBar::CreateEx  
 Creates a <CodeContentPlaceHolder>267\</CodeContentPlaceHolder> object that uses additional style options, such as large icons.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>268\</CodeContentPlaceHolder>  
 A pointer to the parent window of the toolbar.  
  
 [in] <CodeContentPlaceHolder>269\</CodeContentPlaceHolder>  
 Additional styles for creating the embedded control bar object.  
  
 [in] <CodeContentPlaceHolder>270\</CodeContentPlaceHolder>  
 The toolbar style. See                                 [Toolbar Control and Button Styles](http://msdn.microsoft.com/library/windows/desktop/bb760439) for a list of appropriate styles.  
  
 [in] <CodeContentPlaceHolder>271\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>272\</CodeContentPlaceHolder> object that specifies the widths of the toolbar window borders.  
  
 [in] <CodeContentPlaceHolder>273\</CodeContentPlaceHolder>  
 The ID of the child window of the toolbar.  
  
### Return Value  
 Nonzero if this method succeeds; otherwise 0.  
  
### Remarks  
 This method creates a control bar and attaches it to the toolbar.  
  
 Call this method instead of [Create](#cmfctoolbar__create) when you want to provide specific styles. For example, set <CodeContentPlaceHolder>274\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>275\</CodeContentPlaceHolder> to create a toolbar that resembles the toolbars that are used by Internet Explorer 4.  
  
### Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>276\</CodeContentPlaceHolder> method of the <CodeContentPlaceHolder>277\</CodeContentPlaceHolder> class. This code snippet is part of the [IE Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_IEDemo#6](../vs140/codesnippet/CPP/cmfctoolbar-class_1.h)]  
[!code[NVC_MFC_IEDemo#7](../vs140/codesnippet/CPP/cmfctoolbar-class_3.cpp)]  
  
##  \<a name="cmfctoolbar__deactivate">\</a>  CMFCToolBar::Deactivate  
 Deactivates the toolbar.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Remarks  
 This method deactivates the toolbar by removing the focus from the highlighted toolbar button. The framework calls this method when the toolbar loses focus or is destroyed.  
  
##  \<a name="cmfctoolbar__dopaint">\</a>  CMFCToolBar::DoPaint  
 Repaints a toolbar.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>278\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
### Remarks  
 This method is called by the framework when a part of the toolbar must be repainted.  
  
 Override this method to customize the appearance of an object derived from [CMFCToolBar](../vs140/cmfctoolbar-class.md).  
  
##  \<a name="cmfctoolbar__drawbutton">\</a>  CMFCToolBar::DrawButton  
 Repaints a toolbar button.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>279\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>280\</CodeContentPlaceHolder>  
 A pointer to a button to draw.  
  
 [in] <CodeContentPlaceHolder>281\</CodeContentPlaceHolder>  
 A pointer to the toolbar images.  
  
 [in] <CodeContentPlaceHolder>282\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>283\</CodeContentPlaceHolder> if the button is highlighted; otherwise <CodeContentPlaceHolder>284\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>285\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>286\</CodeContentPlaceHolder> if disabled buttons are dimmed; otherwise <CodeContentPlaceHolder>287\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>288\</CodeContentPlaceHolder> if the button was repainted; <CodeContentPlaceHolder>289\</CodeContentPlaceHolder> if the button is hidden.  
  
### Remarks  
 The [DoPaint](#cmfctoolbar__drawbutton) method calls this method when a toolbar button must be repainted.  
  
 Override this method if you want to customize the appearance of buttons on your toolbar.  
  
##  \<a name="cmfctoolbar__drawseparator">\</a>  CMFCToolBar::DrawSeparator  
 Repaints a separator on a toolbar.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>290\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>291\</CodeContentPlaceHolder>  
 The bounding rectangle of the location where the separator is drawn, in pixels.  
  
 [in] <CodeContentPlaceHolder>292\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>293\</CodeContentPlaceHolder> if the separator is horizontal, <CodeContentPlaceHolder>294\</CodeContentPlaceHolder> if the separator is vertical.  
  
### Remarks  
 [DoPaint](#cmfctoolbar__dopaint) calls this method for each [CMFCToolbarButton](#cmfctoolbar__drawseparator) object that has the <CodeContentPlaceHolder>295\</CodeContentPlaceHolder> style, instead of calling [CMFCToolBar::DrawButton](#cmfctoolbar__drawbutton) for those buttons.  
  
 Override this method in a class derived from [CMFCToolBar](../vs140/cmfctoolbar-class.md) to customize the appearance of separators on the toolbar. The default implementation calls [CMFCVisualManager::OnDrawSeparator](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondrawseparator) to draw a separator whose appearance is determined by the current visual manager.  
  
##  \<a name="cmfctoolbar__enablecustomizebutton">\</a>  CMFCToolBar::EnableCustomizeButton  
 Enables or disables the Customize button that appears on the toolbar.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>296\</CodeContentPlaceHolder>  
 Enables or disables the Customize button.  
  
 [in] <CodeContentPlaceHolder>297\</CodeContentPlaceHolder>  
 The command ID of the Customize button.  
  
 [in] <CodeContentPlaceHolder>298\</CodeContentPlaceHolder>  
 The text label of the Customize button.  
  
 [in] <CodeContentPlaceHolder>299\</CodeContentPlaceHolder>  
 The resource string ID of the Customize button label.  
  
 [in] <CodeContentPlaceHolder>300\</CodeContentPlaceHolder>  
 Enables or disables the **Add or Remove Buttons** option on the menu that drops down from the button.  
  
### Remarks  
 If <CodeContentPlaceHolder>301\</CodeContentPlaceHolder> is -1, the framework displays the Customize button when multiple toolbar buttons do not fit in the toolbar area. The button displays a double left-pointing arrow, or chevron, which indicates that there are more buttons.  
  
 If <CodeContentPlaceHolder>302\</CodeContentPlaceHolder> specifies a valid command ID, and <CodeContentPlaceHolder>303\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>304\</CodeContentPlaceHolder>, the Customize button is always displayed. The button has a small down arrow and opens a menu that contains a command. This command uses the text label specified by <CodeContentPlaceHolder>305\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>306\</CodeContentPlaceHolder> is also <CodeContentPlaceHolder>307\</CodeContentPlaceHolder>, the menu displays the **Add or Remove Buttons** option.  
  
 The framework dynamically adds to the menu any buttons that do not fit in the toolbar area before the item that is specified by <CodeContentPlaceHolder>308\</CodeContentPlaceHolder>. The chevron is displayed next to the down arrow.  
  
##  \<a name="cmfctoolbar__enabledocking">\</a>  CMFCToolBar::EnableDocking  
 Enables docking of the pane to the main frame.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>309\</CodeContentPlaceHolder>  
 Specifies the docking alignment to enable.  
  
### Remarks  
 This method extends the base class implementation, [CBasePane::EnableDocking](../vs140/cbasepane-class.md#cbasepane__enabledocking), by setting the <CodeContentPlaceHolder>310\</CodeContentPlaceHolder> data member to <CodeContentPlaceHolder>311\</CodeContentPlaceHolder>. This method then passes <CodeContentPlaceHolder>312\</CodeContentPlaceHolder> to the base class implementation.  
  
##  \<a name="cmfctoolbar__enablelargeicons">\</a>  CMFCToolBar::EnableLargeIcons  
 Enables or disables large icons on toolbar buttons.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>313\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>314\</CodeContentPlaceHolder> to enable large icons, <CodeContentPlaceHolder>315\</CodeContentPlaceHolder> to disable large icons.  
  
### Remarks  
 By default, large icons are enabled.  
  
##  \<a name="cmfctoolbar__enablequickcustomization">\</a>  CMFCToolBar::EnableQuickCustomization  
 Enables or disables the quick customization of toolbars so that the user can press the **Alt** key and drag a button to a new location.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>316\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>317\</CodeContentPlaceHolder> to enable quick customization, <CodeContentPlaceHolder>318\</CodeContentPlaceHolder> to disable quick customization.  
  
##  \<a name="cmfctoolbar__enablereflections">\</a>  CMFCToolBar::EnableReflections  
 Enables or disables command reflection.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>319\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>320\</CodeContentPlaceHolder> to enable command reflection; <CodeContentPlaceHolder>321\</CodeContentPlaceHolder> to disable command reflection.  
  
### Remarks  
 Call this method to enable command reflection for toolbar buttons that contain embedded controls, such as combo boxes.  
  
 For more information about command reflection, see [TN062: Message Reflection for Windows Controls](../vs140/tn062--message-reflection-for-windows-controls.md).  
  
##  \<a name="cmfctoolbar__enabletextlabels">\</a>  CMFCToolBar::EnableTextLabels  
 Enables or disables text labels under toolbar button images.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>322\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>323\</CodeContentPlaceHolder> if text labels appear under toolbar button images; otherwise <CodeContentPlaceHolder>324\</CodeContentPlaceHolder>.  
  
### Remarks  
 If text labels are enabled, all buttons on the toolbar are enlarged to provide space for the labels to be displayed under the images. The customization dialog box has a **Show text label** check-box on the **Toolbars** page. When the user selects a toolbar and checks this option, the framework calls <CodeContentPlaceHolder>325\</CodeContentPlaceHolder> for the selected toolbar. You can disable the check-box for an object derived from [CMFCToolBar](../vs140/cmfctoolbar-class.md) by returning <CodeContentPlaceHolder>326\</CodeContentPlaceHolder> from [CMFCToolBar::AllowChangeTextLabels](#cmfctoolbar__allowchangetextlabels) .  
  
##  \<a name="cmfctoolbar__fromhandlepermanent">\</a>  CMFCToolBar::FromHandlePermanent  
 Retrieves a pointer to the <CodeContentPlaceHolder>327\</CodeContentPlaceHolder> object that contains the given window handle.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>328\</CodeContentPlaceHolder>  
 The window handle to look for.  
  
### Return Value  
 A pointer to the <CodeContentPlaceHolder>329\</CodeContentPlaceHolder> object that contains the given window handle, or <CodeContentPlaceHolder>330\</CodeContentPlaceHolder> if no corresponding <CodeContentPlaceHolder>331\</CodeContentPlaceHolder> object exists.  
  
### Remarks  
 This shared method examines each toolbar in the application for the <CodeContentPlaceHolder>332\</CodeContentPlaceHolder> object that contains the given window handle.  
  
##  \<a name="cmfctoolbar__getallbuttons">\</a>  CMFCToolBar::GetAllButtons  
 Returns a read-only list of buttons in a toolbar.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Return Value  
 A constant reference to a [CObList](../vs140/coblist-class.md) object, which contains a collection of [CMFCToolbarButton](../vs140/cmfctoolbarbutton-class.md) objects.  
  
##  \<a name="cmfctoolbar__getalltoolbars">\</a>  CMFCToolBar::GetAllToolbars  
 Returns a read-only list of all toolbars in the application.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Return Value  
 A const reference to a [CObList](../vs140/coblist-class.md) object that contains a collection of [CMFCToolbar](../vs140/cmfctoolbar-class.md) objects.  
  
##  \<a name="cmfctoolbar__getbasiccommands">\</a>  CMFCToolBar::GetBasicCommands  
 Returns a read-only list of the basic commands defined in the application.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Return Value  
 A const reference to a [CList](../vs140/clist-class.md) object that contains a collection of basic commands.  
  
### Remarks  
 Add basic commands by calling [AddBasicCommand](#cmfctoolbar__addbasiccommand) or [SetBasicCommand](#cmfctoolbar__setbasiccommands).  
  
##  \<a name="cmfctoolbar__getbutton">\</a>  CMFCToolBar::GetButton  
 Returns a pointer to the [CMFCToolBarButton](../vs140/cmfctoolbarbutton-class.md) object at a specified index.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>333\</CodeContentPlaceHolder>  
 Specifies the index of the button to return.  
  
### Return Value  
 A pointer to the toolbar button if it exists; or <CodeContentPlaceHolder>334\</CodeContentPlaceHolder> if there is no such button.  
  
##  \<a name="cmfctoolbar__getbuttoninfo">\</a>  CMFCToolBar::GetButtonInfo  
 Returns the command ID, style, and image index of the button at a specified index.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>335\</CodeContentPlaceHolder>  
 Specifies the index of the button in the list of buttons on the toolbar.  
  
 [out] <CodeContentPlaceHolder>336\</CodeContentPlaceHolder>  
 The command ID of a button.  
  
 [out] <CodeContentPlaceHolder>337\</CodeContentPlaceHolder>  
 The style of the button.  
  
 [out] <CodeContentPlaceHolder>338\</CodeContentPlaceHolder>  
 The index of the image for the button.  
  
### Remarks  
 The <CodeContentPlaceHolder>339\</CodeContentPlaceHolder> method finds a toolbar button at the specified index and retrieves the command ID, style and image index of the button.  
  
 If the button at the specified index does not exist, the framework sets <CodeContentPlaceHolder>340\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>341\</CodeContentPlaceHolder> to 0, and <CodeContentPlaceHolder>342\</CodeContentPlaceHolder> to -1 when the method returns.  
  
##  \<a name="cmfctoolbar__getbuttonsize">\</a>  CMFCToolBar::GetButtonSize  
 Returns the dimensions of each button on the toolbar.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Return Value  
 A [CSize](../vs140/csize-class.md) object that specifies the dimensions of each button on the toolbar.  
  
### Remarks  
 Call [SetSizes](#cmfctoolbar__setsizes) or [SetLockedSizes](#cmfctoolbar__setlockedsizes) to set the dimensions of each button on the toolbar.  
  
##  \<a name="cmfctoolbar__getbuttonstyle">\</a>  CMFCToolBar::GetButtonStyle  
 Returns the current style of the toolbar button that is located at the specified index.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>343\</CodeContentPlaceHolder>  
 Specifies the index of a toolbar button.  
  
### Return Value  
 A value that specifies the style of the toolbar button. . See [ToolBar Control Styles](../vs140/toolbar-control-styles.md) for a list of possible styles.  
  
### Remarks  
 Call [SetButtonStyle](#cmfctoolbar__setbuttonstyle) to set the style of a toolbar button  
  
##  \<a name="cmfctoolbar__getbuttontext">\</a>  CMFCToolBar::GetButtonText  
 Returns the text label of a button that has a specified index.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>344\</CodeContentPlaceHolder>  
 The index of a toolbar button.  
  
 [out] <CodeContentPlaceHolder>345\</CodeContentPlaceHolder>  
 The label text of the toolbar button.  
  
### Return Value  
 The label text of the toolbar button.  
  
### Remarks  
 Call [CMFCToolBar::SetButtonText](#cmfctoolbar__setbuttontext) or [CMFCToolBar::SetToolBarBtnText](#cmfctoolbar__settoolbarbtntext) to set the text label.  
  
##  \<a name="cmfctoolbar__getcoldimages">\</a>  CMFCToolBar::GetColdImages  
 Returns a pointer to the collection of cold toolbar button images in the application.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the collection of cold toolbar button images.  
  
### Remarks  
 Cold images are the images that are used when the user is not interacting with the toolbar buttons. Call [LoadBitmapEx](#cmfctoolbar__loadbitmapex) or [LoadBitmap](#cmfctoolbar__loadbitmap) to load the cold images.  
  
##  \<a name="cmfctoolbar__getcolumnwidth">\</a>  CMFCToolBar::GetColumnWidth  
 Returns the width of the toolbar buttons.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Return Value  
 A value that specifies the width of toolbar buttons.  
  
### Remarks  
 The framework calls this method to calculate toolbar layout. Override this method in a derived class to specify a different column width for your toolbar.  
  
##  \<a name="cmfctoolbar__getcommandbuttons">\</a>  CMFCToolBar::GetCommandButtons  
 Returns a list of buttons that have a specified command ID from all toolbars in the application.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>346\</CodeContentPlaceHolder>  
 The command ID of the buttons.  
  
 [out] <CodeContentPlaceHolder>347\</CodeContentPlaceHolder>  
 A reference to a [CObList](../vs140/coblist-class.md) object that receives the list of toolbar buttons.  
  
### Return Value  
 The number of buttons that have the specified command ID.  
  
##  \<a name="cmfctoolbar__getcount">\</a>  CMFCToolBar::GetCount  
 Returns the number of buttons and separators on the toolbar.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Return Value  
 The number of buttons and separators on the toolbar.  
  
##  \<a name="cmfctoolbar__getcustomizebutton">\</a>  CMFCToolBar::GetCustomizeButton  
 Retrieves a pointer to the <CodeContentPlaceHolder>348\</CodeContentPlaceHolder> object that is associated with the toolbar.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the <CodeContentPlaceHolder>349\</CodeContentPlaceHolder> object that is associated with the toolbar.  
  
### Remarks  
 This method retrieves the **Customize** button that appears at the end of the toolbar. Use the [CMFCToolBar::EnableCustomizeButton](#cmfctoolbar__enablecustomizebutton) method to add the **Customize** button to your toolbar.  
  
 You can call the [CMFCToolBar::IsExistCustomizeButton](#cmfctoolbar__isexistcustomizebutton) method to determine whether the toolbar contains a valid <CodeContentPlaceHolder>350\</CodeContentPlaceHolder> object.  
  
##  \<a name="cmfctoolbar__getdefaultimage">\</a>  CMFCToolBar::GetDefaultImage  
 Returns the index of the default image for a toolbar button with a specified command ID.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>351\</CodeContentPlaceHolder>  
 Specifies the command ID of the button.  
  
### Return Value  
 The index of the toolbar image in the shared list of images.  
  
### Remarks  
 Use this shared method to retrieve the index of the default image for a toolbar button with the specified command ID. The return value is an index into the shared collection of toolbar button images for all toolbars in the application. Call the [GetImages](#cmfctoolbar__getimages) method to obtain a pointer to this collection.  
  
##  \<a name="cmfctoolbar__getdisabledimages">\</a>  CMFCToolBar::GetDisabledImages  
 Returns a pointer to the collection of images that are used for disabled toolbar buttons in the application.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the collection of disabled toolbar button images.  
  
### Remarks  
 Load the disabled toolbar button images by using the [LoadBitmapEx](../vs140/cmfctoolbareditboxbutton-class.md) and [LoadBitmap](#cmfctoolbar__loadbitmap) methods.  
  
##  \<a name="cmfctoolbar__getdisabledmenuimages">\</a>  CMFCToolBar::GetDisabledMenuImages  
 Returns a pointer to the collection of images that are used for disabled menu buttons in the application.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the collection of disabled menu images.  
  
### Remarks  
 Load the disabled images by using the [LoadBitmapEx](../vs140/cmfctoolbareditboxbutton-class.md) method.  
  
##  \<a name="cmfctoolbar__getdroppeddownmenu">\</a>  CMFCToolBar::GetDroppedDownMenu  
 Retrieves a pointer to the menu button object that is currently displaying its sub-menu.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>352\</CodeContentPlaceHolder>  
 Receives the index of the button in the collection of toolbar buttons.  
  
### Return Value  
 A pointer to the menu button object that is displaying its sub-menu or <CodeContentPlaceHolder>353\</CodeContentPlaceHolder> if no menu is displaying its sub-menu.  
  
### Remarks  
 If this method returns a non- <CodeContentPlaceHolder>354\</CodeContentPlaceHolder> value and <CodeContentPlaceHolder>355\</CodeContentPlaceHolder> is not <CodeContentPlaceHolder>356\</CodeContentPlaceHolder>, the value pointed to by <CodeContentPlaceHolder>357\</CodeContentPlaceHolder> is set to the index of the menu button in the collection of toolbar buttons.  
  
##  \<a name="cmfctoolbar__getgraydisabledbuttons">\</a>  CMFCToolBar::GetGrayDisabledButtons  
 Specifies whether the images of disabled buttons are dimmed versions of the regular button images, or taken from the collection of disabled button images.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>358\</CodeContentPlaceHolder> to dim the images of disabled buttons; <CodeContentPlaceHolder>359\</CodeContentPlaceHolder>to obtain images from the collection of disabled images.  
  
### Remarks  
 Use [SetGrayDisabledButtons](#cmfctoolbar__setgraydisabledbuttons) to switch between dimmed images and the images from the collection of disabled images.  
  
##  \<a name="cmfctoolbar__gethighlightedbutton">\</a>  CMFCToolBar::GetHighlightedButton  
 Returns a pointer to the toolbar button that is currently highlighted.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to a toolbar button object; or <CodeContentPlaceHolder>360\</CodeContentPlaceHolder> if no button is highlighted.  
  
### Remarks  
 A toolbar button is highlighted if it has keyboard focus. A toolbar button is also highlighted if the toolbar buttons are hot-tracked in this application (for more information, see [CMFCToolBar::GetHotBorder](#cmfctoolbar__gethotborder) and [CMFCToolBar::SetHotBorder](#cmfctoolbar__sethotborder)) and the mouse is pointing at it when no toolbar button or menu item has keyboard focus.  
  
##  \<a name="cmfctoolbar__gethotborder">\</a>  CMFCToolBar::GetHotBorder  
 Determines whether the toolbar buttons are *hot-tracked*. If a button is hot-tracked, it is highlighted when the mouse moves across it.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>361\</CodeContentPlaceHolder> if the toolbar buttons are hot-tracked; otherwise, <CodeContentPlaceHolder>362\</CodeContentPlaceHolder>.  
  
### Remarks  
 By default, toolbar buttons are hot-tracked.  
  
##  \<a name="cmfctoolbar__gethottextcolor">\</a>  CMFCToolBar::GetHotTextColor  
 Returns the text color of the highlighted toolbar buttons.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Return Value  
 A                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value that represent the current highlighted text color.  
  
### Remarks  
 Call [SetHotTextColor](#cmfctoolbar__sethottextcolor) to set a new text color for highlighted toolbar buttons.  
  
##  \<a name="cmfctoolbar__gethwndlastfocus">\</a>  CMFCToolBar::GetHwndLastFocus  
 Returns a handle to the window that had the input focus just before the toolbar did.  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Return Value  
 A handle to window that is not derived from [CMFCBaseToolBar](../vs140/cmfcbasetoolbar-class.md), which previously had the input focus; or <CodeContentPlaceHolder>363\</CodeContentPlaceHolder> if there is no such window.  
  
### Remarks  
 When a [CMFCToolBar](../vs140/cmfctoolbar-class.md) control receives the input focus, it stores a handle to the window that lost the focus so that it can restore it later.  
  
##  \<a name="cmfctoolbar__getignoresettext">\</a>  CMFCToolBar::GetIgnoreSetText  
 Specifies whether calls to set button labels are ignored.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>364\</CodeContentPlaceHolder> if calls to set button labels are ignored; otherwise, <CodeContentPlaceHolder>365\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfctoolbar__getimages">\</a>  CMFCToolBar::GetImages  
 Returns a pointer to the collection of default button images in the application.  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the [CMFCToolBarImages](../vs140/cmfctoolbarimages-class.md) object that contains the collection of default images for all toolbars in the application.  
  
### Remarks  
 This shared method provides access to the collection of all default toolbar images for the application. Call the [LoadBitmap](#cmfctoolbar__loadbitmap) method to add images to the collection.  
  
##  \<a name="cmfctoolbar__getimagesize">\</a>  CMFCToolBar::GetImageSize  
 Returns the current size of toolbar button images.  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
### Return Value  
 A [CSize](../vs140/csize-class.md) object that represents the current size of toolbar button images.  
  
##  \<a name="cmfctoolbar__getimagesoffset">\</a>  CMFCToolBar::GetImagesOffset  
 Returns the index offset used to find the toolbar button images for this toolbar in the global list of toolbar button images.  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Return Value  
 The index offset of the toolbar images.  
  
### Remarks  
 All toolbar default images are stored in the global [CMFCToolBarImages](../vs140/cmfctoolbarimages-class.md) list. The images for each button in the toolbar are stored consecutively in that list. To compute the index of the image, add the index of the button in the toolbar to the offset of the beginning of the list of images for that toolbar button.  
  
 Call [CMFCToolBar::ButtonToIndex](#cmfctoolbar__buttontoindex) to obtain the index of a toolbar button given a pointer to the button.  
  
 Call [GetImages](#cmfctoolbar__getimages) to obtain a pointer to the collection of toolbar images.  
  
##  \<a name="cmfctoolbar__getinvalidateitemrect">\</a>  CMFCToolBar::GetInvalidateItemRect  
 Retrieves the region of the client area that must be redrawn for the button at the given index.  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>366\</CodeContentPlaceHolder>  
 The index of the button for which to retrieve the client area.  
  
 [out] <CodeContentPlaceHolder>367\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>368\</CodeContentPlaceHolder> object that receives the region of the client area.  
  
### Remarks  
 The <CodeContentPlaceHolder>369\</CodeContentPlaceHolder> parameter must not be <CodeContentPlaceHolder>370\</CodeContentPlaceHolder>. If no button exists at the provided index, <CodeContentPlaceHolder>371\</CodeContentPlaceHolder> receives a <CodeContentPlaceHolder>372\</CodeContentPlaceHolder> object that is initialized to zero.  
  
##  \<a name="cmfctoolbar__getitemid">\</a>  CMFCToolBar::GetItemID  
 Returns the command ID of the toolbar button at a specified index.  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>373\</CodeContentPlaceHolder>  
 Specifies the index of the toolbar button.  
  
### Return Value  
 The command ID of the toolbar button; or zero if the button with the specified index does not exist.  
  
##  \<a name="cmfctoolbar__getitemrect">\</a>  CMFCToolBar::GetItemRect  
 Returns the bounding rectangle of the button at a specified index.  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>374\</CodeContentPlaceHolder>  
 Specifies the index of a toolbar button.  
  
 [out] <CodeContentPlaceHolder>375\</CodeContentPlaceHolder>  
 A pointer to <CodeContentPlaceHolder>376\</CodeContentPlaceHolder> object that receives the coordinates of the image bounding rectangle.  
  
### Remarks  
 The <CodeContentPlaceHolder>377\</CodeContentPlaceHolder> object to which <CodeContentPlaceHolder>378\</CodeContentPlaceHolder> points is set to 0 if a button at the specified index does not exist.  
  
### Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>379\</CodeContentPlaceHolder> method of the <CodeContentPlaceHolder>380\</CodeContentPlaceHolder> class. This code snippet is part of the [IE Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_IEDemo#6](../vs140/codesnippet/CPP/cmfctoolbar-class_1.h)]  
[!code[NVC_MFC_IEDemo#9](../vs140/codesnippet/CPP/cmfctoolbar-class_4.cpp)]  
  
##  \<a name="cmfctoolbar__getlargecoldimages">\</a>  CMFCToolBar::GetLargeColdImages  
 Returns a pointer to the collection of large cold toolbar button images in the application.  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the collection of large cold images.  
  
### Remarks  
 Cold images are the images that are used when the user is not interacting with the toolbar buttons. Call [LoadBitmapEx](#cmfctoolbar__loadbitmapex) to load the large cold images.  
  
##  \<a name="cmfctoolbar__getlargedisabledimages">\</a>  CMFCToolBar::GetLargeDisabledImages  
 Returns a pointer to the collection of large disabled toolbar button images in the application.  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the collection of large disabled toolbar button images.  
  
### Remarks  
 Large images are large versions of the regular toolbar button images. Call [LoadBitmapEx](#cmfctoolbar__loadbitmapex) or [LoadBitmap](#cmfctoolbar__loadbitmap) to load the large images.  
  
##  \<a name="cmfctoolbar__getlargeimages">\</a>  CMFCToolBar::GetLargeImages  
 Returns a pointer to the collection of large toolbar button images in the application.  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the collection of large toolbar button images.  
  
### Remarks  
 Large images are large versions of the regular toolbar button images. Call [LoadBitmapEx](#cmfctoolbar__loadbitmapex) to load the large images.  
  
##  \<a name="cmfctoolbar__getlockedcoldimages">\</a>  CMFCToolBar::GetLockedColdImages  
 Returns a pointer to the collection of locked cold images in the toolbar.  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the collection of locked cold images, or <CodeContentPlaceHolder>381\</CodeContentPlaceHolder> if the toolbar is not locked.  
  
### Remarks  
 Locked images are versions of the regular toolbar button images that the framework uses when the user cannot customize the toolbar. Cold images are the images that are used when the user is not interacting with the toolbar buttons.  
  
 This method returns <CodeContentPlaceHolder>382\</CodeContentPlaceHolder> if the toolbar is not locked. This method also generates an assertion failure in Debug builds if the toolbar is not locked. For more information about locked toolbars, see [CMFCToolBar::IsLocked](#cmfctoolbar__islocked).  
  
 Call the [CMFCToolBar::LoadBitmapEx](#cmfctoolbar__loadbitmapex) method to load the locked cold images.  
  
##  \<a name="cmfctoolbar__getlockeddisabledimages">\</a>  CMFCToolBar::GetLockedDisabledImages  
 Returns a pointer to the collection of locked disabled images in the toolbar.  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the collection of locked disabled images, or <CodeContentPlaceHolder>383\</CodeContentPlaceHolder> if the toolbar is not locked.  
  
### Remarks  
 Locked images are versions of the regular toolbar button images that the framework uses when the user cannot customize the toolbar. Disabled images are the images that the framework uses when a button has the <CodeContentPlaceHolder>384\</CodeContentPlaceHolder> style.  
  
 This method returns <CodeContentPlaceHolder>385\</CodeContentPlaceHolder> if the toolbar is not locked. This method also generates an assertion failure in Debug builds if the toolbar is not locked. For more information about locked toolbars, see [CMFCToolBar::IsLocked](#cmfctoolbar__islocked).  
  
 Call the [CMFCToolBar::LoadBitmapEx](#cmfctoolbar__loadbitmapex) method to load the locked disabled images.  
  
##  \<a name="cmfctoolbar__getlockedimages">\</a>  CMFCToolBar::GetLockedImages  
 Returns a pointer to the collection of locked button images in the toolbar.  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the collection of locked toolbar button images, or <CodeContentPlaceHolder>386\</CodeContentPlaceHolder> if the toolbar is not locked.  
  
### Remarks  
 Locked images are versions of the regular toolbar button images that the framework uses when the user cannot customize the toolbar.  
  
 This method returns <CodeContentPlaceHolder>387\</CodeContentPlaceHolder> if the toolbar is not locked. This method also generates an assertion failure in Debug builds if the toolbar is not locked. For more information about locked toolbars, see [CMFCToolBar::IsLocked](#cmfctoolbar__islocked).  
  
##  \<a name="cmfctoolbar__getlockedimagesize">\</a>  CMFCToolBar::GetLockedImageSize  
 Returns the default size of locked toolbar images.  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>388\</CodeContentPlaceHolder> structure that specifies the size of locked toolbar images or an empty <CodeContentPlaceHolder>389\</CodeContentPlaceHolder> structure if the toolbar is not locked.  
  
### Remarks  
 Locked images are versions of the regular toolbar button images that the framework uses when the user cannot customize the toolbar.  
  
 This method returns a <CodeContentPlaceHolder>390\</CodeContentPlaceHolder> structure with zero width and zero height if the toolbar is not locked. This method also generates an assertion failure in Debug builds if the toolbar is not locked. For more information about locked toolbars, see [CMFCToolBar::IsLocked](#cmfctoolbar__islocked).  
  
 Call the [CMFCToolBar::SetLockedSizes](#cmfctoolbar__setlockedsizes) method to specify the locked image size.  
  
##  \<a name="cmfctoolbar__getlockedmenuimages">\</a>  CMFCToolBar::GetLockedMenuImages  
 Returns a pointer to the collection of locked toolbar menu images in the toolbar.  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the collection of locked toolbar menu images, or <CodeContentPlaceHolder>391\</CodeContentPlaceHolder> if the toolbar is not locked.  
  
### Remarks  
 Locked images are versions of the regular toolbar menu images that the framework uses when the user cannot customize the toolbar.  
  
 This method returns <CodeContentPlaceHolder>392\</CodeContentPlaceHolder> if the toolbar is not locked. This method also generates an assertion failure in Debug builds if the toolbar is not locked. For more information about locked toolbars, see [CMFCToolBar::IsLocked](#cmfctoolbar__islocked).  
  
 Call the [CMFCToolBar::LoadBitmapEx](#cmfctoolbar__loadbitmapex) method to load the locked menu images.  
  
##  \<a name="cmfctoolbar__getmenubuttonsize">\</a>  CMFCToolBar::GetMenuButtonSize  
 Returns the size of menu buttons in the application.  
  
<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>393\</CodeContentPlaceHolder> object that represents the size of menu buttons, in pixels.  
  
### Remarks  
 The size of menu buttons on toolbars is maintained as a global variable and can be retrieved by this static method.  
  
 Call [SetMenuSizes](#cmfctoolbar__setmenusizes) to set this global variable.  
  
##  \<a name="cmfctoolbar__getmenuimages">\</a>  CMFCToolBar::GetMenuImages  
 Returns a pointer to the collection of menu button images in the application.  
  
<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the collection of menu images.  
  
### Remarks  
 Call the [LoadBitmapEx](#cmfctoolbar__loadbitmapex) method to load the menu images.  
  
 Call the [CMFCToolBar::SetMenuSizes](#cmfctoolbar__setmenusizes) method to set the size of buttons and their images.  
  
##  \<a name="cmfctoolbar__getmenuimagesize">\</a>  CMFCToolBar::GetMenuImageSize  
 Returns the size of menu button images in the application.  
  
<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>394\</CodeContentPlaceHolder> object that represents the size of menu images.  
  
### Remarks  
 This method returns the size of images on toolbar menu buttons that is maintained as a global variable. Call [SetMenuSizes](#cmfctoolbar__setmenusizes) to set this global variable.  
  
##  \<a name="cmfctoolbar__getorigbuttons">\</a>  CMFCToolBar::GetOrigButtons  
 Retrieves the collection of non-customized buttons of the toolbar.  
  
<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
### Return Value  
 A reference to the list of non-customized buttons of the toolbar.  
  
### Remarks  
 The framework creates a copy of toolbar buttons before they are customized by the user. The [CMFCToolBar::SetButtons](#cmfctoolbar__setbuttons) method adds a copy of each button in the provided array to the list of original buttons. The [CMFCToolBar::RestoreOriginalstate](#cmfctoolbar__restoreoriginalstate) method restores the original state of the toolbar by loading it from the resource file.  
  
 To set the list of original buttons for your toolbar, call the [CMFCToolBar::SetOrigButtons](#cmfctoolbar__setorigbuttons) method.  
  
##  \<a name="cmfctoolbar__getorigresetbuttons">\</a>  CMFCToolBar::GetOrigResetButtons  
 Retrieves the collection of non-customized reset buttons of the toolbar.  
  
<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
### Return Value  
 A reference to the list of non-customized reset buttons of the toolbar.  
  
### Remarks  
 When the user clicks the **Reset** button during customization mode, the framework uses this method to restore buttons that were removed from the toolbar.  
  
 The [CMFCToolBar::SetButtons](#cmfctoolbar__setbuttons) method adds a copy of each toolbar button to the list of original reset buttons after it calls the [CMFCToolBar::OnReset](#cmfctoolbar__onreset) method. You can override the [CMFCToolBar::OnReset](#cmfctoolbar__onreset) method to customize the appearance of buttons after the user presses the **Reset** button.  
  
##  \<a name="cmfctoolbar__getresourceid">\</a>  CMFCToolBar::GetResourceID  
 Retrieves the resource ID of the toolbar.  
  
<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
### Return Value  
 The resource ID of the toolbar.  
  
### Remarks  
 Call the [CMFCToolBar::LoadToolBarEx](#cmfctoolbar__loadtoolbarex) method to set the resource ID of the toolbar.  
  
##  \<a name="cmfctoolbar__getroutecommandsviaframe">\</a>  CMFCToolBar::GetRouteCommandsViaFrame  
 Determines which object, the parent frame or the owner, sends commands to the toolbar.  
  
<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the parent frame sends commands to the toolbar; 0 if the owner sends commands to the toolbar.  
  
### Remarks  
 By default, the parent frame sends commands to the toolbar. Call [SetRouteCommandsViaFrame](#cmfctoolbar__setroutecommandsviaframe) to change this behavior.  
  
 If this method returns a nonzero value, you can retrieve a pointer to the parent frame object by using the <CodeContentPlaceHolder>395\</CodeContentPlaceHolder> method. See the VisualStudioDemo sample for an example that uses this method.  
  
##  \<a name="cmfctoolbar__getrowheight">\</a>  CMFCToolBar::GetRowHeight  
 Returns the height of toolbar buttons.  
  
<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
### Return Value  
 The height of toolbar buttons, in pixels.  
  
### Remarks  
 The framework calls this method to calculate toolbar layout. Override this method in a derived class to specify a different height for your toolbar.  
  
##  \<a name="cmfctoolbar__getshowtooltips">\</a>  CMFCToolBar::GetShowTooltips  
 Specifies whether tool tips are displayed for toolbar buttons.  
  
<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>396\</CodeContentPlaceHolder> if tool tips are shown for toolbar buttons; otherwise <CodeContentPlaceHolder>397\</CodeContentPlaceHolder>.  
  
### Remarks  
 By default tool tips are shown. You can change this static flag by calling [SetShowTooltips](#cmfctoolbar__setshowtooltips).  
  
##  \<a name="cmfctoolbar__getsiblingtoolbar">\</a>  CMFCToolBar::GetSiblingToolBar  
 Retrieves the sibling of the toolbar.  
  
<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the sibling toolbar.  
  
### Remarks  
 For more information about how to enable the **Show Buttons on One Row** and **Show Buttons on Two Rows** buttons, see [CMFCToolBar::SetSiblingToolBar](#cmfctoolbar__setsiblingtoolbar).  
  
##  \<a name="cmfctoolbar__getuserimages">\</a>  CMFCToolBar::GetUserImages  
 Returns a pointer to the collection of user-defined toolbar button images in the application.  
  
<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the collection of user-defined toolbar button images for all toolbars in the application.  
  
### Remarks  
 Call the [SetUserImages](#cmfctoolbar__setuserimages) method to set the collection of user-defined images in the application.  
  
##  \<a name="cmfctoolbar__hittest">\</a>  CMFCToolBar::HitTest  
 Returns the index of the toolbar button that is located at the specified position.  
  
<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>398\</CodeContentPlaceHolder>  
 The point to be tested, in client coordinates.  
  
### Return Value  
 The index of the button that is located at the specified position, or -1 if there is no such button or the button is a separator.  
  
##  \<a name="cmfctoolbar__insertbutton">\</a>  CMFCToolBar::InsertButton  
 Inserts a button into the toolbar.  
  
<CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>399\</CodeContentPlaceHolder>  
 Specifies the button to insert.  
  
 [in] <CodeContentPlaceHolder>400\</CodeContentPlaceHolder>  
 Specifies the zero-based position to insert the button at.  
  
### Return Value  
 The position at which the button was inserted or -1 if an error occurs.  
  
### Remarks  
 If <CodeContentPlaceHolder>401\</CodeContentPlaceHolder> is -1, this method adds the button to the end of the list of toolbar buttons.  
  
 Call the [CMFCToolBar::InsertSeparator](#cmfctoolbar__insertseparator) method to insert a separator into the toolbar.  
  
##  \<a name="cmfctoolbar__insertseparator">\</a>  CMFCToolBar::InsertSeparator  
 Inserts a separator into the toolbar.  
  
<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>402\</CodeContentPlaceHolder>  
 Specifies the zero-based position to insert the separator at. This parameter must be larger than 0.  
  
### Return Value  
 The position at which the separator was inserted or -1 if an error occurs.  
  
### Remarks  
 Call this method to insert a separator between two existing buttons. If <CodeContentPlaceHolder>403\</CodeContentPlaceHolder> is -1, this method adds the separator to the end of the list of toolbar buttons.  
  
 You cannot use this method to add a separator to an empty toolbar.  
  
 Call the [CMFCToolBar::InsertButton](#cmfctoolbar__insertbutton) method to insert a button into the toolbar.  
  
##  \<a name="cmfctoolbar__invalidatebutton">\</a>  CMFCToolBar::InvalidateButton  
 Invalidates the client area of the toolbar button that exists at the provided index.  
  
<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>404\</CodeContentPlaceHolder>  
 The zero-based index of the button in the toolbar.  
  
### Return Value  
 A pointer to the <CodeContentPlaceHolder>405\</CodeContentPlaceHolder> object that exists at the provided index or <CodeContentPlaceHolder>406\</CodeContentPlaceHolder> if no such object exists.  
  
### Remarks  
 The framework calls this method when it updates the client area that is associated with a toolbar button. It calls the [CWnd::InvalidateRect](../vs140/cwnd-class.md#cwnd__invalidaterect) method with the client rectangle of the <CodeContentPlaceHolder>407\</CodeContentPlaceHolder> object that exists at the provided index.  
  
##  \<a name="cmfctoolbar__isaddremovequickcustomize">\</a>  CMFCToolBar::IsAddRemoveQuickCustomize  
 Determines whether a user can add or remove toolbar buttons by using the **Customize** menu option.  
  
<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>408\</CodeContentPlaceHolder> if a user can use the **Customize** menu option to modify the toolbar; otherwise, <CodeContentPlaceHolder>409\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfctoolbar__isaltcustomizemode">\</a>  CMFCToolBar::IsAltCustomizeMode  
 Specifies whether *quick customization* is being used to drag a button. When quick customization is enabled, a user can press and hold the Alt key and drag a button to a new location.  
  
<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>410\</CodeContentPlaceHolder> if quick customization is being used to drag a button; otherwise, <CodeContentPlaceHolder>411\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfctoolbar__isautograyinactiveimages">\</a>  CMFCToolBar::IsAutoGrayInactiveImages  
 Specifies whether the automatic generation of inactive (non-highlighted) button images is enabled.  
  
<CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>412\</CodeContentPlaceHolder> if the option to automatically dim inactive images is enabled; otherwise <CodeContentPlaceHolder>413\</CodeContentPlaceHolder>.  
  
### Remarks  
 You can enable or disable automatic dimming of inactive images by calling [CMFCToolBar::AutoGrayInactiveImages](#cmfctoolbar__autograyinactiveimages).  
  
##  \<a name="cmfctoolbar__isbasiccommand">\</a>  CMFCToolBar::IsBasicCommand  
 Determines whether a command is on the list of basic commands.  
  
<CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>414\</CodeContentPlaceHolder>  
 Specifies the command to check.  
  
### Return Value  
 <CodeContentPlaceHolder>415\</CodeContentPlaceHolder> if the specified command belongs to the list of basic commands; otherwise <CodeContentPlaceHolder>416\</CodeContentPlaceHolder>.  
  
### Remarks  
 This static method determines whether the command specified by <CodeContentPlaceHolder>417\</CodeContentPlaceHolder> belongs to the global list of basic commands. You can change the list of basic commands by calling [AddBasicCommand](#cmfctoolbar__addbasiccommand) or [SetBasicCommands](#cmfctoolbar__setbasiccommands).  
  
##  \<a name="cmfctoolbar__isbuttonextrasizeavailable">\</a>  CMFCToolBar::IsButtonExtraSizeAvailable  
 Determines whether the toolbar can display buttons that have extended borders.  
  
<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>418\</CodeContentPlaceHolder> if the bar can display buttons with the extra border size; otherwise <CodeContentPlaceHolder>419\</CodeContentPlaceHolder>.  
  
### Remarks  
 The toolbar object returns <CodeContentPlaceHolder>420\</CodeContentPlaceHolder> if it can display buttons that have extended borders. A toolbar button calls this method when it handles the [CMFCToolBarButton::OnChangeParentWnd](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onchangeparentwnd) notification and will set its internal extra border size flag accordingly. This internal flag may be retrieved later by calling [CMFCToolBarButton::IsExtraSize](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__isextrasize).  
  
 Override this method in a class derived from [CMFCToolBar](../vs140/cmfctoolbar-class.md) and return <CodeContentPlaceHolder>421\</CodeContentPlaceHolder> if your bar can display the toolbar buttons with the extra border size and return <CodeContentPlaceHolder>422\</CodeContentPlaceHolder> otherwise. The default implementation returns <CodeContentPlaceHolder>423\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctoolbar__isbuttonhighlighted">\</a>  CMFCToolBar::IsButtonHighlighted  
 Determines whether the specified button is highlighted.  
  
<CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>424\</CodeContentPlaceHolder>  
 Specifies the index of a toolbar button.  
  
### Return Value  
 <CodeContentPlaceHolder>425\</CodeContentPlaceHolder> if the specified button is highlighted; otherwise, <CodeContentPlaceHolder>426\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfctoolbar__iscommandpermitted">\</a>  CMFCToolBar::IsCommandPermitted  
 Determines whether a command is permitted.  
  
<CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>427\</CodeContentPlaceHolder>  
 Specifies the command to check.  
  
### Return Value  
 <CodeContentPlaceHolder>428\</CodeContentPlaceHolder> if the specified command is permitted; otherwise <CodeContentPlaceHolder>429\</CodeContentPlaceHolder>.  
  
### Remarks  
 This static method determines whether the command specified by <CodeContentPlaceHolder>430\</CodeContentPlaceHolder> belongs to the global list of non-permitted commands.  
  
 You can change the list of non-permitted commands by calling [SetNonPermittedCommands](#cmfctoolbar__setnonpermittedcommands).  
  
##  \<a name="cmfctoolbar__iscommandrarelyused">\</a>  CMFCToolBar::IsCommandRarelyUsed  
 Determines whether a command is rarely used.  
  
<CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>431\</CodeContentPlaceHolder>  
 Specifies the command to check.  
  
### Return Value  
 <CodeContentPlaceHolder>432\</CodeContentPlaceHolder> if the specified command is rarely used; otherwise <CodeContentPlaceHolder>433\</CodeContentPlaceHolder>.  
  
### Remarks  
 The <CodeContentPlaceHolder>434\</CodeContentPlaceHolder> method returns <CodeContentPlaceHolder>435\</CodeContentPlaceHolder> when one or more of the following conditions occur:  
  
-   The specified command belongs to the list of basic commands  
  
-   The specified command is one of the standard commands  
  
-   The framework is in customization mode  
  
-   The list of basic commands is empty  
  
-   More than 20% of command calls are calls to the specified command.  
  
##  \<a name="cmfctoolbar__iscustomizemode">\</a>  CMFCToolBar::IsCustomizeMode  
 Specifies whether the toolbar framework is in customization mode.  
  
<CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>436\</CodeContentPlaceHolder> if the framework is in customization mode; otherwise <CodeContentPlaceHolder>437\</CodeContentPlaceHolder>.  
  
### Remarks  
 You can toggle customization mode by calling [SetCustomizeMode](#cmfctoolbar__setcustomizemode).  
  
 The framework changes the mode when the user invokes the customization dialog box ( [CMFCToolBarsCustomizeDialog](../vs140/cmfctoolbarscustomizedialog-class.md)).  
  
##  \<a name="cmfctoolbar__isdragbutton">\</a>  CMFCToolBar::IsDragButton  
 Determines whether a toolbar button is being dragged.  
  
<CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>438\</CodeContentPlaceHolder>  
 Pointer to a toolbar button.  
  
### Return Value  
 <CodeContentPlaceHolder>439\</CodeContentPlaceHolder> if the specified button is being dragged; otherwise, <CodeContentPlaceHolder>440\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfctoolbar__isexistcustomizebutton">\</a>  CMFCToolBar::IsExistCustomizeButton  
 Determines whether the toolbar contains the **Customize** button.  
  
<CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>441\</CodeContentPlaceHolder> if the toolbar contains the **Customize** button; otherwise <CodeContentPlaceHolder>442\</CodeContentPlaceHolder>.  
  
### Remarks  
 If this method returns <CodeContentPlaceHolder>443\</CodeContentPlaceHolder>, the [CMFCToolBar::GetCustomizeButton](#cmfctoolbar__getcustomizebutton) method returns a pointer to the **Customize** button that appears at the end of the toolbar.  
  
 Use the [CMFCToolBar::EnableCustomizeButton](#cmfctoolbar__enablecustomizebutton) method to add the **Customize** button to your toolbar.  
  
##  \<a name="cmfctoolbar__isfloating">\</a>  CMFCToolBar::IsFloating  
 Determines whether the toolbar is floating.  
  
<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>444\</CodeContentPlaceHolder> if the toolbar is floating; otherwise, <CodeContentPlaceHolder>445\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctoolbar__islargeicons">\</a>  CMFCToolBar::IsLargeIcons  
 Specifies whether toolbars in the application currently display large icons.  
  
<CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>446\</CodeContentPlaceHolder> if the application is using large icons; otherwise <CodeContentPlaceHolder>447\</CodeContentPlaceHolder>.  
  
### Remarks  
 Call [SetLargeIcons](#cmfctoolbar__setlargeicons) to toggle between large icons and regular icons.  
  
 The framework automatically changes the mode when the user toggles the **Large icons** check-box on the **Options** page of the **Customization** dialog box.  
  
##  \<a name="cmfctoolbar__islastcommandfrombutton">\</a>  CMFCToolBar::IsLastCommandFromButton  
 Determines whether the most recently executed command was sent from the specified toolbar button.  
  
<CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>448\</CodeContentPlaceHolder>  
 Pointer to button.  
  
### Return Value  
 <CodeContentPlaceHolder>449\</CodeContentPlaceHolder> if the last command was sent from the button that <CodeContentPlaceHolder>450\</CodeContentPlaceHolder> specifies; otherwise <CodeContentPlaceHolder>451\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method obtains a pointer to a [MSG Structure](../vs140/msg-structure.md) by calling <CodeContentPlaceHolder>452\</CodeContentPlaceHolder>. It then compares the <CodeContentPlaceHolder>453\</CodeContentPlaceHolder> of the button with the <CodeContentPlaceHolder>454\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>455\</CodeContentPlaceHolder> members to determine whether the button was the source of the command.  
  
##  \<a name="cmfctoolbar__islocked">\</a>  CMFCToolBar::IsLocked  
 Determines whether the toolbar is locked.  
  
<CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>456\</CodeContentPlaceHolder> if the toolbar is locked; otherwise, <CodeContentPlaceHolder>457\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method returns <CodeContentPlaceHolder>458\</CodeContentPlaceHolder> when the user cannot perform customization tasks such as repositioning toolbar buttons.  
  
 Locked toolbars use separate image lists. For more information about these image lists, see [CMFCToolBar::LoadBitmapEx](#cmfctoolbar__loadbitmapex).  
  
##  \<a name="cmfctoolbar__isonerowwithsibling">\</a>  CMFCToolBar::IsOneRowWithSibling  
 Determines whether the toolbar and its sibling toolbar are positioned on the same row.  
  
<CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>459\</CodeContentPlaceHolder> if the toolbar and its sibling are positioned on the same row; otherwise <CodeContentPlaceHolder>460\</CodeContentPlaceHolder>.  
  
### Remarks  
 The [CMFCCustomizeButton::CreatePopupMenu](assetId:///e501083e-f78e-4d8d-900c-40bd6e2bb7f8) method calls this method to determine how to show the **Customize** pop-up menu. If this method returns <CodeContentPlaceHolder>461\</CodeContentPlaceHolder>, the framework displays the **Show Buttons on One Row** button. Otherwise, the framework displays the **Show Buttons on Two Rows** button.  
  
 You typically do not have to use this method. To enable the **Show Buttons on One Row** or **Show Buttons on Two Rows** buttons, call [CMFCToolBar::SetSiblingToolBar](#cmfctoolbar__setsiblingtoolbar).  
  
##  \<a name="cmfctoolbar__isresourcechanged">\</a>  CMFCToolBar::IsResourceChanged  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbar__issibling">\</a>  CMFCToolBar::IsSibling  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbar__isuserdefined">\</a>  CMFCToolBar::IsUserDefined  
 Specifies whether the toolbar is user-defined.  
  
<CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>462\</CodeContentPlaceHolder> if the toolbar was created by the user; otherwise <CodeContentPlaceHolder>463\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctoolbar__loadbitmap">\</a>  CMFCToolBar::LoadBitmap  
 Loads toolbar images from application resources.  
  
<CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>464\</CodeContentPlaceHolder>  
 The resource ID of the bitmap that refers to the hot toolbar images.  
  
 [in] <CodeContentPlaceHolder>465\</CodeContentPlaceHolder>  
 The resource ID of the bitmap that refers to the cold toolbar images.  
  
 [in] <CodeContentPlaceHolder>466\</CodeContentPlaceHolder>  
 The resource ID of the bitmap that refers to the regular menu images.  
  
 [in] <CodeContentPlaceHolder>467\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>468\</CodeContentPlaceHolder> to lock the toolbar; otherwise <CodeContentPlaceHolder>469\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>470\</CodeContentPlaceHolder>  
 The resource ID of the bitmap that refers to the disabled toolbar images.  
  
 [in] <CodeContentPlaceHolder>471\</CodeContentPlaceHolder>  
 The resource ID of the bitmap that refers to the disabled menu images.  
  
### Return Value  
 Nonzero if the method succeeds; otherwise 0.  
  
### Remarks  
 The [CMFCToolBar::LoadToolBarEx](#cmfctoolbar__loadtoolbarex) method calls this method to load the images that are associated with the toolbar. Override this method to perform custom loading of image resources.  
  
 Call the <CodeContentPlaceHolder>472\</CodeContentPlaceHolder> method to load additional images after you create the toolbar.  
  
##  \<a name="cmfctoolbar__loadbitmapex">\</a>  CMFCToolBar::LoadBitmapEx  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>473\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>474\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbar__loadlargeiconsstate">\</a>  CMFCToolBar::LoadLargeIconsState  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>475\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbar__loadparameters">\</a>  CMFCToolBar::LoadParameters  
 Loads global toolbar options from the Windows registry.  
  
<CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>476\</CodeContentPlaceHolder>  
 Specifies the relative path of the Windows registry key.  
  
### Return Value  
 Nonzero if the method succeeds; otherwise 0.  
  
### Remarks  
 This method loads global parameters such as the menu animation type, the menu shadow style, and whether to display large icons from the Windows registry.  
  
 The [CWinAppEx::LoadState](../vs140/cwinappex-class.md#cwinappex__loadstate) method calls this method as a part of the initialization process of the application.  
  
##  \<a name="cmfctoolbar__loadstate">\</a>  CMFCToolBar::LoadState  
 Loads the toolbar state information from the Windows registry.  
  
<CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>477\</CodeContentPlaceHolder>  
 Specifies the relative path of the Windows registry key.  
  
 [in] <CodeContentPlaceHolder>478\</CodeContentPlaceHolder>  
 Specifies the control ID of the toolbar.  
  
 [in] <CodeContentPlaceHolder>479\</CodeContentPlaceHolder>  
 Specifies the resource ID of the toolbar.  
  
### Return Value  
 Nonzero if the method succeeds; otherwise 0.  
  
### Remarks  
 The framework calls this method as a part of the initialization process of the application. For more information, see [CWinAppEx::LoadState](../vs140/cwinappex-class.md#cwinappex__loadstate).  
  
##  \<a name="cmfctoolbar__loadtoolbar">\</a>  CMFCToolBar::LoadToolBar  
 Loads the toolbar from application resources.  
  
<CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>480\</CodeContentPlaceHolder>  
 The resource ID of the toolbar.  
  
 [in] <CodeContentPlaceHolder>481\</CodeContentPlaceHolder>  
 The resource ID of the bitmap that refers to the cold toolbar images.  
  
 [in] <CodeContentPlaceHolder>482\</CodeContentPlaceHolder>  
 The resource ID of the bitmap that refers to the regular menu images.  
  
 [in] <CodeContentPlaceHolder>483\</CodeContentPlaceHolder>  
 A Boolean value that specifies whether the toolbar is locked or not. If this parameter is <CodeContentPlaceHolder>484\</CodeContentPlaceHolder>, the toolbar is locked. Otherwise, the toolbar is not locked.  
  
 [in] <CodeContentPlaceHolder>485\</CodeContentPlaceHolder>  
 The resource ID of the bitmap that refers to the disabled toolbar images.  
  
 [in] <CodeContentPlaceHolder>486\</CodeContentPlaceHolder>  
 The resource ID of the bitmap that refers to the disabled menu images.  
  
 [in] <CodeContentPlaceHolder>487\</CodeContentPlaceHolder>  
 The resource ID of the bitmap that refers to the hot toolbar images.  
  
### Return Value  
 Nonzero if the method succeeds; otherwise 0.  
  
### Remarks  
 The framework calls this method during initialization to load the images that are associated with the toolbar.  
  
### Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>488\</CodeContentPlaceHolder> method in the <CodeContentPlaceHolder>489\</CodeContentPlaceHolder> class. This code snippet is part of the [IE Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_IEDemo#6](../vs140/codesnippet/CPP/cmfctoolbar-class_1.h)]  
[!code[NVC_MFC_IEDemo#7](../vs140/codesnippet/CPP/cmfctoolbar-class_3.cpp)]  
  
##  \<a name="cmfctoolbar__loadtoolbarex">\</a>  CMFCToolBar::LoadToolBarEx  
 Loads the toolbar from application resources by using the <CodeContentPlaceHolder>490\</CodeContentPlaceHolder> helper class to enable the application to use large images.  
  
<CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>491\</CodeContentPlaceHolder>  
 The resource ID of the toolbar.  
  
 [in] <CodeContentPlaceHolder>492\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>493\</CodeContentPlaceHolder> object that contains the resource IDs for the toolbar images.  
  
 [in] <CodeContentPlaceHolder>494\</CodeContentPlaceHolder>  
 A Boolean value that specifies whether the toolbar is locked or not. If this parameter is <CodeContentPlaceHolder>495\</CodeContentPlaceHolder>, the toolbar is locked. Otherwise, the toolbar is not locked.  
  
### Return Value  
 Nonzero if the method succeeds; otherwise 0.  
  
### Remarks  
 Call this method to load toolbar images from the application resources.  
  
##  \<a name="cmfctoolbar__m_dbllargeimageratio">\</a>  CMFCToolBar::m_dblLargeImageRatio  
 Specifies the ratio between the dimension (height or width) of large images and the dimension of regular images.  
  
<CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
### Remarks  
 The default ratio is 2. You can change this value to make large toolbar images larger or smaller.  
  
 The framework uses this data member when you do not specify a set of large images. For example, if you provide only the set of small images with size 16x16 and want the large images to have the size 24x24, set this data member to 1.5.  
  
##  \<a name="cmfctoolbar__nextmenu">\</a>  CMFCToolBar::NextMenu  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbar__onbeforeremovebutton">\</a>  CMFCToolBar::OnBeforeRemoveButton  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>496\</CodeContentPlaceHolder>  
 Unused.  
  
 [in] <CodeContentPlaceHolder>497\</CodeContentPlaceHolder>  
 Unused.  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbar__onchangehot">\</a>  CMFCToolBar::OnChangeHot  
 Called by the framework when a user selects a button on the toolbar.  
  
<CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>498\</CodeContentPlaceHolder>  
 Specifies the index of the toolbar button that is selected; or -1 if no toolbar button is selected.  
  
### Remarks  
 Override this method to process notifications that the user selected a button on a toolbar.  
  
##  \<a name="cmfctoolbar__onchangevisualmanager">\</a>  CMFCToolBar::OnChangeVisualManager  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfctoolbar__onfillbackground">\</a>  CMFCToolBar::OnFillBackground  
 Called by the framework from [CBasePane::DoPaint](../vs140/cbasepane-class.md#cbasepane__dopaint) to fill the toolbar background.  
  
<CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>499\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
### Remarks  
 [DoPaint](#cmfctoolbar__dopaint) calls this method when the background of a toolbar has been filled. The default implementation does nothing.  
  
 Override this method to draw custom background in derived classes.  
  
##  \<a name="cmfctoolbar__onglobalfontschanged">\</a>  CMFCToolBar::OnGlobalFontsChanged  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfctoolbar__onreset">\</a>  CMFCToolBar::OnReset  
 Restores the toolbar to its original state.  
  
<CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
### Remarks  
 Override this method to handle notification about a toolbar reset.  
  
 The default implementation does nothing. Override <CodeContentPlaceHolder>500\</CodeContentPlaceHolder> in a class derived from [CMFCToolBar](../vs140/cmfctoolbar-class.md) when the toolbar has dummy buttons that must be replaced when the toolbar returns to its original state.  
  
##  \<a name="cmfctoolbar__onsetaccdata">\</a>  CMFCToolBar::OnSetAccData  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>501\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbar__onsetdefaultbuttontext">\</a>  CMFCToolBar::OnSetDefaultButtonText  
 Restores the text of a toolbar button to its default state.  
  
<CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>502\</CodeContentPlaceHolder>  
 Points to a button, whose text is being set.  
  
### Return Value  
 <CodeContentPlaceHolder>503\</CodeContentPlaceHolder> ifthe text was successfully restored; otherwise <CodeContentPlaceHolder>504\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this method to process notifications that the text of a toolbar button is being changed to its default.  
  
 The default implementation loads the text of a button from the application resources.  
  
##  \<a name="cmfctoolbar__onusertooltip">\</a>  CMFCToolBar::OnUserToolTip  
 Called by the framework when the tooltip for a button is about to be displayed.  
  
<CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>505\</CodeContentPlaceHolder>  
 Points to a toolbar button for which a tooltip is to be displayed.  
  
 [out] <CodeContentPlaceHolder>506\</CodeContentPlaceHolder>  
 A reference to <CodeContentPlaceHolder>507\</CodeContentPlaceHolder> object that receives the text of the tooltip.  
  
### Return Value  
 <CodeContentPlaceHolder>508\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>509\</CodeContentPlaceHolder> was populated with tooltip text; otherwise <CodeContentPlaceHolder>510\</CodeContentPlaceHolder>.  
  
### Remarks  
 The framework calls this method when the tooltip for a toolbar button is about to be displayed. If <CodeContentPlaceHolder>511\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>512\</CodeContentPlaceHolder>, the framework displays a tooltip which contains the text returned by <CodeContentPlaceHolder>513\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>514\</CodeContentPlaceHolder>. Otherwise, the tooltip contains the button text.  
  
 Override <CodeContentPlaceHolder>515\</CodeContentPlaceHolder> to customize tool tips of toolbar buttons. The default implementation calls [CFrameWndEx::GetToolbarButtonToolTipText](#cmfctoolbar__onusertooltip) to obtain the tooltip text.  
  
##  \<a name="cmfctoolbar__prevmenu">\</a>  CMFCToolBar::PrevMenu  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbar__processcommand">\</a>  CMFCToolBar::ProcessCommand  
 Posts a <CodeContentPlaceHolder>516\</CodeContentPlaceHolder> message to the window that owns the toolbar.  
  
<CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>517\</CodeContentPlaceHolder>  
 Pointer to a button on the toolbar.  
  
### Return Value  
 This method should always return <CodeContentPlaceHolder>518\</CodeContentPlaceHolder>. MFC uses <CodeContentPlaceHolder>519\</CodeContentPlaceHolder> values internally.  
  
### Remarks  
 This method posts a <CodeContentPlaceHolder>520\</CodeContentPlaceHolder> message to the window that owns the toolbar by calling [CWnd::PostMessage](../vs140/cwnd-class.md#cwnd__postmessage) and passing the command ID of the specified button as the <CodeContentPlaceHolder>521\</CodeContentPlaceHolder> parameter.  
  
 Use the [ON_COMMAND](../vs140/on_command.md) macro to map the <CodeContentPlaceHolder>522\</CodeContentPlaceHolder> message to a member function.  
  
##  \<a name="cmfctoolbar__removeallbuttons">\</a>  CMFCToolBar::RemoveAllButtons  
 Removes all buttons and separators from the toolbar.  
  
<CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
### Remarks  
 The framework calls this method when it recreates or destroys a toolbar.  
  
##  \<a name="cmfctoolbar__removebutton">\</a>  CMFCToolBar::RemoveButton  
 Removes from the toolbar the button that has the specified index.  
  
<CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>523\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the button to remove.  
  
### Return Value  
 <CodeContentPlaceHolder>524\</CodeContentPlaceHolder> if the method succeeds, or <CodeContentPlaceHolder>525\</CodeContentPlaceHolder> if the specified index is invalid or the index refers to the **Customize** button.  
  
### Remarks  
 This method updates additional toolbar attributes that are affected by the removal of the button. For example, this method removes nonessential separators from the toolbar and rebuilds the table of shortcut keys.  
  
 For more information about the **Customize** button, see [EnableCustomizeButton](#cmfctoolbar__enablecustomizebutton).  
  
##  \<a name="cmfctoolbar__removestatefromregistry">\</a>  CMFCToolBar::RemoveStateFromRegistry  
 Deletes the state information for the toolbar from the Windows registry.  
  
<CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>526\</CodeContentPlaceHolder>  
 Specifies the registry key where the state information is located.  
  
 [in] <CodeContentPlaceHolder>527\</CodeContentPlaceHolder>  
 The control ID of the toolbar.  
  
 [in] <CodeContentPlaceHolder>528\</CodeContentPlaceHolder>  
 The resource ID of the toolbar. If this parameter is -1, this method uses the [CWnd::GetDlgCtrlID](../vs140/cwnd-class.md#cwnd__getdlgctrlid) method to retrieve the resource ID.  
  
### Return Value  
 Nonzero if the method succeeds; otherwise 0.  
  
### Remarks  
 The framework calls this method when it deletes a user-defined toolbar.  
  
 Override this method if you store additional state information in the Windows registry.  
  
##  \<a name="cmfctoolbar__replacebutton">\</a>  CMFCToolBar::ReplaceButton  
 Replaces a toolbar button with another toolbar button.  
  
<CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>529\</CodeContentPlaceHolder>  
 The command ID of the button to replace.  
  
 [in] <CodeContentPlaceHolder>530\</CodeContentPlaceHolder>  
 A reference to the <CodeContentPlaceHolder>531\</CodeContentPlaceHolder> to insert.  
  
 [in] <CodeContentPlaceHolder>532\</CodeContentPlaceHolder>  
 A Boolean value that specifies whether to replace all buttons that have the command ID specified by <CodeContentPlaceHolder>533\</CodeContentPlaceHolder>. If this parameter is <CodeContentPlaceHolder>534\</CodeContentPlaceHolder>, all buttons that have the specified command ID are replaced. Otherwise, the first button is replaced.  
  
### Return Value  
 The number of buttons that are replaced. This method returns 0 if a button with the specified command ID does not exist on the toolbar.  
  
### Remarks  
 Call this method when you want to add toolbar buttons that cannot be loaded from resources. You can create a placeholder button at design-time and replace that button with a custom button when you initialize the toolbar. See the VisualStudioDemo sample for an example that uses this method.  
  
### Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>535\</CodeContentPlaceHolder> method in the <CodeContentPlaceHolder>536\</CodeContentPlaceHolder> class. This code snippet is part of the [IE Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_IEDemo#6](../vs140/codesnippet/CPP/cmfctoolbar-class_1.h)]  
[!code[NVC_MFC_IEDemo#10](../vs140/codesnippet/CPP/cmfctoolbar-class_5.cpp)]  
  
##  \<a name="cmfctoolbar__resetall">\</a>  CMFCToolBar::ResetAll  
 Restores all toolbars to their original states.  
  
<CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
### Remarks  
 This method calls the [RestoreOriginalState](#cmfctoolbar__restoreoriginalstate) method on each toolbar in the application that can be restored. It uses the [CanBeRestored](#cmfctoolbar__canberestored) method to determine whether a toolbar can be restored.  
  
##  \<a name="cmfctoolbar__resetallimages">\</a>  CMFCToolBar::ResetAllImages  
 Clears all toolbar image collections in the application.  
  
<CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
### Remarks  
 This method clears the image collections that are initialized by the [CMFCToolBar::LoadToolBar](#cmfctoolbar__loadtoolbar) and [CMFCToolBar::LoadBitmap](#cmfctoolbar__loadbitmap) methods.  
  
##  \<a name="cmfctoolbar__resetimages">\</a>  CMFCToolBar::ResetImages  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfctoolbar__restorefocus">\</a>  CMFCToolBar::RestoreFocus  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfctoolbar__restoreoriginalstate">\</a>  CMFCToolBar::RestoreOriginalState  
 Restores the original state of a toolbar.  
  
<CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>537\</CodeContentPlaceHolder> if the method succeeds, or <CodeContentPlaceHolder>538\</CodeContentPlaceHolder> if the method fails or the toolbar is user-defined.  
  
### Remarks  
 This method loads the toolbar from the resource file by using the [LoadToolBar](#cmfctoolbar__loadtoolbar) method.  
  
 The framework calls this method when the user chooses the **Reset All** button on the **Toolbars** page of a customization dialog box.  
  
##  \<a name="cmfctoolbar__saveparameters">\</a>  CMFCToolBar::SaveParameters  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>539\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbar__savestate">\</a>  CMFCToolBar::SaveState  
 Saves the state information for the toolbar in the Windows registry.  
  
<CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>540\</CodeContentPlaceHolder>  
 Specifies the relative path of the Windows registry key.  
  
 [in] <CodeContentPlaceHolder>541\</CodeContentPlaceHolder>  
 The control ID of the toolbar.  
  
 [in] <CodeContentPlaceHolder>542\</CodeContentPlaceHolder>  
 The resource ID of the toolbar.  
  
### Return Value  
 Nonzero if the method succeeds; otherwise 0.  
  
### Remarks  
 The framework calls this method when it saves the application state to the registry. For more information, see [CWinAppEx::SaveState](../vs140/cwinappex-class.md#cwinappex__savestate).  
  
##  \<a name="cmfctoolbar__setbasiccommands">\</a>  CMFCToolBar::SetBasicCommands  
 Sets the list of commands that are always displayed when a user opens a menu.  
  
<CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>543\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>544\</CodeContentPlaceHolder> object that contains a collection of commands.  
  
### Remarks  
 A basic command is always displayed when the menu is opened. This method is meaningful when the user chooses to view recently used commands.  
  
 Use the [AddBasicCommand](#cmfctoolbar__addbasiccommand) method to add a command to the list of basic commands. Use the [GetBasicCommands](#cmfctoolbar__getbasiccommands) method to retrieve the list of basic commands that is used by your application.  
  
 See the Explorer sample for an example that uses this method.  
  
##  \<a name="cmfctoolbar__setbuttoninfo">\</a>  CMFCToolBar::SetButtonInfo  
 Sets the command ID, style, and image ID of a toolbar button.  
  
<CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>545\</CodeContentPlaceHolder>  
 The zero-based index of the button whose properties are set.  
  
 [in] <CodeContentPlaceHolder>546\</CodeContentPlaceHolder>  
 The command ID of the button.  
  
 [in] <CodeContentPlaceHolder>547\</CodeContentPlaceHolder>  
 The style of the button. See [ToolBar Control Styles](../vs140/toolbar-control-styles.md) for the list of available toolbar button styles.  
  
 [in] <CodeContentPlaceHolder>548\</CodeContentPlaceHolder>  
 The zero-based image index of the button (that is, the index in the collection of toolbar images).  
  
### Remarks  
 Call this method to set the properties of a toolbar button.  
  
 In Debug builds, this method generates an assertion failure if the index that is specified by <CodeContentPlaceHolder>549\</CodeContentPlaceHolder> is invalid.  
  
 Call the [CMFCToolBar::SetButtonStyle](#cmfctoolbar__setbuttonstyle) method to set only the style of the button.  
  
##  \<a name="cmfctoolbar__setbuttons">\</a>  CMFCToolBar::SetButtons  
 Sets the buttons for the toolbar.  
  
<CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>550\</CodeContentPlaceHolder>  
 A pointer to the array of command IDs of the buttons to insert.  
  
 [in] <CodeContentPlaceHolder>551\</CodeContentPlaceHolder>  
 The number of items in <CodeContentPlaceHolder>552\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>553\</CodeContentPlaceHolder>  
 A Boolean value that specifies whether to associate the existing button images with the inserted buttons. If this parameter is <CodeContentPlaceHolder>554\</CodeContentPlaceHolder>, the images are remapped.  
  
### Return Value  
 Nonzero if the method succeeds; otherwise 0.  
  
### Remarks  
 Call this method to remove existing buttons from a toolbar and insert a collection of new buttons.  
  
 This method adds the **Customize** button to the toolbar and sends the <CodeContentPlaceHolder>555\</CodeContentPlaceHolder> message to the parent window of the toolbar. For more information about the **Customize** button, see [EnableCustomizeButton](#cmfctoolbar__enablecustomizebutton).  
  
##  \<a name="cmfctoolbar__setbuttonstyle">\</a>  CMFCToolBar::SetButtonStyle  
 Sets the style of the toolbar button at the given index.  
  
<CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>556\</CodeContentPlaceHolder>  
 The zero-based index of the toolbar button whose style is to be set.  
  
 [in] <CodeContentPlaceHolder>557\</CodeContentPlaceHolder>  
 The style of the button. See [ToolBar Control Styles](../vs140/toolbar-control-styles.md) for the list of available toolbar button styles.  
  
### Remarks  
 This method removes the <CodeContentPlaceHolder>558\</CodeContentPlaceHolder> style if <CodeContentPlaceHolder>559\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>560\</CodeContentPlaceHolder> because the user cannot click a disabled button.  
  
##  \<a name="cmfctoolbar__setbuttontext">\</a>  CMFCToolBar::SetButtonText  
 Sets the text label of a toolbar button.  
  
<CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>561\</CodeContentPlaceHolder>  
 The index of the toolbar button.  
  
 [in] <CodeContentPlaceHolder>562\</CodeContentPlaceHolder>  
 The text label of the toolbar button. Must be non- <CodeContentPlaceHolder>563\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>564\</CodeContentPlaceHolder> if the method succeeds; otherwise <CodeContentPlaceHolder>565\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method returns <CodeContentPlaceHolder>566\</CodeContentPlaceHolder> if the provided index does not refer to a valid toolbar button.  
  
##  \<a name="cmfctoolbar__setcommandusageoptions">\</a>  CMFCToolBar::SetCommandUsageOptions  
 Specifies when rarely used commands do not appear in the menu of the application.  
  
<CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>567\</CodeContentPlaceHolder>  
 Specifies the number of times that commands must be executed before the framework shows only the basic and recently-used commands.  
  
 [in] <CodeContentPlaceHolder>568\</CodeContentPlaceHolder>  
 The percentage of times that a command must be executed to be considered a recently-used command.  
  
### Return Value  
 <CodeContentPlaceHolder>569\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>570\</CodeContentPlaceHolder> is equal to or larger than 100; otherwise <CodeContentPlaceHolder>571\</CodeContentPlaceHolder>.  
  
### Remarks  
 Call this method to customize the algorithm that the framework uses to determine how basic and recently used menu items appear. For more information about basic commands, see [CMFCToolBar::AddBasicCommand](#cmfctoolbar__addbasiccommand).  
  
 This class uses the <CodeContentPlaceHolder>572\</CodeContentPlaceHolder> class to track the usage count of commands. For more information about this class, see [CMFCCmdUsageCount Class](../vs140/cmfccmdusagecount-class.md).  
  
##  \<a name="cmfctoolbar__setcustomizemode">\</a>  CMFCToolBar::SetCustomizeMode  
 Enables or disables customization mode for all toolbars in the application.  
  
<CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>573\</CodeContentPlaceHolder>  
 A Boolean value that specifies whether to enable or disable customization mode. Set this parameter to <CodeContentPlaceHolder>574\</CodeContentPlaceHolder> to enable customization mode or <CodeContentPlaceHolder>575\</CodeContentPlaceHolder> to disable it.  
  
### Return Value  
 <CodeContentPlaceHolder>576\</CodeContentPlaceHolder> if calling this method changes the customization mode; otherwise <CodeContentPlaceHolder>577\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method adjusts the layout of and redraws each toolbar in the application. Call the [CMFCToolBar::IsCustomizeMode](#cmfctoolbar__iscustomizemode) method to determine whether the application is in customization mode,  
  
##  \<a name="cmfctoolbar__setgraydisabledbuttons">\</a>  CMFCToolBar::SetGrayDisabledButtons  
 Specifies whether unavailable buttons on the toolbar are dimmed, or whether button-unavailable images are used.  
  
<CodeContentPlaceHolder>143\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>578\</CodeContentPlaceHolder>  
 A Boolean value that specifies how to display unavailable buttons. If this parameter is <CodeContentPlaceHolder>579\</CodeContentPlaceHolder>, the framework dims the buttons. Otherwise, the framework uses the collection of button-unavailable images.  
  
### Remarks  
 By default, unavailable buttons are dimmed.  
  
##  \<a name="cmfctoolbar__setheight">\</a>  CMFCToolBar::SetHeight  
 Sets the height of the toolbar.  
  
<CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>580\</CodeContentPlaceHolder>  
 The height of the toolbar, in pixels.  
  
### Remarks  
 This method redraws the toolbar after it sets the height.  
  
##  \<a name="cmfctoolbar__sethelpmode">\</a>  CMFCToolBar::SetHelpMode  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>581\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfctoolbar__sethot">\</a>  CMFCToolBar::SetHot  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>582\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbar__sethotborder">\</a>  CMFCToolBar::SetHotBorder  
 Specifies whether toolbar buttons are hot-tracked.  
  
<CodeContentPlaceHolder>147\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>583\</CodeContentPlaceHolder>  
 A Boolean value that specifies whether to hot-track toolbar buttons. If this parameter is <CodeContentPlaceHolder>584\</CodeContentPlaceHolder>, the toolbar hot-tracks its buttons. Otherwise, the toolbar does not hot-track its buttons.  
  
### Remarks  
 If a button is hot-tracked, the framework highlights the button when the mouse moves across it. By default, each toolbar hot-tracks its buttons.  
  
 Call the [CMFCToolBar::GetHotBorder](#cmfctoolbar__gethotborder) method to determine whether the toolbar hot-tracks its buttons.  
  
##  \<a name="cmfctoolbar__sethottextcolor">\</a>  CMFCToolBar::SetHotTextColor  
 Sets the text color for hot toolbar buttons.  
  
<CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>585\</CodeContentPlaceHolder>  
 Specifies the text color for toolbar buttons that are hot-tracked.  
  
### Remarks  
 For more information about hot-tracked toolbar buttons, see [CMFCToolBar::GetHotBorder](#cmfctoolbar__gethotborder) and [CMFCToolBar::SetHotBorder](#cmfctoolbar__sethotborder).  
  
##  \<a name="cmfctoolbar__setignoresettext">\</a>  CMFCToolBar::SetIgnoreSetText  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>586\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfctoolbar__setlargeicons">\</a>  CMFCToolBar::SetLargeIcons  
 Specifies whether toolbar buttons display large icons.  
  
<CodeContentPlaceHolder>150\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>587\</CodeContentPlaceHolder>  
 A Boolean value that specifies which icons to use. If this parameter is <CodeContentPlaceHolder>588\</CodeContentPlaceHolder>, the framework displays large icons. Otherwise, the framework displays regular icons.  
  
### Remarks  
 The framework calls this method when the user changes the state of the **Large Icons** check box in the **Options** tab of the **Customize** dialog box. This method resizes all toolbars in the application.  
  
 By default, the framework displays regular icons.  
  
 For more information about the **Customize** dialog box, see [CMFCToolBarsCustomizeDialog Class](../vs140/cmfctoolbarscustomizedialog-class.md).  
  
##  \<a name="cmfctoolbar__setlockedsizes">\</a>  CMFCToolBar::SetLockedSizes  
 Sets the sizes of locked buttons and locked images on the toolbar.  
  
<CodeContentPlaceHolder>151\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>589\</CodeContentPlaceHolder>  
 Specifies the size of locked toolbar buttons.  
  
 [in] <CodeContentPlaceHolder>590\</CodeContentPlaceHolder>  
 Specifies the size of locked toolbar images.  
  
 <CodeContentPlaceHolder>591\</CodeContentPlaceHolder>  
 Specifies whether to scale or not locked toolbar images in high DPI mode.  
  
### Remarks  
 The default size of locked buttons is 23x22 pixels. The default size of locked images is 16x15 pixels.  
  
 Call the [CMFCToolBar::GetLockedImageSize](#cmfctoolbar__getlockedimagesize) method to retrieve the size of locked images. Call the [CMFCToolBar::GetButtonSize](#cmfctoolbar__getbuttonsize) method to retrieve the size of locked toolbar buttons.  
  
##  \<a name="cmfctoolbar__setmaskmode">\</a>  CMFCToolBar::SetMaskMode  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>592\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfctoolbar__setmenusizes">\</a>  CMFCToolBar::SetMenuSizes  
 Sets the size of toolbar menu buttons and their images.  
  
<CodeContentPlaceHolder>153\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>593\</CodeContentPlaceHolder>  
 Specifies the size of toolbar buttons, in pixels.  
  
 [in] <CodeContentPlaceHolder>594\</CodeContentPlaceHolder>  
 Specifies the size of toolbar images, in pixels.  
  
### Remarks  
 By default, menu buttons and their images have an undefined size.  
  
 Call the [CMFCToolBar::GetMenuButtonSize](#cmfctoolbar__getmenubuttonsize) method to determine the size of menu buttons and the [CMFCToolBar::GetMenuImageSize](#cmfctoolbar__getmenuimagesize) method to determine the size of menu button images.  
  
 See the IEDemo and MSMoneyDemo samples for examples that use this method.  
  
##  \<a name="cmfctoolbar__setnonpermittedcommands">\</a>  CMFCToolBar::SetNonPermittedCommands  
 Sets the list of commands that cannot be executed by the user.  
  
<CodeContentPlaceHolder>154\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>595\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>596\</CodeContentPlaceHolder> object that contains the commands that cannot be executed by the user.  
  
### Remarks  
 Call this method to prevent the user from selecting certain commands. For example, you might want to prevent the user from selecting certain commands for security reasons. See the MDITabsDemo and MenuSubSet samples for examples that use this method.  
  
 This method clears the previous list of non-permitted commands. By default, the list of non-permitted commands is empty.  
  
##  \<a name="cmfctoolbar__setonerowwithsibling">\</a>  CMFCToolBar::SetOneRowWithSibling  
 Positions the toolbar and its sibling on the same row.  
  
<CodeContentPlaceHolder>155\</CodeContentPlaceHolder>  
### Remarks  
 The framework calls this method when the user clicks the **Show Buttons on One Row** button.  
  
 Call the [CMFCToolBar::SetSiblingToolBar](#cmfctoolbar__setsiblingtoolbar) method to enable the **Show Buttons on One Row** or **Show Buttons on Two Rows** buttons. If you call [CMFCToolBar::SetSiblingToolBar](#cmfctoolbar__setsiblingtoolbar) for this toolbar, the sibling toolbar is moved to the row of this toolbar. Otherwise, this toolbar is moved to the row of the sibling.  
  
 The framework calls the [CMFCToolBar::SetTwoRowsWithSibling](#cmfctoolbar__settworowswithsibling) method when the user clicks the **Show Buttons on Two Rows** button.  
  
##  \<a name="cmfctoolbar__setorigbuttons">\</a>  CMFCToolBar::SetOrigButtons  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>156\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>597\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfctoolbar__setpermament">\</a>  CMFCToolBar::SetPermament  
 Specifies whether a user can close the toolbar.  
  
<CodeContentPlaceHolder>157\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>598\</CodeContentPlaceHolder>  
 A Boolean value that specifies whether a user can close the toolbar. If this parameter is <CodeContentPlaceHolder>599\</CodeContentPlaceHolder>, a user cannot close the toolbar. Otherwise, a user can close the toolbar.  
  
### Remarks  
 By default, a user can close each toolbar.  
  
 Call the [CMFCToolBar::CanBeClosed](#cmfctoolbar__canbeclosed) method to determine whether a user can close the toolbar.  
  
##  \<a name="cmfctoolbar__setroutecommandsviaframe">\</a>  CMFCToolBar::SetRouteCommandsViaFrame  
 Specifies whether the parent frame or the owner sends commands to the toolbar.  
  
<CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>600\</CodeContentPlaceHolder>  
 If this parameter is <CodeContentPlaceHolder>601\</CodeContentPlaceHolder>, the parent frame sends commands to the toolbar. Otherwise, the owner sends commands to the toolbar.  
  
### Remarks  
 By default, the parent frame sends commands to the toolbar. Call the [CMFCToolBar::GetRouteCommandsViaFrame](#cmfctoolbar__getroutecommandsviaframe) method to determine whether the parent frame or the owner sends commands to the toolbar.  
  
##  \<a name="cmfctoolbar__setshowtooltips">\</a>  CMFCToolBar::SetShowTooltips  
 Specifies whether the framework displays tool tips.  
  
<CodeContentPlaceHolder>159\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>602\</CodeContentPlaceHolder>  
 If this parameter is <CodeContentPlaceHolder>603\</CodeContentPlaceHolder>, the framework shows tool tips. Otherwise, the framework hides tool tips.  
  
### Remarks  
 By default, the framework shows tool tips.  
  
 Call the [CMFCToolBar::GetShowTooltips](#cmfctoolbar__getshowtooltips) method to determine whether the framework shows tool tips.  
  
##  \<a name="cmfctoolbar__setsiblingtoolbar">\</a>  CMFCToolBar::SetSiblingToolBar  
 Specifies the sibling of the toolbar.  
  
<CodeContentPlaceHolder>160\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>604\</CodeContentPlaceHolder>  
 A pointer to the sibling toolbar.  
  
### Remarks  
 This method enables the **Show Buttons on One Row** or **Show Buttons on Two Rows** buttons that are shown when the user displays the **Customize** pop-up menu. Call this method when you want to enable the user to specify whether related toolbars appear on the same row or on different rows.  
  
 Call this method after you enable the **Customize** button that appears on the toolbar. To enable the **Customize** button, call the [CMFCToolBar::EnableCustomizeButton](#cmfctoolbar__enablecustomizebutton) method.  
  
 To retrieve the sibling of a toolbar, call [CMFCToolBar::GetSiblingToolBar](#cmfctoolbar__getsiblingtoolbar).  
  
##  \<a name="cmfctoolbar__setsizes">\</a>  CMFCToolBar::SetSizes  
 Specifies the sizes of buttons and images on all toolbars.  
  
<CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>605\</CodeContentPlaceHolder>  
 The size of toolbar buttons, in pixels.  
  
 [in] <CodeContentPlaceHolder>606\</CodeContentPlaceHolder>  
 The size of toolbar button images, in pixels.  
  
### Remarks  
 The default size of toolbar buttons is 23x22 pixels. The default size of toolbar button images is 16x15 pixels.  
  
 Call the [CMFCToolBar::GetImageSize](#cmfctoolbar__getimagesize) method to retrieve the size of toolbar button images. Call the [CMFCToolBar::GetButtonSize](#cmfctoolbar__getbuttonsize) method to retrieve the size of toolbar buttons.  
  
##  \<a name="cmfctoolbar__settoolbarbtntext">\</a>  CMFCToolBar::SetToolBarBtnText  
 Specifies properties of a button on the toolbar.  
  
<CodeContentPlaceHolder>162\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>607\</CodeContentPlaceHolder>  
 The zero-based index of the toolbar button in the list of toolbar buttons.  
  
 [in] <CodeContentPlaceHolder>608\</CodeContentPlaceHolder>  
 Specifies the text label of the toolbar button.  
  
 [in] <CodeContentPlaceHolder>609\</CodeContentPlaceHolder>  
 If this parameter is <CodeContentPlaceHolder>610\</CodeContentPlaceHolder>, the framework shows the text label. Otherwise, the framework hides the text label.  
  
 [in] <CodeContentPlaceHolder>611\</CodeContentPlaceHolder>  
 If this parameter is <CodeContentPlaceHolder>612\</CodeContentPlaceHolder>, the framework shows the toolbar button image. Otherwise, the framework hides the toolbar button image.  
  
### Remarks  
 By default, the framework shows the images of toolbar buttons but does not show the text label of toolbar buttons.  
  
 In Debug builds, this method generates an assertion failure if <CodeContentPlaceHolder>613\</CodeContentPlaceHolder> does not refer to a valid toolbar button or the toolbar button is a separator.  
  
##  \<a name="cmfctoolbar__settworowswithsibling">\</a>  CMFCToolBar::SetTwoRowsWithSibling  
 Positions the toolbar and its sibling on separate rows.  
  
<CodeContentPlaceHolder>163\</CodeContentPlaceHolder>  
### Remarks  
 The framework calls this method when the user clicks the **Show Buttons on Two Rows** button.  
  
 Call the [CMFCToolBar::SetSiblingToolBar](#cmfctoolbar__setsiblingtoolbar) method to enable the **Show Buttons on One Row** or **Show Buttons on Two Rows** buttons. If you call [CMFCToolBar::SetSiblingToolBar](#cmfctoolbar__setsiblingtoolbar) for this toolbar, the sibling toolbar is moved to a separate row. Otherwise, this toolbar is moved to a separate row.  
  
 The framework calls the [CMFCToolBar::SetOneRowWithSibling](#cmfctoolbar__setonerowwithsibling) method when the user clicks the **Show Buttons on One Row** button.  
  
##  \<a name="cmfctoolbar__setuserimages">\</a>  CMFCToolBar::SetUserImages  
 Sets the collection of user-defined images in the application.  
  
<CodeContentPlaceHolder>164\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>614\</CodeContentPlaceHolder>  
 A pointer to the collection of user-defined images.  
  
### Return Value  
 Nonzero if the method succeeds; otherwise 0 if the specified <CodeContentPlaceHolder>615\</CodeContentPlaceHolder> object is not valid or has an image size that differs from the default image size of the toolbar.  
  
### Remarks  
 The framework uses user-defined images to draw toolbar buttons that are customized by the user. The image list specified by <CodeContentPlaceHolder>616\</CodeContentPlaceHolder> is shared among all toolbars in the application.  
  
 This method generates an assertion failure in Debug builds if the specified <CodeContentPlaceHolder>617\</CodeContentPlaceHolder> object is not valid or has an image size that differs from the default image size of the toolbar.  
  
 The OutlookDemo, ToolTipDemo, and VisualStudioDemo samples use this method to set the global collection of user-defined images. They load the file that is named UserImages.bmp, which is located in the working directory of the application.  
  
 Call the [CMFCToolBar::GetUserImages](#cmfctoolbar__getuserimages) method to retrieve the collection of user-defined images in the application.  
  
##  \<a name="cmfctoolbar__stretchpane">\</a>  CMFCToolBar::StretchPane  
 Stretches the toolbar vertically or horizontally, and repositions the buttons if necessary.  
  
<CodeContentPlaceHolder>165\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>618\</CodeContentPlaceHolder>  
 The amount, in pixels, by which to stretch the pane.  
  
 [in] <CodeContentPlaceHolder>619\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>620\</CodeContentPlaceHolder>, stretches the pane vertically. If <CodeContentPlaceHolder>621\</CodeContentPlaceHolder>, stretches the pane horizontally.  
  
### Return Value  
 A <CodeContentPlaceHolder>622\</CodeContentPlaceHolder> object that specifies the size of the toolbar client area.  
  
### Remarks  
 This method calls [CMFCToolBar::WrapToolBar](#cmfctoolbar__wraptoolbar) to reposition the buttons within the stretched toolbar.  
  
 The return value is determined by calling [CMFCToolBar::CalcSize](#cmfctoolbar__calcsize).  
  
##  \<a name="cmfctoolbar__translatechar">\</a>  CMFCToolBar::TranslateChar  
 Executes a button command if the specified key code corresponds to a valid keyboard shortcut.  
  
<CodeContentPlaceHolder>166\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>623\</CodeContentPlaceHolder>  
 Specifies a virtual key code. For a list of standard virtual key codes, see Winuser.h  
  
### Return Value  
 <CodeContentPlaceHolder>624\</CodeContentPlaceHolder> if the specified key code is either unprintable or does not correspond to a valid keyboard shortcut; <CodeContentPlaceHolder>625\</CodeContentPlaceHolder> if the specified key code corresponds to a drop-down menu option; otherwise, the return value from [CMFCToolBar::ProcessCommand](#cmfctoolbar__processcommand).  
  
### Remarks  
 The framework calls this method when a key is pressed together with the Alt key.  
  
##  \<a name="cmfctoolbar__updatebutton">\</a>  CMFCToolBar::UpdateButton  
 Updates the state of the specified button.  
  
<CodeContentPlaceHolder>167\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>626\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the button to update.  
  
### Remarks  
  
##  \<a name="cmfctoolbar__wraptoolbar">\</a>  CMFCToolBar::WrapToolBar  
 Repositions toolbar buttons within the given dimensions.  
  
<CodeContentPlaceHolder>168\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>627\</CodeContentPlaceHolder>  
 Maximum width of the toolbar.  
  
 [in] <CodeContentPlaceHolder>628\</CodeContentPlaceHolder>  
 Maximum height of the toolbar. Not used if the toolbar is floating.  
  
 [in] <CodeContentPlaceHolder>629\</CodeContentPlaceHolder>  
 Pointer to a device context. If NULL, the device context for the toolbar is used.  
  
 [in] <CodeContentPlaceHolder>630\</CodeContentPlaceHolder>  
 Button width. If -1, the current width is used.  
  
 [in] m <CodeContentPlaceHolder>631\</CodeContentPlaceHolder>  
 Button height. If -1, the current height is used.  
  
### Return Value  
 The number of rows of buttons on the toolbar.  
  
### Remarks  
 This method repositions buttons within the toolbar, wrapping buttons to additional rows if necessary.  
  
##  \<a name="cmfctoolbar__m_bdontscaleimages">\</a>  CMFCToolBar::m_bDontScaleImages  
 Specifies whether or not to scale toolbar images in high DPI mode.  
  
<CodeContentPlaceHolder>169\</CodeContentPlaceHolder>  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCMenuBar](../vs140/cmfcmenubar-class.md)   
 [CMFCPopupMenuBar](../vs140/cmfcpopupmenubar-class.md)   
 [CMFCDropDownToolBar](../vs140/cmfcdropdowntoolbar-class.md)   
 [How to Put Controls on Toolbars](../vs140/walkthrough--putting-controls-on-toolbars.md)