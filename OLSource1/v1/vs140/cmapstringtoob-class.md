---
title: "CMapStringToOb Class"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CMapStringToOb
dev_langs: 
  - C++
helpviewer_keywords: 
  - collection classes, string mapping
  - CMapStringToOb class
  - strings [C++], class for mapping
ms.assetid: 09653980-b885-4f3a-8594-0aeb7f94c601
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMapStringToOb Class
A dictionary collection class that maps unique `CString` objects to `CObject` pointers.  
  
## Syntax  
  
```  
class CMapStringToOb : public CObject  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMapStringToOb::CMapStringToOb](#cmapstringtoob__cmapstringtoob)|Constructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMapStringToOb::GetCount](#cmapstringtoob__getcount)|Returns the number of elements in this map.|  
|[CMapStringToOb::GetHashTableSize](#cmapstringtoob__gethashtablesize)|Determines the current number of elements in the hash table.|  
|[CMapStringToOb::GetNextAssoc](#cmapstringtoob__getnextassoc)|Gets the next element for iterating.|  
|[CMapStringToOb::GetSize](#cmapstringtoob__getsize)|Returns the number of elements in this map.|  
|[CMapStringToOb::GetStartPosition](#cmapstringtoob__getstartposition)|Returns the position of the first element.|  
|[CMapStringToOb::HashKey](#cmapstringtoob__hashkey)|Calculates the hash value of a specified key.|  
|[CMapStringToOb::InitHashTable](#cmapstringtoob__inithashtable)|Initializes the hash table.|  
|[CMapStringToOb::IsEmpty](#cmapstringtoob__isempty)|Tests for the empty-map condition (no elements).|  
|[CMapStringToOb::Lookup](#cmapstringtoob__lookup)|Looks up a void pointer based on the void pointer key. The pointer value, not the entity it points to, is used for the key comparison.|  
|[CMapStringToOb::LookupKey](#cmapstringtoob__lookupkey)|Returns a reference to the key associated with the specified key value.|  
|[CMapStringToOb::RemoveAll](#cmapstringtoob__removeall)|Removes all the elements from this map.|  
|[CMapStringToOb::RemoveKey](#cmapstringtoob__removekey)|Removes an element specified by a key.|  
|[CMapStringToOb::SetAt](#cmapstringtoob__setat)|Inserts an element into the map; replaces an existing element if a matching key is found.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CMapStringToOb::operator &#91;&#93;](#cmapstringtoob__operator_at)|Inserts an element into the map — operator substitution for `SetAt`.|  
  
## Remarks  
 Once you have inserted a `CString`- `CObject*` pair (element) into the map, you can efficiently retrieve or delete the pair using a string or a `CString` value as a key. You can also iterate over all the elements in the map.  
  
 A variable of type **POSITION** is used for alternate entry access in all map variations. You can use a **POSITION** to "remember" an entry and to iterate through the map. You might think that this iteration is sequential by key value; it is not. The sequence of retrieved elements is indeterminate.  
  
 `CMapStringToOb` incorporates the `IMPLEMENT_SERIAL` macro to support serialization and dumping of its elements. Each element is serialized in turn if a map is stored to an archive, either with the overloaded insertion ( **<<**) operator or with the `Serialize` member function.  
  
 If you need a diagnostic dump of the individual elements in the map (the `CString` value and the `CObject` contents), you must set the depth of the dump context to 1 or greater.  
  
 When a `CMapStringToOb` object is deleted, or when its elements are removed, the `CString` objects and the `CObject` pointers are removed. The objects referenced by the `CObject` pointers are not destroyed.  
  
 Map class derivation is similar to list derivation. See the article [Collections](../vs140/collections.md) for an illustration of the derivation of a special-purpose list class.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 `CMapStringToOb`  
  
## Requirements  
 **Header:** afxcoll.h  
  
##  <a name="cmapstringtoob__cmapstringtoob"></a>  CMapStringToOb::CMapStringToOb  
 Constructs an empty `CString`-to- `CObject*` map.  
  
```  
CMapStringToOb(    INT_PTR nBlockSize = 10 );  
  
