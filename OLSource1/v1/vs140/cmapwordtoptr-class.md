---
title: "CMapWordToPtr Class"
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
  - "CMapWordToPtr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "16-bit word mapping"
  - "CMapWordToPtr class"
ms.assetid: b204d87f-6427-43e1-93e3-a4b1bb41099f
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMapWordToPtr Class
Supports maps of void pointers keyed by 16-bit words.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
 The member functions of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> are similar to the member functions of class [CMapStringToOb](../vs140/cmapstringtoob-class.md). Because of this similarity, you can use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> reference documentation for member function specifics. Wherever you see a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> pointer as a function parameter or return value, substitute a pointer to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Wherever you see a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or a **const** pointer to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> as a function parameter or return value, substitute **WORD**.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 for example, translates to  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
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
|[CMapStringToOb::operator &#91;&#93;](../vs140/cmapstringtoob-class.md#cmapstringtoob__operator_at)|Inserts an element into the map — operator substitution for <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.|  
  
## Remarks  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> incorporates the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> macro to support run-time type access and dumping to a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object. If you need a dump of individual map elements, you must set the depth of the dump context to 1 or greater.  
  
 Word-to-pointer maps may not be serialized.  
  
 When a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object is deleted, or when its elements are removed, the words and the pointers are removed. The entities referenced by the pointers are not removed.  
  
 For more information on <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, see the article [Collections](../vs140/collections.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [Base Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)