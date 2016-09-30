---
title: "CComModule Class"
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
  - "CComModule"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComModule class"
  - "DLL modules [C++], ATL"
ms.assetid: f5face2c-8fd8-40e6-9ec3-54ab74701769
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComModule Class
As of ATL 7.0, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is deprecated: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComModule::GetClassObject](../vs140/ccommodule--getclassobject.md)|Creates an object of a specified CLSID. For DLLs only.|  
|[CComModule::GetModuleInstance](../vs140/ccommodule--getmoduleinstance.md)|Returns <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.|  
|[CComModule::GetResourceInstance](../vs140/ccommodule--getresourceinstance.md)|Returns <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.|  
|[CComModule::GetTypeLibInstance](../vs140/ccommodule--gettypelibinstance.md)|Returns <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.|  
|[CComModule::Init](../vs140/ccommodule--init.md)|Initializes data members.|  
|[CComModule::RegisterClassHelper](../vs140/ccommodule--registerclasshelper.md)|Enters an object's standard class registration in the system registry.|  
|[CComModule::RegisterClassObjects](../vs140/ccommodule--registerclassobjects.md)|Registers the class object. For EXEs only.|  
|[CComModule::RegisterServer](../vs140/ccommodule--registerserver.md)|Updates the system registry for each object in the object map.|  
|[CComModule::RegisterTypeLib](../vs140/ccommodule--registertypelib.md)|Registers a type library.|  
|[CComModule::RevokeClassObjects](../vs140/ccommodule--revokeclassobjects.md)|Revokes the class object. For EXEs only.|  
|[CComModule::Term](../vs140/ccommodule--term.md)|Releases data members.|  
|[CComModule::UnregisterClassHelper](../vs140/ccommodule--unregisterclasshelper.md)|Removes an object's standard class registration from the system registry.|  
|[CComModule::UnregisterServer](../vs140/ccommodule--unregisterserver.md)|Unregisters each object in the object map.|  
|[CComModule::UpdateRegistryClass](../vs140/ccommodule--updateregistryclass.md)|Registers or unregisters an object's standard class registration.|  
|[CComModule::UpdateRegistryFromResourceD](../vs140/ccommodule--updateregistryfromresourced.md)|Runs the script contained in a specified resource to register or unregister an object.|  
|[CComModule::UpdateRegistryFromResourceS](../vs140/ccommodule--updateregistryfromresources.md)|Statically links to the ATL Registry Component. Runs the script contained in a specified resource to register or unregister an object.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CComModule::m_csObjMap](../vs140/ccommodule--m_csobjmap.md)|Ensures synchronized access to the object map information.|  
|[CComModule::m_csTypeInfoHolder](../vs140/ccommodule--m_cstypeinfoholder.md)|Ensures synchronized access to the type library information.|  
|[CComModule::m_csWindowCreate](../vs140/ccommodule--m_cswindowcreate.md)|Ensures synchronized access to window class information and static data used during window creation.|  
|[CComModule::m_hInst](../vs140/ccommodule--m_hinst.md)|Contains the handle to the module instance.|  
|[CComModule::m_hInstResource](../vs140/ccommodule--m_hinstresource.md)|By default, contains the handle to the module instance.|  
|[CComModule::m_hInstTypeLib](../vs140/ccommodule--m_hinsttypelib.md)|By default, contains the handle to the module instance.|  
|[CComModule::m_pObjMap](../vs140/ccommodule--m_pobjmap.md)|Points to the object map maintained by the module instance.|  
  
## Remarks  
  
> [!NOTE]
>  This class is deprecated, and the ATL code generation wizards now use the [CAtlAutoThreadModule](../vs140/catlautothreadmodule-class.md) and [CAtlModule](../vs140/catlmodule-class.md) derived classes. See [ATL Module Classes](../vs140/atl-module-classes.md) for more information. The information that follows is for use with applications created with older releases of ATL. <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is still part of ATL for backwards capability.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> implements a COM server module, allowing a client to access the module's components. <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> supports both DLL (in-process) and EXE (local) modules.  
  
 A <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> instance uses an object map to maintain a set of class object definitions. This object map is implemented as an array of <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> structures, and contains information for:  
  
-   Entering and removing object descriptions in the system registry.  
  
-   Instantiating objects through a class factory.  
  
-   Establishing communication between a client and the root object in the component.  
  
