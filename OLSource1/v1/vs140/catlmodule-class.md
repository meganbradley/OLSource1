---
title: "CAtlModule Class"
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
  - "ATL::CAtlModule"
  - "CAtlModule"
  - "ATL.CAtlModule"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAtlModule class"
ms.assetid: 63fe02f1-4c4b-4e7c-ae97-7ad7b4252415
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlModule Class
This class provides methods used by several ATL module classes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlModule::CAtlModule](../vs140/catlmodule--catlmodule.md)|The constructor.|  
|[CAtlModule::~CAtlModule](../vs140/catlmodule--~catlmodule.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlModule::AddCommonRGSReplacements](../vs140/catlmodule--addcommonrgsreplacements.md)|Override this method to add parameters to the ATL Registry Component (Registrar) replacement map.|  
|[CAtlModule::AddTermFunc](../vs140/catlmodule--addtermfunc.md)|Adds a new function to be called when the module terminates.|  
|[CAtlModule::GetGITPtr](../vs140/catlmodule--getgitptr.md)|Returns the Global Interface Pointer.|  
|[CAtlModule::GetLockCount](../vs140/catlmodule--getlockcount.md)|Returns the lock count.|  
|[CAtlModule::Lock](../vs140/catlmodule--lock.md)|Increments the lock count.|  
|[CAtlModule::Term](../vs140/catlmodule--term.md)|Releases all data members.|  
|[CAtlModule::Unlock](../vs140/catlmodule--unlock.md)|Decrements the lock count.|  
|[CAtlModule::UpdateRegistryFromResourceD](../vs140/catlmodule--updateregistryfromresourced.md)|Runs the script contained in a specified resource to register or unregister an object.|  
|[CAtlModule::UpdateRegistryFromResourceDHelper](../vs140/catlmodule--updateregistryfromresourcedhelper.md)|This method is called by <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to perform the registry update.|  
|[CAtlModule::UpdateRegistryFromResourceS](../vs140/catlmodule--updateregistryfromresources.md)|Runs the script contained in a specified resource to register or unregister an object. This method statically links to the ATL Registry Component.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlModule::m_libid](../vs140/catlmodule--m_libid.md)|Contains the GUID of the current module.|  
|[CAtlModule::m_pGIT](../vs140/catlmodule--m_pgit.md)|Pointer to the Global Interface Table.|  
  
## Remarks  
 This class is used by [CAtlDllModuleT Class](../vs140/catldllmodulet-class.md), [CAtlExeModuleT Class](../vs140/catlexemodulet-class.md), and [CAtlServiceModuleT Class](../vs140/catlservicemodulet-class.md) to provide support for DLL applications, EXE applications, and Windows services, respectively.  
  
 For more information on modules in ATL, see [ATL Module Classes](../vs140/atl-module-classes.md).  
  
 This class replaces the obsolete [CComModule Class](../vs140/ccommodule-class.md) used in earlier versions of ATL.  
  
## Inheritance Hierarchy  
 [_ATL_MODULE](../vs140/_atl_module.md)  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlbase.h  
  
