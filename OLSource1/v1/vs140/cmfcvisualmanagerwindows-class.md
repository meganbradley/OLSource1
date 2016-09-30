---
title: "CMFCVisualManagerWindows Class"
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
  - "CMFCVisualManagerWindows"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCVisualManagerWindows class"
ms.assetid: 568b6e9e-8e67-4477-9a3d-2981cbd09861
caps.latest.revision: 45
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerWindows Class
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder> mimics the appearance of Microsoft Windows XP or Microsoft Vista when the user selects a Windows XP or Vista theme.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>|Default constructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCVisualManagerWindows::AlwaysHighlight3DTabs](#cmfcvisualmanagerwindows__alwayshighlight3dtabs)|The framework calls this method to determine whether 3D tabs should always be highlighted in the application. (Overrides [CMFCVisualManager::AlwaysHighlight3DTabs](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__alwayshighlight3dtabs).)|  
|[CMFCVisualManagerWindows::DrawComboBorderWinXP](#cmfcvisualmanagerwindows__drawcomboborderwinxp)|(Overrides <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::DrawComboDropButtonWinXP](#cmfcvisualmanagerwindows__drawcombodropbuttonwinxp)|(Overrides [CMFCVisualManager::DrawComboDropButtonWinXP](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__drawcombodropbuttonwinxp).)|  
|[CMFCVisualManagerWindows::DrawPushButtonWinXP](#cmfcvisualmanagerwindows__drawpushbuttonwinxp)|(Overrides [CMFCVisualManager::DrawPushButtonWinXP](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__drawpushbuttonwinxp).)|  
|[CMFCVisualManagerWindows::GetButtonExtraBorder](#cmfcvisualmanagerwindows__getbuttonextraborder)|The framework calls this method when it draws a toolbar button. (Overrides [CMFCVisualManager::GetButtonExtraBorder](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__getbuttonextraborder).)|  
|[CMFCVisualManagerWindows::GetCaptionButtonExtraBorder](#cmfcvisualmanagerwindows__getcaptionbuttonextraborder)|(Overrides [CMFCVisualManager::GetCaptionButtonExtraBorder](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__getcaptionbuttonextraborder).)|  
|[CMFCVisualManagerWindows::GetDockingPaneCaptionExtraHeight](#cmfcvisualmanagerwindows__getdockingpanecaptionextraheight)|(Overrides <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::GetHighlightedMenuItemTextColor](#cmfcvisualmanagerwindows__gethighlightedmenuitemtextcolor)|(Overrides <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::GetPopupMenuGap](#cmfcvisualmanagerwindows__getpopupmenugap)|(Overrides <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::GetToolbarButtonTextColor](#cmfcvisualmanagerwindows__gettoolbarbuttontextcolor)|(Overrides <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::IsDefaultWinXPPopupButton](#cmfcvisualmanagerwindows__isdefaultwinxppopupbutton)|(Overrides [CMFCVisualManager::IsDefaultWinXPPopupButton](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__isdefaultwinxppopupbutton).)|  
|[CMFCVisualManagerWindows::IsHighlightWholeMenuItem](#cmfcvisualmanagerwindows__ishighlightwholemenuitem)|(Overrides <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::IsOfficeStyleMenus](#cmfcvisualmanagerwindows__isofficestylemenus)||  
|[CMFCVisualManagerWindows::IsOfficeXPStyleMenus](#cmfcvisualmanagerwindows__isofficexpstylemenus)|Indicates whether the visual manager implements Office XP-style menus. (Overrides [CMFCVisualManager::IsOfficeXPStyleMenus](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__isofficexpstylemenus).)|  
|[CMFCVisualManagerWindows::IsWindowsThemingSupported](#cmfcvisualmanagerwindows__iswindowsthemingsupported)|(Overrides <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::IsWinXPThemeAvailable](#cmfcvisualmanagerwindows__iswinxpthemeavailable)|Indicates whether a Windows theme is available. A theme can be either a Windows XP theme or a [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] theme.|  
|[CMFCVisualManagerWindows::OnDrawBarGripper](#cmfcvisualmanagerwindows__ondrawbargripper)|(Overrides <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnDrawBrowseButton](#cmfcvisualmanagerwindows__ondrawbrowsebutton)|(Overrides <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnDrawButtonBorder](#cmfcvisualmanagerwindows__ondrawbuttonborder)|(Overrides <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnDrawButtonSeparator](#cmfcvisualmanagerwindows__ondrawbuttonseparator)|(Overrides <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnDrawCaptionButton](#cmfcvisualmanagerwindows__ondrawcaptionbutton)|(Overrides <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnDrawCaptionButtonIcon](#cmfcvisualmanagerwindows__ondrawcaptionbuttonicon)|(Overrides <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnDrawCheckBoxEx](#cmfcvisualmanagerwindows__ondrawcheckboxex)|(Overrides [CMFCVisualManager::OnDrawCheckBoxEx](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondrawcheckboxex).)|  
|[CMFCVisualManagerWindows::OnDrawComboBorder](#cmfcvisualmanagerwindows__ondrawcomboborder)|(Overrides <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnDrawComboDropButton](#cmfcvisualmanagerwindows__ondrawcombodropbutton)|(Overrides <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnDrawControlBorder](#cmfcvisualmanagerwindows__ondrawcontrolborder)|(Overrides [CMFCVisualManager::OnDrawControlBorder](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondrawcontrolborder).)|  
|[CMFCVisualManagerWindows::OnDrawEditBorder](#cmfcvisualmanagerwindows__ondraweditborder)|(Overrides <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnDrawExpandingBox](#cmfcvisualmanagerwindows__ondrawexpandingbox)|(Overrides [CMFCVisualManager::OnDrawExpandingBox](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondrawexpandingbox).)|  
|[CMFCVisualManagerWindows::OnDrawFloatingToolbarBorder](#cmfcvisualmanagerwindows__ondrawfloatingtoolbarborder)|(Overrides <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnDrawHeaderCtrlBorder](#cmfcvisualmanagerwindows__ondrawheaderctrlborder)|The framework calls this method when it draws the border around an instance of the [CMFCHeaderCtrl Class](../vs140/cmfcheaderctrl-class.md). (Overrides [CMFCVisualManager::OnDrawHeaderCtrlBorder](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondrawheaderctrlborder).)|  
|[CMFCVisualManagerWindows::OnDrawHeaderCtrlSortArrow](#cmfcvisualmanagerwindows__ondrawheaderctrlsortarrow)|The framework calls this function when it draws the sort arrow of a header control. (Overrides [CMFCVisualManager::OnDrawHeaderCtrlSortArrow](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondrawheaderctrlsortarrow).)|  
|[CMFCVisualManagerWindows::OnDrawMenuBorder](#cmfcvisualmanagerwindows__ondrawmenuborder)|(Overrides <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnDrawMenuSystemButton](#cmfcvisualmanagerwindows__ondrawmenusystembutton)|(Overrides <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnDrawMiniFrameBorder](#cmfcvisualmanagerwindows__ondrawminiframeborder)|(Overrides <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnDrawOutlookPageButtonBorder](#cmfcvisualmanagerwindows__ondrawoutlookpagebuttonborder)|Called by the framework when it draws the border of an Outlook page button. (Overrides [CMFCVisualManager::OnDrawOutlookPageButtonBorder](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondrawoutlookpagebuttonborder).)|  
|[CMFCVisualManagerWindows::OnDrawPaneBorder](#cmfcvisualmanagerwindows__ondrawpaneborder)|(Overrides <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnDrawPaneCaption](#cmfcvisualmanagerwindows__ondrawpanecaption)|(Overrides <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnDrawPopupWindowButtonBorder](#cmfcvisualmanagerwindows__ondrawpopupwindowbuttonborder)|(Overrides <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnDrawScrollButtons](#cmfcvisualmanagerwindows__ondrawscrollbuttons)|(Overrides <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnDrawSeparator](#cmfcvisualmanagerwindows__ondrawseparator)|(Overrides <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnDrawSpinButtons](#cmfcvisualmanagerwindows__ondrawspinbuttons)|(Overrides <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnDrawStatusBarPaneBorder](#cmfcvisualmanagerwindows__ondrawstatusbarpaneborder)|(Overrides <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnDrawStatusBarProgress](#cmfcvisualmanagerwindows__ondrawstatusbarprogress)|The framework calls this method when it draws the progress indicator on the [CMFCStatusBar](../vs140/cmfcstatusbar-class.md) object. (Overrides [CMFCVisualManager::OnDrawStatusBarProgress](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondrawstatusbarprogress).)|  
|[CMFCVisualManagerWindows::OnDrawStatusBarSizeBox](#cmfcvisualmanagerwindows__ondrawstatusbarsizebox)|The framework calls this method when it draws the size box for a [CMFCStatusBar](../vs140/cmfcstatusbar-class.md). (Overrides [CMFCVisualManager::OnDrawStatusBarSizeBox](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondrawstatusbarsizebox).)|  
|[CMFCVisualManagerWindows::OnDrawTab](#cmfcvisualmanagerwindows__ondrawtab)|(Overrides <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnDrawTabCloseButton](#cmfcvisualmanagerwindows__ondrawtabclosebutton)|(Overrides <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnDrawTabsButtonBorder](#cmfcvisualmanagerwindows__ondrawtabsbuttonborder)|(Overrides <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnDrawTask](#cmfcvisualmanagerwindows__ondrawtask)|(Overrides <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnDrawTasksGroupAreaBorder](#cmfcvisualmanagerwindows__ondrawtasksgroupareaborder)|(Overrides <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnDrawTasksGroupCaption](#cmfcvisualmanagerwindows__ondrawtasksgroupcaption)|(Overrides <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnDrawTearOffCaption](#cmfcvisualmanagerwindows__ondrawtearoffcaption)|(Overrides <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnErasePopupWindowButton](#cmfcvisualmanagerwindows__onerasepopupwindowbutton)|(Overrides <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnEraseTabsArea](#cmfcvisualmanagerwindows__onerasetabsarea)|(Overrides <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnEraseTabsButton](#cmfcvisualmanagerwindows__onerasetabsbutton)|(Overrides <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnEraseTabsFrame](#cmfcvisualmanagerwindows__onerasetabsframe)|The framework calls this method when it erases a frame on a [CMFCBaseTabCtrl](../vs140/cmfcbasetabctrl-class.md). (Overrides [CMFCVisualManager::OnEraseTabsFrame](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__onerasetabsframe).)|  
|[CMFCVisualManagerWindows::OnFillBarBackground](#cmfcvisualmanagerwindows__onfillbarbackground)|(Overrides <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnFillButtonInterior](#cmfcvisualmanagerwindows__onfillbuttoninterior)|(Overrides <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnFillCommandsListBackground](#cmfcvisualmanagerwindows__onfillcommandslistbackground)|(Overrides <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnFillMiniFrameCaption](#cmfcvisualmanagerwindows__onfillminiframecaption)|(Overrides <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnFillOutlookPageButton](#cmfcvisualmanagerwindows__onfilloutlookpagebutton)|The framework calls this method when it fills the interior of an Outlook page button. (Overrides [CMFCVisualManager::OnFillOutlookPageButton](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__onfilloutlookpagebutton).)|  
|[CMFCVisualManagerWindows::OnFillTasksGroupInterior](#cmfcvisualmanagerwindows__onfilltasksgroupinterior)|(Overrides <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnFillTasksPaneBackground](#cmfcvisualmanagerwindows__onfilltaskspanebackground)|The framework calls this method when it fills the background of a [CMFCTasksPane](../vs140/cmfctaskspane-class.md) control. (Overrides [CMFCVisualManager::OnFillTasksPaneBackground](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__onfilltaskspanebackground).)|  
|[CMFCVisualManagerWindows::OnHighlightMenuItem](#cmfcvisualmanagerwindows__onhighlightmenuitem)|(Overrides <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnHighlightRarelyUsedMenuItems](#cmfcvisualmanagerwindows__onhighlightrarelyusedmenuitems)|(Overrides <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::OnUpdateSystemColors](#cmfcvisualmanagerwindows__onupdatesystemcolors)|(Overrides <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>.)|  
|[CMFCVisualManagerWindows::SetOfficeStyleMenus](#cmfcvisualmanagerwindows__setofficestylemenus)||  
  
### Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCVisualManagerWindows::m_b3DTabsXPTheme](#cmfcvisualmanagerwindows__m_b3dtabsxptheme)|Specifies whether the Windows XP theme displays 3D tabs.|  
  
## Remarks  
 Use the <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> class to change the appearance of your application to mimic the current Windows XP or [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] theme on the computer where the application runs.  
  
 However, a Windows theme might be unavailable if your application is running on a version of Windows earlier than Windows XP or if themes are disabled because the user is using the **Classic** view. If no theme is available, the application uses the default visual manager defined in [CMFCVisualManager](../vs140/cmfcvisualmanager-class.md).  
  
## Example  
 The following example demonstrates how to use <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>. This code snippet is part of the [Desktop Alert Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_DesktopAlertDemo#10](../vs140/codesnippet/CPP/cmfcvisualmanagerwindows-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMFCBaseVisualManager](../vs140/cmfcbasevisualmanager-class.md)  
  
 [CMFCVisualManager](../vs140/cmfcvisualmanager-class.md)  
  
 [CMFCVisualManagerOfficeXP](../vs140/cmfcvisualmanagerofficexp-class.md)  
  
 [CMFCVisualManagerWindows](../vs140/cmfcvisualmanagerwindows-class.md)  
  
## Requirements  
 **Header:** afxvisualmanagerwindows.h  
  
##  \<a name="cmfcvisualmanagerwindows__alwayshighlight3dtabs">\</a>  CMFCVisualManagerWindows::AlwaysHighlight3DTabs  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__cmfcvisualmanagerwindows">\</a>  CMFCVisualManagerWindows::CMFCVisualManagerWindows  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__drawcomboborderwinxp">\</a>  CMFCVisualManagerWindows::DrawComboBorderWinXP  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__drawcombodropbuttonwinxp">\</a>  CMFCVisualManagerWindows::DrawComboDropButtonWinXP  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__drawpushbuttonwinxp">\</a>  CMFCVisualManagerWindows::DrawPushButtonWinXP  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__getbuttonextraborder">\</a>  CMFCVisualManagerWindows::GetButtonExtraBorder  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__getcaptionbuttonextraborder">\</a>  CMFCVisualManagerWindows::GetCaptionButtonExtraBorder  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__getdockingpanecaptionextraheight">\</a>  CMFCVisualManagerWindows::GetDockingPaneCaptionExtraHeight  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__gethighlightedmenuitemtextcolor">\</a>  CMFCVisualManagerWindows::GetHighlightedMenuItemTextColor  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__getpopupmenugap">\</a>  CMFCVisualManagerWindows::GetPopupMenuGap  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__gettoolbarbuttontextcolor">\</a>  CMFCVisualManagerWindows::GetToolbarButtonTextColor  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__isdefaultwinxppopupbutton">\</a>  CMFCVisualManagerWindows::IsDefaultWinXPPopupButton  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ishighlightwholemenuitem">\</a>  CMFCVisualManagerWindows::IsHighlightWholeMenuItem  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__isofficestylemenus">\</a>  CMFCVisualManagerWindows::IsOfficeStyleMenus  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__isofficexpstylemenus">\</a>  CMFCVisualManagerWindows::IsOfficeXPStyleMenus  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__iswindowsthemingsupported">\</a>  CMFCVisualManagerWindows::IsWindowsThemingSupported  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__iswinxpthemeavailable">\</a>  CMFCVisualManagerWindows::IsWinXPThemeAvailable  
 Determines whether a Windows XP or [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] theme is available.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if a theme is available; otherwise 0.  
  
### Remarks  
 This method is valid for both Windows XP and [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] themes.  
  
 <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> is identical to <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> except that <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> is a static method. Therefore, it will create a temporary visual manager if one does not exist.  
  
 <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> always return 0s for versions of Windows earlier than Windows XP.  
  
##  \<a name="cmfcvisualmanagerwindows__m_b3dtabsxptheme">\</a>  CMFCVisualManagerWindows::m_b3DTabsXPTheme  
 A Boolean parameter that determines whether the visual manager displays 3D tabs.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
##  \<a name="cmfcvisualmanagerwindows__ondrawbargripper">\</a>  CMFCVisualManagerWindows::OnDrawBarGripper  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ondrawbrowsebutton">\</a>  CMFCVisualManagerWindows::OnDrawBrowseButton  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ondrawbuttonborder">\</a>  CMFCVisualManagerWindows::OnDrawButtonBorder  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ondrawbuttonseparator">\</a>  CMFCVisualManagerWindows::OnDrawButtonSeparator  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ondrawcaptionbutton">\</a>  CMFCVisualManagerWindows::OnDrawCaptionButton  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ondrawcaptionbuttonicon">\</a>  CMFCVisualManagerWindows::OnDrawCaptionButtonIcon  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ondrawcheckboxex">\</a>  CMFCVisualManagerWindows::OnDrawCheckBoxEx  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ondrawcomboborder">\</a>  CMFCVisualManagerWindows::OnDrawComboBorder  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ondrawcombodropbutton">\</a>  CMFCVisualManagerWindows::OnDrawComboDropButton  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ondrawcontrolborder">\</a>  CMFCVisualManagerWindows::OnDrawControlBorder  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ondraweditborder">\</a>  CMFCVisualManagerWindows::OnDrawEditBorder  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ondrawexpandingbox">\</a>  CMFCVisualManagerWindows::OnDrawExpandingBox  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>199\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ondrawfloatingtoolbarborder">\</a>  CMFCVisualManagerWindows::OnDrawFloatingToolbarBorder  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ondrawheaderctrlborder">\</a>  CMFCVisualManagerWindows::OnDrawHeaderCtrlBorder  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>205\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>208\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ondrawheaderctrlsortarrow">\</a>  CMFCVisualManagerWindows::OnDrawHeaderCtrlSortArrow  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>209\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>210\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>211\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>212\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ondrawmenuborder">\</a>  CMFCVisualManagerWindows::OnDrawMenuBorder  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>214\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ondrawmenusystembutton">\</a>  CMFCVisualManagerWindows::OnDrawMenuSystemButton  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>217\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>219\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ondrawminiframeborder">\</a>  CMFCVisualManagerWindows::OnDrawMiniFrameBorder  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>221\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>222\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>224\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ondrawoutlookpagebuttonborder">\</a>  CMFCVisualManagerWindows::OnDrawOutlookPageButtonBorder  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>226\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>227\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>228\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ondrawpaneborder">\</a>  CMFCVisualManagerWindows::OnDrawPaneBorder  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>229\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>230\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>231\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ondrawpanecaption">\</a>  CMFCVisualManagerWindows::OnDrawPaneCaption  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>232\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>233\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>234\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>235\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>236\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ondrawpopupwindowbuttonborder">\</a>  CMFCVisualManagerWindows::OnDrawPopupWindowButtonBorder  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>237\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>238\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>239\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ondrawscrollbuttons">\</a>  CMFCVisualManagerWindows::OnDrawScrollButtons  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>240\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>241\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>242\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>243\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>244\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ondrawseparator">\</a>  CMFCVisualManagerWindows::OnDrawSeparator  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>245\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>246\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>247\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>248\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ondrawspinbuttons">\</a>  CMFCVisualManagerWindows::OnDrawSpinButtons  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>249\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>250\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>251\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>252\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>253\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ondrawstatusbarpaneborder">\</a>  CMFCVisualManagerWindows::OnDrawStatusBarPaneBorder  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>254\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>255\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>256\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>257\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>258\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ondrawstatusbarprogress">\</a>  CMFCVisualManagerWindows::OnDrawStatusBarProgress  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>259\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>260\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>261\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>262\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>263\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>264\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>265\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>266\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>267\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ondrawstatusbarsizebox">\</a>  CMFCVisualManagerWindows::OnDrawStatusBarSizeBox  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>268\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>269\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>270\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ondrawtab">\</a>  CMFCVisualManagerWindows::OnDrawTab  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>271\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>272\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>273\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>274\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>275\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ondrawtabclosebutton">\</a>  CMFCVisualManagerWindows::OnDrawTabCloseButton  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>276\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>277\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>278\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>279\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>280\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>281\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ondrawtabsbuttonborder">\</a>  CMFCVisualManagerWindows::OnDrawTabsButtonBorder  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>282\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>283\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>284\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>285\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>286\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ondrawtask">\</a>  CMFCVisualManagerWindows::OnDrawTask  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>287\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>288\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>289\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>290\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>291\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ondrawtasksgroupareaborder">\</a>  CMFCVisualManagerWindows::OnDrawTasksGroupAreaBorder  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>292\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>293\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>294\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>295\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ondrawtasksgroupcaption">\</a>  CMFCVisualManagerWindows::OnDrawTasksGroupCaption  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>296\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>297\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>298\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>299\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>300\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__ondrawtearoffcaption">\</a>  CMFCVisualManagerWindows::OnDrawTearOffCaption  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>301\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>302\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>303\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__onerasepopupwindowbutton">\</a>  CMFCVisualManagerWindows::OnErasePopupWindowButton  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>304\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>305\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>306\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__onerasetabsarea">\</a>  CMFCVisualManagerWindows::OnEraseTabsArea  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>307\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>308\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>309\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__onerasetabsbutton">\</a>  CMFCVisualManagerWindows::OnEraseTabsButton  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>310\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>311\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>312\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>313\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__onerasetabsframe">\</a>  CMFCVisualManagerWindows::OnEraseTabsFrame  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>314\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>315\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>316\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__onfillbarbackground">\</a>  CMFCVisualManagerWindows::OnFillBarBackground  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>317\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>318\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>319\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>320\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>321\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__onfillbuttoninterior">\</a>  CMFCVisualManagerWindows::OnFillButtonInterior  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>322\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>323\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>324\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>325\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__onfillcommandslistbackground">\</a>  CMFCVisualManagerWindows::OnFillCommandsListBackground  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>326\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>327\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>328\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__onfillminiframecaption">\</a>  CMFCVisualManagerWindows::OnFillMiniFrameCaption  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>329\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>330\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>331\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>332\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__onfilloutlookpagebutton">\</a>  CMFCVisualManagerWindows::OnFillOutlookPageButton  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>333\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>334\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>335\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>336\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>337\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__onfilltasksgroupinterior">\</a>  CMFCVisualManagerWindows::OnFillTasksGroupInterior  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>338\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>339\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>340\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__onfilltaskspanebackground">\</a>  CMFCVisualManagerWindows::OnFillTasksPaneBackground  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>341\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>342\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__onhighlightmenuitem">\</a>  CMFCVisualManagerWindows::OnHighlightMenuItem  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>343\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>344\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>345\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>346\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__onhighlightrarelyusedmenuitems">\</a>  CMFCVisualManagerWindows::OnHighlightRarelyUsedMenuItems  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>347\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>348\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__onupdatesystemcolors">\</a>  CMFCVisualManagerWindows::OnUpdateSystemColors  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows__setofficestylemenus">\</a>  CMFCVisualManagerWindows::SetOfficeStyleMenus  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>349\</CodeContentPlaceHolder>  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [CMFCVisualManagerOfficeXP](../vs140/cmfcvisualmanagerofficexp-class.md)   
 [CMFCVisualManager::SetDefaultManager](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__setdefaultmanager)