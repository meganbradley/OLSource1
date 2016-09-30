---
title: "CAutoPtr Class"
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
  - "CAutoPtr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAutoPtr class"
ms.assetid: 08988d53-4fb0-4711-bdfc-8ac29c63f410
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAutoPtr Class
This class represents a smart pointer object.  
  
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
|[CAutoPtr::CAutoPtr](../vs140/cautoptr--cautoptr.md)|The constructor.|  
|[CAutoPtr::~CAutoPtr](../vs140/cautoptr--~cautoptr.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CAutoPtr::Attach](../vs140/cautoptr--attach.md)|Call this method to take ownership of an existing pointer.|  
|[CAutoPtr::Detach](../vs140/cautoptr--detach.md)|Call this method to release ownership of a pointer.|  
|[CAutoPtr::Free](../vs140/cautoptr--free.md)|Call this method to delete an object pointed to by a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CAutoPtr::operator T*](../vs140/cautoptr--operator-t-.md)|The cast operator.|  
|[CAutoPtr::operator =](../vs140/cautoptr--operator-=.md)|The assignment operator.|  
|[CAutoPtr::operator ->](../vs140/cautoptr--operator---.md)|The pointer-to-member operator.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CAutoPtr::m_p](../vs140/cautoptr--m_p.md)|The pointer data member variable.|  
  
## Remarks  
 This class provides methods for creating and managing a smart pointer, which will help protect against memory leaks by automatically freeing resources when it falls out of scope.  
  
 Further, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>'s copy constructor and assignment operator transfer ownership of the pointer, copying the source pointer to the destination pointer and setting the source pointer to NULL. It is therefore impossible to have two <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> objects each storing the same pointer, and this reduces the possibility of deleting the same pointer twice.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> also simplifies the creation of collections of pointers. Instead of deriving a collection class and overriding the destructor, it's simpler to make a collection of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> objects. When the collection is deleted, the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> objects will go out of scope and automatically delete themselves.  
  
 [CHeapPtr](../vs140/cheapptr-class.md) and variants work in the same way as <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, except that they allocate and free memory using different heap functions instead of the C++                 **new** and **delete** operators. [CAutoVectorPtr](../vs140/cautovectorptr-class.md) is similar to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, the only difference being that it uses **vector new[]** and **vector delete[]** to allocate and free memory.  
  
 See also [CAutoPtrArray](../vs140/cautoptrarray-class.md) and [CAutoPtrList](../vs140/cautoptrlist-class.md) when arrays or lists of smart pointers are required.  
  
## Requirements  
 **Header:** atlbase.h  
  
## Example  
 [!code[NVC_ATL_Utilities#74](../vs140/codesnippet/CPP/cautoptr-class_1.cpp)]  
  
##  \<a name="cautoptr__attach">\</a>  CAutoPtr::Attach  
 Call this method to take ownership of an existing pointer.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object will take ownership of this pointer.  
  
### Remarks  
 When a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object takes ownership of a pointer, it will automatically delete the pointer and any allocated data when it goes out of scope. If [CAutoPtr::Detach](../vs140/cautoptr--detach.md) is called, the programmer is again given responsibility for freeing any allocated resources.  
  
 In debug builds, an assertion failure will occur if the [CAutoPtr::m_p](../vs140/cautoptr--m_p.md) data member currently points to an existing value; that is, it is not equal to NULL.  
  
### Example  
 See the example in the [CAutoPtr Overview](../vs140/cautoptr-class.md).  
  
##  \<a name="cautoptr__cautoptr">\</a>  CAutoPtr::CAutoPtr  
 The constructor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 An existing pointer.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 The type being managed by another <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, used to initialize the current object.  
  
### Remarks  
 The <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object can be created using an existing pointer, in which case it transfers ownership of the pointer.  
  
### Example  
 See the example in the [CAutoPtr Overview](../vs140/cautoptr-class.md).  
  
##  \<a name="cautoptr___dtorcautoptr">\</a>  CAutoPtr::~CAutoPtr  
 The destructor.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 Frees any allocated resources. Calls [CAutoPtr::Free](../vs140/cautoptr--free.md).  
  
##  \<a name="cautoptr__detach">\</a>  CAutoPtr::Detach  
 Call this method to release ownership of a pointer.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 Returns a copy of the pointer.  
  
### Remarks  
 Releases ownership of a pointer, sets the [CAutoPtr::m_p](../vs140/cautoptr--m_p.md) data member variable to NULL, and returns a copy of the pointer. After calling **Detach**, it is up to the programmer to free any allocated resources over which the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object may have previously assumed reponsibility.  
  
### Example  
 See the example in the [CAutoPtr Overview](../vs140/cautoptr-class.md).  
  
##  \<a name="cautoptr__free">\</a>  CAutoPtr::Free  
 Call this method to delete an object pointed to by a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 The object pointed to by the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is freed, and the [CAutoPtr::m_p](../vs140/cautoptr--m_p.md) data member variable is set to NULL.  
  
##  \<a name="cautoptr__m_p">\</a>  CAutoPtr::m_p  
 The pointer data member variable.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 This member variable holds the pointer information.  
  
##  \<a name="cautoptr__operator__eq">\</a>  CAutoPtr::operator =  
 The assignment operator.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 A pointer.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 A class type.  
  
### Return Value  
 Returns a reference to a **CAutoPtr\< T >**.  
  
### Remarks  
 The assignment operator detaches the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object from any current pointer and attaches the new pointer, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, in its place.  
  
### Example  
 See the example in the [CAutoPtr Overview](../vs140/cautoptr-class.md).  
  
##  \<a name="cautoptr__operator_-_gt_">\</a>  CAutoPtr::operator -&gt;  
 The pointer-to-member operator.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 Returns the value of the [CAutoPtr::m_p](../vs140/cautoptr--m_p.md) data member variable.  
  
### Remarks  
 Use this operator to call a method in a class pointed to by the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object. In debug builds, an assertion failure will occur if the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> points to NULL.  
  
### Example  
 See the example in the [CAutoPtr Overview](../vs140/cautoptr-class.md).  
  
##  \<a name="cautoptr__operator_t_star">\</a>  CAutoPtr::operator T*  
 The cast operator.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 Returns a pointer to the object data type defined in the class template.  
  
### Example  
 See the example in the [CAutoPtr Overview](../vs140/cautoptr-class.md).  
  
## See Also  
 [CHeapPtr Class](../vs140/cheapptr-class.md)   
 [CAutoVectorPtr Class](../vs140/cautovectorptr-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)