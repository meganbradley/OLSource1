---
title: "CBaseTabbedPane Class"
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
  - "CBaseTabbedPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CBaseTabbedPane class"
ms.assetid: f22c0080-5b29-4a0a-8f74-8f0a4cd2dbcf
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBaseTabbedPane Class
Extends the functionality of the [CDockablePane Class](../vs140/cdockablepane-class.md) to support the creation of tabbed windows.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|Default constructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CBaseTabbedPane::AddTab](#cbasetabbedpane__addtab)|Adds a new tab to a tabbed pane.|  
|[CBaseTabbedPane::AllowDestroyEmptyTabbedPane](#cbasetabbedpane__allowdestroyemptytabbedpane)|Specifies whether an empty tabbed pane can be destroyed.|  
|[CBaseTabbedPane::ApplyRestoredTabInfo](#cbasetabbedpane__applyrestoredtabinfo)|Applies tab settings, which are loaded from the registry, to a tabbed pane.|  
|[CBaseTabbedPane::CanFloat](#cbasetabbedpane__canfloat)|Determines whether the pane can float. (Overrides [CBasePane::CanFloat](../vs140/cbasepane-class.md#cbasepane__canfloat).)|  
|[CBaseTabbedPane::CanSetCaptionTextToTabName](#cbasetabbedpane__cansetcaptiontexttotabname)|Determines whether the caption for the tabbed pane should display the same text as the active tab.|  
|[CBaseTabbedPane::ConvertToTabbedDocument](#cbasetabbedpane__converttotabbeddocument)|(Overrides [CDockablePane::ConvertToTabbedDocument](../vs140/cdockablepane-class.md#cdockablepane__converttotabbeddocument).)|  
|[CBaseTabbedPane::DetachPane](#cbasetabbedpane__detachpane)|Converts one or more dockable panes to MDI tabbed documents.|  
|[CBaseTabbedPane::EnableSetCaptionTextToTabName](#cbasetabbedpane__enablesetcaptiontexttotabname)|Enables or disables the ability of the tabbed pane to synchronize caption text with the label text on the active tab.|  
|[CBaseTabbedPane::FillDefaultTabsOrderArray](#cbasetabbedpane__filldefaulttabsorderarray)|Restores the internal tab order to a default state.|  
|[CBaseTabbedPane::FindBarByTabNumber](#cbasetabbedpane__findbarbytabnumber)|Returns a pane that resides in a tab when the tab is identified by a zero-based tab index.|  
|||  
|[CBaseTabbedPane::FindPaneByID](#cbasetabbedpane__findpanebyid)|Returns a pane that is identified by the pane ID.|  
|[CBaseTabbedPane::FloatTab](#cbasetabbedpane__floattab)|Floats a pane, but only if the pane currently resides in a detachable tab.|  
|[CBaseTabbedPane::GetDefaultTabsOrder](#cbasetabbedpane__getdefaulttabsorder)|Returns the default order of tabs in the pane.|  
|[CBaseTabbedPane::GetFirstVisibleTab](#cbasetabbedpane__getfirstvisibletab)|Retrieves a pointer to the first displayed tab.|  
|[CBaseTabbedPane::GetMinSize](#cbasetabbedpane__getminsize)|Retrieves the minimum allowed size for the pane. (Overrides [CPane::GetMinSize](../vs140/cpane-class.md#cpane__getminsize).)|  
|[CBaseTabbedPane::GetPaneIcon](#cbasetabbedpane__getpaneicon)|Returns a handle to the pane icon. (Overrides [CBasePane::GetPaneIcon](../vs140/cbasepane-class.md#cbasepane__getpaneicon).)|  
|[CBaseTabbedPane::GetPaneList](#cbasetabbedpane__getpanelist)|Returns a list of panes that are contained in the tabbed pane.|  
|[CBaseTabbedPane::GetTabArea](#cbasetabbedpane__gettabarea)|Returns the bounding rectangles for the top and bottom tab areas.|  
|[CBaseTabbedPane::GetTabsNum](#cbasetabbedpane__gettabsnum)|Returns the count of tabs in a tab window.|  
|[CBaseTabbedPane::GetUnderlyingWindow](#cbasetabbedpane__getunderlyingwindow)|Gets the underlying (wrapped) tab window.|  
|[CBaseTabbedPane::GetVisibleTabsNum](#cbasetabbedpane__getvisibletabsnum)|Returns the count of displayed tabs.|  
|[CBaseTabbedPane::HasAutoHideMode](#cbasetabbedpane__hasautohidemode)|Determines whether the tabbed pane can be switched to auto-hide mode.|  
|[CBaseTabbedPane::IsHideSingleTab](#cbasetabbedpane__ishidesingletab)|Determines whether the tabbed pane is hidden if only one tab is displayed.|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|Used internally during serialization.|  
|[CBaseTabbedPane::RecalcLayout](#cbasetabbedpane__recalclayout)|Recalculates layout information for the pane. (Overrides [CPane::RecalcLayout](../vs140/cpane-class.md#cpane__recalclayout).)|  
|[CBaseTabbedPane::RemovePane](#cbasetabbedpane__removepane)|Removes a pane from the tabbed pane.|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|Used internally during serialization.|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|(Overrides [CDockablePane::Serialize](assetId:///09787e59-e446-4e76-894b-206d303dcfd6).)|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|Used internally during serialization.|  
|[CBaseTabbedPane::SetAutoDestroy](#cbasetabbedpane__setautodestroy)|Determines whether the tabbed control bar will be destroyed automatically.|  
|[CBaseTabbedPane::SetAutoHideMode](#cbasetabbedpane__setautohidemode)|Toggles the docking pane between displayed and auto-hide mode. (Overrides [CDockablePane::SetAutoHideMode](../vs140/cdockablepane-class.md#cdockablepane__setautohidemode).)|  
|[CBaseTabbedPane::ShowTab](#cbasetabbedpane__showtab)|Shows or hides a tab.|  
  
## Remarks  
 This class is an abstract class and cannot be instantiated. It implements the services that are common to all kinds of tabbed panes.  
  
 Currently, the library includes two derived tabbed pane classes: [CTabbedPane Class](../vs140/ctabbedpane-class.md) and [CMFCOutlookBar](../vs140/cmfcoutlookbar-class.md).  
  
 A <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object wraps a pointer to a [CMFCBaseTabCtrl](../vs140/cmfcbasetabctrl-class.md) object. [CMFCBaseTabCtrl](../vs140/cmfcbasetabctrl-class.md) then becomes a child window of the tabbed pane.  
  
 For more information about how to create tabbed panes, see [CDockablePane Class](../vs140/cdockablepane-class.md), [CTabbedPane Class](../vs140/ctabbedpane-class.md), and [CMFCOutlookBar](../vs140/cmfcoutlookbar-class.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CBasePane](../vs140/cbasepane-class.md)  
  
 [CPane](../vs140/cpane-class.md)  
  
 [CDockablePane](../vs140/cdockablepane-class.md)  
  
 [CBaseTabbedPane](../vs140/cbasetabbedpane-class.md)  
  
## Requirements  
 **Header:** afxBaseTabbedPane.h  
  
##  \<a name="cbasetabbedpane__addtab">\</a>  CBaseTabbedPane::AddTab  
 Adds a new tab to a tabbed pane.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] [out] <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 A pointer to the pane to add. This pointer may become invalid after you call this method. For more information, see the Remarks section.  
  
 [in] <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> to make the tab visible; otherwise, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> to make the tab the active tab; otherwise, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> to make the tab detachable; otherwise, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> if the pane was successfully added as a tab and was not destroyed in the process. <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> if the pane being added is an object of type <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>. For more information, see the Remarks section.  
  
### Remarks  
 Call this method to add a pane as a new tab on a tabbed pane. If <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> points to an object of type <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, all its tabs are copied onto the tabbed pane and then <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> is destroyed. Thus, <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> becomes an invalid pointer and should not be used.  
  
##  \<a name="cbasetabbedpane__allowdestroyemptytabbedpane">\</a>  CBaseTabbedPane::AllowDestroyEmptyTabbedPane  
 Specifies whether an empty tabbed pane can be destroyed.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> if an empty tabbed pane can be destroyed; otherwise, <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>. The default implementation always returns <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>.  
  
### Remarks  
 If an empty tabbed pane is not allowed to be destroyed, the framework hides the pane instead.  
  
##  \<a name="cbasetabbedpane__applyrestoredtabinfo">\</a>  CBaseTabbedPane::ApplyRestoredTabInfo  
 Loads tab settings from the registry and applies them to a tabbed pane.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 This parameter is used internally by the framework.  
  
### Remarks  
 This method is called by the framework when it reloads docking state information from the registry. The method obtains information about tab order and tab names for a tabbed pane.  
  
##  \<a name="cbasetabbedpane__canfloat">\</a>  CBaseTabbedPane::CanFloat  
 Specifies whether the tabbed pane can float.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> if the pane can float; otherwise, <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.  
  
##  \<a name="cbasetabbedpane__cansetcaptiontexttotabname">\</a>  CBaseTabbedPane::CanSetCaptionTextToTabName  
 Determines whether the caption for the tabbed pane should display the same text as the active tab.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> if the caption text of the tabbed pane is set to the text of the active tab; otherwise, <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
### Remarks  
 The method is used to determine whether the text displayed on the tabbed pane caption duplicates the label of the active tab. You can enable or disable this functionality by calling [CBaseTabbedPane::EnableSetCaptionTextToTabName](#cbasetabbedpane__enablesetcaptiontexttotabname).  
  
##  \<a name="cbasetabbedpane__converttotabbeddocument">\</a>  CBaseTabbedPane::ConvertToTabbedDocument  
 Converts one or more dockable panes to MDI tabbed documents.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 When you convert a tabbed pane, specify <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> to convert only the active tab. Specify <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> to convert all tabs in the pane.  
  
##  \<a name="cbasetabbedpane__detachpane">\</a>  CBaseTabbedPane::DetachPane  
 Detaches a pane from the tabbed pane.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 Pointer to the pane to detach.  
  
 [in] <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 Boolean parameter that specifies whether the framework hides the pane after it is detached.  
  
### Return Value  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> if the framework successfully detaches the pane; <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> or refers to a pane that is not in the tabbed pane.  
  
### Remarks  
 The framework floats the detached pane if possible. For more information, see [CBasePane::CanFloat](../vs140/cbasepane-class.md#cbasepane__canfloat).  
  
##  \<a name="cbasetabbedpane__enablesetcaptiontexttotabname">\</a>  CBaseTabbedPane::EnableSetCaptionTextToTabName  
 Enables or disables the ability of the tabbed pane to synchronize caption text with the label text on the active tab.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> to synchronize the tabbed pane caption with the active tab caption; otherwise, <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>.  
  
##  \<a name="cbasetabbedpane__filldefaulttabsorderarray">\</a>  CBaseTabbedPane::FillDefaultTabsOrderArray  
 Restores the internal tab order to a default state.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 This method is called when the framework restores an Outlook bar to an initial state.  
  
##  \<a name="cbasetabbedpane__findpanebyid">\</a>  CBaseTabbedPane::FindPaneByID  
 Returns a pane identified by the pane ID.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 Specifies the ID of the pane to find.  
  
### Return Value  
 A pointer to the pane if it was found; otherwise, <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method compares all tabs in the pane and returns the one with the ID specified by the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> parameter.  
  
##  \<a name="cbasetabbedpane__findbarbytabnumber">\</a>  CBaseTabbedPane::FindBarByTabNumber  
 Returns a pane that resides in a tab.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the tab to retrieve.  
  
 [in] <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> to return the underlying (wrapped) window of the pane instead of the pane itself; otherwise <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>. This only applies to panes derived from [CDockablePaneAdapter](../vs140/cdockablepaneadapter-class.md).  
  
### Return Value  
 If the pane is found, then a valid pointer to the pane being searched for is returned; otherwise, <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>.  
  
### Remarks  
 Call this method to retrieve the pane residing in the tab specified by the <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> parameter.  
  
##  \<a name="cbasetabbedpane__floattab">\</a>  CBaseTabbedPane::FloatTab  
 Floats a pane, but only if the pane currently resides in a detachable tab.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] [out] <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 A pointer to the pane to float.  
  
 [in] <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the tab to float.  
  
 [in] <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 Specifies the method to use to make the pane float. For more information, see the Remarks section.  
  
 [in] <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> to hide the pane before floating; otherwise, <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> if the pane floated; otherwise, <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>.  
  
### Remarks  
 Call this method to float a pane that currently resides in a detachable tab.  
  
 If you want to detach a pane programmatically, specify <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> for the <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> parameter. If you want to float the pane in the same position where it floated previously, specify <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> as the <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> parameter.  
  
##  \<a name="cbasetabbedpane__getdefaulttabsorder">\</a>  CBaseTabbedPane::GetDefaultTabsOrder  
 Returns the default order of tabs in the pane.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> object that specifies the default order of tabs in the pane.  
  
### Remarks  
 The framework calls this method when an Outlook bar is reset to an initial state.  
  
##  \<a name="cbasetabbedpane__getfirstvisibletab">\</a>  CBaseTabbedPane::GetFirstVisibleTab  
 Retrieves a pointer to the first displayed tab.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 A reference to an integer. This method writes the zero-based index of the first displayed tab to this parameter, or -1 if no displayed tab is found.  
  
### Return Value  
 If successful, a pointer to the first displayed tab; otherwise, <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>.  
  
##  \<a name="cbasetabbedpane__getminsize">\</a>  CBaseTabbedPane::GetMinSize  
 Retrieves the minimum allowed size for the pane.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> object that is filled with the minimum allowed size.  
  
### Remarks  
 If consistent handling of minimum pane sizes is active ( [CPane::m_bHandleMinSize](../vs140/cpane-class.md#cpane__m_bhandleminsize)), <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> is filled with the minimum allowed size for the active tab. Otherwise, <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> is filled with the return value of [CPane::GetMinSize](../vs140/cpane-class.md#cpane__getminsize).  
  
##  \<a name="cbasetabbedpane__getpaneicon">\</a>  CBaseTabbedPane::GetPaneIcon  
 Retrieves the minimum allowed size for the pane.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> object that is filled with the minimum allowed size.  
  
### Remarks  
 If consistent handling of minimum pane sizes is active ( [CPane::m_bHandleMinSize](../vs140/cpane-class.md#cpane__m_bhandleminsize)), <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> is filled with the minimum allowed size for the active tab. Otherwise, <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> is filled with the return value of [CPane::GetMinSize](../vs140/cpane-class.md#cpane__getminsize).  
  
##  \<a name="cbasetabbedpane__getpanelist">\</a>  CBaseTabbedPane::GetPaneList  
 Returns a list of panes that are contained in the tabbed pane.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> that is filled with the panes that are contained in the tabbed pane.  
  
 [in] <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 If it is not <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>, the returned list contains only panes that are of the specified runtime class.  
  
##  \<a name="cbasetabbedpane__gettabarea">\</a>  CBaseTabbedPane::GetTabArea  
 Returns the bounding rectangles for the top and bottom tab areas.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 Receives the screen coordinates of the upper tab area.  
  
 [out] <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 Receives the screen coordinates of the lower tab area.  
  
### Remarks  
 Call this method to determine the bounding rectangles, in screen coordinates, for the upper and lower tab areas.  
  
##  \<a name="cbasetabbedpane__gettabsnum">\</a>  CBaseTabbedPane::GetTabsNum  
 Returns the count of tabs in a tab window.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 The number of tabs in the tabbed pane.  
  
##  \<a name="cbasetabbedpane__getunderlyingwindow">\</a>  CBaseTabbedPane::GetUnderlyingWindow  
 Gets the underlying (wrapped) tab window.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the underlying tab window.  
  
##  \<a name="cbasetabbedpane__getvisibletabsnum">\</a>  CBaseTabbedPane::GetVisibleTabsNum  
 Returns the count of visible tabs.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 The number of visible tabs, which will be greater than or equal to zero.  
  
### Remarks  
 Call this method to determine the number of visible tabs in the tabbed pane.  
  
##  \<a name="cbasetabbedpane__hasautohidemode">\</a>  CBaseTabbedPane::HasAutoHideMode  
 Determines whether the tabbed pane can be switched to autohide mode.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> if the pane can be switched to autohide mode; otherwise, <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>.  
  
### Remarks  
 If autohide mode is disabled, no pin button is displayed on the tabbed pane caption.  
  
##  \<a name="cbasetabbedpane__ishidesingletab">\</a>  CBaseTabbedPane::IsHideSingleTab  
 Determines whether the tabbed pane is hidden if only one tab is displayed.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> if the tab window is not shown when there is only one visible tab; otherwise, <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>.  
  
### Remarks  
 If the pane is not displayed because only one tab is open, you can call this method to determine whether the tabbed pane is working correctly.  
  
##  \<a name="cbasetabbedpane__removepane">\</a>  CBaseTabbedPane::RemovePane  
 Removes a pane from the tabbed pane.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 [in] [out] <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
 A pointer to the pane to remove from the tabbed pane.  
  
### Return Value  
 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> if the pane was successfully removed from the tabbed pane and if the tabbed pane is still valid. <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> if the last pane has been removed from the tabbed pane and the tabbed pane is about to be destroyed. If the return value is <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>, do not use the tabbed pane any more.  
  
### Remarks  
 Call this method to remove the pane specified by the <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> parameter from the tabbed pane.  
  
##  \<a name="cbasetabbedpane__setautodestroy">\</a>  CBaseTabbedPane::SetAutoDestroy  
 Determines whether the tabbed control bar will be destroyed automatically.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> if the tabbed pane was created dynamically and you are not controlling its lifetime; otherwise, <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>.  
  
### Remarks  
 Set the auto-destroy mode to <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> if you create a tabbed pane dynamically and if you are not controlling its lifetime. If auto-destroy mode is <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>, the tabbed pane will be destroyed automatically by the framework.  
  
##  \<a name="cbasetabbedpane__showtab">\</a>  CBaseTabbedPane::ShowTab  
 Shows or hides a tab.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
 A pointer to the pane to show or hide.  
  
 [in] <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> to show the pane; <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> to hide the pane.  
  
 [in] <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> to delay the adjustment of the tab layout; otherwise, <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> to make the tab the active tab; otherwise, <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> if the tab was either shown or hidden successfully; otherwise, <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>.  
  
### Remarks  
 When you call this method, a pane is either shown or hidden, depending on the value of the <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> parameter. If you hide a tab and it is the last visible tab in the underlying tab window, the tabbed pane is hidden. If you show a tab when there were previously no tabs visible, the tabbed pane is shown.  
  
##  \<a name="cbasetabbedpane__recalclayout">\</a>  CBaseTabbedPane::RecalcLayout  
 Recalculates layout information for the pane.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Remarks  
 If the pane is floating, this method notifies the framework to resize the pane to the current size of the mini-frame.  
  
 If the pane is docked, this method does nothing.  
  
##  \<a name="cbasetabbedpane__setautohidemode">\</a>  CBaseTabbedPane::SetAutoHideMode  
 Sets the auto-hide mode for detachable panes in the tabbed pane.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> to enable auto-hide mode; <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> to enable regular docking mode.  
  
 [in] <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
 Specifies the alignment of the auto-hide pane that is to be created. For a list of possible values, see [CPane::MoveByAlignment](../vs140/cpane-class.md#cpane__movebyalignment).  
  
 [in] [out] <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
 A pointer to the current auto-hide toolbar. Can be <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>  
 Specifies whether to use the auto-hide effect when the user switches the pane to auto-hide mode, or to hide the pane immediately.  
  
### Return Value  
 A pointer to the auto-hide toolbar that is created when switching to auto-hide mode, or <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> if no toolbar is created.  
  
### Remarks  
 The framework calls this method when a user chooses the pin button to switch the tabbed pane to auto-hide mode or to regular docking mode.  
  
 Auto-hide mode is set for each detachable pane in the tabbed pane. Panes that are non-detachable are ignored. For more information, see [CMFCBaseTabCtrl::EnableTabDetach](../vs140/cmfcbasetabctrl-class.md#cmfcbasetabctrl__enabletabdetach).  
  
 Call this method to switch a tabbed pane to auto-hide mode programmatically. The pane must be docked to the main frame window ( [CDockablePane::GetDefaultPaneDivider](../vs140/cdockablepane-class.md#cdockablepane__getdefaultpanedivider) must return a valid pointer to the [CPaneDivider](../vs140/cpanedivider-class.md)).  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CDockablePane Class](../vs140/cdockablepane-class.md)