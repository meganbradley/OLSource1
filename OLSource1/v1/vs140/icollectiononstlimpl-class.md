---
title: "ICollectionOnSTLImpl Class"
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
  - "ATL.ICollectionOnSTLImpl"
  - "ATL::ICollectionOnSTLImpl"
  - "ICollectionOnSTLImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ICollectionOnSTLImpl class"
ms.assetid: 683c88b0-0d97-4779-a762-e493334ba7f9
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ICollectionOnSTLImpl Class
This class provides methods used by a collection class.  
  
## Syntax  
  
```  
  
template <class T,  
      class  CollType,  
      class  ItemType,  
      class  CopyItem,  
      class  EnumType>  
   class ICollectionOnSTLImpl :  
      public  T  
  
```  
  
#### Parameters  
 `T`  
 A COM collection interface.  
  
 `CollType`  
 An STL container class.  
  
 *ItemType*  
 The type of item exposed by the container interface.  
  
 *CopyItem*  
 A [copy policy class](../vs140/atl-copy-policy-classes.md).  
  
 *EnumType*  
 A [CComEnumOnSTL](../vs140/ccomenumonstl-class.md)-compatible enumerator class.  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[ICollectionOnSTLImpl::get__NewEnum](../vs140/icollectiononstlimpl--get__newenum.md)|Returns an enumerator object for the collection.|  
|[ICollectionOnSTLImpl::get_Count](../vs140/icollectiononstlimpl--get_count.md)|Returns the number of elements in the collection.|  
|[ICollectionOnSTLImpl::get_Item](../vs140/icollectiononstlimpl--get_item.md)|Returns the requested item from the collection.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[ICollectionOnSTLImpl::m_coll](../vs140/icollectiononstlimpl--m_coll.md)|The collection.|  
  
## Remarks  
 This class provides the implementation for three methods of a collection interface: [get_Count](../vs140/icollectiononstlimpl--get_count.md), [get_Item](../vs140/icollectiononstlimpl--get_item.md), and [get__NewEnum](../vs140/icollectiononstlimpl--get__newenum.md).  
  
 To use this class:  
  
-   Define (or borrow) a collection interface that you wish to implement.  
  
-   Derive your class from a specialization of `ICollectionOnSTLImpl` based on this collection interface.  
  
-   Use your derived class to implement any methods from the collection interface not handled by `ICollectionOnSTLImpl`.  
  
> [!NOTE]
>  If the collection interface is a dual interface, derive your class from [IDispatchImpl](../vs140/idispatchimpl-class.md), passing the `ICollectionOnSTLImpl` specialization as the first template parameter if you want ATL to provide the implementation of the `IDispatch` methods.  
  
-   Add items to the [m_coll](../vs140/icollectiononstlimpl--m_coll.md) member to populate the collection.  
  
 For more information and examples, see [ATL Collections and Enumerators](../vs140/atl-collections-and-enumerators.md).  
  
## Inheritance Hierarchy  
 `T`  
  
 `ICollectionOnSTLImpl`  
  
## Requirements  
 **Header:** atlcom.h  
  
##  \<a name="icollectiononstlimpl__get_count"></a>  ICollectionOnSTLImpl::get_Count  
 This method returns the number of items in the collection.  
  
```  
  
STDMETHOD(get_Count)(  
      long*  pcount   
   );  
  
```  
  
### Parameters  
 *pcount*  
 [out] The number of elements in the collection.  
  
### Return Value  
 A standard `HRESULT` value.  
  
##  \<a name="icollectiononstlimpl__get_item"></a>  ICollectionOnSTLImpl::get_Item  
 This method returns the specified item from the collection.  
  
```  
  
STDMETHOD(get_Item)(  
      long  Index,  
      ItemType*  pvar   
   );  
  
```  
  
### Parameters  
 `Index`  
 [in] The 1-based index of an item in the collection.  
  
 `pvar`  
 [out] The item corresponding to `Index`.  
  
### Return Value  
 A standard `HRESULT` value.  
  
### Remarks  
 The item is obtained by copying the data at the specified position in [m_coll](../vs140/icollectiononstlimpl--m_coll.md) using the copy method of the [copy policy class](../vs140/atl-copy-policy-classes.md) passed as a template argument in the `ICollectionOnSTLImpl` specialization.  
  
##  \<a name="icollectiononstlimpl__get__newenum"></a>  ICollectionOnSTLImpl::get__NewEnum  
 Returns an enumerator object for the collection.  
  
```  
  
STDMETHOD(get__NewEnum)(  
      IUnknown**  ppUnk   
   );  
  
```  
  
### Parameters  
 `ppUnk`  
 [out] The **IUnknown** pointer of a newly created enumerator object.  
  
### Return Value  
 A standard `HRESULT` value.  
  
### Remarks  
 The newly created enumerator maintains an iterator on the original collection, `m_coll`, (so no copy is made) and holds a COM reference on the collection object to ensure that the collection remains alive while there are outstanding enumerators.  
  
##  \<a name="icollectiononstlimpl__m_coll"></a>  ICollectionOnSTLImpl::m_coll  
 This member holds the items represented by the collection.  
  
```  
  
CollType m_coll;  
  
```  
  
## See Also  
 [ATLCollections Sample](../vs140/visual-c---samples.md)   
 [Class Overview](../vs140/atl-class-overview.md)