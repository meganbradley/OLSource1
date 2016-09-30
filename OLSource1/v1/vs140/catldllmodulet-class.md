---
title: "CAtlDllModuleT Class"
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
  - "ATL.CAtlDllModuleT"
  - "ATL::CAtlDllModuleT<T>"
  - "ATL::CAtlDllModuleT"
  - "ATL.CAtlDllModuleT<T>"
  - "CAtlDllModuleT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAtlDllModuleT class"
ms.assetid: 351d5767-8257-4878-94be-45a85e31a72d
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlDllModuleT Class
This class represents the module for a DLL.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Your class derived from <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlDllModuleT::CAtlDllModuleT](../vs140/catldllmodulet--catldllmodulet.md)|The constructor.|  
|[CAtlDllModuleT::~CAtlDllModuleT](../vs140/catldllmodulet--~catldllmodulet.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlDllModuleT::DllCanUnloadNow](../vs140/catldllmodulet--dllcanunloadnow.md)|Tests if the DLL can be unloaded.|  
|[CAtlDllModuleT::DllGetClassObject](../vs140/catldllmodulet--dllgetclassobject.md)|Returns a class factory.|  
|[CAtlDllModuleT::DllMain](../vs140/catldllmodulet--dllmain.md)|The optional entry point into a dynamic-link library (DLL).|  
|[CAtlDllModuleT::DllRegisterServer](../vs140/catldllmodulet--dllregisterserver.md)|Adds entries to the system registry for objects in the DLL.|  
|[CAtlDllModuleT::DllUnregisterServer](../vs140/catldllmodulet--dllunregisterserver.md)|Removes entries in the system registry for objects in the DLL.|  
|[CAtlDllModuleT::GetClassObject](../vs140/catldllmodulet--getclassobject.md)|Returns a class factory. Invoked by [DllGetClassObject](../vs140/catldllmodulet--dllgetclassobject.md).|  
  
## Remarks  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> represents the module for a dynamic-link library (DLL) and provides functions used by all DLL projects. This specialization of [CAtlModuleT](../vs140/catlmodulet-class.md) class includes support for registration.  
  
 For more information on modules in ATL, see [ATL Module Classes](../vs140/atl-module-classes.md).  
  
## Inheritance Hierarchy  
 [_ATL_MODULE](../vs140/_atl_module.md)  
  
 [CAtlModule](../vs140/catlmodule-class.md)  
  
 [CAtlModuleT](../vs140/catlmodulet-class.md)  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlbase.h  
  
##  \<a name="catldllmodulet__catldllmodulet">\</a>  CAtlDllModuleT::CAtlDllModuleT  
 The constructor.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="catldllmodulet___dtorcatldllmodulet">\</a>  CAtlDllModuleT::~CAtlDllModuleT  
 The destructor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="catldllmodulet__dllcanunloadnow">\</a>  CAtlDllModuleT::DllCanUnloadNow  
 Tests if the DLL can be unloaded.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 Returns S_OK if the DLL can be unloaded, or S_FALSE if it cannot.  
  
##  \<a name="catldllmodulet__dllgetclassobject">\</a>  CAtlDllModuleT::DllGetClassObject  
 Returns the class factory.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The CLSID of the object to be created.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The IID of the requested interface.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 A pointer to the interface pointer identified by <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. If the object does not support this interface, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is set to NULL.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="catldllmodulet__dllmain">\</a>  CAtlDllModuleT::DllMain  
 The optional entry point into a dynamic-link library (DLL).  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 If set to DLL_PROCESS_ATTACH, the DLL_THREAD_ATTACH and DLL_THREAD_DETACH notification calls are disabled.  
  
 *lpReserved*  
 Reserved.  
  
### Return Value  
 Always returns TRUE.  
  
### Remarks  
 Disabling the DLL_THREAD_ATTACH and DLL_THREAD_DETACH notification calls can be a useful optimization for multithreaded applications that have many DLLs, that frequently create and delete threads, and whose DLLs do not need these thread-level notifications of attachment/detachment.  
  
##  \<a name="catldllmodulet__dllregisterserver">\</a>  CAtlDllModuleT::DllRegisterServer  
 Adds entries to the system registry for objects in the DLL.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 TRUE if the type library is to be registered. The default value is TRUE.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="catldllmodulet__dllunregisterserver">\</a>  CAtlDllModuleT::DllUnregisterServer  
 Removes entries in the system registry for objects in the DLL.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 TRUE if the type library is to be removed from the registry. The default value is TRUE.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="catldllmodulet__getclassobject">\</a>  CAtlDllModuleT::GetClassObject  
 Creates an object of the specified CLSID.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 The CLSID of the object to be created.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The IID of the requested interface.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 A pointer to the interface pointer identified by <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. If the object does not support this interface, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is set to NULL.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method is called by [CAtlDllModuleT::DllGetClassObject](../vs140/catldllmodulet--dllgetclassobject.md) and is included for backward compatibility.  
  
## See Also  
 [CAtlModuleT Class](../vs140/catlmodulet-class.md)   
 [CAtlExeModuleT Class](../vs140/catlexemodulet-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)   
 [Module Classes](../vs140/atl-module-classes.md)