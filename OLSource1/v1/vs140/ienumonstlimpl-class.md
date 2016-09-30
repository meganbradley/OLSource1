---
title: "IEnumOnSTLImpl Class"
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
  - "IEnumOnSTLImpl"
  - "ATL.IEnumOnSTLImpl"
  - "ATL::IEnumOnSTLImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IEnumOnSTLImpl class"
ms.assetid: 1789e77b-88b8-447d-a490-806b918912ce
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IEnumOnSTLImpl Class
This class defines an enumerator interface based on an STL collection.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A COM enumerator ( [IEnumXXXX](https://msdn.microsoft.com/en-us/library/ms680089.aspx)) interface.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 A pointer to the interface ID of the enumerator interface.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The type of item exposed by the enumerator interface.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 A [copy policy class](../vs140/atl-copy-policy-classes.md).  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 An STL container class.  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IEnumOnSTLImpl::Clone](../vs140/ienumonstlimpl--clone.md)|The implementation of [IEnumXXXX::Clone](https://msdn.microsoft.com/en-us/library/ms690336.aspx).|  
|[IEnumOnSTLImpl::Init](../vs140/ienumonstlimpl--init.md)|Initializes the enumerator.|  
|[IEnumOnSTLImpl::Next](../vs140/ienumonstlimpl--next.md)|The implementation of [IEnumXXXX::Next](https://msdn.microsoft.com/en-us/library/ms695273.aspx).|  
|[IEnumOnSTLImpl::Reset](../vs140/ienumonstlimpl--reset.md)|The implementation of [IEnumXXXX::Reset](https://msdn.microsoft.com/en-us/library/ms693414.aspx).|  
|[IEnumOnSTLImpl::Skip](../vs140/ienumonstlimpl--skip.md)|The implementation of [IEnumXXXX::Skip](https://msdn.microsoft.com/en-us/library/ms690392.aspx).|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[IEnumOnSTLImpl::m_iter](../vs140/ienumonstlimpl--m_iter.md)|The iterator that represents the enumerator's current position within the collection.|  
|[IEnumOnSTLImpl::m_pcollection](../vs140/ienumonstlimpl--m_pcollection.md)|A pointer to the STL container holding the items to be enumerated.|  
|[IEnumOnSTLImpl::m_spUnk](../vs140/ienumonstlimpl--m_spunk.md)|The **IUnknown** pointer of the object supplying the collection.|  
  
## Remarks  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> provides the implementation for a COM enumerator interface where the items being enumerated are stored in an STL-compatible container. This class is analogous to the [CComEnumImpl](../vs140/ccomenumimpl-class.md) class, which provides an implementation for an enumerator interface based on an array.  
  
> [!NOTE]
>  See [CComEnumImpl::Init](../vs140/ccomenumimpl--init.md) for details on further differences between <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 Typically, you will *not* need to create your own enumerator class by deriving from this interface implementation. If you want to use an ATL-supplied enumerator based on an STL container, it is more common to create an instance of [CComEnumOnSTL](../vs140/ccomenumonstl-class.md), or to create a collection class that returns an enumerator by deriving from [ICollectionOnSTLImpl](../vs140/icollectiononstlimpl-class.md).  
  
 However, if you do need to provide a custom enumerator (for example, one that exposes interfaces in addition to the enumerator interface), you can derive from this class. In this situation it is likely that you'll need to override the [Clone](../vs140/ienumonstlimpl--clone.md) method to provide your own implementation.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlcom.h  
  
##  \<a name="ienumonstlimpl__init">\</a>  IEnumOnSTLImpl::Init  
 Initializes the enumerator.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 [in] The **IUnknown** pointer of an object that must be kept alive during the lifetime of the enumerator. Pass **NULL** if no such object exists.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 A reference to the STL container that holds the items to be enumerated.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> value.  
  
### Remarks  
 If you pass <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> a reference to a collection held in another object, you can use the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> parameter to ensure that the object, and the collection it holds, is available for as long as the enumerator needs it.  
  
 You must call this method before passing a pointer to the enumerator interface back to any clients.  
  
##  \<a name="ienumonstlimpl__clone">\</a>  IEnumOnSTLImpl::Clone  
 This method provides the implementation of the [IEnumXXXX::Clone](https://msdn.microsoft.com/en-us/library/ms690336.aspx) method by creating an object of type <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, initializing it with the same collection and iterator used by the current object, and returning the interface on the newly created object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 [out] The enumerator interface on a newly created object cloned from the current enumerator.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> value.  
  
##  \<a name="ienumonstlimpl__m_spunk">\</a>  IEnumOnSTLImpl::m_spUnk  
 The **IUnknown** pointer of the object supplying the collection.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 This smart pointer maintains a reference on the object passed to [IEnumOnSTLImpl::Init](../vs140/ienumonstlimpl--init.md), ensuring that it remains alive during the lifetime of the enumerator.  
  
##  \<a name="ienumonstlimpl__m_pcollection">\</a>  IEnumOnSTLImpl::m_pcollection  
 This member points to the collection that provides the data driving the implementation of the enumerator interface.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 This member is initialized by a call to [IEnumOnSTLImpl::Init](../vs140/ienumonstlimpl--init.md).  
  
##  \<a name="ienumonstlimpl__m_iter">\</a>  IEnumOnSTLImpl::m_iter  
 This member holds the iterator used to mark the current position within the collection and navigate to subsequent elements.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="ienumonstlimpl__next">\</a>  IEnumOnSTLImpl::Next  
 This method provides the implementation of the [IEnumXXXX::Next](https://msdn.microsoft.com/en-us/library/ms695273.aspx) method.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 [in] The number of elements requested.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 [out] The array to be filled in with the elements.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 [out] The number of elements actually returned in <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. This can be less than <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> if fewer than <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> elements remain in the list.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> value.  
  
##  \<a name="ienumonstlimpl__reset">\</a>  IEnumOnSTLImpl::Reset  
 This method provides the implementation of the [IEnumXXXX::Reset](https://msdn.microsoft.com/en-us/library/ms693414.aspx) method.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 A standard <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> value.  
  
##  \<a name="ienumonstlimpl__skip">\</a>  IEnumOnSTLImpl::Skip  
 This method provides the implementation of the [IEnumXXXX::Skip](https://msdn.microsoft.com/en-us/library/ms690392.aspx) method.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 [in] The number of elements to skip.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> value.  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)