-   Performing lifetime management of class objects.  
  
 When you run the ATL COM AppWizard, the wizard automatically generates <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, a global instance of <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> or a class derived from it. For more information about the ATL Project Wizard, see the article [Creating an ATL Project](../vs140/creating-an-atl-project.md).  
  
 In addition to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, ATL provides [CComAutoThreadModule](../vs140/ccomautothreadmodule-class.md), which implements an apartment-model module for EXEs and Windows services. Derive your module from <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> when you want to create objects in multiple apartments.  
  
## Inheritance Hierarchy  
 [_ATL_MODULE](../vs140/_atl_module.md)  
  
 [CAtlModule](../vs140/catlmodule-class.md)  
  
 [CAtlModuleT](../vs140/catlmodulet-class.md)  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
  
## Requirements  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> atlbase.h  
  
##  \<a name="ccommodule__getclassobject">\</a>  CComModule::GetClassObject  
 As of ATL 7.0, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 [in] The CLSID of the object to be created.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 [in] The IID of the requested interface.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 [out] A pointer to the interface pointer identified by <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>. If the object does not support this interface, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is set to **NULL**.  
  
### Return Value  
 A standard HRESULT value.  
  
### Remarks  
 Creates an object of the specified CLSID and retrieves an interface pointer to this object.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> is only available to DLLs.  
  
##  \<a name="ccommodule__getmoduleinstance">\</a>  CComModule::GetModuleInstance  
 As of ATL 7.0, <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 The <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> identifying this module.  
  
### Remarks  
 Returns the [m_hInst](../vs140/ccommodule--m_hinst.md) data member.  
  
##  \<a name="ccommodule__getresourceinstance">\</a>  CComModule::GetResourceInstance  
 As of ATL 7.0, <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 An <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  
  
### Remarks  
 Returns the [m_hInstResource](../vs140/ccommodule--m_hinstresource.md) data member.  
  
##  \<a name="ccommodule__gettypelibinstance">\</a>  CComModule::GetTypeLibInstance  
 As of ATL 7.0, <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 An <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
### Remarks  
 Returns the [m_hInstTypeLib](../vs140/ccommodule--m_hinsttypelib.md) data member.  
  
##  \<a name="ccommodule__init">\</a>  CComModule::Init  
 As of ATL 7.0, <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 [in] A pointer to an array of object map entries.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 [in] The <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> passed to **DLLMain** or <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 [in] A pointer to the LIBID of the type library associated with the project.  
  
### Return Value  
 A standard HRESULT value.  
  
### Remarks  
 Initializes all data members.  
  
##  \<a name="ccommodule__m_csobjmap">\</a>  CComModule::m_csObjMap  
 As of ATL 7.0, <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 Ensures synchronized access to the object map.  
  
##  \<a name="ccommodule__m_cstypeinfoholder">\</a>  CComModule::m_csTypeInfoHolder  
 As of ATL 7.0, <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 Ensures synchronized access to the type library.  
  
##  \<a name="ccommodule__m_cswindowcreate">\</a>  CComModule::m_csWindowCreate  
 As of ATL 7.0, <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
 Ensures synchronized access to window class information and to static data used during window creation.  
  
##  \<a name="ccommodule__m_hinst">\</a>  CComModule::m_hInst  
 As of ATL 7.0, <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 Contains the handle to the module instance.  
  
 The [Init](../vs140/ccommodule--init.md) method sets <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> to the handle passed to **DLLMain** or <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>.  
  
##  \<a name="ccommodule__m_hinstresource">\</a>  CComModule::m_hInstResource  
 As of ATL 7.0, <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 By default, contains the handle to the module instance.  
  
 The [Init](../vs140/ccommodule--init.md) method sets <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> to the handle passed to **DLLMain** or <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>. You can explicitly set <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> to the handle to a resource.  
  
 The [GetResourceInstance](../vs140/ccommodule--getresourceinstance.md) method returns the handle stored in <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>.  
  
##  \<a name="ccommodule__m_hinsttypelib">\</a>  CComModule::m_hInstTypeLib  
 As of ATL 7.0, <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 By default, contains the handle to the module instance.  
  
 The [Init](../vs140/ccommodule--init.md) method sets <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> to the handle passed to **DLLMain** or <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>. You can explicitly set <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> to the handle to a type library.  
  
 The [GetTypeLibInstance](../vs140/ccommodule--gettypelibinstance.md) method returns the handle stored in <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>.  
  
##  \<a name="ccommodule__m_pobjmap">\</a>  CComModule::m_pObjMap  
 As of ATL 7.0, <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Remarks  
 Points to the object map maintained by the module instance.  
  
