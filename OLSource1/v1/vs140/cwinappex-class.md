---
title: "CWinAppEx Class"
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
  - "CWinAppEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWinAppEx class"
ms.assetid: a3d3e053-3e22-463f-9444-c73abb1bb9d7
caps.latest.revision: 36
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx Class
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder> handles the application state, saves the state to the registry, loads the state from the registry, initializes application managers, and provides links to those same application managers.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CWinAppEx::CWinAppEx](#cwinappex__cwinappex)|Constructs a <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CWinAppEx::CleanState](#cwinappex__cleanstate)|Removes information about the application from the Windows registry.|  
|[CWinAppEx::EnableLoadWindowPlacement](#cwinappex__enableloadwindowplacement)|Specifies whether the application will load the initial size and location of the main frame window from the registry.|  
|[CWinAppEx::EnableTearOffMenus](#cwinappex__enabletearoffmenus)|Enables tear-off menus for the application.|  
|[CWinAppEx::EnableUserTools](#cwinappex__enableusertools)|Enables the user to create custom menu commands in the application.|  
|[CWinAppEx::ExitInstance](#cwinappex__exitinstance)|Called by the framework from within the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> member function to exit this instance of the application. (Overrides [CWinApp::ExitInstance](../vs140/cwinapp-class.md#cwinapp__exitinstance).)|  
|[CWinAppEx::GetBinary](#cwinappex__getbinary)|Reads binary data that is associated with the specified registry value.|  
|[CWinAppEx::GetContextMenuManager](#cwinappex__getcontextmenumanager)|Returns a pointer to the global [CContextMenuManager](../vs140/ccontextmenumanager-class.md) object.|  
|[CWinAppEx::GetDataVersion](#cwinappex__getdataversion)||  
|[CWinAppEx::GetDataVersionMajor](#cwinappex__getdataversionmajor)|Returns the major version of the application saved in the Windows registry.|  
|[CWinAppEx::GetDataVersionMinor](#cwinappex__getdataversionminor)|Returns the minor version of the application saved in the Windows registry.|  
|[CWinAppEx::GetInt](#cwinappex__getint)|Reads numeric data that is associated with the specified value from the registry.|  
|[CWinAppEx::GetKeyboardManager](#cwinappex__getkeyboardmanager)|Returns a pointer to the global [CKeyboardManager](../vs140/ckeyboardmanager-class.md) object.|  
|[CWinAppEx::GetMouseManager](#cwinappex__getmousemanager)|Returns a pointer to the global [CMouseManager](../vs140/cmousemanager-class.md) object.|  
|[CWinAppEx::GetObject](#cwinappex__getobject)|Reads <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>-derived data that is associated with the specified value from the registry.|  
|[CWinAppEx::GetRegSectionPath](#cwinappex__getregsectionpath)|Returns a string that is the path of a registry key. This path concatenates the supplied relative path with the application path.|  
|[CWinAppEx::GetRegistryBase](#cwinappex__getregistrybase)|Returns the registry path for the application.|  
|[CWinAppEx::GetSectionBinary](#cwinappex__getsectionbinary)|Reads binary data that is associated with the specified key and value from the registry.|  
|[CWinAppEx::GetSectionInt](#cwinappex__getsectionint)|Reads numeric data from the registry associated with the specified key and value.|  
|[CWinAppEx::GetSectionObject](#cwinappex__getsectionobject)|Reads <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> data that is associated with the specified key and value from the registry.|  
|[CWinAppEx::GetSectionString](#cwinappex__getsectionstring)|Reads string data that is associated with the specified key and value from the registry.|  
|[CWinAppEx::GetShellManager](#cwinappex__getshellmanager)|Returns a pointer to the global [CShellManager](../vs140/cshellmanager-class.md) object.|  
|[CWinAppEx::GetString](#cwinappex__getstring)|Reads string data that is associated with the specified value from the registry.|  
|[CWinAppEx::GetTooltipManager](#cwinappex__gettooltipmanager)|Returns a pointer to the global [CTooltipManager](../vs140/ctooltipmanager-class.md) object.|  
|[CWinAppEx::GetUserToolsManager](#cwinappex__getusertoolsmanager)|Returns a pointer to the global [CUserToolsManager](../vs140/cusertoolsmanager-class.md) object.|  
|[CWinAppEx::InitContextMenuManager](#cwinappex__initcontextmenumanager)|Initializes the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> object.|  
|[CWinAppEx::InitKeyboardManager](#cwinappex__initkeyboardmanager)|Initializes the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> object.|  
|[CWinAppEx::InitMouseManager](#cwinappex__initmousemanager)|Initializes the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> object.|  
|[CWinAppEx::InitShellManager](#cwinappex__initshellmanager)|Initializes the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> class|  
|[CWinAppEx::InitTooltipManager](#cwinappex__inittooltipmanager)|Initializes the <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> class.|  
|[CWinAppEx::IsResourceSmartUpdate](#cwinappex__isresourcesmartupdate)||  
|[CWinAppEx::IsStateExists](#cwinappex__isstateexists)|Indicates whether the specified key is in the registry.|  
|[CWinAppEx::LoadState](#cwinappex__loadstate)|Loads the application state from the registry.|  
|[CWinAppEx::OnAppContextHelp](#cwinappex__onappcontexthelp)|Called by the framework when the user requests context help for the **Customization** dialog box.|  
|[CWinAppEx::OnViewDoubleClick](#cwinappex__onviewdoubleclick)|Calls the user-defined command when the user double-clicks anywhere in the application.|  
|[CWinAppEx::OnWorkspaceIdle](#cwinappex__onworkspaceidle)||  
|[CWinAppEx::SaveState](#cwinappex__savestate)|Writes the state of the application framework to the Windows registry.|  
|[CWinAppEx::SetRegistryBase](#cwinappex__setregistrybase)|Sets the path of the default registry key. This key will serve as a root for all subsequent registry calls.|  
|[CWinAppEx::ShowPopupMenu](#cwinappex__showpopupmenu)|Displays a popup menu.|  
|[CWinAppEx::WriteBinary](#cwinappex__writebinary)|Writes the binary data to the specified registry value.|  
|[CWinAppEx::WriteInt](#cwinappex__writeint)|Writes the numeric data to the specified registry value.|  
|[CWinAppEx::WriteObject](#cwinappex__writeobject)|Writes data that is derived from the [CObject Class](../vs140/cobject-class.md) to the specified registry value.|  
|[CWinAppEx::WriteSectionBinary](#cwinappex__writesectionbinary)|Writes the binary data to a value of the specified registry key.|  
|[CWinAppEx::WriteSectionInt](#cwinappex__writesectionint)|Writes the numeric data to a value of the specified registry key.|  
|[CWinAppEx::WriteSectionObject](#cwinappex__writesectionobject)|Writes data derived from the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> class to a value of the specified registry key.|  
|[CWinAppEx::WriteSectionString](#cwinappex__writesectionstring)|Writes the string data to a value of the specified registry key.|  
|[CWinAppEx::WriteString](#cwinappex__writestring)|Writes the string data to the specified registry value.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CWinAppEx::LoadCustomState](#cwinappex__loadcustomstate)|Called by the framework when the application state has been loaded.|  
|[CWinAppEx::LoadWindowPlacement](#cwinappex__loadwindowplacement)|Called by the framework when it loads the size and location of your application from the registry. The loaded data includes the size and location of the main frame at the time your application last closed.|  
|[CWinAppEx::OnClosingMainFrame](#cwinappex__onclosingmainframe)|Called by the framework when a main frame window is processing <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>.|  
|[CWinAppEx::PreLoadState](#cwinappex__preloadstate)|Called by the framework immediately before the application state is loaded.|  
|[CWinAppEx::PreSaveState](#cwinappex__presavestate)|Called by the framework immediately before the application state is saved.|  
|[CWinAppEx::ReloadWindowPlacement](#cwinappex__reloadwindowplacement)|Reloads the size and location of the supplied window from the registry|  
|[CWinAppEx::SaveCustomState](#cwinappex__savecustomstate)|Called by the framework after it writes the application state to the registry.|  
|[CWinAppEx::StoreWindowPlacement](#cwinappex__storewindowplacement)|Called by the framework to write the size and location of the main frame to the registry.|  
  
### Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CWinAppEx::m_bForceImageReset](#cwinappex__m_bforceimagereset)|Specifies whether the framework will reset all toolbar images when the frame window that contains the toolbar is loaded.|  
  
## Remarks  
 Much of the functionality provided by the MFC framework depends on the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> class. You can incorporate the <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> class into your application in one of two ways:  
  
-   Construct a <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> class in the main thread.  
  
-   Derive the main application class from <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>.  
  
 After you incorporate <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> into your application, you can initialize any one of the application managers. Before you use an application manager, you must initialize it by calling the appropriate initialize method. To obtain a pointer to a specific manager, call the associated get method. The <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> class manages the following application managers: [CMouseManager Class](../vs140/cmousemanager-class.md), [CContextMenuManager Class](../vs140/ccontextmenumanager-class.md), [CKeyboardManager Class](../vs140/ckeyboardmanager-class.md), [CUserToolsManager Class](../vs140/cusertoolsmanager-class.md), and [CMenuTearOffManager Class](../vs140/cmenutearoffmanager-class.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWinThread](../vs140/cwinthread-class.md)  
  
 [CWinApp](../vs140/cwinapp-class.md)  
  
 [CWinAppEx](../vs140/cwinappex-class.md)  
  
## Requirements  
 **Header:** afxwinappex.h  
  
##  \<a name="cwinappex__cleanstate">\</a>  CWinAppEx::CleanState  
 Removes all the information about the application from the Windows registry.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 A string that contains a path of a registry key.  
  
### Return Value  
 Nonzero if the method was successful; otherwise 0.  
  
### Remarks  
 This method clears application data from a specific section of the registry. You can specify the section to clear by using the parameter <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>, this method will use the default registry path stored in the <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> object. To get the default registry path, use [CWinAppEx::GetRegistryBase](#cwinappex__getregistrybase).  
  
##  \<a name="cwinappex__cwinappex">\</a>  CWinAppEx::CWinAppEx  
 Constructs a <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies whether the workspace object should detect and handle resource updates.  
  
### Remarks  
 The <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> class has initialization methods, provides functionality for saving and loading application information to the registry, and controls global application settings. It also enables you to use global managers such as the [CKeyboardManager Class](../vs140/ckeyboardmanager-class.md) and the [CUserToolsManager Class](../vs140/cusertoolsmanager-class.md). Each application can have only one instance of the <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> class.  
  
##  \<a name="cwinappex__enableloadwindowplacement">\</a>  CWinAppEx::EnableLoadWindowPlacement  
 Specifies whether the application will load the initial size and location of the main frame window from the registry.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 Specifies whether the application loads the initial size and location of the main frame window from the registry.  
  
### Remarks  
 By default, the size and location of the main frame is loaded from the registry together with other application settings. This occurs during [CWinAppEx::LoadState](#cwinappex__loadstate). If you do not want to load the initial window placement from the registry, call this method with <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>.  
  
##  \<a name="cwinappex__enabletearoffmenus">\</a>  CWinAppEx::EnableTearOffMenus  
 Creates and initializes a [CMenuTearOffManager](../vs140/cmenutearoffmanager-class.md) object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 A string that contains the path of a registry key. The application uses this registry key to store information for the tear-off menus.  
  
 [in] <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 The first tear off menu ID.  
  
 [in] <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 The last tear off menu ID.  
  
### Return Value  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> if the <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> is created and initialized successfully; <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> if an error occurs or if the <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> already exists.  
  
### Remarks  
 Use this function to enable tear-off menus in your application. You should call this function from <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>.  
  
##  \<a name="cwinappex__enableusertools">\</a>  CWinAppEx::EnableUserTools  
 Enables the user to create custom menu commands that reduce keystrokes in your application. This method creates a [CUserToolsManager](../vs140/cusertoolsmanager-class.md) object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 An unsigned integer that the framework uses as a placeholder for the command ID of the user tools menu.  
  
 [in] <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 The command ID for the first user tool command.  
  
 [in] <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 The command ID for the last user tool command.  
  
 [in] <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
 A class that the <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> object uses to create new user tools.  
  
 [in] <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 The argument menu ID.  
  
 [in] <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 The menu ID for the initial tool directory.  
  
### Return Value  
 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> if the method creates and initializes a <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> object; <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> if the method fails or if a <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> object already exists.  
  
### Remarks  
 When you enable user-defined tools, the framework automatically supports a dynamic menu that can be extended during customization. The framework associates each new item with an external command. The framework invokes these commands when the user selects the appropriate item from the **Tools** menu.  
  
 Every time the user adds a new item, the framework creates a new object. The class type for the new object is defined by <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> class type must be derived from the [CUserTool Class](../vs140/cusertool-class.md).  
  
 For more information about user tools and how to incorporate them into your application, see [User-defined Tools](../vs140/user-defined-tools.md).  
  
##  \<a name="cwinappex__exitinstance">\</a>  CWinAppEx::ExitInstance  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cwinappex__getbinary">\</a>  CWinAppEx::GetBinary  
 Reads binary data from a specified registry key.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 A string that contains the name of a registry key.  
  
 [out] <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 A pointer to the buffer that the method fills with the binary data.  
  
 [out] <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 A pointer to an unsigned integer that the method uses to write the number of bytes read.  
  
### Return Value  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> if successful; <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 This method reads binary data written to the registry. To write data to the registry, use the methods [CWinAppEx::WriteBinary](#cwinappex__writebinary) and [CWinAppEx::WriteSectionBinary](#cwinappex__writesectionbinary).  
  
 The <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> parameter is the name of a registry entry located under the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](#cwinappex__getregistrybase) and [CWinAppEx::SetRegistryBase](#cwinappex__setregistrybase) respectively.  
  
##  \<a name="cwinappex__getcontextmenumanager">\</a>  CWinAppEx::GetContextMenuManager  
 Returns a pointer to the global [CContextMenuManager](../vs140/ccontextmenumanager-class.md) object.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the global <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> object.  
  
### Remarks  
 If the CContextMenuManager object is not initialized, this function calls [CWinAppEx::InitContextMenuManager](#cwinappex__initcontextmenumanager) before it returns a pointer.  
  
##  \<a name="cwinappex__getdataversion">\</a>  CWinAppEx::GetDataVersion  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cwinappex__getdataversionmajor">\</a>  CWinAppEx::GetDataVersionMajor  
 Returns the major version of the application that is saved in the Windows registry when you call [CWinAppEx::SaveState](#cwinappex__savestate).  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 An integer value that contains the major version number.  
  
##  \<a name="cwinappex__getdataversionminor">\</a>  CWinAppEx::GetDataVersionMinor  
 Returns the minor version of the application that is saved in the Windows registry when you call [CWinAppEx::SaveState](#cwinappex__savestate).  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 An integer value that contains the minor version number.  
  
##  \<a name="cwinappex__getint">\</a>  CWinAppEx::GetInt  
 Reads integer data from a specified registry key.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
 A string that contains the name of a registry entry.  
  
 [in] <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
 The default value that the method returns if the specified registry entry does not exist.  
  
### Return Value  
 The registry data if the method was successful; otherwise <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method reads integer data from the registry. If there is no integer data associated with the registry key indicated by <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>, this method returns <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>. To write data to the registry, use the methods [CWinAppEx::WriteSectionInt](#cwinappex__writesectionint) and [CWinAppEx::WriteInt](#cwinappex__writeint).  
  
 The <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> parameter is the name of a registry entry located under the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](#cwinappex__getregistrybase) and [CWinAppEx::SetRegistryBase](#cwinappex__setregistrybase) respectively.  
  
##  \<a name="cwinappex__getkeyboardmanager">\</a>  CWinAppEx::GetKeyboardManager  
 Returns a pointer to the global [CKeyboardManager](../vs140/ckeyboardmanager-class.md) object.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the global <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> object.  
  
### Remarks  
 If the keyboard manager is not initialized, this function calls [CWinAppEx::InitKeyboardManager](#cwinappex__initkeyboardmanager) before it returns a pointer.  
  
##  \<a name="cwinappex__getmousemanager">\</a>  CWinAppEx::GetMouseManager  
 Returns a pointer to the global [CMouseManager](../vs140/cmousemanager-class.md) object.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the global <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> object.  
  
### Remarks  
 If the mouse manager is not initialized,, this function calls [CWinAppEx::InitMouseManager](#cwinappex__initmousemanager) before it returns a pointer.  
  
##  \<a name="cwinappex__getobject">\</a>  CWinAppEx::GetObject  
 Reads [CObject](../vs140/cobject-class.md)-dervied data from the registry.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
 A string that contains the relative path of a registry entry.  
  
 [out] <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>. The method uses this reference to store the registry data.  
  
### Return Value  
 Nonzero if the method was successful; otherwise 0.  
  
### Remarks  
 This method reads data from the registry that is derived from <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>. To write <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> data to the registry, use either [CWinAppEx::WriteObject](#cwinappex__writeobject) or [CWinAppEx::WriteSectionObject](#cwinappex__writesectionobject).  
  
 The <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> parameter is the name of a registry entry that is located under the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](#cwinappex__getregistrybase) and [CWinAppEx::SetRegistryBase](#cwinappex__setregistrybase) respectively.  
  
##  \<a name="cwinappex__getregistrybase">\</a>  CWinAppEx::GetRegistryBase  
 Retrieves the default registry path for the application.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 A string that contains the path of the default registry location.  
  
### Remarks  
 All methods of the [CWinAppEx Class](../vs140/cwinappex-class.md) that access the registry start in a default location. Use this method to retrieve a path of the default registry location. Use [CWinAppEx::SetRegistryBase](#cwinappex__setregistrybase) to change the default registry location.  
  
##  \<a name="cwinappex__getregsectionpath">\</a>  CWinAppEx::GetRegSectionPath  
 Creates and returns the absolute path of a registry key.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 A string that contains the relative path of a registry key.  
  
### Return Value  
 A <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> that contains the absolute path of a registry key.  
  
### Remarks  
 This method defines the registry key's absolute path by appending the relative path in <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> to the default registry location for your application. To get the default registry key, use the method [CWinAppEx::GetRegistryBase](#cwinappex__getregistrybase).  
  
##  \<a name="cwinappex__getsectionbinary">\</a>  CWinAppEx::GetSectionBinary  
 Reads binary data from the registry.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
 A string that contains the relative path of a registry key.  
  
 [in] <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 A string that contains the value to read.  
  
 [out] <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
 A pointer to the buffer where the method stores the data.  
  
 [out] <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
 A pointer to an unsigned integer. The method writes the size of <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> to this parameter.  
  
### Return Value  
 <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> if successful; otherwise <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method reads binary data that is written to the registry using the methods [CWinAppEx::WriteBinary](#cwinappex__writebinary) and [CWinAppEx::WriteSectionBinary](#cwinappex__writesectionbinary).  
  
 The <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> parameter is not an absolute path for a registry entry. It is a relative path that is appended to the end of the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](#cwinappex__getregistrybase) and [CWinAppEx::SetRegistryBase](#cwinappex__setregistrybase) respectively.  
  
##  \<a name="cwinappex__getsectionint">\</a>  CWinAppEx::GetSectionInt  
 Reads integer data from the registry.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
 A string that contains the relative path of a registry key.  
  
 [in] <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
 A string that contains the value to read.  
  
 [in] <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
 The default value to return if the specified value does not exist.  
  
### Return Value  
 The integer data that is stored in the specified registry value; <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> if the data does not exist.  
  
### Remarks  
 Use the methods [CWinAppEx::WriteInt](#cwinappex__writeint) and [CWinAppEx::WriteSectionInt](#cwinappex__writesectionint) to write integer data to the registry.  
  
 The <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> parameter is not an absolute path of a registry entry. It is a relative path that is added to the end of the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](#cwinappex__getregistrybase) and [CWinAppEx::SetRegistryBase](#cwinappex__setregistrybase) respectively.  
  
##  \<a name="cwinappex__getsectionobject">\</a>  CWinAppEx::GetSectionObject  
 Reads [CObject](../vs140/cobject-class.md) registry data from the registry.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
 A string that contains the relative path of a registry key.  
  
 [in] <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
 A string that contains the value to read.  
  
 [out] <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>. The method uses this <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> to store the registry data.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 This method reads data from the registry. The data read is <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> data, or data for a class derived from <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>. To write <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> data to the registry, use either [CWinAppEx::WriteObject](#cwinappex__writeobject) or [CWinAppEx::WriteSectionObject](#cwinappex__writesectionobject).  
  
 The <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> parameter is not an absolute path for a registry entry. It is a relative path that is appended to the end of the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](#cwinappex__getregistrybase) and [CWinAppEx::SetRegistryBase](#cwinappex__setregistrybase) respectively.  
  
##  \<a name="cwinappex__getsectionstring">\</a>  CWinAppEx::GetSectionString  
 Reads string data from the registry.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>  
 A string that contains the relative path of a registry key.  
  
 [in] <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>  
 A string that contains the value to read.  
  
 [in] <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>  
 The default value to return if the specified value does not exist.  
  
### Return Value  
 The string data stored in the specified registry value if the data exists; otherwise <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method reads string data written to the registry. Use [CWinAppEx::WriteString](#cwinappex__writestring) and [CWinAppEx::WriteSectionString](#cwinappex__writesectionstring) to write string data to the registry.  
  
 The <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> parameter is not an absolute path for a registry entry. It is a relative path that is appended to the end of the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](#cwinappex__getregistrybase) and [CWinAppEx::SetRegistryBase](#cwinappex__setregistrybase) respectively.  
  
##  \<a name="cwinappex__getshellmanager">\</a>  CWinAppEx::GetShellManager  
 Returns a pointer to the global [CShellManager](../vs140/cshellmanager-class.md) object.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the global <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> object.  
  
### Remarks  
 If the <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> object is not initialized, this function calls [CWinAppEx::InitShellManager](#cwinappex__initshellmanager) before it returns a pointer.  
  
##  \<a name="cwinappex__getstring">\</a>  CWinAppEx::GetString  
 Reads string data from a specified registry key.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
 A string that contains the name of a registry key  
  
 [in] <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>  
 The default value that the method returns if the specified registry entry does not exist.  
  
### Return Value  
 The string data stored in the registry if successful; <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 This method reads string data written to the registry. To write data to the registry, use the methods [CWinAppEx::WriteString](#cwinappex__writestring) or [CWinAppEx::WriteSectionString](#cwinappex__writesectionstring).  
  
 The <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> parameter is the name of a registry entry located under the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](#cwinappex__getregistrybase) and [CWinAppEx::SetRegistryBase](#cwinappex__setregistrybase) respectively.  
  
##  \<a name="cwinappex__gettooltipmanager">\</a>  CWinAppEx::GetTooltipManager  
 Returns a pointer to the global [CTooltipManager](../vs140/ctooltipmanager-class.md) object.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the global <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> object.  
  
### Remarks  
 If the <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> object is not initialized, this function calls [CWinAppEx::InitTooltipManager](#cwinappex__inittooltipmanager) before it returns a pointer.  
  
##  \<a name="cwinappex__getusertoolsmanager">\</a>  CWinAppEx::GetUserToolsManager  
 Returns a pointer to the global [CUserToolsManager](../vs140/cusertoolsmanager-class.md) object.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the global <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> object; <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> if user tools management is not enabled for the application.  
  
### Remarks  
 Before you retrieve a pointer to the <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> object, you must initialize the manager by calling [CWinAppEx::EnableUserTools](#cwinappex__enableusertools).  
  
##  \<a name="cwinappex__initcontextmenumanager">\</a>  CWinAppEx::InitContextMenuManager  
 Initializes the [CContextMenuManager](../vs140/ccontextmenumanager-class.md) object.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the method creates the CContextMenuManager object; 0 if the <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> object already exists.  
  
### Remarks  
 If you call [CWinAppEx::GetContextMenuManager](#cwinappex__getcontextmenumanager), the default implementation of that method calls <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>.  
  
 If your application already has a context menu manager and you call <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>, your application will have an [ASSERT](../vs140/assert--mfc-.md) failure. Therefore, you should not call <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> if you create a <CodeContentPlaceHolder>174\</CodeContentPlaceHolder> object directly. If you are not using a custom <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>, you should use <CodeContentPlaceHolder>176\</CodeContentPlaceHolder> to create a <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> object.  
  
##  \<a name="cwinappex__initkeyboardmanager">\</a>  CWinAppEx::InitKeyboardManager  
 Initializes the [CKeyboardManager](../vs140/ckeyboardmanager-class.md) object.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the method creates the <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> object; 0 if the <CodeContentPlaceHolder>179\</CodeContentPlaceHolder> object already exists.  
  
### Remarks  
 If you call [CWinAppEx::GetKeyboardManager](#cwinappex__getkeyboardmanager), the default implementation of that method calls <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>.  
  
 If your application already has a keyboard manager and you call <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>, your application will have an [ASSERT](../vs140/assert--mfc-.md) failure. Therefore, you should not call <CodeContentPlaceHolder>182\</CodeContentPlaceHolder> if you create a <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> object directly. If you are not using a custom <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>, you should use <CodeContentPlaceHolder>185\</CodeContentPlaceHolder> to create a <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> object.  
  
##  \<a name="cwinappex__initmousemanager">\</a>  CWinAppEx::InitMouseManager  
 Initializes the [CMouseManager](../vs140/cmousemanager-class.md) object.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the method creates the <CodeContentPlaceHolder>187\</CodeContentPlaceHolder> object; 0 if the <CodeContentPlaceHolder>188\</CodeContentPlaceHolder> object already exists.  
  
### Remarks  
 If you call [CWinAppEx::GetMouseManager](#cwinappex__getmousemanager), the default implementation of that method calls <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>.  
  
 If your application already has a mouse manager and you call <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>, your application will have an [ASSERT](../vs140/assert--mfc-.md) failure. Therefore you should not call <CodeContentPlaceHolder>191\</CodeContentPlaceHolder> if you create a <CodeContentPlaceHolder>192\</CodeContentPlaceHolder> object directly. If you are not using a custom <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>, you should use <CodeContentPlaceHolder>194\</CodeContentPlaceHolder> to create a <CodeContentPlaceHolder>195\</CodeContentPlaceHolder> object.  
  
##  \<a name="cwinappex__initshellmanager">\</a>  CWinAppEx::InitShellManager  
 Initializes the [CShellManager](../vs140/cshellmanager-class.md) object.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the method creates the <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> object; 0 if the <CodeContentPlaceHolder>197\</CodeContentPlaceHolder> object already exists.  
  
### Remarks  
 If you call [CWinAppEx::GetShellManager](#cwinappex__getshellmanager), the default implementation of that method calls <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>.  
  
 If your application already has a shell manager and you call <CodeContentPlaceHolder>199\</CodeContentPlaceHolder>, your application raises an [ASSERT](../vs140/assert--mfc-.md) failure. Therefore, do not call <CodeContentPlaceHolder>200\</CodeContentPlaceHolder> if you create a <CodeContentPlaceHolder>201\</CodeContentPlaceHolder> object directly. If you are not using a custom <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>, use <CodeContentPlaceHolder>203\</CodeContentPlaceHolder> to create a <CodeContentPlaceHolder>204\</CodeContentPlaceHolder> object.  
  
##  \<a name="cwinappex__inittooltipmanager">\</a>  CWinAppEx::InitTooltipManager  
 Initializes the [CTooltipManager](../vs140/ctooltipmanager-class.md) object.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the method creates the <CodeContentPlaceHolder>205\</CodeContentPlaceHolder> object; 0 if the <CodeContentPlaceHolder>206\</CodeContentPlaceHolder> object already exists.  
  
### Remarks  
 If you call [CWinAppEx::GetTooltipManager](#cwinappex__gettooltipmanager), the default implementation of that method calls <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>.  
  
 If your application already has a tooltip manager and you call <CodeContentPlaceHolder>208\</CodeContentPlaceHolder>, your application will have an [ASSERT](../vs140/assert--mfc-.md) failure. Therefore, you should not call <CodeContentPlaceHolder>209\</CodeContentPlaceHolder> if you create a <CodeContentPlaceHolder>210\</CodeContentPlaceHolder> object directly. If you are not using a custom <CodeContentPlaceHolder>211\</CodeContentPlaceHolder>, you should use <CodeContentPlaceHolder>212\</CodeContentPlaceHolder> to create a <CodeContentPlaceHolder>213\</CodeContentPlaceHolder> object.  
  
##  \<a name="cwinappex__isresourcesmartupdate">\</a>  CWinAppEx::IsResourceSmartUpdate  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cwinappex__isstateexists">\</a>  CWinAppEx::IsStateExists  
 Indicates whether the specified key is in the registry.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>214\</CodeContentPlaceHolder>  
 A string that contains a path of a registry key.  
  
### Return Value  
 Nonzero if the key is in the registry; otherwise 0.  
  
##  \<a name="cwinappex__loadcustomstate">\</a>  CWinAppEx::LoadCustomState  
 The framework calls this method after it loads the state of the application from the registry.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Remarks  
 Override this method if you want to do any processing after the application loads the state from the registry. By default, this method does nothing.  
  
 In order to load custom state information from the registry, the information must first be saved by using [CWinAppEx::SaveCustomState](#cwinappex__savecustomstate).  
  
##  \<a name="cwinappex__loadstate">\</a>  CWinAppEx::LoadState  
 Reads the application state from the Windows registry.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>  
 A pointer to a frame window object. The method applies the state information in the registry to this frame window.  
  
 [in] <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>  
 A string that contains the relative path of a registry key.  
  
 [in] <CodeContentPlaceHolder>217\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>218\</CodeContentPlaceHolder> object. The method applies the state information in the registry to this frame window.  
  
### Return Value  
 Nonzero if successful; 0 otherwise.  
  
### Remarks  
 This method loads the state of the application and any state information for a frame window. The loaded information for the frame window is applied to the supplied frame window. If you do not supply a frame window, only the application state information is loaded. The application information includes the state of the [CMouseManager Class](../vs140/cmousemanager-class.md), [CContextMenuManager Class](../vs140/ccontextmenumanager-class.md), [CKeyboardManager Class](../vs140/ckeyboardmanager-class.md), and the [CUserToolsManager Class](../vs140/cusertoolsmanager-class.md).  
  
 The default implementation of <CodeContentPlaceHolder>219\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>221\</CodeContentPlaceHolder> parameter is not the absolute path for a registry entry. It is a relative path that is added to the end of the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](#cwinappex__getregistrybase) and [CWinAppEx::SetRegistryBase](#cwinappex__setregistrybase) respectively.  
  
##  \<a name="cwinappex__loadwindowplacement">\</a>  CWinAppEx::LoadWindowPlacement  
 Called by the framework when it loads the size and location of the main frame window from the registry.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>222\</CodeContentPlaceHolder>  
 A rectangle that contains the coordinates of the main frame window when it is in the restored position.  
  
 [out] <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>  
 Flags that control the position of the minimized window and how the operating system switches between a minimized window and a restored window.  
  
 [out] <CodeContentPlaceHolder>224\</CodeContentPlaceHolder>  
 An integer that specifies the show state of the window. For more information about possible values, see [CWnd::ShowWindow](../vs140/cwnd-class.md#cwnd__showwindow).  
  
### Return Value  
 Nonzero if successful; 0 otherwise.  
  
### Remarks  
 By default, MFC automatically loads the previous position and state of the main frame window when the application starts. For more information about how this information is stored in the registry, see [CWinAppEx::StoreWindowPlacement](#cwinappex__storewindowplacement).  
  
 Override this method if you want to load additional information about the main frame window.  
  
##  \<a name="cwinappex__m_bforceimagereset">\</a>  CWinAppEx::m_bForceImageReset  
 Specifies whether the framework resets all toolbar images when it reloads the frame window that contains the toolbar.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Remarks  
 The <CodeContentPlaceHolder>225\</CodeContentPlaceHolder> data member is a protected variable.  
  
##  \<a name="cwinappex__onappcontexthelp">\</a>  CWinAppEx::OnAppContextHelp  
 The framework calls this method when the user requests context help for the **Customization** dialog box.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>226\</CodeContentPlaceHolder>  
 A pointer to a window object for which the user invoked context help.  
  
 [in] <CodeContentPlaceHolder>227\</CodeContentPlaceHolder>  
 A reserved value.  
  
### Remarks  
 This method is currently reserved for future use. The default implementation does nothing and it is currently not called by the framework.  
  
##  \<a name="cwinappex__onclosingmainframe">\</a>  CWinAppEx::OnClosingMainFrame  
 The framework calls this method when a frame window is processing <CodeContentPlaceHolder>228\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>229\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>230\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The default implementation of this method saves the state of <CodeContentPlaceHolder>231\</CodeContentPlaceHolder>.  
  
##  \<a name="cwinappex__onviewdoubleclick">\</a>  CWinAppEx::OnViewDoubleClick  
 Calls the user-defined command that is associated with a view when the user double-clicks anywhere within that view.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>232\</CodeContentPlaceHolder>  
 A pointer to an object derived from the [CView Class](../vs140/cview-class.md).  
  
 [in] <CodeContentPlaceHolder>233\</CodeContentPlaceHolder>  
 The view ID.  
  
### Return Value  
 <CodeContentPlaceHolder>234\</CodeContentPlaceHolder> if the framework finds a command; otherwise false.  
  
### Remarks  
 In order to support custom mouse behavior, you must call this function when you process the <CodeContentPlaceHolder>235\</CodeContentPlaceHolder> message. This method will execute the command associated with the view ID supplied by <CodeContentPlaceHolder>236\</CodeContentPlaceHolder>. For more information about custom mouse behavior, see [Keyboard and Mouse Customization](../vs140/keyboard-and-mouse-customization.md).  
  
##  \<a name="cwinappex__onworkspaceidle">\</a>  CWinAppEx::OnWorkspaceIdle  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>237\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cwinappex__preloadstate">\</a>  CWinAppEx::PreLoadState  
 The framework calls this method immediately before it loads the state of the application from the registry.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Remarks  
 Override this method if you want to do any processing immediately before the framework loads the application state.  
  
##  \<a name="cwinappex__presavestate">\</a>  CWinAppEx::PreSaveState  
 The framework calls this method immediately before it saves the application state.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Remarks  
 Override this method if you want to do any processing immediately before the framework saves the application state.  
  
##  \<a name="cwinappex__reloadwindowplacement">\</a>  CWinAppEx::ReloadWindowPlacement  
 Reloads the size and location of a window from the registry.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>238\</CodeContentPlaceHolder>  
 A pointer to a frame window.  
  
### Return Value  
 Nonzero if the method was successful; 0 if the load failed or there is no data to load.  
  
### Remarks  
 Use the function [CWinAppEx::StoreWindowPlacement](#cwinappex__storewindowplacement) to write the size and location of a window to the registry.  
  
##  \<a name="cwinappex__savecustomstate">\</a>  CWinAppEx::SaveCustomState  
 The framework calls this method after it saves the state of the application to the registry.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Remarks  
 Override this method if you want to do any processing after the application saves the state to the registry. By default, this method does nothing.  
  
##  \<a name="cwinappex__savestate">\</a>  CWinAppEx::SaveState  
 Writes the application state to the Windows registry.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>239\</CodeContentPlaceHolder>  
 A string that contains the relative path of a registry key.  
  
 [in] <CodeContentPlaceHolder>240\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>241\</CodeContentPlaceHolder> object. This frame is saved to the Windows registry.  
  
 [in] <CodeContentPlaceHolder>242\</CodeContentPlaceHolder>  
 A pointer to a frame window object. This frame is saved to the Windows registry.  
  
### Return Value  
 <CodeContentPlaceHolder>243\</CodeContentPlaceHolder> if successful; <CodeContentPlaceHolder>244\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 This method saves the state of the application and any state information for the provided frame window. If you do not provide a frame window, the method only saves the application state. The application information includes the state of the [CMouseManager Class](../vs140/cmousemanager-class.md), [CContextMenuManager Class](../vs140/ccontextmenumanager-class.md), [CKeyboardManager Class](../vs140/ckeyboardmanager-class.md), and the [CUserToolsManager Class](../vs140/cusertoolsmanager-class.md).  
  
 The <CodeContentPlaceHolder>245\</CodeContentPlaceHolder> parameter is not the absolute path for a registry entry. It is a relative path that is appended to the end of the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](#cwinappex__getregistrybase) and [CWinAppEx::SetRegistryBase](#cwinappex__setregistrybase) respectively.  
  
##  \<a name="cwinappex__setregistrybase">\</a>  CWinAppEx::SetRegistryBase  
 Sets the default registry path for the application.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>246\</CodeContentPlaceHolder>  
 A string that contains the path of a registry key.  
  
### Return Value  
 A string that contains the path of the default registry location.  
  
### Remarks  
 All methods of the [CWinAppEx Class](../vs140/cwinappex-class.md) that access the registry start in a default location. Use this method to change that default registry location. Use [CWinAppEx::GetRegistryBase](#cwinappex__getregistrybase) to retrieve the default registry location.  
  
##  \<a name="cwinappex__showpopupmenu">\</a>  CWinAppEx::ShowPopupMenu  
 Displays a popup menu.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>247\</CodeContentPlaceHolder>  
 A menu resource ID.  
  
 [in] <CodeContentPlaceHolder>248\</CodeContentPlaceHolder>  
 A [CPoint](../vs140/cpoint-class.md) that specifies the position of the menu in screen coordinates.  
  
 [in] <CodeContentPlaceHolder>249\</CodeContentPlaceHolder>  
 A pointer to the window that owns the popup menu.  
  
### Return Value  
 Nonzero if the popup menu is displayed successfully; 0 otherwise.  
  
### Remarks  
 This method displays the menu associated with <CodeContentPlaceHolder>250\</CodeContentPlaceHolder>.  
  
 To support popup menus, you must have a [CContextMenuManager](../vs140/ccontextmenumanager-class.md) object. If you have not initialized the <CodeContentPlaceHolder>251\</CodeContentPlaceHolder> object, <CodeContentPlaceHolder>252\</CodeContentPlaceHolder> will fail.  
  
##  \<a name="cwinappex__storewindowplacement">\</a>  CWinAppEx::StoreWindowPlacement  
 Called by the framework to write the size and location of the main frame window to the registry.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>253\</CodeContentPlaceHolder>  
 Flags that control the position of the minimized window and how the operating system switches between a minimized window and a restored window.  
  
 [in] <CodeContentPlaceHolder>254\</CodeContentPlaceHolder>  
 An integer that specifies the show state of the window. For more information about possible values, see [CWnd::ShowWindow](../vs140/cwnd-class.md#cwnd__showwindow).  
  
 [in] <CodeContentPlaceHolder>255\</CodeContentPlaceHolder>  
 A rectangle that contains the coordinates of the main frame window when it is in the restored state.  
  
### Return Value  
 Nonzero if successful; 0 otherwise.  
  
### Remarks  
 By default, MFC automatically saves the position and state of the main frame window before the application exits. This information is stored in the Windows registry under the WindowPlacement key in the default registry location for your application. For more information about the default registry location of your application, see [CWinAppEx::GetRegistryBase](#cwinappex__getregistrybase).  
  
 Override this method if you want to store additional information about the main frame window.  
  
##  \<a name="cwinappex__writebinary">\</a>  CWinAppEx::WriteBinary  
 Writes binary data to the registry.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>256\</CodeContentPlaceHolder>  
 A string that contains the name of a registry key.  
  
 [in] <CodeContentPlaceHolder>257\</CodeContentPlaceHolder>  
 The data to store.  
  
 [in] <CodeContentPlaceHolder>258\</CodeContentPlaceHolder>  
 The size of <CodeContentPlaceHolder>259\</CodeContentPlaceHolder> in bytes.  
  
### Return Value  
 <CodeContentPlaceHolder>260\</CodeContentPlaceHolder> if this method is successful; otherwise <CodeContentPlaceHolder>261\</CodeContentPlaceHolder>.  
  
### Remarks  
 The <CodeContentPlaceHolder>262\</CodeContentPlaceHolder> parameter is the name of a registry entry that is located under the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](#cwinappex__getregistrybase) and [CWinAppEx::SetRegistryBase](#cwinappex__setregistrybase) respectively.  
  
 If the key specified by <CodeContentPlaceHolder>263\</CodeContentPlaceHolder> does not exist, this method will create it.  
  
##  \<a name="cwinappex__writeint">\</a>  CWinAppEx::WriteInt  
 Writes numeric data to the registry.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>264\</CodeContentPlaceHolder>  
 A string that contains the name of a registry key.  
  
 [in] <CodeContentPlaceHolder>265\</CodeContentPlaceHolder>  
 The data to store.  
  
### Return Value  
 <CodeContentPlaceHolder>266\</CodeContentPlaceHolder> if this method is successful; otherwise <CodeContentPlaceHolder>267\</CodeContentPlaceHolder>.  
  
### Remarks  
 The <CodeContentPlaceHolder>268\</CodeContentPlaceHolder> parameter is the name of a registry entry located under the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](#cwinappex__getregistrybase) and [CWinAppEx::SetRegistryBase](#cwinappex__setregistrybase) respectively.  
  
 If the key specified by <CodeContentPlaceHolder>269\</CodeContentPlaceHolder> does not exist, this method will create it.  
  
##  \<a name="cwinappex__writeobject">\</a>  CWinAppEx::WriteObject  
 Writes data derived from the [CObject Class](../vs140/cobject-class.md) to the registry.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>270\</CodeContentPlaceHolder>  
 A string that contains the value to set.  
  
 [in] <CodeContentPlaceHolder>271\</CodeContentPlaceHolder>  
 A reference to <CodeContentPlaceHolder>272\</CodeContentPlaceHolder> data that the method will store.  
  
### Return Value  
 <CodeContentPlaceHolder>273\</CodeContentPlaceHolder> if this method is successful; otherwise <CodeContentPlaceHolder>274\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method writes the <CodeContentPlaceHolder>275\</CodeContentPlaceHolder> data to the specified value under the default registry key. Use [CWinAppEx::GetRegistryBase](#cwinappex__getregistrybase) to determine the current registry key.  
  
##  \<a name="cwinappex__writesectionbinary">\</a>  CWinAppEx::WriteSectionBinary  
 Writes binary data to a value in the registry.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>276\</CodeContentPlaceHolder>  
 A string that contains the name of a registry key  
  
 [in] <CodeContentPlaceHolder>277\</CodeContentPlaceHolder>  
 A string that contains the value to set.  
  
 [in] <CodeContentPlaceHolder>278\</CodeContentPlaceHolder>  
 The data to write to the registry.  
  
 [in] <CodeContentPlaceHolder>279\</CodeContentPlaceHolder>  
 The size of <CodeContentPlaceHolder>280\</CodeContentPlaceHolder> in bytes.  
  
### Return Value  
 <CodeContentPlaceHolder>281\</CodeContentPlaceHolder> if this method is successful; otherwise <CodeContentPlaceHolder>282\</CodeContentPlaceHolder>.  
  
### Remarks  
 The <CodeContentPlaceHolder>283\</CodeContentPlaceHolder> parameter is not the absolute path for a registry entry. It is a relative path that is appended to the end of the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](#cwinappex__getregistrybase) and [CWinAppEx::SetRegistryBase](#cwinappex__setregistrybase) respectively.  
  
 If the key specified by <CodeContentPlaceHolder>284\</CodeContentPlaceHolder> does not exist, this method will create it.  
  
##  \<a name="cwinappex__writesectionint">\</a>  CWinAppEx::WriteSectionInt  
 Writes numeric data to the registry.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>285\</CodeContentPlaceHolder>  
 A string that contains the relative path of a registry key.  
  
 [in] <CodeContentPlaceHolder>286\</CodeContentPlaceHolder>  
 A string that contains the value to set.  
  
 [in] <CodeContentPlaceHolder>287\</CodeContentPlaceHolder>  
 The data to write to the registry.  
  
### Return Value  
 <CodeContentPlaceHolder>288\</CodeContentPlaceHolder> if this method is successful; otherwise <CodeContentPlaceHolder>289\</CodeContentPlaceHolder>.  
  
### Remarks  
 The <CodeContentPlaceHolder>290\</CodeContentPlaceHolder> parameter is not an absolute path for a registry entry. It is a relative path that is appended to the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](#cwinappex__getregistrybase) and [CWinAppEx::SetRegistryBase](#cwinappex__setregistrybase) respectively.  
  
 If the key specified by <CodeContentPlaceHolder>291\</CodeContentPlaceHolder> does not exist, this method will create it.  
  
##  \<a name="cwinappex__writesectionobject">\</a>  CWinAppEx::WriteSectionObject  
 Writes data derived from the [CObject Class](../vs140/cobject-class.md) to a specific registry value.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>292\</CodeContentPlaceHolder>  
 A string that contains the name of a registry key.  
  
 [in] <CodeContentPlaceHolder>293\</CodeContentPlaceHolder>  
 A string that contains the name of the value to set.  
  
 [in] <CodeContentPlaceHolder>294\</CodeContentPlaceHolder>  
 The data to store.  
  
### Return Value  
 <CodeContentPlaceHolder>295\</CodeContentPlaceHolder> if this method is successful; otherwise <CodeContentPlaceHolder>296\</CodeContentPlaceHolder>.  
  
### Remarks  
 The <CodeContentPlaceHolder>297\</CodeContentPlaceHolder> parameter is not an absolute path for a registry entry. It is a relative path that is appended to the end of the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](#cwinappex__getregistrybase) and [CWinAppEx::SetRegistryBase](#cwinappex__setregistrybase), respectively.  
  
 If the value specified by <CodeContentPlaceHolder>298\</CodeContentPlaceHolder> does not exist under the registry key specified by <CodeContentPlaceHolder>299\</CodeContentPlaceHolder>, this method will create that value.  
  
##  \<a name="cwinappex__writesectionstring">\</a>  CWinAppEx::WriteSectionString  
 Writes string data to a value in the registry.  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>300\</CodeContentPlaceHolder>  
 A string that contains the name of a registry key.  
  
 [in] <CodeContentPlaceHolder>301\</CodeContentPlaceHolder>  
 A string that contains the value to set.  
  
 [in] <CodeContentPlaceHolder>302\</CodeContentPlaceHolder>  
 The string data to write to the registry.  
  
### Return Value  
 <CodeContentPlaceHolder>303\</CodeContentPlaceHolder> if this method is successful; otherwise <CodeContentPlaceHolder>304\</CodeContentPlaceHolder>.  
  
### Remarks  
 The <CodeContentPlaceHolder>305\</CodeContentPlaceHolder> parameter is not an absolute path for a registry entry. It is a relative path that is appended to the end of the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](#cwinappex__getregistrybase) and [CWinAppEx::SetRegistryBase](#cwinappex__setregistrybase), respectively.  
  
 If the value specified by <CodeContentPlaceHolder>306\</CodeContentPlaceHolder> does not exist under <CodeContentPlaceHolder>307\</CodeContentPlaceHolder>, this method will create it.  
  
##  \<a name="cwinappex__writestring">\</a>  CWinAppEx::WriteString  
 Writes string data to the registry.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>308\</CodeContentPlaceHolder>  
 A string that contains the name of a registry key.  
  
 [in] <CodeContentPlaceHolder>309\</CodeContentPlaceHolder>  
 The data to store.  
  
### Return Value  
 <CodeContentPlaceHolder>310\</CodeContentPlaceHolder> if this method is successful; otherwise <CodeContentPlaceHolder>311\</CodeContentPlaceHolder>.  
  
### Remarks  
 The <CodeContentPlaceHolder>312\</CodeContentPlaceHolder> parameter is the name of a registry entry located under the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](#cwinappex__getregistrybase) and [CWinAppEx::SetRegistryBase](#cwinappex__setregistrybase) respectively.  
  
 If the key specified by <CodeContentPlaceHolder>313\</CodeContentPlaceHolder> does not exist, this method will create it.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [CMouseManager Class](../vs140/cmousemanager-class.md)   
 [CContextMenuManager Class](../vs140/ccontextmenumanager-class.md)   
 [CKeyboardManager Class](../vs140/ckeyboardmanager-class.md)   
 [CUserToolsManager Class](../vs140/cusertoolsmanager-class.md)