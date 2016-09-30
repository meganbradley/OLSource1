---
title: "CUserToolsManager Class"
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
  - "CUserToolsManager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CUserToolsManager class"
ms.assetid: bdfa37ae-efca-4616-abb5-9d0dcd2d335b
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CUserToolsManager Class
Maintains the collection of [CMFCUserTool](../vs140/cusertool-class.md) objects in an application. A user tool is a menu item that runs an external application. The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object enables the user or developer to add new user tools to the application. It supports the execution of the commands associated with user tools, and it also saves information about user tools in the Windows registry.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CUserToolsManager::CMFCUserToolsManager](#cusertoolsmanager__cusertoolsmanager)|Constructs a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CUserToolsManager::CreateNewTool](#cusertoolsmanager__createnewtool)|Creates a new user tool.|  
|[CUserToolsManager::FindTool](#cusertoolsmanager__findtool)|Returns the pointer to the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object that is associated with a specified command ID.|  
|[CUserToolsManager::GetArgumentsMenuID](#cusertoolsmanager__getargumentsmenuid)|Returns the resource ID that is associated with the **Arguments** menu on the **Tools** tab of the **Customize** dialog box.|  
|[CUserToolsManager::GetDefExt](#cusertoolsmanager__getdefext)|Returns the default extension that the **File Open** dialog box ( [CFileDialog](../vs140/cfiledialog-class.md#cfiledialog__cfiledialog)) uses in the **Command** field on the **Tools** tab of the **Customize** dialog box.|  
|[CUserToolsManager::GetFilter](#cusertoolsmanager__getfilter)|Returns the file filter that the **File Open** dialog box ( [CFileDialog](../vs140/cfiledialog-class.md)) uses in the **Command** field on the **Tools** tab of the **Customize** dialog box.|  
|[CUserToolsManager::GetInitialDirMenuID](#cusertoolsmanager__getinitialdirmenuid)|Returns the resource ID that is associated with the **Initial directory** menu on the **Tools** tab of the **Customize** dialog box.|  
|[CUserToolsManager::GetMaxTools](#cusertoolsmanager__getmaxtools)|Returns the maximum number of user tools that can be allocated in the application.|  
|[CUserToolsManager::GetToolsEntryCmd](#cusertoolsmanager__gettoolsentrycmd)|Returns the command ID of the menu item placeholder for user tools.|  
|[CUserToolsManager::GetUserTools](#cusertoolsmanager__getusertools)|Returns a reference to the list of user tools.|  
|[CUserToolsManager::InvokeTool](#cusertoolsmanager__invoketool)|Executes an application associated with the user tool that has a specified command ID.|  
|[CUserToolsManager::IsUserToolCmd](#cusertoolsmanager__isusertoolcmd)|Determines whether a command ID is associated with a user tool.|  
|[CUserToolsManager::LoadState](#cusertoolsmanager__loadstate)|Loads information about user tools from the Windows registry.|  
|[CUserToolsManager::MoveToolDown](#cusertoolsmanager__movetooldown)|Moves the specified user tool down in the list of user tools.|  
|[CUserToolsManager::MoveToolUp](#cusertoolsmanager__movetoolup)|Moves the specified user tool up in the list of user tools.|  
|[CUserToolsManager::RemoveTool](#cusertoolsmanager__removetool)|Removes the specified user tool from the application.|  
|[CUserToolsManager::SaveState](#cusertoolsmanager__savestate)|Stores information about user tools in the Windows registry.|  
|[CUserToolsManager::SetDefExt](#cusertoolsmanager__setdefext)|Specifies the default extension that the **File Open** dialog box ( [CFileDialog](../vs140/cfiledialog-class.md)) uses in the **Command** field on the **Tools** tab of the **Customize** dialog box.|  
|[CUserToolsManager::SetFilter](#cusertoolsmanager__setfilter)|Specifies the file filter that the **File Open** dialog box ( [CFileDialog](../vs140/cfiledialog-class.md)) uses in the **Command** field on the **Tools** tab of the **Customize** dialog box.|  
  
## Remarks  
 To incorporate user tools into your application, you must:  
  
 1. Reserve a menu item and an associated command ID for a user tool menu entry.  
  
 2. Reserve a sequential command ID for each user tool that a user can define in your application.  
  
 3. Call the [CWinAppEx::EnableUserTool](../vs140/cwinappex-class.md#cwinappex__enableusertools) method and supply the following parameters: menu command ID, first user tool command ID, and last user tool command ID.  
  
 There should be only one global <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object per application.  
  
 For an example of user tools, see the VisualStudioDemo sample project.  
  
## Example  
 The following example demonstrates how to retrieve a reference to a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object and how to create new user tools. This code snippet is part of the [Visual Studio Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#38](../vs140/codesnippet/CPP/cusertoolsmanager-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CUserToolsManager](../vs140/cusertoolsmanager-class.md)  
  
## Requirements  
 **Header:** afxusertoolsmanager.h  
  
##  \<a name="cusertoolsmanager__createnewtool">\</a>  CUserToolsManager::CreateNewTool  
 Creates a new user tool.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the newly created user tool, or <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> if the number of user tools has exceeded the maximum. The returned type is the same as the type that is passed to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> as the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> parameter.  
  
### Remarks  
 This method finds the first available menu command ID in the range that is supplied in the call to [CWinAppEx::EnableUserTools](../vs140/cwinappex-class.md#cwinappex__enableusertools) and assigns the user tool this ID.  
  
 The method fails if the number of tools has reached the maximum. This occurs when all command IDs within the range are assigned to user tools. You can retrieve the maximum number of tools by calling [GetMaxTools](#cusertoolsmanager__getmaxtools). You can get access to the tools list by calling the [GetUserTools](#cusertoolsmanager__getusertools) method.  
  
##  \<a name="cusertoolsmanager__cusertoolsmanager">\</a>  CUserToolsManager::CUserToolsManager  
 Constructs a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. Each application must have at most one user tools manager.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in]  <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 An unsigned integer that the framework uses as a placeholder for the command ID of the user tools menu.  
  
 [in]  <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The command ID for the first user tool command.  
  
 [in]  <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 The command ID for the last user tool command.  
  
 [in]  <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The class that [CUserToolsManager::CreateNewTool](#cusertoolsmanager__createnewtool) creates. By using this class, you can use a derived type of [CUserTool](../vs140/cusertool-class.md) instead of the default implementation.  
  
 [in]  <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 The menu resource ID of the arguments popup menu.  
  
 [in]  <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 The menu resource ID of the initial directory popup menu.  
  
### Remarks  
 Do not call this constructor. Instead, call [CWinAppEx::EnableUserTools](../vs140/cwinappex-class.md#cwinappex__enableusertools) to enable user tools, and call [CWinAppEx::GetUserToolsManager](../vs140/cwinappex-class.md#cwinappex__getusertoolsmanager) to obtain a pointer to the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>. For more information, see [User Defined Tools](../vs140/user-defined-tools.md).  
  
##  \<a name="cusertoolsmanager__findtool">\</a>  CUserToolsManager::FindTool  
 Returns the pointer to the [CUserTool](../vs140/cusertool-class.md) object that is associated with a specified command ID.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in]  <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 A menu command identifier.  
  
### Return Value  
 A pointer to a [CUserTool](../vs140/cusertool-class.md) or <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>-derived object if success; otherwise <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
### Remarks  
 When <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is successful, the returned type is the same as the type of the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> parameter to [CWinAppEx::EnableUserTools](../vs140/cwinappex-class.md#cwinappex__enableusertools).  
  
##  \<a name="cusertoolsmanager__getargumentsmenuid">\</a>  CUserToolsManager::GetArgumentsMenuID  
 Returns the resource ID that is associated with the **Arguments** menu on the **Tools** tab of the **Customize** dialog box.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The identifier of a menu resource.  
  
### Remarks  
 The <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> parameter of [CWinAppEx::EnableUserTools](../vs140/cwinappex-class.md#cwinappex__enableusertools) specifies the ID of the resource.  
  
##  \<a name="cusertoolsmanager__getdefext">\</a>  CUserToolsManager::GetDefExt  
 Returns the default extension that the **File Open** dialog box ( [CFileDialog](../vs140/cfiledialog-class.md#cfiledialog__cfiledialog)) uses in the **Command** field on the **Tools** tab of the **Customize** dialog box.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 A reference to the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object that contains the extension.  
  
##  \<a name="cusertoolsmanager__getfilter">\</a>  CUserToolsManager::GetFilter  
 Returns the file filter that the **File Open** dialog box ( [CFileDialog](../vs140/cfiledialog-class.md)) uses in the **Command** field on the **Tools** tab of the **Customize** dialog box.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A reference to the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object that contains the filter.  
  
##  \<a name="cusertoolsmanager__getinitialdirmenuid">\</a>  CUserToolsManager::GetInitialDirMenuID  
 Returns the resource ID that is associated with the **Initial directory** menu on the **Tools** tab of the **Customize** dialog box.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 A menu resource identifier.  
  
### Remarks  
 The returned ID is specified in the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> parameter of [CWinAppEx::EnableUserTools](../vs140/cwinappex-class.md#cwinappex__enableusertools).  
  
##  \<a name="cusertoolsmanager__getmaxtools">\</a>  CUserToolsManager::GetMaxTools  
 Returns the maximum number of user tools that can be allocated in the application.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 The maximum number of user tools that can be allocated.  
  
### Remarks  
 Call this method to retrieve the maximum number of tools that can be allocated in the application. This number is the number of IDs in the range from the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> through the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> parameters that you pass to [CWinAppEx::EnableUserTools](../vs140/cwinappex-class.md#cwinappex__enableusertools).  
  
##  \<a name="cusertoolsmanager__gettoolsentrycmd">\</a>  CUserToolsManager::GetToolsEntryCmd  
 Returns the command ID of the menu item placeholder for user tools.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 The command ID of the placeholder.  
  
### Remarks  
 To enable user tools, you call [CWinAppEx::EnableUserTools](../vs140/cwinappex-class.md#cwinappex__enableusertools). The <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> parameter specifies the command ID of the tools entry command. This method returns the tools entry command ID. Wherever that ID is used in a menu, it is replaced by the list of user tools when the menu appears.  
  
##  \<a name="cusertoolsmanager__getusertools">\</a>  CUserToolsManager::GetUserTools  
 Returns a reference to the list of user tools.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 A const reference to a [CObList](../vs140/coblist-class.md) object that contains a list of user tools.  
  
### Remarks  
 Call this method to retrieve a list of user tools that the [CUserToolsManager](../vs140/cusertoolsmanager-class.md) object maintains. Each user tool is represented by an object of type [CUserTool](../vs140/cusertool-class.md) or a type derived from <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>. The type is specified by the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> parameter when you call [CWinAppEx::EnableUserTools](../vs140/cwinappex-class.md#cwinappex__enableusertools) to enable user tools.  
  
##  \<a name="cusertoolsmanager__invoketool">\</a>  CUserToolsManager::InvokeTool  
 Executes an application associated with the user tool that has a specified command ID.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in]  <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The menu command ID associated with the user tool.  
  
### Return Value  
 Nonzero if the command associated with user tool was executed successfully; otherwise 0.  
  
### Remarks  
 Call this method to execute an application associated with the user tool that has the command ID specified by <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
##  \<a name="cusertoolsmanager__isusertoolcmd">\</a>  CUserToolsManager::IsUserToolCmd  
 Determines whether a command ID is associated with a user tool.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in]  <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 A command ID of the menu item.  
  
### Return Value  
 Nonzero if a given command ID is associated with a user tool; otherwise 0.  
  
### Remarks  
 This method checks whether the given command ID is in the command ID range. You specify the range when you call [CWinAppEx::EnableUserTools](../vs140/cwinappex-class.md#cwinappex__enableusertools) to enable user tools.  
  
##  \<a name="cusertoolsmanager__loadstate">\</a>  CUserToolsManager::LoadState  
 Loads information about user tools from the Windows registry.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [in]  <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 The path of the Windows registry key.  
  
### Return Value  
 Nonzero if the state was loaded successfully; otherwise 0.  
  
### Remarks  
 This method loads the state of the [CUserToolsManager](../vs140/cusertoolsmanager-class.md) object from the Windows registry.  
  
 Usually, you do not call this method directly. [CWinAppEx::LoadState](../vs140/cwinappex-class.md#cwinappex__loadstate) calls it as part of workspace initialization process.  
  
##  \<a name="cusertoolsmanager__movetooldown">\</a>  CUserToolsManager::MoveToolDown  
 Moves the specified user tool down in the list of user tools.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 [in]  <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 Specifies the user tool to move.  
  
### Return Value  
 Nonzero if the user tool was moved down successfully; otherwise 0.  
  
### Remarks  
 The method fails if the tool that the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> specifies is not in the internal list or if the tool is last in the list.  
  
##  \<a name="cusertoolsmanager__movetoolup">\</a>  CUserToolsManager::MoveToolUp  
 Moves the specified user tool up in the list of user tools.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 [in]  <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 Specifies the user tool to move.  
  
### Return Value  
 Nonzero if the user tool was moved up successfully; otherwise 0.  
  
### Remarks  
 The method fails if the tool that the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> parameter specifies is not in the internal list or if the tool is the first tool item in the list.  
  
##  \<a name="cusertoolsmanager__removetool">\</a>  CUserToolsManager::RemoveTool  
 Removes the specified user tool from the application.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 [in, out]  <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 A pointer to a user tool to be removed.  
  
### Return Value  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> if the tool is successfully removed. Otherwise, <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>.  
  
### Remarks  
 If the tool is successfully removed, this method deletes <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>.  
  
##  \<a name="cusertoolsmanager__savestate">\</a>  CUserToolsManager::SaveState  
 Stores information about user tools in the Windows registry.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 [in]  <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 A path to the Windows registry key.  
  
### Return Value  
 Nonzero if the state was saved successfully; otherwise 0.  
  
### Remarks  
 The method stores the current state of the [CUserToolsManager](../vs140/cusertoolsmanager-class.md) object in the Windows registry.  
  
 Usually, you do not need to call this method directly, [CWinAppEx::SaveState](../vs140/cwinappex-class.md#cwinappex__savestate) calls it automatically as a part of the workspace serialization process of the application.  
  
##  \<a name="cusertoolsmanager__setdefext">\</a>  CUserToolsManager::SetDefExt  
 Specifies the default extension that the **File Open** dialog box ( [CFileDialog](../vs140/cfiledialog-class.md)) uses in the **Command** field on the **Tools** tab of the **Customize** dialog box.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 [in]  <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 A text string that contains the default file name extension.  
  
### Remarks  
 Call this method to specify a default file name extension in the **File Open** dialog box, which is displayed when the user selects an application to associate with the user tool. The default is "exe".  
  
##  \<a name="cusertoolsmanager__setfilter">\</a>  CUserToolsManager::SetFilter  
 Specifies the file filter that the **File Open** dialog box ( [CFileDialog](../vs140/cfiledialog-class.md)) uses in the **Command** field on the **Tools** tab of the **Customize** dialog box.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 [in]  <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 Specifies the filter.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CWinAppEx](../vs140/cwinappex-class.md)   
 [CMFCUserTool](../vs140/cusertool-class.md)