---
title: "CStringArray Class"
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
  - "CStringArray"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "string arrays"
  - "arrays [C++], strings"
  - "CStringArray class"
  - "strings [C++], collections"
ms.assetid: 6c637e06-bba8-4c08-b0fc-cf8cb067ce34
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringArray Class
Supports arrays of [CString](../vs140/using-cstring.md) objects.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
 The member functions of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> are similar to the member functions of class [CObArray](../vs140/cobarray-class.md). Because of this similarity, you can use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> reference documentation for member function specifics. Wherever you see a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> pointer as a return value, substitute a [CString](../vs140/using-cstring.md) object (not a [CString](../vs140/using-cstring.md) pointer). Wherever you see a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> pointer as a function parameter, substitute a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 for example, translates to  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 and  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 translates to  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
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
|[CObArray::ElementAt](../vs140/cobarray-class.md#cobarray__elementat)|Returns a temporary reference to the element pointer within the array.|  
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
|[CObArray::operator &#91;&#93;](../vs140/cobarray-class.md#cobarray__operator_at)|Sets or gets the element at the specified index.|  
  
## Remarks  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> incorporates the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> macro to support serialization and dumping of its elements. If an array of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> objects is stored to an archive, either with an overloaded insertion operator or with the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> member function, each element is serialized in turn.  
  
> [!NOTE]
>  Before using an array, use <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to establish its size and allocate memory for it. If you do not use <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, adding elements to your array causes it to be frequently reallocated and copied. Frequent reallocation and copying are inefficient and can fragment memory.  
  
 If you need a dump of individual string elements in the array, you must set the depth of the dump context to 1 or greater.  
  
 When a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> array is deleted, or when its elements are removed, string memory is freed as appropriate.  
  
 For more information on using <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, see the article [Collections](../vs140/collections.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [Base Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)