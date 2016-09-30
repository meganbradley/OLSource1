---
title: "CMFCPopupMenuBar Class"
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
  - "CMFCPopupMenuBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCPopupMenuBar class"
ms.assetid: 4c93c459-7f70-4240-8c63-280bb811e374
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPopupMenuBar Class
A menu bar embedded into a pop-up menu.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCPopupMenuBar::AdjustSizeImmediate](#cmfcpopupmenubar__adjustsizeimmediate)|Immediately recalculates the layout of a pane. (Overrides [CPane::AdjustSizeImmediate](../vs140/cpane-class.md#cpane__adjustsizeimmediate).)|  
|[CMFCPopupMenuBar::BuildOrigItems](#cmfcpopupmenubar__buildorigitems)|Loads popup menu items from a specified menu resource.|  
|[CMFCPopupMenuBar::CloseDelayedSubMenu](#cmfcpopupmenubar__closedelayedsubmenu)|Closes a delayed popup menu button.|  
|[CMFCPopupMenuBar::ExportToMenu](#cmfcpopupmenubar__exporttomenu)|Builds a menu from the popup-menu buttons.|  
|[CMFCPopupMenuBar::FindDestintationToolBar](#cmfcpopupmenubar__finddestintationtoolbar)|Locates the toolbar where a specified point lies.|  
|[CMFCPopupMenuBar::GetCurrentMenuImageSize](#cmfcpopupmenubar__getcurrentmenuimagesize)|Indicates the size of menu-button images.|  
|[CMFCPopupMenuBar::GetDefaultMenuId](#cmfcpopupmenubar__getdefaultmenuid)|Returns the identifier of the default menu item.|  
|[CMFCPopupMenuBar::GetLastCommandIndex](#cmfcpopupmenubar__getlastcommandindex)|Gets the index of the most recently invoked menu command.|  
|[CMFCPopupMenuBar::GetOffset](#cmfcpopupmenubar__getoffset)|Gets the row offset of the popup menu bar.|  
|[CMFCPopupMenuBar::ImportFromMenu](#cmfcpopupmenubar__importfrommenu)|Imports popup menu buttons from a specified menu.|  
|[CMFCPopupMenuBar::IsDropDownListMode](#cmfcpopupmenubar__isdropdownlistmode)|Indicates whether the popup menu bar is in drop-down-list mode.|  
|[CMFCPopupMenuBar::IsPaletteMode](#cmfcpopupmenubar__ispalettemode)|Indicates whether the popup menu bar is in palette mode.|  
|[CMFCPopupMenuBar::IsRibbonPanel](#cmfcpopupmenubar__isribbonpanel)|Indicates whether this is a ribbon panel ( <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> by default).|  
|[CMFCPopupMenuBar::IsRibbonPanelInRegularMode](#cmfcpopupmenubar__isribbonpanelinregularmode)|Indicates whether this is a ribbon panel in regular mode ( <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> by default).|  
|[CMFCPopupMenuBar::LoadFromHash](#cmfcpopupmenubar__loadfromhash)|Loads an archived menu.|  
|[CMFCPopupMenuBar::RestoreDelayedSubMenu](#cmfcpopupmenubar__restoredelayedsubmenu)|Restores a delayed menu button for closing the popup menu bar.|  
|[CMFCPopupMenuBar::SetButtonStyle](#cmfcpopupmenubar__setbuttonstyle)|Sets the style of the toolbar button at the given index. (Overrides [CMFCToolBar::SetButtonStyle](../vs140/cmfctoolbar-class.md#cmfctoolbar__setbuttonstyle).)|  
|[CMFCPopupMenuBar::SetOffset](#cmfcpopupmenubar__setoffset)|Sets the row offset of the popup menu bar.|  
|[CMFCPopupMenuBar::StartPopupMenuTimer](#cmfcpopupmenubar__startpopupmenutimer)|Starts the timer for a specified delayed popup menu button.|  
  
### Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCPopupMenuBar::m_bDisableSideBarInXPMode](#cmfcpopupmenubar__m_bdisablesidebarinxpmode)|Specifies whether the gray sidebar will be displayed when the application has a Windows XP appearance.|  
  
## Remarks  
 The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is created at the same time as a [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md) and embedded inside it. The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> covers the entire client area of the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object. It supports keyboard and mouse input. It also communicates that input to the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and to the top-level frame window.  
  
## Example  
 The following example demonstrates how to initialize a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object from a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object. This code snippet is part of the [Draw Client sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_DrawClient#7](../vs140/codesnippet/CPP/cmfcpopupmenubar-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CBasePane](../vs140/cbasepane-class.md)  
  
 [CPane](../vs140/cpane-class.md)  
  
 [CMFCBaseToolBar](../vs140/cmfcbasetoolbar-class.md)  
  
 [CMFCToolBar](../vs140/cmfctoolbar-class.md)  
  
 [CMFCPopupMenuBar](../vs140/cmfcpopupmenubar-class.md)  
  
## Requirements  
 **Header:** afxpopupmenubar.h  
  
##  \<a name="cmfcpopupmenubar__adjustsizeimmediate">\</a>  CMFCPopupMenuBar::AdjustSizeImmediate  
 Immediately recalculates the layout of the popup menu bar pane. (Overrides [CPane::AdjustSizeImmediate](../vs140/cpane-class.md#cpane__adjustsizeimmediate).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> to automatically recalculate the layout of the popup menu bar pane; otherwise, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcpopupmenubar__buildorigitems">\</a>  CMFCPopupMenuBar::BuildOrigItems  
 Loads popup menu items from a specified menu resource.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 Specifies the menu ID of the menu resource to load.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> if successful or <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> if not.  
  
### Remarks  
  
##  \<a name="cmfcpopupmenubar__closedelayedsubmenu">\</a>  CMFCPopupMenuBar::CloseDelayedSubMenu  
 Closes a popup menu button that has been delayed.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcpopupmenubar__exporttomenu">\</a>  CMFCPopupMenuBar::ExportToMenu  
 Builds a menu from the popup menu buttons.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 Returns a handle to the new menu.  
  
### Remarks  
  
##  \<a name="cmfcpopupmenubar__finddestintationtoolbar">\</a>  CMFCPopupMenuBar::FindDestintationToolBar  
 Locates the toolbar where a specified point lies.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 A point on the screen.  
  
### Return Value  
 Returns a handle to the toolbar where the point lies, if therei is one, or <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> if not.  
  
### Remarks  
  
##  \<a name="cmfcpopupmenubar__getcurrentmenuimagesize">\</a>  CMFCPopupMenuBar::GetCurrentMenuImageSize  
 Indicates the size of menu-button images.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Returns the size of menu-button images in the toolbar.  
  
### Remarks  
  
##  \<a name="cmfcpopupmenubar__getdefaultmenuid">\</a>  CMFCPopupMenuBar::GetDefaultMenuId  
 Returns the identifier of the default menu item.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 Returns the identifier of the default menu item in the popup menu bar.  
  
### Remarks  
  
##  \<a name="cmfcpopupmenubar__getlastcommandindex">\</a>  CMFCPopupMenuBar::GetLastCommandIndex  
 Gets the index of the most recently invoked menu command.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 Returns the index of the last menu command that has been invoked.  
  
### Remarks  
  
##  \<a name="cmfcpopupmenubar__getoffset">\</a>  CMFCPopupMenuBar::GetOffset  
 Gets the row offset of the popup menu bar.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 Returns the row offset of the popup menu bar.  
  
### Remarks  
 This value is set using [CMFCPopupMenuBar::SetOffset](#cmfcpopupmenubar__setoffset).  
  
##  \<a name="cmfcpopupmenubar__importfrommenu">\</a>  CMFCPopupMenuBar::ImportFromMenu  
 Imports popup menu buttons from a specified menu.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The menu from which to import the popup menu buttons.  
  
 [in] <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> if all commands on the menu are to be imported, or <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> if rarely used ones may be hidden.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> if the menu buttons were successfully imported from the menu, or <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> if not.  
  
### Remarks  
  
##  \<a name="cmfcpopupmenubar__isdropdownlistmode">\</a>  CMFCPopupMenuBar::IsDropDownListMode  
 Indicates whether the popup menu bar is in drop-down-list mode.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> if the popup menu bar is in drop-down-list mode, or <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> if not.  
  
### Remarks  
  
##  \<a name="cmfcpopupmenubar__ispalettemode">\</a>  CMFCPopupMenuBar::IsPaletteMode  
 Indicates whether the popup menu bar is in palette mode.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> if palette mode is enabled, or <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> if not.  
  
### Remarks  
 When the menu bar is set to palette mode, menu items appear in multiple columns and a limited number of rows.  
  
##  \<a name="cmfcpopupmenubar__isribbonpanel">\</a>  CMFCPopupMenuBar::IsRibbonPanel  
 Indicates whether this is a ribbon panel ( <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> by default).  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> by default, indicating that this is not a ribbon panel.  
  
### Remarks  
  
##  \<a name="cmfcpopupmenubar__isribbonpanelinregularmode">\</a>  CMFCPopupMenuBar::IsRibbonPanelInRegularMode  
 Indicates whether this is a ribbon panel in regular mode ( <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> by default).  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> by default, indicating that this is not a ribbon panel in regular mode.  
  
### Remarks  
  
##  \<a name="cmfcpopupmenubar__loadfromhash">\</a>  CMFCPopupMenuBar::LoadFromHash  
 Loads an archived menu.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 A handle to the archived menu to load.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> if the menu is loaded successfully, or <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> if not.  
  
### Remarks  
  
##  \<a name="cmfcpopupmenubar__m_bdisablesidebarinxpmode">\</a>  CMFCPopupMenuBar::m_bDisableSideBarInXPMode  
 A Boolean parameter that indicates whether your application has a gray sidebar when it has a Windows XP appearance.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Remarks  
 If this member variable is set to <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> and your application has a Windows XP appearance, the framework draws a gray sidebar in your application.  
  
 The default value is <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcpopupmenubar__restoredelayedsubmenu">\</a>  CMFCPopupMenuBar::RestoreDelayedSubMenu  
 Restores a delayed menu button for closing the popup menu bar.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcpopupmenubar__setbuttonstyle">\</a>  CMFCPopupMenuBar::SetButtonStyle  
 Sets the style of the toolbar button at the given index. (Overrides [CMFCToolBar::SetButtonStyle](../vs140/cmfctoolbar-class.md#cmfctoolbar__setbuttonstyle).)  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 The zero-based index of the toolbar button whose style is to be set.  
  
 [in] <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 The style of the button. See [ToolBar Control Styles](../vs140/toolbar-control-styles.md) for the list of available toolbar button styles.  
  
### Remarks  
  
##  \<a name="cmfcpopupmenubar__setoffset">\</a>  CMFCPopupMenuBar::SetOffset  
 Sets the row offset of the popup menu bar.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 The number of rows that the popup menu bar should be offset.  
  
### Remarks  
  
##  \<a name="cmfcpopupmenubar__startpopupmenutimer">\</a>  CMFCPopupMenuBar::StartPopupMenuTimer  
 Starts the timer for a specified delayed popup menu button.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 Pointer to the menu button for which to set the delay timer.  
  
 [in] <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 A delay factor, equal to at least one, to multiply by the standard menu delay time (generally between a half second and five seconds).  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCColorBar Class](../vs140/cmfccolorbar-class.md)   
 [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md)