```  
  
### Parameters  
 `nBlockSize`  
 Specifies the memory-allocation granularity for extending the map.  
  
### Remarks  
 As the map grows, memory is allocated in units of `nBlockSize` entries.  
  
 The following table shows other member functions that are similar to **CMapStringToOb:: CMapStringToOb**.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**CMapPtrToPtr( INT_PTR**  `nBlockSize`  **= 10 );**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**CMapPtrToWord( INT_PTR**  `nBlockSize`  **= 10 );**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**CMapStringToPtr( INT_PTR**  `nBlockSize`  **= 10 );**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**CMapStringToString( INT_PTR**  `nBlockSize`  **= 10 );**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**CMapWordToOb( INT_PTR**  `nBlockSize`  **= 10 );**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**MapWordToPtr( INT_PTR**  `nBlockSize`  **= 10 );**|  
  
### Example  
 [!code[NVC_MFCCollections#63](../vs140/codesnippet/CPP/cmapstringtoob-class_1.cpp)]
  
  
 See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the `CAge` class used in all collection examples.  
  
##  <a name="cmapstringtoob__getcount"></a>  CMapStringToOb::GetCount  
 Determines how many elements are in the map.  
  
```  
INT_PTR GetCount( ) const;  
  
```  
  
### Return Value  
 The number of elements in this map.  
  
### Remarks  
 The following table shows other member functions that are similar to `CMapStringToOb::GetCount`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**INT_PTR GetCount( ) const;**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**INT_PTR GetCount( ) const;**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**INT_PTR GetCount( ) const;**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**INT_PTR GetCount( ) const;**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**INT_PTR GetCount( ) const;**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**INT_PTR GetCount( ) const;**|  
  
### Example  
 See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the `CAge` class used in all collection examples.  
  
 [!code[NVC_MFCCollections#64](../vs140/codesnippet/CPP/cmapstringtoob-class_2.cpp)]
  
  
##  <a name="cmapstringtoob__gethashtablesize"></a>  CMapStringToOb::GetHashTableSize  
 Determines the current number of elements in the hash table.  
  
```  
UINT GetHashTableSize( ) const;  
  
```  
  
### Return Value  
 Returns the number of elements in the hash table.  
  
### Remarks  
 The following table shows other member functions that are similar to `CMapStringToOb::GetHashTableSize`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**UINT GetHashTableSize( ) const;**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**UINT GetHashTableSize( ) const;**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**UINT GetHashTableSize( ) const;**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**UINT GetHashTableSize( ) const;**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**UINT GetHashTableSize( ) const;**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**UINT GetHashTableSize( ) const;**|  
  
##  <a name="cmapstringtoob__getnextassoc"></a>  CMapStringToOb::GetNextAssoc  
 Retrieves the map element at                 *rNextPosition*, then updates                 *rNextPosition* to refer to the next element in the map.  
  
```  
void GetNextAssoc(    POSITION& rNextPosition ,    CString& rKey ,    CObject*& rValue ) const;  
  
```  
  
### Parameters  
 *rNextPosition*  
 Specifies a reference to a **POSITION** value returned by a previous **GetNextAssoc** or **GetStartPosition** call.  
  
 *rKey*  
 Specifies the returned key of the retrieved element (a string).  
  
 *rValue*  
 Specifies the returned value of the retrieved element (a **CObject** pointer). See Remarks for more about this parameter.  
  
### Remarks  
 This function is most useful for iterating through all the elements in the map. Note that the position sequence is not necessarily the same as the key value sequence.  
  
 If the retrieved element is the last in the map, then the new value of                         *rNextPosition* is set to **NULL**.  
  
 For the                         *rValue* parameter, be sure to cast your object type to **CObject\*&**, which is what the compiler requires, as shown in the following example:  
  
 [!code[NVC_MFCCollections#65](../vs140/codesnippet/CPP/cmapstringtoob-class_3.cpp)]
  
  
 This is not true of **GetNextAssoc** for maps based on templates.  
  
 The following table shows other member functions that are similar to **CMapStringToOb::GetNextAssoc**.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**void GetNextAssoc( POSITION&**  *rNextPosition* **, void\*&**  *rKey* **, void\*&**  *rValue*  **) const;**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**void GetNextAssoc( POSITION&**  *rNextPosition* **, void\*&**  *rKey* **, WORD&**  *rValue*  **) const;**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**void GetNextAssoc( POSITION&**  *rNextPosition* **, CString&**  *rKey* **, void\*&**  *rValue*  **) const;**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**void GetNextAssoc( POSITION&**  *rNextPosition* **, CString&**  *rKey* **, CString&**  *rValue*  **) const;**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**void GetNextAssoc( POSITION&**  *rNextPosition* **, WORD&**  *rKey* **, CObject\*&**  *rValue*  **) const;**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**void GetNextAssoc( POSITION&**  *rNextPosition* **, WORD&**  *rKey* **, void\*&**  *rValue*  **) const;**|  
  
### Example  
 See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the `CAge` class used in all collection examples.  
  
 [!code[NVC_MFCCollections#66](../vs140/codesnippet/CPP/cmapstringtoob-class_4.cpp)]
  
  
 The results from this program are as follows:  
  
 `Lisa : a CAge at $4724 11`  
  
 `Marge : a CAge at $47A8 35`  
  
 `Homer : a CAge at $4766 36`  
  
 `Bart : a CAge at $45D4 13`  
  
##  <a name="cmapstringtoob__getsize"></a>  CMapStringToOb::GetSize  
 Returns the number of map elements.  
  
```  
INT_PTR GetSize( ) const;  
  
