---
title: "CComUnkArray Class"
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
  - "ATL.CComUnkArray"
  - "ATL.CComUnkArray<nMaxSize>"
  - "ATL::CComUnkArray<nMaxSize>"
  - "ATL::CComUnkArray"
  - "CComUnkArray"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "connection points [C++], managing"
  - "CComUnkArray class"
ms.assetid: 5fd4b378-a7b5-4cc1-8866-8ab72a73639e
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComUnkArray Class
This class stores **IUnknown** pointers, and is designed to be used as a parameter to the [IConnectionPointImpl](../vs140/iconnectionpointimpl-class.md) template class.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *nMaxSize*  
 The maximum number of **IUnknown** pointers that can be held in the static array.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CComUnkArray::CComUnkArray](../vs140/ccomunkarray--ccomunkarray.md)|Constructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComUnkArray::Add](../vs140/ccomunkarray--add.md)|Call this method to add an **IUnknown** pointer to the array.|  
|[CComUnkArray::begin](../vs140/ccomunkarray--begin.md)|Returns a pointer to the first **IUnknown** pointer in the collection.|  
|[CComUnkArray::end](../vs140/ccomunkarray--end.md)|Returns a pointer to one past the last **IUnknown** pointer in the collection.|  
|[CComUnkArray::GetCookie](../vs140/ccomunkarray--getcookie.md)|Call this method to get the cookie associated with a given **IUnknown** pointer.|  
|[CComUnkArray::GetUnknown](../vs140/ccomunkarray--getunknown.md)|Call this method to get the **IUnknown** pointer associated with a given cookie.|  
|[CComUnkArray::Remove](../vs140/ccomunkarray--remove.md)|Call this method to remove an **IUnknown** pointer from the array.|  
  
## Remarks  
 **CComUnkArray** holds a fixed number of **IUnknown** pointers, each an interface on a connection point. **CComUnkArray** can be used as a parameter to the [IConnectionPointImpl](../vs140/iconnectionpointimpl-class.md) template class. **CComUnkArray\<1>** is a template specialization of **CComUnkArray** that has been optimized for one connection point.  
  
 The **CComUnkArray** methods [begin](../vs140/ccomunkarray--begin.md) and [end](../vs140/ccomunkarray--end.md) can be used to loop through all connection points (for example, when an event is fired).  
  
 See [Adding Connection Points to an Object](../vs140/adding-connection-points-to-an-object.md) for details on automating creation of connection point proxies.  
  
> [!NOTE]
>  **Note** The class [CComDynamicUnkArray](../vs140/ccomdynamicunkarray-class.md) is used by the **Add Class** wizard when creating a control which has Connection Points. If you wish to specify the number of Connection Points manually, change the reference from **CComDynamicUnkArray** to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> *n* <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, where *n* is the number of connection points required.  
  
## Requirements  
 **Header:** atlcom.h  
  
##  \<a name="ccomunkarray__add">\</a>  CComUnkArray::Add  
 Call this method to add an **IUnknown** pointer to the array.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 *pUnk*  
 Call this method to add an **IUnknown** pointer to the array.  
  
### Return Value  
 Returns the cookie associated with the newly added pointer, or 0 if the array is not large enough to contain the new pointer.  
  
##  \<a name="ccomunkarray__begin">\</a>  CComUnkArray::begin  
 Returns a pointer to the beginning of the collection of **IUnknown** interface pointers.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to an **IUnknown** interface pointer.  
  
### Remarks  
 The collection contains pointers to interfaces stored locally as **IUnknown**. You cast each **IUnknown** interface to the real interface type and then call through it. You do not need to query for the interface first.  
  
 Before using the **IUnknown** interface, you should check that it is not **NULL**.  
  
##  \<a name="ccomunkarray__ccomunkarray">\</a>  CComUnkArray::CComUnkArray  
 The constructor.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 Sets the collection to hold <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> **IUnknown** pointers, and initializes the pointers to **NULL**.  
  
##  \<a name="ccomunkarray__end">\</a>  CComUnkArray::end  
 Returns a pointer to one past the last **IUnknown** pointer in the collection.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to an **IUnknown** interface pointer.  
  
### Remarks  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> methods **begin** and **end** can be used to loop through all connection points, for example, when an event is fired.  
  
 [!code[NVC_ATL_COM#44](../vs140/codesnippet/CPP/ccomunkarray-class_1.cpp)]  
  
##  \<a name="ccomunkarray__getcookie">\</a>  CComUnkArray::GetCookie  
 Call this method to get the cookie associated with a given **IUnknown** pointer.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The **IUnknown** pointer for which the associated cookie is required.  
  
### Return Value  
 Returns the cookie associated with the **IUnknown** pointer, or 0 if no matching **IUnknown** pointer is found.  
  
### Remarks  
 If there is more than one instance of the same **IUnknown** pointer, this function returns the cookie for the first one.  
  
##  \<a name="ccomunkarray__getunknown">\</a>  CComUnkArray::GetUnknown  
 Call this method to get the **IUnknown** pointer associated with a given cookie.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The cookie for which the associated **IUnknown** pointer is required.  
  
### Return Value  
 Returns the **IUnknown** pointer, or NULL if no matching cookie is found.  
  
##  \<a name="ccomunkarray__remove">\</a>  CComUnkArray::Remove  
 Call this method to remove an **IUnknown** pointer from the array.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The cookie referencing the **IUnknown** pointer to be removed from the array.  
  
### Return Value  
 Returns **TRUE** if the pointer is removed,                         **FALSE** otherwise.  
  
## See Also  
 [CComDynamicUnkArray Class](../vs140/ccomdynamicunkarray-class.md)   
 [ATL Class Overview](../vs140/atl-class-overview.md)