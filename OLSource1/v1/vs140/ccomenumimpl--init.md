---
title: "CComEnumImpl::Init"
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
  - "ATL::CComEnumImpl::Init"
  - "ATL.CComEnumImpl.Init"
  - "CComEnumImpl::Init"
  - "CComEnumImpl.Init"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Init method"
ms.assetid: e179097f-53ef-4e1b-bb96-371f54f9f8d9
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComEnumImpl::Init
You must call this method before passing a pointer to the enumerator interface back to any clients.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *begin*  
 A pointer to the first element of the array containing the items to be enumerated.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the location just beyond the last element of the array containing the items to be enumerated.  
  
 *pUnk*  
 [in] The **IUnknown** pointer of an object that must be kept alive during the lifetime of the enumerator. Pass **NULL** if no such object exists.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Flags specifying whether or not the enumerator should take ownership of the array or make a copy of it. Possible values are described below.  
  
## Return Value  
 A standard <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> value.  
  
## Remarks  
 Only call this method once — initialize the enumerator, use it, then throw it away.  
  
 If you pass pointers to items in an array held in another object (and you don't ask the enumerator to copy the data), you can use the *pUnk* parameter to ensure that the object and the array it holds are available for as long as the enumerator needs them. The enumerator simply holds a COM reference on the object to keep it alive. The COM reference is automatically released when the enumerator is destroyed.  
  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter allows you to specify how the enumerator should treat the array elements passed to it. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> can take one of the values from the **CComEnumFlags** enumeration shown below:  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 **AtlFlagNoCopy** means that the array's lifetime is not controlled by the enumerator. In this case, either the array will be static or the object identified by *pUnk* will be responsible for freeing the array when it's no longer needed.  
  
 **AtlFlagTakeOwnership** means that the destruction of the array is to be controlled by the enumerator. In this case, the array must have been dynamically allocated using **new**. The enumerator will delete the array in its destructor. Typically, you would pass **NULL** for *pUnk*, although you can still pass a valid pointer if you need to be notified of the destruction of the enumerator for some reason.  
  
 **AtlFlagCopy** means that a new array is to be created by copying the array passed to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. The new array's lifetime is to be controlled by the enumerator. The enumerator will delete the array in its destructor. Typically, you would pass **NULL** for *pUnk*, although you can still pass a valid pointer if you need to be notified of the destruction of the enumerator for some reason.  
  
> [!NOTE]
>  The prototype of this method specifies the array elements as being of type **T**, where **T** was defined as a template parameter to the class. This is the same type that is exposed by means of the COM interface method [CComEnumImpl::Next](../vs140/ccomenumimpl--next.md). The implication of this is that, unlike [IEnumOnSTLImpl](../vs140/ienumonstlimpl-class.md), this class does not support different storage and exposed data types. The data type of elements in the array must be the same as the data type exposed by means of the COM interface.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComEnumImpl Class](../vs140/ccomenumimpl-class.md)   
 [IEnumOnSTLImpl::Init](../vs140/ienumonstlimpl--init.md)