```  
  
### Return Value  
 The number of items in the map.  
  
### Remarks  
 Call this method to retrieve the number of elements in the map.  
  
 The following table shows other member functions that are similar to `CMapStringToOb::GetSize`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**INT_PTR GetSize( ) const;**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**INT_PTR GetSize( ) const;**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**INT_PTR GetSize( ) const;**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**INT_PTR GetSize( ) const;**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**INT_PTR GetSize( ) const;**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**INT_PTR GetSize( ) const;**|  
  
### Example  
 [!code[NVC_MFCCollections#67](../vs140/codesnippet/CPP/cmapstringtoob-class_5.cpp)]
  
  
##  <a name="cmapstringtoob__getstartposition"></a>  CMapStringToOb::GetStartPosition  
 Starts a map iteration by returning a **POSITION** value that can be passed to a `GetNextAssoc` call.  
  
```  
POSITION GetStartPosition( ) const;  
  
```  
  
### Return Value  
 A **POSITION** value that indicates a starting position for iterating the map; or **NULL** if the map is empty.  
  
### Remarks  
 The iteration sequence is not predictable; therefore, the "first element in the map" has no special significance.  
  
 The following table shows other member functions that are similar to `CMapStringToOb::GetStartPosition`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**POSITION GetStartPosition( ) const;**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**POSITION GetStartPosition( ) const;**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**POSITION GetStartPosition( ) const;**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**POSITION GetStartPosition( ) const;**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**POSITION GetStartPosition( ) const;**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**POSITION GetStartPosition( ) const;**|  
  
### Example  
 See the example for [CMapStringToOb::GetNextAssoc](#cmapstringtoob__getnextassoc).  
  
##  <a name="cmapstringtoob__hashkey"></a>  CMapStringToOb::HashKey  
 Calculates the hash value of a specified key.  
  
```  
UINT HashKey(    LPCTSTR  key ) const;  
  
```  
  
### Parameters  
 `key`  
 The key whose hash value is to be calculated.  
  
### Return Value  
 The Key's hash value  
  
### Remarks  
 The following table shows other member functions that are similar to `CMapStringToOb::HashKey`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**UINT HashKey( void\***  `key`  **) const;**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**UINT HashKey( void\***  `key`  **) const;**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**UINT HashKey( LPCTSTR**  `key`  **) const;**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**UINT HashKey( LPCTSTR**  `key`  **) const;**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**UINT HashKey( WORD**  `key`  **) const;**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**UINT HashKey( WORD**  `key`  **) const;**|  
  
##  <a name="cmapstringtoob__inithashtable"></a>  CMapStringToOb::InitHashTable  
 Initializes the hash table.  
  
```  
void InitHashTable(    UINT  hashSize ,    BOOL  bAllocNow  = TRUE );  
  
```  
  
### Parameters  
 `hashSize`  
 Number of entries in the hash table.  
  
 `bAllocNow`  
 If **TRUE**, allocates the hash table upon initialization; otherwise the table is allocated when needed.  
  
### Remarks  
 For best performance, the hash table size should be a prime number. To minimize collisions, the size should be roughly 20 percent larger than the largest anticipated data set.  
  
 The following table shows other member functions that are similar to `CMapStringToOb::InitHashTable`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**void InitHashTable( UINT**  `hashSize` **, BOOL**  `bAllocNow`  **= TRUE );**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**void InitHashTable( UINT**  `hashSize` **, BOOL**  `bAllocNow`  **= TRUE );**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**void InitHashTable( UINT**  `hashSize` **, BOOL**  `bAllocNow`  **= TRUE );**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**void InitHashTable( UINT**  `hashSize` **, BOOL**  `bAllocNow`  **= TRUE );**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**void InitHashTable( UINT**  `hashSize` **, BOOL**  `bAllocNow`  **= TRUE );**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**void InitHashTable( UINT**  `hashSize` **, BOOL**  `bAllocNow`  **= TRUE );**|  
  
##  <a name="cmapstringtoob__isempty"></a>  CMapStringToOb::IsEmpty  
 Determines whether the map is empty.  
  
```  
BOOL IsEmpty( ) const;  
  
