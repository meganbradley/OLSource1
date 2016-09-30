---
title: "CAutoVectorPtr Class"
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
  - "ATL::CAutoVectorPtr"
  - "ATL.CAutoVectorPtr"
  - "ATL.CAutoVectorPtr<T>"
  - "CAutoVectorPtr"
  - "ATL::CAutoVectorPtr<T>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAutoVectorPtr class"
ms.assetid: 0030362b-6bc4-4a47-9b5b-3c3899dceab4
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAutoVectorPtr Class
This class represents a smart pointer object using vector new and delete operators.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The pointer type.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CAutoVectorPtr::CAutoVectorPtr](../vs140/cautovectorptr--cautovectorptr.md)|The constructor.|  
|[CAutoVectorPtr::~CAutoVectorPtr](../vs140/cautovectorptr--~cautovectorptr.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CAutoVectorPtr::Allocate](../vs140/cautovectorptr--allocate.md)|Call this method to allocate the memory required by the array of objects pointed to by <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.|  
|[CAutoVectorPtr::Attach](../vs140/cautovectorptr--attach.md)|Call this method to take ownership of an existing pointer.|  
|[CAutoVectorPtr::Detach](../vs140/cautovectorptr--detach.md)|Call this method to release ownership of a pointer.|  
|[CAutoVectorPtr::Free](../vs140/cautovectorptr--free.md)|Call this method to delete an object pointed to by a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CAutoVectorPtr::operator T*](../vs140/cautovectorptr--operator-t--.md)|The cast operator.|  
|[CAutoVectorPtr::operator=](../vs140/cautovectorptr--operator-=.md)|The assignment operator.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CAutoVectorPtr::m_p](../vs140/cautovectorptr--m_p.md)|The pointer data member variable.|  
  
## Remarks  
 This class provides methods for creating and managing a smart pointer, which will help protect against memory leaks by automatically freeing resources when it falls out of scope. <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is similar to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, the only difference being that <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> uses [vector new&#91;&#93;](../vs140/operator-new--new--.md) and [vector delete&#91;&#93;](../vs140/operator-delete--new--.md) to allocate and free memory instead of the C++                 **new** and **delete** operators. See [CAutoVectorPtrElementTraits](../vs140/cautovectorptrelementtraits-class.md) if collection classes of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> are required.  
  
 See [CAutoPtr](../vs140/cautoptr-class.md) for an example of using a smart pointer class.  
  
## Requirements  
 **Header:** atlbase.h  
  
##  \<a name="cautovectorptr__allocate">\</a>  CAutoVectorPtr::Allocate  
 Call this method to allocate the memory required by the array of objects pointed to by <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 The number of elements in the array.  
  
### Return Value  
 Returns true if the memory is successfully allocated, false on failure.  
  
### Remarks  
 In debug builds, an assertion failure will occur if the [CAutoVectorPtr::m_p](../vs140/cautovectorptr--m_p.md) member variable currently points to an existing value; that is, it is not equal to NULL.  
  
##  \<a name="cautovectorptr__attach">\</a>  CAutoVectorPtr::Attach  
 Call this method to take ownership of an existing pointer.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object will take ownership of this pointer.  
  
### Remarks  
 When a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object takes ownership of a pointer, it will automatically delete the pointer and any allocated data when it goes out of scope. If [CAutoVectorPtr::Detach](../vs140/cautovectorptr--detach.md) is called, the programmer is again given responsibility for freeing any allocated resources.  
  
 In debug builds, an assertion failure will occur if the [CAutoVectorPtr::m_p](../vs140/cautovectorptr--m_p.md) member variable currently points to an existing value; that is, it is not equal to NULL.  
  
##  \<a name="cautovectorptr__cautovectorptr">\</a>  CAutoVectorPtr::CAutoVectorPtr  
 The constructor.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 An existing pointer.  
  
### Remarks  
 The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object can be created using an existing pointer, in which case it transfers ownership of the pointer.  
  
##  \<a name="cautovectorptr___dtorcautovectorptr">\</a>  CAutoVectorPtr::~CAutoVectorPtr  
 The destructor.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 Frees any allocated resources. Calls [CAutoVectorPtr::Free](../vs140/cautovectorptr--free.md).  
  
##  \<a name="cautovectorptr__detach">\</a>  CAutoVectorPtr::Detach  
 Call this method to release ownership of a pointer.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 Returns a copy of the pointer.  
  
### Remarks  
 Releases ownership of a pointer, sets the [CAutoVectorPtr::m_p](../vs140/cautovectorptr--m_p.md) member variable to NULL, and returns a copy of the pointer. After calling **Detach**, it is up to the programmer to free any allocated resources over which the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object may have previously assumed responsibility.  
  
##  \<a name="cautovectorptr__free">\</a>  CAutoVectorPtr::Free  
 Call this method to delete an object pointed to by a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 The object pointed to by the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is freed, and the [CAutoVectorPtr::m_p](../vs140/cautovectorptr--m_p.md) member variable is set to NULL.  
  
##  \<a name="cautovectorptr__m_p">\</a>  CAutoVectorPtr::m_p  
 The pointer data member variable.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 This member variable holds the pointer information.  
  
##  \<a name="cautovectorptr__operator__eq">\</a>  CAutoVectorPtr::operator =  
 The assignment operator.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 A pointer.  
  
### Return Value  
 Returns a reference to a **CAutoVectorPtr\< T >**.  
  
### Remarks  
 The assignment operator detaches the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object from any current pointer and attaches the new pointer, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, in its place.  
  
##  \<a name="cautovectorptr__operator_t__star">\</a>  CAutoVectorPtr::operator T *  
 The cast operator.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 Returns a pointer to the object data type defined in the class template.  
  
## See Also  
 [CAutoPtr Class](../vs140/cautoptr-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)