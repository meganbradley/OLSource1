---
title: "CComEnumImpl Class"
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
  - "ATL.CComEnumImpl"
  - "ATL::CComEnumImpl"
  - "CComEnumImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComEnumImpl class"
ms.assetid: cc0d8e76-e608-46db-87cd-4c7161fe32d2
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComEnumImpl Class
This class provides the implementation for a COM enumerator interface where the items being enumerated are stored in an array.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 A COM enumerator ( [IEnumXXXX](https://msdn.microsoft.com/en-us/library/ms680089.aspx)) interface.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 A pointer to the interface ID of the enumerator interface.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The type of item exposed by the enumerator interface.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 A homogeneous [copy policy class](../vs140/atl-copy-policy-classes.md).  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CComEnumImpl::CComEnumImpl](../vs140/ccomenumimpl--ccomenumimpl.md)|The constructor.|  
|[CComEnumImpl::~CComEnumImpl](../vs140/ccomenumimpl--~ccomenumimpl.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComEnumImpl::Clone](../vs140/ccomenumimpl--clone.md)|The implementation of [IEnumXXXX::Clone](https://msdn.microsoft.com/en-us/library/ms690336.aspx).|  
|[CComEnumImpl::Init](../vs140/ccomenumimpl--init.md)|Initializes the enumerator.|  
|[CComEnumImpl::Next](../vs140/ccomenumimpl--next.md)|The implementation of [IEnumXXXX::Next](https://msdn.microsoft.com/en-us/library/ms695273.aspx).|  
|[CComEnumImpl::Reset](../vs140/ccomenumimpl--reset.md)|The implementation of [IEnumXXXX::Reset](https://msdn.microsoft.com/en-us/library/ms693414.aspx).|  
|[CComEnumImpl::Skip](../vs140/ccomenumimpl--skip.md)|The implementation of [IEnumXXXX::Skip](https://msdn.microsoft.com/en-us/library/ms690392.aspx).|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CComEnumImpl::m_begin](../vs140/ccomenumimpl--m_begin.md)|A pointer to the first item in the array.|  
|[CComEnumImpl::m_dwFlags](../vs140/ccomenumimpl--m_dwflags.md)|Copy flags passed through <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.|  
|[CComEnumImpl::m_end](../vs140/ccomenumimpl--m_end.md)|A pointer to the location just beyond the last item in the array.|  
|[CComEnumImpl::m_iter](../vs140/ccomenumimpl--m_iter.md)|A pointer to the current item in the array.|  
|[CComEnumImpl::m_spUnk](../vs140/ccomenumimpl--m_spunk.md)|The **IUnknown** pointer of the object supplying the collection being enumerated.|  
  
## Remarks  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> provides the implementation for a COM enumerator interface where the items being enumerated are stored in an array. This class is analogous to the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> class, which provides an implementation of an enumerator interface based on an STL container.  
  
> [!NOTE]
>  For details on further differences between <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, see [CComEnumImpl::Init](../vs140/ccomenumimpl--init.md).  
  
 Typically, you will *not* need to create your own enumerator class by deriving from this interface implementation. If you want to use an ATL-supplied enumerator based on an array, it is more common to create an instance of [CComEnum](../vs140/ccomenum-class.md).  
  
 However, if you do need to provide a custom enumerator (for example, one that exposes interfaces in addition to the enumerator interface), you can derive from this class. In this situation, it is likely that you'll need to override the [CComEnumImpl::Clone](../vs140/ccomenumimpl--clone.md) method to provide your own implementation.  
  
 For more information, see [ATL Collections and Enumerators](../vs140/atl-collections-and-enumerators.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlcom.h  
  
##  \<a name="ccomenumimpl__ccomenumimpl">\</a>  CComEnumImpl::CComEnumImpl  
 The constructor.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="ccomenumimpl___dtorccomenumimpl">\</a>  CComEnumImpl::~CComEnumImpl  
 The destructor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="ccomenumimpl__init">\</a>  CComEnumImpl::Init  
 You must call this method before passing a pointer to the enumerator interface back to any clients.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 *begin*  
 A pointer to the first element of the array containing the items to be enumerated.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 A pointer to the location just beyond the last element of the array containing the items to be enumerated.  
  
 *pUnk*  
 [in] The **IUnknown** pointer of an object that must be kept alive during the lifetime of the enumerator. Pass **NULL** if no such object exists.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Flags specifying whether or not the enumerator should take ownership of the array or make a copy of it. Possible values are described below.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> value.  
  
### Remarks  
 Only call this method once — initialize the enumerator, use it, then throw it away.  
  
 If you pass pointers to items in an array held in another object (and you don't ask the enumerator to copy the data), you can use the *pUnk* parameter to ensure that the object and the array it holds are available for as long as the enumerator needs them. The enumerator simply holds a COM reference on the object to keep it alive. The COM reference is automatically released when the enumerator is destroyed.  
  
 The <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> parameter allows you to specify how the enumerator should treat the array elements passed to it. <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> can take one of the values from the **CComEnumFlags** enumeration shown below:  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  
 **AtlFlagNoCopy** means that the array's lifetime is not controlled by the enumerator. In this case, either the array will be static or the object identified by *pUnk* will be responsible for freeing the array when it's no longer needed.  
  
 **AtlFlagTakeOwnership** means that the destruction of the array is to be controlled by the enumerator. In this case, the array must have been dynamically allocated using **new**. The enumerator will delete the array in its destructor. Typically, you would pass **NULL** for *pUnk*, although you can still pass a valid pointer if you need to be notified of the destruction of the enumerator for some reason.  
  
 **AtlFlagCopy** means that a new array is to be created by copying the array passed to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>. The new array's lifetime is to be controlled by the enumerator. The enumerator will delete the array in its destructor. Typically, you would pass **NULL** for *pUnk*, although you can still pass a valid pointer if you need to be notified of the destruction of the enumerator for some reason.  
  
> [!NOTE]
>  The prototype of this method specifies the array elements as being of type **T**, where **T** was defined as a template parameter to the class. This is the same type that is exposed by means of the COM interface method [CComEnumImpl::Next](../vs140/ccomenumimpl--next.md). The implication of this is that, unlike [IEnumOnSTLImpl](../vs140/ienumonstlimpl-class.md), this class does not support different storage and exposed data types. The data type of elements in the array must be the same as the data type exposed by means of the COM interface.  
  
##  \<a name="ccomenumimpl__clone">\</a>  CComEnumImpl::Clone  
 This method provides the implementation of the [IEnumXXXX::Clone](https://msdn.microsoft.com/en-us/library/ms690336.aspx) method by creating an object of type <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, initializing it with the same array and iterator used by the current object, and returning the interface on the newly created object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 [out] The enumerator interface on a newly created object cloned from the current enumerator.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> value.  
  
### Remarks  
 Note that cloned enumerators never make their own copy (or take ownership) of the data used by the original enumerator. If necessary, cloned enumerators will keep the original enumerator alive (using a COM reference) to ensure that the data is available for as long as they need it.  
  
##  \<a name="ccomenumimpl__m_spunk">\</a>  CComEnumImpl::m_spUnk  
 This smart pointer maintains a reference on the object passed to [CComEnumImpl::Init](../vs140/ccomenumimpl--init.md), ensuring that it remains alive during the lifetime of the enumerator.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="ccomenumimpl__m_begin">\</a>  CComEnumImpl::m_begin  
 A pointer to the location just beyond the last element of the array containing the items to be enumerated.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="ccomenumimpl__m_end">\</a>  CComEnumImpl::m_end  
 A pointer to the first element of the array containing the items to be enumerated.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="ccomenumimpl__m_iter">\</a>  CComEnumImpl::m_iter  
 A pointer to the current element of the array containing the items to be enumerated.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
##  \<a name="ccomenumimpl__m_dwflags">\</a>  CComEnumImpl::m_dwFlags  
 The flags passed to [CComEnumImpl::Init](../vs140/ccomenumimpl--init.md).  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
##  \<a name="ccomenumimpl__next">\</a>  CComEnumImpl::Next  
 This method provides the implementation of the [IEnumXXXX::Next](https://msdn.microsoft.com/en-us/library/ms695273.aspx) method.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 [in] The number of elements requested.  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 [out] The array to be filled with the elements.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 [out] The number of elements actually returned in <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>. This can be less than <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> if fewer than <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> elements remained in the list.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> value.  
  
##  \<a name="ccomenumimpl__reset">\</a>  CComEnumImpl::Reset  
 This method provides the implementation of the [IEnumXXXX::Reset](https://msdn.microsoft.com/en-us/library/ms693414.aspx) method.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 A standard <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> value.  
  
##  \<a name="ccomenumimpl__skip">\</a>  CComEnumImpl::Skip  
 This method provides the implementation of the [IEnumXXXX::Skip](https://msdn.microsoft.com/en-us/library/ms690392.aspx) method.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 [in] The number of elements to skip.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> value.  
  
### Remarks  
 Returns E_INVALIDARG if <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> is zero, returns S_FALSE if less than <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> elements are returned, returns S_OK otherwise.  
  
## See Also  
 [IEnumOnSTLImpl Class](../vs140/ienumonstlimpl-class.md)   
 [CComEnum Class](../vs140/ccomenum-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)