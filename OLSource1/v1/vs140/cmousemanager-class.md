---
title: "CMouseManager Class"
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
  - "CMouseManager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMouseManager class"
ms.assetid: a4d05017-4e44-4a40-8b57-4ece0de20481
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMouseManager Class
Allows a user to associate different commands with a particular [CView](../vs140/cview-class.md) object when the user double-clicks inside that view.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMouseManager::AddView](#cmousemanager__addview)|Adds a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object to the **Customization** dialog box. The **Customization** dialog box enables the user to associate a double-click with a command for each of the listed views.|  
|[CMouseManager::GetViewDblClickCommand](#cmousemanager__getviewdblclickcommand)|Returns the command that is executed when the user double-clicks inside the provided view.|  
|[CMouseManager::GetViewIconId](#cmousemanager__getviewiconid)|Returns the icon associated with the provided view ID.|  
|[CMouseManager::GetViewIdByName](#cmousemanager__getviewidbyname)|Returns the view ID associated with the provided view name.|  
|[CMouseManager::GetViewNames](#cmousemanager__getviewnames)|Retrieves a list of all added view names.|  
|[CMouseManager::LoadState](#cmousemanager__loadstate)|Loads the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> state from the Windows registry.|  
|[CMouseManager::SaveState](#cmousemanager__savestate)|Writes the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> state to the Windows registry.|  
|[CMouseManager::SetCommandForDblClick](#cmousemanager__setcommandfordblclk)|Associates the provided command and the provided view.|  
  
## Remarks  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> class maintains a collection of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> objects. Each view is identified by a name and by an ID. These views are shown in the **Customization** dialog box. The user can change the command that is associated with any view through the **Customization** dialog box. The associated command is executed when the user double-clicks in that view. To support this from a coding perspective, you must process the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> message and call the [CWinAppEx::OnViewDoubleClick](../vs140/cwinappex-class.md#cwinappex__onviewdoubleclick) function in the code for that <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object..  
  
 You should not create a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object manually. It will be created by the framework of your application. It will also be destroyed automatically when the user exits the application. To get a pointer to the mouse manager for your application, call [CWinAppEx::GetMouseManager](../vs140/cwinappex-class.md#cwinappex__getmousemanager).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMouseManager](../vs140/cmousemanager-class.md)  
  
## Requirements  
 **Header:** afxmousemanager.h  
  
##  \<a name="cmousemanager__addview">\</a>  CMouseManager::AddView  
 Registers a [CView](../vs140/cview-class.md) object with the [CMouseManager Class](../vs140/cmousemanager-class.md) to support custom mouse behavior.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 A view ID.  
  
 [in] <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 A resource string ID that references the view name.  
  
 [in] <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 A view icon ID.  
  
 [in] <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 A view ID.  
  
 [in] <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 A view name.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 In order to support custom mouse behavior, a view must be registered with the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object. Any object derived from the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> class can be registered with the mouse manager. The string and icon associated with a view are displayed in the **Mouse** tab of the **Customize** dialog box.  
  
 It is the responsibility of the programmer to create and maintain view IDs such as <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
 For more information about how to provide custom mouse behavior, see [Keyboard and Mouse Customization](../vs140/keyboard-and-mouse-customization.md).  
  
### Example  
 The following example demonstrates how to retrieve a pointer to a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object by using the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> method and the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> method in the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> class. This code snippet is part of the [State Collection sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_StateCollection#4](../vs140/codesnippet/CPP/cmousemanager-class_1.cpp)]  
  
##  \<a name="cmousemanager__getviewdblclickcommand">\</a>  CMouseManager::GetViewDblClickCommand  
 Returns the command that is executed when the user double-clicks inside the provided view.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The view ID.  
  
### Return Value  
 The command identifier if the view is associated with a command; otherwise 0.  
  
##  \<a name="cmousemanager__getviewiconid">\</a>  CMouseManager::GetViewIconId  
 Retrieves the icon associated with a view ID.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 The view ID.  
  
### Return Value  
 An icon resource identifier if successful; otherwise 0.  
  
### Remarks  
 This method will fail if the view is not first registered by using [CMouseManager::AddView](#cmousemanager__addview).  
  
##  \<a name="cmousemanager__getviewidbyname">\</a>  CMouseManager::GetViewIdByName  
 Retrieves the view ID associated with a view name.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The view name.  
  
### Return Value  
 A view ID if successful; otherwise 0.  
  
### Remarks  
 This method searches through views registered by using [CMouseManager::AddView](#cmousemanager__addview).  
  
##  \<a name="cmousemanager__getviewnames">\</a>  CMouseManager::GetViewNames  
 Retrieves a list of all the registered view names.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 A reference to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object.  
  
### Remarks  
 This method fills the parameter <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> with the names of all the views registered by using [CMouseManager::AddView](#cmousemanager__addview).  
  
##  \<a name="cmousemanager__loadstate">\</a>  CMouseManager::LoadState  
 Loads the state of the [CMouseManager Class](../vs140/cmousemanager-class.md) from the registry.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 A path of a registry key.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The state information loaded from the registry includes the registered views, view identifiers, and the associated commands. If the parameter <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, this function loads the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> data from the default registry location controlled by the [CWinAppEx Class](../vs140/cwinappex-class.md).  
  
 In most cases, you do not have to call this function directly. It is called as a part of the workspace initialization process. For more information about the workspace initialization process, see [CWinAppEx::LoadState](../vs140/cwinappex-class.md#cwinappex__loadstate).  
  
##  \<a name="cmousemanager__savestate">\</a>  CMouseManager::SaveState  
 Writes the state of the [CMouseManager Class](../vs140/cmousemanager-class.md) to the registry.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 A path of a registry key.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The state information written to the registry includes all registered views, view identifiers, and the associated commands. If the parameter <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, this function writes the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> data to the default registry location controlled by the [CWinAppEx Class](../vs140/cwinappex-class.md).  
  
 In most cases, you do not have to call this function directly. It is called as a part of the workspace serialization process. For more information about the workspace serialization process, see [CWinAppEx::SaveState](../vs140/cwinappex-class.md#cwinappex__savestate).  
  
##  \<a name="cmousemanager__setcommandfordblclk">\</a>  CMouseManager::SetCommandForDblClk  
 Associates a custom command with a view that is first registered with the mouse manager.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 The view identifier.  
  
 [in] <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 The command identifier.  
  
### Remarks  
 In order to associate a custom command with a view, you must first register the view by using [CMouseManager::AddView](#cmousemanager__addview). The <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> method requires a view identifier as an input parameter. Once you register a view, you can call <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> with the same view identifier input parameter that you supplied to <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>. Thereafter, when the user double-clicks the mouse in the registered view, the application will execute the command indicated by <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> To support the custom mouse behavior, you will also need to customize the view registered with the mouse manager. For more information about custom mouse behavior, see [Keyboard and Mouse Customization](../vs140/keyboard-and-mouse-customization.md).  
  
 If <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> is set to 0, the specified view is no longer associated with a command.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Keyboard and Mouse Customization](../vs140/keyboard-and-mouse-customization.md)