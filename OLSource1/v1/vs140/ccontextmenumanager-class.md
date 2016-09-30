---
title: "CContextMenuManager Class"
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
  - "CContextMenuManager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CContextMenuManager class"
ms.assetid: 1de20640-243c-47e1-85de-1baa4153bc83
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CContextMenuManager Class
The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object manages shortcut menus, also known as context menus.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CContextMenuManager::CContextMenuManager](#ccontextmenumanager__ccontextmenumanager)|Constructs a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CContextMenuManager::AddMenu](#ccontextmenumanager__addmenu)|Adds a new shortcut menu.|  
|[CContextMenuManager::GetMenuById](#ccontextmenumanager__getmenubyid)|Returns a handle to the menu associated with the provided resource ID.|  
|[CContextMenuManager::GetMenuByName](#ccontextmenumanager__getmenubyname)|Returns a handle to the menu that matches the provided menu name.|  
|[CContextMenuManager::GetMenuNames](#ccontextmenumanager__getmenunames)|Returns a list of menu names.|  
|[CContextMenuManager::LoadState](#ccontextmenumanager__loadstate)|Loads shortcut menus stored in the Windows registry.|  
|[CContextMenuManager::ResetState](#ccontextmenumanager__resetstate)|Clears the shortcut menus from the context menu manager.|  
|[CContextMenuManager::SaveState](#ccontextmenumanager__savestate)|Saves shortcut menus to the Windows registry.|  
|[CContextMenuManager::SetDontCloseActiveMenu](#ccontextmenumanager__setdontcloseactivemenu)|Controls whether the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> closes the active shortcut menu when it shows a new shortcut menu.|  
|[CContextMenuManager::ShowPopupMenu](#ccontextmenumanager__showpopupmenu)|Displays the specified shortcut menu.|  
|[CContextMenuManager::TrackPopupMenu](#ccontextmenumanager__trackpopupmenu)|Displays the specified shortcut menu. Returns the index of the selected menu command.|  
  
## Remarks  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> manages shortcut menus and makes sure that they have a consistent appearance.  
  
 You should not create a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object manually. The framework of your application creates the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object. However, you should call [CWinAppEx::InitContextMenuManager](../vs140/cwinappex-class.md#cwinappex__initcontextmenumanager) when your application is initialized. After initializing the context manager, use the method [CWinAppEx::GetContextMenuManager](../vs140/cwinappex-class.md#cwinappex__getcontextmenumanager) to obtain a pointer to the context manager for your application.  
  
 You can create shortcut menus at runtime by calling <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. If you want to show the menu without first receiving user input, call <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is used when you want to create a menu and wait for user input. <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> returns the index of the selected command or 0 if the user exited without selecting anything.  
  
 The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> can also save and load its state to the Windows registry.  
  
## Example  
 The following example demonstrates how to add a menu to a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object, and how not to close the active pop-up menu when the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object displays a new pop-up menu. This code snippet is part of the [Custom Pages sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_CustomPages#4](../vs140/codesnippet/CPP/ccontextmenumanager-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CContextMenuManager](../vs140/ccontextmenumanager-class.md)  
  
## Requirements  
 **Header:** afxcontextmenumanager.h  
  
##  \<a name="ccontextmenumanager__addmenu">\</a>  CContextMenuManager::AddMenu  
 Adds a new shortcut menu to the [CContextMenuManager](../vs140/ccontextmenumanager-class.md).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 A resource ID for a string that contains the name for the new menu.  
  
 [in] <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 The menu resource ID.  
  
 [in] <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 A string that contains the name for the new menu.  
  
### Return Value  
 Nonzero if the method was successful; 0 if the method fails.  
  
### Remarks  
 This method fails if <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is invalid or if another menu with the same name already is in the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
##  \<a name="ccontextmenumanager__ccontextmenumanager">\</a>  CContextMenuManager::CContextMenuManager  
 Constructs a [CContextMenuManager](../vs140/ccontextmenumanager-class.md) object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 In most cases, you should not create a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> manually. The framework of your application creates the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object. You should call [CWinAppEx::InitContextMenuManager](../vs140/cwinappex-class.md#cwinappex__initcontextmenumanager) during the initialization of your application. To get a pointer to the context manager, call [CWinAppEx::GetContextMenuManager](../vs140/cwinappex-class.md#cwinappex__getcontextmenumanager).  
  
##  \<a name="ccontextmenumanager__getmenubyid">\</a>  CContextMenuManager::GetMenuById  
 Returns a handle to the menu associated with a given resource ID.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 The resource ID for the menu.  
  
### Return Value  
 A handle to the associated menu or <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> if the menu is not found.  
  
##  \<a name="ccontextmenumanager__getmenubyname">\</a>  CContextMenuManager::GetMenuByName  
 Returns a handle to a specific menu.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 A string that contains the name of the menu to retrieve.  
  
 [out] <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>. This parameter contains the resource ID of the specified menu, if found.  
  
### Return Value  
 A handle to the menu that matches the name that was specified by <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> if there is no menu called <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
### Remarks  
 If this method finds a menu that matches <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> stores the menu resource ID in the parameter <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
##  \<a name="ccontextmenumanager__getmenunames">\</a>  CContextMenuManager::GetMenuNames  
 Returns the list of menu names added to the [CContextMenuManager](../vs140/ccontextmenumanager-class.md).  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 A reference to a [CStringList](../vs140/cstringlist-class.md) parameter. This method writes the list of menu names to this parameter.  
  
##  \<a name="ccontextmenumanager__loadstate">\</a>  CContextMenuManager::LoadState  
 Loads information associated with the [CContextMenuManager Class](../vs140/ccontextmenumanager-class.md) from the Windows registry.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 A string that contains the relative path of a registry key.  
  
### Return Value  
 Nonzero if the method is successful; otherwise 0.  
  
### Remarks  
 The <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> parameter is not the absolute path for a registry entry. It is a relative path that is added to the end of the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](../vs140/cwinappex-class.md#cwinappex__getregistrybase) and [CWinAppEx::SetRegistryBase](../vs140/cwinappex-class.md#cwinappex__setregistrybase) respectively.  
  
 Use the method [CContextMenuManager::SaveState](#ccontextmenumanager__savestate) to save the shortcut menus to the registry.  
  
##  \<a name="ccontextmenumanager__resetstate">\</a>  CContextMenuManager::ResetState  
 Clears all items from the shortcut menus associated with the [CContextMenuManager Class](../vs140/ccontextmenumanager-class.md).  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> if the method is successful; <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> if a failure occurs.  
  
### Remarks  
 This method clears the pop-up menus and removes them from the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  
  
##  \<a name="ccontextmenumanager__savestate">\</a>  CContextMenuManager::SaveState  
 Saves information associated with the [CContextMenuManager Class](../vs140/ccontextmenumanager-class.md) to the Windows registry.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 A string that contains the relative path of a registry key.  
  
### Return Value  
 Nonzero if the method is successful; otherwise 0.  
  
### Remarks  
 The <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> parameter is not the absolute path for a registry entry. It is a relative path that is added to the end of the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](../vs140/cwinappex-class.md#cwinappex__getregistrybase) and [CWinAppEx::SetRegistryBase](../vs140/cwinappex-class.md#cwinappex__setregistrybase) respectively.  
  
 Use the method [CContextMenuManager::LoadState](#ccontextmenumanager__loadstate) to load the shortcut menus from the registry.  
  
##  \<a name="ccontextmenumanager__setdontcloseactivemenu">\</a>  CContextMenuManager::SetDontCloseActiveMenu  
 Controls whether the [CContextMenuManager](../vs140/ccontextmenumanager-class.md) closes the active pop-up menu when it displays a new pop-up menu.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 A Boolean parameter that controls whether to close the active pop-up menu. A value of <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> indicates the active pop-up menu is not closed. <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> indicates that the active pop-up menu is closed.  
  
### Remarks  
 By default, the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> closes the active pop-up menu.  
  
##  \<a name="ccontextmenumanager__showpopupmenu">\</a>  CContextMenuManager::ShowPopupMenu  
 Displays the specified shortcut menu.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 The resource ID of the menu that this method will display.  
  
 [in] <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 The horizontal offset for the shortcut menu in client coordinates.  
  
 [in] <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 The vertical offset for the shortcut menu in client coordinates  
  
 [in] <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 A pointer to the parent window of the shortcut menu.  
  
 [in] <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates how messages are routed. If <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, standard MFC routing is used. Otherwise, <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> receives the messages.  
  
 [in] <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 The handle of the menu that this method will display.  
  
 [in] <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the menu will be automatically destroyed.  
  
 [in] <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates how the menu items are aligned. If <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>, the menu is right-aligned for right-to-left reading order.  
  
### Return Value  
 The first method overload returns nonzero if the method shows the menu successfully; otherwise 0. The second method overload returns a pointer to [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md) if the shortcut menu displays correctly; otherwise <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method resembles the method [CContextMenuManager::TrackPopupMenu](#ccontextmenumanager__trackpopupmenu) in that both methods display a shortcut menu. However, <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> returns the index of the selected menu command.  
  
 If the parameter <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>, you must manually call the inherited <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> method to release memory resources. The default implementation of <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> does not use the parameter <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>. It is provided for future use or for custom classes derived from the [CContextMenuManager Class](../vs140/ccontextmenumanager-class.md).  
  
##  \<a name="ccontextmenumanager__trackpopupmenu">\</a>  CContextMenuManager::TrackPopupMenu  
 Displays the specified shortcut menu and returns the index of the selected shortcut menu command.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 The handle of the shortcut menu that this method displays.  
  
 [in] <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 The horizontal offset for the shortcut menu in client coordinates.  
  
 [in] <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 The vertical offset for the shortcut menu in client coordinates.  
  
 [in] <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 A pointer to the parent window of the shortcut menu.  
  
 [in] <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates how menu items are aligned. If <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>, the menu is right-aligned for right-to-left reading order. If <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>, the menu is left-aligned for left-to-right reading order.  
  
### Return Value  
 The menu command ID of the command that the user chooses; 0 if the user closes the shortcut menu without selecting a menu command.  
  
### Remarks  
 This method functions as a modal call to display a shortcut menu. The application will not continue to the following line in code until the user either closes the shortcut menu or selects a command. An alternative method that you can use to display a shortcut menu is [CContextMenuManager::ShowPopupMenu](#ccontextmenumanager__showpopupmenu). That method is not a modal call and will not return the ID of the selected command.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [CWinAppEx::InitContextMenuManager](../vs140/cwinappex-class.md#cwinappex__initcontextmenumanager)