---
title: "IPersistPropertyBagImpl Class"
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
  - "IPersistPropertyBagImpl"
  - "ATL.IPersistPropertyBagImpl<T>"
  - "ATL::IPersistPropertyBagImpl"
  - "ATL::IPersistPropertyBagImpl<T>"
  - "ATL.IPersistPropertyBagImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IPersistPropertyBagImpl class"
ms.assetid: 712af24d-99f8-40f2-9811-53b3ff6e5b19
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IPersistPropertyBagImpl Class
This class implements **IUnknown** and allows an object to save its properties to a client-supplied property bag.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
template <   
   class  T>  
   class ATL_NO_VTABLE IPersistPropertyBagImpl :  
   public IPersistPropertyBag  
  
```  
  
#### Parameters  
 `T`  
 Your class, derived from `IPersistPropertyBagImpl`.  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IPersistPropertyBagImpl::GetClassID](../vs140/ipersistpropertybagimpl--getclassid.md)|Retrieves the object's CLSID.|  
|[IPersistPropertyBagImpl::InitNew](../vs140/ipersistpropertybagimpl--initnew.md)|Initializes a newly created object. The ATL implementation returns `S_OK`.|  
|[IPersistPropertyBagImpl::Load](../vs140/ipersistpropertybagimpl--load.md)|Loads the object's properties from a client-supplied property bag.|  
|[IPersistPropertyBagImpl::Save](../vs140/ipersistpropertybagimpl--save.md)|Saves the object's properties into a client-supplied property bag.|  
  
## Remarks  
 The [IPersistPropertyBag](https://msdn.microsoft.com/en-us/library/aa768205.aspx) interface allows an object to save its properties to a client-supplied property bag. Class `IPersistPropertyBagImpl` provides a default implementation of this interface and implements **IUnknown** by sending information to the dump device in debug builds.  
  
 **IPersistPropertyBag** works in conjunction with [IPropertyBag](https://msdn.microsoft.com/en-us/library/aa768196.aspx) and [IErrorLog](https://msdn.microsoft.com/en-us/library/aa768231.aspx). These latter two interfaces must be implemented by the client. Through `IPropertyBag`, the client saves and loads the object's individual properties. Through **IErrorLog**, both the object and the client can report any errors encountered.  
  
 **Related Articles** [ATL Tutorial](../vs140/active-template-library--atl--tutorial.md), [Creating an ATL Project](../vs140/creating-an-atl-project.md)  
  
## Inheritance Hierarchy  
 `IPersistPropertyBag`  
  
 `IPersistPropertyBagImpl`  
  
## Requirements  
 **Header:** atlcom.h  
  
##  <a name="ipersistpropertybagimpl__getclassid"></a>  IPersistPropertyBagImpl::GetClassID  
 Retrieves the object's CLSID.  
  
```  
  
STDMETHOD(GetClassID)(  
      CLSID * pClassID  
   );  
  
```  
  
### Remarks  
 See [IPersist::GetClassID](http://msdn.microsoft.com/library/windows/desktop/ms688664) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  <a name="ipersistpropertybagimpl__initnew"></a>  IPersistPropertyBagImpl::InitNew  
 Initializes a newly created object.  
  
```  
  
STDMETHOD(InitNew)( );  
  
```  
  
### Return Value  
 Returns `S_OK`.  
  
### Remarks  
 See [IPersistPropertyBag::InitNew](https://msdn.microsoft.com/en-us/library/aa768204.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  <a name="ipersistpropertybagimpl__load"></a>  IPersistPropertyBagImpl::Load  
 Loads the object's properties from a client-supplied property bag.  
  
```  
  
STDMETHOD(Load)(  
      LPPROPERTYBAG  pPropBag,  
      LPERRORLOG  pErrorLog  
   );  
  
```  
  
### Remarks  
 ATL uses the object's property map to retrieve this information.  
  
 See [IPersistPropertyBag::Load](https://msdn.microsoft.com/en-us/library/aa768206.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  <a name="ipersistpropertybagimpl__save"></a>  IPersistPropertyBagImpl::Save  
 Saves the object's properties into a client-supplied property bag.  
  
```  
  
STDMETHOD(Save)(  
      LPPROPERTYBAG  pPropBag,  
      BOOL  fClearDirty,  
      BOOL  fSaveAllProperties  
   );  
  
```  
  
### Remarks  
 ATL uses the object's property map to store this information. By default, this method saves all properties, regardless of the value of *fSaveAllProperties*.  
  
 See [IPersistPropertyBag::Save](https://msdn.microsoft.com/en-us/library/aa768207.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## See Also  
 [BEGIN_PROP_MAP](../vs140/begin_prop_map.md)   
 [Class Overview](../vs140/atl-class-overview.md)