##  \<a name="catlmodule__addcommonrgsreplacements">\</a>  CAtlModule::AddCommonRGSReplacements  
 Override this method to add parameters to the ATL Registry Component (Registrar) replacement map.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 *pRegistrar*  
 Reserved.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 Replaceable parameters allow a Registrar's client to specify run-time data. To do this, the Registrar maintains a replacement map into which it enters the values associated with the replaceable parameters in your script. The Registrar makes these entries at run time.  
  
 See the topic [Using Replaceable Parameters (The Registrar's Preprocessor)](../vs140/using-replaceable-parameters--the-registrar-s-preprocessor-.md) for more details.  
  
##  \<a name="catlmodule__addtermfunc">\</a>  CAtlModule::AddTermFunc  
 Adds a new function to be called when the module terminates.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 *pFunc*  
 Pointer to the function to add.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 User-defined data, passed to the function.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="catlmodule__catlmodule">\</a>  CAtlModule::CAtlModule  
 The constructor.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 Initializes data members and initiates a critical section around the module's thread.  
  
##  \<a name="catlmodule___dtorcatlmodule">\</a>  CAtlModule::~CAtlModule  
 The destructor.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 Releases all data members.  
  
##  \<a name="catlmodule__getgitptr">\</a>  CAtlModule::GetGITPtr  
 Retrieves a pointer to the Global Interface Table.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 Pointer to the variable which will receive the pointer to the Global Interface Table.  
  
### Return Value  
 Returns S_OK on success, or an error code on failure. E_POINTER is returned if <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is equal to NULL.  
  
### Remarks  
 If the Global Interface Table object does not exist, it is created, and its address is stored in the member variable [CAtlModule::m_pGIT](../vs140/catlmodule--m_pgit.md).  
  
 In debug builds, an assertion error will occur if <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is equal to NULL, or if the Global Interface Table pointer cannot be obtained.  
  
 See [IGlobalInterfaceTable](http://msdn.microsoft.com/library/windows/desktop/ms678517) for information on the Global Interface Table.  
  
##  \<a name="catlmodule__getlockcount">\</a>  CAtlModule::GetLockCount  
 Returns the lock count.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Returns the lock count. This value may be useful for diagnostics and debugging.  
  
##  \<a name="catlmodule__lock">\</a>  CAtlModule::Lock  
 Increments the lock count.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 Increments the lock count and returns the updated value. This value may be useful for diagnostics and debugging.  
  
##  \<a name="catlmodule__m_libid">\</a>  CAtlModule::m_libid  
 Contains the GUID of the current module.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
##  \<a name="catlmodule__m_pgit">\</a>  CAtlModule::m_pGIT  
 Pointer to the Global Interface Table.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
##  \<a name="catlmodule__term">\</a>  CAtlModule::Term  
 Releases all data members.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 Releases all data members. This method is called by the destructor.  
  
##  \<a name="catlmodule__unlock">\</a>  CAtlModule::Unlock  
 Decrements the lock count.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 Decrements the lock count and returns the updated value. This value may be useful for diagnostics and debugging.  
  
##  \<a name="catlmodule__updateregistryfromresourced">\</a>  CAtlModule::UpdateRegistryFromResourceD  
 Runs the script contained in a specified resource to register or unregister an object.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 A resource name.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 A resource ID.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 **TRUE** if the object should be registered;                                 **FALSE** otherwise.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 A pointer to the replacement map storing values associated with the script's replaceable parameters. ATL automatically uses %MODULE%. To use additional replaceable parameters, see [CAtlModule::AddCommonRGSReplacements](../vs140/catlmodule--addcommonrgsreplacements.md). Otherwise, use the **NULL** default value.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 Runs the script contained in the resource specified by *lpszRes or nResID*. If <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is **TRUE**, this method registers the object in the system registry; otherwise it removes the object from the registry.  
  
 To statically link to the ATL Registry Component (Registrar), see [CAtlModule::UpdateRegistryFromResourceS](../vs140/catlmodule--updateregistryfromresources.md).  
  
 This method calls [CAtlModule::UpdateRegistryFromResourceDHelper](../vs140/catlmodule--updateregistryfromresourcedhelper.md).  
  
##  \<a name="catlmodule__updateregistryfromresourcedhelper">\</a>  CAtlModule::UpdateRegistryFromResourceDHelper  
 This method is called by <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> to perform the registry update.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 A resource name.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Indicates whether the object should be registered.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 A pointer to the replacement map storing values associated with the script's replaceable parameters. ATL automatically uses %MODULE%. To use additional replaceable parameters, see [CAtlModule::AddCommonRGSReplacements](../vs140/catlmodule--addcommonrgsreplacements.md). Otherwise, use the **NULL** default value.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method provides the implementation of [CAtlModule::UpdateRegistryFromResourceD](../vs140/catlmodule--updateregistryfromresourced.md).  
  
##  \<a name="catlmodule__updateregistryfromresources">\</a>  CAtlModule::UpdateRegistryFromResourceS  
 Runs the script contained in a specified resource to register or unregister an object. This method statically links to the ATL Registry Component.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 A resource ID.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 A resource name.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 Indicates whether the resource script should be registered.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 A pointer to the replacement map storing values associated with the script's replaceable parameters. ATL automatically uses %MODULE%. To use additional replaceable parameters, see [CAtlModule::AddCommonRGSReplacements](../vs140/catlmodule--addcommonrgsreplacements.md). Otherwise, use the **NULL** default value.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 Similar to [CAtlModule::UpdateRegistryFromResourceD](../vs140/catlmodule--updateregistryfromresourced.md) except <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> creates a static link to the ATL Registry Component (Registrar).  
  
## See Also  
 [_ATL_MODULE](../vs140/_atl_module.md)   
 [Class Overview](../vs140/atl-class-overview.md)   
 [Module Classes](../vs140/atl-module-classes.md)   
 [Registry Component (Registrar)](../vs140/atl-registry-component--registrar-.md)