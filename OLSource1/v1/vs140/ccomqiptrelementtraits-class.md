---
title: "CComQIPtrElementTraits Class"
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
  - "ATL.CComQIPtrElementTraits"
  - "CComQIPtrElementTraits"
  - "ATL::CComQIPtrElementTraits"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComQIPtrElementTraits class"
ms.assetid: 9df9250a-5413-4362-b133-332932a597c4
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComQIPtrElementTraits Class
This class provides methods, static functions, and typedefs useful when creating collections of COM interface pointers.  
  
## Syntax  
  
```  
  
template<  
      typename  I,  
      const IID*  piid  
    = & __uuidof(  I  
    )   
   >   
   class CComQIPtrElementTraits : public CDefaultElementTraits<  
      ATL::CComQIPtr<  I  
   ,  piid  
    >>  
  
```  
  
#### Parameters  
 `I`  
 A COM interface specifying the type of pointer to be stored.  
  
 `piid`  
 A pointer to the IID of `I`.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|[CComQIPtrElementTraits::INARGTYPE](../vs140/ccomqiptrelementtraits--inargtype.md)|The data type to use for adding elements to the collection class object.|  
  
## Remarks  
 This class derives methods and provides a typedef useful when creating a collection class of [CComQIPtr](../vs140/ccomqiptr-class.md) COM interface pointer objects. This class is utilized by both the [CInterfaceArray](../vs140/cinterfacearray-class.md) and [CInterfaceList](../vs140/cinterfacelist-class.md) classes.  
  
 For more information, see [ATL Collection Classes](../vs140/atl-collection-classes.md).  
  
## Inheritance Hierarchy  
 [CDefaultCompareTraits](../vs140/cdefaultcomparetraits-class.md)  
  
 [CDefaultHashTraits](../vs140/cdefaulthashtraits-class.md)  
  
 [CElementTraitsBase](../vs140/celementtraitsbase-class.md)  
  
 [CDefaultElementTraits](../vs140/cdefaultelementtraits-class.md)  
  
 `CComQIPtrElementTraits`  
  
## Requirements  
 **Header:** atlcoll.h  
  
##  <a name="ccomqiptrelementtraits__inargtype"></a>  CComQIPtrElementTraits::INARGTYPE  
 The data type to use for adding elements to the collection class object.  
  
```  
  
typedef I * INARGTYPE;  
  
```  
  
## See Also  
 [CDefaultElementTraits Class](../vs140/cdefaultelementtraits-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)