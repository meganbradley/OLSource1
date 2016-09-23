---
title: "CComPtr Class"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CComPtr
dev_langs: 
  - C++
helpviewer_keywords: 
  - CComPtr class
ms.assetid: 22d9ea8d-ed66-4c34-940f-141db11e83bd
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComPtr Class
A smart pointer class for managing COM interface pointers.  
  
## Syntax  
  
```  
  
template<  
      class  T >  
   class CComPtr  
  
```  
  
#### Parameters  
 `T`  
 A COM interface specifying the type of pointer to be stored.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CComPtr::CComPtr](../vs140/ccomptr--ccomptr.md)|The constructor.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CComPtr::operator =](../vs140/ccomptr--operator-=.md)|Assigns a pointer to the member pointer.|  
  
## Remarks  
 ATL uses `CComPtr` and [CComQIPtr](../vs140/ccomqiptr-class.md) to manage COM interface pointers. Both are derived from [CComPtrBase](../vs140/ccomptrbase-class.md), and both perform automatic reference counting.  
  
 The **CComPtr** and [CComQIPtr](../vs140/ccomqiptr-class.md) classes can help eliminate memory leaks by performing automatic reference counting.  The following functions both perform the same logical operations; however, note how the second version may be less error-prone by using the **CComPtr** class:  
  
 [!code[NVC_ATL_Utilities#130](../vs140/codesnippet/CPP/ccomptr-class_1.cpp)]
  
  
 [!code[NVC_ATL_Utilities#131](../vs140/codesnippet/CPP/ccomptr-class_2.cpp)]
  
  
 In Debug builds, link atlsd.lib for code tracing.  
  
## Inheritance Hierarchy  
 [CComPtrBase](../vs140/ccomptrbase-class.md)  
  
 `CComPtr`  
  
## Requirements  
 **Header:** atlbase.h  
  
##  <a name="ccomptr__ccomptr"></a>  CComPtr::CComPtr  
 The constructor.  
  
```  
  
CComPtr( ) throw ( );   
   CComPtr(  
      T*  lp  
   ) throw ( );  
   CComPtr (  
      const CComPtr<  T  
    >&  lp  
   ) throw ( );  
  
```  
  
### Parameters  
 `lp`  
 Used to initialize the interface pointer.  
  
 `T`  
 A COM interface.  
  
##  <a name="ccomptr__operator__eq"></a>  CComPtr::operator =  
 Assignment operator.  
  
```  
T  
  * operator =( T  
  *  lp  
  ) throw ( );  T  
  * operator =(  
     const CComPtr<  T  
   >&  lp  
  ) throw ( );  
  
```  
  
### Return Value  
 Returns a pointer to the updated `CComPtr` object  
  
### Remarks  
 This operation AddRefs the new object and releases the existing object, if one exists.  
  
## See Also  
 [CComPtr::CComPtr](../vs140/ccomptr--ccomptr.md)   
 [CComQIPtr::CComQIPtr](../vs140/ccomqiptr--ccomqiptr.md)   
 [Class Overview](../vs140/atl-class-overview.md)