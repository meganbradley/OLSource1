---
title: "CInterfaceArray Class"
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
  - "ATL.CInterfaceArray"
  - "CInterfaceArray"
  - "ATL::CInterfaceArray"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CInterfaceArray class"
ms.assetid: 1f29cf66-a086-4a7b-b6a8-64f73da39f79
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CInterfaceArray Class
This class provides methods useful when constructing an array of COM interface pointers.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A COM interface specifying the type of pointer to be stored.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the IID of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CInterfaceArray::CInterfaceArray](../vs140/cinterfacearray--cinterfacearray.md)|The constructor for the interface array.|  
  
## Remarks  
 This class provides a constructor and derived methods for creating an array of COM interface pointers. Use [CInterfaceList](../vs140/cinterfacelist-class.md) when a list is required.  
  
 For more information, see [ATL Collection Classes](../vs140/atl-collection-classes.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlcoll.h  
  
##  \<a name="cinterfacearray__cinterfacearray">\</a>  CInterfaceArray::CInterfaceArray  
 The constructor.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 Initializes the smart pointer array.  
  
## See Also  
 [CAtlArray Class](../vs140/catlarray-class.md)   
 [CComQIPtr Class](../vs140/ccomqiptr-class.md)   
 [CComQIPtrElementTraits Class](../vs140/ccomqiptrelementtraits-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)