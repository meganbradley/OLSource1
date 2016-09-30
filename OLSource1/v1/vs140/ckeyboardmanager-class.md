---
title: "CKeyboardManager Class"
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
  - "CKeyboardManager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CKeyboardManager class"
ms.assetid: 4809ece6-89df-4479-8b53-9bf476ee107b
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CKeyboardManager Class
Manages shortcut key tables for the main frame window and child frame windows.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|||  
|-|-|  
|Name|Description|  
|[CKeyboardManager::CKeyboardManager](#ckeyboardmanager__ckeyboardmanager)|Constructs a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|||  
|-|-|  
|Name|Description|  
|[CKeyboardManager::CleanUp](#ckeyboardmanager__cleanup)|Clears the shortcut key tables.|  
|[CKeyboardManager::FindDefaultAccelerator](#ckeyboardmanager__finddefaultaccelerator)|Retrieves the default shortcut key for the specified command and window.|  
|[CKeyboardManager::IsKeyHandled](#ckeyboardmanager__iskeyhandled)|Determines whether a key is handled by the accelerator table.|  
|[CKeyboardManager::IsKeyPrintable](#ckeyboardmanager__iskeyprintable)|Indicates whether a character is printable.|  
|[CKeyboardManager::IsShowAllAccelerators](#ckeyboardmanager__isshowallaccelerators)|Indicates whether menus show all shortcut keys for a command or only the default shortcut key.|  
|[CKeyboardManager::LoadState](#ckeyboardmanager__loadstate)|Loads the shortcut key tables from the Windows registry.|  
|[CKeyboardManager::ResetAll](#ckeyboardmanager__resetall)|Reloads the shortcut key tables from the application resource.|  
|[CKeyboardManager::SaveState](#ckeyboardmanager__savestate)|Saves the shortcut key tables to the Windows registry.|  
|[CKeyboardManager::ShowAllAccelerators](#ckeyboardmanager__showallaccelerators)|Specifies whether the framework displays all the shortcut keys for all commands, or a single shortcut key for each command. This method does not affect commands that have only one associated shortcut key.|  
|[CKeyboardManager::TranslateCharToUpper](#ckeyboardmanager__translatechartoupper)|Converts a character to its upper register.|  
|[CKeyboardManager::UpdateAccelTable](#ckeyboardmanager__updateacceltable)|Updates a shortcut key table with a new shortcut key table.|  
  
## Remarks  
 The members of this class enable you to save and load shortcut key tables to the Windows registry, use a template to update the short cut key tables, and find the default shortcut key for a command in a frame window. In addition, the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object lets you control how shortcut keys are displayed to the user.  
  
 You should not create a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object manually. It will be created automatically by the framework of your application. However, you should call [CWinAppEx::InitKeyboardManager](../vs140/cwinappex-class.md#cwinappex__initkeyboardmanager) during the initialization process of your application. To get a pointer to the keyboard manager for your application, call [CWinAppEx::GetKeyboardManager](../vs140/cwinappex-class.md#cwinappex__getkeyboardmanager).  
  
## Example  
 The following example demonstrates how to retrieve a pointer to a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object from a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> class, and how to show all the shortcut keys associated with menu commands. This code snippet is part of the [Custom Pages sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_CustomPages#5](../vs140/codesnippet/CPP/ckeyboardmanager-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CKeyboardManager](../vs140/ckeyboardmanager-class.md)  
  
## Requirements  
 **Header:** afxkeyboardmanager.h  
  
##  \<a name="ckeyboardmanager__ckeyboardmanager">\</a>  CKeyboardManager::CKeyboardManager  
 Constructs a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 In most cases, you do not have to create a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> directly. By default, the framework creates one for you. To get a pointer to the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, call [CWinAppEx::GetKeyboardManager](../vs140/cwinappex-class.md#cwinappex__getkeyboardmanager). If you do create one manually, you must initialize it with the method [CWinAppEx::InitKeyboardManager](../vs140/cwinappex-class.md#cwinappex__initkeyboardmanager).  
  
##  \<a name="ckeyboardmanager__cleanup">\</a>  CKeyboardManager::CleanUp  
 Frees the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> resources and clears all shortcut key mappings.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 For more information about shortcut keys, see [Keyboard and Mouse Customization](../vs140/keyboard-and-mouse-customization.md).  
  
 You do not have to call this function when your application exits because the framework calls it automatically during application exit.  
  
##  \<a name="ckeyboardmanager__finddefaultaccelerator">\</a>  CKeyboardManager::FindDefaultAccelerator  
 Retrieves the default shortcut key for the specified command and window.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The command ID.  
  
 [out] <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object.  
  
 [in] <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 A pointer to a frame window.  
  
 [in] <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 Specifies whether the frame window is the default frame window.  
  
### Return Value  
 Nonzero if the shortcut is found; otherwise 0.  
  
### Remarks  
 This method looks up the command specified by <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> and retrieves the default shortcut key. Then the method takes the string associated with this shortcut key and writes the value to the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> parameter.  
  
##  \<a name="ckeyboardmanager__iskeyhandled">\</a>  CKeyboardManager::IsKeyHandled  
 Determines whether the specified key is handled by the [CKeyboardManager Class](../vs140/ckeyboardmanager-class.md).  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|The key to check.|  
|[in] <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|Specifies the behavior of the shortcut key. For a list of possible values, see                                         [ACCEL Structure](http://msdn.microsoft.com/library/windows/desktop/ms646340).|  
|[in] <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|A frame window. This method determines whether a shortcut key is handled in this frame.|  
|[in] <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|A Boolean parameter that indicates whether <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is the default frame window.|  
  
### Return Value  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> if the shortcut key is handled. <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> if the key is not handled or if <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
### Remarks  
 The input parameters must match the entry in the accelerator table both for <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> to determine whether a shortcut key is handled in <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
##  \<a name="ckeyboardmanager__iskeyprintable">\</a>  CKeyboardManager::IsKeyPrintable  
 Indicates whether a character is printable.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|The character that this method checks.|  
  
### Return Value  
 Nonzero if the character is printable, zero if it is not.  
  
### Remarks  
 This method fails if a call to                         [GetKeyboardState](http://msdn.microsoft.com/library/windows/desktop/ms646299) fails.  
  
##  \<a name="ckeyboardmanager__isshowallaccelerators">\</a>  CKeyboardManager::IsShowAllAccelerators  
 Indicates whether menus show all the shortcut keys associated with menu commands or only the default shortcut keys.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the application lists all the shortcut keys for menu commands; 0 if the application displays only default shortcut keys.  
  
### Remarks  
 The application lists the shortcut keys for menu commands in the menu bar. Use the function [CKeyboardManager::ShowAllAccelerators](#ckeyboardmanager__showallaccelerators) to control whether the application lists all the shortcut keys or just the default shortcut keys.  
  
##  \<a name="ckeyboardmanager__loadstate">\</a>  CKeyboardManager::LoadState  
 Loads the shortcut key tables from the Windows registry.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 The registry path where <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> data is saved.  
  
 [in] <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 A pointer to a frame window to use as the default window.  
  
### Return Value  
 Nonzero if the state was loaded successfully or 0 otherwise.  
  
### Remarks  
 If the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> parameter is <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, this method checks the default registry location for <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> data. The default registry location is specified by the [CWinAppEx Class](../vs140/cwinappex-class.md). The data must be previously written with the method [CKeyboardManager::SaveState](#ckeyboardmanager__savestate).  
  
 If you do not specify a default window, the main frame window of your application will be used.  
  
##  \<a name="ckeyboardmanager__resetall">\</a>  CKeyboardManager::ResetAll  
 Reloads the shortcut key tables from the application resource.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
 This function clears the shortcuts stored in the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> instance. It will then reload the state of the keyboard manager from the application resource.  
  
##  \<a name="ckeyboardmanager__savestate">\</a>  CKeyboardManager::SaveState  
 Saves the shortcut key tables to the Windows registry.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 The registry path for saving the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> state.  
  
 [in] <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 A pointer to a frame window that becomes the default window.  
  
### Return Value  
 Nonzero if the keyboard manager state was saved successfully, or 0 otherwise.  
  
### Remarks  
 If the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> parameter is <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, this method will write the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> state to the default location specified by the [CWinAppEx Class](../vs140/cwinappex-class.md). If you specify a location, you can load the data later using the method [CKeyboardManager::LoadState](#ckeyboardmanager__loadstate).  
  
 If you do not specify a default window, the main frame window will be used as the default window.  
  
##  \<a name="ckeyboardmanager__showallaccelerators">\</a>  CKeyboardManager::ShowAllAccelerators  
 Shows all the shortcut keys associated with menu commands.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, all the shortcut keys will be displayed. If <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, only the first shortcut key will be displayed.  
  
 [in] <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 A string to insert between shortcut keys. This delimiter has no effect if only one shortcut key is displayed.  
  
### Remarks  
 By default, if a command has more than one shortcut key associated with it, only the first shortcut key will be shown. This function enables you to list all the shortcut keys associated with all commands.  
  
 The shortcut keys will be listed next to the command in the menu bar. If all the shortcut keys are displayed, the string provided by <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> will separate individual shortcut keys.  
  
##  \<a name="ckeyboardmanager__translatechartoupper">\</a>  CKeyboardManager::TranslateCharToUpper  
 Converts a character to its upper register.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 The character to convert.  
  
### Return Value  
 The character that is the upper register of the input parameter.  
  
##  \<a name="ckeyboardmanager__updateacceltable">\</a>  CKeyboardManager::UpdateAccelTable  
 Updates a shortcut key table with a new shortcut key table.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 A pointer to a document template.  
  
 [in] <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 A pointer to the new shortcut key.  
  
 [in] <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 The size of the new shortcut table.  
  
 [in] <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 A pointer to the default frame window.  
  
 [in] <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 A handle to the new shortcut table.  
  
### Return Value  
 Nonzero if the method is successful; otherwise 0.  
  
### Remarks  
 Use this function to replace the existing shortcut table with new shortcut keys for several frame window objects. The function receives a document template as a parameter to obtain access to all frame window objects connected to the given document template.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [CWinAppEx::InitKeyboardManager](../vs140/cwinappex-class.md#cwinappex__initkeyboardmanager)   
 [Keyboard and Mouse Customization](../vs140/keyboard-and-mouse-customization.md)