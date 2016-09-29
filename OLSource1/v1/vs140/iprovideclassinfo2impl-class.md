---
title: "IProvideClassInfo2Impl Class"
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
  - "IProvideClassInfo2"
  - "ATL.IProvideClassInfo2Impl"
  - "IProvideClassInfo2Impl"
  - "ATL::IProvideClassInfo2Impl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IProvideClassInfo2Impl class"
  - "IProvideClassInfo2 ATL implementation"
  - "class information, ATL"
ms.assetid: d74956e8-9c69-4cba-b99d-ca1ac031bb9d
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IProvideClassInfo2Impl Class
This class provides a default implementation of the [IProvideClassInfo](http://msdn.microsoft.com/library/windows/desktop/ms687303) and [IProvideClassInfo2](http://msdn.microsoft.com/library/windows/desktop/ms693764) methods.  
  
## Syntax  
  
```  
  
template <  
      const CLSID*  pcoclsid,  
      const IID*  psrcid,  
      const GUID*  plibid  
    = &CAtlModule::m_libid,  
      WORD  wMajor  
    = 1,  
      WORD  wMinor  
    = 0,  
      class  tihclass  
    = CComTypeInfoHolder >  
   class ATL_NO_VTABLE IProvideClassInfo2Impl :  
      public IProvideClassInfo2  
  
```  
  
#### Parameters  
 *pcoclsid*  
 A pointer to the coclass' identifier.  
  
 *psrcid*  
 A pointer to the identifier for the coclass' default outgoing dispinterface.  
  
 `plibid`  
 A pointer to the LIBID of the type library that contains information about the interface. By default, the server-level type library is passed.  
  
 `wMajor`  
 The major version of the type library. The default value is 1.  
  
 `wMinor`  
 The minor version of the type library. The default value is 0.  
  
 `tihclass`  
 The class used to manage the coclass' type information. The default value is `CComTypeInfoHolder`.  
  
## Members  
  
### Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[IProvideClassInfo2Impl::IProvideClassInfo2Impl](../vs140/iprovideclassinfo2impl--iprovideclassinfo2impl.md)|Constructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IProvideClassInfo2Impl::GetClassInfo](../vs140/iprovideclassinfo2impl--getclassinfo.md)|Retrieves an **ITypeInfo** pointer to the coclass' type information.|  
|[IProvideClassInfo2Impl::GetGUID](../vs140/iprovideclassinfo2impl--getguid.md)|Retrieves the GUID for the object's outgoing dispinterface.|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[IProvideClassInfo2Impl::_tih](../vs140/iprovideclassinfo2impl--_tih.md)|Manages the type information for the coclass.|  
  
## Remarks  
 The [IProvideClassInfo2](http://msdn.microsoft.com/library/windows/desktop/ms693764) interface extends [IProvideClassInfo](http://msdn.microsoft.com/library/windows/desktop/ms687303) by adding the `GetGUID` method. This method allows a client to retrieve an object's outgoing interface IID for its default event set. Class `IProvideClassInfo2Impl` provides a default implementation of the **IProvideClassInfo** and `IProvideClassInfo2` methods.  
  
 `IProvideClassInfo2Impl` contains a static member of type `CComTypeInfoHolder` that manages the type information for the coclass.  
  
## Inheritance Hierarchy  
 `IProvideClassInfo2`  
  
 `IProvideClassInfo2Impl`  
  
## Requirements  
 **Header:** atlcom.h  
  
##  <a name="iprovideclassinfo2impl__getclassinfo"></a>  IProvideClassInfo2Impl::GetClassInfo  
 Retrieves an `ITypeInfo` pointer to the coclass' type information.  
  
```  
  
STDMETHOD(GetClassInfo)(  
      ITypeInfo**  pptinfo  
   );  
  
```  
  
### Remarks  
 See [IProvideClassInfo::GetClassInfo](http://msdn.microsoft.com/library/windows/desktop/ms690192) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  <a name="iprovideclassinfo2impl__getguid"></a>  IProvideClassInfo2Impl::GetGUID  
 Retrieves the GUID for the object's outgoing dispinterface.  
  
```  
  
STDMETHOD(GetGUID)(  
      DWORD  dwGuidKind,  
      GUID*  pGUID  
   );  
  
```  
  
### Remarks  
 See [IProvideClassInfo2::GetGUID](http://msdn.microsoft.com/library/windows/desktop/ms679721) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  <a name="iprovideclassinfo2impl__iprovideclassinfo2impl"></a>  IProvideClassInfo2Impl::IProvideClassInfo2Impl  
 The constructor.  
  
```  
  
IProvideClassInfo2Impl( );  
  
```  
  
### Remarks  
 Calls `AddRef` on the [_tih](../vs140/iprovideclassinfo2impl--_tih.md) member. The destructor calls **Release**.  
  
##  <a name="iprovideclassinfo2impl___tih"></a>  IProvideClassInfo2Impl::_tih  
 This static data member is an instance of the class template parameter, `tihclass`, which by default is `CComTypeInfoHolder`.  
  
```  
  
static  tihclass  
    _tih;  
  
```  
  
### Remarks  
 `_tih` manages the type information for the coclass.  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)