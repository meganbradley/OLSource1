---
title: "IPersistStorageImpl Class"
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
  - "ATL::IPersistStorageImpl"
  - "ATL::IPersistStorageImpl<T>"
  - "ATL.IPersistStorageImpl<T>"
  - "IPersistStorageImpl"
  - "ATL.IPersistStorageImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "storage, ATL"
  - "IPersistStorageImpl class"
ms.assetid: d652f02c-239c-47c7-9a50-3e9fc3014fff
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IPersistStorageImpl Class
This class implements the [IPersistStorage](http://msdn.microsoft.com/library/windows/desktop/ms679731) interface.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
template <  
   class  T>  
   class ATL_NO_VTABLE IPersistStorageImpl :  
   public IPersistStorage  
  
```  
  
#### Parameters  
 `T`  
 Your class, derived from `IPersistStorageImpl`.  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IPersistStorageImpl::GetClassID](../VS_csharp/ipersiststorageimpl--getclassid.md)|Retrieves the object's CLSID.|  
|[IPersistStorageImpl::HandsOffStorage](../VS_csharp/ipersiststorageimpl--handsoffstorage.md)|Instructs the object to release all storage objects and enter HandsOff mode. The ATL implementation returns `S_OK`.|  
|[IPersistStorageImpl::InitNew](../VS_csharp/ipersiststorageimpl--initnew.md)|Initializes a new storage.|  
|[IPersistStorageImpl::IsDirty](../VS_csharp/ipersiststorageimpl--isdirty.md)|Checks whether the object's data has changed since it was last saved.|  
|[IPersistStorageImpl::Load](../VS_csharp/ipersiststorageimpl--load.md)|Loads the object's properties from the specified storage.|  
|[IPersistStorageImpl::Save](../VS_csharp/ipersiststorageimpl--save.md)|Saves the object's properties to the specified storage.|  
|[IPersistStorageImpl::SaveCompleted](../VS_csharp/ipersiststorageimpl--savecompleted.md)|Notifies an object that it can return to Normal mode to write to its storage object. The ATL implementation returns `S_OK`.|  
  
## Remarks  
 `IPersistStorageImpl` implements the [IPersistStorage](http://msdn.microsoft.com/library/windows/desktop/ms679731) interface, which allows a client to request that your object load and save its persistent data using a storage.  
  
 The implementation of this class requires class `T` to make an implementation of the `IPersistStreamInit` interface available via `QueryInterface`. Typically this means that class `T` should derive from [IPersistStreamInitImpl](../VS_csharp/ipersiststreaminitimpl-class.md), provide an entry for `IPersistStreamInit` in the [COM map](../VS_csharp/begin_com_map.md), and use a [property map](../VS_csharp/begin_prop_map.md) to describe the class's persistent data.  
  
 **Related Articles** [ATL Tutorial](../VS_csharp/active-template-library--atl--tutorial.md), [Creating an ATL Project](../VS_csharp/creating-an-atl-project.md)  
  
## Inheritance Hierarchy  
 `IPersistStorage`  
  
 `IPersistStorageImpl`  
  
## Requirements  
 **Header:** atlcom.h  
  
##  <a name="ipersiststorageimpl__getclassid"></a>  IPersistStorageImpl::GetClassID  
 Retrieves the object's CLSID.  
  
```  
  
STDMETHOD(GetClassID)(  
      CLSID * pClassID  
   );  
  
```  
  
### Remarks  
 See [IPersist::GetClassID](http://msdn.microsoft.com/library/windows/desktop/ms688664) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
##  <a name="ipersiststorageimpl__handsoffstorage"></a>  IPersistStorageImpl::HandsOffStorage  
 Instructs the object to release all storage objects and enter HandsOff mode.  
  
```  
  
STDMETHOD(HandsOffStorage)(void);  
  
```  
  
### Return Value  
 Returns `S_OK`.  
  
### Remarks  
 See [IPersistStorage::HandsOffStorage](http://msdn.microsoft.com/library/windows/desktop/ms679742) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
##  <a name="ipersiststorageimpl__initnew"></a>  IPersistStorageImpl::InitNew  
 Initializes a new storage.  
  
```  
  
STDMETHOD(InitNew)(  
      IStorage*  
   );  
  
```  
  
### Remarks  
 The ATL implementation delegates to the [IPersistStreamInit](http://msdn.microsoft.com/library/windows/desktop/ms682273) interface.  
  
 See [IPersistStorage:InitNew](http://msdn.microsoft.com/library/windows/desktop/ms687194) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
##  <a name="ipersiststorageimpl__isdirty"></a>  IPersistStorageImpl::IsDirty  
 Checks whether the object's data has changed since it was last saved.  
  
```  
  
STDMETHOD(IsDirty)(void);  
  
```  
  
### Remarks  
 The ATL implementation delegates to the [IPersistStreamInit](http://msdn.microsoft.com/library/windows/desktop/ms682273) interface.  
  
 See [IPersistStorage:IsDirty](http://msdn.microsoft.com/library/windows/desktop/ms683910) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
##  <a name="ipersiststorageimpl__load"></a>  IPersistStorageImpl::Load  
 Loads the object's properties from the specified storage.  
  
```  
  
STDMETHOD(Load)(  
      IStorage*  pStorage  
   );  
  
```  
  
### Remarks  
 The ATL implementation delegates to the [IPersistStreamInit](http://msdn.microsoft.com/library/windows/desktop/ms682273) interface. **Load** uses a stream named "Contents" to retrieve the object's data. The [Save](../VS_csharp/ipersiststorageimpl--save.md) method originally creates this stream.  
  
 See [IPersistStorage:Load](http://msdn.microsoft.com/library/windows/desktop/ms680557) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
##  <a name="ipersiststorageimpl__save"></a>  IPersistStorageImpl::Save  
 Saves the object's properties to the specified storage.  
  
```  
  
STDMETHOD(Save)(  
      IStorage*  pStorage,  
      BOOL  fSameAsLoad  
   );  
  
```  
  
### Remarks  
 The ATL implementation delegates to the [IPersistStreamInit](http://msdn.microsoft.com/library/windows/desktop/ms682273) interface. When **Save** is first called, it creates a stream named "Contents" on the specified storage. This stream is then used in later calls to **Save** and in calls to [Load](../VS_csharp/ipersiststorageimpl--load.md).  
  
 See [IPersistStorage:Save](http://msdn.microsoft.com/library/windows/desktop/ms680680) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
##  <a name="ipersiststorageimpl__savecompleted"></a>  IPersistStorageImpl::SaveCompleted  
 Notifies an object that it can return to Normal mode to write to its storage object.  
  
```  
  
STDMETHOD(SaveCompleted)(  
      IStorage*  
   );  
  
```  
  
### Return Value  
 Returns `S_OK`.  
  
### Remarks  
 See [IPersistStorage:SaveCompleted](http://msdn.microsoft.com/library/windows/desktop/ms679713) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
## See Also  
 [Storages and Streams](http://msdn.microsoft.com/library/windows/desktop/aa380352)   
 [IPersistStreamInitImpl Class](../VS_csharp/ipersiststreaminitimpl-class.md)   
 [IPersistPropertyBagImpl Class](../VS_csharp/ipersistpropertybagimpl-class.md)   
 [Class Overview](../VS_csharp/atl-class-overview.md)