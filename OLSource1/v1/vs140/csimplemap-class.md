---
title: "CSimpleMap Class"
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
  - "ATL::CSimpleMap"
  - "ATL.CSimpleMap"
  - "CSimpleMap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSimpleMap class"
ms.assetid: 61b06eb4-ae73-44b0-a305-0afb5a33e8b1
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleMap Class
This class provides support for a simple mapping array.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 The key element type.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The value element type.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 A trait object, defining the equality test for elements of type <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|[CSimpleMap::_ArrayElementType](../vs140/csimplemap--_arrayelementtype.md)|Typedef for the value type.|  
|[CSimpleMap::_ArrayKeyType](../vs140/csimplemap--_arraykeytype.md)|Typedef for the key type.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CSimpleMap::CSimpleMap](../vs140/csimplemap--csimplemap.md)|The constructor.|  
|[CSimpleMap::~CSimpleMap](../vs140/csimplemap--~csimplemap.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CSimpleMap::Add](../vs140/csimplemap--add.md)|Adds a key and associated value to the map array.|  
|[CSimpleMap::FindKey](../vs140/csimplemap--findkey.md)|Finds a specific key.|  
|[CSimpleMap::FindVal](../vs140/csimplemap--findval.md)|Finds a specific value.|  
|[CSimpleMap::GetKeyAt](../vs140/csimplemap--getkeyat.md)|Retrieves the specified key.|  
|[CSimpleMap::GetSize](../vs140/csimplemap--getsize.md)|Returns the number of entries in the mapping array.|  
|[CSimpleMap::GetValueAt](../vs140/csimplemap--getvalueat.md)|Retrieves the specified value.|  
|[CSimpleMap::Lookup](../vs140/csimplemap--lookup.md)|Returns the value associated with the given key.|  
|[CSimpleMap::Remove](../vs140/csimplemap--remove.md)|Removes a key and matching value.|  
|[CSimpleMap::RemoveAll](../vs140/csimplemap--removeall.md)|Removes all keys and values.|  
|[CSimpleMap::RemoveAt](../vs140/csimplemap--removeat.md)|Removes a specific key and matching value.|  
|[CSimpleMap::ReverseLookup](../vs140/csimplemap--reverselookup.md)|Returns the key associated with the given value.|  
|[CSimpleMap::SetAt](../vs140/csimplemap--setat.md)|Sets the value associated with the given key.|  
|[CSimpleMap::SetAtIndex](../vs140/csimplemap--setatindex.md)|Sets the specific key and value.|  
  
## Remarks  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> provides support for a simple mapping array of any given type <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, managing an unordered array of key elements and their associated values.  
  
 The parameter <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> provides a means of defining an equality function for two elements of type <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. By creating a class similar to [CSimpleMapEqualHelper](../vs140/csimplemapequalhelper-class.md), it is possible to alter the behavior of the equality test for any given array. For example, when dealing with an array of pointers, it may be useful to define the equality as depending on the values the pointers reference. The default implementation utilizes **operator==()**.  
  
 Both <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and [CSimpleArray](../vs140/csimplearray-class.md) are provided for compatibility with previous ATL releases, and more complete and efficient collection implementations are provided by [CAtlArray](../vs140/catlarray-class.md) and [CAtlMap](../vs140/catlmap-class.md).  
  
 Unlike other map collections in ATL and MFC, this class is implemented with a simple array, and lookup searches require a linear search. <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> should be used when the array contains a large number of elements.  
  
## Requirements  
 **Header:** atlsimpcoll.h  
  
