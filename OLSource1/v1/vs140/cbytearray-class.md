---
title: "CByteArray Class"
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
  - "CByteArray"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CByteArray class"
  - "byte arrays"
  - "arrays [C++], byte"
  - "MFC collection classes, byte arrays"
ms.assetid: 53d4a512-657c-4187-9609-e3f5339a78e0
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CByteArray Class
Supports dynamic arrays of bytes.  
  
## Syntax  
  
```  
class CByteArray : public CObject  
```  
  
## Members  
 The member functions of `CByteArray` are similar to the member functions of class [CObArray](../vs140/cobarray-class.md). Because of this similarity, you can use the `CObArray` reference documentation for member function specifics. Wherever you see a `CObject` pointer as a function parameter or return value, substitute a **BYTE**.  
  
 `CObject* CObArray::GetAt( int <nIndex> ) const;`  
  
 for example, translates to  
  
 `BYTE CByteArray::GetAt( int <nIndex> ) const;`  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CObArray::CObArray](../vs140/cobarray-class.md#cobarray__cobarray)|Constructs an empty array.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CObArray::Add](../vs140/cobarray-class.md#cobarray__add)|Adds an element to the end of the array; grows the array if necessary.|  
|[CObArray::Append](../vs140/cobarray-class.md#cobarray__append)|Appends another array to the array; grows the array if necessary.|  
|[CObArray::Copy](../vs140/cobarray-class.md#cobarray__copy)|Copies another array to the array; grows the array if necessary.|  
|[CObArray::ElementAt](../vs140/cobarray-class.md#cobarray__elementat)|Returns a temporary reference to the byte within the array.|  
|[CObArray::FreeExtra](../vs140/cobarray-class.md#cobarray__freeextra)|Frees all unused memory above the current upper bound.|  
|[CObArray::GetAt](../vs140/cobarray-class.md#cobarray__getat)|Returns the value at a given index.|  
|[CObArray::GetCount](../vs140/cobarray-class.md#cobarray__getcount)|Gets the number of elements in this array.|  
|[CObArray::GetData](../vs140/cobarray-class.md#cobarray__getdata)|Allows access to elements in the array. Can be **NULL**.|  
|[CObArray::GetSize](../vs140/cobarray-class.md#cobarray__getsize)|Gets the number of elements in this array.|  
|[CObArray::GetUpperBound](../vs140/cobarray-class.md#cobarray__getupperbound)|Returns the largest valid index.|  
|[CObArray::InsertAt](../vs140/cobarray-class.md#cobarray__insertat)|Inserts an element (or all the elements in another array) at a specified index.|  
|[CObArray::IsEmpty](../vs140/cobarray-class.md#cobarray__isempty)|Determines if the array is empty.|  
|[CObArray::RemoveAll](../vs140/cobarray-class.md#cobarray__removeall)|Removes all the elements from this array.|  
|[CObArray::RemoveAt](../vs140/cobarray-class.md#cobarray__removeat)|Removes an element at a specific index.|  
|[CObArray::SetAt](../vs140/cobarray-class.md#cobarray__setat)|Sets the value for a given index; array not allowed to grow.|  
|[CObArray::SetAtGrow](../vs140/cobarray-class.md#cobarray__setatgrow)|Sets the value for a given index; grows the array if necessary.|  
|[CObArray::SetSize](../vs140/cobarray-class.md#cobarray__setsize)|Sets the number of elements to be contained in this array.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[operator&#91;&#93;](../vs140/cobarray-class.md#cobarray__operator_at)|Sets or gets the element at the specified index.|  
  
## Remarks  
 `CByteArray` incorporates the `IMPLEMENT_SERIAL` macro to support serialization and dumping of its elements. If an array of bytes is stored to an archive, either with the overloaded insertion ( **<<**) operator or with the `Serialize` member function, each element is, in turn, serialized.  
  
> [!NOTE]
>  Before using an array, use `SetSize` to establish its size and allocate memory for it. If you do not use `SetSize`, adding elements to your array causes it to be frequently reallocated and copied. Frequent reallocation and copying are inefficient and can fragment memory.  
  
 If you need debug output from individual elements in the array, you must set the depth of the `CDumpContext` object to 1 or greater.  
  
 For more information on using `CByteArray`, see the article [Collections](../vs140/collections.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 `CByteArray`  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [Base Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObArray](../vs140/cobarray-class.md)