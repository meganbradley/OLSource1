---
title: "CMapPtrToWord Class"
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
  - "CMapPtrToWord"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "16-bit word mapping"
  - "CMapPtrToWord class"
ms.assetid: 4631c6b6-d49f-49d9-adc0-1e0491e32d7b
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMapPtrToWord Class
Supports maps of 16-bit words keyed by void pointers.  
  
## Syntax  
  
```  
class CMapPtrToWord : public CObject  
```  
  
## Members  
 The member functions of `CMapPtrToWord` are similar to the member functions of class [CMapStringToOb](../vs140/cmapstringtoob-class.md). Because of this similarity, you can use the `CMapStringToOb` reference documentation for member function specifics. Wherever you see a `CObject` pointer as a function parameter or return value, substitute **WORD**. Wherever you see a `CString` or a **const** pointer to `char` as a function parameter or return value, substitute a pointer to `void`.  
  
 `BOOL CMapStringToOb::Lookup( const char* <key>,`  
  
 `CObject*& <rValue> ) const;`  
  
 for example, translates to  
  
 `BOOL CMapPtrToWord::Lookup( const void* <key>, WORD& <rValue> ) const;`  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMapStringToOb::CMapStringToOb](../vs140/cmapstringtoob-class.md#cmapstringtoob__cmapstringtoob)|Constructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMapStringToOb::GetCount](../vs140/cmapstringtoob-class.md#cmapstringtoob__getcount)|Returns the number of elements in this map.|  
|[CMapStringToOb::GetHashTableSize](../vs140/cmapstringtoob-class.md#cmapstringtoob__gethashtablesize)|Determines the current number of elements in the hash table.|  
|[CMapStringToOb::GetNextAssoc](../vs140/cmapstringtoob-class.md#cmapstringtoob__getnextassoc)|Gets the next element for iterating.|  
|[CMapStringToOb::GetSize](../vs140/cmapstringtoob-class.md#cmapstringtoob__getsize)|Returns the number of elements in this map.|  
|[CMapStringToOb::GetStartPosition](../vs140/cmapstringtoob-class.md#cmapstringtoob__getstartposition)|Returns the position of the first element.|  
|[CMapStringToOb::HashKey](../vs140/cmapstringtoob-class.md#cmapstringtoob__hashkey)|Calculates the hash value of a specified key.|  
|[CMapStringToOb::InitHashTable](../vs140/cmapstringtoob-class.md#cmapstringtoob__inithashtable)|Initializes the hash table.|  
|[CMapStringToOb::IsEmpty](../vs140/cmapstringtoob-class.md#cmapstringtoob__isempty)|Tests for the empty-map condition (no elements).|  
|[CMapStringToOb::Lookup](../vs140/cmapstringtoob-class.md#cmapstringtoob__lookup)|Looks up a void pointer based on the void pointer key. The pointer value, not the entity it points to, is used for the key comparison.|  
|[CMapStringToOb::LookupKey](../vs140/cmapstringtoob-class.md#cmapstringtoob__lookupkey)|Returns a reference to the key associated with the specified key value.|  
|[CMapStringToOb::RemoveAll](../vs140/cmapstringtoob-class.md#cmapstringtoob__removeall)|Removes all the elements from this map.|  
|[CMapStringToOb::RemoveKey](../vs140/cmapstringtoob-class.md#cmapstringtoob__removekey)|Removes an element specified by a key.|  
|[CMapStringToOb::SetAt](../vs140/cmapstringtoob-class.md#cmapstringtoob__setat)|Inserts an element into the map; replaces an existing element if a matching key is found.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CMapStringToOb::operator &#91;&#93;](../vs140/cmapstringtoob-class.md#cmapstringtoob__operator_at)|Inserts an element into the map — operator substitution for `SetAt`.|  
  
## Remarks  
 `CMapWordToPtr` incorporates the `IMPLEMENT_DYNAMIC` macro to support run-time type access and dumping to a `CDumpContext` object. If you need a dump of individual map elements, you must set the depth of the dump context to 1 or greater.  
  
 Pointer-to-word maps may not be serialized.  
  
 When a `CMapPtrToWord` object is deleted, or when its elements are removed, the pointers and the words are removed. The entities referenced by the key pointers are not removed.  
  
 For more information on `CMapPtrToWord`, see the article [Collections](../vs140/collections.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 `CMapPtrToWord`  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [Base Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)