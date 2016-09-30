---
title: "CSnapInItemImpl Class"
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
  - "CSnapInItemImpl"
  - "ATL.CSnapInItemImpl"
  - "ATL::CSnapInItemImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "snap-ins, data items"
  - "snap-ins, ATL support for"
  - "CSnapInItemImpl class"
  - "snap-ins"
ms.assetid: 52caefbd-9eae-49b0-add2-d55524271aa7
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSnapInItemImpl Class
This class provides methods for implementing a snap-in node object.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 Your class, derived from <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 *bIsExtension*  
 **TRUE** if the object is a snap-in extension; otherwise **FALSE**.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CSnapInItemImpl::CSnapInItemImpl](../vs140/csnapinitemimpl--csnapinitemimpl.md)|Constructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CSnapInItemImpl::AddMenuItems](../vs140/csnapinitemimpl--addmenuitems.md)|Adds menu items to a context menu.|  
|[CSnapInItemImpl::Command](../vs140/csnapinitemimpl--command.md)|Called by the console when a custom menu item is selected.|  
|[CSnapInItemImpl::CreatePropertyPages](../vs140/csnapinitemimpl--createpropertypages.md)|Adds pages to the property sheet of the snap-in.|  
|[CSnapInItemImpl::FillData](../vs140/csnapinitemimpl--filldata.md)|Copies information on the snap-in object into a specified stream.|  
|[CSnapInItemImpl::GetResultPaneInfo](../vs140/csnapinitemimpl--getresultpaneinfo.md)|Retrieves the **RESULTDATAITEM** structure of the snap-in.|  
|[CSnapInItemImpl::GetResultViewType](../vs140/csnapinitemimpl--getresultviewtype.md)|Determines the type of view used by the result pane.|  
|[CSnapInItemImpl::GetScopePaneInfo](../vs140/csnapinitemimpl--getscopepaneinfo.md)|Retrieves the **SCOPEDATAITEM** structure of the snap-in.|  
|[CSnapInItemImpl::Notify](../vs140/csnapinitemimpl--notify.md)|Called by the console to notify the snap-in of actions taken by the user.|  
|[CSnapInItemImpl::QueryPagesFor](../vs140/csnapinitemimpl--querypagesfor.md)|Called to see if the snap-in node supports property pages.|  
|[CSnapInItemImpl::SetMenuInsertionFlags](../vs140/csnapinitemimpl--setmenuinsertionflags.md)|Modifies the menu insertion flags for a snap-in object.|  
|[CSnapInItemImpl::SetToolbarButtonInfo](../vs140/csnapinitemimpl--settoolbarbuttoninfo.md)|Sets the information of the specified toolbar button.|  
|[CSnapInItemImpl::UpdateMenuState](../vs140/csnapinitemimpl--updatemenustate.md)|Updates the state of a context menu item.|  
|[CSnapInItemImpl::UpdateToolbarButton](../vs140/csnapinitemimpl--updatetoolbarbutton.md)|Updates the state of the specified toolbar button.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CSnapInItemImpl::m_bstrDisplayName](../vs140/csnapinitemimpl--m_bstrdisplayname.md)|The name of the snap-in object.|  
|[CSnapInItemImpl::m_resultDataItem](../vs140/csnapinitemimpl--m_resultdataitem.md)|The Windows **RESULTDATAITEM** structure used by the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object.|  
|[CSnapInItemImpl::m_scopeDataItem](../vs140/csnapinitemimpl--m_scopedataitem.md)|The Windows **SCOPEDATAITEM** structure used by the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> provides a basic implementation for a snap-in node object, such as adding menu items and toolbars, and forwarding commands for the snap-in node to the appropriate handler function. These features are implemented using several different interfaces and map types. The default implementation handles notifications sent to the node object by determining the correct instance of the derived class and then forwarding the message to the correct instance.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlsnap.h  
  