##  \<a name="ccommodule__registerclasshelper">\</a>  CComModule::RegisterClassHelper  
 As of ATL 7.0, <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 [in] The CLSID of the object to be registered.  
  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 [in] The ProgID associated with the object.  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 [in] The version-independent ProgID associated with the object.  
  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 [in] The identifier of a string resource for the object's description.  
  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 [in] Specifies the threading model to enter in the registry. Possible values are **THREADFLAGS_APARTMENT**,                                 **THREADFLAGS_BOTH**, or **AUTPRXFLAG**.  
  
### Return Value  
 A standard HRESULT value.  
  
### Remarks  
 Enters an object's standard class registration in the system registry.  
  
 The [UpdateRegistryClass](../vs140/ccommodule--updateregistryclass.md) method calls <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>.  
  
##  \<a name="ccommodule__registerclassobjects">\</a>  CComModule::RegisterClassObjects  
 As of ATL 7.0, <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 [in] Specifies the context in which the class object is to be run. Possible values are **CLSCTX_INPROC_SERVER**,                                 **CLSCTX_INPROC_HANDLER**, or **CLSCTX_LOCAL_SERVER**. For a description of these values, see [CLSCTX](http://msdn.microsoft.com/library/windows/desktop/ms693716) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 [in] Determines the connection types to the class object. Possible values are **REGCLS_SINGLEUSE**,                                 **REGCLS_MULTIPLEUSE**, or **REGCLS_MULTI_SEPARATE**. For a description of these values, see [REGCLS](http://msdn.microsoft.com/library/windows/desktop/ms679697) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Return Value  
 A standard HRESULT value.  
  
### Remarks  
 Registers an EXE class object with OLE so other applications can connect to it. This method                        is only available to EXEs.  
  
##  \<a name="ccommodule__registerserver">\</a>  CComModule::RegisterServer  
 As of ATL 7.0, <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 [in] Indicates whether the type library will be registered. The default value is **FALSE**.  
  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 [in] Points to the CLSID of the object to be registered. If **NULL** (the default value), all objects in the object map will be registered.  
  
### Return Value  
 A standard HRESULT value.  
  
### Remarks  
 Depending on the <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> parameter, updates the system registry for a single class object or for all objects in the object map.  
  
 If <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> is **TRUE**, the type library information will also be updated.  
  
 See [OBJECT_ENTRY_AUTO](../vs140/object_entry_auto.md) for information on how to add an entry to the object map.  
  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> will be called automatically by **DLLRegisterServer** for a DLL or by <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> for an EXE run with the **/RegServer** command line option.  
  
##  \<a name="ccommodule__registertypelib">\</a>  CComModule::RegisterTypeLib  
 As of ATL 7.0, <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 [in] String in the format <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> is the integer index of the TYPELIB resource.  
  
### Return Value  
 A standard HRESULT value.  
  
### Remarks  
 Adds information about a type library to the system registry.  
  
 If the module instance contains multiple type libraries, use the second version of this method to specify which type library should be used.  
  
##  \<a name="ccommodule__revokeclassobjects">\</a>  CComModule::RevokeClassObjects  
 As of ATL 7.0, <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 A standard HRESULT value.  
  
### Remarks  
 Removes the class object. This method                        is only available to EXEs.  
  
##  \<a name="ccommodule__term">\</a>  CComModule::Term  
 As of ATL 7.0, <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Remarks  
 Releases all data members.  
  
##  \<a name="ccommodule__unregisterclasshelper">\</a>  CComModule::UnregisterClassHelper  
 As of ATL 7.0, <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 [in] The CLSID of the object to be unregistered.  
  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 [in] The ProgID associated with the object.  
  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 [in] The version-independent ProgID associated with the object.  
  
### Return Value  
 A standard HRESULT value.  
  
### Remarks  
 Removes an object's standard class registration from the system registry.  
  
 The [UpdateRegistryClass](../vs140/ccommodule--updateregistryclass.md) method calls <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>.  
  
##  \<a name="ccommodule__unregisterserver">\</a>  CComModule::UnregisterServer  
 As of ATL 7.0, <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
 If **TRUE**, the type library is also unregistered.  
  
 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
 Points to the CLSID of the object to be unregistered. If **NULL** (the default value), all objects in the object map will be unregistered.  
  
### Return Value  
 A standard HRESULT value.  
  
### Remarks  
 Depending on the <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> parameter, unregisters either a single class object or all objects in the object map.  
  
 <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> will be called automatically by **DLLUnregisterServer** for a DLL or by <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> for an EXE run with the **/UnregServer** command line option.  
  
 See [OBJECT_ENTRY_AUTO](../vs140/object_entry_auto.md) for information on how to add an entry to the object map.  
  
##  \<a name="ccommodule__updateregistryclass">\</a>  CComModule::UpdateRegistryClass  
 As of ATL 7.0, <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 The CLSID of the object to be registered or unregistered.  
  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 The ProgID associated with the object.  
  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
 The version-independent ProgID associated with the object.  
  
 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
 The identifier of the string resource for the object's description.  
  
 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
 A string containing the object's description.  
  
 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
 Specifies the threading model to enter in the registry. Possible values are **THREADFLAGS_APARTMENT**,                                 **THREADFLAGS_BOTH**, or **AUTPRXFLAG**.  
  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
 Indicates whether the object should be registered.  
  
### Return Value  
 A standard HRESULT value.  
  
### Remarks  
 If <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> is **TRUE**, this method enters the object's standard class registration in the system registry.  
  
 If <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> is **FALSE**, it removes the object's registration.  
  
 Depending on the value of <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> calls either [RegisterClassHelper](../vs140/ccommodule--registerclasshelper.md) or [UnregisterClassHelper](../vs140/ccommodule--unregisterclasshelper.md).  
  
 By specifying the [DECLARE_REGISTRY](../vs140/declare_registry.md) macro, <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> will be invoked automatically when your object map is processed.  
  
##  \<a name="ccommodule__updateregistryfromresourced">\</a>  CComModule::UpdateRegistryFromResourceD  
 As of ATL 7.0, <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
 [in] A resource name.  
  
 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
 [in] A resource ID.  
  
 <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
 [in] Indicates whether the object should be registered.  
  
 <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
 [in] A pointer to the replacement map storing values associated with the script's replaceable parameters. ATL automatically uses <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>. To use additional replaceable parameters, see the Remarks for details. Otherwise, use the **NULL** default value.  
  
### Return Value  
 A standard HRESULT value.  
  
### Remarks  
 Runs the script contained in the resource specified by <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> is **TRUE**, this method registers the object in the system registry; otherwise, it unregisters the object.  
  
 By specifying the [DECLARE_REGISTRY_RESOURCE](../vs140/declare_registry_resource.md) or [DECLARE_REGISTRY_RESOURCEID](../vs140/declare_registry_resourceid.md) macro, <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> will be invoked automatically when your object map is processed.  
  
> [!NOTE]
>  To substitute replacement values at run time, do not specify the <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> macro. Instead, create an array of **_ATL_REGMAP_ENTRIES** structures, where each entry contains a variable placeholder paired with a value to replace the placeholder at run time. Then call <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>, passing the array for the <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> parameter. This adds all the replacement values in the **_ATL_REGMAP_ENTRIES** structures to the Registrar's replacement map.  
  
> [!NOTE]
>  To statically link to the ATL Registry Component (Registrar), see [UpdateRegistryFromResourceS](../vs140/ccommodule--updateregistryfromresources.md).  
  
 For more information about replaceable parameters and scripting, see the article [The ATL Registry Component (Registrar)](../vs140/atl-registry-component--registrar-.md).  
  
##  \<a name="ccommodule__updateregistryfromresources">\</a>  CComModule::UpdateRegistryFromResourceS  
 As of ATL 7.0, <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
 [in] A resource name.  
  
 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
 [in] A resource ID.  
  
 <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
 [in] Indicates whether the resource script should be registered.  
  
 <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
 [in] A pointer to the replacement map storing values associated with the script's replaceable parameters. ATL automatically uses <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>. To use additional replaceable parameters, see the Remarks for details. Otherwise, use the **NULL** default value.  
  
### Return Value  
 A standard HRESULT value.  
  
### Remarks  
 Similar to [UpdateRegistryFromResourceD](../vs140/ccommodule--updateregistryfromresourced.md) except <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> creates a static link to the ATL Registry Component (Registrar).  
  
 <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> will be invoked automatically when your object map is processed, provided you add <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> to your stdafx.h.  
  
> [!NOTE]
>  To substitute replacement values at run time, do not specify the [DECLARE_REGISTRY_RESOURCE](../vs140/declare_registry_resource.md) or [DECLARE_REGISTRY_RESOURCEID](../vs140/declare_registry_resourceid.md) macro. Instead, create an array of **_ATL_REGMAP_ENTRIES** structures, where each entry contains a variable placeholder paired with a value to replace the placeholder at run time. Then call <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>, passing the array for the <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> parameter. This adds all the replacement values in the **_ATL_REGMAP_ENTRIES** structures to the Registrar's replacement map.  
  
 For more information about replaceable parameters and scripting, see the article [The ATL Registry Component (Registrar)](../vs140/atl-registry-component--registrar-.md).  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)