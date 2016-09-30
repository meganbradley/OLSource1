---
title: "CMFCRibbonBar Class"
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
  - "CMFCRibbonBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonBar class"
ms.assetid: a65d06fa-1a28-4cc0-8971-bc9d7c9198fe
caps.latest.revision: 41
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBar Class
The <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> class implements a ribbon bar similar to that used in Office 2007.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>94\</CodeContentPlaceHolder>|Default constructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonBar::ActivateContextCategory](#cmfcribbonbar__activatecontextcategory)|Activates a context category that is already visible.|  
|[CMFCRibbonBar::AddCategory](#cmfcribbonbar__addcategory)|Adds a new ribbon category to the ribbon.|  
|[CMFCRibbonBar::AddContextCategory](#cmfcribbonbar__addcontextcategory)|Adds a context category.|  
|[CMFCRibbonBar::AddMainCategory](#cmfcribbonbar__addmaincategory)|Adds a new main ribbon category.|  
|[CMFCRibbonBar::AddPrintPreviewCategory](#cmfcribbonbar__addprintpreviewcategory)||  
|[CMFCRibbonBar::AddQATOnlyCategory](#cmfcribbonbar__addqatonlycategory)||  
|[CMFCRibbonBar::AddToTabs](#cmfcribbonbar__addtotabs)|Add a ribbon element to the right side of a ribbon bar.|  
|[CMFCRibbonBar::CreateEx](#cmfcribbonbar__createex)|Creates a control bar and attaches it to the [CPane](../vs140/cpane-class.md) object. (Overrides [CPane::CreateEx](../vs140/cpane-class.md#cpane__createex).)|  
|[CMFCRibbonBar::Create](#cmfcribbonbar__create)|Creates a ribbon bar control and attaches it to a ribbon bar.|  
|[CMFCRibbonBar::DeactivateKeyboardFocus](#cmfcribbonbar__deactivatekeyboardfocus)||  
|[CMFCRibbonBar::DrawMenuImage](#cmfcribbonbar__drawmenuimage)||  
|[CMFCRibbonBar::DWMCompositionChanged](#cmfcribbonbar__dwmcompositionchanged)||  
|[CMFCRibbonBar::EnableKeyTips](#cmfcribbonbar__enablekeytips)|Enable or disable key tips for the ribbon control.|  
|[CMFCRibbonBar::EnablePrintPreview](#cmfcribbonbar__enableprintpreview)|Enable the **Print Preview** tab.|  
|[CMFCRibbonBar::EnableToolTips](#cmfcribbonbar__enabletooltips)|Enables or disables tooltips and tooltip descriptions on the ribbon bar.|  
|[CMFCRibbonBar::FindByData](#cmfcribbonbar__findbydata)|Find a ribbon element by using data that a user specifies.|  
|[CMFCRibbonBar::FindByID](#cmfcribbonbar__findbyid)|Finds a ribbon element that has the specified command id.|  
|[CMFCRibbonBar::FindCategoryIndexByData](#cmfcribbonbar__findcategoryindexbydata)|Finds the index of the ribbon category that contains the user-defined data.|  
|[CMFCRibbonBar::ForceRecalcLayout](#cmfcribbonbar__forcerecalclayout)||  
|[CMFCRibbonBar::GetActiveCategory](#cmfcribbonbar__getactivecategory)|Gets a pointer to an active category.|  
|[CMFCRibbonBar::GetCaptionHeight](#cmfcribbonbar__getcaptionheight)|Returns the caption height. (Overrides [CBasePane::GetCaptionHeight](../vs140/cbasepane-class.md#cbasepane__getcaptionheight).)|  
|[CMFCRibbonBar::GetCategory](#cmfcribbonbar__getcategory)|Gets the pointer to a category located at a specified index.|  
|[CMFCRibbonBar::GetCategoryCount](#cmfcribbonbar__getcategorycount)|Gets the number of the ribbon categories in the ribbon bar.|  
|[CMFCRibbonBar::GetCategoryHeight](#cmfcribbonbar__getcategoryheight)||  
|[CMFCRibbonBar::GetCategoryIndex](#cmfcribbonbar__getcategoryindex)|Returns the index of a ribbon category.|  
|[CMFCRibbonBar::GetContextName](#cmfcribbonbar__getcontextname)|Retrieves the name of the context category caption that you specify by using an ID.|  
|[CMFCRibbonBar::GetDroppedDown](#cmfcribbonbar__getdroppeddown)||  
|[CMFCRibbonBar::GetElementsByID](#cmfcribbonbar__getelementsbyid)|Gets an array that contains the pointers to all the ribbon elements that have the specified ID.|  
|[CMFCRibbonBar::GetApplicationButton](#cmfcribbonbar__getapplicationbutton)|Gets a pointer to a ribbon button.|  
|[CMFCRibbonBar::GetFocused](#cmfcribbonbar__getfocused)|Returns a focused element.|  
|[CMFCRibbonBar::GetHideFlags](#cmfcribbonbar__gethideflags)||  
|[CMFCRibbonBar::GetItemIDsList](#cmfcribbonbar__getitemidslist)||  
|[CMFCRibbonBar::GetKeyboardNavigationLevel](#cmfcribbonbar__getkeyboardnavigationlevel)||  
|[CMFCRibbonBar::GetKeyboardNavLevelCurrent](#cmfcribbonbar__getkeyboardnavlevelcurrent)||  
|[CMFCRibbonBar::GetKeyboardNavLevelParent](#cmfcribbonbar__getkeyboardnavlevelparent)||  
|[CMFCRibbonBar::GetMainCategory](#cmfcribbonbar__getmaincategory)|Returns a pointer to the ribbon category that is currently selected.|  
|[CMFCRibbonBar::GetQATCommandsLocation](#cmfcribbonbar__getqatcommandslocation)||  
|[CMFCRibbonBar::GetQATDroppedDown](#cmfcribbonbar__getqatdroppeddown)||  
|[CMFCRibbonBar::GetQuickAccessCommands](#cmfcribbonbar__getquickaccesscommands)|Fills a list that contains the command IDs of all the elements that appear on the Quick Access Toolbar.|  
|[CMFCRibbonBar::GetQuickAccessToolbarLocation](#cmfcribbonbar__getquickaccesstoolbarlocation)||  
|[CMFCRibbonBar::GetTabTrancateRatio](#cmfcribbonbar__gettabtrancateratio)||  
|[CMFCRibbonBar::GetTooltipFixedWidthLargeImage](#cmfcribbonbar__gettooltipfixedwidthlargeimage)||  
|[CMFCRibbonBar::GetTooltipFixedWidthRegular](#cmfcribbonbar__gettooltipfixedwidthregular)||  
|[CMFCRibbonBar::GetVisibleCategoryCount](#cmfcribbonbar__getvisiblecategorycount)||  
|[CMFCRibbonBar::HideAllContextCategories](#cmfcribbonbar__hideallcontextcategories)|Hides all the categories that are active and visible.|  
|[CMFCRibbonBar::HideKeyTips](#cmfcribbonbar__hidekeytips)||  
|[CMFCRibbonBar::HitTest](#cmfcribbonbar__hittest)|Finds a pointer to the ribbon element that is located at the specified point in the ribbon bar's client coordinates.|  
|[CMFCRibbonBar::IsKeyTipEnabled](#cmfcribbonbar__iskeytipenabled)|Determines whether keytips are enabled.|  
|[CMFCRibbonBar::IsMainRibbonBar](#cmfcribbonbar__ismainribbonbar)||  
|[CMFCRibbonBar::IsPrintPreviewEnabled](#cmfcribbonbar__isprintpreviewenabled)|Determines whether the **Print Preview** tab is enabled.|  
|[CMFCRibbonBar::IsQATEmpty](#cmfcribbonbar__isqatempty)||  
|[CMFCRibbonBar::IsQuickAccessToolbarOnTop](#cmfcribbonbar__isquickaccesstoolbarontop)|Specifies whether the Quick Access Toolbar is located above the ribbon bar.|  
|[CMFCRibbonBar::IsReplaceFrameCaption](#cmfcribbonbar__isreplaceframecaption)|Determines whether the ribbon bar replaces the main frame caption, or is added below the frame caption.|  
|[CMFCRibbonBar::IsShowGroupBorder](#cmfcribbonbar__isshowgroupborder)||  
|[CMFCRibbonBar::IsToolTipDescrEnabled](#cmfcribbonbar__istooltipdescrenabled)|Determines whether the tooltip descriptions are enabled.|  
|[CMFCRibbonBar::IsToolTipEnabled](#cmfcribbonbar__istooltipenabled)|Determines whether the tooltips for the ribbon bar are enabled.|  
|[CMFCRibbonBar::IsTransparentCaption](#cmfcribbonbar__istransparentcaption)||  
|[CMFCRibbonBar::IsWindows7Look](#cmfcribbonbar__iswindows7look)|Indicates whether the ribbon has Windows 7-style look (small rectangular application button).|  
|[CMFCRibbonBar::LoadFromResource](#cmfcribbonbar__loadfromresource)|Overloaded. Loads a Ribbon Bar from application resources.|  
|[CMFCRibbonBar::OnClickButton](#cmfcribbonbar__onclickbutton)||  
|[CMFCRibbonBar::OnEditContextMenu](#cmfcribbonbar__oneditcontextmenu)||  
|[CMFCRibbonBar::OnRTLChanged](#cmfcribbonbar__onrtlchanged)|(Overrides <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>.)|  
|[CMFCRibbonBar::OnSetAccData](#cmfcribbonbar__onsetaccdata)|(Overrides [CBasePane::OnSetAccData](../vs140/cbasepane-class.md#cbasepane__onsetaccdata).)|  
|[CMFCRibbonBar::OnShowRibbonContextMenu](#cmfcribbonbar__onshowribboncontextmenu)||  
|[CMFCRibbonBar::OnShowRibbonQATMenu](#cmfcribbonbar__onshowribbonqatmenu)||  
|[CMFCRibbonBar::OnSysKeyDown](#cmfcribbonbar__onsyskeydown)||  
|[CMFCRibbonBar::OnSysKeyUp](#cmfcribbonbar__onsyskeyup)||  
|[CMFCRibbonBar::PopTooltip](#cmfcribbonbar__poptooltip)||  
|[CMFCRibbonBar::PreTranslateMessage](#cmfcribbonbar__pretranslatemessage)|(Overrides <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>.)|  
|[CMFCRibbonBar::RecalcLayout](#cmfcribbonbar__recalclayout)|(Overrides [CPane::RecalcLayout](../vs140/cpane-class.md#cpane__recalclayout).)|  
|[CMFCRibbonBar::RemoveAllCategories](#cmfcribbonbar__removeallcategories)|Removes all the ribbon categories from the ribbon bar.|  
|[CMFCRibbonBar::RemoveAllFromTabs](#cmfcribbonbar__removeallfromtabs)|Removes all ribbon elements from the tab area.|  
|[CMFCRibbonBar::RemoveCategory](#cmfcribbonbar__removecategory)|Removes the ribbon category that is located at the specified index.|  
|[CMFCRibbonBar::SaveToXMLBuffer](#cmfcribbonbar__savetoxmlbuffer)|Saves the Ribbon Bar to a buffer.|  
|[CMFCRibbonBar::SaveToXMLFile](#cmfcribbonbar__savetoxmlfile)|Saves the Ribbon Bar to XML file.|  
|[CMFCRibbonBar::SetActiveCategory](#cmfcribbonbar__setactivecategory)|Sets a specified ribbon category to active.|  
|[CMFCRibbonBar::SetActiveMDIChild](#cmfcribbonbar__setactivemdichild)||  
|[CMFCRibbonBar::SetElementKeys](#cmfcribbonbar__setelementkeys)|Sets the specified keytips for all ribbon elements that have the specified command ID.|  
|[CMFCRibbonBar::SetApplicationButton](#cmfcribbonbar__setapplicationbutton)|Assigns an application ribbon button to the ribbon bar.|  
|[CMFCRibbonBar::SetKeyboardNavigationLevel](#cmfcribbonbar__setkeyboardnavigationlevel)||  
|[CMFCRibbonBar::SetMaximizeMode](#cmfcribbonbar__setmaximizemode)||  
|[CMFCRibbonBar::SetQuickAccessCommands](#cmfcribbonbar__setquickaccesscommands)|Adds one or more ribbon elements to the Quick Access Toolbar.|  
|[CMFCRibbonBar::SetQuickAccessDefaultState](#cmfcribbonbar__setquickaccessdefaultstate)|Specifies the default state for the Quick Access Toolbar.|  
|[CMFCRibbonBar::SetQuickAccessToolbarOnTop](#cmfcribbonbar__setquickaccesstoolbarontop)|Positions the Quick Access Toolbar (QAT) above or below the ribbon bar.|  
|[CMFCRibbonBar::SetTooltipFixedWidth](#cmfcribbonbar__settooltipfixedwidth)||  
|[CMFCRibbonBar::SetWindows7Look](#cmfcribbonbar__setwindows7look)|Enable/disable ribbon Windows 7-style look (small rectangular application button)|  
|[CMFCRibbonBar::ShowCategory](#cmfcribbonbar__showcategory)|Shows or hides the specified ribbon category.|  
|[CMFCRibbonBar::ShowContextCategories](#cmfcribbonbar__showcontextcategories)|Shows or hides the context categories that have the specified ID.|  
|[CMFCRibbonBar::ShowKeyTips](#cmfcribbonbar__showkeytips)||  
|[CMFCRibbonBar::ToggleMimimizeState](#cmfcribbonbar__togglemimimizestate)|Toggles the ribbon bar between the minimized and maximized states..|  
|[CMFCRibbonBar::TranslateChar](#cmfcribbonbar__translatechar)||  
  
## Remarks  
 Microsoft introduced the Office Fluent Ribbon when it simultaneously released Microsoft Office 2007. This ribbon bar is not just a new control. It represents a new user-interface paradigm. The ribbon is a pane that contains a set of tabs called categories. Each category is logically split into ribbon panels and each panel can contain various controls and command buttons.  
  
 The elements that appear on the ribbon bar expand and contract to make the best use of available space. For example, if a ribbon panel has insufficient space to display its elements, it becomes a menu button that displays subitems on a pop-up menu. The ribbon bar behaves as a static (non-floating) control bar and can be docked at the top of a frame.  
  
 You can use the <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> class to implement a status bar similar to the one used in Office 2007. A ribbon category contains (and displays) a group of [ribbon panels](../vs140/cmfcribbonpanel-class.md). Each ribbon panel contains one or more ribbon elements, which are derived from [CMFCRibbonBaseElement](../vs140/cmfcribbonbaseelement-class.md).  
  
 For information about how to add a ribbon bar to your existing MFC application, see [Walkthrough: Updating the MFC Scribble Application](../vs140/walkthrough--updating-the-mfc-scribble-application--part-1-.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CBasePane](../vs140/cbasepane-class.md)  
  
 [CPane](../vs140/cpane-class.md)  
  
 [CMFCRibbonBar](../vs140/cmfcribbonbar-class.md)  
  
## Requirements  
 **Header:** afxribbonbar.h  
  
##  \<a name="cmfcribbonbar__activatecontextcategory">\</a>  CMFCRibbonBar::ActivateContextCategory  
 Activates a context category that is already visible.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
 The context category ID.  
  
### Return Value  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> if a context category with <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> is found and activated; otherwise <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcribbonbar__addcategory">\</a>  CMFCRibbonBar::AddCategory  
 Creates and initializes a new ribbon category for the ribbon bar.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
 Name of the ribbon category.  
  
 [in] <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 Resource ID of the small image list for the ribbon category.  
  
 [in] <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
 Resource ID of the large image list for the ribbon category.  
  
 [in] <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
 Specifies the size of small images for the ribbon category.  
  
 [in] <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 Specifies the size of large images for the ribbon category.  
  
 [in] <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
 Zero based index of the category location.  
  
 [in] <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 Pointer to a [CMFCRibbonCategory](../vs140/cmfcribboncategory-class.md) run-time class to dynamically create a ribbon category at run-time.  
  
### Return Value  
 A pointer to the new ribbon category if the method was successful; otherwise, <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>.  
  
### Remarks  
 If the <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> parameter is not <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>, the new ribbon category is created dynamically using the run-time class.  
  
### Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> method in the <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFC_RibbonApp#5](../vs140/codesnippet/CPP/cmfcribbonbar-class_1.cpp)]  
  
##  \<a name="cmfcribbonbar__addcontextcategory">\</a>  CMFCRibbonBar::AddContextCategory  
 Creates and initializes a new context category for the ribbon bar.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
 Name of the category.  
  
 [in] <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
 Name of the context category caption.  
  
 [in] <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
 Context ID.  
  
 [in] <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
 Color of the context category caption.  
  
 [in] <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 Resource ID of the small image of a context category.  
  
 [in] <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
 Resource ID of the large image of a context category.  
  
 [in] <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 Size of a small image.  
  
 [in] <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
 Size of a large image.  
  
 [in] <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
 Pointer to a runtime class.  
  
### Return Value  
 A pointer to the newly created category, or <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> if the <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> method of <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> cannot create the specified category.  
  
### Remarks  
 Use this function to add a context category. Context categories are a special type of category that can be shown or hidden at runtime, depending on the current application context. For example, when the user selects an object, you can display special tabs with context categories which you use to change the specific selected object.  
  
 The color of a context category can be one of the following values:  
  
-   AFX_CategoryColor_None  
  
-   AFX_CategoryColor_Red  
  
-   AFX_CategoryColor_Orange  
  
-   AFX_CategoryColor_Yellow  
  
-   AFX_CategoryColor_Green  
  
-   AFX_CategoryColor_Blue  
  
-   AFX_CategoryColor_Indigo  
  
-   AFX_CategoryColor_Violet  
  
##  \<a name="cmfcribbonbar__addmaincategory">\</a>  CMFCRibbonBar::AddMainCategory  
 Creates a new main ribbon category for the ribbon bar.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
 Name of the main ribbon category.  
  
 [in] <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
 Resource ID of small images.  
  
 [in] <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
 Resource ID of large images.  
  
 [in] <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 The size of small images.  
  
 [in] <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
 The size of large images.  
  
### Return Value  
 Pointer to the new main ribbon category if the method was successful; otherwise, <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>.  
  
### Remarks  
 If a main ribbon category already exists, it is deleted.  
  
### Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> method in the <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFC_RibbonApp#4](../vs140/codesnippet/CPP/cmfcribbonbar-class_2.cpp)]  
  
##  \<a name="cmfcribbonbar__addprintpreviewcategory">\</a>  CMFCRibbonBar::AddPrintPreviewCategory  
 Creates a print preview category on the ribbon bar.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the new ribbon category if the method was successful; otherwise, <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method creates a ribbon category and the controls that it needs in order to provide a print preview.  
  
##  \<a name="cmfcribbonbar__addqatonlycategory">\</a>  CMFCRibbonBar::AddQATOnlyCategory  
 Creates a quick access toolbar ribbon category.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
 Name of the category.  
  
 [in] <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  
 Resource ID of the image list for the category.  
  
 [in] <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
 Size of images for ribbon elements in the category.  
  
### Return Value  
 A pointer to the new category if the method was successful; otherwise, <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>.  
  
### Remarks  
 The quick access toolbar ribbon category is only used on the quick access toolbar customization dialog box.  
  
##  \<a name="cmfcribbonbar__addtotabs">\</a>  CMFCRibbonBar::AddToTabs  
 Adds the specified ribbon element to the tabs row of the ribbon bar.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
 Pointer to a ribbon element.  
  
### Remarks  
 The ribbon element is positioned before any system buttons.  
  
##  \<a name="cmfcribbonbar__cmfcribbonbar">\</a>  CMFCRibbonBar::CMFCRibbonBar  
 Constructs and initializes a [CMFCRibbonBar](../vs140/cmfcribbonbar-class.md) object.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> for the ribbon bar to replace the caption of the main frame window; <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> to locate the ribbon bar under the caption of the main frame window.  
  
### Remarks  
  
##  \<a name="cmfcribbonbar__create">\</a>  CMFCRibbonBar::Create  
 Creates a window for the ribbon bar.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>  
 Pointer to the parent window for the ribbon bar.  
  
 [in] <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  
 A logical combination of styles for the new window.  
  
 [in] <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
 ID of the new window.  
  
### Return Value  
 <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> if the window was created; otherwise <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>.  
  
### Remarks  
  
### Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> method of the <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFC_RibbonApp#1](../vs140/codesnippet/CPP/cmfcribbonbar-class_3.cpp)]  
  
##  \<a name="cmfcribbonbar__createex">\</a>  CMFCRibbonBar::CreateEx  
 Creates a window for the ribbon bar.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>  
 Pointer to the parent window for the ribbon bar.  
  
 [in] <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
 [in] <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
 A logical combination of styles for the new window.  
  
 [in] <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>  
 ID of the new window.  
  
### Return Value  
 <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> if the window was created; otherwise <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonbar__deactivatekeyboardfocus">\</a>  CMFCRibbonBar::DeactivateKeyboardFocus  
 Closes all keytip controls on the ribbon bar.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> to set the focus to the parent window of the ribbon bar.  
  
### Remarks  
  
##  \<a name="cmfcribbonbar__drawmenuimage">\</a>  CMFCRibbonBar::DrawMenuImage  
 Draws the image for a menu button.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
 Pointer to a device context for the menu button.  
  
 [in] <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>  
 Pointer to a toolbar menu button.  
  
 [in] <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>  
 The display rectangle for a menu button.  
  
### Return Value  
 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> if the image was drawn; otherwise <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonbar__dwmcompositionchanged">\</a>  CMFCRibbonBar::DWMCompositionChanged  
 Adjusts the display of the ribbon bar when Desktop Window Manager (DWM) composition is enabled or disabled.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcribbonbar__enablekeytips">\</a>  CMFCRibbonBar::EnableKeyTips  
 Enables or disables the keytip feature for the ribbon bar.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> to enable the keytips feature; <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> to disable the keytips feature.  
  
### Remarks  
 When you enable this feature, key tips are displayed when the user presses the ALT or F10 button. When the user presses ALT key, key tips are displayed with a 200 millisecond delay. This delay allows for shortcuts to be executed so that the pressed ALT key does not interfere with other combinations that include the ALT key.  
  
##  \<a name="cmfcribbonbar__enableprintpreview">\</a>  CMFCRibbonBar::EnablePrintPreview  
 Enables or disables the **Print Preview** feature.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> to enable the **Print Preview** feature; <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> to disable the **Print Preview** feature.  
  
### Remarks  
 If <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> and a print preview category exists, it is deleted.  
  
 By default the **Print Preview** feature is enabled.  
  
##  \<a name="cmfcribbonbar__enabletooltips">\</a>  CMFCRibbonBar::EnableToolTips  
 Enables or disables tooltips and optional tooltip descriptions on the ribbon bar.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> to enable tooltips on the ribbon bar; <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> to disable tooltips on the ribbon bar.  
  
 [in] <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> to enable tooltip descriptions on the tooltip; <CodeContentPlaceHolder>176\</CodeContentPlaceHolder> to disable tooltip descriptions on the tooltip.  
  
### Remarks  
 The <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> parameter determines whether tooltips are displayed when the mouse hovers over a ribbon element. The <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> parameter determines whether additional descriptive text appears with the tooltip text.  
  
##  \<a name="cmfcribbonbar__findbydata">\</a>  CMFCRibbonBar::FindByData  
 Retrieves a pointer to a ribbon element if it has the specified data and visibility.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>  
 The data associated with a ribbon element.  
  
 [in] <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> to search visible ribbon elements only; <CodeContentPlaceHolder>182\</CodeContentPlaceHolder> to search all ribbon elements.  
  
### Return Value  
 A pointer to a ribbon element if it has the specified data and visibility; otherwise <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>.  
  
### Remarks  
 A ribbon element is any control that you can add to the ribbon, such as a ribbon button, or a ribbon category, or a ribbon slider.  
  
##  \<a name="cmfcribbonbar__findbyid">\</a>  CMFCRibbonBar::FindByID  
 Retrieves a pointer to the ribbon element that has the specified command ID and search values.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>  
 Command ID for a ribbon element.  
  
 [in] <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> to search visible ribbon elements only; <CodeContentPlaceHolder>187\</CodeContentPlaceHolder> to search all ribbon elements.  
  
 [in] <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>189\</CodeContentPlaceHolder> to exclude quick access toolbar elements from the search; otherwise, <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>.  
  
### Return Value  
 A pointer to a ribbon element if it has the specified command ID and search values; otherwise, <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>.  
  
### Remarks  
 A ribbon element is any ribbon control that can be added to the ribbon, such as a ribbon button, or a ribbon category, or a ribbon slider.  
  
 In general, there can be more than one ribbon element that has the same command ID. If you want to obtain pointers to all ribbon elements that use a specified command ID, use the [GetElementsByID](#cmfcribbonbar__getelementsbyid) method.  
  
##  \<a name="cmfcribbonbar__findcategoryindexbydata">\</a>  CMFCRibbonBar::FindCategoryIndexByData  
 Retrieves the index of the ribbon category that contains the specified data.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>  
 The data associated with a ribbon category.  
  
### Return Value  
 The zero-based index of a ribbon category if the method was successful; otherwise -1.  
  
##  \<a name="cmfcribbonbar__forcerecalclayout">\</a>  CMFCRibbonBar::ForceRecalcLayout  
 Adjusts the layout of all items in the ribbon bar and parent window and redraws the whole window.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcribbonbar__getactivecategory">\</a>  CMFCRibbonBar::GetActiveCategory  
 Retrieves a pointer to the active ribbon category.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the active ribbon category; or <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> if no category is active.  
  
### Remarks  
 A category is active if it has the focus. By default, the active category is the first category on the left side of the ribbon bar.  
  
 The main category is displayed when the user presses the application button and it cannot be the active category.  
  
##  \<a name="cmfcribbonbar__getapplicationbutton">\</a>  CMFCRibbonBar::GetApplicationButton  
 Retrieves a pointer to the application button.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the application button; or <CodeContentPlaceHolder>194\</CodeContentPlaceHolder> if the button has not been set.  
  
##  \<a name="cmfcribbonbar__getcaptionheight">\</a>  CMFCRibbonBar::GetCaptionHeight  
 Retrieves the height of the caption area for the ribbon bar.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 The height, in pixels, of the caption area for the ribbon bar.  
  
### Remarks  
  
##  \<a name="cmfcribbonbar__getcategory">\</a>  CMFCRibbonBar::GetCategory  
 Retrieves a pointer to the ribbon category at the specified index.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>  
 The zero-based index of a ribbon category in the list of ribbon categories that is contained in the ribbon bar.  
  
### Return Value  
 A pointer to the ribbon category at the specified index; otherwise, <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>197\</CodeContentPlaceHolder> was out of range.  
  
##  \<a name="cmfcribbonbar__getcategorycount">\</a>  CMFCRibbonBar::GetCategoryCount  
 Retrieves the number of ribbon categories in the ribbon bar.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Return Value  
 The number of the ribbon categories in the ribbon bar.  
  
##  \<a name="cmfcribbonbar__getcategoryheight">\</a>  CMFCRibbonBar::GetCategoryHeight  
 Retrieves the height of the category.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
 The height of the category.  
  
### Remarks  
 The category height includes the height of the category tab.  
  
##  \<a name="cmfcribbonbar__getcategoryindex">\</a>  CMFCRibbonBar::GetCategoryIndex  
 Retrieves the index of the specified ribbon category.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>  
 Pointer to a ribbon category.  
  
### Return Value  
 The zero-based index of a ribbon category specified by <CodeContentPlaceHolder>199\</CodeContentPlaceHolder>; or -1 if the ribbon category is not found.  
  
##  \<a name="cmfcribbonbar__getcontextname">\</a>  CMFCRibbonBar::GetContextName  
 Retrieves the name of the context category caption specified by a context ID.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>  
 A ribbon category context ID.  
  
 [out] <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>  
 The name of a context category caption.  
  
### Return Value  
 <CodeContentPlaceHolder>202\</CodeContentPlaceHolder> if the method was successful; otherwise, <CodeContentPlaceHolder>203\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>204\</CodeContentPlaceHolder> was zero or the context category caption was not found.  
  
##  \<a name="cmfcribbonbar__getdroppeddown">\</a>  CMFCRibbonBar::GetDroppedDown  
 Retrieves the ribbon element that is currently dropped down.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Return Value  
 The ribbon element that is currently dropped down; or <CodeContentPlaceHolder>205\</CodeContentPlaceHolder> if no ribbon element is currently dropped down.  
  
### Remarks  
  
##  \<a name="cmfcribbonbar__getelementsbyid">\</a>  CMFCRibbonBar::GetElementsByID  
 Retrieves an array of pointers to all ribbon elements that have a specific command ID.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>  
 Command ID of a ribbon element.  
  
 [out] <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>  
 An array of pointers to ribbon elements.  
  
### Remarks  
 Multiple ribbon elements can have the same command ID because some ribbon elements can be copied to the quick access toolbar.  
  
##  \<a name="cmfcribbonbar__gethideflags">\</a>  CMFCRibbonBar::GetHideFlags  
 Retrieves the flags that indicate how much of the ribbon bar is visible.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Return Value  
 The flags that indicate how much of the ribbon bar is visible.  
  
### Remarks  
 The following table lists the possible combination of flags for the return value:  
  
 <CodeContentPlaceHolder>208\</CodeContentPlaceHolder>  
 The ribbon bar is minimized vertically and only the category tabs, main button, and quick access toolbar are visible.  
  
 <CodeContentPlaceHolder>209\</CodeContentPlaceHolder>  
 The width of the ribbon bar is less than the minimum width and is completely hidden.  
  
##  \<a name="cmfcribbonbar__getitemidslist">\</a>  CMFCRibbonBar::GetItemIDsList  
 Retrieves the command IDs for the specified collection of ribbon elements on the ribbon bar.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>210\</CodeContentPlaceHolder>  
 The list of command IDs for ribbon elements that are contained in the ribbon bar.  
  
 [in] <CodeContentPlaceHolder>211\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>212\</CodeContentPlaceHolder> to exclude ribbon elements that are displayed; <CodeContentPlaceHolder>213\</CodeContentPlaceHolder> to include all ribbon elements in the ribbon bar.  
  
### Remarks  
  
##  \<a name="cmfcribbonbar__getkeyboardnavigationlevel">\</a>  CMFCRibbonBar::GetKeyboardNavigationLevel  
 Retrieves the current navigation level as the user presses the keytips that are contained on the ribbon bar.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Return Value  
 The current navigation level as the user presses the keytips that are contained on the ribbon bar. The following table lists possible return values:  
  
 -1  
 Keytips are not displayed.  
  
 0  
 Keytips are displayed.  
  
 1  
 User has pressed a displayed keytip.  
  
### Remarks  
  
##  \<a name="cmfcribbonbar__getkeyboardnavlevelcurrent">\</a>  CMFCRibbonBar::GetKeyboardNavLevelCurrent  
 Retrieves the current keyboard navigation object on the ribbon bar.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Return Value  
 The current keyboard navigation object on the ribbon bar; otherwise <CodeContentPlaceHolder>214\</CodeContentPlaceHolder> if no object currently displays keytips.  
  
### Remarks  
 The object that is currently displaying keytips is the current keyboard navigation object.  
  
##  \<a name="cmfcribbonbar__getkeyboardnavlevelparent">\</a>  CMFCRibbonBar::GetKeyboardNavLevelParent  
 Retrieves the parent keyboard navigation object on the ribbon bar.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Return Value  
 The parent keyboard navigation object on the ribbon bar; otherwise <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>.  
  
### Remarks  
 When the user presses a keytip on the ribbon bar, the current keyboard navigation object becomes the parent keyboard navigation object.  
  
##  \<a name="cmfcribbonbar__getmaincategory">\</a>  CMFCRibbonBar::GetMainCategory  
 Retrieves a pointer to the main ribbon category.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the main ribbon category.  
  
### Remarks  
 The main ribbon category contains the main ribbon panel.  
  
##  \<a name="cmfcribbonbar__getqatcommandslocation">\</a>  CMFCRibbonBar::GetQATCommandsLocation  
 Retrieves the display rectangle for the commands section of the quick access toolbar.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Return Value  
 The display rectangle for the commands section of the quick access toolbar.  
  
### Remarks  
 The commands section of the display rectangle does not include the customization button.  
  
##  \<a name="cmfcribbonbar__getqatdroppeddown">\</a>  CMFCRibbonBar::GetQATDroppedDown  
 Retrieves a pointer to the ribbon element on the quick access toolbar that has its pop-up menu dropped down.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the ribbon element on the quick access toolbar that has its pop-up menu dropped down.  
  
### Remarks  
  
##  \<a name="cmfcribbonbar__getquickaccesscommands">\</a>  CMFCRibbonBar::GetQuickAccessCommands  
 Retrieves a list of command IDs for the ribbon elements on the quick access toolbar.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>  
 The list of command IDs for the ribbon elements on the quick access toolbar.  
  
### Remarks  
 The list does not contain ribbon elements that are control separators.  
  
##  \<a name="cmfcribbonbar__getquickaccesstoolbarlocation">\</a>  CMFCRibbonBar::GetQuickAccessToolbarLocation  
 Retrieves the display rectangle for the quick access toolbar.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Return Value  
 The display rectangle for the quick access toolbar.  
  
### Remarks  
  
##  \<a name="cmfcribbonbar__gettabtrancateratio">\</a>  CMFCRibbonBar::GetTabTrancateRatio  
 Retrieves the percent size reduction in the display width of the category tabs.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Return Value  
 The percent size reduction in the display width of the category tabs.  
  
### Remarks  
 Category tabs are reduced in width when there is not enough width on the ribbon bar.  
  
##  \<a name="cmfcribbonbar__gettooltipfixedwidthlargeimage">\</a>  CMFCRibbonBar::GetTooltipFixedWidthLargeImage  
 Retrieves the large size of tooltip width for the ribbon bar.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Return Value  
 The large size of tooltip width in pixels.  
  
### Remarks  
 If the large size of tooltip width is 0, the width varies.  
  
##  \<a name="cmfcribbonbar__gettooltipfixedwidthregular">\</a>  CMFCRibbonBar::GetTooltipFixedWidthRegular  
 Retrieves the regular size of tooltip width for the ribbon bar.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Return Value  
 The regular size of tooltip width in pixels.  
  
### Remarks  
 If the regular size of tooltip width is 0, the width varies.  
  
##  \<a name="cmfcribbonbar__getvisiblecategorycount">\</a>  CMFCRibbonBar::GetVisibleCategoryCount  
 Retrieves the number of visible categories on the ribbon bar.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Return Value  
 The number of visible categories on the ribbon bar.  
  
### Remarks  
  
##  \<a name="cmfcribbonbar__hideallcontextcategories">\</a>  CMFCRibbonBar::HideAllContextCategories  
 Hides all the context categories on the ribbon bar.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>217\</CodeContentPlaceHolder> if at least one context category was hidden; otherwise, <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>.  
  
### Remarks  
 If a context category is active, the active category is reset to the first visible category in the category list.  
  
##  \<a name="cmfcribbonbar__hidekeytips">\</a>  CMFCRibbonBar::HideKeyTips  
 Hides all keytips on the ribbon bar.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcribbonbar__hittest">\</a>  CMFCRibbonBar::HitTest  
 Retrieves a pointer to the ribbon element specified by the location of the point.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>219\</CodeContentPlaceHolder>  
 Location of the point in ribbon bar coordinates.  
  
 [in] <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>221\</CodeContentPlaceHolder> to search the active category; <CodeContentPlaceHolder>222\</CodeContentPlaceHolder> not to search the active category.  
  
 [in] <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>224\</CodeContentPlaceHolder> to test the caption of the ribbon panel with the point located in it; <CodeContentPlaceHolder>225\</CodeContentPlaceHolder> not to test the caption of the ribbon panel with the point located in it. See the Remarks section for more information.  
  
### Return Value  
 A pointer to the ribbon element located at the specified point; otherwise <CodeContentPlaceHolder>226\</CodeContentPlaceHolder> if the point is not located in a ribbon element.  
  
### Remarks  
 The caption of the ribbon panel with the point located in it is not tested unless the <CodeContentPlaceHolder>227\</CodeContentPlaceHolder> parameter is <CodeContentPlaceHolder>228\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcribbonbar__iskeytipenabled">\</a>  CMFCRibbonBar::IsKeyTipEnabled  
 Indicates whether the keytips feature is enabled.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>229\</CodeContentPlaceHolder> if the keytips feature is enabled; otherwise <CodeContentPlaceHolder>230\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcribbonbar__ismainribbonbar">\</a>  CMFCRibbonBar::IsMainRibbonBar  
 Indicates whether the ribbon bar is the primary ribbon bar.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Return Value  
 Always returns <CodeContentPlaceHolder>231\</CodeContentPlaceHolder>.  
  
### Remarks  
 By default this method always returns <CodeContentPlaceHolder>232\</CodeContentPlaceHolder>. Override this method to indicate whether the ribbon bar is the primary ribbon bar.  
  
##  \<a name="cmfcribbonbar__isprintpreviewenabled">\</a>  CMFCRibbonBar::IsPrintPreviewEnabled  
 Indicates whether the **Print Preview** feature is enabled.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>233\</CodeContentPlaceHolder> if the **Print Preview** feature is enabled; otherwise <CodeContentPlaceHolder>234\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcribbonbar__isqatempty">\</a>  CMFCRibbonBar::IsQATEmpty  
 Indicates whether the quick access toolbar contains command buttons.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>235\</CodeContentPlaceHolder> if the quick access toolbar contains command buttons; otherwise <CodeContentPlaceHolder>236\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonbar__isquickaccesstoolbarontop">\</a>  CMFCRibbonBar::IsQuickAccessToolbarOnTop  
 Indicates whether the quick access toolbar is located over or under the ribbon bar.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>237\</CodeContentPlaceHolder> if the quick access toolbar is located over the ribbon bar; <CodeContentPlaceHolder>238\</CodeContentPlaceHolder> if the quick access toolbar is located under the ribbon bar.  
  
##  \<a name="cmfcribbonbar__isreplaceframecaption">\</a>  CMFCRibbonBar::IsReplaceFrameCaption  
 Indicates whether the ribbon bar replaces or is under the caption of the main frame window.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>239\</CodeContentPlaceHolder> if the ribbon bar replaces the caption of the main frame window; <CodeContentPlaceHolder>240\</CodeContentPlaceHolder> if ribbon bar is under the caption of the main frame window.  
  
##  \<a name="cmfcribbonbar__isshowgroupborder">\</a>  CMFCRibbonBar::IsShowGroupBorder  
 Indicates whether button groups located on the ribbon bar display a group border.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>241\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
### Return Value  
 Always returns <CodeContentPlaceHolder>242\</CodeContentPlaceHolder>.  
  
### Remarks  
 By default this method always returns <CodeContentPlaceHolder>243\</CodeContentPlaceHolder>. Override this method to indicate whether button groups located on the ribbon bar display a group border.  
  
##  \<a name="cmfcribbonbar__istooltipdescrenabled">\</a>  CMFCRibbonBar::IsToolTipDescrEnabled  
 Indicates whether tooltip descriptions are enabled.  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>244\</CodeContentPlaceHolder> if tooltip descriptions are enabled; <CodeContentPlaceHolder>245\</CodeContentPlaceHolder> if tooltip descriptions are disabled.  
  
### Remarks  
 Tooltip descriptions are additional descriptive text displayed with the tooltip text.  
  
##  \<a name="cmfcribbonbar__istooltipenabled">\</a>  CMFCRibbonBar::IsToolTipEnabled  
 Indicates whether tooltips are enabled or disabled for the ribbon bar.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>246\</CodeContentPlaceHolder> if tooltips are enabled; <CodeContentPlaceHolder>247\</CodeContentPlaceHolder> if tooltips are disabled.  
  
##  \<a name="cmfcribbonbar__istransparentcaption">\</a>  CMFCRibbonBar::IsTransparentCaption  
 Indicates whether the display is set for Windows Aero color scheme.  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>248\</CodeContentPlaceHolder> if the color scheme is Windows Aero; otherwise <CodeContentPlaceHolder>249\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonbar__onclickbutton">\</a>  CMFCRibbonBar::OnClickButton  
 This method is retained for backward compatibility with existing applications and should not be used for new development.  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>250\</CodeContentPlaceHolder>  
 Pointer to the button that was clicked.  
  
 [in] <CodeContentPlaceHolder>251\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
### Remarks  
  
##  \<a name="cmfcribbonbar__oneditcontextmenu">\</a>  CMFCRibbonBar::OnEditContextMenu  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>252\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>253\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcribbonbar__onrtlchanged">\</a>  CMFCRibbonBar::OnRTLChanged  
 Called by the framework when the layout changes direction.  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>254\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>255\</CodeContentPlaceHolder> if the layout is right-to-left; <CodeContentPlaceHolder>256\</CodeContentPlaceHolder> if the layout is left-to-right.  
  
### Remarks  
 This method adjusts the layout of all controls on the ribbon bar for the new layout direction.  
  
##  \<a name="cmfcribbonbar__onsetaccdata">\</a>  CMFCRibbonBar::OnSetAccData  
 This method is internal to the Framework and is not intended to be called from user code.  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
### Parameters  
 long <CodeContentPlaceHolder>257\</CodeContentPlaceHolder>  
 The index of the accessible object.  
  
### Return Value  
 S_OK if successful; otherwise FALSE or S_FALSE.  
  
### Remarks  
  
##  \<a name="cmfcribbonbar__onshowribboncontextmenu">\</a>  CMFCRibbonBar::OnShowRibbonContextMenu  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>258\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>259\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>260\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>261\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonbar__onshowribbonqatmenu">\</a>  CMFCRibbonBar::OnShowRibbonQATMenu  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>262\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>263\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>264\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>265\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonbar__onsyskeydown">\</a>  CMFCRibbonBar::OnSysKeyDown  
 Called by the framework when the user presses the F10 key or holds down the ALT key and then presses another key.  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>266\</CodeContentPlaceHolder>  
 Pointer to the parent main frame window of the ribbon bar.  
  
 [in] <CodeContentPlaceHolder>267\</CodeContentPlaceHolder>  
 Virtual key code of the key being pressed.  
  
 [in] <CodeContentPlaceHolder>268\</CodeContentPlaceHolder>  
 Keyboard state flags when the key was pressed.  
  
### Return Value  
 <CodeContentPlaceHolder>269\</CodeContentPlaceHolder> if the keystroke event was processed; otherwise <CodeContentPlaceHolder>270\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonbar__onsyskeyup">\</a>  CMFCRibbonBar::OnSysKeyUp  
 Called by the framework when the user releases the F10 key, the ALT key, or a key that was pressed when the ALT key was held down.  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>271\</CodeContentPlaceHolder>  
 Pointer to the parent main frame window of the ribbon bar.  
  
 [in] <CodeContentPlaceHolder>272\</CodeContentPlaceHolder>  
 Virtual key code of the key being released.  
  
 [in] <CodeContentPlaceHolder>273\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
### Return Value  
 <CodeContentPlaceHolder>274\</CodeContentPlaceHolder> if the keystroke event was processed; otherwise <CodeContentPlaceHolder>275\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonbar__poptooltip">\</a>  CMFCRibbonBar::PopTooltip  
 Removes a tooltip from view.  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcribbonbar__pretranslatemessage">\</a>  CMFCRibbonBar::PreTranslateMessage  
 Determines if the specified message is processed by the ribbon bar.  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>276\</CodeContentPlaceHolder>  
 Pointer to a message.  
  
### Return Value  
 <CodeContentPlaceHolder>277\</CodeContentPlaceHolder> if the message was processed by the ribbon bar; otherwise <CodeContentPlaceHolder>278\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonbar__recalclayout">\</a>  CMFCRibbonBar::RecalcLayout  
 Adjusts the layout of all controls on the ribbon bar.  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
### Remarks  
 After layout adjustment, the display of the ribbon bar is updated.  
  
##  \<a name="cmfcribbonbar__removeallcategories">\</a>  CMFCRibbonBar::RemoveAllCategories  
 Deletes all ribbon categories from the ribbon bar.  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
### Remarks  
 This method deletes all ribbon categories from memory and from the category list.  
  
##  \<a name="cmfcribbonbar__removeallfromtabs">\</a>  CMFCRibbonBar::RemoveAllFromTabs  
 Removes all ribbon elements from the tab area.  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
### Remarks  
 Use this function if you want to remove all the elements that you added to the tab area by using [AddToTabs](#cmfcribbonbar__addtotabs) method.  
  
##  \<a name="cmfcribbonbar__removecategory">\</a>  CMFCRibbonBar::RemoveCategory  
 Deletes the specified ribbon category from the ribbon bar.  
  
<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>279\</CodeContentPlaceHolder>  
 The zero-based index of a category in the list of ribbon categories that is contained in the ribbon bar.  
  
### Return Value  
 <CodeContentPlaceHolder>280\</CodeContentPlaceHolder> if the specified ribbon category was deleted; otherwise <CodeContentPlaceHolder>281\</CodeContentPlaceHolder>.  
  
### Remarks  
 The specified ribbon category is deleted from memory and from the category list.  
  
##  \<a name="cmfcribbonbar__setactivecategory">\</a>  CMFCRibbonBar::SetActiveCategory  
 Sets the specified ribbon category as the active category.  
  
<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>282\</CodeContentPlaceHolder>  
 A ribbon category that is contained in the ribbon bar.  
  
 [in] <CodeContentPlaceHolder>283\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>284\</CodeContentPlaceHolder> to maximize the ribbon bar if it is minimized; <CodeContentPlaceHolder>285\</CodeContentPlaceHolder> to display the active category in a pop-up window if the ribbon bar is minimized.  
  
### Return Value  
 <CodeContentPlaceHolder>286\</CodeContentPlaceHolder> if the specified category was set as the active category; otherwise <CodeContentPlaceHolder>287\</CodeContentPlaceHolder>.  
  
### Remarks  
 The main ribbon category cannot be the active category.  
  
 If the category specified by <CodeContentPlaceHolder>288\</CodeContentPlaceHolder> is not displayed, it cannot be set as the active category.  
  
##  \<a name="cmfcribbonbar__setactivemdichild">\</a>  CMFCRibbonBar::SetActiveMDIChild  
 Associates the system buttons on the ribbon bar that belong to a multiple-document interface (MDI) child window to the specified MDI child window.  
  
<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>289\</CodeContentPlaceHolder>  
 Pointer to an MDI child window.  
  
### Remarks  
  
##  \<a name="cmfcribbonbar__setapplicationbutton">\</a>  CMFCRibbonBar::SetApplicationButton  
 Assigns an application ribbon button to the ribbon bar.  
  
<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>290\</CodeContentPlaceHolder>  
 A pointer to the application ribbon button.  
  
 [in] <CodeContentPlaceHolder>291\</CodeContentPlaceHolder>  
 The size of the application ribbon button.  
  
### Remarks  
 The application ribbon button is a large rounded button located at the upper-left corner of Ribbon control.  
  
### Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>292\</CodeContentPlaceHolder> method in the <CodeContentPlaceHolder>293\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFC_RibbonApp#3](../vs140/codesnippet/CPP/cmfcribbonbar-class_4.cpp)]  
  
##  \<a name="cmfcribbonbar__setelementkeys">\</a>  CMFCRibbonBar::SetElementKeys  
 Sets the keytips for all ribbon elements that have the specified command ID.  
  
<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>294\</CodeContentPlaceHolder>  
 The command ID of a ribbon element.  
  
 [in] <CodeContentPlaceHolder>295\</CodeContentPlaceHolder>  
 The keytip.  
  
 [in] <CodeContentPlaceHolder>296\</CodeContentPlaceHolder>  
 The menu keytip.  
  
### Return Value  
 <CodeContentPlaceHolder>297\</CodeContentPlaceHolder> if the keytips of at least one ribbon element are set; otherwise <CodeContentPlaceHolder>298\</CodeContentPlaceHolder>.  
  
### Remarks  
 The optional menu keytip is for ribbon elements with a split button that opens a popup menu.  
  
##  \<a name="cmfcribbonbar__setkeyboardnavigationlevel">\</a>  CMFCRibbonBar::SetKeyboardNavigationLevel  
 Sets the keyboard navigation level as the user presses the keytips that are contained on the ribbon bar.  
  
<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>299\</CodeContentPlaceHolder>  
 Pointer to the current keyboard navigation object.  
  
 [in] <CodeContentPlaceHolder>300\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>301\</CodeContentPlaceHolder> to set the keyboard focus to the ribbon bar.  
  
### Remarks  
 Keyboard navigation of the ribbon bar starts when the user presses the ALT or F10 key. The user selects the next navigation level by pressing a keytip on the ribbon bar. The user can return to the previous navigation level by pressing the escape key.  
  
##  \<a name="cmfcribbonbar__setmaximizemode">\</a>  CMFCRibbonBar::SetMaximizeMode  
 Adjusts the ribbon bar when the window size of a multiple-document interface (MDI) child window enters or leaves the maximized state.  
  
<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>302\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>303\</CodeContentPlaceHolder> to display the system buttons for an MDI child window on the ribbon bar; <CodeContentPlaceHolder>304\</CodeContentPlaceHolder> to remove the system buttons for an MDI child window from the ribbon bar.  
  
 [in] <CodeContentPlaceHolder>305\</CodeContentPlaceHolder>  
 Pointer to the main frame window for the ribbon bar.  
  
### Remarks  
 The ribbon bar displays system buttons for an MDI child window in the tab row when an MDI child window is maximized.  
  
##  \<a name="cmfcribbonbar__setquickaccesscommands">\</a>  CMFCRibbonBar::SetQuickAccessCommands  
 Adds one or more ribbon elements to the Quick Access Toolbar.  
  
<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>306\</CodeContentPlaceHolder>  
 The list of commands to be placed on the Quick Access Toolbar.  
  
 [in] <CodeContentPlaceHolder>307\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>308\</CodeContentPlaceHolder> if want to redraw the ribbon after you add the ribbon elements; <CodeContentPlaceHolder>309\</CodeContentPlaceHolder> otherwise.  
  
### Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>310\</CodeContentPlaceHolder> method in the <CodeContentPlaceHolder>311\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFC_RibbonApp#8](../vs140/codesnippet/CPP/cmfcribbonbar-class_5.cpp)]  
  
##  \<a name="cmfcribbonbar__setquickaccessdefaultstate">\</a>  CMFCRibbonBar::SetQuickAccessDefaultState  
 Sets the quick access toolbar to the default state.  
  
<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>312\</CodeContentPlaceHolder>  
 The quick access toolbar default state.  
  
### Remarks  
 The quick access toolbar state includes a list of commands and their visibility.  
  
### Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>313\</CodeContentPlaceHolder> method in the <CodeContentPlaceHolder>314\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFC_RibbonApp#9](../vs140/codesnippet/CPP/cmfcribbonbar-class_6.cpp)]  
  
##  \<a name="cmfcribbonbar__setquickaccesstoolbarontop">\</a>  CMFCRibbonBar::SetQuickAccessToolbarOnTop  
 Positions the quick access toolbar above or below the ribbon bar.  
  
<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>315\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>316\</CodeContentPlaceHolder> to position the quick access toolbar above the ribbon bar; <CodeContentPlaceHolder>317\</CodeContentPlaceHolder> to position the quick access toolbar below the ribbon bar.  
  
##  \<a name="cmfcribbonbar__settooltipfixedwidth">\</a>  CMFCRibbonBar::SetTooltipFixedWidth  
 Sets the regular and large sizes of tooltip fixed widths for the ribbon bar.  
  
<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>318\</CodeContentPlaceHolder>  
 The width, in pixels, of a regular fixed sized tooltip.  
  
 [in] <CodeContentPlaceHolder>319\</CodeContentPlaceHolder>  
 The width, in pixels, of a large fixed sized tooltip.  
  
### Remarks  
 Setting a parameter to 0 causes the corresponding width to vary.  
  
##  \<a name="cmfcribbonbar__showcategory">\</a>  CMFCRibbonBar::ShowCategory  
 Shows or hides the specified ribbon category.  
  
<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>320\</CodeContentPlaceHolder>  
 The index of the ribbon category.  
  
 [in] <CodeContentPlaceHolder>321\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>322\</CodeContentPlaceHolder>, show the ribbon category; otherwise, hide the ribbon category.  
  
##  \<a name="cmfcribbonbar__showcontextcategories">\</a>  CMFCRibbonBar::ShowContextCategories  
 Shows or hides the context categories that have the specified ID.  
  
<CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>323\</CodeContentPlaceHolder>  
 The context category ID.  
  
 [in] <CodeContentPlaceHolder>324\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>325\</CodeContentPlaceHolder>, show the categories that have the specified ID; otherwise, hide the categories that have the specified ID.  
  
##  \<a name="cmfcribbonbar__showkeytips">\</a>  CMFCRibbonBar::ShowKeyTips  
 Shows the keytips for each ribbon element on the ribbon bar.  
  
<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcribbonbar__togglemimimizestate">\</a>  CMFCRibbonBar::ToggleMimimizeState  
 Toggles the ribbon bar between the minimized and maximized states.  
  
<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
### Remarks  
 The misspelling in the method name is a known issue.  
  
 In the minimized state, the ribbon control is hidden and only the tabs are displayed. When the user clicks a tab, the ribbon control is displayed as a popup window. The window closes when the user clicks away or executes a command.  
  
##  \<a name="cmfcribbonbar__translatechar">\</a>  CMFCRibbonBar::TranslateChar  
 Determines whether the specified keystroke character code is processed by the ribbon bar.  
  
<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>326\</CodeContentPlaceHolder>  
 A user keystroke character code.  
  
### Return Value  
 <CodeContentPlaceHolder>327\</CodeContentPlaceHolder> if the character code was processed by the ribbon bar; otherwise <CodeContentPlaceHolder>328\</CodeContentPlaceHolder>.  
  
### Remarks  
 The keytips feature enables users to navigate the ribbon bar by using the keyboard.  
  
##  \<a name="cmfcribbonbar__getfocused">\</a>  CMFCRibbonBar::GetFocused  
 Returns a focused element.  
  
<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to a focused element or <CodeContentPlaceHolder>329\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonbar__iswindows7look">\</a>  CMFCRibbonBar::IsWindows7Look  
 Indicates whether the ribbon has Windows 7 look (small rectangular application button).  
  
<CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>330\</CodeContentPlaceHolder> if the ribbon has Windows 7 look; otherwise <CodeContentPlaceHolder>331\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonbar__loadfromresource">\</a>  CMFCRibbonBar::LoadFromResource  
 Overloaded. Loads a Ribbon Bar from application resources.  
  
<CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>332\</CodeContentPlaceHolder>  
 Specifies resource ID of XML string with Ribbon Bar information.  
  
 <CodeContentPlaceHolder>333\</CodeContentPlaceHolder>  
 Specifies type of the resource located at <CodeContentPlaceHolder>334\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>335\</CodeContentPlaceHolder>  
 Handle to the module whose executable file contains the resource. If <CodeContentPlaceHolder>336\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>337\</CodeContentPlaceHolder>, the system loads the resource from the module that was used to create the current process.  
  
 <CodeContentPlaceHolder>338\</CodeContentPlaceHolder>  
 Specifies resource ID (in string form) with Ribbon Bar information.  
  
### Return Value  
 <CodeContentPlaceHolder>339\</CodeContentPlaceHolder> if load succeeds; otherwise <CodeContentPlaceHolder>340\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonbar__savetoxmlbuffer">\</a>  CMFCRibbonBar::SaveToXMLBuffer  
 Saves the Ribbon Bar to a buffer.  
  
<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>341\</CodeContentPlaceHolder>  
 When this function returns, <CodeContentPlaceHolder>342\</CodeContentPlaceHolder> points to a buffer allocated by this method and contains Ribbon Bar information in XML format.  
  
### Return Value  
 <CodeContentPlaceHolder>343\</CodeContentPlaceHolder> if successful; otherwise <CodeContentPlaceHolder>344\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonbar__savetoxmlfile">\</a>  CMFCRibbonBar::SaveToXMLFile  
 Saves the Ribbon Bar to an XML file.  
  
<CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>345\</CodeContentPlaceHolder>  
 Specifies the output file.  
  
### Return Value  
 <CodeContentPlaceHolder>346\</CodeContentPlaceHolder> if successful; otherwise <CodeContentPlaceHolder>347\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonbar__setwindows7look">\</a>  CMFCRibbonBar::SetWindows7Look  
 Enables or disables Windows 7 look (small rectangular application button) for the Ribbon.  
  
<CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>348\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>349\</CodeContentPlaceHolder> sets Windows 7 look; <CodeContentPlaceHolder>350\</CodeContentPlaceHolder> otherwise.  
  
 <CodeContentPlaceHolder>351\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>352\</CodeContentPlaceHolder> recalculates the ribbon layout; <CodeContentPlaceHolder>353\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CPane](../vs140/cpane-class.md)   
 [CMFCRibbonCategory](../vs140/cmfcribboncategory-class.md)   
 [CMFCRibbonPanel](../vs140/cmfcribbonpanel-class.md)   
 [CMFCRibbonBaseElement](../vs140/cmfcribbonbaseelement-class.md)   
 [Walkthrough: Updating the MFC Scribble Application](../vs140/walkthrough--updating-the-mfc-scribble-application--part-1-.md)