##  \<a name="csnapinitemimpl__addmenuitems">\</a>  CSnapInItemImpl::AddMenuItems  
 This method implements the Win32 function [IExtendContextMenu::AddMenuItems](http://msdn.microsoft.com/library/aa814841).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 *piCallback*  
 [in] Pointer to the **IContextMenuCallback** that can add items to the context menu.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 [in, out] Identifies Microsoft Management Console (MMC)-defined, menu-item insertion points that can be used. This can be a combination of the following flags:  
  
-   **CCM_INSERTIONALLOWED_TOP** Items can be inserted at the top of a context menu.  
  
-   **CCM_INSERTIONALLOWED_NEW** Items can be inserted in the Create New submenu.  
  
-   **CCM_INSERTIONALLOWED_TASK** Items can be inserted in the Task submenu.  
  
-   **CCM_INSERTIONALLOWED_VIEW** Items can be inserted in the toolbar view menu or in the View submenu of the result pane context menu.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 [in] Specifies the type of object. It can have one of the following values:  
  
-   **CCT_SCOPE** Data object for scope pane context.  
  
-   **CCT_RESULT** Data object for result pane context.  
  
-   **CCT_SNAPIN_MANAGER** Data object for snap-in manager context.  
  
-   **CCT_UNINITIALIZED** Data object has an invalid type.  
  
##  \<a name="csnapinitemimpl__command">\</a>  CSnapInItemImpl::Command  
 This method implements the Win32 function [IExtendContextMenu::Command](http://msdn.microsoft.com/library/aa814842).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 *lCommandID*  
 [in] Specifies the command identifier of the menu item.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 [in] Specifies the type of object. It can have one of the following values:  
  
-   **CCT_SCOPE** Data object for scope pane context.  
  
-   **CCT_RESULT** Data object for result pane context.  
  
-   **CCT_SNAPIN_MANAGER** Data object for snap-in manager context.  
  
-   **CCT_UNINITIALIZED** Data object has an invalid type.  
  
##  \<a name="csnapinitemimpl__createpropertypages">\</a>  CSnapInItemImpl::CreatePropertyPages  
 This method implements the Win32 function [IExtendPropertySheet::CreatePropertyPages](http://msdn.microsoft.com/library/aa814846).  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 *lpProvider*  
 [in] Pointer to the **IPropertySheetCallback** interface.  
  
 *handle*  
 [in] Specifies the handle used to route the **MMCN_PROPERTY_CHANGE** notification message to the appropriate data class.  
  
 *pUnk*  
 [in] Pointer to the **IExtendPropertySheet** interface on the object that contains context information about the node.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 [in] Specifies the type of object. It can have one of the following values:  
  
-   **CCT_SCOPE** Data object for scope pane context.  
  
-   **CCT_RESULT** Data object for result pane context.  
  
-   **CCT_SNAPIN_MANAGER** Data object for snap-in manager context.  
  
-   **CCT_UNINITIALIZED** Data object has an invalid type.  
  
##  \<a name="csnapinitemimpl__csnapinitemimpl">\</a>  CSnapInItemImpl::CSnapInItemImpl  
 Constructs a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="csnapinitemimpl__filldata">\</a>  CSnapInItemImpl::FillData  
 This function is called to retrieve information about the item.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 [in] The format (text, rich text, or rich text with OLE items) of the Clipboard.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 [in] A pointer to the stream containing the object data.  
  
### Remarks  
 To properly implement this function, copy the correct information into the stream ( <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>), depending on the Clipboard format indicated by <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
##  \<a name="csnapinitemimpl__getresultviewtype">\</a>  CSnapInItemImpl::GetResultViewType  
 Call this function to retrieve the type of view for the result pane of the snap-in object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 *ppViewType*  
 [out] Pointer to the address of the returned view type.  
  
 *pViewOptions*  
 [out] Pointer to the **MMC_VIEW_OPTIONS** enumeration, which provides the console with options specified by the owning snap-in. This value can be one of the following:  
  
-   **MMC_VIEW_OPTIONS_NOLISTVIEWS** = 0x00000001   Tells the console to refrain from presenting standard list view choices in the **View** menu. Allows the snap-in to display its own custom views only in the result view pane. This is the only option flag defined at this time.  
  
-   **MMC_VIEW_OPTIONS_NONE** = 0   Allows the default view options.  
  
##  \<a name="csnapinitemimpl__getscopepaneinfo">\</a>  CSnapInItemImpl::GetScopePaneInfo  
 Call this function to retrieve the **SCOPEDATAITEM** structure of the snap-in.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 *pScopeDataItem*  
 [out] A pointer to the **SCOPEDATAITEM** structure of the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object.  
  
##  \<a name="csnapinitemimpl__getresultpaneinfo">\</a>  CSnapInItemImpl::GetResultPaneInfo  
 Call this function to retrieve the **RESULTDATAITEM** structure of the snap-in.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 *pResultDataItem*  
 [out] A pointer to the **RESULTDATAITEM** structure of the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object.  
  
##  \<a name="csnapinitemimpl__m_bstrdisplayname">\</a>  CSnapInItemImpl::m_bstrDisplayName  
 Contains the string displayed for the node item.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
##  \<a name="csnapinitemimpl__m_scopedataitem">\</a>  CSnapInItemImpl::m_scopeDataItem  
 The \<xref:Microsoft.CLRAdmin.SCOPEDATAITEM*> structure of the snap-in data object.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
##  \<a name="csnapinitemimpl__m_resultdataitem">\</a>  CSnapInItemImpl::m_resultDataItem  
 The [RESULTDATAITEM](http://msdn.microsoft.com/library/aa815165) structure of the snap-in data object.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
##  \<a name="csnapinitemimpl__notify">\</a>  CSnapInItemImpl::Notify  
 Called when the snap-in object is acted upon by the user.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 [in] Identifies an action taken by a user. The following notifications are possible:  
  
-   **MMCN_ACTIVATE** Sent when a window is being activated and deactivated.  
  
-   **MMCN_ADD_IMAGES** Sent to add images to the result pane.  
  
-   **MMCN_BTN_CLICK** Sent when the user clicks one of the toolbar buttons.  
  
-   **MMCN_CLICK** Sent when a user clicks a mouse button on a list view item.  
  
-   **MMCN_DBLCLICK** Sent when a user double clicks a mouse button on a list view item.  
  
-   **MMCN_DELETE** Sent to inform the snap-in that the object should be deleted.  
  
-   **MMCN_EXPAND** Sent when a folder needs to be expanded or contracted.  
  
-   **MMCN_MINIMIZED** Sent when a window is being minimized or maximized.  
  
-   **MMCN_PROPERTY_CHANGE** Sent to notify a snap-in object that the snap-in object's view is about to change.  
  
-   **MMCN_REMOVE_CHILDREN** Sent when the snap-in must delete the entire subtree it has added below the specified node.  
  
-   **MMCN_RENAME** Sent the first time to query for a rename and the second time to do the rename.  
  
-   **MMCN_SELECT** Sent when an item in the scope or result view pane is selected.  
  
-   **MMCN_SHOW** Sent when a scope item is selected or deselected for the first time.  
  
-   **MMCN_VIEW_CHANGE** Sent when the snap-in can update all views when a change occurs.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 [in] Depends on the notification type.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 [in] Depends on the notification type.  
  
 *pComponentData*  
 [out] A pointer to the object implementing **IComponentData**. This parameter is **NULL** if the notification is not being forwarded from **IComponentData::Notify**.  
  
 *pComponent*  
 [out] A pointer to the object that implements **IComponent**. This parameter is **NULL** if the notification is not being forwarded from **IComponent::Notify**.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 [in] Specifies the type of object. It can have one of the following values:  
  
-   **CCT_SCOPE** Data object for scope pane context.  
  
-   **CCT_RESULT** Data object for result pane context.  
  
-   **CCT_SNAPIN_MANAGER** Data object for snap-in manager context.  
  
-   **CCT_UNINITIALIZED** Data object has an invalid type.  
  
##  \<a name="csnapinitemimpl__querypagesfor">\</a>  CSnapInItemImpl::QueryPagesFor  
 Called to see if the snap-in node supports property pages.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
##  \<a name="csnapinitemimpl__setmenuinsertionflags">\</a>  CSnapInItemImpl::SetMenuInsertionFlags  
 Call this function to modify the menu insertion flags, specified by <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, for the snap-in object.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 *bBeforeInsertion*  
 [in] Nonzero if the function should be called before items are added to the context menu; otherwise 0.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 [in, out] Identifies Microsoft Management Console (MMC)-defined, menu-item insertion points that can be used. This can be a combination of the following flags:  
  
-   **CCM_INSERTIONALLOWED_TOP** Items can be inserted at the top of a context menu.  
  
-   **CCM_INSERTIONALLOWED_NEW** Items can be inserted in the Create New submenu.  
  
-   **CCM_INSERTIONALLOWED_TASK** Items can be inserted in the Task submenu.  
  
-   **CCM_INSERTIONALLOWED_VIEW** Items can be inserted in the toolbar view menu or in the View submenu of the result pane context menu.  
  
### Remarks  
 If you are developing a primary snap-in, you can reset any of the insertion flags as a way of restricting the kind of menu items that a third-party extension can add. For example, the primary snap-in can clear the **CCM_INSERTIONALLOWED_NEW** flag to prevent extensions from adding their own Create New menu items.  
  
 You should not attempt to set bits in <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> that were originally cleared. Future versions of MMC may use bits not currently defined so you should not change bits that are currently not defined.  
  
##  \<a name="csnapinitemimpl__settoolbarbuttoninfo">\</a>  CSnapInItemImpl::SetToolbarButtonInfo  
 Call this function to modify any toolbar button styles, of the snap-in object, before the toolbar is created.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 [in] The ID of the toolbar button to be set.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 [in] The state flags of the button. Can be one or more of the following:  
  
-   <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> The button has the **TBSTYLE_CHECKED** style and is being pressed.  
  
-   <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> The button accepts user input. A button that does not have this state does not accept user input and is grayed.  
  
-   <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> The button is not visible and cannot receive user input.  
  
-   <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> The button is grayed.  
  
-   <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> The button is being pressed.  
  
-   <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> A line break follows the button. The button must also have the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
 *fsType*  
 [in] The state flags of the button. Can be one or more of the following:  
  
-   <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> Creates a standard push button.  
  
-   <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> Creates a button that toggles between the pressed and not-pressed states each time the user clicks it. The button has a different background color when it is in the pressed state.  
  
-   <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> Creates a check button that stays pressed until another button in the group is pressed.  
  
-   <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> Creates a button that stays pressed until another button in the group is pressed.  
  
-   <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> Creates a separator, providing a small gap between button groups. A button that has this style does not receive user input.  
  
##  \<a name="csnapinitemimpl__updatemenustate">\</a>  CSnapInItemImpl::UpdateMenuState  
 Call this function to modify a menu item before it is inserted into the context menu of the snap-in object.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 [in] The ID of the menu item to be set.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 [in] A pointer to the string for the menu item to be updated.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 [in] Specifies the new state flags. This can be a combination of the following flags:  
  
-   **MF_POPUP** Specifies that this is a submenu within the context menu. Menu items, insertion points, and further submenus may be added to this submenu using its **lCommandID** as their **IInsertionPointID**.  
  
-   **MF_BITMAP** and <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> These flags are not permitted and will result in a return value of <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>.  
  
-   **MF_SEPARATOR** Draws a horizontal dividing line. Only **IContextMenuProvider** is allowed to add menu items with **MF_SEPARATOR** set.  
  
-   **MF_CHECKED** Places a check mark next to the menu item.  
  
-   **MF_DISABLED** Disables the menu item so it cannot be selected, but the flag does not gray it.  
  
-   <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> Enables the menu item so it can be selected, restoring it from its grayed state.  
  
-   **MF_GRAYED** Disables the menu item, graying it so it cannot be selected.  
  
-   **MF_MENUBARBREAK** Functions the same as the **MF_MENUBREAK** flag for a menu bar. For a drop-down menu, submenu, or shortcut menu, the new column is separated from the old column by a vertical line.  
  
-   **MF_MENUBREAK** Places the item on a new line (for a menu bar) or in a new column (for a drop-down menu, submenu, or shortcut menu) without separating columns.  
  
-   **MF_UNCHECKED** Does not place a check mark next to the item (default).  
  
 The following groups of flags cannot be used together:  
  
-   **MF_DISABLED**, <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, and **MF_GRAYED**.  
  
-   **MF_MENUBARBREAK** and **MF_MENUBREAK**.  
  
-   **MF_CHECKED** and **MF_UNCHECKED**.  
  
##  \<a name="csnapinitemimpl__updatetoolbarbutton">\</a>  CSnapInItemImpl::UpdateToolbarButton  
 Call this function to modify a toolbar button, of the snap-in object, before it is displayed.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 Specifies the button ID of the toolbar button to be updated.  
  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 Specifies a toolbar button state. If this state is to be set, return **TRUE**. This can be a combination of the following flags:  
  
-   **ENABLED** The button accepts user input. A button that does not have this state does not accept user input and is grayed.  
  
-   **CHECKED** The button has the **CHECKED** style and is being pressed.  
  
-   **HIDDEN** The button is not visible and cannot receive user input.  
  
-   **INDETERMINATE** The button is grayed.  
  
-   **BUTTONPRESSED** The button is being pressed.  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)