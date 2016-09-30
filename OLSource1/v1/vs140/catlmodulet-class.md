---
title: "CAtlModuleT Class"
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
  - "ATL::CAtlModuleT<T>"
  - "ATL.CAtlModuleT"
  - "ATL.CAtlModuleT<T>"
  - "ATL::CAtlModuleT"
  - "CAtlModuleT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAtlModuleT class"
ms.assetid: 9b74d02f-9117-47b1-a05e-c5945f83dd2b
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlModuleT Class
This class implements an ATL module.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Your class derived from <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlModuleT::CAtlModuleT](../vs140/catlmodulet--catlmodulet.md)|The constructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlModuleT::InitLibId](../vs140/catlmodulet--initlibid.md)|Initializes the data member containing the GUID of the current module.|  
|[CAtlModuleT::RegisterAppId](../vs140/catlmodulet--registerappid.md)|Adds the EXE to the registry.|  
|[CAtlModuleT::RegisterServer](../vs140/catlmodulet--registerserver.md)|Adds the service to the registry.|  
|[CAtlModuleT::UnregisterAppId](../vs140/catlmodulet--unregisterappid.md)|Removes the EXE from the registry.|  
|[CAtlModuleT::UnregisterServer](../vs140/catlmodulet--unregisterserver.md)|Removes the service from the registry.|  
|[CAtlModuleT::UpdateRegistryAppId](../vs140/catlmodulet--updateregistryappid.md)|Updates the EXE information in the registry.|  
  
## Remarks  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, derived from [CAtlModule](../vs140/catlmodule-class.md), implements an Executable (EXE) or a Service (EXE) ATL module. An Executable module is a local, out-of-process server, whereas a Service module is a Windows application that runs in the background when Windows starts.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> provides support for initializing, registering, and unregistering of the module.  
  
## Inheritance Hierarchy  
 [_ATL_MODULE](../vs140/_atl_module.md)  
  
 [CAtlModule](../vs140/catlmodule-class.md)  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlbase.h  
  
##  \<a name="catlmodulet__catlmodulet">\</a>  CAtlModuleT::CAtlModuleT  
 The constructor.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 Calls [CAtlModuleT::InitLibId](../vs140/catlmodulet--initlibid.md).  
  
##  \<a name="catlmodulet__initlibid">\</a>  CAtlModuleT::InitLibId  
 Initializes the data member containing the GUID of the current module.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 Called by the constructor [CAtlModuleT::CAtlModuleT](../vs140/catlmodulet--catlmodulet.md).  
  
##  \<a name="catlmodulet__registerappid">\</a>  CAtlModuleT::RegisterAppId  
 Adds the EXE to the registry.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="catlmodulet__registerserver">\</a>  CAtlModuleT::RegisterServer  
 Adds the service to the registry.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 TRUE if the type library is to be registered. The default value is FALSE.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Points to the CLSID of the object to be registered. If NULL (the default value), all objects in the object map will be registered.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="catlmodulet__unregisterappid">\</a>  CAtlModuleT::UnregisterAppId  
 Removes the EXE from the registry.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="catlmodulet__unregisterserver">\</a>  CAtlModuleT::UnregisterServer  
 Removes the service from the registry.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 TRUE if the type library is also to be unregistered.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Points to the CLSID of the object to be unregistered. If NULL (the default value), all objects in the object map will be unregistered.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="catlmodulet__updateregistryappid">\</a>  CAtlModuleT::UpdateRegistryAppId  
 Updates the EXE information in the registry.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Reserved.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## See Also  
 [CAtlModule Class](../vs140/catlmodule-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)   
 [Module Classes](../vs140/atl-module-classes.md)