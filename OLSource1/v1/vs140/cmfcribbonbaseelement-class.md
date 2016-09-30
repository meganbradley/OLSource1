---
title: "CMFCRibbonBaseElement Class"
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
  - "CMFCRibbonBaseElement"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonBaseElement class"
ms.assetid: 419ea91b-5062-44cc-b0a3-f87d29566f62
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBaseElement Class
The <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> class is the base class for all elements that you can add to a [ribbon bar](../vs140/cmfcribbonbar-class.md). Examples of ribbon elements are ribbon buttons, ribbon check boxes, and ribbon combo boxes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>116\</CodeContentPlaceHolder>|Constructs a <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonBaseElement::AddToKeyList](#cmfcribbonbaseelement__addtokeylist)|Adds a keytip for the ribbon element to an array of keytips.|  
|[CMFCRibbonBaseElement::AddToListBox](#cmfcribbonbaseelement__addtolistbox)|Adds a ribbon element to the specified ribbon commands list box.|  
|[CMFCRibbonBaseElement::CanBeAddedToQuickAccessToolBar](#cmfcribbonbaseelement__canbeaddedtoquickaccesstoolbar)|Indicates whether the ribbon element can be added to the quick access toolbar.|  
|[CMFCRibbonBaseElement::CanBeCompacted](#cmfcribbonbaseelement__canbecompacted)|Indicates whether the size of the ribbon element can be compact.|  
|[CMFCRibbonBaseElement::CanBeStretched](#cmfcribbonbaseelement__canbestretched)|Indicates whether the height of the ribbon element can increase vertically to the height of a ribbon row.|  
|[CMFCRibbonBaseElement::CanBeStretchedHorizontally](#cmfcribbonbaseelement__canbestretchedhorizontally)|Indicates whether the width of the ribbon element can change.|  
|[CMFCRibbonBaseElement::CleanUpSizes](#cmfcribbonbaseelement__cleanupsizes)|Cleans up the dimension settings for the ribbon element.|  
|[CMFCRibbonBaseElement::ClosePopupMenu](#cmfcribbonbaseelement__closepopupmenu)|Closes the popup menu for the ribbon element.|  
|[CMFCRibbonBaseElement::CopyFrom](#cmfcribbonbaseelement__copyfrom)|Copies the state of the specified <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> to the current object.|  
|[CMFCRibbonBaseElement::DestroyCtrl](#cmfcribbonbaseelement__destroyctrl)|Destroys the ribbon element.|  
|[CMFCRibbonBaseElement::DrawImage](#cmfcribbonbaseelement__drawimage)|Draws the image for the ribbon element.|  
|[CMFCRibbonBaseElement::Find](#cmfcribbonbaseelement__find)|Returns the specified pointer to the ribbon element if it points to the current object.|  
|[CMFCRibbonBaseElement::FindByData](#cmfcribbonbaseelement__findbydata)|Retrieves a pointer to the ribbon element if it contains the specified data.|  
|[CMFCRibbonBaseElement::FindByID](#cmfcribbonbaseelement__findbyid)|Retrieves a pointer to the ribbon element if that element is identified by the specified command ID.|  
|[CMFCRibbonBaseElement::FindByOriginal](#cmfcribbonbaseelement__findbyoriginal)|Retrieves a pointer to the ribbon element if its original ribbon element matches the specified ribbon element.|  
|[CMFCRibbonBaseElement::GetCompactSize](#cmfcribbonbaseelement__getcompactsize)|Returns the compact size of the ribbon element.|  
|[CMFCRibbonBaseElement::GetData](#cmfcribbonbaseelement__getdata)|Retrieves the user-defined data associated with the ribbon element.|  
|[CMFCRibbonBaseElement::GetDescription](#cmfcribbonbaseelement__getdescription)|Returns the description of the ribbon element.|  
|[CMFCRibbonBaseElement::GetDroppedDown](#cmfcribbonbaseelement__getdroppeddown)|Retrieves a pointer to the ribbon element if its pop-up menu is dropped down.|  
|[CMFCRibbonBaseElement::GetElements](#cmfcribbonbaseelement__getelements)|Adds the current ribbon element to the specified array.|  
|[CMFCRibbonBaseElement::GetElementsByID](#cmfcribbonbaseelement__getelementsbyid)|Adds the current ribbon element to the specified array if the current ribbon element contains the specified command ID.|  
|[CMFCRibbonBaseElement::GetHighlighted](#cmfcribbonbaseelement__gethighlighted)|Retrieves a pointer to the ribbon element if it is highlighted.|  
|[CMFCRibbonBaseElement::GetID](#cmfcribbonbaseelement__getid)|Returns the command ID of the ribbon element.|  
|[CMFCRibbonBaseElement::GetImageSize](#cmfcribbonbaseelement__getimagesize)|Returns the image size of the ribbon element.|  
|[CMFCRibbonBaseElement::GetIntermediateSize](#cmfcribbonbaseelement__getintermediatesize)|Returns the size of the ribbon element in its intermediate state.|  
|[CMFCRibbonBaseElement::GetKeys](#cmfcribbonbaseelement__getkeys)|Returns the keytip associated with the ribbon element.|  
|[CMFCRibbonBaseElement::GetKeyTipRect](#cmfcribbonbaseelement__getkeytiprect)|Retrieves the keytip boundary rectangle for the ribbon element.|  
|[CMFCRibbonBaseElement::GetKeyTipSize](#cmfcribbonbaseelement__getkeytipsize)|Retrieves the size of the keytip text.|  
|[CMFCRibbonBaseElement::GetLocationInGroup](#cmfcribbonbaseelement__getlocationingroup)|Indicates the display location of the ribbon element in a ribbon group.|  
|[CMFCRibbonBaseElement::GetMenuKeys](#cmfcribbonbaseelement__getmenukeys)|Returns the keytips associated with a button.|  
|[CMFCRibbonBaseElement::GetNotifyID](#cmfcribbonbaseelement__getnotifyid)|Retrieves the notification command ID for the ribbon element.|  
|[CMFCRibbonBaseElement::GetOriginal](#cmfcribbonbaseelement__getoriginal)|Retrieves the original ribbon element.|  
|[CMFCRibbonBaseElement::GetParentCategory](#cmfcribbonbaseelement__getparentcategory)|Retrieves the ribbon category for the ribbon element.|  
|[CMFCRibbonBaseElement::GetParentPanel](#cmfcribbonbaseelement__getparentpanel)|Retrieves the ribbon panel that contains the ribbon element.|  
|[CMFCRibbonBaseElement::GetParentRibbonBar](#cmfcribbonbaseelement__getparentribbonbar)|Retrieves the parent ribbon bar for the ribbon element.|  
|[CMFCRibbonBaseElement::GetParentWnd](#cmfcribbonbaseelement__getparentwnd)|Retrieves the parent window for the ribbon element.|  
|[CMFCRibbonBaseElement::GetPressed](#cmfcribbonbaseelement__getpressed)|Retrieves a pointer to the ribbon element if the user currently presses it.|  
|[CMFCRibbonBaseElement::GetQuickAccessToolBarID](#cmfcribbonbaseelement__getquickaccesstoolbarid)|Retrieves the command ID of the ribbon element when it is located in the quick access toolbar.|  
|[CMFCRibbonBaseElement::GetRect](#cmfcribbonbaseelement__getrect)|Returns the bounding rectangle of the ribbon element.|  
|[CMFCRibbonBaseElement::GetRegularSize](#cmfcribbonbaseelement__getregularsize)|Returns the regular size of the ribbon element.|  
|[CMFCRibbonBaseElement::GetSize](#cmfcribbonbaseelement__getsize)|Returns the current size of the ribbon element.|  
|[CMFCRibbonBaseElement::GetText](#cmfcribbonbaseelement__gettext)|Returns the text associated with the ribbon element.|  
|[CMFCRibbonBaseElement::GetToolTipText](#cmfcribbonbaseelement__gettooltiptext)|Returns tooltip text of the ribbon element.|  
|[CMFCRibbonBaseElement::GetTopLevelRibbonBar](#cmfcribbonbaseelement__gettoplevelribbonbar)|Retrieves the top level ribbon bar for the ribbon element.|  
|[CMFCRibbonBaseElement::HasCompactMode](#cmfcribbonbaseelement__hascompactmode)|Specifies whether the ribbon element has a compact mode.|  
|[CMFCRibbonBaseElement::HasFocus](#cmfcribbonbaseelement__hasfocus)|Indicates whether the parent element has keyboard focus.|  
|[CMFCRibbonBaseElement::HasIntermediateMode](#cmfcribbonbaseelement__hasintermediatemode)|Specifies whether the ribbon element has an intermediate mode.|  
|[CMFCRibbonBaseElement::HasLargeMode](#cmfcribbonbaseelement__haslargemode)|Specifies whether the ribbon element has a large mode.|  
|[CMFCRibbonBaseElement::HasMenu](#cmfcribbonbaseelement__hasmenu)|Indicates whether the ribbon element has a menu.|  
|[CMFCRibbonBaseElement::HitTest](#cmfcribbonbaseelement__hittest)|Retrieves a pointer to the ribbon element if the specified point is located in it.|  
|[CMFCRibbonBaseElement::IsAlignByColumn](#cmfcribbonbaseelement__isalignbycolumn)|Indicates whether the ribbon element is aligned vertically with other ribbon elements.|  
|[CMFCRibbonBaseElement::IsAlwaysLargeImage](#cmfcribbonbaseelement__isalwayslargeimage)|Indicates whether the ribbon element image size is always large.|  
|[CMFCRibbonBaseElement::IsAutoRepeatMode](#cmfcribbonbaseelement__isautorepeatmode)|Indicates whether the ribbon element is in auto repeat mode.|  
|[CMFCRibbonBaseElement::IsChecked](#cmfcribbonbaseelement__ischecked)|Specifies whether the ribbon element is checked.|  
|[CMFCRibbonBaseElement::IsCompactMode](#cmfcribbonbaseelement__iscompactmode)|Specifies whether the ribbon element is in a compact mode.|  
|[CMFCRibbonBaseElement::IsDefaultMenuLook](#cmfcribbonbaseelement__isdefaultmenulook)||  
|[CMFCRibbonBaseElement::IsDisabled](#cmfcribbonbaseelement__isdisabled)|Specifies whether the ribbon element is disabled.|  
|[CMFCRibbonBaseElement::IsDroppedDown](#cmfcribbonbaseelement__isdroppeddown)|Determines whether the ribbon element displays a popup menu and is dropped down.|  
|[CMFCRibbonBaseElement::IsFocused](#cmfcribbonbaseelement__isfocused)|Specifies whether the ribbon element has the focus.|  
|[CMFCRibbonBaseElement::IsGalleryIcon](#cmfcribbonbaseelement__isgalleryicon)|Indicates whether the ribbon element is contained in a ribbon gallery.|  
|[CMFCRibbonBaseElement::IsHighlighted](#cmfcribbonbaseelement__ishighlighted)|Specifies whether ribbon element is highlighted.|  
|[CMFCRibbonBaseElement::IsIntermediateMode](#cmfcribbonbaseelement__isintermediatemode)|Indicates whether the current image for the ribbon element is intermediate size.|  
|[CMFCRibbonBaseElement::IsLargeMode](#cmfcribbonbaseelement__islargemode)|Indicates whether the current image for the ribbon element is large sized.|  
|[CMFCRibbonBaseElement::IsMenuMode](#cmfcribbonbaseelement__ismenumode)|Indicates whether the ribbon element is contained in a menu.|  
|[CMFCRibbonBaseElement::IsPressed](#cmfcribbonbaseelement__ispressed)|Indicates whether the user has clicked the ribbon element.|  
|[CMFCRibbonBaseElement::IsQATMode](#cmfcribbonbaseelement__isqatmode)|Indicates whether the ribbon element is contained in the quick access toolbar.|  
|[CMFCRibbonBaseElement::IsSeparator](#cmfcribbonbaseelement__isseparator)|Indicates whether the ribbon element is a display separator.|  
|[CMFCRibbonBaseElement::IsShowGroupBorder](#cmfcribbonbaseelement__isshowgroupborder)|Indicates whether the ribbon element is contained in a group that displays a common border.|  
|[CMFCRibbonBaseElement::IsShowTooltipOnBottom](#cmfcribbonbaseelement__isshowtooltiponbottom)|Indicates whether the tooltip is displayed under the ribbon element.|  
|[CMFCRibbonBaseElement::IsTabStop](#cmfcribbonbaseelement__istabstop)|Indicates whether the ribbon element can be selected with the keyboard.|  
|[CMFCRibbonBaseElement::IsTextAlwaysOnRight](#cmfcribbonbaseelement__istextalwaysonright)|Indicates whether the text for the ribbon element is displayed on the right.|  
|[CMFCRibbonBaseElement::IsVisible](#cmfcribbonbaseelement__isvisible)|Indicates whether the ribbon element is currently displayed.|  
|[CMFCRibbonBaseElement::IsWholeRowHeight](#cmfcribbonbaseelement__iswholerowheight)|Indicates whether the display heigth of the ribbon element is the same as the display height of the ribbon panel that contains it.|  
|[CMFCRibbonBaseElement::NotifyCommand](#cmfcribbonbaseelement__notifycommand)|Sends a command notification to the parent window of the ribbon element.|  
|[CMFCRibbonBaseElement::NotifyHighlightListItem](#cmfcribbonbaseelement__notifyhighlightlistitem)|Notifies the parent window of the ribbon bar when a user highlights a ribbon element that is located in a list.|  
|[CMFCRibbonBaseElement::OnAddToQAToolbar](#cmfcribbonbaseelement__onaddtoqatoolbar)|Adds the ribbon element to the specified quick access toolbar.|  
|[CMFCRibbonBaseElement::OnAfterChangeRect](#cmfcribbonbaseelement__onafterchangerect)|Updates the tooltip for the ribbon element.|  
|[CMFCRibbonBaseElement::OnAutoRepeat](#cmfcribbonbaseelement__onautorepeat)|Updates the ribbon element in response to sustained user input.|  
|[CMFCRibbonBaseElement::OnCalcTextSize](#cmfcribbonbaseelement__oncalctextsize)|Calculates the size of the text for the ribbon element.|  
|[CMFCRibbonBaseElement::OnChangeMenuHighlight](#cmfcribbonbaseelement__onchangemenuhighlight)|Called by the framework when the highlight changes for a ribbon element that is located in a menu.|  
|[CMFCRibbonBaseElement::OnDraw](#cmfcribbonbaseelement__ondraw)|Called by the framework to draw the ribbon element.|  
|[CMFCRibbonBaseElement::OnDrawKeyTip](#cmfcribbonbaseelement__ondrawkeytip)|Called by the framework to draw the keytip for the ribbon element.|  
|[CMFCRibbonBaseElement::OnDrawMenuImage](#cmfcribbonbaseelement__ondrawmenuimage)|Called by the framework when the menu image for the ribbon element is drawn.|  
|[CMFCRibbonBaseElement::OnDrawOnList](#cmfcribbonbaseelement__ondrawonlist)|Called by the framework to draw the ribbon element in a commands list box.|  
|[CMFCRibbonBaseElement::OnKey](#cmfcribbonbaseelement__onkey)|Called by the framework when the user presses a keytip and the ribbon element has the focus.|  
|[CMFCRibbonBaseElement::OnMenuKey](#cmfcribbonbaseelement__onmenukey)||  
|[CMFCRibbonBaseElement::OnRTLChanged](#cmfcribbonbaseelement__onrtlchanged)|Called by the framework when the layout changes direction.|  
|[CMFCRibbonBaseElement::OnShow](#cmfcribbonbaseelement__onshow)|Called by the framework to show or hide the ribbon element.|  
|[CMFCRibbonBaseElement::OnShowPopupMenu](#cmfcribbonbaseelement__onshowpopupmenu)|Called by the framework when the ribbon element is going to display a popup menu.|  
|[CMFCRibbonBaseElement::PostMenuCommand](#cmfcribbonbaseelement__postmenucommand)||  
|[CMFCRibbonBaseElement::Redraw](#cmfcribbonbaseelement__redraw)|Updates the display for the ribbon element.|  
|[CMFCRibbonBaseElement::SetACCData](#cmfcribbonbaseelement__setaccdata)|Sets the accessibility data for the ribbon element.|  
|[CMFCRibbonBaseElement::SetCompactMode](#cmfcribbonbaseelement__setcompactmode)|Sets the display size for the ribbon element.|  
|[CMFCRibbonBaseElement::SetData](#cmfcribbonbaseelement__setdata)|Associates a data item with the ribbon element.|  
|[CMFCRibbonBaseElement::SetDefaultMenuLook](#cmfcribbonbaseelement__setdefaultmenulook)||  
|[CMFCRibbonBaseElement::SetDescription](#cmfcribbonbaseelement__setdescription)|Sets the description for the ribbon element.|  
|[CMFCRibbonBaseElement::SetID](#cmfcribbonbaseelement__setid)|Sets the command ID of the ribbon element.|  
|[CMFCRibbonBaseElement::SetInitialMode](#cmfcribbonbaseelement__setinitialmode)|Sets the initial display size for the ribbon element.|  
|[CMFCRibbonBaseElement::SetKeys](#cmfcribbonbaseelement__setkeys)|Sets a keytip for the ribbon element.|  
|[CMFCRibbonBaseElement::SetOriginal](#cmfcribbonbaseelement__setoriginal)|Sets the original ribbon element for the ribbon element.|  
|[CMFCRibbonBaseElement::SetParentCategory](#cmfcribbonbaseelement__setparentcategory)|Sets the parent category for the ribbon element.|  
|[CMFCRibbonBaseElement::SetParentMenu](#cmfcribbonbaseelement__setparentmenu)|Sets the parent menu container for the ribbon element.|  
|[CMFCRibbonBaseElement::SetParentRibbonBar](#cmfcribbonbaseelement__setparentribbonbar)|Sets the parent ribbon bar for the ribbon element.|  
|[CMFCRibbonBaseElement::SetRect](#cmfcribbonbaseelement__setrect)|Sets the dimensions fot he display rectangle for the ribbon element.|  
|[CMFCRibbonBaseElement::SetText](#cmfcribbonbaseelement__settext)|Sets the text for the ribbon element.|  
|[CMFCRibbonBaseElement::SetTextAlwaysOnRight](#cmfcribbonbaseelement__settextalwaysonright)|Sets the text for the ribbon element to display on the right.|  
|[CMFCRibbonBaseElement::SetToolTipText](#cmfcribbonbaseelement__settooltiptext)|Sets the tooltip text for the ribbon element.|  
|[CMFCRibbonBaseElement::SetVisible](#cmfcribbonbaseelement__setvisible)|Sets the visibility state of the ribbon element.|  
|[CMFCRibbonBaseElement::StretchHorizontally](#cmfcribbonbaseelement__stretchhorizontally)|Stretches the width of the ribbon element.|  
|[CMFCRibbonBaseElement::StretchToWholeRow](#cmfcribbonbaseelement__stretchtowholerow)|Changes the display height of the ribbon element to the specified row height.|  
|[CMFCRibbonBaseElement::UpdateTooltipInfo](#cmfcribbonbaseelement__updatetooltipinfo)|Updates the tooltip text by using the command resource for the ribbon element.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonBaseElement::OnProcessKey](#cmfcribbonbaseelement__onprocesskey)|Called by the framework when the user presses a shortcut key.|  
|[CMFCRibbonBaseElement::OnSetFocus](#cmfcribbonbaseelement__onsetfocus)|Called by the framework when a ribbon element receives or loses the input focus.|  
  
## Remarks  
 The <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> class defines the properties that are common to all ribbon elements that include command ID, text label, tooltip text, element description, and state (which can be focused, highlighted, pressed, disabled, checked, or dropped down).  
  
 The image size of a ribbon element is defined by the <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> member, which can be one of the following values:  
  
-   <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
  
 Depending on its size, a ribbon element displays either a small or large image.  
  
## Example  
 The following example demonstrates how to use various methods in the <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> class. The example shows how to get a <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> object from a <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> class, set the description for the ribbon element, set the text, set a keytip, and set the tooltip text for the ribbon element. This code snippet is part of the [Draw Client sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_DrawClient#8](../vs140/codesnippet/CPP/cmfcribbonbaseelement-class_1.cpp)]  
[!code[NVC_MFC_DrawClient#9](../vs140/codesnippet/CPP/cmfcribbonbaseelement-class_2.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMFCRibbonBaseElement](../vs140/cmfcribbonbaseelement-class.md)  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
##  \<a name="cmfcribbonbaseelement__addtokeylist">\</a>  CMFCRibbonBaseElement::AddToKeyList  
 Adds a keytip for the ribbon element to an array of keytips.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
 Reference to a [CArray](../vs140/carray-class.md) of keytips.  
  
### Remarks  
 When the ribbon keytips feature is enabled, the framework displays ribbon keytips when the user presses the ALT key or the F10 key.  
  
##  \<a name="cmfcribbonbaseelement__addtolistbox">\</a>  CMFCRibbonBaseElement::AddToListBox  
 Adds a ribbon element to the specified ribbon commands list box.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
 Pointer to a commands list box.  
  
 [in] <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
### Return Value  
 The zero-based index of the added ribbon element.  
  
### Remarks  
 The framework adds ribbon elements to a commands list box to enable the user to customize the user interface.  
  
##  \<a name="cmfcribbonbaseelement__canbeaddedtoquickaccesstoolbar">\</a>  CMFCRibbonBaseElement::CanBeAddedToQuickAccessToolBar  
 Indicates whether the ribbon element can be added to the quick access toolbar.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> if the element can be added; otherwise, <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__canbecompacted">\</a>  CMFCRibbonBaseElement::CanBeCompacted  
 Indicates whether the size of the ribbon element can be compact.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> if the size of the ribbon element can be compact; otherwise, <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>.  
  
### Remarks  
 The size of a ribbon element can be compact, intermediate, or large.  
  
##  \<a name="cmfcribbonbaseelement__canbestretched">\</a>  CMFCRibbonBaseElement::CanBeStretched  
 Indicates whether the height of the ribbon element can increase vertically to the height of a ribbon row.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 Always returns <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>.  
  
### Remarks  
 By default this method always returns <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>. Override this method to indicate whether the height of the ribbon element can increase vertically to the height of a ribbon row.  
  
##  \<a name="cmfcribbonbaseelement__canbestretchedhorizontally">\</a>  CMFCRibbonBaseElement::CanBeStretchedHorizontally  
 Indicates whether the width of the ribbon element can change.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Always returns <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>.  
  
### Remarks  
 By default this method always returns <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>. Override this method to indicate whether the width of the ribbon element can change.  
  
##  \<a name="cmfcribbonbaseelement__cleanupsizes">\</a>  CMFCRibbonBaseElement::CleanUpSizes  
 Cleans up the dimension settings for the ribbon element.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 By default this method does nothing. Override this method in a derived class to reset the dimension settings for the ribbon element.  
  
##  \<a name="cmfcribbonbaseelement__closepopupmenu">\</a>  CMFCRibbonBaseElement::ClosePopupMenu  
 Closes the pop-up menu for the ribbon element.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__copyfrom">\</a>  CMFCRibbonBaseElement::CopyFrom  
 Copies the state of the specified [CMFCRibbonBaseElement](../vs140/cmfcribbonbaseelement-class.md) to the current object.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
 The source [CMFCRibbonBaseElement](../vs140/cmfcribbonbaseelement-class.md) object.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__destroyctrl">\</a>  CMFCRibbonBaseElement::DestroyCtrl  
 Destroys the ribbon element.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 By default this method does nothing. Override this method in a derived class to destroy the ribbon element.  
  
##  \<a name="cmfcribbonbaseelement__drawimage">\</a>  CMFCRibbonBaseElement::DrawImage  
 Draws the image for the ribbon element.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
 Pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
 An image type enumerated value. See the Remarks section for a list of possible values.  
  
 [in] <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
 The image rectangle.  
  
### Remarks  
 By default this method does nothing. Override this method in a derived class to draw the image for the ribbon element.  
  
 The following table lists possible values for the <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> parameter:  
  
 <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
 Large 32x32 pixel image size.  
  
 <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>  
 Small 16x16 pixel image size.  
  
##  \<a name="cmfcribbonbaseelement__find">\</a>  CMFCRibbonBaseElement::Find  
 Returns the specified pointer if it points to the current object.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  
 Pointer to a ribbon element.  
  
### Return Value  
 A pointer to the ribbon element if <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> points to the current object; otherwise <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__findbydata">\</a>  CMFCRibbonBaseElement::FindByData  
 Retrieves a pointer to the ribbon element if it contains the specified data.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>  
 The data associated with a ribbon element.  
  
### Return Value  
 A pointer to the ribbon element if it contains the specified data; otherwise <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__findbyid">\</a>  CMFCRibbonBaseElement::FindByID  
 Retrieves a pointer to the ribbon element if that element is identified by the specified command ID.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
 Command ID for a ribbon element.  
  
### Return Value  
 A pointer to the ribbon element if that element is identified by the specified command ID; otherwise <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__findbyoriginal">\</a>  CMFCRibbonBaseElement::FindByOriginal  
 Retrieves a pointer to the current ribbon element if its original ribbon element matches the specified ribbon element.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>  
 Pointer to a ribbon element.  
  
### Return Value  
 A pointer to the ribbon element if its original ribbon element matches the specified ribbon element; otherwise <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>.  
  
### Remarks  
 Ribbon elements that are copied to another container retain a pointer to the original ribbon element.  
  
##  \<a name="cmfcribbonbaseelement__getcompactsize">\</a>  CMFCRibbonBaseElement::GetCompactSize  
 Returns the compact size of the ribbon element.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
### Return Value  
 The compact size of a ribbon element.  
  
> [!NOTE]
>  The compact size means that the ribbon element is truncated (it displays a small image, or an image without a text).  
  
##  \<a name="cmfcribbonbaseelement__getdata">\</a>  CMFCRibbonBaseElement::GetData  
 Retrieves the user-defined data associated with the ribbon element.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 The user-defined data associated with the ribbon element.  
  
##  \<a name="cmfcribbonbaseelement__getdescription">\</a>  CMFCRibbonBaseElement::GetDescription  
 Returns the description of the ribbon element.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
 The ribbon element description. The description is displayed either on the status bar, or in a tooltip, or under the menu button if the ribbon element is located on the [main panel](../vs140/cmfcribbonmainpanel-class.md).  
  
##  \<a name="cmfcribbonbaseelement__getdroppeddown">\</a>  CMFCRibbonBaseElement::GetDroppedDown  
 Retrieves a pointer to the ribbon element if its pop-up menu is dropped down.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the ribbon element if its pop-up menu is dropped down; otherwise <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__getelements">\</a>  CMFCRibbonBaseElement::GetElements  
 Adds the current ribbon element to the specified array.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 [in, out] <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>  
 An array of ribbon elements.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__getelementsbyid">\</a>  CMFCRibbonBaseElement::GetElementsByID  
 Adds the current ribbon element to the specified array if the current ribbon element contains the specified command ID.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>  
 Command ID of a ribbon element.  
  
 [in] <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>  
 An array of ribbon elements.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__gethighlighted">\</a>  CMFCRibbonBaseElement::GetHighlighted  
 Retrieves a pointer to the ribbon element if it is highlighted.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the ribbon element if it is highlighted; otherwise <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__getid">\</a>  CMFCRibbonBaseElement::GetID  
 Returns the command ID of the ribbon element.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 The command ID of the ribbon element.  
  
##  \<a name="cmfcribbonbaseelement__getimagesize">\</a>  CMFCRibbonBaseElement::GetImageSize  
 Returns the image size of the ribbon element.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Return Value  
 The image size of the ribbon element.  
  
##  \<a name="cmfcribbonbaseelement__getintermediatesize">\</a>  CMFCRibbonBaseElement::GetIntermediateSize  
 Returns the size of the ribbon element in its intermediate state.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
### Return Value  
 The size of the ribbon element in its intermediate state.  
  
##  \<a name="cmfcribbonbaseelement__getkeys">\</a>  CMFCRibbonBaseElement::GetKeys  
 Returns the keytip associated with the ribbon element.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
 A keytip associated with the ribbon element.  
  
##  \<a name="cmfcribbonbaseelement__getkeytiprect">\</a>  CMFCRibbonBaseElement::GetKeyTipRect  
 Retrieves the keytip boundary rectangle for the ribbon element.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>  
 Pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> if the ribbon element displays a pop-up menu; otherwise <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>.  
  
### Return Value  
 Always returns a rectangle with 0 values.  
  
### Remarks  
 Override this method in a derived class to return the keytip boundary rectangle.  
  
##  \<a name="cmfcribbonbaseelement__getkeytipsize">\</a>  CMFCRibbonBaseElement::GetKeyTipSize  
 Retrieves the size of the keytip text.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>  
 Pointer to a device context.  
  
### Return Value  
 The size of the keytip text.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__getlocationingroup">\</a>  CMFCRibbonBaseElement::GetLocationInGroup  
 Indicates the display location of the ribbon element in a ribbon group.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> enumerated value. The following table lists possible values.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>166\</CodeContentPlaceHolder>|The ribbon element is not contained in a ribbon group.|  
|<CodeContentPlaceHolder>167\</CodeContentPlaceHolder>|The ribbon element is displayed as the only item in a ribbon group.|  
|<CodeContentPlaceHolder>168\</CodeContentPlaceHolder>|The ribbon element is displayed on the left end of a ribbon group.|  
|<CodeContentPlaceHolder>169\</CodeContentPlaceHolder>|The ribbon element is displayed on the right end of a ribbon group.|  
|<CodeContentPlaceHolder>170\</CodeContentPlaceHolder>|The ribbon element is not displayed on either end of a ribbon group.|  
  
### Remarks  
 Ribbon element groups are only aligned horizontally.  
  
##  \<a name="cmfcribbonbaseelement__getmenukeys">\</a>  CMFCRibbonBaseElement::GetMenuKeys  
 Returns the menu keytip for the ribbon element.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Return Value  
 The menu keytip associated with the ribbon element.  
  
### Remarks  
 When invoked, a menu keytip displays a pop-up menu.  
  
##  \<a name="cmfcribbonbaseelement__getnotifyid">\</a>  CMFCRibbonBaseElement::GetNotifyID  
 Retrieves the notification command ID for the ribbon element.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Return Value  
 The notification command ID.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__getoriginal">\</a>  CMFCRibbonBaseElement::GetOriginal  
 Retrieves the original ribbon element.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the original ribbon element.  
  
### Remarks  
 Ribbon elements that are copied to another container retain a pointer to the original ribbon element.  
  
##  \<a name="cmfcribbonbaseelement__getparentcategory">\</a>  CMFCRibbonBaseElement::GetParentCategory  
 Retrieves the ribbon category for the ribbon element.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the ribbon category.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__getparentpanel">\</a>  CMFCRibbonBaseElement::GetParentPanel  
 Retrieves the ribbon panel that contains the ribbon element.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the ribbon panel that contains the ribbon element.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__getparentribbonbar">\</a>  CMFCRibbonBaseElement::GetParentRibbonBar  
 Retrieves the parent ribbon bar for the ribbon element.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the parent ribbon bar for the ribbon element.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__getparentwnd">\</a>  CMFCRibbonBaseElement::GetParentWnd  
 Retrieves the parent window for the ribbon element.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the parent window for the ribbon element if the method was successful; otherwise, <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>.  
  
### Remarks  
 The parent window for a ribbon element is a [CMFCRibbonBar](../vs140/cmfcribbonbar-class.md) or a [CMFCRibbonPanelMenuBar](assetId:///7bd4b986-8b7b-493e-9746-bd3161b78581).  
  
##  \<a name="cmfcribbonbaseelement__getpressed">\</a>  CMFCRibbonBaseElement::GetPressed  
 Retrieves a pointer to the ribbon element if the user currently presses it.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the ribbon element if the user currently presses it; otherwise, <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__getquickaccesstoolbarid">\</a>  CMFCRibbonBaseElement::GetQuickAccessToolBarID  
 Retrieves the command ID of the ribbon element when it is located in the quick access toolbar.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Return Value  
 The command ID of the ribbon element when it is located in the quick access toolbar.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__getrect">\</a>  CMFCRibbonBaseElement::GetRect  
 Returns the bounding rectangle of the ribbon element.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Return Value  
 The bounding rectangle of the ribbon element. The position of the rectangle is in the coordinates of the parent Ribbon control.  
  
##  \<a name="cmfcribbonbaseelement__getregularsize">\</a>  CMFCRibbonBaseElement::GetRegularSize  
 Returns the regular size of the ribbon element.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
### Return Value  
 The regular size of the ribbon element.  
  
### Remarks  
  
> [!NOTE]
>  The regular size is the maximal possible size of the ribbon element.  
  
##  \<a name="cmfcribbonbaseelement__getsize">\</a>  CMFCRibbonBaseElement::GetSize  
 Returns the current size of the ribbon element.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
### Return Value  
 The current size of the ribbon element.  
  
##  \<a name="cmfcribbonbaseelement__gettext">\</a>  CMFCRibbonBaseElement::GetText  
 Returns the text associated with the ribbon element.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Return Value  
 The text associated with the ribbon element.  
  
##  \<a name="cmfcribbonbaseelement__gettooltiptext">\</a>  CMFCRibbonBaseElement::GetToolTipText  
 Returns tooltip text of the ribbon element.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Return Value  
 The tooltip text of the ribbon element.  
  
##  \<a name="cmfcribbonbaseelement__gettoplevelribbonbar">\</a>  CMFCRibbonBaseElement::GetTopLevelRibbonBar  
 Retrieves the top level ribbon bar for the ribbon element.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the top level ribbon bar for the ribbon element if the method was successful; otherwise, <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__hascompactmode">\</a>  CMFCRibbonBaseElement::HasCompactMode  
 Specifies whether the ribbon element has a compact mode.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>176\</CodeContentPlaceHolder> if the ribbon element has a compact mode. <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
  
> [!NOTE]
>  In the compact mode, an element displays a small image only.  
  
##  \<a name="cmfcribbonbaseelement__hasintermediatemode">\</a>  CMFCRibbonBaseElement::HasIntermediateMode  
 Specifies whether the ribbon element has an intermediate mode.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> if the ribbon element has an intermediate mode, <CodeContentPlaceHolder>179\</CodeContentPlaceHolder> otherwise. In the intermediate mode, an element displays a small image and text on the right of the image.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__haslargemode">\</a>  CMFCRibbonBaseElement::HasLargeMode  
 Determines whether the ribbon element has a large mode.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>180\</CodeContentPlaceHolder> if the ribbon element has a large mode. <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 In the large mode, an element can take the full height of the parent panel.  
  
##  \<a name="cmfcribbonbaseelement__hasmenu">\</a>  CMFCRibbonBaseElement::HasMenu  
 Indicates whether the ribbon element has a menu.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Return Value  
 Always returns <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>.  
  
### Remarks  
 By default this method always returns <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>. Override this method in a derived class to indicate whether the ribbon element has a menu.  
  
##  \<a name="cmfcribbonbaseelement__hittest">\</a>  CMFCRibbonBaseElement::HitTest  
 Retrieves a pointer to the ribbon element if the specified point is located in it.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
### Return Value  
 A pointer to the ribbon element if it exists; otherwise <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>.  
  
### Remarks  
 By default this method always returns a valid pointer to the ribbon element when it exists. Override this method to indicate if the point resides in the ribbon element.  
  
##  \<a name="cmfcribbonbaseelement__isalignbycolumn">\</a>  CMFCRibbonBaseElement::IsAlignByColumn  
 Indicates whether the ribbon element is aligned vertically with other ribbon elements.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Return Value  
 Always returns <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>.  
  
### Remarks  
 By default this method always returns <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>. Override this method in a derived class to indicate whether the derived ribbon element is aligned vertically with other ribbon elements.  
  
##  \<a name="cmfcribbonbaseelement__isalwayslargeimage">\</a>  CMFCRibbonBaseElement::IsAlwaysLargeImage  
 Indicates whether the ribbon element image size is always large.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>188\</CodeContentPlaceHolder> if the ribbon element image size is always large; otherwise <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>.  
  
### Remarks  
 Large image size is 32 x 32 pixels.  
  
##  \<a name="cmfcribbonbaseelement__isautorepeatmode">\</a>  CMFCRibbonBaseElement::IsAutoRepeatMode  
 Indicates whether the ribbon element is in auto repeat mode.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
### Return Value  
 Always returns <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>.  
  
### Remarks  
 By default this method always returns <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>. Override this method to indicate whether the ribbon element is in auto repeat mode.  
  
 In auto repeat mode, the ribbon element responds at a set interval, measured in milliseconds, to sustained user input.  
  
##  \<a name="cmfcribbonbaseelement__ischecked">\</a>  CMFCRibbonBaseElement::IsChecked  
 Specifies whether the ribbon element is checked.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> if the ribbon element is checked; otherwise <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcribbonbaseelement__iscompactmode">\</a>  CMFCRibbonBaseElement::IsCompactMode  
 Specifies whether the ribbon element is in a compact mode.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>195\</CodeContentPlaceHolder> if the ribbon element is in a compact mode; otherwise <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcribbonbaseelement__isdefaultmenulook">\</a>  CMFCRibbonBaseElement::IsDefaultMenuLook  
 Indicates whether the ribbon element is set to appear as a pop-up command.  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>197\</CodeContentPlaceHolder> if the ribbon element is set to appear as a pop-up command; otherwise <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__isdisabled">\</a>  CMFCRibbonBaseElement::IsDisabled  
 Specifies whether the ribbon element is disabled.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>199\</CodeContentPlaceHolder> if the ribbon element is disabled; otherwise <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcribbonbaseelement__isdroppeddown">\</a>  CMFCRibbonBaseElement::IsDroppedDown  
 Specifies whether the ribbon element displays a pop-up menu and is dropped down.  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>201\</CodeContentPlaceHolder> if the ribbon element is dropped down and displays a pop-up menu; otherwise <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcribbonbaseelement__isfocused">\</a>  CMFCRibbonBaseElement::IsFocused  
 Specifies whether the ribbon element has the focus.  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>203\</CodeContentPlaceHolder> if the ribbon element has the focus; otherwise <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcribbonbaseelement__isgalleryicon">\</a>  CMFCRibbonBaseElement::IsGalleryIcon  
 Indicates whether the ribbon element is contained in a ribbon gallery.  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Return Value  
 Always returns <CodeContentPlaceHolder>205\</CodeContentPlaceHolder>.  
  
### Remarks  
 By default this method always returns <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>. Override this method in a derived class to indicate whether the ribbon element is contained in a ribbon gallery.  
  
##  \<a name="cmfcribbonbaseelement__ishighlighted">\</a>  CMFCRibbonBaseElement::IsHighlighted  
 Specifies whether ribbon element is highlighted.  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>207\</CodeContentPlaceHolder> if the ribbon element is highlighted; otherwise <CodeContentPlaceHolder>208\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__isintermediatemode">\</a>  CMFCRibbonBaseElement::IsIntermediateMode  
 Indicates whether the current image for the ribbon element is intermediate size.  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>209\</CodeContentPlaceHolder> if the image for the ribbon element is intermediate size; otherwise <CodeContentPlaceHolder>210\</CodeContentPlaceHolder>.  
  
### Remarks  
 Intermediate image size is 16 x 16 pixels.  
  
##  \<a name="cmfcribbonbaseelement__islargemode">\</a>  CMFCRibbonBaseElement::IsLargeMode  
 Indicates whether the current image for the ribbon element is large size.  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>211\</CodeContentPlaceHolder> if the image for the ribbon element is large size; otherwise <CodeContentPlaceHolder>212\</CodeContentPlaceHolder>.  
  
### Remarks  
 Large image size is 32 x 32 pixels.  
  
##  \<a name="cmfcribbonbaseelement__ismenumode">\</a>  CMFCRibbonBaseElement::IsMenuMode  
 Indicates whether the ribbon element is contained in a menu.  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>213\</CodeContentPlaceHolder> if the ribbon element is contained in a menu; otherwise, <CodeContentPlaceHolder>214\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__ispressed">\</a>  CMFCRibbonBaseElement::IsPressed  
 Indicates whether the user has clicked the ribbon element.  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>215\</CodeContentPlaceHolder> if the user has clicked the ribbon element; otherwise <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcribbonbaseelement__isqatmode">\</a>  CMFCRibbonBaseElement::IsQATMode  
 Indicates whether the ribbon element is contained in the quick access toolbar.  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>217\</CodeContentPlaceHolder> if the ribbon element is contained in the quick access toolbar; otherwise, <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__isseparator">\</a>  CMFCRibbonBaseElement::IsSeparator  
 Indicates whether the ribbon element is a display separator.  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>219\</CodeContentPlaceHolder> if the ribbon element is a display separator; otherwise <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__isshowgroupborder">\</a>  CMFCRibbonBaseElement::IsShowGroupBorder  
 Indicates whether the ribbon element is contained in a group that displays a common border.  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>221\</CodeContentPlaceHolder> if the ribbon element is contained in a group that displays a common border; otherwise, <CodeContentPlaceHolder>222\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__isshowtooltiponbottom">\</a>  CMFCRibbonBaseElement::IsShowTooltipOnBottom  
 Indicates whether the tooltip is displayed under the ribbon element.  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>223\</CodeContentPlaceHolder> if the tooltip is displayed under the ribbon element; <CodeContentPlaceHolder>224\</CodeContentPlaceHolder> if the tooltip is displayed near the pointer.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__istabstop">\</a>  CMFCRibbonBaseElement::IsTabStop  
 Indicates whether the ribbon element can be selected with the keyboard.  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
### Return Value  
 Always returns <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>.  
  
### Remarks  
 By default this method always returns <CodeContentPlaceHolder>226\</CodeContentPlaceHolder>. Override this method to indicate whether the ribbon element can be selected with the keyboard.  
  
##  \<a name="cmfcribbonbaseelement__istextalwaysonright">\</a>  CMFCRibbonBaseElement::IsTextAlwaysOnRight  
 Indicates whether the text for the ribbon element is displayed on the right.  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>227\</CodeContentPlaceHolder> if the text for the ribbon element is displayed on the right; otherwise, <CodeContentPlaceHolder>228\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__isvisible">\</a>  CMFCRibbonBaseElement::IsVisible  
 Indicates whether the ribbon element is currently displayed.  
  
<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>229\</CodeContentPlaceHolder> if the ribbon element is currently displayed; otherwise, <CodeContentPlaceHolder>230\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__iswholerowheight">\</a>  CMFCRibbonBaseElement::IsWholeRowHeight  
 Indicates whether the display height of the ribbon element is the same as the display height of the ribbon panel that contains it.  
  
<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
### Return Value  
 Always returns <CodeContentPlaceHolder>231\</CodeContentPlaceHolder>.  
  
### Remarks  
 By default this method always returns <CodeContentPlaceHolder>232\</CodeContentPlaceHolder>. Override this method to indicate whether the display height of the ribbon element is the same as the display height of the ribbon panel that contains it.  
  
##  \<a name="cmfcribbonbaseelement__notifycommand">\</a>  CMFCRibbonBaseElement::NotifyCommand  
 Sends a command notification to the parent window of the ribbon element.  
  
<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>233\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>234\</CodeContentPlaceHolder> to add the command notification to the message queue of the parent window; <CodeContentPlaceHolder>235\</CodeContentPlaceHolder> to send the message immediately to the parent window.  
  
### Return Value  
 <CodeContentPlaceHolder>236\</CodeContentPlaceHolder> if the message was sent; otherwise, <CodeContentPlaceHolder>237\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__notifyhighlightlistitem">\</a>  CMFCRibbonBaseElement::NotifyHighlightListItem  
 Notifies the parent window of the ribbon bar when a user highlights a ribbon element that is located in a list.  
  
<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>238\</CodeContentPlaceHolder>  
 The index of the ribbon element in the list.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__onaddtoqatoolbar">\</a>  CMFCRibbonBaseElement::OnAddToQAToolbar  
 Adds the ribbon element to the specified quick access toolbar.  
  
<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>239\</CodeContentPlaceHolder>  
 The quick access toolbar.  
  
### Return Value  
 Always returns <CodeContentPlaceHolder>240\</CodeContentPlaceHolder> indicating the ribbon element was added to the quick access toolbar.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__onafterchangerect">\</a>  CMFCRibbonBaseElement::OnAfterChangeRect  
 Updates the tooltip for the ribbon element.  
  
<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>241\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
### Remarks  
 By default this method updates the tooltip for the ribbon element. Override this method to update the ribbon element after its display rectangle has changed.  
  
##  \<a name="cmfcribbonbaseelement__onautorepeat">\</a>  CMFCRibbonBaseElement::OnAutoRepeat  
 Updates the ribbon element in response to sustained user input.  
  
<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
### Return Value  
 Always returns <CodeContentPlaceHolder>242\</CodeContentPlaceHolder>.  
  
### Remarks  
 By default this method always return <CodeContentPlaceHolder>243\</CodeContentPlaceHolder>. Override this method to process sustained user input.  
  
##  \<a name="cmfcribbonbaseelement__oncalctextsize">\</a>  CMFCRibbonBaseElement::OnCalcTextSize  
 Calculates the size of the text for the ribbon element.  
  
<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>244\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
### Remarks  
 By default this method does nothing. Override this method to calculate the size of the text for the ribbon element.  
  
##  \<a name="cmfcribbonbaseelement__onchangemenuhighlight">\</a>  CMFCRibbonBaseElement::OnChangeMenuHighlight  
 Called by the framework when the highlight changes for a ribbon element that is located in a menu.  
  
<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>245\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
 [in] <CodeContentPlaceHolder>246\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
### Remarks  
 By default this method does nothing. Override this method to update a ribbon element that is located in a menu when the highlight changes.  
  
##  \<a name="cmfcribbonbaseelement__ondraw">\</a>  CMFCRibbonBaseElement::OnDraw  
 Called by the framework to draw the ribbon element.  
  
<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>247\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
### Remarks  
 Override this method in a derived class if you want to customize the drawing of a specific ribbon element.  
  
##  \<a name="cmfcribbonbaseelement__ondrawkeytip">\</a>  CMFCRibbonBaseElement::OnDrawKeyTip  
 Called by the framework to draw the keytip for the ribbon element.  
  
<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>248\</CodeContentPlaceHolder>  
 Pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>249\</CodeContentPlaceHolder>  
 Boundary rectangle for the keytip.  
  
 [in] <CodeContentPlaceHolder>250\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>251\</CodeContentPlaceHolder> if the keytip is for a pop-up menu button; otherwise, <CodeContentPlaceHolder>252\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__ondrawmenuimage">\</a>  CMFCRibbonBaseElement::OnDrawMenuImage  
 Called by the framework when the menu image for the ribbon element is drawn.  
  
<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>253\</CodeContentPlaceHolder>  
 Pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>254\</CodeContentPlaceHolder>  
 Menu image rectangle.  
  
### Return Value  
 Always returns <CodeContentPlaceHolder>255\</CodeContentPlaceHolder> to indicate the image was drawn.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__ondrawonlist">\</a>  CMFCRibbonBaseElement::OnDrawOnList  
 Called by the framework to draw the ribbon element in a commands list box.  
  
<CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>256\</CodeContentPlaceHolder>  
 Pointer to a device context for the ribbon element.  
  
 [in] <CodeContentPlaceHolder>257\</CodeContentPlaceHolder>  
 The display text.  
  
 [in] <CodeContentPlaceHolder>258\</CodeContentPlaceHolder>  
 Distance, in pixels, from the left side of the list box to the display text.  
  
 [in] <CodeContentPlaceHolder>259\</CodeContentPlaceHolder>  
 The display rectangle for the ribbon element.  
  
 [in] <CodeContentPlaceHolder>260\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
 [in] <CodeContentPlaceHolder>261\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
### Remarks  
 The commands list box displays ribbon elements to enable users to customize the quick access toolbar.  
  
##  \<a name="cmfcribbonbaseelement__onkey">\</a>  CMFCRibbonBaseElement::OnKey  
 Called by the framework when the user presses a keytip and the ribbon element has the focus.  
  
<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>262\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>263\</CodeContentPlaceHolder> if the keytip displays a pop-up menu; otherwise, <CodeContentPlaceHolder>264\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>265\</CodeContentPlaceHolder> if the event was handled; otherwise <CodeContentPlaceHolder>266\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__onmenukey">\</a>  CMFCRibbonBaseElement::OnMenuKey  
 Called by the framework when the user presses a menu keytip on the main panel.  
  
<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>267\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
### Return Value  
 Always returns <CodeContentPlaceHolder>268\</CodeContentPlaceHolder>.  
  
### Remarks  
 By default this method always returns <CodeContentPlaceHolder>269\</CodeContentPlaceHolder>. Override this method to respond when a user presses a menu keytip on the main panel.  
  
##  \<a name="cmfcribbonbaseelement__onprocesskey">\</a>  CMFCRibbonBaseElement::OnProcessKey  
 Called by the framework when the user presses a shortcut key.  
  
<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>270\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
### Return Value  
 Always returns <CodeContentPlaceHolder>271\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this method if you want the ribbon element to process a shortcut key.  
  
##  \<a name="cmfcribbonbaseelement__onrtlchanged">\</a>  CMFCRibbonBaseElement::OnRTLChanged  
 Called by the framework when the layout changes direction.  
  
<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>272\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
### Remarks  
 By default this method does nothing. Override this method to adjust the ribbon element when the layout changes direction. The default layout direction is left-to-right.  
  
##  \<a name="cmfcribbonbaseelement__onsetfocus">\</a>  CMFCRibbonBaseElement::OnSetFocus  
 Called by the framework when a ribbon element receives or loses the input focus.  
  
<CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
### Remarks  
 Override this method in a derived class if you want your application to handle a change in the focus of a ribbon element.  
  
##  \<a name="cmfcribbonbaseelement__onshow">\</a>  CMFCRibbonBaseElement::OnShow  
 Called by the framework to show or hide the ribbon element.  
  
<CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>273\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
### Remarks  
 By default this method does nothing. Override this method to show or hide the ribbon element.  
  
##  \<a name="cmfcribbonbaseelement__onshowpopupmenu">\</a>  CMFCRibbonBaseElement::OnShowPopupMenu  
 Called by the framework before the ribbon element shows a pop-up menu.  
  
<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
### Remarks  
 This method notifies the parent window of the ribbon bar that the ribbon element will show a pop-up menu.  
  
##  \<a name="cmfcribbonbaseelement__postmenucommand">\</a>  CMFCRibbonBaseElement::PostMenuCommand  
 Closes the pop-up menu for the ribbon element and sends a close message to the parent menu.  
  
<CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>274\</CodeContentPlaceHolder>  
 The parameter is not used.  
  
### Remarks  
 The close message is only sent if the ribbon element is located on a pop-up menu.  
  
##  \<a name="cmfcribbonbaseelement__redraw">\</a>  CMFCRibbonBaseElement::Redraw  
 Updates the display for the ribbon element.  
  
<CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
### Remarks  
 This method redraws the display rectangle for the ribbon element by calling                         [CWnd::RedrawWindow](http://msdn.microsoft.com/library/windows/desktop/dd162911) with the <CodeContentPlaceHolder>275\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>276\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>277\</CodeContentPlaceHolder> flags set.  
  
##  \<a name="cmfcribbonbaseelement__setaccdata">\</a>  CMFCRibbonBaseElement::SetACCData  
 Sets the accessibility data for the ribbon element.  
  
<CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>278\</CodeContentPlaceHolder>  
 The parent window for the ribbon element.  
  
 <CodeContentPlaceHolder>279\</CodeContentPlaceHolder>  
 The accessibility data for the ribbon element.  
  
### Return Value  
 Always returns <CodeContentPlaceHolder>280\</CodeContentPlaceHolder>.  
  
### Remarks  
 By default this method sets the accessibility data for the ribbon element and always returns <CodeContentPlaceHolder>281\</CodeContentPlaceHolder>. Override this method to set the accessibility data and return a value that indicates success or failure.  
  
##  \<a name="cmfcribbonbaseelement__setcompactmode">\</a>  CMFCRibbonBaseElement::SetCompactMode  
 Sets the display size for the ribbon element.  
  
<CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>282\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>283\</CodeContentPlaceHolder> to reduce the display size of the ribbon element; <CodeContentPlaceHolder>284\</CodeContentPlaceHolder> to increase the display size of the ribbon element.  
  
### Remarks  
 The following table summarizes the logic for this method.  
  
|<CodeContentPlaceHolder>285\</CodeContentPlaceHolder>|Current ribbon element size|New ribbon element size|  
|--------------------|---------------------------------|-----------------------------|  
|<CodeContentPlaceHolder>286\</CodeContentPlaceHolder>|Compact|No change.|  
|<CodeContentPlaceHolder>287\</CodeContentPlaceHolder>|Intermediate|Compact if it is possible.|  
|<CodeContentPlaceHolder>288\</CodeContentPlaceHolder>|Large|Intermediate if it is possible.|  
|<CodeContentPlaceHolder>289\</CodeContentPlaceHolder>|Compact|Intermediate if it is possible; otherwise large.|  
  
##  \<a name="cmfcribbonbaseelement__setdata">\</a>  CMFCRibbonBaseElement::SetData  
 Associates a data item with the ribbon element.  
  
<CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>290\</CodeContentPlaceHolder>  
 The data value.  
  
##  \<a name="cmfcribbonbaseelement__setdefaultmenulook">\</a>  CMFCRibbonBaseElement::SetDefaultMenuLook  
 Sets the ribbon element to appear as a pop-up command.  
  
<CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>291\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>292\</CodeContentPlaceHolder> to set the ribbon element to appear as a pop-up command; otherwise <CodeContentPlaceHolder>293\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__setdescription">\</a>  CMFCRibbonBaseElement::SetDescription  
 Sets the description for the ribbon element.  
  
<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>294\</CodeContentPlaceHolder>  
 The description for the ribbon element.  
  
### Remarks  
 The framework displays the new description either on the status bar, or in the tooltip, or under the menu button.  
  
##  \<a name="cmfcribbonbaseelement__setid">\</a>  CMFCRibbonBaseElement::SetID  
 Sets the command ID of the ribbon element.  
  
<CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>295\</CodeContentPlaceHolder>  
 The command ID.  
  
##  \<a name="cmfcribbonbaseelement__setinitialmode">\</a>  CMFCRibbonBaseElement::SetInitialMode  
 Sets the initial display size for the ribbon element.  
  
<CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>296\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>297\</CodeContentPlaceHolder> to limit the display size for the ribbon element to compact or intermediate; otherwise, <CodeContentPlaceHolder>298\</CodeContentPlaceHolder>.  
  
### Remarks  
 The display size of ribbon elements can be compact, intermediate, or large.  
  
##  \<a name="cmfcribbonbaseelement__setkeys">\</a>  CMFCRibbonBaseElement::SetKeys  
 Sets the keytips for the ribbon element.  
  
<CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>299\</CodeContentPlaceHolder>  
 The keytip for the ribbon element.  
  
 [in] <CodeContentPlaceHolder>300\</CodeContentPlaceHolder>  
 The keytip for the pop-up menu of the ribbon element.  
  
##  \<a name="cmfcribbonbaseelement__setoriginal">\</a>  CMFCRibbonBaseElement::SetOriginal  
 Sets the original ribbon element for the ribbon element.  
  
<CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>301\</CodeContentPlaceHolder>  
 Pointer to a ribbon element.  
  
### Remarks  
 Ribbon elements that are copied to another container retain a pointer to the original ribbon element.  
  
##  \<a name="cmfcribbonbaseelement__setparentcategory">\</a>  CMFCRibbonBaseElement::SetParentCategory  
 Sets the parent category for the ribbon element.  
  
<CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>302\</CodeContentPlaceHolder>  
 Pointer to a ribbon category.  
  
### Remarks  
 The tabbed groups in ribbon controls are called categories.  
  
##  \<a name="cmfcribbonbaseelement__setparentmenu">\</a>  CMFCRibbonBaseElement::SetParentMenu  
 Sets the parent menu container for the ribbon element.  
  
<CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>303\</CodeContentPlaceHolder>  
 The parent menu.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__setparentribbonbar">\</a>  CMFCRibbonBaseElement::SetParentRibbonBar  
 Sets the parent ribbon bar for the ribbon element.  
  
<CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>304\</CodeContentPlaceHolder>  
 Pointer to the parent ribbon bar.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__setrect">\</a>  CMFCRibbonBaseElement::SetRect  
 Sets the dimensions of the display rectangle for the ribbon element.  
  
<CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>305\</CodeContentPlaceHolder>  
 The dimensions of the rectangle.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__settext">\</a>  CMFCRibbonBaseElement::SetText  
 Sets the text and keytip for the ribbon element.  
  
<CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>306\</CodeContentPlaceHolder>  
 The text and keytip for the ribbon element.  
  
### Remarks  
 To set the keytip for the ribbon element, append the newline escape sequence followed by the keytip characters to <CodeContentPlaceHolder>307\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
##  \<a name="cmfcribbonbaseelement__settextalwaysonright">\</a>  CMFCRibbonBaseElement::SetTextAlwaysOnRight  
 Sets the text for the ribbon element to display on the right.  
  
<CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>308\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>309\</CodeContentPlaceHolder> to display the text on the right; otherwise <CodeContentPlaceHolder>310\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__settooltiptext">\</a>  CMFCRibbonBaseElement::SetToolTipText  
 Sets the tooltip text for the ribbon element.  
  
<CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>311\</CodeContentPlaceHolder>  
 The tooltip text.  
  
##  \<a name="cmfcribbonbaseelement__setvisible">\</a>  CMFCRibbonBaseElement::SetVisible  
 Sets the visibility of the ribbon element.  
  
<CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>312\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>313\</CodeContentPlaceHolder> to display the ribbon element; <CodeContentPlaceHolder>314\</CodeContentPlaceHolder> to hide the ribbon element.  
  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__stretchhorizontally">\</a>  CMFCRibbonBaseElement::StretchHorizontally  
 Stretches the width of the ribbon element.  
  
<CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
### Remarks  
 By default this method generates an assertion failure in debug builds and therefore should not be called. Override this method to stretch the width of the ribbon element.  
  
##  \<a name="cmfcribbonbaseelement__stretchtowholerow">\</a>  CMFCRibbonBaseElement::StretchToWholeRow  
 Changes the display height of the ribbon element to the specified row height.  
  
<CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>315\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
 [in] <CodeContentPlaceHolder>316\</CodeContentPlaceHolder>  
 The height of the row.  
  
### Return Value  
 <CodeContentPlaceHolder>317\</CodeContentPlaceHolder> if the display height was set; otherwise, <CodeContentPlaceHolder>318\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this method to change the display height of the ribbon element to the specified row height.  
  
##  \<a name="cmfcribbonbaseelement__updatetooltipinfo">\</a>  CMFCRibbonBaseElement::UpdateTooltipInfo  
 Updates the tooltip text by using the command resource for the ribbon element.  
  
<CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcribbonbaseelement__hasfocus">\</a>  CMFCRibbonBaseElement::HasFocus  
 Indicates whether the parent element has keyboard focus.  
  
<CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>319\</CodeContentPlaceHolder> if the ribbon element is focused; otherwise <CodeContentPlaceHolder>320\</CodeContentPlaceHolder>.  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)