## Example  
 [!code[NVC_ATL_Utilities#91](../vs140/codesnippet/CPP/csimplemap-class_1.cpp)]  
  
##  \<a name="csimplemap__add">\</a>  CSimpleMap::Add  
 Adds a key and associated value to the map array.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 The key.  
  
 *val*  
 The associated value.  
  
### Return Value  
 Returns TRUE if the key and value were successfully added, FALSE otherwise.  
  
### Remarks  
 Each key and value pair added causes the mapping array memory to be freed and reallocated, in order to ensure the data for each is always stored contiguously. That is, the second key element always directly follows the first key element in memory and so on.  
  
##  \<a name="csimplemap___arrayelementtype">\</a>  CSimpleMap::_ArrayElementType  
 A typedef for the key type.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="csimplemap___arraykeytype">\</a>  CSimpleMap::_ArrayKeyType  
 A typedef for the value type.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="csimplemap__csimplemap">\</a>  CSimpleMap::CSimpleMap  
 The constructor.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 Initializes the data members.  
  
##  \<a name="csimplemap___dtorcsimplemap">\</a>  CSimpleMap::~CSimpleMap  
 The destructor.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 Frees all allocated resources.  
  
##  \<a name="csimplemap__findkey">\</a>  CSimpleMap::FindKey  
 Finds a specific key.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The key to search for.  
  
### Return Value  
 Returns the index of the key if found, otherwise returns -1.  
  
##  \<a name="csimplemap__findval">\</a>  CSimpleMap::FindVal  
 Finds a specific value.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 *val*  
 The value for which to search.  
  
### Return Value  
 Returns the index of the value if it is found, otherwise returns -1.  
  
##  \<a name="csimplemap__getkeyat">\</a>  CSimpleMap::GetKeyAt  
 Retrieves the key at the specified index.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The index of the key to return.  
  
### Return Value  
 Returns the key referenced by <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
### Remarks  
 The index passed by <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> must be valid for the return value to be meaningful.  
  
##  \<a name="csimplemap__getsize">\</a>  CSimpleMap::GetSize  
 Returns the number of entries in the mapping array.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 Returns the number of entries (a key and value is one entry) in the mapping array.  
  
##  \<a name="csimplemap__getvalueat">\</a>  CSimpleMap::GetValueAt  
 Retrieves the value at the specific index.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 The index of the value to return.  
  
### Return Value  
 Returns the value referenced by <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
### Remarks  
 The index passed by <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> must be valid for the return value to be meaningful.  
  
##  \<a name="csimplemap__lookup">\</a>  CSimpleMap::Lookup  
 Returns the value associated with the given key.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 The key.  
  
### Return Value  
 Returns the associated value. If no matching key is found, NULL is returned.  
  
##  \<a name="csimplemap__remove">\</a>  CSimpleMap::Remove  
 Removes a key and matching value.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The key.  
  
### Return Value  
 Returns TRUE if the key, and matching value, were successfully removed, FALSE otherwise.  
  
##  \<a name="csimplemap__removeall">\</a>  CSimpleMap::RemoveAll  
 Removes all keys and values.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Remarks  
 Removes all keys and values from the mapping array object.  
  
##  \<a name="csimplemap__removeat">\</a>  CSimpleMap::RemoveAt  
 Removes a key and associated value at the specified index.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 The index of the key and associated value to remove.  
  
### Return Value  
 Returns TRUE on success, FALSE if the index specified is an invalid index.  
  
##  \<a name="csimplemap__reverselookup">\</a>  CSimpleMap::ReverseLookup  
 Returns the key associated with the given value.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 *val*  
 The value.  
  
### Return Value  
 Returns the associated key. If no matching key is found, NULL is returned.  
  
##  \<a name="csimplemap__setat">\</a>  CSimpleMap::SetAt  
 Sets the value associated with the given key.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The key.  
  
 *val*  
 The new value to assign.  
  
### Return Value  
 Returns TRUE if the key was found, and the value was successfully changed, FALSE otherwise.  
  
##  \<a name="csimplemap__setatindex">\</a>  CSimpleMap::SetAtIndex  
 Sets the key and value at a specified index.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 The index, referencing the key and value pairing to change.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 The new key.  
  
 *val*  
 The new value.  
  
### Return Value  
 Returns TRUE if successful, FALSE if the index was not valid.  
  
### Remarks  
 Updates both the key and value pointed to by <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)