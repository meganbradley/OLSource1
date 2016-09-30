---
title: "CMFCPopupMenu Class"
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
  - "CMFCPopupMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCPopupMenu class"
ms.assetid: 9555dca1-8c9c-44c9-af72-0659ddad128e
caps.latest.revision: 39
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPopupMenu Class
Implements Windows pop-up menu functionality and extends it by adding features such as tear-off menus and tooltips.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Protected Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCPopupMenu::CMFCPopupMenu](#cmfcpopupmenu__cmfcpopupmenu)|Constructs a <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCPopupMenu::ActivatePopupMenu](#cmfcpopupmenu__activatepopupmenu)||  
|[CMFCPopupMenu::AlwaysShowEmptyToolsEntry](#cmfcpopupmenu__alwaysshowemptytoolsentry)|Sets whether a pop-up menu is enabled to show empty entries for user-defined tools.|  
|[CMFCPopupMenu::AreAllCommandsShown](#cmfcpopupmenu__areallcommandsshown)||  
|[CMFCPopupMenu::CheckArea](#cmfcpopupmenu__checkarea)|Determines the location of a point relative to the pop-up menu.|  
|[CMFCPopupMenu::CloseMenu](#cmfcpopupmenu__closemenu)||  
|[CMFCPopupMenu::Create](#cmfcpopupmenu__create)|Creates a pop-up menu and attaches it to the <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> object.|  
|[CMFCPopupMenu::DefaultMouseClickOnClose](#cmfcpopupmenu__defaultmouseclickonclose)||  
|[CMFCPopupMenu::EnableMenuLogo](#cmfcpopupmenu__enablemenulogo)|Initializes the logo for a pop-up menu.|  
|[CMFCPopupMenu::EnableMenuSound](#cmfcpopupmenu__enablemenusound)|Enables menu sound.|  
|[CMFCPopupMenu::EnableResize](#cmfcpopupmenu__enableresize)||  
|[CMFCPopupMenu::EnableScrolling](#cmfcpopupmenu__enablescrolling)||  
|[CMFCPopupMenu::EnableVertResize](#cmfcpopupmenu__enablevertresize)||  
|[CMFCPopupMenu::FindSubItemByCommand](#cmfcpopupmenu__findsubitembycommand)||  
|[CMFCPopupMenu::GetActiveMenu](#cmfcpopupmenu__getactivemenu)|Returns the currently active menu.|  
|[CMFCPopupMenu::GetAnimationSpeed](#cmfcpopupmenu__getanimationspeed)|Returns the animation speed for pop-up menus.|  
|[CMFCPopupMenu::GetAnimationType](#cmfcpopupmenu__getanimationtype)|Returns the current type of pop-up menu animation.|  
|[CMFCPopupMenu::GetDropDirection](#cmfcpopupmenu__getdropdirection)||  
|[CMFCPopupMenu::GetForceMenuFocus](#cmfcpopupmenu__getforcemenufocus)|Indicates whether the focus is returned to the menu bar when a pop-up menu is displayed.|  
|[CMFCPopupMenu::GetForceShadow](#cmfcpopupmenu__getforceshadow)||  
|[CMFCPopupMenu::GetHMenu](#cmfcpopupmenu__gethmenu)|Returns a handle to the attached menu resource.|  
|[CMFCPopupMenu::GetMenuBar](#cmfcpopupmenu__getmenubar)|Returns the [CMFCPopupMenuBar](../vs140/cmfcpopupmenubar-class.md) embedded inside the pop-up menu.|  
|[CMFCPopupMenu::GetMenuItem](#cmfcpopupmenu__getmenuitem)|Returns a pointer to the menu item at the specified index.|  
|[CMFCPopupMenu::GetMenuItemCount](#cmfcpopupmenu__getmenuitemcount)|Returns the number of items in a popup menu.|  
|[CMFCPopupMenu::GetMessageWnd](#cmfcpopupmenu__getmessagewnd)|Returns a pointer to the window where the framework routes the pop-up menu messages.|  
|[CMFCPopupMenu::GetParentArea](#cmfcpopupmenu__getparentarea)||  
|[CMFCPopupMenu::GetParentButton](#cmfcpopupmenu__getparentbutton)|Returns a pointer to the parent toolbar button.|  
|[CMFCPopupMenu::GetParentPopupMenu](#cmfcpopupmenu__getparentpopupmenu)|Returns a pointer to the parent pop-up menu.|  
|[CMFCPopupMenu::GetParentRibbonElement](#cmfcpopupmenu__getparentribbonelement)||  
|[CMFCPopupMenu::GetParentToolBar](#cmfcpopupmenu__getparenttoolbar)|Returns a pointer to the parent toolbar.|  
|[CMFCPopupMenu::GetQuickCustomizeType](#cmfcpopupmenu__getquickcustomizetype)||  
|[CMFCPopupMenu::GetSelItem](#cmfcpopupmenu__getselitem)|Returns a pointer to the currently selected menu command.|  
|[CMFCPopupMenu::HasBeenResized](#cmfcpopupmenu__hasbeenresized)||  
|[CMFCPopupMenu::HideRarelyUsedCommands](#cmfcpopupmenu__hiderarelyusedcommands)|Indicates whether the pop-up menu can hide rarely used commands.|  
|[CMFCPopupMenu::InCommand](#cmfcpopupmenu__incommand)||  
|[CMFCPopupMenu::InsertItem](#cmfcpopupmenu__insertitem)|Inserts a new item into the pop-up menu at the specified location.|  
|[CMFCPopupMenu::InsertSeparator](#cmfcpopupmenu__insertseparator)|Inserts a separator into the pop-up menu at the specified location.|  
|[CMFCPopupMenu::IsAlwaysClose](#cmfcpopupmenu__isalwaysclose)||  
|[CMFCPopupMenu::IsAlwaysShowEmptyToolsEntry](#cmfcpopupmenu__isalwaysshowemptytoolsentry)||  
|[CMFCPopupMenu::IsCustomizePane](#cmfcpopupmenu__iscustomizepane)|Indicates whether the pop-up menu is functioning as a **QuickCustomizePane**.|  
|[CMFCPopupMenu::IsEscClose](#cmfcpopupmenu__isescclose)||  
|[CMFCPopupMenu::IsIdle](#cmfcpopupmenu__isidle)|Indicates whether a pop-up menu is currently idle.|  
|[CMFCPopupMenu::IsMenuSound](#cmfcpopupmenu__ismenusound)||  
|[CMFCPopupMenu::IsQuickCustomize](#cmfcpopupmenu__isquickcustomize)|Determines whether the associated [CMFCToolBarMenuButton Class](../vs140/cmfctoolbarmenubutton-class.md) is in QuickCustomize mode.|  
|[CMFCPopupMenu::IsResizeble](#cmfcpopupmenu__isresizeble)||  
|[CMFCPopupMenu::IsRightAlign](#cmfcpopupmenu__isrightalign)|Indicates whether the menu is right-aligned or left-aligned.|  
|[CMFCPopupMenu::IsScrollable](#cmfcpopupmenu__isscrollable)||  
|[CMFCPopupMenu::IsSendMenuSelectMsg](#cmfcpopupmenu__issendmenuselectmsg)|Indicates whether the framework notifies the parent frame when the user selects a command from the pop-up menu.|  
|[CMFCPopupMenu::IsShown](#cmfcpopupmenu__isshown)|Indicates whether the pop-up menu is currently visible.|  
|[CMFCPopupMenu::MoveTo](#cmfcpopupmenu__moveto)||  
|[CMFCPopupMenu::OnCmdMsg](#cmfcpopupmenu__oncmdmsg)|(Overrides <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>.)|  
|[CMFCPopupMenu::PostCommand](#cmfcpopupmenu__postcommand)||  
|[CMFCPopupMenu::PreTranslateMessage](#cmfcpopupmenu__pretranslatemessage)|(Overrides <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>.)|  
|[CMFCPopupMenu::RecalcLayout](#cmfcpopupmenu__recalclayout)|Called by the framework when the standard control bars are toggled on or off or when the frame window is resized. (Overrides [CFrameWnd::RecalcLayout](../vs140/cframewnd-class.md#cframewnd__recalclayout).)|  
|[CMFCPopupMenu::RemoveAllItems](#cmfcpopupmenu__removeallitems)|Clears all the items from a pop-up menu.|  
|[CMFCPopupMenu::RemoveItem](#cmfcpopupmenu__removeitem)|Removes the specified item from a pop-up menu.|  
|[CMFCPopupMenu::SaveState](#cmfcpopupmenu__savestate)||  
|[CMFCPopupMenu::SetAnimationSpeed](#cmfcpopupmenu__setanimationspeed)|Sets the animation speed for pop-up menus.|  
|[CMFCPopupMenu::SetAnimationType](#cmfcpopupmenu__setanimationtype)|Sets the animation type for the pop-up menu.|  
|[CMFCPopupMenu::SetAutoDestroy](#cmfcpopupmenu__setautodestroy)||  
|[CMFCPopupMenu::SetDefaultItem](#cmfcpopupmenu__setdefaultitem)|Sets the default command for the pop-up menu.|  
|[CMFCPopupMenu::SetForceMenuFocus](#cmfcpopupmenu__setforcemenufocus)|Forces the input focus to return to the menu bar when a pop-up menu is displayed.|  
|[CMFCPopupMenu::SetForceShadow](#cmfcpopupmenu__setforceshadow)|Forces the framework to draw menu shadows when pop-up menus appear outside the main frame.|  
|[CMFCPopupMenu::SetMaxWidth](#cmfcpopupmenu__setmaxwidth)|Set the maximum width for the pop-up menu.|  
|[CMFCPopupMenu::SetMessageWnd](#cmfcpopupmenu__setmessagewnd)||  
|[CMFCPopupMenu::SetParentRibbonElement](#cmfcpopupmenu__setparentribbonelement)||  
|[CMFCPopupMenu::SetQuickCustomizeType](#cmfcpopupmenu__setquickcustomizetype)||  
|[CMFCPopupMenu::SetQuickMode](#cmfcpopupmenu__setquickmode)||  
|[CMFCPopupMenu::SetRightAlign](#cmfcpopupmenu__setrightalign)|Sets the menu alignment for pop-up menus.|  
|[CMFCPopupMenu::SetSendMenuSelectMsg](#cmfcpopupmenu__setsendmenuselectmsg)|Sets a flag that controls whether the pop-up menu notifies its parent frame when the user selects a command.|  
|[CMFCPopupMenu::ShowAllCommands](#cmfcpopupmenu__showallcommands)|Forces the pop-up menu to display all commands.|  
|[CMFCPopupMenu::TriggerResize](#cmfcpopupmenu__triggerresize)||  
|[CMFCPopupMenu::UpdateAllShadows](#cmfcpopupmenu__updateallshadows)|Updates the shadows for all opened pop-up menus.|  
|[CMFCPopupMenu::UpdateShadow](#cmfcpopupmenu__updateshadow)|Updates the shadow for the pop-up menu.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCPopupMenu::CreateTearOffBar](#cmfcpopupmenu__createtearoffbar)||  
|[CMFCPopupMenu::OnChangeHot](#cmfcpopupmenu__onchangehot)||  
|[CMFCPopupMenu::OnChooseItem](#cmfcpopupmenu__onchooseitem)||  
  
### Remarks  
 Normally, MFC creates pop-up menus automatically. If you want to create a <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> object manually, allocate one on the heap and then call [CMFCPopupMenu::Create](#cmfcpopupmenu__create).  
  
## Example  
 The following example demonstrates how to configure a pop-up menu object. The example shows how to set the logo and the sound of the pop-up menu, set the animation speed and type, draw menu shadows when the pop-up menu appears outside the main frame, set the maximum width, and set the right menu alignment of the pop-up menu. This code snippet is part of the [Custom Pages sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_CustomPages#2](../vs140/codesnippet/CPP/cmfcpopupmenu-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CFrameWnd](../vs140/cframewnd-class.md)  
  
 [CMiniFrameWnd](../vs140/cminiframewnd-class.md)  
  
 [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md)  
  
## Requirements  
 **Header:** afxpopupmenu.h  
  
##  \<a name="cmfcpopupmenu__activatepopupmenu">\</a>  CMFCPopupMenu::ActivatePopupMenu  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcpopupmenu__alwaysshowemptytoolsentry">\</a>  CMFCPopupMenu::AlwaysShowEmptyToolsEntry  
 Sets whether a pop-up menu is enabled to show empty entries for user-defined tools.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> if the pop-up menu can display empty entries; <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cmfcpopupmenu__areallcommandsshown">\</a>  CMFCPopupMenu::AreAllCommandsShown  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcpopupmenu__checkarea">\</a>  CMFCPopupMenu::CheckArea  
 Determines the location of a point relative to the pop-up menu.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 A point, in screen coordinates.  
  
### Return Value  
 A MENUAREA_TYPE parameter that indicates where the point is relative to the pop-up menu.  
  
### Remarks  
 A MENUAREA_TYPE parameter can have any one of the following values.  
  
-   OUTSIDE - <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> is outside the pop-up menu.  
  
-   LOGO - <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> is over a logo area.  
  
-   TEAROFF_CAPTION - <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> is over the tear-off caption.  
  
-   SHADOW_BOTTOM - <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> is over the bottom shadow of the pop-up menu.  
  
-   SHADOW_RIGHT - <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> is over the right shadow of the pop-up menu.  
  
-   MENU - <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> is over a command.  
  
##  \<a name="cmfcpopupmenu__closemenu">\</a>  CMFCPopupMenu::CloseMenu  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcpopupmenu__cmfcpopupmenu">\</a>  CMFCPopupMenu::CMFCPopupMenu  
 Constructs a [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md) object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 A pointer to a customization page.  
  
 [in] <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 A string that contains the menu caption.  
  
### Remarks  
 This method allocates the resources for a <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>. To create the pop-up menu item, call [CMFCPopupMenu::Create](#cmfcpopupmenu__create).  
  
##  \<a name="cmfcpopupmenu__create">\</a>  CMFCPopupMenu::Create  
 Creates a pop-up menu and attaches it to a [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md) object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 The parent window for the <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 The horizontal screen coordinate for the location of the pop-up menu  
  
 [in] <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
 The vertical screen coordinate for the location of the pop-menu.  
  
 [in] <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 A handle to a menu resource.  
  
 [in] <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the menu is customizable. <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> indicates that the pop-up menu is customizable.  
  
 [in] <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates how the framework routes the menu messages. See the Remarks section for more details.  
  
### Return Value  
 <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> if the method is successful; otherwise <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>.  
  
### Remarks  
 If <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>, the framework routes any menu messages to <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> must not be <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> If <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>, the framework routes the menu messages to the parent pop-up menu.  
  
### Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> method of the <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> class. This code snippet is part of the [Custom Pages sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_CustomPages#1](../vs140/codesnippet/CPP/cmfcpopupmenu-class_2.cpp)]  
  
##  \<a name="cmfcpopupmenu__createtearoffbar">\</a>  CMFCPopupMenu::CreateTearOffBar  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcpopupmenu__defaultmouseclickonclose">\</a>  CMFCPopupMenu::DefaultMouseClickOnClose  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcpopupmenu__enablemenulogo">\</a>  CMFCPopupMenu::EnableMenuLogo  
 Initializes the logo for a pop-up menu.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
 The size of the logo, in pixels.  
  
 [in] <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
 An enumerated data type that indicates the location of the logo.  
  
### Remarks  
 To display the logo, implement the method [CFrameWndEx::OnDrawMenuLogo](../vs140/cframewndex-class.md#cframewndex__ondrawmenulogo) in the main frame window.  
  
 The possible values for <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> are MENU_LOGO_LEFT, MENU_LOGO_RIGHT, MENU_LOGO_TOP, and MENU_LOGO_BOTTOM.  
  
##  \<a name="cmfcpopupmenu__enablemenusound">\</a>  CMFCPopupMenu::EnableMenuSound  
 Enables menu sound.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> to enable sound, <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 If you enable sound, the framework calls the                         [PlaySound](http://msdn.microsoft.com/library/windows/desktop/bb774426) method when a user opens a pop-up menu or selects a menu command. By default, this feature is enabled.  
  
##  \<a name="cmfcpopupmenu__enableresize">\</a>  CMFCPopupMenu::EnableResize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcpopupmenu__enablescrolling">\</a>  CMFCPopupMenu::EnableScrolling  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcpopupmenu__enablevertresize">\</a>  CMFCPopupMenu::EnableVertResize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcpopupmenu__findsubitembycommand">\</a>  CMFCPopupMenu::FindSubItemByCommand  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcpopupmenu__getactivemenu">\</a>  CMFCPopupMenu::GetActiveMenu  
 Returns the currently active menu.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the active pop-up menu, or NULL if no pop-up menu is currently active.  
  
### Remarks  
 Each application can have at most one active pop-up menu.  
  
##  \<a name="cmfcpopupmenu__getanimationspeed">\</a>  CMFCPopupMenu::GetAnimationSpeed  
 Returns the animation speed for pop-up menus.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 An integer that indicates the time, in milliseconds, that a pop-up menu animation takes to finish.  
  
### Remarks  
 The animation speed is a global value. Use [CMFCPopupMenu::SetAnimationSpeed](#cmfcpopupmenu__setanimationspeed) to change the animation speed for pop-up menus.  
  
##  \<a name="cmfcpopupmenu__getanimationtype">\</a>  CMFCPopupMenu::GetAnimationType  
 Returns the current type of pop-up animation.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether this method checks the global value. FALSE if you want this method to return the animation style for this instance of the [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md).  
  
### Return Value  
 An enumerated value that describes the animation type.  
  
### Remarks  
 The style of animation for pop-up menus is global for your application. Use [CMFCPopupMenu::SetAnimationType](#cmfcpopupmenu__setanimationtype) to set the animation style.  
  
 The following table lists the possible animation types.  
  
 NO_ANIMATION  
 The pop-up menu is not animated and appears immediately.  
  
 UNFOLD  
 The framework reveals the pop-up menu from the upper-left corner to the lower right corner.  
  
 SLIDE  
 The pop-up menu moves from top to bottom.  
  
 FADE  
 The pop-up menu first appears transparent and gradually solidifies.  
  
##  \<a name="cmfcpopupmenu__getdropdirection">\</a>  CMFCPopupMenu::GetDropDirection  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcpopupmenu__getforcemenufocus">\</a>  CMFCPopupMenu::GetForceMenuFocus  
 Indicates whether the focus is returned to the menu bar when a pop-up menu is displayed.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> if the input focus is returned to the menu bar when a pop-up menu is displayed; <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> if the pop-up menu retains the focus.  
  
### Remarks  
 By default, your application does not return focus to the menu bar. To change this setting, use [CMFCPopupMenu::SetForceMenuFocus](#cmfcpopupmenu__setforcemenufocus).  
  
##  \<a name="cmfcpopupmenu__getforceshadow">\</a>  CMFCPopupMenu::GetForceShadow  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcpopupmenu__gethmenu">\</a>  CMFCPopupMenu::GetHMenu  
 Returns a handle to the attached menu resource.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
##  \<a name="cmfcpopupmenu__getmenubar">\</a>  CMFCPopupMenu::GetMenuBar  
 Returns the [CMFCPopupMenuBar](../vs140/cmfcpopupmenubar-class.md) embedded inside the pop-up menu.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the embedded <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>.  
  
### Remarks  
 The pop-up menu has an embedded <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> object. You must override this method in a derived class if you are using a different embedded class.  
  
##  \<a name="cmfcpopupmenu__getmenuitem">\</a>  CMFCPopupMenu::GetMenuItem  
 Returns a pointer to the menu item at the specified index.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
 The zero-based index of a menu item.  
  
### Return Value  
 A pointer to a menu item. <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> if the index is invalid.  
  
### Remarks  
 Menu items are represented by the [CMFCToolBarMenuButton Class](../vs140/cmfctoolbarmenubutton-class.md). When you call this method, it returns a pointer to the appropriate <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcpopupmenu__getmenuitemcount">\</a>  CMFCPopupMenu::GetMenuItemCount  
 Returns the number of items in a pop-up menu.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Return Value  
 The number of items in the menu.  
  
##  \<a name="cmfcpopupmenu__getmessagewnd">\</a>  CMFCPopupMenu::GetMessageWnd  
 Returns a pointer to the window where the framework routes the pop-up menu messages.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the window that receives the pop-up menu messages; <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> if there is no window.  
  
### Remarks  
 When you use the method [CMFCPopupMenu::Create](#cmfcpopupmenu__create) to create a pop-up menu, you specify what window receives the menu messages.  
  
##  \<a name="cmfcpopupmenu__getparentarea">\</a>  CMFCPopupMenu::GetParentArea  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcpopupmenu__getparentbutton">\</a>  CMFCPopupMenu::GetParentButton  
 Returns a pointer to the parent toolbar button.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the parent toolbar button. <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> if the pop-up menu has no parent toolbar button.  
  
### Remarks  
 A [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md) can be associated with a button on the menu. In this scenario, the pop-up menu appears when a user selects the parent toolbar button.  
  
 If the pop-up menu is a shortcut menu, it will have no parent toolbar button.  
  
##  \<a name="cmfcpopupmenu__getparentpopupmenu">\</a>  CMFCPopupMenu::GetParentPopupMenu  
 Returns a pointer to the parent pop-up menu.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the parent [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md) object; <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> if there is no parent pop-up menu.  
  
### Remarks  
 A pop-up menu has a parent <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> object only if it is a submenu.  
  
##  \<a name="cmfcpopupmenu__getparentribbonelement">\</a>  CMFCPopupMenu::GetParentRibbonElement  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcpopupmenu__getparenttoolbar">\</a>  CMFCPopupMenu::GetParentToolBar  
 Returns a pointer to the parent toolbar.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the parent toolbar. <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> if the pop-up menu has no parent toolbar.  
  
### Remarks  
 If the [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md) is a shortcut menu, then it has no parent toolbar.  
  
##  \<a name="cmfcpopupmenu__getquickcustomizetype">\</a>  CMFCPopupMenu::GetQuickCustomizeType  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcpopupmenu__getselitem">\</a>  CMFCPopupMenu::GetSelItem  
 Returns a pointer to the currently selected menu command.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the currently selected menu command; <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> if no item is selected.  
  
### Remarks  
 The menu commands on a pop-up menu are represented by the [CMFCToolBarMenuButton Class](../vs140/cmfctoolbarmenubutton-class.md), or a class derived from <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcpopupmenu__hasbeenresized">\</a>  CMFCPopupMenu::HasBeenResized  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcpopupmenu__hiderarelyusedcommands">\</a>  CMFCPopupMenu::HideRarelyUsedCommands  
 Indicates whether the pop-up menu can hide rarely used commands.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> if the pop-up menu can hide the rarely used commands; otherwise <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method specifies only whether a pop-up menu can hide rarely used commands, not if that configuration is enabled. A pop-up menu can hide rarely used commands if it has a parent button and the parent window is derived from the [CMFCMenuBar Class](../vs140/cmfcmenubar-class.md). Use [CMFCMenuBar::SetRecentlyUsedMenus](../vs140/cmfcmenubar-class.md#cmfcmenubar__setrecentlyusedmenus) to enable this feature and [CMFCMenuBar::IsRecentlyUsedMenus](../vs140/cmfcmenubar-class.md#cmfcmenubar__isrecentlyusedmenus) to determine if this feature is currently enabled. You must call both of these methods for the parent window.  
  
##  \<a name="cmfcpopupmenu__incommand">\</a>  CMFCPopupMenu::InCommand  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcpopupmenu__insertitem">\</a>  CMFCPopupMenu::InsertItem  
 Inserts a new item into the pop-up menu at the specified location.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>  
 A reference to the menu item to add.  
  
 [in] <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
 The zero-based index for the new item. If <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> is -1, the item is added to the end of the menu.  
  
### Return Value  
 The zero-based index of the position where the item was inserted. -1 if the method fails.  
  
### Remarks  
 This method will fail if you provide an invalid value for <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>, such as an integer larger than the number of items currently on the pop-up menu.  
  
##  \<a name="cmfcpopupmenu__insertseparator">\</a>  CMFCPopupMenu::InsertSeparator  
 Inserts a separator into the pop-up menu at the specified location.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>  
 The zero-based index of the position where this method will insert the separator.  
  
### Return Value  
 The zero-based index of the position where the separator was inserted. -1 if this method fails.  
  
### Remarks  
 A value of -1 for <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> means this method will add the separator to the end of the pop-up menu.  
  
 This method fails if <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> is an invalid value.  
  
##  \<a name="cmfcpopupmenu__isalwaysclose">\</a>  CMFCPopupMenu::IsAlwaysClose  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcpopupmenu__isalwaysshowemptytoolsentry">\</a>  CMFCPopupMenu::IsAlwaysShowEmptyToolsEntry  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcpopupmenu__iscustomizepane">\</a>  CMFCPopupMenu::IsCustomizePane  
 Indicates whether the pop-up menu is functioning as a **QuickCustomizePane**.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> if the pop-up is a **QuckCustomizePane**; otherwise <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>.  
  
### Remarks  
 Use the **QuickCustomizePane** to enable the user to directly customize the pop-up menu. The **QuickCustomizePane** is a [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md) that appears when the user clicks on a toolbar button to edit it directly.  
  
 Your application should call this method during [CMDIFrameWndEx::OnShowCustomizePane](../vs140/cmdiframewndex-class.md#cmdiframewndex__onshowcustomizepane).  
  
##  \<a name="cmfcpopupmenu__isescclose">\</a>  CMFCPopupMenu::IsEscClose  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcpopupmenu__isidle">\</a>  CMFCPopupMenu::IsIdle  
 Indicates whether a pop-up menu is currently idle.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> if the pop-up menu is in idle mode; otherwise <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>.  
  
### Remarks  
 By default, a pop-up menu is in idle mode if the display animation is complete and the user is not scrolling the pop-up menu.  
  
##  \<a name="cmfcpopupmenu__ismenusound">\</a>  CMFCPopupMenu::IsMenuSound  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcpopupmenu__isquickcustomize">\</a>  CMFCPopupMenu::IsQuickCustomize  
 Determines whether the associated [CMFCToolBarMenuButton Class](../vs140/cmfctoolbarmenubutton-class.md) is in QuickCustomize mode.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> if the associated menu button is in QuickCustomize mode; otherwise <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>. This method will also return <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> if the pop-up menu is not associated with a <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>.  
  
### Remarks  
 In QuickCustomize mode the user selects a button on a toolbar to customize the button directly.  
  
##  \<a name="cmfcpopupmenu__isresizeble">\</a>  CMFCPopupMenu::IsResizeble  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcpopupmenu__isrightalign">\</a>  CMFCPopupMenu::IsRightAlign  
 Indicates whether the menu is right-aligned or left-aligned.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> if the menu is right-aligned; <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> if the menu left-aligned.  
  
### Remarks  
 You can use [CMFCPopupMenu::SetRightAlign](#cmfcpopupmenu__setrightalign) to set the menu alignment. By default, pop-up menus use left-alignment.  
  
 Menu alignment is not a global setting and can vary between pop-up menus.  
  
##  \<a name="cmfcpopupmenu__isscrollable">\</a>  CMFCPopupMenu::IsScrollable  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcpopupmenu__issendmenuselectmsg">\</a>  CMFCPopupMenu::IsSendMenuSelectMsg  
 Indicates whether the framework notifies the parent frame when the user selects a command from the pop-up menu.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> if the framework notifies the parent frame; otherwise <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>.  
  
### Remarks  
 The framework notifies the parent frame by sending it the <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> message when a used selects a menu command.  
  
##  \<a name="cmfcpopupmenu__isshown">\</a>  CMFCPopupMenu::IsShown  
 Indicates whether the pop-up menu is currently visible.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> if a pop-up menu is visible; otherwise <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcpopupmenu__moveto">\</a>  CMFCPopupMenu::MoveTo  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcpopupmenu__onchangehot">\</a>  CMFCPopupMenu::OnChangeHot  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcpopupmenu__onchooseitem">\</a>  CMFCPopupMenu::OnChooseItem  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcpopupmenu__oncmdmsg">\</a>  CMFCPopupMenu::OnCmdMsg  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcpopupmenu__postcommand">\</a>  CMFCPopupMenu::PostCommand  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcpopupmenu__pretranslatemessage">\</a>  CMFCPopupMenu::PreTranslateMessage  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcpopupmenu__recalclayout">\</a>  CMFCPopupMenu::RecalcLayout  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcpopupmenu__removeallitems">\</a>  CMFCPopupMenu::RemoveAllItems  
 Clears all the items from a pop-up menu.  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
##  \<a name="cmfcpopupmenu__removeitem">\</a>  CMFCPopupMenu::RemoveItem  
 Removes the specified item from the pop-up menu.  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>  
 The zero-based index of the item to delete.  
  
### Return Value  
 <CodeContentPlaceHolder>184\</CodeContentPlaceHolder> if the method is successful; otherwise <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method automatically arranges any separators that are affected by the removal of an item. For more information about how the framework rearranges separators, see [CMFCToolBar::RemoveButton](../vs140/cmfctoolbar-class.md#cmfctoolbar__removebutton).  
  
##  \<a name="cmfcpopupmenu__savestate">\</a>  CMFCPopupMenu::SaveState  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcpopupmenu__setanimationspeed">\</a>  CMFCPopupMenu::SetAnimationSpeed  
 Sets the animation speed for pop-up menus.  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>  
 The new animation speed, in milliseconds.  
  
### Remarks  
 The animation speed is a global value and affects all the pop-up menus in the application. This value specifies how long it takes for the animation for a pop-up menu to finish.  
  
 By default, this parameter is set to 30 milliseconds. The range of valid values for <CodeContentPlaceHolder>187\</CodeContentPlaceHolder> is from 0 to 200.  
  
##  \<a name="cmfcpopupmenu__setanimationtype">\</a>  CMFCPopupMenu::SetAnimationType  
 Sets the animation type for this pop-up menu.  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>  
 An enumerated data type that specifies the type of animation.  
  
### Remarks  
 See [CMFCPopupMenu::GetAnimationType](#cmfcpopupmenu__getanimationtype) for a list of valid values for <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcpopupmenu__setautodestroy">\</a>  CMFCPopupMenu::SetAutoDestroy  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcpopupmenu__setdefaultitem">\</a>  CMFCPopupMenu::SetDefaultItem  
 Sets the default command for the pop-up menu.  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>  
 The menu command ID of the new default command.  
  
### Remarks  
 The default command in the pop-up menu is the command that is selected when the pop-up menu appears.  
  
##  \<a name="cmfcpopupmenu__setforcemenufocus">\</a>  CMFCPopupMenu::SetForceMenuFocus  
 Forces the input focus to return to the menu bar when a pop-up menu is displayed.  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> if you want the framework to force the input focus to the menu bar when a pop-up menu is displayed. <CodeContentPlaceHolder>194\</CodeContentPlaceHolder> if you want the pop-up menu to retain the focus.  
  
### Remarks  
 This method sets a flag that is global for all pop-up menus in the application. By default, this feature is not enabled.  
  
##  \<a name="cmfcpopupmenu__setforceshadow">\</a>  CMFCPopupMenu::SetForceShadow  
 Forces the framework to draw menu shadows when pop-up menus appear outside the main frame.  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> if you want the framework to draw menu shadows, <CodeContentPlaceHolder>197\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 When you call this method, it sets a global flag in your application. This flag affects all pop-up menus in your application.  
  
##  \<a name="cmfcpopupmenu__setmaxwidth">\</a>  CMFCPopupMenu::SetMaxWidth  
 Set the maximum width for the pop-up menu.  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>  
 The maximum width for the pop-up menu, in pixels.  
  
### Remarks  
 If the text associated with a menu command will not fit in the maximum width, it is truncated and the part that does not fit is replaced by three dots.  
  
##  \<a name="cmfcpopupmenu__setmessagewnd">\</a>  CMFCPopupMenu::SetMessageWnd  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>199\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcpopupmenu__setparentribbonelement">\</a>  CMFCPopupMenu::SetParentRibbonElement  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcpopupmenu__setquickcustomizetype">\</a>  CMFCPopupMenu::SetQuickCustomizeType  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcpopupmenu__setquickmode">\</a>  CMFCPopupMenu::SetQuickMode  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcpopupmenu__setrightalign">\</a>  CMFCPopupMenu::SetRightAlign  
 Sets the menu alignment for pop-up menus.  
  
<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>  
 A Boolean that indicates the menu alignment. <CodeContentPlaceHolder>203\</CodeContentPlaceHolder> indicates right alignment, <CodeContentPlaceHolder>204\</CodeContentPlaceHolder> indicates left alignment.  
  
### Remarks  
 By default, all pop-up menus are left-aligned.  
  
##  \<a name="cmfcpopupmenu__setsendmenuselectmsg">\</a>  CMFCPopupMenu::SetSendMenuSelectMsg  
 Sets a flag that controls whether the pop-up menu notifies its parent frame when the user selects a command.  
  
<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>205\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>206\</CodeContentPlaceHolder> if the pop-up menu notifies its parent frame, <CodeContentPlaceHolder>207\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 This is a global option for all the pop-up menus in an application. If it is enabled, the pop-up menus will send a <CodeContentPlaceHolder>208\</CodeContentPlaceHolder> message to the parent frame when the user selects a command.  
  
##  \<a name="cmfcpopupmenu__showallcommands">\</a>  CMFCPopupMenu::ShowAllCommands  
 Forces the pop-up menu to display all commands.  
  
<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
### Remarks  
 This is not a global setting and affects only the current pop-up menu.  
  
##  \<a name="cmfcpopupmenu__triggerresize">\</a>  CMFCPopupMenu::TriggerResize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcpopupmenu__updateallshadows">\</a>  CMFCPopupMenu::UpdateAllShadows  
 Updates the shadows for all opened pop-up menus.  
  
<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>209\</CodeContentPlaceHolder>  
 A rectangle that specifies the region to update, in screen coordinates.  
  
### Remarks  
 This method is useful when pop-up menus are displayed over animated controls or other windows that have dynamic content.  
  
##  \<a name="cmfcpopupmenu__updateshadow">\</a>  CMFCPopupMenu::UpdateShadow  
 Updates the shadow for the pop-up menu.  
  
<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>210\</CodeContentPlaceHolder>  
 A rectangle, in screen coordinates, that specifies the boundaries of the region to update.  
  
### Remarks  
 Call this method when a pop-up menu that has a shadow overlaps an animated image.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCPopupMenuBar Class](../vs140/cmfcpopupmenubar-class.md)