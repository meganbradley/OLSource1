---
title: "CMFCVisualManager Class"
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
  - "CMFCVisualManager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCVisualManager class"
ms.assetid: beed80f7-36a2-4d64-9f09-e807cfefc3fe
caps.latest.revision: 57
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager Class
Provides support for changing the appearance of your application at a global level. The <CodeContentPlaceHolder>206\</CodeContentPlaceHolder> class works together with a class that provides instructions to draw the GUI controls of your application using a consistent style. These other classes are referred to as visual managers and they inherit from <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>208\</CodeContentPlaceHolder>|Default constructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCVisualManager::AdjustFrames](#cmfcvisualmanager__adjustframes)||  
|[CMFCVisualManager::AdjustToolbars](#cmfcvisualmanager__adjusttoolbars)||  
|[CMFCVisualManager::AlwaysHighlight3DTabs](#cmfcvisualmanager__alwayshighlight3dtabs)|Called by the framework to determine whether 3D tabs should always be drawn by using a highlight color.|  
|[CMFCVisualManager::DestroyInstance](#cmfcvisualmanager__destroyinstance)||  
|[CMFCVisualManager::DoDrawHeaderSortArrow](#cmfcvisualmanager__dodrawheadersortarrow)||  
|[CMFCVisualManager::DrawComboDropButtonWinXP](#cmfcvisualmanager__drawcombodropbuttonwinxp)||  
|[CMFCVisualManager::DrawPushButtonWinXP](#cmfcvisualmanager__drawpushbuttonwinxp)||  
|[CMFCVisualManager::DrawTextOnGlass](#cmfcvisualmanager__drawtextonglass)||  
|[CMFCVisualManager::GetAutoHideButtonTextColor](#cmfcvisualmanager__getautohidebuttontextcolor)|Called by the framework to retrieve the text color for an auto-hide button.|  
|[CMFCVisualManager::GetButtonExtraBorder](#cmfcvisualmanager__getbuttonextraborder)|Called by the framework to retrieve the increased button size that the current visual manager requires to draw a button.|  
|[CMFCVisualManager::GetCaptionBarTextColor](#cmfcvisualmanager__getcaptionbartextcolor)|Called by the framework to retrieve the text color of a caption bar.|  
|[CMFCVisualManager::GetDockingTabsBordersSize](#cmfcvisualmanager__getdockingtabsborderssize)|Called by the framework to retrieve the size for the border of a docked tabbed bar.|  
|[CMFCVisualManager::GetHighlightedMenuItemTextColor](#cmfcvisualmanager__gethighlightedmenuitemtextcolor)||  
|[CMFCVisualManager::GetInstance](#cmfcvisualmanager__getinstance)|Returns a pointer to the <CodeContentPlaceHolder>209\</CodeContentPlaceHolder> object.|  
|[CMFCVisualManager::GetMDITabsBordersSize](#cmfcvisualmanager__getmditabsborderssize)|Called by the framework to retrieve the border size of the MDITabs window.|  
|[CMFCVisualManager::GetMenuItemTextColor](#cmfcvisualmanager__getmenuitemtextcolor)||  
|[CMFCVisualManager::GetMenuShadowDepth](#cmfcvisualmanager__getmenushadowdepth)|Returns a value that determines the width and height of a menu shadow.|  
|[CMFCVisualManager::GetNcBtnSize](#cmfcvisualmanager__getncbtnsize)|Called by the framework to determine the size of the system buttons based on the current visual manager. The system buttons are the buttons in the caption of the main frame that map to the commands **Close**, **Minimize**, **Maximize**, and **Restore**.|  
|[CMFCVisualManager::GetPopupMenuBorderSize](#cmfcvisualmanager__getpopupmenubordersize)|Called by the framework to retrieve the size of the border for a popup menu.|  
|[CMFCVisualManager::GetPropListGridGroupColor](#cmfcvisualmanager__getpropertygridgroupcolor)|Called by the framework to retrieve the background color of a property list.|  
|[CMFCVisualManager::GetPropListGridGroupTextColor](#cmfcvisualmanager__getpropertygridgrouptextcolor)|Called by the framework to retrieve the text color of a property list.|  
|[CMFCVisualManager::GetRibbonHyperlinkTextColor](#cmfcvisualmanager__getribbonhyperlinktextcolor)||  
|[CMFCVisualManager::GetRibbonPopupBorderSize](#cmfcvisualmanager__getribbonpopupbordersize)||  
|[CMFCVisualManager::GetRibbonQuickAccessToolBarTextColor](#cmfcvisualmanager__getribbonquickaccesstoolbartextcolor)||  
|[CMFCVisualManager::GetRibbonSliderColors](#cmfcvisualmanager__getribbonslidercolors)||  
|[CMFCVisualManager::GetShowAllMenuItemsHeight](#cmfcvisualmanager__getshowallmenuitemsheight)||  
|[CMFCVisualManager::GetSmartDockingBaseGuideColors](#cmfcvisualmanager__getsmartdockingbaseguidecolors)||  
|[CMFCVisualManager::GetSmartDockingHighlightToneColor](#cmfcvisualmanager__getsmartdockinghighlighttonecolor)||  
|[CMFCVisualManager::GetSmartDockingTheme](#cmfcvisualmanager__getsmartdockingtheme)|Returns a theme used to display smart docking markers.|  
|[CMFCVisualManager::GetStatusBarPaneTextColor](#cmfcvisualmanager__getstatusbarpanetextcolor)||  
|[CMFCVisualManager::GetTabFrameColors](#cmfcvisualmanager__gettabframecolors)|Called by the framework to retrieve the set of colors to use when it draws a tab frame.|  
|[CMFCVisualManager::GetTabTextColor](#cmfcvisualmanager__gettabtextcolor)||  
|[CMFCVisualManager::GetToolbarButtonTextColor](#cmfcvisualmanager__gettoolbarbuttontextcolor)|Called by the framework to retrieve the current color of the text on the toolbar button. This color varies based on the current visual manager and the button state.|  
|[CMFCVisualManager::GetToolbarDisabledTextColor](#cmfcvisualmanager__gettoolbardisabledtextcolor)|Called by the framework to determine the color of the text that is displayed on disabled toolbar elements.|  
|[CMFCVisualManager::GetToolbarHighlightColor](#cmfcvisualmanager__gettoolbarhighlightcolor)||  
|[CMFCVisualManager::GetToolTipInfo](#cmfcvisualmanager__gettooltipinfo)||  
|[CMFCVisualManager::HasOverlappedAutoHideButtons](#cmfcvisualmanager__hasoverlappedautohidebuttons)|Specifies whether auto-hide buttons overlap.|  
|[CMFCVisualManager::IsDockingTabHasBorder](#cmfcvisualmanager__isdockingtabhasborder)|Specifies whether the current visual manager draws a border around tabbed docking bars.|  
|[CMFCVisualManager::IsEmbossDisabledImage](#cmfcvisualmanager__isembossdisabledimage)|Specifies whether disabled images should be embossed.|  
|[CMFCVisualManager::IsFadeInactiveImage](#cmfcvisualmanager__isfadeinactiveimage)|Called by the framework to determine whether inactive images on a toolbar or menu appear dimmed.|  
|[CMFCVisualManager::IsMenuFlatLook](#cmfcvisualmanager__ismenuflatlook)|Specifies whether menu buttons have a flattened appearance.|  
|[CMFCVisualManager::IsOfficeXPStyleMenus](#cmfcvisualmanager__isofficexpstylemenus)|Specifies whether the visual manager implements Office XP-style menus.|  
|[CMFCVisualManager::IsOwnerDrawCaption](#cmfcvisualmanager__isownerdrawcaption)|Specifies whether the current visual manager implements owner-drawn captions of a frame window.|  
|[CMFCVisualManager::IsShadowHighlightedImage](#cmfcvisualmanager__isshadowhighlightedimage)|Specifies whether a highlighted image has a shadow.|  
|[CMFCVisualManager::OnDrawAutoHideButtonBorder](#cmfcvisualmanager__ondrawautohidebuttonborder)|Called by the framework when it draws the border for an auto-hide button.|  
|[CMFCVisualManager::OnDrawBarGripper](#cmfcvisualmanager__ondrawbargripper)|Called by the framework when it draws the gripper of a control bar. The user must click the gripper in order to move the control bar.|  
|[CMFCVisualManager::OnDrawBrowseButton](#cmfcvisualmanager__ondrawbrowsebutton)|Called by the framework when it draws a browse button that belongs to an edit control ( [CMFCEditBrowseCtrl Class](../vs140/cmfceditbrowsectrl-class.md)).|  
|[CMFCVisualManager::OnDrawButtonBorder](#cmfcvisualmanager__ondrawbuttonborder)|Called by the framework when it draws the border of a toolbar button.|  
|[CMFCVisualManager::OnDrawButtonSeparator](#cmfcvisualmanager__ondrawbuttonseparator)||  
|[CMFCVisualManager::OnDrawCaptionBarBorder](#cmfcvisualmanager__ondrawcaptionbarborder)|Called by the framework when it draws the caption bar border.|  
|[CMFCVisualManager::OnDrawCaptionBarButtonBorder](#cmfcvisualmanager__ondrawcaptionbarbuttonborder)||  
|[CMFCVisualManager::OnDrawCaptionBarInfoArea](#cmfcvisualmanager__ondrawcaptionbarinfoarea)||  
|[CMFCVisualManager::OnDrawCaptionButton](#cmfcvisualmanager__ondrawcaptionbutton)|Called by the framework when it draws a caption button.|  
|[CMFCVisualManager::OnDrawCheckBox](#cmfcvisualmanager__ondrawcheckbox)||  
|[CMFCVisualManager::OnDrawCheckBoxEx](#cmfcvisualmanager__ondrawcheckboxex)||  
|[CMFCVisualManager::OnDrawComboBorder](#cmfcvisualmanager__ondrawcomboborder)|Called by the framework when it draws the border of a combo box button.|  
|[CMFCVisualManager::OnDrawComboDropButton](#cmfcvisualmanager__ondrawcombodropbutton)|Called by the framework when it draws a combo box drop button.|  
|[CMFCVisualManager::OnDrawControlBorder](#cmfcvisualmanager__ondrawcontrolborder)||  
|[CMFCVisualManager::OnDrawDefaultRibbonImage](#cmfcvisualmanager__ondrawdefaultribbonimage)|Called by the framework when it draws the default ribbon image.|  
|[CMFCVisualManager::OnDrawEditBorder](#cmfcvisualmanager__ondraweditborder)|Called by the framework when it draws a border around a [CMFCToolBarEditBoxButton](../vs140/cmfctoolbareditboxbutton-class.md) object.|  
|[CMFCVisualManager::OnDrawExpandingBox](#cmfcvisualmanager__ondrawexpandingbox)||  
|[CMFCVisualManager::OnDrawFloatingToolbarBorder](#cmfcvisualmanager__ondrawfloatingtoolbarborder)|Called by the framework when it draws the borders of a floating toolbar. The floating toolbar is a toolbar that appears as a mini-frame window.|  
|[CMFCVisualManager::OnDrawHeaderCtrlBorder](#cmfcvisualmanager__ondrawheaderctrlborder)|Called by the framework when it draws the border that contains the header control.|  
|[CMFCVisualManager::OnDrawHeaderCtrlSortArrow](#cmfcvisualmanager__ondrawheaderctrlsortarrow)|Called by the framework when it draws the header control sort arrow.|  
|[CMFCVisualManager::OnDrawMenuArrowOnCustomizeList](#cmfcvisualmanager__ondrawmenuarrowoncustomizelist)||  
|[CMFCVisualManager::OnDrawMenuBorder](#cmfcvisualmanager__ondrawmenuborder)|Called by the framework when it draws a menu border.|  
|[CMFCVisualManager::OnDrawMenuCheck](#cmfcvisualmanager__ondrawmenucheck)||  
|[CMFCVisualManager::OnDrawMenuItemButton](#cmfcvisualmanager__ondrawmenuitembutton)||  
|[CMFCVisualManager::OnDrawMenuLabel](#cmfcvisualmanager__ondrawmenulabel)||  
|[CMFCVisualManager::OnDrawMenuResizeBar](#cmfcvisualmanager__ondrawmenuresizebar)||  
|[CMFCVisualManager::OnDrawMenuScrollButton](#cmfcvisualmanager__ondrawmenuscrollbutton)|Called by the framework when it draws a menu scroll button.|  
|[CMFCVisualManager::OnDrawMenuShadow](#cmfcvisualmanager__ondrawmenushadow)||  
|[CMFCVisualManager::OnDrawMenuSystemButton](#cmfcvisualmanager__ondrawmenusystembutton)|Called by the framework when it draws the menu system buttons **Close**, **Minimize**, **Maximize**, and **Restore**.|  
|[CMFCVisualManager::OnDrawMiniFrameBorder](#cmfcvisualmanager__ondrawminiframeborder)||  
|[CMFCVisualManager::OnDrawOutlookBarSplitter](#cmfcvisualmanager__ondrawoutlookbarsplitter)|Called by the framework when it draws the splitter for an Outlook bar. The splitter is a horizontal bar used to group controls.|  
|[CMFCVisualManager::OnDrawOutlookPageButtonBorder](#cmfcvisualmanager__ondrawoutlookpagebuttonborder)|Called by the framework when it draws the border of an Outlook page button. Outlook page buttons appear if the Outlook bar pane contains more buttons than it can display.|  
|[CMFCVisualManager::OnDrawPaneBorder](#cmfcvisualmanager__ondrawpaneborder)|Called by the framework when it draws the border of a [CPane Class](../vs140/cpane-class.md).|  
|[CMFCVisualManager::OnDrawPaneCaption](#cmfcvisualmanager__ondrawpanecaption)|Called by the framework when it draws the caption for a <CodeContentPlaceHolder>210\</CodeContentPlaceHolder>.|  
|[CMFCVisualManager::OnDrawPaneDivider](#cmfcvisualmanager__ondrawpanedivider)||  
|[CMFCVisualManager::OnDrawPopupWindowBorder](#cmfcvisualmanager__ondrawpopupwindowborder)||  
|[CMFCVisualManager::OnDrawPopupWindowButtonBorder](#cmfcvisualmanager__ondrawpopupwindowbuttonborder)||  
|[CMFCVisualManager::OnDrawPopupWindowCaption](#cmfcvisualmanager__ondrawpopupwindowcaption)||  
|[CMFCVisualManager::OnDrawRibbonApplicationButton](#cmfcvisualmanager__ondrawribbonapplicationbutton)|Called by the framework when it draws the **Main Button** on the ribbon.|  
|[CMFCVisualManager::OnDrawRibbonButtonBorder](#cmfcvisualmanager__ondrawribbonbuttonborder)|Called by the framework when it draws the border of a ribbon button.|  
|[CMFCVisualManager::OnDrawRibbonButtonsGroup](#cmfcvisualmanager__ondrawribbonbuttonsgroup)|Called by the framework when it draws a group of buttons on the ribbon.|  
|[CMFCVisualManager::OnDrawRibbonCaption](#cmfcvisualmanager__ondrawribboncaption)|Called by the framework when it draws the caption of the main frame, but only if the ribbon bar is integrated with the frame.|  
|[CMFCVisualManager::OnDrawRibbonCaptionButton](#cmfcvisualmanager__ondrawribboncaptionbutton)|Called by the framework when it draws a caption button located on the ribbon bar.|  
|[CMFCVisualManager::OnDrawRibbonCategory](#cmfcvisualmanager__ondrawribboncategory)|Called by the framework when it draws a ribbon category.|  
|[CMFCVisualManager::OnDrawRibbonCategoryCaption](#cmfcvisualmanager__ondrawribboncategorycaption)|Called by the framework when it draws the caption for a ribbon category.|  
|[CMFCVisualManager::OnDrawRibbonCategoryScroll](#cmfcvisualmanager__ondrawribboncategoryscroll)||  
|[CMFCVisualManager::OnDrawRibbonCategoryTab](#cmfcvisualmanager__ondrawribboncategorytab)|Called by the framework when it draws the tab for a ribbon category.|  
|[CMFCVisualManager::OnDrawRibbonCheckBoxOnList](#cmfcvisualmanager__ondrawribboncheckboxonlist)||  
|[CMFCVisualManager::OnDrawRibbonColorPaletteBox](#cmfcvisualmanager__ondrawribboncolorpalettebox)||  
|[CMFCVisualManager::OnDrawRibbonDefaultPaneButtonContext](#cmfcvisualmanager__ondrawribbondefaultpanebuttoncontext)||  
|[CMFCVisualManager::OnDrawRibbonDefaultPaneButton](#cmfcvisualmanager__ondrawribbondefaultpanebutton)|Called by the framework when it draws the ribbon pane default button. The default button appears when the user shrinks a ribbon panel so that it is too small to display the ribbon elements. The default button is drawn instead and the ribbon elements are added as items on a drop down menu.|  
|[CMFCVisualManager::OnDrawRibbonDefaultPaneButtonIndicator](#cmfcvisualmanager__ondrawribbondefaultpanebuttonindicator)||  
|[CMFCVisualManager::OnDrawRibbonGalleryBorder](#cmfcvisualmanager__ondrawribbongalleryborder)||  
|[CMFCVisualManager::OnDrawRibbonGalleryButton](#cmfcvisualmanager__ondrawribbongallerybutton)||  
|[CMFCVisualManager::OnDrawRibbonKeyTip](#cmfcvisualmanager__ondrawribbonkeytip)||  
|[CMFCVisualManager::OnDrawRibbonLabel](#cmfcvisualmanager__ondrawribbonlabel)|Called by the framework when it draws the ribbon label.|  
|[CMFCVisualManager::OnDrawRibbonMainPanelButtonBorder](#cmfcvisualmanager__ondrawribbonmainpanelbuttonborder)|Called by the framework when it draws the border of a ribbon button that is positioned on the **Main** panel. The **Main** panel is the panel that appears when a user clicks the **Main Button**.|  
|[CMFCVisualManager::OnDrawRibbonMainPanelFrame](#cmfcvisualmanager__ondrawribbonmainpanelframe)|Called by the framework when it draws the frame around the **Main** panel.|  
|[CMFCVisualManager::OnDrawRibbonMenuCheckFrame](#cmfcvisualmanager__ondrawribbonmenucheckframe)||  
|[CMFCVisualManager::OnDrawRibbonPanel](#cmfcvisualmanager__ondrawribbonpanel)|Called by the framework when it draws a ribbon panel.|  
|[CMFCVisualManager::OnDrawRibbonPanelCaption](#cmfcvisualmanager__ondrawribbonpanelcaption)|Called by the framework when it draws the caption of a ribbon panel.|  
|[CMFCVisualManager::OnDrawRibbonProgressBar](#cmfcvisualmanager__ondrawribbonprogressbar)|Called by the framework when it draws a [CMFCRibbonProgressBar](../vs140/cmfcribbonprogressbar-class.md) object.|  
|[CMFCVisualManager::OnDrawRibbonQuickAccessToolbarSeparator](#cmfcvisualmanager__ondrawribbonquickaccesstoolbarseparator)|Called by the framework when it draws a separator on a ribbon's **Quick Access Toolbar**.|  
|[CMFCVisualManager::OnDrawRibbonRecentFilesFrame](#cmfcvisualmanager__ondrawribbonrecentfilesframe)|Called by the framework when it draws a frame around a recent files list.|  
|[CMFCVisualManager::OnDrawRibbonSliderChannel](#cmfcvisualmanager__ondrawribbonsliderchannel)|Called by the framework when it draws the channel of a [CMFCRibbonSlider](../vs140/cmfcribbonslider-class.md) object.|  
|[CMFCVisualManager::OnDrawRibbonSliderThumb](#cmfcvisualmanager__ondrawribbonsliderthumb)|Called by the framework when it draws the thumb of a <CodeContentPlaceHolder>211\</CodeContentPlaceHolder> object.|  
|[CMFCVisualManager::OnDrawRibbonSliderZoomButton](#cmfcvisualmanager__ondrawribbonsliderzoombutton)|Called by the framework when it draws the zoom buttons of a <CodeContentPlaceHolder>212\</CodeContentPlaceHolder> object.|  
|[CMFCVisualManager::OnDrawRibbonStatusBarPane](#cmfcvisualmanager__ondrawribbonstatusbarpane)|Called by the framework when it draws the status-bar pane of a ribbon.|  
|[CMFCVisualManager::OnDrawRibbonTabsFrame](#cmfcvisualmanager__ondrawribbontabsframe)|Called by the framework when it draws a frame around a set of ribbon tabs.|  
|[CMFCVisualManager::OnDrawScrollButtons](#cmfcvisualmanager__ondrawscrollbuttons)||  
|[CMFCVisualManager::OnDrawSeparator](#cmfcvisualmanager__ondrawseparator)|Called by the framework when it draws a separator. The separator is typically used on a control bar to separate groups of icons.|  
|[CMFCVisualManager::OnDrawShowAllMenuItems](#cmfcvisualmanager__ondrawshowallmenuitems)||  
|[CMFCVisualManager::OnDrawSpinButtons](#cmfcvisualmanager__ondrawspinbuttons)|Called by the framework when it draws spin buttons.|  
|[CMFCVisualManager::OnDrawSplitterBorder](#cmfcvisualmanager__ondrawsplitterborder)|Called by the framework when it draws the border of a split window.|  
|[CMFCVisualManager::OnDrawSplitterBox](#cmfcvisualmanager__ondrawsplitterbox)|Called by the framework when it draws the splitter drag box for a split window.|  
|[CMFCVisualManager::OnDrawStatusBarPaneBorder](#cmfcvisualmanager__ondrawstatusbarpaneborder)|Called by the framework when it draws the border for a status-bar pane.|  
|[CMFCVisualManager::OnDrawStatusBarProgress](#cmfcvisualmanager__ondrawstatusbarprogress)|Called by the framework when it draws the status-bar progress indicator.|  
|[CMFCVisualManager::OnDrawStatusBarSizeBox](#cmfcvisualmanager__ondrawstatusbarsizebox)|Called by the framework when it draws the status-bar size box.|  
|[CMFCVisualManager::OnDrawTab](#cmfcvisualmanager__ondrawtab)|Called by the framework when it draws a [CMFCTabCtrl](../vs140/cmfctabctrl-class.md) object.|  
|[CMFCVisualManager::OnDrawTabCloseButton](#cmfcvisualmanager__ondrawtabclosebutton)|Called by the framework when it draws the **Close** button on the active tab.|  
|[CMFCVisualManager::OnDrawTabContent](#cmfcvisualmanager__ondrawtabcontent)|Called by the framework when it draws the tab interior (images, texts).|  
|[CMFCVisualManager::OnDrawTabsButtonBorder](#cmfcvisualmanager__ondrawtabsbuttonborder)|Called by the framework when it draws the border of a tab button.|  
|[CMFCVisualManager::OnDrawTask](#cmfcvisualmanager__ondrawtask)|Called by the framework when it draws a task on the task pane.|  
|[CMFCVisualManager::OnDrawTasksGroupAreaBorder](#cmfcvisualmanager__ondrawtasksgroupareaborder)|Called by the framework when it draws a border around a group area on the task pane.|  
|[CMFCVisualManager::OnDrawTasksGroupCaption](#cmfcvisualmanager__ondrawtasksgroupcaption)|Called by the framework when it draws the caption for a task group on the task pane.|  
|[CMFCVisualManager::OnDrawTasksGroupIcon](#cmfcvisualmanager__ondrawtasksgroupicon)||  
|[CMFCVisualManager::OnDrawTearOffCaption](#cmfcvisualmanager__ondrawtearoffcaption)|Called by the framework when it draws the tear-off caption for a tear-off bar.|  
|[CMFCVisualManager::OnDrawToolBoxFrame](#cmfcvisualmanager__ondrawtoolboxframe)||  
|[CMFCVisualManager::OnEraseMDIClientArea](#cmfcvisualmanager__onerasemdiclientarea)|Called by the framework when it erases the MDI client area.|  
|[CMFCVisualManager::OnErasePopupWindowButton](#cmfcvisualmanager__onerasepopupwindowbutton)||  
|[CMFCVisualManager::OnEraseTabsArea](#cmfcvisualmanager__onerasetabsarea)|Called by the framework when it erases the tab area in a tab window.|  
|[CMFCVisualManager::OnEraseTabsButton](#cmfcvisualmanager__onerasetabsbutton)|Called by the framework when it erases the icon and text of a tab button.|  
|[CMFCVisualManager::OnEraseTabsFrame](#cmfcvisualmanager__onerasetabsframe)|Called by the framework when it erases a tab frame.|  
|[CMFCVisualManager::OnFillAutoHideButtonBackground](#cmfcvisualmanager__onfillautohidebuttonbackground)|Called by the framework when it fills the background of an auto-hide button.|  
|[CMFCVisualManager::OnFillBarBackground](#cmfcvisualmanager__onfillbarbackground)|Called by the framework when it fills the background of a control bar.|  
|[CMFCVisualManager::OnFillButtonInterior](#cmfcvisualmanager__onfillbuttoninterior)|Called by the framework when it fills the background of a toolbar button.|  
|[CMFCVisualManager::OnFillCaptionBarButton](#cmfcvisualmanager__onfillcaptionbarbutton)||  
|[CMFCVisualManager::OnFillCommandsListBackground](#cmfcvisualmanager__onfillcommandslistbackground)|Called by the framework when it fills the background of a toolbar button that belongs to a command list that, in turn, is part of a customization dialog box.|  
|[CMFCVisualManager::OnFillHeaderCtrlBackground](#cmfcvisualmanager__onfillheaderctrlbackground)|Called by the framework when it fills the background of a header control.|  
|[CMFCVisualManager::OnFillMiniFrameCaption](#cmfcvisualmanager__onfillminiframecaption)|Called by the framework when it fills the caption of a mini frame window.|  
|[CMFCVisualManager::OnFillOutlookBarCaption](#cmfcvisualmanager__onfilloutlookbarcaption)|Called by the framework when it fills the background of an Outlook bar caption.|  
|[CMFCVisualManager::OnFillOutlookPageButton](#cmfcvisualmanager__onfilloutlookpagebutton)|Called by the framework when it fills the interior of an Outlook page button.|  
|[CMFCVisualManager::OnFillPopupWindowBackground](#cmfcvisualmanager__onfillpopupwindowbackground)|Called by the framework when it fills the background of a popup window.|  
|[CMFCVisualManager::OnFillRibbonButton](#cmfcvisualmanager__onfillribbonbutton)|Called by the framework when it fills the interior of a ribbon button.|  
|[CMFCVisualManager::OnFillRibbonEdit](#cmfcvisualmanager__onfillribbonedit)|Called by the framework when it fills the interior of a ribbon edit control.|  
|[CMFCVisualManager::OnFillRibbonMainPanelButton](#cmfcvisualmanager__onfillribbonmainpanelbutton)|Called by the framework when it fills the interior of a ribbon button located on the **Main** panel.|  
|[CMFCVisualManager::OnFillRibbonMenuFrame](#cmfcvisualmanager__onfillribbonmenuframe)|Called by the framework when it fills the menu frame of the main ribbon panel.|  
|[CMFCVisualManager::OnFillRibbonQuickAccessToolBarPopup](#cmfcvisualmanager__onfillribbonquickaccesstoolbarpopup)||  
|[CMFCVisualManager::OnFillSplitterBackground](#cmfcvisualmanager__onfillsplitterbackground)|Called by the framework when it fills the background of a split window.|  
|[CMFCVisualManager::OnFillTab](#cmfcvisualmanager__onfilltab)|Called by the framework when it fills the background of a tab.|  
|[CMFCVisualManager::OnFillTasksGroupInterior](#cmfcvisualmanager__onfilltasksgroupinterior)|Called by the framework when it fills the interior of a [CMFCTasksPaneTaskGroup](../vs140/cmfctaskspanetaskgroup-class.md) object on the [CMFCTasksPane](../vs140/cmfctaskspane-class.md).|  
|[CMFCVisualManager::OnFillTasksPaneBackground](#cmfcvisualmanager__onfilltaskspanebackground)|Called by the framework when it fills the background of a <CodeContentPlaceHolder>213\</CodeContentPlaceHolder> control.|  
|[CMFCVisualManager::OnHighlightMenuItem](#cmfcvisualmanager__onhighlightmenuitem)|Called by the framework when it draws a highlighted menu item.|  
|[CMFCVisualManager::OnHighlightRarelyUsedMenuItems](#cmfcvisualmanager__onhighlightrarelyusedmenuitems)|Called by the framework when it draws a highlighted and rarely used menu item.|  
|[CMFCVisualManager::OnNcPaint](#cmfcvisualmanager__onncpaint)|Called by the framework when it draws the non-client area.|  
|[CMFCVisualManager::OnSetWindowRegion](#cmfcvisualmanager__onsetwindowregion)|Called by the framework when it sets a region that contains frames and popup menus.|  
|[CMFCVisualManager::OnUpdateSystemColors](#cmfcvisualmanager__onupdatesystemcolors)|Called by the framework when it changes the system color setting.|  
|[CMFCVisualManager::RedrawAll](#cmfcvisualmanager__redrawall)|Redraws all control bars in the application.|  
|[CMFCVisualManager::RibbonCategoryColorToRGB](#cmfcvisualmanager__ribboncategorycolortorgb)||  
|[CMFCVisualManager::SetDefaultManager](#cmfcvisualmanager__setdefaultmanager)|Sets the default visual manager.|  
|[CMFCVisualManager::SetEmbossDisabledImage](#cmfcvisualmanager__setembossdisabledimage)|Enables or disables the embossed mode for disabled toolbar images.|  
|[CMFCVisualManager::SetFadeInactiveImage](#cmfcvisualmanager__setfadeinactiveimage)|Enables or disables the lighting effect for inactive images on a menu or toolbar.|  
|[CMFCVisualManager::SetMenuFlatLook](#cmfcvisualmanager__setmenuflatlook)|Sets a flag indicating whether the application menu buttons have a flattened appearance.|  
|[CMFCVisualManager::SetMenuShadowDepth](#cmfcvisualmanager__setmenushadowdepth)|Sets the width and height of the menu shadow.|  
|[CMFCVisualManager::SetShadowHighlightedImage](#cmfcvisualmanager__setshadowhighlightedimage)|Sets a flag that indicates whether to display the shadow when rendering highlighted images.|  
  
## Remarks  
 Because the <CodeContentPlaceHolder>214\</CodeContentPlaceHolder> class controls the application's GUI, each application can have either one instance of a <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>, or one instance of a class derived from <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>. Your application can also function without a <CodeContentPlaceHolder>217\</CodeContentPlaceHolder>. Use the static method <CodeContentPlaceHolder>218\</CodeContentPlaceHolder> to obtain a pointer to the current <CodeContentPlaceHolder>219\</CodeContentPlaceHolder>-derived object.  
  
 To change the appearance of your application you must use other classes that provide methods for drawing all of the visual elements of your application. Some examples of these classes are [CMFCVisualManagerOfficeXP Class](../vs140/cmfcvisualmanagerofficexp-class.md), [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md), and [CMFCVisualManagerOffice2007 Class](../vs140/cmfcvisualmanageroffice2007-class.md). When you want to change the appearance of your application, pass one of these visual managers into the method <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>. For an example that demonstrates how your application can mimic the appearance of Microsoft Office 2003, see [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md).  
  
 All of the drawing methods are virtual. This enables you to create a custom visual style for the GUI of your application. If you want to create your own visual style, derive a class from one of the visual manager classes and override the drawing methods that you want to change.  
  
## Example  
 This sample demonstrates how to instantiate the standard and custom <CodeContentPlaceHolder>221\</CodeContentPlaceHolder> objects.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following example demonstrates how to retrieve the default values of a <CodeContentPlaceHolder>222\</CodeContentPlaceHolder> object. This code snippet is part of the [Tasks Pane sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_TasksPane#1](../vs140/codesnippet/CPP/cmfcvisualmanager-class_1.h)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMFCBaseVisualManager](../vs140/cmfcbasevisualmanager-class.md)  
  
 [CMFCVisualManager](../vs140/cmfcvisualmanager-class.md)  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
##  \<a name="cmfcvisualmanager__adjustframes">\</a>  CMFCVisualManager::AdjustFrames  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcvisualmanager__adjusttoolbars">\</a>  CMFCVisualManager::AdjustToolbars  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcvisualmanager__alwayshighlight3dtabs">\</a>  CMFCVisualManager::AlwaysHighlight3DTabs  
 The framework calls this method to determine whether 3D tabs should always be highlighted in the application.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>223\</CodeContentPlaceHolder> if 3D tabs should be highlighted.  
  
### Remarks  
 Override this function in a derived visual manager and return <CodeContentPlaceHolder>224\</CodeContentPlaceHolder> if 3D tabs should always be highlighted. The default implementation of this method returns <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcvisualmanager__cmfcvisualmanager">\</a>  CMFCVisualManager::CMFCVisualManager  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>226\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__destroyinstance">\</a>  CMFCVisualManager::DestroyInstance  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>227\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__dodrawheadersortarrow">\</a>  CMFCVisualManager::DoDrawHeaderSortArrow  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>228\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>229\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>230\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>231\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__drawcomboborderwinxp">\</a>  CMFCVisualManager::DrawComboBorderWinXP  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>232\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>233\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>234\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__drawcombodropbuttonwinxp">\</a>  CMFCVisualManager::DrawComboDropButtonWinXP  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>235\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>236\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>237\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__drawpushbuttonwinxp">\</a>  CMFCVisualManager::DrawPushButtonWinXP  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>238\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>239\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>240\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>241\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__drawtextonglass">\</a>  CMFCVisualManager::DrawTextOnGlass  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>242\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>243\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>244\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>245\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>246\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>247\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__enabletoolbarbuttonfill">\</a>  CMFCVisualManager::EnableToolbarButtonFill  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>248\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__getautohidebuttontextcolor">\</a>  CMFCVisualManager::GetAutoHideButtonTextColor  
 The framework calls this method to retrieve the text color of an auto-hide button.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>249\</CodeContentPlaceHolder>  
 A pointer to an auto-hide button.  
  
### Return Value  
 A                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) parameter that specifies the text color of <CodeContentPlaceHolder>250\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this method in a derived class to customize the text color of an auto-hide button in your application. To do this, return the color that you want your application to use as the text color.  
  
##  \<a name="cmfcvisualmanager__getbuttonextraborder">\</a>  CMFCVisualManager::GetButtonExtraBorder  
 The framework calls this method when it draws a toolbar button.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 A [CSize](../vs140/csize-class.md) object that contains the extra size of the border for toolbar buttons.  
  
### Remarks  
 Some skins have to extend the borders of toolbar buttons. Override this method in a custom visual manager to extend the borders of toolbar buttons in your application. The default implementation of this method returns an empty size.  
  
##  \<a name="cmfcvisualmanager__getcaptionbartextcolor">\</a>  CMFCVisualManager::GetCaptionBarTextColor  
 The framework calls this method to retrieve the color of the text in the caption bar.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>251\</CodeContentPlaceHolder>  
 A pointer to a caption bar.  
  
### Return Value  
 A                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) parameter that indicates the color of the text in <CodeContentPlaceHolder>252\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this method in your derived class to customize the text color for a caption bar. In your overridden method, return the desired color.  
  
##  \<a name="cmfcvisualmanager__getcaptionbuttonextraborder">\</a>  CMFCVisualManager::GetCaptionButtonExtraBorder  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__getdockingpanecaptionextraheight">\</a>  CMFCVisualManager::GetDockingPaneCaptionExtraHeight  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__getdockingtabsborderssize">\</a>  CMFCVisualManager::GetDockingTabsBordersSize  
 The framework calls this method when it draws a pane that is docked and tabbed.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
 An integer that indicates the border size of a pane that is docked and tabbed.  
  
### Remarks  
 A docked pane becomes tabbed when the user docks multiple panes to the same location in your application.  
  
 Override this method in a custom visual manager to change the border size of docked tabbed control bars. The default implementation returns -1.  
  
##  \<a name="cmfcvisualmanager__gethighlightedmenuitemtextcolor">\</a>  CMFCVisualManager::GetHighlightedMenuItemTextColor  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>253\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__getinstance">\</a>  CMFCVisualManager::GetInstance  
 Returns a pointer to the current [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md) object for the application.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to a <CodeContentPlaceHolder>254\</CodeContentPlaceHolder> object.  
  
### Remarks  
 An application can only have one <CodeContentPlaceHolder>255\</CodeContentPlaceHolder> object associated with it. This includes any object derived from the <CodeContentPlaceHolder>256\</CodeContentPlaceHolder> class. This method returns a pointer to the associated <CodeContentPlaceHolder>257\</CodeContentPlaceHolder> object. If the application does not have an associated <CodeContentPlaceHolder>258\</CodeContentPlaceHolder> object, this method will create one and associate it with the application.  
  
##  \<a name="cmfcvisualmanager__getmditabsborderssize">\</a>  CMFCVisualManager::GetMDITabsBordersSize  
 The framework calls this method to determine the border size of a MDITabs window before it draws the window.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 The border size of the MDITabs window.  
  
### Remarks  
 Override this function in a derived class to customize the border size of the MDITabs window.  
  
##  \<a name="cmfcvisualmanager__getmenuimagemargin">\</a>  CMFCVisualManager::GetMenuImageMargin  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__getmenuitemtextcolor">\</a>  CMFCVisualManager::GetMenuItemTextColor  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>259\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>260\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>261\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__getmenushadowdepth">\</a>  CMFCVisualManager::GetMenuShadowDepth  
 Retrieves the width and height of the menu shadow.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Return Value  
 The width and height of the menu shadow in pixels.  
  
### Remarks  
 The width and height of the menu shadow are equivalent. The default value is 7 pixels.  
  
##  \<a name="cmfcvisualmanager__getncbtnsize">\</a>  CMFCVisualManager::GetNcBtnSize  
 Called by the framework when it has to retrieve the size of the system buttons.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>262\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether <CodeContentPlaceHolder>263\</CodeContentPlaceHolder> should retrieve the size of a small or large system button. If <CodeContentPlaceHolder>264\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>265\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>266\</CodeContentPlaceHolder> returns the size of a small system button. Otherwise, it returns the size of a large system button.  
  
### Return Value  
 A [CSize](../vs140/csize-class.md) parameter that indicate the size of the system buttons.  
  
### Remarks  
 The system buttons are the buttons in the caption of the frame window that map to the commands **Close**, **Minimize**, **Maximize**, and **Restore**. The size of these buttons depends on the current visual manager. Override this method if you want to customize the size of the system buttons in your application.  
  
##  \<a name="cmfcvisualmanager__getpopupmenubordersize">\</a>  CMFCVisualManager::GetPopupMenuBorderSize  
 The framework calls this method to obtain the border size of pop-up menus.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
 An integer that specifies the border size of pop-up menus.  
  
### Remarks  
 Override this method to customize the border size of pop-up menus in your application.  
  
##  \<a name="cmfcvisualmanager__getpopupmenugap">\</a>  CMFCVisualManager::GetPopupMenuGap  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__getpropertygridgroupcolor">\</a>  CMFCVisualManager::GetPropertyGridGroupColor  
 The framework calls this method to get the background color of a property list.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>267\</CodeContentPlaceHolder>  
 A pointer to the property list that the framework is drawing.  
  
### Return Value  
 A                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) parameter that indicates the background color of <CodeContentPlaceHolder>268\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this function to customize the background color of a property list in your application.  
  
##  \<a name="cmfcvisualmanager__getpropertygridgrouptextcolor">\</a>  CMFCVisualManager::GetPropertyGridGroupTextColor  
 The framework calls this method to retrieve the text color of a property list.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>269\</CodeContentPlaceHolder>  
 A pointer to the property list.  
  
### Return Value  
 A                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) parameter that indicates the text color of the property list.  
  
### Remarks  
 Override this function to customize the text color of a property list in your application.  
  
##  \<a name="cmfcvisualmanager__getribbonhyperlinktextcolor">\</a>  CMFCVisualManager::GetRibbonHyperlinkTextColor  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>270\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__getribbonpopupbordersize">\</a>  CMFCVisualManager::GetRibbonPopupBorderSize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>271\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__getribbonquickaccesstoolbarchevronoffset">\</a>  CMFCVisualManager::GetRibbonQuickAccessToolBarChevronOffset  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__getribbonquickaccesstoolbarrightmargin">\</a>  CMFCVisualManager::GetRibbonQuickAccessToolBarRightMargin  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__getribbonquickaccesstoolbartextcolor">\</a>  CMFCVisualManager::GetRibbonQuickAccessToolBarTextColor  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>272\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__getribbonslidercolors">\</a>  CMFCVisualManager::GetRibbonSliderColors  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>273\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>274\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>275\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>276\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>277\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>278\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__getribbonstatusbartextcolor">\</a>  CMFCVisualManager::GetRibbonStatusBarTextColor  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>279\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__getshowallmenuitemsheight">\</a>  CMFCVisualManager::GetShowAllMenuItemsHeight  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>280\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>281\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__getsmartdockingbaseguidecolors">\</a>  CMFCVisualManager::GetSmartDockingBaseGuideColors  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>282\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>283\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__getsmartdockinghighlighttonecolor">\</a>  CMFCVisualManager::GetSmartDockingHighlightToneColor  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__getsmartdockingtheme">\</a>  CMFCVisualManager::GetSmartDockingTheme  
 Returns a theme used to display smart docking markers.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Return Value  
 Returns one of the following enumerated values: AFX_SDT_DEFAULT, AFX_SDT_VS2005, AFX_SDT_VS2008.  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__getstatusbarpanetextcolor">\</a>  CMFCVisualManager::GetStatusBarPaneTextColor  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>284\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>285\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__gettabframecolors">\</a>  CMFCVisualManager::GetTabFrameColors  
 The framework calls this function when it has to retrieve the set of colors for drawing a tab window.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>286\</CodeContentPlaceHolder>  
 A pointer to the tabbed window where the frame is drawing a tab.  
  
 [out] <CodeContentPlaceHolder>287\</CodeContentPlaceHolder>  
 A reference to a                                 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) parameter where this method stores the color for the dark border of a tab.  
  
 [out] <CodeContentPlaceHolder>288\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>289\</CodeContentPlaceHolder> parameter where this method stores the color for the border of the tab window. The default color for the border is black.  
  
 [out] <CodeContentPlaceHolder>290\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>291\</CodeContentPlaceHolder> parameter where this method stores the color for the highlight state of the tab window.  
  
 [out] <CodeContentPlaceHolder>292\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>293\</CodeContentPlaceHolder> parameter where this method stores the color for face of the tab window.  
  
 [out] <CodeContentPlaceHolder>294\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>295\</CodeContentPlaceHolder> parameter where this method stores the color for the shadow of the tab window.  
  
 [out] <CodeContentPlaceHolder>296\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>297\</CodeContentPlaceHolder> parameter where this method stores the color for the light edge of the tab window.  
  
 [out] <CodeContentPlaceHolder>298\</CodeContentPlaceHolder>  
 A pointer to a reference for a brush. This method stores the brush that it uses to fill the face of the tab window in this parameter.  
  
 [out] <CodeContentPlaceHolder>299\</CodeContentPlaceHolder>  
 A pointer to a reference for a brush. This method stores the brush it uses to fill the black edge of the tab window in this parameter.  
  
### Remarks  
 Override this function in a derived class if you want to customize the set of colors that the framework uses when it draws a tab window.  
  
##  \<a name="cmfcvisualmanager__gettabhorzmargin">\</a>  CMFCVisualManager::GetTabHorzMargin  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>300\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__gettabtextcolor">\</a>  CMFCVisualManager::GetTabTextColor  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>301\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>302\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>303\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__gettaskspanegroupcaptionheight">\</a>  CMFCVisualManager::GetTasksPaneGroupCaptionHeight  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__gettaskspanegroupcaptionhorzoffset">\</a>  CMFCVisualManager::GetTasksPaneGroupCaptionHorzOffset  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__gettaskspanegroupcaptionvertoffset">\</a>  CMFCVisualManager::GetTasksPaneGroupCaptionVertOffset  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__gettaskspanegroupvertoffset">\</a>  CMFCVisualManager::GetTasksPaneGroupVertOffset  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__gettaskspanehorzmargin">\</a>  CMFCVisualManager::GetTasksPaneHorzMargin  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__gettaskspaneiconhorzoffset">\</a>  CMFCVisualManager::GetTasksPaneIconHorzOffset  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__gettaskspaneiconvertoffset">\</a>  CMFCVisualManager::GetTasksPaneIconVertOffset  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__gettaskspanetaskhorzoffset">\</a>  CMFCVisualManager::GetTasksPaneTaskHorzOffset  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__gettaskspanevertmargin">\</a>  CMFCVisualManager::GetTasksPaneVertMargin  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__gettoolbarbuttontextcolor">\</a>  CMFCVisualManager::GetToolbarButtonTextColor  
 The framework calls this method to determine the text color of a toolbar button.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>304\</CodeContentPlaceHolder>  
 A pointer to the toolbar button.  
  
 [in] <CodeContentPlaceHolder>305\</CodeContentPlaceHolder>  
 The state of the toolbar button.  
  
### Return Value  
 The text color of <CodeContentPlaceHolder>306\</CodeContentPlaceHolder> when it has the state indicated by <CodeContentPlaceHolder>307\</CodeContentPlaceHolder>.  
  
### Remarks  
 The text color of a [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md) object depends on the state of the button. The possible states of a toolbar button are <CodeContentPlaceHolder>308\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>309\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>310\</CodeContentPlaceHolder>.  
  
 Override this function to customize the text color of a toolbar button in your application.  
  
##  \<a name="cmfcvisualmanager__gettoolbarcustomizebuttonmargin">\</a>  CMFCVisualManager::GetToolBarCustomizeButtonMargin  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__gettoolbardisabledcolor">\</a>  CMFCVisualManager::GetToolbarDisabledColor  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__gettoolbardisabledtextcolor">\</a>  CMFCVisualManager::GetToolbarDisabledTextColor  
 The framework calls this function to determine the text color of toolbar buttons that are unavailable.  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Return Value  
 The color that the framework uses for the text color of toolbar buttons that are unavailable.  
  
### Remarks  
 Override this method in a custom visual manager to set the text color of toolbar buttons that are unavailable .  
  
##  \<a name="cmfcvisualmanager__gettoolbarhighlightcolor">\</a>  CMFCVisualManager::GetToolbarHighlightColor  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__gettooltipinfo">\</a>  CMFCVisualManager::GetToolTipInfo  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>311\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>312\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__hasoverlappedautohidebuttons">\</a>  CMFCVisualManager::HasOverlappedAutoHideButtons  
 Returns whether auto-hide buttons overlap in the current visual manager.  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>313\</CodeContentPlaceHolder> if auto-hide buttons overlap; <CodeContentPlaceHolder>314\</CodeContentPlaceHolder> if they do not.  
  
##  \<a name="cmfcvisualmanager__isautodestroy">\</a>  CMFCVisualManager::IsAutoDestroy  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__isdefaultwinxppopupbutton">\</a>  CMFCVisualManager::IsDefaultWinXPPopupButton  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>315\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__isdockingtabhasborder">\</a>  CMFCVisualManager::IsDockingTabHasBorder  
 Returns whether the current visual manager draws borders around panes that are docked and tabbed.  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>316\</CodeContentPlaceHolder> if the visual manager draws borders around panes that are docked and tabbed; <CodeContentPlaceHolder>317\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 Docked panes become tabbed when multiple panes are docked to the same location.  
  
##  \<a name="cmfcvisualmanager__isembossdisabledimage">\</a>  CMFCVisualManager::IsEmbossDisabledImage  
 Specifies whether the framework embosses images that are unavailable.  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the framework embosses images that are unavailable; otherwise 0.  
  
### Remarks  
 This method is called by [CMFCToolBarImages::Draw](../vs140/cmfctoolbarimages-class.md#cmfctoolbarimages__draw) when it draws an image on the toolbar that is unavailable.  
  
##  \<a name="cmfcvisualmanager__isfadeinactiveimage">\</a>  CMFCVisualManager::IsFadeInactiveImage  
 The framework calls this method when it draws inactive images on the toolbar or in a menu.  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the framework uses the lighting effect when it draws inactive images on the toolbar or in a menu; otherwise 0.  
  
### Remarks  
 You can activate or deactivate the lighting effect by calling [CMFCVisualManager::SetFadeInactiveImage](#cmfcvisualmanager__setfadeinactiveimage). The lighting effect is what makes unavailable images appear faded.  
  
##  \<a name="cmfcvisualmanager__isframemenucheckeditems">\</a>  CMFCVisualManager::IsFrameMenuCheckedItems  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__ishighlightonenotetabs">\</a>  CMFCVisualManager::IsHighlightOneNoteTabs  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__ishighlightwholemenuitem">\</a>  CMFCVisualManager::IsHighlightWholeMenuItem  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__islayeredribbonkeytip">\</a>  CMFCVisualManager::IsLayeredRibbonKeyTip  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__ismenuflatlook">\</a>  CMFCVisualManager::IsMenuFlatLook  
 Indicates whether menu buttons appear flat.  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if menu buttons appear flat; 0 otherwise.  
  
### Remarks  
 By default, menu buttons do not appear flat. Use the [CMFCVisualManager::SetMenuFlatLook](#cmfcvisualmanager__setmenuflatlook) method to change this behavior. When menu buttons appear flat, they do not change appearance when the user clicks on them.  
  
##  \<a name="cmfcvisualmanager__isofficexpstylemenus">\</a>  CMFCVisualManager::IsOfficeXPStyleMenus  
 Indicates whether the visual manager implements Office XP-style menus.  
  
<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the visual manager displays Office XP-style menus; otherwise 0.  
  
### Remarks  
 The [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md) calls this method when it has to draw the menu and shadow. By default, this method returns <CodeContentPlaceHolder>318\</CodeContentPlaceHolder>. If you want to use pop-up menus similar to the pop-up menus in Office XP, override this method in a custom visual manager and return <CodeContentPlaceHolder>319\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcvisualmanager__isoffsetpressedbutton">\</a>  CMFCVisualManager::IsOffsetPressedButton  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__isownerdrawcaption">\</a>  CMFCVisualManager::IsOwnerDrawCaption  
 Indicates whether the current visual manager implements owner-drawn captions.  
  
<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>320\</CodeContentPlaceHolder> if all the frame windows in the application have owner-draw captions; <CodeContentPlaceHolder>321\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cmfcvisualmanager__isownerdrawmenucheck">\</a>  CMFCVisualManager::IsOwnerDrawMenuCheck  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__isshadowhighlightedimage">\</a>  CMFCVisualManager::IsShadowHighlightedImage  
 Indicates whether the visual manager displays shadows when rendering highlighted images.  
  
<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero when the visual manager displays shadows under highlighted images; 0 otherwise.  
  
##  \<a name="cmfcvisualmanager__istoolbarbuttonfillenabled">\</a>  CMFCVisualManager::IsToolbarButtonFillEnabled  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__istoolbarroundshape">\</a>  CMFCVisualManager::IsToolbarRoundShape  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>322\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__iswindowsthemingsupported">\</a>  CMFCVisualManager::IsWindowsThemingSupported  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__onactivateapp">\</a>  CMFCVisualManager::OnActivateApp  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>323\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>324\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__ondrawautohidebuttonborder">\</a>  CMFCVisualManager::OnDrawAutoHideButtonBorder  
 The framework calls this method when it draws the border of an auto-hide button.  
  
<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>325\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>326\</CodeContentPlaceHolder>  
 The size and location of the auto-hide button.  
  
 [in] <CodeContentPlaceHolder>327\</CodeContentPlaceHolder>  
 A [CRect](../vs140/crect-class.md) parameter that contains the sizes of the borders.  
  
 [in] <CodeContentPlaceHolder>328\</CodeContentPlaceHolder>  
 A pointer to the auto-hide button. The framework is drawing the border for this button.  
  
### Remarks  
 Override this method in a derived class if you want to customize the appearance of the border of an auto-hide button. By default, this method fills a flat border with the default shadow color for your application.  
  
 The <CodeContentPlaceHolder>329\</CodeContentPlaceHolder> parameter does not contain the coordinates of the border. It contains the size of the border in the <CodeContentPlaceHolder>330\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>331\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>332\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>333\</CodeContentPlaceHolder> data members. A value less than or equal to 0 indicates no border on that side of the auto-hide button.  
  
##  \<a name="cmfcvisualmanager__ondrawbargripper">\</a>  CMFCVisualManager::OnDrawBarGripper  
 Called by the framework when it draws the gripper for a control bar.  
  
<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>334\</CodeContentPlaceHolder>  
 A pointer to the device context for a control bar.  
  
 [in] <CodeContentPlaceHolder>335\</CodeContentPlaceHolder>  
 The bounding rectangle for the control bar.  
  
 [in] <CodeContentPlaceHolder>336\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies whether the control bar is docked horizontally or vertically.  
  
 [in] <CodeContentPlaceHolder>337\</CodeContentPlaceHolder>  
 A pointer to a control bar. The visual manager draws the gripper of this control bar.  
  
### Remarks  
 The default implementation of this method displays the standard gripper. To customize the appearance of the gripper, override this method in a custom class derived from the [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md).  
  
##  \<a name="cmfcvisualmanager__ondrawbrowsebutton">\</a>  CMFCVisualManager::OnDrawBrowseButton  
 The framework calls this method when it draws the browse button for an edit control.  
  
<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>338\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>339\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundary for the browse button.  
  
 [in] <CodeContentPlaceHolder>340\</CodeContentPlaceHolder>  
 A pointer to an edit control. The visual manager draws the browse button for this edit control.  
  
 [in] <CodeContentPlaceHolder>341\</CodeContentPlaceHolder>  
 An enumerated value that specifies the state of the button.  
  
 [out] <CodeContentPlaceHolder>342\</CodeContentPlaceHolder>  
 A reference to a                                 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) parameter. This is a reserved value and is currently unused.  
  
### Return Value  
 <CodeContentPlaceHolder>343\</CodeContentPlaceHolder> if successful; otherwise <CodeContentPlaceHolder>344\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this function in a derived class if you want to customize the appearance of browse buttons in instances of the [CMFCEditBrowseCtrl Class](../vs140/cmfceditbrowsectrl-class.md). The possible values for the state of the button are <CodeContentPlaceHolder>345\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>346\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>347\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcvisualmanager__ondrawbuttonborder">\</a>  CMFCVisualManager::OnDrawButtonBorder  
 The framework calls this method when it draws the border of a toolbar button.  
  
<CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>348\</CodeContentPlaceHolder>  
 A pointer to the device context of a toolbar button.  
  
 [in] <CodeContentPlaceHolder>349\</CodeContentPlaceHolder>  
 A pointer to a toolbar button. The framework draws the border of this button.  
  
 [in] <CodeContentPlaceHolder>350\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the toolbar button.  
  
 [in] <CodeContentPlaceHolder>351\</CodeContentPlaceHolder>  
 An enumerated data type that specifies the current state of the toolbar button.  
  
### Remarks  
 The default implementation of this method displays the standard border. Override this method in a derived visual manager to customize the appearance of the border of a toolbar button.  
  
 The possible states of a toolbar button are <CodeContentPlaceHolder>352\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>353\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>354\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcvisualmanager__ondrawbuttonseparator">\</a>  CMFCVisualManager::OnDrawButtonSeparator  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>355\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>356\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>357\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>358\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>359\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__ondrawcaptionbarborder">\</a>  CMFCVisualManager::OnDrawCaptionBarBorder  
 The framework calls this method when it draws the border of a [CMFCCaptionBar Class](../vs140/cmfccaptionbar-class.md) object.  
  
<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>360\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>361\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>362\</CodeContentPlaceHolder> object. The framework draws this caption bar.  
  
 [in] <CodeContentPlaceHolder>363\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the caption bar.  
  
 [in] <CodeContentPlaceHolder>364\</CodeContentPlaceHolder>  
 The color of the border.  
  
 [in] <CodeContentPlaceHolder>365\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies whether the border has a flat, 2D appearance.  
  
### Remarks  
 Override this method in a derived class to customize the appearance of the border of a caption bar.  
  
##  \<a name="cmfcvisualmanager__ondrawcaptionbarbuttonborder">\</a>  CMFCVisualManager::OnDrawCaptionBarButtonBorder  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>366\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>367\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>368\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>369\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>370\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>371\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>372\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>373\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__ondrawcaptionbarinfoarea">\</a>  CMFCVisualManager::OnDrawCaptionBarInfoArea  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>374\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>375\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>376\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__ondrawcaptionbutton">\</a>  CMFCVisualManager::OnDrawCaptionButton  
 The framework calls this method when it draws a [CMFCCaptionButton](../vs140/cmfccaptionbutton-class.md) object.  
  
<CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>377\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>378\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>379\</CodeContentPlaceHolder> object. The framework draws this caption button.  
  
 [in] <CodeContentPlaceHolder>380\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies whether the button is active.  
  
 [in] <CodeContentPlaceHolder>381\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies whether the caption is horizontal.  
  
 [in] <CodeContentPlaceHolder>382\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies whether the parent pane is maximized.  
  
 [in] <CodeContentPlaceHolder>383\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies whether the caption button is disabled.  
  
 [in] <CodeContentPlaceHolder>384\</CodeContentPlaceHolder>  
 The image index for the icon to use for the button. If <CodeContentPlaceHolder>385\</CodeContentPlaceHolder> is -1, this method uses the image index recorded in <CodeContentPlaceHolder>386\</CodeContentPlaceHolder>.  
  
### Remarks  
 The default implementation of this method displays a small button from the global instance of the <CodeContentPlaceHolder>387\</CodeContentPlaceHolder> class. The buttons are listed in the header file for <CodeContentPlaceHolder>388\</CodeContentPlaceHolder>. Some examples include <CodeContentPlaceHolder>389\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>390\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>391\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>392\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>393\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>394\</CodeContentPlaceHolder>.  
  
 Override this method in a derived class to customize the appearance of caption buttons.  
  
##  \<a name="cmfcvisualmanager__ondrawcheckbox">\</a>  CMFCVisualManager::OnDrawCheckBox  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>395\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>396\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>397\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>398\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>399\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__ondrawcheckboxex">\</a>  CMFCVisualManager::OnDrawCheckBoxEx  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>400\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>401\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>402\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>403\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>404\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>405\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__ondrawcomboborder">\</a>  CMFCVisualManager::OnDrawComboBorder  
 The framework calls this method when it draws the border around an instance of the [CMFCToolBarComboBoxButton Class](../vs140/cmfctoolbarcomboboxbutton-class.md).  
  
<CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>406\</CodeContentPlaceHolder>  
 A pointer to the device context of a combo box button.  
  
 [in] <CodeContentPlaceHolder>407\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the combo box button.  
  
 [in] <CodeContentPlaceHolder>408\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the combo box button is unavailable.  
  
 [in] <CodeContentPlaceHolder>409\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the combo box is dropped down.  
  
 [in] <CodeContentPlaceHolder>410\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the combo box button is highlighted.  
  
 [in] <CodeContentPlaceHolder>411\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>412\</CodeContentPlaceHolder> object. The framework draws this combo box button.  
  
### Remarks  
 Override this method in your derived visual manager to customize the appearance of the border of the combo box.  
  
##  \<a name="cmfcvisualmanager__ondrawcombodropbutton">\</a>  CMFCVisualManager::OnDrawComboDropButton  
 The framework calls this method when it draws the drop button of a [CMFCToolBarComboBoxButton](../vs140/cmfctoolbarcomboboxbutton-class.md).  
  
<CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>413\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>414\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the drop button.  
  
 [in] <CodeContentPlaceHolder>415\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the drop button is unavailable.  
  
 [in] <CodeContentPlaceHolder>416\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the combo box is dropped down.  
  
 [in] <CodeContentPlaceHolder>417\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the drop button is highlighted.  
  
 [in] <CodeContentPlaceHolder>418\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>419\</CodeContentPlaceHolder> object. The framework draws the drop button for this combo box button.  
  
### Remarks  
 Override this method in your derived visual manager to customize the appearance of the drop button of a combo box button.  
  
##  \<a name="cmfcvisualmanager__ondrawcontrolborder">\</a>  CMFCVisualManager::OnDrawControlBorder  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>420\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__ondrawdefaultribbonimage">\</a>  CMFCVisualManager::OnDrawDefaultRibbonImage  
 The framework calls this method when it draws the default image that is used for the ribbon button.  
  
<CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>421\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>422\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the default image.  
  
 [in] <CodeContentPlaceHolder>423\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the ribbon button is unavailable.  
  
 [in] <CodeContentPlaceHolder>424\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the ribbon button is pressed.  
  
 [in] <CodeContentPlaceHolder>425\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the ribbon button is highlighted.  
  
### Remarks  
 Override this method in a derived visual manager if you want to customize the image that is used for the ribbon button.  
  
##  \<a name="cmfcvisualmanager__ondraweditborder">\</a>  CMFCVisualManager::OnDrawEditBorder  
 The framework calls this method when it draws the border around an instance of the [CMFCToolBarEditBoxButton Class](../vs140/cmfctoolbareditboxbutton-class.md).  
  
<CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>426\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>427\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the <CodeContentPlaceHolder>428\</CodeContentPlaceHolder> object.  
  
 [in] <CodeContentPlaceHolder>429\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the button is unavailable.  
  
 [in] <CodeContentPlaceHolder>430\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the button is highlighted.  
  
 [in] <CodeContentPlaceHolder>431\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>432\</CodeContentPlaceHolder> object. The framework draws the border of this edit box button.  
  
### Remarks  
 Override this method in a derived visual manager to customize the border of a <CodeContentPlaceHolder>433\</CodeContentPlaceHolder> object.  
  
##  \<a name="cmfcvisualmanager__ondrawexpandingbox">\</a>  CMFCVisualManager::OnDrawExpandingBox  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>434\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>435\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>436\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>437\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__ondrawfloatingtoolbarborder">\</a>  CMFCVisualManager::OnDrawFloatingToolbarBorder  
 The framework calls this method when it draws the border of a floating toolbar.  
  
<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>438\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>439\</CodeContentPlaceHolder>  
 A pointer to the floating toolbar.  
  
 [in] <CodeContentPlaceHolder>440\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the floating toolbar.  
  
 [in] <CodeContentPlaceHolder>441\</CodeContentPlaceHolder>  
 A rectangle that specifies the border size of the toolbar.  
  
### Remarks  
 A floating toolbar is a toolbar that appears as a mini-frame window. Usually, this occurs when a user drags a toolbar so that it is no longer docked.  
  
 The size of the border is specified by the corresponding parameter in <CodeContentPlaceHolder>442\</CodeContentPlaceHolder>. For example, the width of the top border of the toolbar is specified by <CodeContentPlaceHolder>443\</CodeContentPlaceHolder>.  
  
 Override this method in a derived visual manager to customize the appearance of the border of a floating toolbar.  
  
##  \<a name="cmfcvisualmanager__ondrawheaderctrlborder">\</a>  CMFCVisualManager::OnDrawHeaderCtrlBorder  
 The framework calls this method when it draws the border around an instance of the [CMFCHeaderCtrl Class](../vs140/cmfcheaderctrl-class.md).  
  
<CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>444\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>445\</CodeContentPlaceHolder> object. The framework draws the border of this header control.  
  
 [in] <CodeContentPlaceHolder>446\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>447\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the header control.  
  
 [in] <CodeContentPlaceHolder>448\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the header control is pressed.  
  
 [in] <CodeContentPlaceHolder>449\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the header control is highlighted.  
  
### Remarks  
 Override this method in a derived visual manager to customize the border of the header control.  
  
##  \<a name="cmfcvisualmanager__ondrawheaderctrlsortarrow">\</a>  CMFCVisualManager::OnDrawHeaderCtrlSortArrow  
 The framework calls this function when it draws the sort arrow of a header control.  
  
<CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>450\</CodeContentPlaceHolder>  
 A pointer to a header control. The visual manager draws the sort arrow of this [CMFCHeaderCtrl Class](../vs140/cmfcheaderctrl-class.md) object.  
  
 [in] <CodeContentPlaceHolder>451\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>452\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the sort arrow.  
  
 [in] <CodeContentPlaceHolder>453\</CodeContentPlaceHolder>  
 A Boolean that specifies the direction of the sort arrow.  
  
### Remarks  
 If <CodeContentPlaceHolder>454\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>455\</CodeContentPlaceHolder>, the visual manager draws an up sort arrow. If it is <CodeContentPlaceHolder>456\</CodeContentPlaceHolder>, the visual manager draws a down sort arrow. Override <CodeContentPlaceHolder>457\</CodeContentPlaceHolder> in a derived class to customize the appearance of the sort button.  
  
##  \<a name="cmfcvisualmanager__ondrawmenuarrowoncustomizelist">\</a>  CMFCVisualManager::OnDrawMenuArrowOnCustomizeList  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>458\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>459\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>460\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__ondrawmenuborder">\</a>  CMFCVisualManager::OnDrawMenuBorder  
 The framework calls this method when it draws the border of a [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md).  
  
<CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>461\</CodeContentPlaceHolder>  
 A pointer to the device context for a <CodeContentPlaceHolder>462\</CodeContentPlaceHolder> object.  
  
 [in] <CodeContentPlaceHolder>463\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>464\</CodeContentPlaceHolder> object. The framework draws a border around this popup menu.  
  
 [in] <CodeContentPlaceHolder>465\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the popup menu.  
  
### Remarks  
 The default implementation of this method displays the standard menu border. Override this method in a derived visual manager to customize the appearance of the menu border.  
  
##  \<a name="cmfcvisualmanager__ondrawmenucheck">\</a>  CMFCVisualManager::OnDrawMenuCheck  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>466\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>467\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>468\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>469\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>470\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__ondrawmenuitembutton">\</a>  CMFCVisualManager::OnDrawMenuItemButton  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>471\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>472\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>473\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>474\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>475\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__ondrawmenulabel">\</a>  CMFCVisualManager::OnDrawMenuLabel  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>476\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>477\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__ondrawmenuresizebar">\</a>  CMFCVisualManager::OnDrawMenuResizeBar  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>478\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>479\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>480\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__ondrawmenuscrollbutton">\</a>  CMFCVisualManager::OnDrawMenuScrollButton  
 The framework calls this method when it draws a menu scroll button.  
  
<CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>481\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>482\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the scroll button.  
  
 [in] <CodeContentPlaceHolder>483\</CodeContentPlaceHolder>  
 A Boolean that indicates which type of button the visual manager draws. A value of <CodeContentPlaceHolder>484\</CodeContentPlaceHolder> indicates the visual manager draws a down button.  
  
 [in] <CodeContentPlaceHolder>485\</CodeContentPlaceHolder>  
 A Boolean that indicates whether the button is highlighted.  
  
 [in] <CodeContentPlaceHolder>486\</CodeContentPlaceHolder>  
 A Boolean that indicates whether the button is pressed.  
  
 [in] <CodeContentPlaceHolder>487\</CodeContentPlaceHolder>  
 A Boolean that indicates whether the button is disabled.  
  
### Remarks  
 Override this method in a derived visual manager to customize the appearance of menu scroll buttons. Menu scroll buttons appear on the edge of pop-up menus when the total height of the menu items exceeds the height of the pop-up menu.  
  
##  \<a name="cmfcvisualmanager__ondrawmenushadow">\</a>  CMFCVisualManager::OnDrawMenuShadow  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>488\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>489\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>490\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>491\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>492\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>493\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>494\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>495\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>496\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__ondrawmenusystembutton">\</a>  CMFCVisualManager::OnDrawMenuSystemButton  
 The framework calls this method when it draws a menu system button for the application.  
  
<CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>497\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>498\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the button.  
  
 [in] <CodeContentPlaceHolder>499\</CodeContentPlaceHolder>  
 A flag that specifies which system command is associated with the button. Possible values are SC_CLOSE, SC_MINIMIZE, and SC_RESTORE.  
  
 [in] <CodeContentPlaceHolder>500\</CodeContentPlaceHolder>  
 A flag that specifies the current style of the button. Possible values are TBBS_PRESSED, TBBS_DISABLED, and 0.  
  
 [in] <CodeContentPlaceHolder>501\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies whether the button is highlighted.  
  
### Remarks  
 The menu system buttons are the **Close**, **Minimize**, **Maximize**, and **Restore** buttons located on the title bar.  
  
 The default implementation for this method calls [CDC::DrawFrameControl](../vs140/cdc-class.md#cdc__drawframecontrol) with the <CodeContentPlaceHolder>502\</CodeContentPlaceHolder> type. Override this method in your derived visual manager class to customize the appearance of system buttons.  
  
##  \<a name="cmfcvisualmanager__ondrawminiframeborder">\</a>  CMFCVisualManager::OnDrawMiniFrameBorder  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>503\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>504\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>505\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>506\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__ondrawoutlookbarsplitter">\</a>  CMFCVisualManager::OnDrawOutlookBarSplitter  
 The framework calls this method when it draws the splitter for an Outlook bar.  
  
<CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>507\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>508\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the splitter.  
  
### Remarks  
 Override this method in a derived visual manager to customize the appearance of splitters on an Outlook bar.  
  
##  \<a name="cmfcvisualmanager__ondrawoutlookpagebuttonborder">\</a>  CMFCVisualManager::OnDrawOutlookPageButtonBorder  
 Called by the framework when it draws the border of an Outlook page button.  
  
<CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>509\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>510\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundary of the Outlook page button.  
  
 [in] <CodeContentPlaceHolder>511\</CodeContentPlaceHolder>  
 A Boolean that specifies whether the button is highlighted.  
  
 [in] <CodeContentPlaceHolder>512\</CodeContentPlaceHolder>  
 A Boolean that specifies whether the button is pressed.  
  
### Remarks  
 Override this method in a custom visual manager to change the appearance of the Outlook page button.  
  
##  \<a name="cmfcvisualmanager__ondrawpaneborder">\</a>  CMFCVisualManager::OnDrawPaneBorder  
 The framework calls this method when it draws the border of a [CPane Class](../vs140/cpane-class.md) object.  
  
<CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>513\</CodeContentPlaceHolder>  
 A pointer to the device context of a control bar.  
  
 [in] <CodeContentPlaceHolder>514\</CodeContentPlaceHolder>  
 A pointer to a pane. The visual manager draws the border of this pane.  
  
 [in] <CodeContentPlaceHolder>515\</CodeContentPlaceHolder>  
 A rectangle that indicates the boundaries of the pane.  
  
### Remarks  
 The default implementation of this method displays the standard border. Override this method in a derived class to customize the appearance of the border.  
  
##  \<a name="cmfcvisualmanager__ondrawpanecaption">\</a>  CMFCVisualManager::OnDrawPaneCaption  
 The framework calls this method when it draws a caption for an instance of the [CDockablePane Class](../vs140/cdockablepane-class.md).  
  
<CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>516\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>517\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>518\</CodeContentPlaceHolder> object. The framework draws the caption for this pane.  
  
 [in] <CodeContentPlaceHolder>519\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the control bar is active.  
  
 [in] <CodeContentPlaceHolder>520\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the caption.  
  
 [in] <CodeContentPlaceHolder>521\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the caption buttons.  
  
### Return Value  
 A                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) parameter that indicates the text color of the caption.  
  
### Remarks  
 Override this method in a derived visual manager to customize the appearance of pane captions.  
  
##  \<a name="cmfcvisualmanager__ondrawpanedivider">\</a>  CMFCVisualManager::OnDrawPaneDivider  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>522\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>523\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>524\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>525\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__ondrawpopupwindowborder">\</a>  CMFCVisualManager::OnDrawPopupWindowBorder  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>526\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>527\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__ondrawpopupwindowbuttonborder">\</a>  CMFCVisualManager::OnDrawPopupWindowButtonBorder  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>528\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>529\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>530\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__ondrawpopupwindowcaption">\</a>  CMFCVisualManager::OnDrawPopupWindowCaption  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>531\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>532\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>533\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__ondrawribbonapplicationbutton">\</a>  CMFCVisualManager::OnDrawRibbonApplicationButton  
 The framework calls this method when it draws the **Main Button** on the ribbon.  
  
<CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>534\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>535\</CodeContentPlaceHolder>  
 A pointer to the **Main Button** on the ribbon.  
  
### Remarks  
 Override this method in a derived visual manager if you want to customize the appearance of the **Main Button**.  
  
##  \<a name="cmfcvisualmanager__ondrawribbonbuttonborder">\</a>  CMFCVisualManager::OnDrawRibbonButtonBorder  
 The framework calls this method when it draws the border of a button on the ribbon.  
  
<CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>536\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>537\</CodeContentPlaceHolder>  
 A pointer to a [CMFCRibbonButton](../vs140/cmfcribbonbutton-class.md) object. The framework draws the border for this ribbon button.  
  
### Remarks  
 Override this method in a derived visual manager to customize the appearance of a <CodeContentPlaceHolder>538\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcvisualmanager__ondrawribbonbuttonsgroup">\</a>  CMFCVisualManager::OnDrawRibbonButtonsGroup  
 The framework calls this method when it draws a group of buttons on the ribbon.  
  
<CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>539\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>540\</CodeContentPlaceHolder>  
 A pointer to a group of buttons on the ribbon. The framework draws this group of buttons.  
  
 [in] <CodeContentPlaceHolder>541\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the group.  
  
### Return Value  
 A reserved value. The default implementation returns -1.  
  
### Remarks  
 Override this method in a derived visual manager to customize the appearance of a group of buttons on the ribbon.  
  
##  \<a name="cmfcvisualmanager__ondrawribboncaption">\</a>  CMFCVisualManager::OnDrawRibbonCaption  
 The framework calls this method when it draws the caption bar of the main frame window. The framework calls this method only if the ribbon is integrated with the main frame.  
  
<CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>542\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>543\</CodeContentPlaceHolder>  
 A pointer to a ribbon bar. The visual manager draws this ribbon bar.  
  
 [in] <CodeContentPlaceHolder>544\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the ribbon bar.  
  
 [in] <CodeContentPlaceHolder>545\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries for the text of the caption bar.  
  
### Remarks  
 Override this function in a derived visual manager to customize the appearance of the caption bar. This method affects the caption bar only if the ribbon is integrated with the main frame window.  
  
##  \<a name="cmfcvisualmanager__ondrawribboncaptionbutton">\</a>  CMFCVisualManager::OnDrawRibbonCaptionButton  
 The framework calls this method when it draws a caption button located on the ribbon bar.  
  
<CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>546\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 <CodeContentPlaceHolder>547\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>548\</CodeContentPlaceHolder> class. The framework draws this caption button.  
  
### Remarks  
 Override this method in a derived visual manager to customize the appearance of a caption button on the ribbon.  
  
##  \<a name="cmfcvisualmanager__ondrawribboncategory">\</a>  CMFCVisualManager::OnDrawRibbonCategory  
 The framework calls this method when it draws a [CMFCRibbonCategory](../vs140/cmfcribboncategory-class.md) object.  
  
<CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>549\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>550\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>551\</CodeContentPlaceHolder> object. The framework draws this ribbon category.  
  
 [in] <CodeContentPlaceHolder>552\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundary of all the category panels on the ribbon.  
  
### Remarks  
 A ribbon category is a logical grouping of menu commands. For more information about ribbon categories, see [CMFCRibbonCategory Class](../vs140/cmfcribboncategory-class.md).  
  
 Override this method in a derived visual manager to customize the appearance of a ribbon category.  
  
##  \<a name="cmfcvisualmanager__ondrawribboncategorycaption">\</a>  CMFCVisualManager::OnDrawRibbonCategoryCaption  
 The framework calls this method when it draws the caption bar for a ribbon category.  
  
<CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>553\</CodeContentPlaceHolder>  
 The drawing context.  
  
 [in] <CodeContentPlaceHolder>554\</CodeContentPlaceHolder>  
 A pointer to a caption bar. The visual manager draws this [CMFCRibbonContextCaption Class](../vs140/cmfcribboncontextcaption-class.md) object.  
  
### Return Value  
 A                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) parameter that indicates the color of the text on the caption bar.  
  
### Remarks  
 Override this method in a derived class to customize the appearance of the caption bar for a ribbon category. For more information about the caption bar, see [CMFCRibbonContextCaption Class](../vs140/cmfcribboncontextcaption-class.md).  
  
##  \<a name="cmfcvisualmanager__ondrawribboncategoryscroll">\</a>  CMFCVisualManager::OnDrawRibbonCategoryScroll  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>555\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>556\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__ondrawribboncategorytab">\</a>  CMFCVisualManager::OnDrawRibbonCategoryTab  
 The framework calls this method when it draws the tab for a ribbon category.  
  
<CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>557\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>558\</CodeContentPlaceHolder>  
 A pointer to an instance of the <CodeContentPlaceHolder>559\</CodeContentPlaceHolder> class. The framework draws this tab.  
  
 [in] <CodeContentPlaceHolder>560\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the tab is active.  
  
### Return Value  
 The color that is used for text on the ribbon category tab.  
  
### Remarks  
 Override this method in a derived visual manager to customize the appearance of a ribbon category tab. For more information about ribbon categories, see [CMFCRibbonCategory Class](../vs140/cmfcribboncategory-class.md).  
  
##  \<a name="cmfcvisualmanager__ondrawribboncheckboxonlist">\</a>  CMFCVisualManager::OnDrawRibbonCheckBoxOnList  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>561\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>562\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>563\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>564\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>565\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__ondrawribboncolorpalettebox">\</a>  CMFCVisualManager::OnDrawRibbonColorPaletteBox  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>566\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>567\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>568\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>569\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>570\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>571\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>572\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>573\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>574\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>575\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__ondrawribbondefaultpanebutton">\</a>  CMFCVisualManager::OnDrawRibbonDefaultPaneButton  
 The framework calls this method when it draws the default button for the ribbon pane.  
  
<CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>576\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>577\</CodeContentPlaceHolder>  
 A pointer to the default button for the ribbon pane.  
  
### Remarks  
 The framework displays the default button when a ribbon pane is resized to its minimal size and there is no area to display the content for the panel. When the user clicks on the default button, the framework displays a drop down menu that contains the content for the panel.  
  
 Override this method in a derived visual manager to customize the appearance of the default button.  
  
##  \<a name="cmfcvisualmanager__ondrawribbondefaultpanebuttoncontext">\</a>  CMFCVisualManager::OnDrawRibbonDefaultPaneButtonContext  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>578\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>579\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__ondrawribbondefaultpanebuttonindicator">\</a>  CMFCVisualManager::OnDrawRibbonDefaultPaneButtonIndicator  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>580\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>581\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>582\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>583\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>584\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__ondrawribbongalleryborder">\</a>  CMFCVisualManager::OnDrawRibbonGalleryBorder  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>585\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>586\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>587\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__ondrawribbongallerybutton">\</a>  CMFCVisualManager::OnDrawRibbonGalleryButton  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>588\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>589\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__ondrawribbonkeytip">\</a>  CMFCVisualManager::OnDrawRibbonKeyTip  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>590\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>591\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>592\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>593\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__ondrawribbonlabel">\</a>  CMFCVisualManager::OnDrawRibbonLabel  
 The framework calls this method when it draws the label of the ribbon.  
  
<CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>594\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>595\</CodeContentPlaceHolder>  
 A pointer to a [CMFCRibbonLabel](../vs140/cmfcribbonlabel-class.md) object. The framework draws this ribbon label.  
  
 [in] <CodeContentPlaceHolder>596\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the ribbon panel.  
  
### Remarks  
 Override this method in a derived class to customize the ribbon label.  
  
##  \<a name="cmfcvisualmanager__ondrawribbonmainpanelbuttonborder">\</a>  CMFCVisualManager::OnDrawRibbonMainPanelButtonBorder  
 The framework calls this method when it draws the border of a [CMFCRibbonButton](../vs140/cmfcribbonbutton-class.md) that is positioned on the **Main** panel.  
  
<CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>597\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>598\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>599\</CodeContentPlaceHolder> located on the main panel of the ribbon. The framework draws the border for this button.  
  
### Remarks  
 Override this method in a derived visual manager to customize the appearance of the border for a <CodeContentPlaceHolder>600\</CodeContentPlaceHolder> on the **Main** panel.  
  
##  \<a name="cmfcvisualmanager__ondrawribbonmainpanelframe">\</a>  CMFCVisualManager::OnDrawRibbonMainPanelFrame  
 The framework calls this method when it draws the frame around the [CMFCRibbonMainPanel](../vs140/cmfcribbonmainpanel-class.md).  
  
<CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>601\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>602\</CodeContentPlaceHolder>  
 A pointer to the <CodeContentPlaceHolder>603\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>604\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the <CodeContentPlaceHolder>605\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this method in a derived visual manager to customize the appearance of the frame for the <CodeContentPlaceHolder>606\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcvisualmanager__ondrawribbonmenucheckframe">\</a>  CMFCVisualManager::OnDrawRibbonMenuCheckFrame  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>607\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>608\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>609\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__ondrawribbonpanel">\</a>  CMFCVisualManager::OnDrawRibbonPanel  
 The framework calls this method when it draws a [CMFCRibbonPanel](../vs140/cmfcribbonpanel-class.md) object.  
  
<CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>610\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>611\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>612\</CodeContentPlaceHolder> object. The framework draws this ribbon panel.  
  
 [in] <CodeContentPlaceHolder>613\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the panel.  
  
 [in] <CodeContentPlaceHolder>614\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the caption for the panel.  
  
### Return Value  
 The color of text on the ribbon panel.  
  
### Remarks  
 Override this method in a derived class to customize the appearance of a ribbon panel.  
  
##  \<a name="cmfcvisualmanager__ondrawribbonpanelcaption">\</a>  CMFCVisualManager::OnDrawRibbonPanelCaption  
 The framework calls this method when it draws the caption of a [CMFCRibbonPanel Class](../vs140/cmfcribbonpanel-class.md).  
  
<CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>615\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>616\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>617\</CodeContentPlaceHolder> object. The framework draws the caption for this ribbon panel.  
  
 [in] <CodeContentPlaceHolder>618\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the caption for the ribbon panel.  
  
### Remarks  
 Override this method in a derived class to customize the appearance of captions for ribbon panels.  
  
##  \<a name="cmfcvisualmanager__ondrawribbonprogressbar">\</a>  CMFCVisualManager::OnDrawRibbonProgressBar  
 The framework calls this method when it draws a [CMFCRibbonProgressBar Class](../vs140/cmfcribbonprogressbar-class.md).  
  
<CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>619\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>620\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>621\</CodeContentPlaceHolder> object. The framework draws this progress bar.  
  
 [in] <CodeContentPlaceHolder>622\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the progress bar.  
  
 [in] <CodeContentPlaceHolder>623\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the area surrounding the progress bar.  
  
 [in] <CodeContentPlaceHolder>624\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates the mode of the progress bar. A value of <CodeContentPlaceHolder>625\</CodeContentPlaceHolder> means the bar is in infinite mode. The default implementation does not use this parameter.  
  
### Remarks  
 Override this method in a derived class to customize the appearance of a progress bar.  
  
##  \<a name="cmfcvisualmanager__ondrawribbonquickaccesstoolbarseparator">\</a>  CMFCVisualManager::OnDrawRibbonQuickAccessToolBarSeparator  
 The framework calls this method when it draws a separator on the **Quick Access Toolbar** of a ribbon.  
  
<CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>626\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>627\</CodeContentPlaceHolder>  
 A pointer to a [CMFCRibbonSeparator](../vs140/cmfcribbonseparator-class.md) object. The framework draws this ribbon separator.  
  
 [in] <CodeContentPlaceHolder>628\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the separator.  
  
### Remarks  
 Override this method in a derived class to customize the appearance of ribbon separators on the **Quick Access Toolbar**.  
  
##  \<a name="cmfcvisualmanager__ondrawribbonrecentfilesframe">\</a>  CMFCVisualManager::OnDrawRibbonRecentFilesFrame  
 The framework calls this method when it draws a frame around a list of recent files.  
  
<CodeContentPlaceHolder>143\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>629\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>630\</CodeContentPlaceHolder>  
 A pointer to the **Main** panel on the ribbon.  
  
 [in] <CodeContentPlaceHolder>631\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the frame for the list of recent files.  
  
### Remarks  
 Override this method in a derived visual manager to customize the appearance of the list of recent files.  
  
##  \<a name="cmfcvisualmanager__ondrawribbonsliderchannel">\</a>  CMFCVisualManager::OnDrawRibbonSliderChannel  
 The framework calls this method when it draws the channel of a [CMFCRibbonSlider Class](../vs140/cmfcribbonslider-class.md).  
  
<CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>632\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>633\</CodeContentPlaceHolder>  
 A pointer to a CMFCRibbonSlider object. The framework draws the channel for this ribbon slider.  
  
 [in] <CodeContentPlaceHolder>634\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries for the channel of the ribbon slider.  
  
### Remarks  
 Override this method in a derived class to customize the appearance of the channel of the ribbon slider.  
  
##  \<a name="cmfcvisualmanager__ondrawribbonsliderthumb">\</a>  CMFCVisualManager::OnDrawRibbonSliderThumb  
 The framework calls this method when it draws the thumb of a [CMFCRibbonSlider](../vs140/cmfcribbonslider-class.md) object.  
  
<CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>635\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>636\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>637\</CodeContentPlaceHolder>. The framework draws the thumb for this ribbon slider.  
  
 [in] <CodeContentPlaceHolder>638\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the thumb for the ribbon slider.  
  
 [in] <CodeContentPlaceHolder>639\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates if the thumb is highlighted.  
  
 [in] <CodeContentPlaceHolder>640\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates if the thumb is pressed.  
  
 [in] <CodeContentPlaceHolder>641\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates if the thumb is unavailable.  
  
### Remarks  
 Override this method in a derived visual manager to customize the appearance of the thumb for a <CodeContentPlaceHolder>642\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcvisualmanager__ondrawribbonsliderzoombutton">\</a>  CMFCVisualManager::OnDrawRibbonSliderZoomButton  
 The framework calls this method when it draws the zoom buttons for a [CMFCRibbonSlider](../vs140/cmfcribbonslider-class.md) object.  
  
<CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>643\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>644\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>645\</CodeContentPlaceHolder> object. The framework draws this ribbon slider.  
  
 [in] <CodeContentPlaceHolder>646\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the zoom buttons on the ribbon slider.  
  
 [in] <CodeContentPlaceHolder>647\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates which button the framework draws. A value of <CodeContentPlaceHolder>648\</CodeContentPlaceHolder> indicates the left button with a "-" for zoom out. A value of <CodeContentPlaceHolder>649\</CodeContentPlaceHolder> indicates the right button with a "+" for zoom in.  
  
 [in] <CodeContentPlaceHolder>650\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the button is highlighted.  
  
 [in] <CodeContentPlaceHolder>651\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the button is pressed.  
  
 [in] <CodeContentPlaceHolder>652\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the button is unavailable.  
  
### Remarks  
 By default, the zoom buttons on the ribbon slider are a circle with either a + or - sign in the center. To customize the appearance of zoom buttons, override this method in a derived visual manager.  
  
##  \<a name="cmfcvisualmanager__ondrawribbonstatusbarpane">\</a>  CMFCVisualManager::OnDrawRibbonStatusBarPane  
 The framework calls this method when it draws a pane on the status bar.  
  
<CodeContentPlaceHolder>147\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>653\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>654\</CodeContentPlaceHolder>  
 A pointer to the status bar that contains the pane.  
  
 [in] <CodeContentPlaceHolder>655\</CodeContentPlaceHolder>  
 A pointer to a status bar pane. The framework draws this [CMFCRibbonStatusBarPane](../vs140/cmfcribbonstatusbarpane-class.md) object.  
  
### Return Value  
 A reserved value. The default implementation returns -1.  
  
### Remarks  
 Override this method in a derived visual manager to customize the appearance of a pane on the status bar.  
  
##  \<a name="cmfcvisualmanager__ondrawribbontabsframe">\</a>  CMFCVisualManager::OnDrawRibbonTabsFrame  
 The framework calls this method when it draws the frame around a set of ribbon tabs.  
  
<CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>656\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 <CodeContentPlaceHolder>657\</CodeContentPlaceHolder>  
 A pointer to a [CMFCRibbonBar](../vs140/cmfcribbonbar-class.md) object. The framework draws the frame for this ribbon bar.  
  
 <CodeContentPlaceHolder>658\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the ribbon tabs.  
  
### Return Value  
 A reserved value. By default, this method returns -1.  
  
### Remarks  
 Override this method in a derived visual manager to customize the frame around a set of tabs on the ribbon.  
  
##  \<a name="cmfcvisualmanager__ondrawscrollbuttons">\</a>  CMFCVisualManager::OnDrawScrollButtons  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>659\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>660\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>661\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>662\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>663\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__ondrawseparator">\</a>  CMFCVisualManager::OnDrawSeparator  
 The framework calls this method when it draws a separator.  
  
<CodeContentPlaceHolder>150\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>664\</CodeContentPlaceHolder>  
 A pointer to the device context for a control bar.  
  
 [in] <CodeContentPlaceHolder>665\</CodeContentPlaceHolder>  
 A pointer to a pane that contains the separator.  
  
 [in] <CodeContentPlaceHolder>666\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the separator.  
  
 [in] <CodeContentPlaceHolder>667\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates the orientation of a docked pane. A value of <CodeContentPlaceHolder>668\</CodeContentPlaceHolder> indicates that the pane is docked horizontally. A value of <CodeContentPlaceHolder>669\</CodeContentPlaceHolder> indicates that the pane is docked vertically.  
  
### Remarks  
 Separators are used on control bars to separate groups of related icons. The default implementation for this method displays the standard separator. Override this method in a derived visual manager to customize the appearance of the separator.  
  
##  \<a name="cmfcvisualmanager__ondrawshowallmenuitems">\</a>  CMFCVisualManager::OnDrawShowAllMenuItems  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>151\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>670\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>671\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>672\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__ondrawspinbuttons">\</a>  CMFCVisualManager::OnDrawSpinButtons  
 The framework calls this method when it draws an instance of the [CMFCSpinButtonCtrl Class](../vs140/cmfcspinbuttonctrl-class.md).  
  
<CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>673\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>674\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the spin control.  
  
 [in] <CodeContentPlaceHolder>675\</CodeContentPlaceHolder>  
 A flag that indicates the state of the spin control. See the Remarks section for more information.  
  
 [in] <CodeContentPlaceHolder>676\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies the orientation of the spin control. A value of <CodeContentPlaceHolder>677\</CodeContentPlaceHolder> indicates the spin control is horizontal. Otherwise, it is vertical.  
  
 [in] <CodeContentPlaceHolder>678\</CodeContentPlaceHolder>  
 A pointer to a spin control. The framework draws the buttons for this control.  
  
### Remarks  
 The <CodeContentPlaceHolder>679\</CodeContentPlaceHolder> parameter indicates the state of the spin control. The parameter is one of the following values:  
  
-   AFX_SPIN_PRESSEDUP  
  
-   AFX_SPIN_PRESSEDDOWN  
  
-   AFX_SPIN_HIGHLIGHTEDUP  
  
-   AFX_SPIN_HIGHLIGHTEDDOWN  
  
-   AFX_SPIN_DISABLED  
  
 Override this method in a derived visual manager to customize the appearance of a spin control.  
  
##  \<a name="cmfcvisualmanager__ondrawsplitterborder">\</a>  CMFCVisualManager::OnDrawSplitterBorder  
 The framework calls this method when it draws the border around an instance of the [CSplitterWndEx Class](../vs140/csplitterwndex-class.md).  
  
<CodeContentPlaceHolder>153\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>680\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>681\</CodeContentPlaceHolder>  
 A pointer to a splitter window. The framework draws the border for this window.  
  
 [in] <CodeContentPlaceHolder>682\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the splitter window.  
  
### Remarks  
 Override this method in a derived visual manager to customize the appearance of the border for a splitter window.  
  
##  \<a name="cmfcvisualmanager__ondrawsplitterbox">\</a>  CMFCVisualManager::OnDrawSplitterBox  
 The framework calls this method when it draws the drag box for an instance of the [CSplitterWndEx Class](../vs140/csplitterwndex-class.md). The drag box appears when the user selects the splitter bar and changes the dimensions of the child windows.  
  
<CodeContentPlaceHolder>154\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>683\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>684\</CodeContentPlaceHolder>  
 A pointer to a splitter window. The framework draws the box for this splitter window.  
  
 [in] <CodeContentPlaceHolder>685\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the splitter window.  
  
### Remarks  
 Override this method in a derived visual manager to customize the appearance of the drag box for a splitter window.  
  
##  \<a name="cmfcvisualmanager__ondrawstatusbarpaneborder">\</a>  CMFCVisualManager::OnDrawStatusBarPaneBorder  
 The framework calls this method when it draws the border for a [CMFCStatusBar](../vs140/cmfcstatusbar-class.md) object.  
  
<CodeContentPlaceHolder>155\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>686\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>687\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>688\</CodeContentPlaceHolder> object. The framework draws this status bar object.  
  
 [in] <CodeContentPlaceHolder>689\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the status bar.  
  
 [in] <CodeContentPlaceHolder>690\</CodeContentPlaceHolder>  
 The ID of the status bar.  
  
 [in] <CodeContentPlaceHolder>691\</CodeContentPlaceHolder>  
 The style of the status bar.  
  
### Remarks  
 Override this method in a derived visual manager to customize the appearance of the border for a <CodeContentPlaceHolder>692\</CodeContentPlaceHolder> object.  
  
##  \<a name="cmfcvisualmanager__ondrawstatusbarprogress">\</a>  CMFCVisualManager::OnDrawStatusBarProgress  
 The framework calls this method when it draws the progress indicator on the [CMFCStatusBar](../vs140/cmfcstatusbar-class.md) object.  
  
<CodeContentPlaceHolder>156\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>693\</CodeContentPlaceHolder>  
 A pointer to the device context for the status bar.  
  
 [in] <CodeContentPlaceHolder>694\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>695\</CodeContentPlaceHolder> object that contains the progress bar.  
  
 [in] <CodeContentPlaceHolder>696\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the progress bar.  
  
 [in] <CodeContentPlaceHolder>697\</CodeContentPlaceHolder>  
 The total number for the progress bar.  
  
 [in] <CodeContentPlaceHolder>698\</CodeContentPlaceHolder>  
 The current progress for the progress bar.  
  
 [in] <CodeContentPlaceHolder>699\</CodeContentPlaceHolder>  
 A                                 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) parameter that indicates the initial color for the progress bar. The value is either the start of a color gradient or the complete color of the progress bar.  
  
 [in] <CodeContentPlaceHolder>700\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>701\</CodeContentPlaceHolder> parameter that indicates the end of a color gradient for the progress bar. If <CodeContentPlaceHolder>702\</CodeContentPlaceHolder> is -1, the framework does not draw the progress bar as a color gradient. Instead, it fills the whole progress bar with the color specified by <CodeContentPlaceHolder>703\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>704\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>705\</CodeContentPlaceHolder> parameter that indicates the text color for the textual representation of the current progress. This parameter is ignored if <CodeContentPlaceHolder>706\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>707\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>708\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether to display the textual representation of the current progress.  
  
### Remarks  
 Override this method in a derived visual manager to customize the appearance of the <CodeContentPlaceHolder>709\</CodeContentPlaceHolder> object.  
  
##  \<a name="cmfcvisualmanager__ondrawstatusbarsizebox">\</a>  CMFCVisualManager::OnDrawStatusBarSizeBox  
 The framework calls this method when it draws the size box for a [CMFCStatusBar](../vs140/cmfcstatusbar-class.md).  
  
<CodeContentPlaceHolder>157\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>710\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>711\</CodeContentPlaceHolder>  
 A pointer to a status bar. The framework draws the size box for this status bar.  
  
 [in] <CodeContentPlaceHolder>712\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the size box.  
  
### Remarks  
 Override this method in a derived visual manager to customize the appearance of the size box on a <CodeContentPlaceHolder>713\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcvisualmanager__ondrawtab">\</a>  CMFCVisualManager::OnDrawTab  
 The framework calls this method when it draws the tabs for a [CMFCBaseTabCtrl](../vs140/cmfcbasetabctrl-class.md) object.  
  
<CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>714\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>715\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the tab control.  
  
 [in] <CodeContentPlaceHolder>716\</CodeContentPlaceHolder>  
 The index of the tab that the framework draws.  
  
 [in] <CodeContentPlaceHolder>717\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies whether the tab is active.  
  
 [in] <CodeContentPlaceHolder>718\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>719\</CodeContentPlaceHolder> object. The framework draws this tab control.  
  
### Remarks  
 A <CodeContentPlaceHolder>720\</CodeContentPlaceHolder> object calls this method when it processes the WM_PAINT message.  
  
 Override this method in a derived class to customize the look of tabs.  
  
##  \<a name="cmfcvisualmanager__ondrawtabclosebutton">\</a>  CMFCVisualManager::OnDrawTabCloseButton  
 The framework calls this method when it draws the **Close** button on the active tab.  
  
<CodeContentPlaceHolder>159\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>721\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>722\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the **Close** button.  
  
 [in] <CodeContentPlaceHolder>723\</CodeContentPlaceHolder>  
 A pointer to a tab control. The framework draws the **Close** button for this tab control.  
  
 [in] <CodeContentPlaceHolder>724\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the **Close** button is highlighted.  
  
 [in] <CodeContentPlaceHolder>725\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the **Close** button is pressed.  
  
 [in] <CodeContentPlaceHolder>726\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the **Close** button is disabled.  
  
### Remarks  
 Override this method in a derived visual manager to customize the appearance of the **Close** button on the active tab of <CodeContentPlaceHolder>727\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcvisualmanager__ondrawtabcontent">\</a>  CMFCVisualManager::OnDrawTabContent  
 The framework calls this method when it draws the contents located on the interior of an instance of the [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md).  
  
<CodeContentPlaceHolder>160\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>728\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>729\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the tab interior.  
  
 [in] <CodeContentPlaceHolder>730\</CodeContentPlaceHolder>  
 The zero-based index of the tab. The framework draws the interior of this tab.  
  
 [in] <CodeContentPlaceHolder>731\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether a tab is active.  
  
 [in] <CodeContentPlaceHolder>732\</CodeContentPlaceHolder>  
 A pointer to the tabbed control that contains the tab being drawn.  
  
 [in] <CodeContentPlaceHolder>733\</CodeContentPlaceHolder>  
 The color of text on the interior of the tab.  
  
### Remarks  
 The interior of a tab contains the text and icons of the tab. Override this method in a derived visual manager to customize the appearance of tabs.  
  
##  \<a name="cmfcvisualmanager__ondrawtabsbuttonborder">\</a>  CMFCVisualManager::OnDrawTabsButtonBorder  
 The framework calls this method when it draws the border of a tab button.  
  
<CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>734\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>735\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the tab button.  
  
 [in] <CodeContentPlaceHolder>736\</CodeContentPlaceHolder>  
 A pointer to a [CMFCButton](../vs140/cmfcbutton-class.md) object. The framework draws the border for this <CodeContentPlaceHolder>737\</CodeContentPlaceHolder> instance.  
  
 [in] <CodeContentPlaceHolder>738\</CodeContentPlaceHolder>  
 An unsigned integer that specifies the state of the button.  
  
 [in] <CodeContentPlaceHolder>739\</CodeContentPlaceHolder>  
 A pointer to the parent tab window.  
  
### Remarks  
 Override this method in a derived visual manager to customize the appearance of the border of the tab button.  
  
##  \<a name="cmfcvisualmanager__ondrawtask">\</a>  CMFCVisualManager::OnDrawTask  
 The framework calls this method when it draws a [CMFCTasksPane](../vs140/cmfctaskspane-class.md) object.  
  
<CodeContentPlaceHolder>162\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>740\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>741\</CodeContentPlaceHolder>  
 A pointer to a [CMFCTasksPaneTask](../vs140/cmfctaskspanetask-class.md) object. The framework draws this task.  
  
 [in] <CodeContentPlaceHolder>742\</CodeContentPlaceHolder>  
 A pointer to the image list associated with the task pane. Each task contains an index for an image in this list.  
  
 [in] <CodeContentPlaceHolder>743\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies whether the displayed task is highlighted.  
  
 [in] <CodeContentPlaceHolder>744\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies whether the displayed task is selected.  
  
### Remarks  
 The framework displays tasks on the task bar as both an icon and text. The <CodeContentPlaceHolder>745\</CodeContentPlaceHolder> parameter contains the icon for the task indicated by <CodeContentPlaceHolder>746\</CodeContentPlaceHolder>.  
  
 Override this method in a derived class to customize the appearance of tasks on the task bar.  
  
##  \<a name="cmfcvisualmanager__ondrawtasksgroupareaborder">\</a>  CMFCVisualManager::OnDrawTasksGroupAreaBorder  
 The framework calls this method when it draws a border around a group on a [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md).  
  
<CodeContentPlaceHolder>163\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>747\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>748\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the group area on the task pane.  
  
 [in] <CodeContentPlaceHolder>749\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies if the border is highlighted. A value of <CodeContentPlaceHolder>750\</CodeContentPlaceHolder> indicates that the border is highlighted.  
  
 [in] <CodeContentPlaceHolder>751\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies whether the group area has a title. A value of <CodeContentPlaceHolder>752\</CodeContentPlaceHolder> indicates that the group area does not have a title.  
  
### Remarks  
 Override this function in a derived class to customize the border around a group area on the task pane.  
  
##  \<a name="cmfcvisualmanager__ondrawtasksgroupcaption">\</a>  CMFCVisualManager::OnDrawTasksGroupCaption  
 The framework calls this method when it draws the caption for a [CMFCTasksPaneTaskGroup](../vs140/cmfctaskspanetaskgroup-class.md) object.  
  
<CodeContentPlaceHolder>164\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>753\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>754\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>755\</CodeContentPlaceHolder> object. The framework draws the caption for this group.  
  
 [in] <CodeContentPlaceHolder>756\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the group is highlighted.  
  
 [in] <CodeContentPlaceHolder>757\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the group is currently selected.  
  
 [in] <CodeContentPlaceHolder>758\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the group can be collapsed.  
  
### Remarks  
 The task groups appear on the [CMFCTasksPane](../vs140/cmfctaskspane-class.md) object.  
  
 Override this method in a derived class to customize the caption for a <CodeContentPlaceHolder>759\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcvisualmanager__ondrawtasksgroupicon">\</a>  CMFCVisualManager::OnDrawTasksGroupIcon  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>165\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>760\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>761\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>762\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>763\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>764\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>765\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__ondrawtearoffcaption">\</a>  CMFCVisualManager::OnDrawTearOffCaption  
 The framework calls this method when it draws the caption for a [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md).  
  
<CodeContentPlaceHolder>166\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>766\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>767\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the caption.  
  
 [in] <CodeContentPlaceHolder>768\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>769\</CodeContentPlaceHolder> if the caption is active; <CodeContentPlaceHolder>770\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 This function is called by the framework when a <CodeContentPlaceHolder>771\</CodeContentPlaceHolder> object processes a WM_PAINT message and must draw a tear-off caption.  
  
 Override this method in a derived class to customize the look of captions for tear-off bars.  
  
##  \<a name="cmfcvisualmanager__ondrawtoolboxframe">\</a>  CMFCVisualManager::OnDrawToolBoxFrame  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>167\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>772\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>773\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__onerasemdiclientarea">\</a>  CMFCVisualManager::OnEraseMDIClientArea  
 The framework calls this method when it erases the MDI client area.  
  
<CodeContentPlaceHolder>168\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>774\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>775\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the MDI client area.  
  
### Return Value  
 A reserved value. The default implementation returns <CodeContentPlaceHolder>776\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this method to execute custom code when the visual manager erases the MDI client area.  
  
##  \<a name="cmfcvisualmanager__onerasepopupwindowbutton">\</a>  CMFCVisualManager::OnErasePopupWindowButton  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>169\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>777\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>778\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>779\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__onerasetabsarea">\</a>  CMFCVisualManager::OnEraseTabsArea  
 The framework calls this method when it erases the tab area of a tab window.  
  
<CodeContentPlaceHolder>170\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>780\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>781\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the tab area.  
  
 [in] <CodeContentPlaceHolder>782\</CodeContentPlaceHolder>  
 A pointer to a tab window. The framework erases the tab area for the specified tab window.  
  
### Remarks  
 This function is called by the framework when a [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md) object processes a <CodeContentPlaceHolder>783\</CodeContentPlaceHolder> message and erases the tab area.  
  
 Override this method in a derived visual manager to customize the appearance of tabs.  
  
##  \<a name="cmfcvisualmanager__onerasetabsbutton">\</a>  CMFCVisualManager::OnEraseTabsButton  
 The framework calls this method when it erases the text and icon of a tab button.  
  
<CodeContentPlaceHolder>171\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>784\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>785\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the tab button.  
  
 [in] <CodeContentPlaceHolder>786\</CodeContentPlaceHolder>  
 A pointer to a tab button. The framework erases the text and icon for this button.  
  
 [in] <CodeContentPlaceHolder>787\</CodeContentPlaceHolder>  
 A pointer to the tab control that contains the tab button.  
  
### Remarks  
 The framework erases the text and icon for a button when a [CMFCBaseTabCtrl](../vs140/cmfcbasetabctrl-class.md) object processes the <CodeContentPlaceHolder>788\</CodeContentPlaceHolder> message.  
  
 Override this method in a derived visual manager to customize the appearance of tab buttons.  
  
##  \<a name="cmfcvisualmanager__onerasetabsframe">\</a>  CMFCVisualManager::OnEraseTabsFrame  
 The framework calls this method when it erases a frame on a [CMFCBaseTabCtrl](../vs140/cmfcbasetabctrl-class.md).  
  
<CodeContentPlaceHolder>172\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>789\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>790\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the tab window.  
  
 [in] <CodeContentPlaceHolder>791\</CodeContentPlaceHolder>  
 A pointer to a tab window. The framework erases a frame for this <CodeContentPlaceHolder>792\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>793\</CodeContentPlaceHolder> if the method is successful; <CodeContentPlaceHolder>794\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 This method fills the area indicated by <CodeContentPlaceHolder>795\</CodeContentPlaceHolder> with the background color of the active tab. It is called when a <CodeContentPlaceHolder>796\</CodeContentPlaceHolder> object processes a <CodeContentPlaceHolder>797\</CodeContentPlaceHolder> message and erases a tab frame.  
  
##  \<a name="cmfcvisualmanager__onfillautohidebuttonbackground">\</a>  CMFCVisualManager::OnFillAutoHideButtonBackground  
 The framework calls this method when it fills the background of an auto-hide button.  
  
<CodeContentPlaceHolder>173\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>798\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>799\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the auto-hide button.  
  
 [in] <CodeContentPlaceHolder>800\</CodeContentPlaceHolder>  
 A pointer to a [CMFCAutoHideButton](../vs140/cmfcautohidebutton-class.md) object. The framework fills the background for this auto-hide button.  
  
### Remarks  
 Override this method in a derived visual manager to customize the appearance of an auto-hide button.  
  
##  \<a name="cmfcvisualmanager__onfillbarbackground">\</a>  CMFCVisualManager::OnFillBarBackground  
 The framework calls this method when it fills the background of a [CBasePane](../vs140/cbasepane-class.md) object.  
  
<CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>801\</CodeContentPlaceHolder>  
 A pointer to the device context for a control bar.  
  
 [in] <CodeContentPlaceHolder>802\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>803\</CodeContentPlaceHolder> object. The framework fills the background of this pane.  
  
 [in] <CodeContentPlaceHolder>804\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the pane.  
  
 [in] <CodeContentPlaceHolder>805\</CodeContentPlaceHolder>  
 A rectangle that specifies the clipping area of the pane.  
  
 [in] <CodeContentPlaceHolder>806\</CodeContentPlaceHolder>  
 A reserved value.  
  
### Remarks  
 The default implementation of this method fills the background of the bar with the 3d background color from the global variable <CodeContentPlaceHolder>807\</CodeContentPlaceHolder>. Override this method in a derived visual manager to customize the background of a pane.  
  
### Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>808\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>809\</CodeContentPlaceHolder> class. This code snippet is part of the [Outlook Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_OutlookDemo#4](../vs140/codesnippet/CPP/cmfcvisualmanager-class_2.cpp)]  
  
##  \<a name="cmfcvisualmanager__onfillbuttoninterior">\</a>  CMFCVisualManager::OnFillButtonInterior  
 The framework calls this method when it fills the background of a toolbar button.  
  
<CodeContentPlaceHolder>175\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>810\</CodeContentPlaceHolder>  
 A pointer to the device context of a toolbar button.  
  
 [in] <CodeContentPlaceHolder>811\</CodeContentPlaceHolder>  
 A pointer to a [CMFCToolBarButton](../vs140/cmfctoolbarbutton-class.md). The framework fills the background for this button.  
  
 [in] <CodeContentPlaceHolder>812\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the toolbar button.  
  
 [in] <CodeContentPlaceHolder>813\</CodeContentPlaceHolder>  
 The state of the toolbar button.  
  
### Remarks  
 The default implementation of this method uses the default color to fill the background. Override this method in a derived visual manager to customize the background of a toolbar button.  
  
 The possible states of a toolbar button are <CodeContentPlaceHolder>814\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>815\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>816\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcvisualmanager__onfillcaptionbarbutton">\</a>  CMFCVisualManager::OnFillCaptionBarButton  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>176\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>817\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>818\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>819\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>820\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>821\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>822\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>823\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>824\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__onfillcommandslistbackground">\</a>  CMFCVisualManager::OnFillCommandsListBackground  
 The framework calls this method when it fills the background of a toolbar button that belongs to a command list. This command list is part of the customization dialog.  
  
<CodeContentPlaceHolder>177\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>825\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>826\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the button.  
  
 [in] <CodeContentPlaceHolder>827\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the button is selected.  
  
### Return Value  
 The text color for the toolbar button.  
  
### Remarks  
 For more information about the customization list, see [CMFCToolBarButton::OnDrawOnCustomizeList](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__ondrawoncustomizelist). The default implementation for this method fills the background based on the color scheme of the currently selected skin.  
  
##  \<a name="cmfcvisualmanager__onfillheaderctrlbackground">\</a>  CMFCVisualManager::OnFillHeaderCtrlBackground  
 The framework calls this method when it fills the background of a header control.  
  
<CodeContentPlaceHolder>178\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>828\</CodeContentPlaceHolder>  
 A pointer to a [CMFCHeaderCtrl](../vs140/cmfcheaderctrl-class.md) object. The framework fills the background for this header control.  
  
 [in] <CodeContentPlaceHolder>829\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>830\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the header control.  
  
### Remarks  
 Override this method in a derived visual manager to customize the appearance of a header control.  
  
##  \<a name="cmfcvisualmanager__onfillminiframecaption">\</a>  CMFCVisualManager::OnFillMiniFrameCaption  
 The framework calls this method when it fills the caption bar of a mini frame window.  
  
<CodeContentPlaceHolder>179\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>831\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>832\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the caption bar.  
  
 [in] <CodeContentPlaceHolder>833\</CodeContentPlaceHolder>  
 A pointer to a mini frame window. The framework draws the caption bar for this window.  
  
 [in] <CodeContentPlaceHolder>834\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates if the window is active.  
  
### Return Value  
 The color that is used to fill the background of the caption bar.  
  
### Remarks  
 The default implementation for this method fills the caption bar with the current caption color for the active skin.  
  
##  \<a name="cmfcvisualmanager__onfilloutlookbarcaption">\</a>  CMFCVisualManager::OnFillOutlookBarCaption  
 The framework calls this method when it fills the background of an Outlook caption bar.  
  
<CodeContentPlaceHolder>180\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>835\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>836\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the caption bar.  
  
 [out] <CodeContentPlaceHolder>837\</CodeContentPlaceHolder>  
 A reference to a                                 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) parameter. The method writes the color of text on the caption bar to this parameter.  
  
### Remarks  
 The default implementation of this method fills the caption bar with the color for shadows based on the current skin. Override this method in a derived visual manager to customize the color of the Outlook caption bar.  
  
##  \<a name="cmfcvisualmanager__onfilloutlookpagebutton">\</a>  CMFCVisualManager::OnFillOutlookPageButton  
 The framework calls this method when it fills the interior of an Outlook page button.  
  
<CodeContentPlaceHolder>181\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>838\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>839\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the Outlook page button.  
  
 [in] <CodeContentPlaceHolder>840\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies whether the button is highlighted.  
  
 [in] <CodeContentPlaceHolder>841\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies whether the button is pressed.  
  
 [out] <CodeContentPlaceHolder>842\</CodeContentPlaceHolder>  
 A reference to a                                 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) parameter. This method stores the text color of the outlook page button in this parameter.  
  
### Remarks  
 Override this function in a derived visual manager to customize the appearance of Outlook page buttons.  
  
##  \<a name="cmfcvisualmanager__onfillpopupwindowbackground">\</a>  CMFCVisualManager::OnFillPopupWindowBackground  
 The framework calls this method when it fills the background of a pop-up window.  
  
<CodeContentPlaceHolder>182\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>843\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>844\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the popup window.  
  
### Remarks  
 Override this method in a derived visual manager to customize the appearance of pop-up windows.  
  
##  \<a name="cmfcvisualmanager__onfillribbonbutton">\</a>  CMFCVisualManager::OnFillRibbonButton  
 The framework calls this method when it fills the interior of a ribbon button.  
  
<CodeContentPlaceHolder>183\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>845\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>846\</CodeContentPlaceHolder>  
 A pointer to a [CMFCRibbonButton](../vs140/cmfcribbonbutton-class.md) object. The framework fills the interior of this ribbon button.  
  
### Return Value  
 The color of text for the ribbon button specified by <CodeContentPlaceHolder>847\</CodeContentPlaceHolder> if the ribbon button supports text. A value of -1 if text is invalid for the ribbon button.  
  
### Remarks  
 Override this method in a derived visual manager to customize the appearance of ribbon buttons.  
  
##  \<a name="cmfcvisualmanager__onfillribbonedit">\</a>  CMFCVisualManager::OnFillRibbonEdit  
 The framework calls this method when it fills the interior of an instance of the <CodeContentPlaceHolder>848\</CodeContentPlaceHolder> class.  
  
<CodeContentPlaceHolder>184\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>849\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>850\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>851\</CodeContentPlaceHolder> object. The framework fills the interior of this edit control.  
  
 [in] <CodeContentPlaceHolder>852\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the edit control.  
  
 [in] <CodeContentPlaceHolder>853\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the edit control is highlighted.  
  
 [in] <CodeContentPlaceHolder>854\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the parent pane is highlighted.  
  
 [in] <CodeContentPlaceHolder>855\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the edit control is unavailable.  
  
 [in] <CodeContentPlaceHolder>856\</CodeContentPlaceHolder>  
 A reference to the text color of the edit control.  
  
 [in] <CodeContentPlaceHolder>857\</CodeContentPlaceHolder>  
 A reference to the background color of the edit control when it is highlighted.  
  
 [in] <CodeContentPlaceHolder>858\</CodeContentPlaceHolder>  
 A reference to the color of selected text on the edit control.  
  
### Remarks  
 The <CodeContentPlaceHolder>859\</CodeContentPlaceHolder> indicated by <CodeContentPlaceHolder>860\</CodeContentPlaceHolder> can be a part of a combo box button on the ribbon.  
  
 Override this method in a derived visual manager to customize the appearance of a <CodeContentPlaceHolder>861\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcvisualmanager__onfillribbonmainpanelbutton">\</a>  CMFCVisualManager::OnFillRibbonMainPanelButton  
 The framework calls this method when it fills the interior of a ribbon button located on the **Main** panel.  
  
<CodeContentPlaceHolder>185\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>862\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>863\</CodeContentPlaceHolder>  
 A pointer to a [CMFCRibbonButton Class](../vs140/cmfcribbonbutton-class.md) object. The framework fills this ribbon button.  
  
### Return Value  
 The color of text for the ribbon button specified by <CodeContentPlaceHolder>864\</CodeContentPlaceHolder> if the ribbon button supports text. A value of -1 if text is invalid for the ribbon button.  
  
### Remarks  
 Override this method in a derived visual manager to customize the appearance of ribbon buttons on the **Main** panel.  
  
##  \<a name="cmfcvisualmanager__onfillribbonmenuframe">\</a>  CMFCVisualManager::OnFillRibbonMenuFrame  
 The framework calls this method when it fills the menu frame of the ribbon panel.  
  
<CodeContentPlaceHolder>186\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>865\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>866\</CodeContentPlaceHolder>  
 A pointer to an instance of the [CMFCRibbonMainPanel Class](../vs140/cmfcribbonmainpanel-class.md). The framework fills the menu frame for this ribbon panel.  
  
 [in] <CodeContentPlaceHolder>867\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the menu frame.  
  
### Remarks  
 Override this method in a derived visual manager to customize the appearance of the menu bar for the <CodeContentPlaceHolder>868\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcvisualmanager__onfillribbonquickaccesstoolbarpopup">\</a>  CMFCVisualManager::OnFillRibbonQuickAccessToolBarPopup  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>187\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>869\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>870\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>871\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__onfillsplitterbackground">\</a>  CMFCVisualManager::OnFillSplitterBackground  
 The framework calls this method when it fills the background of a splitter window.  
  
<CodeContentPlaceHolder>188\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>872\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>873\</CodeContentPlaceHolder>  
 A pointer to an instance of the [CSplitterWndEx Class](../vs140/csplitterwndex-class.md). The framework fills the background for this splitter window.  
  
 [in] <CodeContentPlaceHolder>874\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the splitter window.  
  
### Remarks  
 Override this method in a derived visual manager to customize the appearance of a splitter window.  
  
##  \<a name="cmfcvisualmanager__onfilltab">\</a>  CMFCVisualManager::OnFillTab  
 The framework calls this method when it fills the background of a tab window.  
  
<CodeContentPlaceHolder>189\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>875\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>876\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries for the tab window.  
  
 [in] <CodeContentPlaceHolder>877\</CodeContentPlaceHolder>  
 A pointer to a brush. The framework uses this brush to fill the tab window.  
  
 [in] <CodeContentPlaceHolder>878\</CodeContentPlaceHolder>  
 The zero-based tab index of a tab for which the framework fills the background.  
  
 [in] <CodeContentPlaceHolder>879\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>880\</CodeContentPlaceHolder> if the tab is active; otherwise <CodeContentPlaceHolder>881\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>882\</CodeContentPlaceHolder>  
 A pointer to the parent tab control.  
  
### Remarks  
 Override this method in a derived visual manager to customize the appearance of tabs.  
  
##  \<a name="cmfcvisualmanager__onfilltasksgroupinterior">\</a>  CMFCVisualManager::OnFillTasksGroupInterior  
 The framework calls this method when it fills the interior of a [CMFCTasksPaneTaskGroup](../vs140/cmfctaskspanetaskgroup-class.md) object.  
  
<CodeContentPlaceHolder>190\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>883\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>884\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the task group.  
  
 [in] <CodeContentPlaceHolder>885\</CodeContentPlaceHolder>  
 A Boolean that indicates if the interior is filled with a special color.  
  
### Remarks  
 Override this method in a derived visual manager to customize the appearance of a task group.  
  
##  \<a name="cmfcvisualmanager__onfilltaskspanebackground">\</a>  CMFCVisualManager::OnFillTasksPaneBackground  
 The framework calls this method when it fills the background of a [CMFCTasksPane](../vs140/cmfctaskspane-class.md) control.  
  
<CodeContentPlaceHolder>191\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>886\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>887\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the task pane.  
  
### Remarks  
 Override this method in a derived visual manager to customize the appearance of a <CodeContentPlaceHolder>888\</CodeContentPlaceHolder> object.  
  
##  \<a name="cmfcvisualmanager__onhighlightmenuitem">\</a>  CMFCVisualManager::OnHighlightMenuItem  
 The framework calls this method when it draws a highlighted menu item.  
  
<CodeContentPlaceHolder>192\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>889\</CodeContentPlaceHolder>  
 A pointer to the device context for a menu.  
  
 [in] <CodeContentPlaceHolder>890\</CodeContentPlaceHolder>  
 A pointer to a [CMFCToolBarMenuButton](../vs140/cmfctoolbarmenubutton-class.md) object to display. The default implementation does not use this parameter.  
  
 [in] <CodeContentPlaceHolder>891\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the menu item.  
  
 [in] <CodeContentPlaceHolder>892\</CodeContentPlaceHolder>  
 The current text color of highlighted menu items. The default implementation does not use this parameter.  
  
### Remarks  
 The default implementation of this method does not use the parameters <CodeContentPlaceHolder>893\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>894\</CodeContentPlaceHolder>. It fills the rectangle specified by <CodeContentPlaceHolder>895\</CodeContentPlaceHolder> with the standard background color.  
  
 Override this method in a derived visual manager to customize the appearance of highlighted menu items. Use the <CodeContentPlaceHolder>896\</CodeContentPlaceHolder> parameter to modify the text color of a highlighted menu item.  
  
##  \<a name="cmfcvisualmanager__onhighlightrarelyusedmenuitems">\</a>  CMFCVisualManager::OnHighlightRarelyUsedMenuItems  
 The framework calls this method when it draws a highlighted menu command.  
  
<CodeContentPlaceHolder>193\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>897\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>898\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the highlighted command.  
  
### Remarks  
 Override this method in a derived visual manager to customize the appearance of highlighted menu commands.  
  
##  \<a name="cmfcvisualmanager__onncactivate">\</a>  CMFCVisualManager::OnNcActivate  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>194\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>899\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>900\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__onncpaint">\</a>  CMFCVisualManager::OnNcPaint  
 The framework calls this method when it draws the non-client area.  
  
<CodeContentPlaceHolder>195\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>901\</CodeContentPlaceHolder>  
 A pointer to the window whose non-client area the framework draws.  
  
 [in] <CodeContentPlaceHolder>902\</CodeContentPlaceHolder>  
 A list of system buttons. These are also known as caption buttons.  
  
 [in] <CodeContentPlaceHolder>903\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the non-client area.  
  
### Return Value  
 A reserved value. The default implementation returns <CodeContentPlaceHolder>904\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this method in a derived visual manager to customize the appearance of the window frame and caption buttons.  
  
##  \<a name="cmfcvisualmanager__onsetwindowregion">\</a>  CMFCVisualManager::OnSetWindowRegion  
 The framework calls this method after it sets a region that contains frames and pop-up menus.  
  
<CodeContentPlaceHolder>196\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>905\</CodeContentPlaceHolder>  
 A pointer to the window with the region that changed.  
  
 [in] <CodeContentPlaceHolder>906\</CodeContentPlaceHolder>  
 The size of the window.  
  
### Return Value  
 <CodeContentPlaceHolder>907\</CodeContentPlaceHolder> if the method is successful; <CodeContentPlaceHolder>908\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 The framework calls this method to notify the visual manager that a region has been set for frames and pop-up menus. For more information, see [CWindow::SetWindowRgn](../vs140/cwindow--setwindowrgn.md).  
  
##  \<a name="cmfcvisualmanager__onupdatesystemcolors">\</a>  CMFCVisualManager::OnUpdateSystemColors  
 The framework calls this function when it changes the system colors.  
  
<CodeContentPlaceHolder>197\</CodeContentPlaceHolder>  
### Remarks  
 The framework calls this method as a part of processing the <CodeContentPlaceHolder>909\</CodeContentPlaceHolder> message. The default implementation does nothing. Override this method in a derived visual manager if you want to execute custom code when the colors change in your application.  
  
##  \<a name="cmfcvisualmanager__redrawall">\</a>  CMFCVisualManager::RedrawAll  
 Immediately redraws all the control bars in the application.  
  
<CodeContentPlaceHolder>198\</CodeContentPlaceHolder>  
##  \<a name="cmfcvisualmanager__ribboncategorycolortorgb">\</a>  CMFCVisualManager::RibbonCategoryColorToRGB  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>199\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>910\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanager__setdefaultmanager">\</a>  CMFCVisualManager::SetDefaultManager  
 Sets the default manager.  
  
<CodeContentPlaceHolder>200\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>911\</CodeContentPlaceHolder>  
 A pointer to the runtime information for a visual manager.  
  
### Remarks  
 Use the [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md) and any derived visual managers to customize the appearance of your application. After you set the default visual manager, this method redraws your application by using the new visual manager. For more information about how to use visual managers, see [The Visualization Manager](../vs140/visualization-manager.md).  
  
 Use this method to change the visual manager that your application uses.  
  
##  \<a name="cmfcvisualmanager__setembossdisabledimage">\</a>  CMFCVisualManager::SetEmbossDisabledImage  
 Enables or disables the embossed mode for disabled toolbar images.  
  
<CodeContentPlaceHolder>201\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>912\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether to enable embossed mode for disabled toolbar images.  
  
### Remarks  
 Use the function [CMFCVisualManager::IsEmbossDisabledImage](#cmfcvisualmanager__isembossdisabledimage) to determine whether embossed mode is enabled.  
  
##  \<a name="cmfcvisualmanager__setfadeinactiveimage">\</a>  CMFCVisualManager::SetFadeInactiveImage  
 Enables or disables the lighting effect for inactive images on a menu or toolbar.  
  
<CodeContentPlaceHolder>202\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>913\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies whether to enable the lighting effect.  
  
### Remarks  
 This feature controls whether inactive images appear faded on a menu or toolbar. Use the method [CMFCVisualManager::IsFadeInactiveImage](#cmfcvisualmanager__isfadeinactiveimage) to determine whether this feature is enabled.  
  
##  \<a name="cmfcvisualmanager__setmenuflatlook">\</a>  CMFCVisualManager::SetMenuFlatLook  
 Sets a flag that indicates whether the menu buttons appear flat. Otherwise, they appear three-dimensional.  
  
<CodeContentPlaceHolder>203\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>914\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the menu buttons appear flat.  
  
### Remarks  
 By default, this feature is not enabled.  
  
##  \<a name="cmfcvisualmanager__setmenushadowdepth">\</a>  CMFCVisualManager::SetMenuShadowDepth  
 Sets the width and height of the menu shadow.  
  
<CodeContentPlaceHolder>204\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>915\</CodeContentPlaceHolder>  
 An integer that specifies the depth of the menu shadow in pixels.  
  
### Remarks  
 The height and width of the menu shadow must be identical. The default value is 7 pixels.  
  
##  \<a name="cmfcvisualmanager__setshadowhighlightedimage">\</a>  CMFCVisualManager::SetShadowHighlightedImage  
 Sets a flag that indicates whether the [CMFCVisualManager](../vs140/cmfcvisualmanager-class.md) displays shadows for highlighted images.  
  
<CodeContentPlaceHolder>205\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>916\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the visual manager displays a shadow under highlighted images.  
  
### Remarks  
 By default, this feature is disabled.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCVisualManager::GetInstance](#cmfcvisualmanager__getinstance)   
 [The Visualization Manager](../vs140/visualization-manager.md)