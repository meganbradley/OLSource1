---
title: "CComPtr Class"
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
  - "CComPtr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComPtr class"
ms.assetid: 22d9ea8d-ed66-4c34-940f-141db11e83bd
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
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
|[CComPtr::CComPtr](../Topic/CComPtr::CComPtr.md)|The constructor.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CComPtr::operator =](../Topic/CComPtr::operator%20=.md)|Assigns a pointer to the member pointer.|  
  
## Remarks  
 ATL uses `CComPtr` and [CComQIPtr](../VS_csharp/ccomqiptr-class.md) to manage COM interface pointers. Both are derived from [CComPtrBase](../VS_csharp/ccomptrbase-class.md), and both perform automatic reference counting.  
  
 The **CComPtr** and [CComQIPtr](../VS_csharp/ccomqiptr-class.md) classes can help eliminate memory leaks by performing automatic reference counting.  The following functions both perform the same logical operations; however, note how the second version may be less error-prone by using the **CComPtr** class:  
  
 [!code[NVC_ATL_Utilities#130](../VS_csharp/codesnippet/CPP/ccomptr-class_1.cpp)]  
  
 [!code[NVC_ATL_Utilities#131](../VS_csharp/codesnippet/CPP/ccomptr-class_2.cpp)]  
  
 In Debug builds, link atlsd.lib for code tracing.  
  
## Inheritance Hierarchy  
 [CComPtrBase](../VS_csharp/ccomptrbase-class.md)  
  
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
 [CComPtr::CComPtr](../Topic/CComPtr::CComPtr.md)   
 [CComQIPtr::CComQIPtr](../Topic/CComQIPtr::CComQIPtr.md)   
 [Class Overview](../VS_csharp/atl-class-overview.md)