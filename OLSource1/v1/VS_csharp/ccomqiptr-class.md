---
title: "CComQIPtr Class"
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
  - "ATL.CComQIPtr"
  - "ATL::CComQIPtr"
  - "CComQIPtr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComQIPtr class"
ms.assetid: 969cacb5-05b6-4af4-b683-24911d70242d
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComQIPtr Class
A smart pointer class for managing COM interface pointers.  
  
## Syntax  
  
```  
  
template<  
      class  T,  
      const IID*  piid =             &__uuidof( T  
   )>  
   class CComQIPtr: public CComPtr< T>  
  
```  
  
#### Parameters  
 `T`  
 A COM interface specifying the type of pointer to be stored.  
  
 `piid`  
 A pointer to the IID of `T`.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CComQIPtr::CComQIPtr](../Topic/CComQIPtr::CComQIPtr.md)|Constructor.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CComQIPtr::operator =](../Topic/CComQIPtr::operator%20=.md)|Assigns a pointer to the member pointer.|  
  
## Remarks  
 ATL uses `CComQIPtr` and [CComPtr](../VS_csharp/ccomptr-class.md) to manage COM interface pointers, both of which derive from [CComPtrBase](../VS_csharp/ccomptrbase-class.md). Both classes perform automatic reference counting through calls to `AddRef` and **Release**. Overloaded operators handle pointer operations.  
  
## Inheritance Hierarchy  
 [CComPtrBase](../VS_csharp/ccomptrbase-class.md)  
  
 [CComPtr](../VS_csharp/ccomptr-class.md)  
  
 `CComQIPtr`  
  
## Requirements  
 **Header:** atlcomcli.h  
  
##  <a name="ccomqiptr__ccomqiptr"></a>  CComQIPtr::CComQIPtr  
 The constructor.  
  
```  
  
CComQIPtr( ) throw( );   
   CComQIPtr( T  
   *  lp  
   ) throw( );  
   CComQIPtr(  
      IUnknown*  lp  
   ) throw( );  
   CComQIPtr(  
      const CComQIPtr<  T,  
      piid >&  lp  
   ) throw( );  
  
```  
  
### Parameters  
 `lp`  
 Used to initialize the interface pointer.  
  
 `T`  
 A COM interface.  
  
 `piid`  
 A pointer to the IID of `T`.  
  
##  <a name="ccomqiptr__operator__eq"></a>  CComQIPtr::operator =  
 The assignment operator.  
  
```  
T  
  * operator =( T  
  *  lp  
  ) throw( ); T  
  * operator =(  
     const CComQIPtr<  T, piid  
   >&  lp  
  ) throw( ); T  
  * operator =(  
     IUnknown*  lp  
  ) throw( );  
  
```  
  
### Parameters  
 `lp`  
 Used to initialize the interface pointer.  
  
 `T`  
 A COM interface.  
  
 `piid`  
 A pointer to the IID of `T`.  
  
### Return Value  
 Returns a pointer to the updated `CComQIPtr` object.  
  
## See Also  
 [CComPtr::CComPtr](../Topic/CComPtr::CComPtr.md)   
 [CComQIPtr::CComQIPtr](../Topic/CComQIPtr::CComQIPtr.md)   
 [CComPtrBase Class](../VS_csharp/ccomptrbase-class.md)   
 [Class Overview](../VS_csharp/atl-class-overview.md)   
 [CComQIPtrElementTraits Class](../VS_csharp/ccomqiptrelementtraits-class.md)