```  
  
### Return Value  
 Nonzero if this map contains no elements; otherwise 0.  
  
### Example  
 See the example for [RemoveAll](#cmapstringtoob__removeall).  
  
### Remarks  
 The following table shows other member functions that are similar to **CMapStringToOb:: IsEmpty**.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**BOOL IsEmpty( ) const;**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**BOOL IsEmpty( ) const;**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**BOOL IsEmpty( ) const;**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**BOOL IsEmpty( ) const;**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**BOOL IsEmpty( ) const;**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**BOOL IsEmpty( ) const;**|  
  
##  <a name="cmapstringtoob__lookup"></a>  CMapStringToOb::Lookup  
 Returns a `CObject` pointer based on a `CString` value.  
  
```  
BOOL Lookup(    LPCTSTR key ,    CObject*& rValue ) const;  
  
```  
  
### Parameters  
 `key`  
 Specifies the string key that identifies the element to be looked up.  
  
 `rValue`  
 Specifies the returned value from the looked-up element.  
  
### Return Value  
 Nonzero if the element was found; otherwise 0.  
  
### Remarks  
 `Lookup` uses a hashing algorithm to quickly find the map element with a key that matches exactly ( `CString` value).  
  
 The following table shows other member functions that are similar to `CMapStringToOb::LookUp`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**BOOL Lookup( void\***  `key` **, void\*&**  `rValue`  **) const;**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**BOOL Lookup( void\***  `key` **, WORD&**  `rValue`  **) const;**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**BOOL Lookup( LPCTSTR**  `key` **, void\*&**  `rValue`  **) const;**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**BOOL Lookup( LPCTSTR**  `key` **, CString&**  `rValue`  **) const;**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**BOOL Lookup( WORD**  `key` **, CObject\*&**  `rValue`  **) const;**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**BOOL Lookup( WORD**  `key` **, void\*&**  `rValue`  **) const;**|  
  
### Example  
 See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the `CAge` class used in all collection examples.  
  
 [!code[NVC_MFCCollections#68](../vs140/codesnippet/CPP/cmapstringtoob-class_6.cpp)]
  
  
##  <a name="cmapstringtoob__lookupkey"></a>  CMapStringToOb::LookupKey  
 Returns a reference to the key associated with the specified key value.  
  
```  
BOOL LookupKey(    LPCTSTR  key ,    LPCTSTR&  rKey ) const;  
  
```  
  
### Parameters  
 `key`  
 Specifies the string key that identifies the element to be looked up.  
  
 `rKey`  
 The reference to the associated key.  
  
### Return Value  
 Nonzero if the key was found; otherwise 0.  
  
### Remarks  
 Using a reference to a key is unsafe if used after the associated element was removed from the map or after the map was destroyed.  
  
 The following table shows other member functions that are similar to **CMapStringToOb:: LookupKey**.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**BOOL LookupKey( LPCTSTR**  `key` **, LPCTSTR&** `rKey`  **) const;**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**BOOL LookupKey( LPCTSTR**  `key` **, LPCTSTR&** `rKey`  **) const;**|  
  
##  <a name="cmapstringtoob__operator_at"></a>  CMapStringToOb::operator [ ]  
 A convenient substitute for the `SetAt` member function.  
  
```  
CObject*& operator [ ](LPCTSTR key);  
  
```  
  
### Return Value  
 A reference to a pointer to a `CObject` object; or **NULL** if the map is empty or `key` is out of range.  
  
### Remarks  
 Thus it can be used only on the left side of an assignment statement (an l-value). If there is no map element with the specified key, then a new element is created.  
  
 There is no "right side" (r-value) equivalent to this operator because there is a possibility that a key may not be found in the map. Use the `Lookup` member function for element retrieval.  
  
 The following table shows other member functions that are similar to **CMapStringToOb::operator []**.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**void\*& operator[](void\***  `key`  **\);**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**WORD& operator[](void\***  `key`  **\);**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**void\*& operator[](LPCTSTR**  `key`  **\);**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**CString& operator[](LPCTSTR**  `key`  **\);**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**CObject\*& operator[](WORD**  `key`  **\);**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**void\*& operator[](WORD**  `key`  **\);**|  
  
### Example  
 See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the `CAge` class used in all collection examples.  
  
 [!code[NVC_MFCCollections#72](../vs140/codesnippet/CPP/cmapstringtoob-class_7.cpp)]
  
  
 The results from this program are as follows:  
  
 `Operator [] example: A CMapStringToOb with 2 elements`  
  
 `[Lisa] = a CAge at $4A02 11`  
  
 `[Bart] = a CAge at $497E 13`  
  
##  <a name="cmapstringtoob__removeall"></a>  CMapStringToOb::RemoveAll  
 Removes all the elements from this map and destroys the `CString` key objects.  
  
```  
void RemoveAll( );  
  
