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
>  This class and its members cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Your class, derived from <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IPersistStorageImpl::GetClassID](../vs140/ipersiststorageimpl--getclassid.md)|Retrieves the object's CLSID.|  
|[IPersistStorageImpl::HandsOffStorage](../vs140/ipersiststorageimpl--handsoffstorage.md)|Instructs the object to release all storage objects and enter HandsOff mode. The ATL implementation returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.|  
|[IPersistStorageImpl::InitNew](../vs140/ipersiststorageimpl--initnew.md)|Initializes a new storage.|  
|[IPersistStorageImpl::IsDirty](../vs140/ipersiststorageimpl--isdirty.md)|Checks whether the object's data has changed since it was last saved.|  
|[IPersistStorageImpl::Load](../vs140/ipersiststorageimpl--load.md)|Loads the object's properties from the specified storage.|  
|[IPersistStorageImpl::Save](../vs140/ipersiststorageimpl--save.md)|Saves the object's properties to the specified storage.|  
|[IPersistStorageImpl::SaveCompleted](../vs140/ipersiststorageimpl--savecompleted.md)|Notifies an object that it can return to Normal mode to write to its storage object. The ATL implementation returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.|  
  
## Remarks  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> implements the [IPersistStorage](http://msdn.microsoft.com/library/windows/desktop/ms679731) interface, which allows a client to request that your object load and save its persistent data using a storage.  
  
 The implementation of this class requires class <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to make an implementation of the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> interface available via <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. Typically this means that class <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> should derive from [IPersistStreamInitImpl](../vs140/ipersiststreaminitimpl-class.md), provide an entry for <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> in the [COM map](../vs140/begin_com_map.md), and use a [property map](../vs140/begin_prop_map.md) to describe the class's persistent data.  
  
 **Related Articles** [ATL Tutorial](../vs140/active-template-library--atl--tutorial.md), [Creating an ATL Project](../vs140/creating-an-atl-project.md)  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlcom.h  
  
##  \<a name="ipersiststorageimpl__getclassid">\</a>  IPersistStorageImpl::GetClassID  
 Retrieves the object's CLSID.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 See [IPersist::GetClassID](http://msdn.microsoft.com/library/windows/desktop/ms688664) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ipersiststorageimpl__handsoffstorage">\</a>  IPersistStorageImpl::HandsOffStorage  
 Instructs the object to release all storage objects and enter HandsOff mode.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
### Remarks  
 See [IPersistStorage::HandsOffStorage](http://msdn.microsoft.com/library/windows/desktop/ms679742) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ipersiststorageimpl__initnew">\</a>  IPersistStorageImpl::InitNew  
 Initializes a new storage.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 The ATL implementation delegates to the [IPersistStreamInit](http://msdn.microsoft.com/library/windows/desktop/ms682273) interface.  
  
 See [IPersistStorage:InitNew](http://msdn.microsoft.com/library/windows/desktop/ms687194) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ipersiststorageimpl__isdirty">\</a>  IPersistStorageImpl::IsDirty  
 Checks whether the object's data has changed since it was last saved.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 The ATL implementation delegates to the [IPersistStreamInit](http://msdn.microsoft.com/library/windows/desktop/ms682273) interface.  
  
 See [IPersistStorage:IsDirty](http://msdn.microsoft.com/library/windows/desktop/ms683910) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ipersiststorageimpl__load">\</a>  IPersistStorageImpl::Load  
 Loads the object's properties from the specified storage.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 The ATL implementation delegates to the [IPersistStreamInit](http://msdn.microsoft.com/library/windows/desktop/ms682273) interface. **Load** uses a stream named "Contents" to retrieve the object's data. The [Save](../vs140/ipersiststorageimpl--save.md) method originally creates this stream.  
  
 See [IPersistStorage:Load](http://msdn.microsoft.com/library/windows/desktop/ms680557) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ipersiststorageimpl__save">\</a>  IPersistStorageImpl::Save  
 Saves the object's properties to the specified storage.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 The ATL implementation delegates to the [IPersistStreamInit](http://msdn.microsoft.com/library/windows/desktop/ms682273) interface. When **Save** is first called, it creates a stream named "Contents" on the specified storage. This stream is then used in later calls to **Save** and in calls to [Load](../vs140/ipersiststorageimpl--load.md).  
  
 See [IPersistStorage:Save](http://msdn.microsoft.com/library/windows/desktop/ms680680) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ipersiststorageimpl__savecompleted">\</a>  IPersistStorageImpl::SaveCompleted  
 Notifies an object that it can return to Normal mode to write to its storage object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
### Remarks  
 See [IPersistStorage:SaveCompleted](http://msdn.microsoft.com/library/windows/desktop/ms679713) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## See Also  
 [Storages and Streams](http://msdn.microsoft.com/library/windows/desktop/aa380352)   
 [IPersistStreamInitImpl Class](../vs140/ipersiststreaminitimpl-class.md)   
 [IPersistPropertyBagImpl Class](../vs140/ipersistpropertybagimpl-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)