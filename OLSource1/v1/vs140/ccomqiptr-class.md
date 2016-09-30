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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A COM interface specifying the type of pointer to be stored.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to the IID of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CComQIPtr::CComQIPtr](../vs140/ccomqiptr--ccomqiptr.md)|Constructor.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CComQIPtr::operator =](../vs140/ccomqiptr--operator-=.md)|Assigns a pointer to the member pointer.|  
  
## Remarks  
 ATL uses <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and [CComPtr](../vs140/ccomptr-class.md) to manage COM interface pointers, both of which derive from [CComPtrBase](../vs140/ccomptrbase-class.md). Both classes perform automatic reference counting through calls to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and **Release**. Overloaded operators handle pointer operations.  
  
## Inheritance Hierarchy  
 [CComPtrBase](../vs140/ccomptrbase-class.md)  
  
 [CComPtr](../vs140/ccomptr-class.md)  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlcomcli.h  
  
##  \<a name="ccomqiptr__ccomqiptr">\</a>  CComQIPtr::CComQIPtr  
 The constructor.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Used to initialize the interface pointer.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 A COM interface.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A pointer to the IID of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
##  \<a name="ccomqiptr__operator__eq">\</a>  CComQIPtr::operator =  
 The assignment operator.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Used to initialize the interface pointer.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 A COM interface.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 A pointer to the IID of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
### Return Value  
 Returns a pointer to the updated <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.  
  
## See Also  
 [CComPtr::CComPtr](../vs140/ccomptr--ccomptr.md)   
 [CComQIPtr::CComQIPtr](../vs140/ccomqiptr--ccomqiptr.md)   
 [CComPtrBase Class](../vs140/ccomptrbase-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)   
 [CComQIPtrElementTraits Class](../vs140/ccomqiptrelementtraits-class.md)