```  
  
### Remarks  
 The `CObject` objects referenced by each key are not destroyed. The `RemoveAll` function can cause memory leaks if you do not ensure that the referenced `CObject` objects are destroyed.  
  
 The function works correctly if the map is already empty.  
  
 The following table shows other member functions that are similar to `CMapStringToOb::RemoveAll`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**void RemoveAll( );**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**void RemoveAll( );**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**void RemoveAll( );**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**void RemoveAll( );**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**void RemoveAll( );**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**void RemoveAll( );**|  
  
### Example  
 See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the `CAge` class used in all collection examples.  
  
 [!code[NVC_MFCCollections#69](../vs140/codesnippet/CPP/cmapstringtoob-class_8.cpp)]
  
  
##  <a name="cmapstringtoob__removekey"></a>  CMapStringToOb::RemoveKey  
 Looks up the map entry corresponding to the supplied key; then, if the key is found, removes the entry.  
  
```  
BOOL RemoveKey(    LPCTSTR key );  
  
```  
  
### Parameters  
 `key`  
 Specifies the string used for map lookup.  
  
### Return Value  
 Nonzero if the entry was found and successfully removed; otherwise 0.  
  
### Remarks  
 This can cause memory leaks if the `CObject` object is not deleted elsewhere.  
  
 The following table shows other member functions that are similar to `CMapStringToOb::RemoveKey`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**BOOL RemoveKey( void\***  `key`  **);**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**BOOL RemoveKey( void\***  `key`  **);**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**BOOL RemoveKey( LPCTSTR**  `key`  **);**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**BOOL RemoveKey( LPCTSTR**  `key`  **);**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**BOOL RemoveKey( WORD**  `key`  **);**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**BOOL RemoveKey( WORD**  `key`  **);**|  
  
### Example  
 See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the `CAge` class used in all collection examples.  
  
 [!code[NVC_MFCCollections#70](../vs140/codesnippet/CPP/cmapstringtoob-class_9.cpp)]
  
  
 The results from this program are as follows:  
  
 `RemoveKey example: A CMapStringToOb with 3 elements`  
  
 `[Marge] = a CAge at $49A0 35`  
  
 `[Homer] = a CAge at $495E 36`  
  
 `[Bart] = a CAge at $4634 13`  
  
##  <a name="cmapstringtoob__setat"></a>  CMapStringToOb::SetAt  
 The primary means to insert an element in a map.  
  
```  
void SetAt(    LPCTSTR key ,    CObject* newValue );  
  
```  
  
### Parameters  
 `key`  
 Specifies the string that is the key of the new element.  
  
 `newValue`  
 Specifies the `CObject` pointer that is the value of the new element.  
  
### Remarks  
 First, the key is looked up. If the key is found, then the corresponding value is changed; otherwise a new key-value element is created.  
  
 The following table shows other member functions that are similar to `CMapStringToOb::SetAt`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**void SetAt( void\***  `key` **, void\***  `newValue`  **);**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**void SetAt( void\***  `key` **, WORD**  `newValue`  **);**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**void SetAt( LPCTSTR**  `key` **, void\***  `newValue`  **);**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**void SetAt( LPCTSTR**  `key` **, LPCTSTR**  `newValue`  **);**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**void SetAt( WORD**  `key` **, CObject\***  `newValue`  **);**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**void SetAt( WORD**  `key` **, void\***  `newValue`  **);**|  
  
### Example  
 See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the `CAge` class used in all collection examples.  
  
 [!code[NVC_MFCCollections#71](../vs140/codesnippet/CPP/cmapstringtoob-class_10.cpp)]
  
  
 The results from this program are as follows:  
  
 `before Lisa's birthday: A CMapStringToOb with 2 elements`  
  
 `[Lisa] = a CAge at $493C 11`  
  
 `[Bart] = a CAge at $4654 13`  
  
 `after Lisa's birthday: A CMapStringToOb with 2 elements`  
  
 `[Lisa] = a CAge at $49C0 12`  
  
 `[Bart] = a CAge at $4654 13`  
  
## See Also  
 [Base Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)   
 [CMapPtrToWord](../vs140/cmapptrtoword-class.md)   
 [CMapStringToPtr](../vs140/cmapstringtoptr-class.md)   
 [CMapStringToString](../vs140/cmapstringtostring-class.md)   
 [CMapWordToOb](../vs140/cmapwordtoob-class.md)   
 [CMapWordToPtr](../vs140/cmapwordtoptr-class.md)