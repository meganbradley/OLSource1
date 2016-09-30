---
title: "CMap Class"
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
  - "CMap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "dictionary mapping class"
  - "collection classes, dictionary mapping"
  - "CMap class"
ms.assetid: 640a45ab-0993-4def-97ec-42cc78eb10b9
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMap Class
A dictionary collection class that maps unique keys to values.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Class of the object used as the key to the map.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> *_* <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 Data type used for <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> arguments; usually a reference to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 Class of the object stored in the map.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> *_* <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 Data type used for <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> arguments; usually a reference to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
## Members  
  
### Public Structures  
  
|Name|Description|  
|----------|-----------------|  
|[CMap::CPair](#cmap__cpair)|A nested structure containing a key value and the value of the associated object.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMap::CMap](#cmap__cmap)|Constructs a collection that maps keys to values.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMap::GetCount](#cmap__getcount)|Returns the number of elements in this map.|  
|[CMap::GetHashTableSize](#cmap__gethashtablesize)|Returns the number of elements in the hash table.|  
|[CMap::GetNextAssoc](#cmap__getnextassoc)|Gets the next element for iterating.|  
|[CMap::GetSize](#cmap__getsize)|Returns the number of elements in this map.|  
|[CMap::GetStartPosition](#cmap__getstartposition)|Returns the position of the first element.|  
|[CMap::InitHashTable](#cmap__inithashtable)|Initializes the hash table and specifies its size.|  
|[CMap::IsEmpty](#cmap__isempty)|Tests for the empty-map condition (no elements).|  
|[CMap::Lookup](#cmap__lookup)|Looks up the value mapped to a given key.|  
|[CMap::PGetFirstAssoc](#cmap__pgetfirstassoc)|Returns a pointer to the first element.|  
|[CMap::PGetNextAssoc](#cmap__pgetnextassoc)|Gets a pointer to the next element for iterating.|  
|[CMap::PLookup](#cmap__plookup)|Returns a pointer to a key whose value matches the specified value.|  
|[CMap::RemoveAll](#cmap__removeall)|Removes all the elements from this map.|  
|[CMap::RemoveKey](#cmap__removekey)|Removes an element specified by a key.|  
|[CMap::SetAt](#cmap__setat)|Inserts an element into the map; replaces an existing element if a matching key is found.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CMap::operator &#91;&#93;](#cmap__operator_at)|Inserts an element into the map â€” operator substitution for <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.|  
  
## Remarks  
 Once you have inserted a key-value pair (element) into the map, you can efficiently retrieve or delete the pair using the key to access it. You can also iterate over all the elements in the map.  
  
 A variable of type **POSITION** is used for alternate access to entries. You can use a **POSITION** to "remember" an entry and to iterate through the map. You might think that this iteration is sequential by key value; it is not. The sequence of retrieved elements is indeterminate.  
  
 Certain member functions of this class call global helper functions that must be customized for most uses of the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> class. See [Collection Class Helpers](../vs140/collection-class-helpers.md) in the Macros and Globals section of the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> overrides [CObject::Serialize](../vs140/cobject-class.md#cobject__serialize) to support serialization and dumping of its elements. If a map is stored to an archive using <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, each map element is serialized in turn. The default implementation of the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> helper function does a bitwise write. For information about serialization of pointer collection items derived from <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> or other user defined types, see [How to: Make a Type-Safe Collection](../vs140/how-to--make-a-type-safe-collection.md).  
  
 If you need a diagnostic dump of the individual elements in the map (the keys and values), you must set the depth of the dump context to 1 or greater.  
  
 When a <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object is deleted, or when its elements are removed, the keys and values both are removed.  
  
 Map class derivation is similar to list derivation. See the article [Collections](../vs140/collections.md) for an illustration of the derivation of a special-purpose list class.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxtempl.h  
  
##  \<a name="cmap__cmap">\</a>  CMap::CMap  
 Constructs an empty map.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 Specifies the memory-allocation granularity for extending the map.  
  
### Remarks  
 As the map grows, memory is allocated in units of <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> entries.  
  
### Example  
 [!code[NVC_MFCCollections#56](../vs140/codesnippet/CPP/cmap-class_1.cpp)]  
  
##  \<a name="cmap__cpair">\</a>  CMap::CPair  
 Contains a key value and the value of the associated object.  
  
### Remarks  
 This is a nested structure within class [CMap](../vs140/cmap-class.md).  
  
 The structure is composed of two fields:  
  
-   **keyÂ Â Â** The actual value of the key type.  
  
-   **valueÂ Â Â** The value of the associated object.  
  
 It is used to store the return values from [CMap::PLookup](#cmap__plookup), [CMap::PGetFirstAssoc](#cmap__pgetfirstassoc), and [CMap::PGetNextAssoc](#cmap__pgetnextassoc).  
  
### Example  
 For an example of usage, see the example for [CMap::PLookup](#cmap__plookup).  
  
##  \<a name="cmap__getcount">\</a>  CMap::GetCount  
 Retrieves the number of elements in the map.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 The number of elements.  
  
### Example  
 See the example for [CMap::Lookup](#cmap__lookup).  
  
##  \<a name="cmap__gethashtablesize">\</a>  CMap::GetHashTableSize  
 Determines the number of elements in the hash table for the map.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 The number of elements in the hash table.  
  
### Example  
 [!code[NVC_MFCCollections#57](../vs140/codesnippet/CPP/cmap-class_2.cpp)]  
  
##  \<a name="cmap__getnextassoc">\</a>  CMap::GetNextAssoc  
 Retrieves the map element at <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, then updates <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> to refer to the next element in the map.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 Specifies a reference to a **POSITION** value returned by a previous <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> call.  
  
 *KEY*  
 Template parameter specifying the type of the map's key.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 Specifies the returned key of the retrieved element.  
  
 *VALUE*  
 Template parameter specifying the type of the map's value.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 Specifies the returned value of the retrieved element.  
  
### Remarks  
 This function is most useful for iterating through all the elements in the map. Note that the position sequence is not necessarily the same as the key value sequence.  
  
 If the retrieved element is the last in the map, then the new value of <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> is set to **NULL**.  
  
### Example  
 See the example for [CMap::SetAt](#cmap__setat).  
  
##  \<a name="cmap__getsize">\</a>  CMap::GetSize  
 Returns the number of map elements.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 The number of items in the map.  
  
### Remarks  
 Call this method to retrieve the number of elements in the map.  
  
### Example  
 [!code[NVC_MFCCollections#58](../vs140/codesnippet/CPP/cmap-class_3.cpp)]  
  
##  \<a name="cmap__getstartposition">\</a>  CMap::GetStartPosition  
 Starts a map iteration by returning a **POSITION** value that can be passed to a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> call.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A **POSITION** value that indicates a starting position for iterating the map; or **NULL** if the map is empty.  
  
### Remarks  
 The iteration sequence is not predictable; therefore, the "first element in the map" has no special significance.  
  
### Example  
 See the example for [CMap::SetAt](#cmap__setat).  
  
##  \<a name="cmap__inithashtable">\</a>  CMap::InitHashTable  
 Initializes the hash table.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 Number of entries in the hash table.  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 If **TRUE**, allocates the hash table upon initialization; otherwise the table is allocated when needed.  
  
### Remarks  
 For best performance, the hash table size should be a prime number. To minimize collisions, the size should be roughly 20 percent larger than the largest anticipated data set.  
  
### Example  
 See the example for [CMap::Lookup](#cmap__lookup).  
  
##  \<a name="cmap__isempty">\</a>  CMap::IsEmpty  
 Determines whether the map is empty.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if this map contains no elements; otherwise 0.  
  
### Example  
 See the example for [CMap::RemoveAll](#cmap__removeall).  
  
##  \<a name="cmap__lookup">\</a>  CMap::Lookup  
 Looks up the value mapped to a given key.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 Template parameter specifying the type of the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> value.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 Specifies the key that identifies the element to be looked up.  
  
 *VALUE*  
 Specifies the type of the value to be looked up.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 Receives the looked-up value.  
  
### Return Value  
 Nonzero if the element was found; otherwise 0.  
  
### Remarks  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> uses a hashing algorithm to quickly find the map element with a key that exactly matches the given key.  
  
### Example  
 [!code[NVC_MFCCollections#58](../vs140/codesnippet/CPP/cmap-class_3.cpp)]  
  
##  \<a name="cmap__operator_at">\</a>  CMap::operator [ ]  
 A convenient substitute for the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> member function.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 *VALUE*  
 Template parameter specifying the type of the map value.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 Template parameter specifying the type of the key value.  
  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 The key used to retrieve the value from the map.  
  
### Remarks  
 Thus it can be used only on the left side of an assignment statement (an l-value). If there is no map element with the specified key, then a new element is created.  
  
 There is no "right side" (r-value) equivalent to this operator because there is a possibility that a key may not be found in the map. Use the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> member function for element retrieval.  
  
### Example  
 See the example for [CMap::Lookup](#cmap__lookup).  
  
##  \<a name="cmap__pgetfirstassoc">\</a>  CMap::PGetFirstAssoc  
 Returns the first entry of the map object.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the first entry in the map; see [CMap::CPair](#cmap__cpair). If the map contains no entries, the value is **NULL**.  
  
### Remarks  
 Call this function to return a pointer the first element in the map object.  
  
### Example  
 [!code[NVC_MFCCollections#59](../vs140/codesnippet/CPP/cmap-class_4.cpp)]  
  
##  \<a name="cmap__pgetnextassoc">\</a>  CMap::PGetNextAssoc  
 Retrieves the map element pointed to by <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 *pAssocRet*  
 Points to a map entry returned by a previous [PGetNextAssoc](#vclrfcmappgetnextassoc) or [PGetFirstAssoc](#cmap__pgetfirstassoc) call.  
  
### Return Value  
 A pointer to the next entry in the map; see [CMap::CPair](#cmap__cpair). If the element is the last in the map, the value is **NULL**.  
  
### Remarks  
 Call this method to iterate through all the elements in the map. Retrieve the first element with a call to <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> and then iterate through the map with successive calls to <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>.  
  
### Example  
 See the example for [CMap::PGetFirstAssoc](#cmap__pgetfirstassoc).  
  
##  \<a name="cmap__plookup">\</a>  CMap::PLookup  
 Finds the value mapped to a given key.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 Key for the element to be searched for.  
  
### Return Value  
 A pointer to a key structure; see [CMap::CPair](#cmap__cpair). If no match is found, <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>.  
  
### Remarks  
 Call this method to search for a map element with a key that exactly matches the given key.  
  
### Example  
 [!code[NVC_MFCCollections#60](../vs140/codesnippet/CPP/cmap-class_5.cpp)]  
  
##  \<a name="cmap__removeall">\</a>  CMap::RemoveAll  
 Removes all the values from this map by calling the global helper function **DestructElements**.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Remarks  
 The function works correctly if the map is already empty.  
  
### Example  
 [!code[NVC_MFCCollections#61](../vs140/codesnippet/CPP/cmap-class_6.cpp)]  
  
##  \<a name="cmap__removekey">\</a>  CMap::RemoveKey  
 Looks up the map entry corresponding to the supplied key; then, if the key is found, removes the entry.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 Template parameter specifying the type of the key.  
  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 Key for the element to be removed.  
  
### Return Value  
 Nonzero if the entry was found and successfully removed; otherwise 0.  
  
### Remarks  
 The **DestructElements** helper function is used to remove the entry.  
  
### Example  
 See the example for [CMap::SetAt](#cmap__setat).  
  
##  \<a name="cmap__setat">\</a>  CMap::SetAt  
 The primary means to insert an element in a map.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 Template parameter specifying the type of the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 Specifies the key of the new element.  
  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 Template parameter specifying the type of the <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 Specifies the value of the new element.  
  
### Remarks  
 First, the key is looked up. If the key is found, then the corresponding value is changed; otherwise a new key-value pair is created.  
  
### Example  
 [!code[NVC_MFCCollections#62](../vs140/codesnippet/CPP/cmap-class_7.cpp)]  
  
## See Also  
 [MFC Sample COLLECT](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)