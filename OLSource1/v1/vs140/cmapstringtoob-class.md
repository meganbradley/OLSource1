---
title: "CMapStringToOb Class"
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
  - "CMapStringToOb"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "collection classes, string mapping"
  - "CMapStringToOb class"
  - "strings [C++], class for mapping"
ms.assetid: 09653980-b885-4f3a-8594-0aeb7f94c601
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMapStringToOb Class
A dictionary collection class that maps unique <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> objects to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> pointers.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
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
|[CMapStringToOb::operator &#91;&#93;](#cmapstringtoob__operator_at)|Inserts an element into the map — operator substitution for <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.|  
  
## Remarks  
 Once you have inserted a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>- <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> pair (element) into the map, you can efficiently retrieve or delete the pair using a string or a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> value as a key. You can also iterate over all the elements in the map.  
  
 A variable of type **POSITION** is used for alternate entry access in all map variations. You can use a **POSITION** to "remember" an entry and to iterate through the map. You might think that this iteration is sequential by key value; it is not. The sequence of retrieved elements is indeterminate.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> incorporates the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> macro to support serialization and dumping of its elements. Each element is serialized in turn if a map is stored to an archive, either with the overloaded insertion ( **<<**) operator or with the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> member function.  
  
 If you need a diagnostic dump of the individual elements in the map (the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> value and the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> contents), you must set the depth of the dump context to 1 or greater.  
  
 When a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object is deleted, or when its elements are removed, the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> objects and the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> pointers are removed. The objects referenced by the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> pointers are not destroyed.  
  
 Map class derivation is similar to list derivation. See the article [Collections](../vs140/collections.md) for an illustration of the derivation of a special-purpose list class.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxcoll.h  
  
##  \<a name="cmapstringtoob__cmapstringtoob">\</a>  CMapStringToOb::CMapStringToOb  
 Constructs an empty <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>-to- <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> map.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 Specifies the memory-allocation granularity for extending the map.  
  
### Remarks  
 As the map grows, memory is allocated in units of <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> entries.  
  
 The following table shows other member functions that are similar to **CMapStringToOb:: CMapStringToOb**.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**CMapPtrToPtr( INT_PTR**  <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  **= 10 );**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**CMapPtrToWord( INT_PTR**  <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  **= 10 );**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**CMapStringToPtr( INT_PTR**  <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  **= 10 );**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**CMapStringToString( INT_PTR**  <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  **= 10 );**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**CMapWordToOb( INT_PTR**  <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  **= 10 );**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**MapWordToPtr( INT_PTR**  <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  **= 10 );**|  
  
### Example  
 [!code[NVC_MFCCollections#63](../vs140/codesnippet/CPP/cmapstringtoob-class_1.cpp)]  
  
 See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> class used in all collection examples.  
  
##  \<a name="cmapstringtoob__getcount">\</a>  CMapStringToOb::GetCount  
 Determines how many elements are in the map.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 The number of elements in this map.  
  
### Remarks  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**INT_PTR GetCount( ) const;**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**INT_PTR GetCount( ) const;**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**INT_PTR GetCount( ) const;**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**INT_PTR GetCount( ) const;**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**INT_PTR GetCount( ) const;**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**INT_PTR GetCount( ) const;**|  
  
### Example  
 See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> class used in all collection examples.  
  
 [!code[NVC_MFCCollections#64](../vs140/codesnippet/CPP/cmapstringtoob-class_2.cpp)]  
  
##  \<a name="cmapstringtoob__gethashtablesize">\</a>  CMapStringToOb::GetHashTableSize  
 Determines the current number of elements in the hash table.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 Returns the number of elements in the hash table.  
  
### Remarks  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**UINT GetHashTableSize( ) const;**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**UINT GetHashTableSize( ) const;**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**UINT GetHashTableSize( ) const;**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**UINT GetHashTableSize( ) const;**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**UINT GetHashTableSize( ) const;**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**UINT GetHashTableSize( ) const;**|  
  
##  \<a name="cmapstringtoob__getnextassoc">\</a>  CMapStringToOb::GetNextAssoc  
 Retrieves the map element at                 *rNextPosition*, then updates                 *rNextPosition* to refer to the next element in the map.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
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
 See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> class used in all collection examples.  
  
 [!code[NVC_MFCCollections#66](../vs140/codesnippet/CPP/cmapstringtoob-class_4.cpp)]  
  
 The results from this program are as follows:  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
  
##  \<a name="cmapstringtoob__getsize">\</a>  CMapStringToOb::GetSize  
 Returns the number of map elements.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 The number of items in the map.  
  
### Remarks  
 Call this method to retrieve the number of elements in the map.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
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
  
##  \<a name="cmapstringtoob__getstartposition">\</a>  CMapStringToOb::GetStartPosition  
 Starts a map iteration by returning a **POSITION** value that can be passed to a <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> call.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A **POSITION** value that indicates a starting position for iterating the map; or **NULL** if the map is empty.  
  
### Remarks  
 The iteration sequence is not predictable; therefore, the "first element in the map" has no special significance.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
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
  
##  \<a name="cmapstringtoob__hashkey">\</a>  CMapStringToOb::HashKey  
 Calculates the hash value of a specified key.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 The key whose hash value is to be calculated.  
  
### Return Value  
 The Key's hash value  
  
### Remarks  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**UINT HashKey( void\***  <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  **) const;**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**UINT HashKey( void\***  <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  **) const;**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**UINT HashKey( LPCTSTR**  <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  **) const;**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**UINT HashKey( LPCTSTR**  <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  **) const;**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**UINT HashKey( WORD**  <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  **) const;**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**UINT HashKey( WORD**  <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  **) const;**|  
  
##  \<a name="cmapstringtoob__inithashtable">\</a>  CMapStringToOb::InitHashTable  
 Initializes the hash table.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 Number of entries in the hash table.  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 If **TRUE**, allocates the hash table upon initialization; otherwise the table is allocated when needed.  
  
### Remarks  
 For best performance, the hash table size should be a prime number. To minimize collisions, the size should be roughly 20 percent larger than the largest anticipated data set.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**void InitHashTable( UINT**  <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> **, BOOL**  <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  **= TRUE );**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**void InitHashTable( UINT**  <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> **, BOOL**  <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  **= TRUE );**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**void InitHashTable( UINT**  <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> **, BOOL**  <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  **= TRUE );**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**void InitHashTable( UINT**  <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> **, BOOL**  <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  **= TRUE );**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**void InitHashTable( UINT**  <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> **, BOOL**  <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  **= TRUE );**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**void InitHashTable( UINT**  <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> **, BOOL**  <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  **= TRUE );**|  
  
##  \<a name="cmapstringtoob__isempty">\</a>  CMapStringToOb::IsEmpty  
 Determines whether the map is empty.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
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
  
##  \<a name="cmapstringtoob__lookup">\</a>  CMapStringToOb::Lookup  
 Returns a <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> pointer based on a <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> value.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 Specifies the string key that identifies the element to be looked up.  
  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 Specifies the returned value from the looked-up element.  
  
### Return Value  
 Nonzero if the element was found; otherwise 0.  
  
### Remarks  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> uses a hashing algorithm to quickly find the map element with a key that matches exactly ( <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> value).  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**BOOL Lookup( void\***  <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> **, void\*&**  <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  **) const;**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**BOOL Lookup( void\***  <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> **, WORD&**  <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  **) const;**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**BOOL Lookup( LPCTSTR**  <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> **, void\*&**  <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  **) const;**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**BOOL Lookup( LPCTSTR**  <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> **, CString&**  <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  **) const;**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**BOOL Lookup( WORD**  <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> **, CObject\*&**  <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  **) const;**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**BOOL Lookup( WORD**  <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> **, void\*&**  <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  **) const;**|  
  
### Example  
 See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> class used in all collection examples.  
  
 [!code[NVC_MFCCollections#68](../vs140/codesnippet/CPP/cmapstringtoob-class_6.cpp)]  
  
##  \<a name="cmapstringtoob__lookupkey">\</a>  CMapStringToOb::LookupKey  
 Returns a reference to the key associated with the specified key value.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 Specifies the string key that identifies the element to be looked up.  
  
 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
 The reference to the associated key.  
  
### Return Value  
 Nonzero if the key was found; otherwise 0.  
  
### Remarks  
 Using a reference to a key is unsafe if used after the associated element was removed from the map or after the map was destroyed.  
  
 The following table shows other member functions that are similar to **CMapStringToOb:: LookupKey**.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**BOOL LookupKey( LPCTSTR**  <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> **, LPCTSTR&** <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  **) const;**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**BOOL LookupKey( LPCTSTR**  <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> **, LPCTSTR&** <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  **) const;**|  
  
##  \<a name="cmapstringtoob__operator_at">\</a>  CMapStringToOb::operator [ ]  
 A convenient substitute for the <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> member function.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 A reference to a pointer to a <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> object; or **NULL** if the map is empty or <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> is out of range.  
  
### Remarks  
 Thus it can be used only on the left side of an assignment statement (an l-value). If there is no map element with the specified key, then a new element is created.  
  
 There is no "right side" (r-value) equivalent to this operator because there is a possibility that a key may not be found in the map. Use the <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> member function for element retrieval.  
  
 The following table shows other member functions that are similar to **CMapStringToOb::operator []**.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**void\*& operator[](void\***  <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  **\);**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**WORD& operator[](void\***  <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  **\);**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**void\*& operator[](LPCTSTR**  <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  **\);**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**CString& operator[](LPCTSTR**  <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  **\);**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**CObject\*& operator[](WORD**  <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  **\);**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**void\*& operator[](WORD**  <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  **\);**|  
  
### Example  
 See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> class used in all collection examples.  
  
 [!code[NVC_MFCCollections#72](../vs140/codesnippet/CPP/cmapstringtoob-class_7.cpp)]  
  
 The results from this program are as follows:  
  
 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
  
##  \<a name="cmapstringtoob__removeall">\</a>  CMapStringToOb::RemoveAll  
 Removes all the elements from this map and destroys the <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> key objects.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Remarks  
 The <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> objects referenced by each key are not destroyed. The <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> function can cause memory leaks if you do not ensure that the referenced <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> objects are destroyed.  
  
 The function works correctly if the map is already empty.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**void RemoveAll( );**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**void RemoveAll( );**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**void RemoveAll( );**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**void RemoveAll( );**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**void RemoveAll( );**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**void RemoveAll( );**|  
  
### Example  
 See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> class used in all collection examples.  
  
 [!code[NVC_MFCCollections#69](../vs140/codesnippet/CPP/cmapstringtoob-class_8.cpp)]  
  
##  \<a name="cmapstringtoob__removekey">\</a>  CMapStringToOb::RemoveKey  
 Looks up the map entry corresponding to the supplied key; then, if the key is found, removes the entry.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
 Specifies the string used for map lookup.  
  
### Return Value  
 Nonzero if the entry was found and successfully removed; otherwise 0.  
  
### Remarks  
 This can cause memory leaks if the <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> object is not deleted elsewhere.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**BOOL RemoveKey( void\***  <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  **);**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**BOOL RemoveKey( void\***  <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  **);**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**BOOL RemoveKey( LPCTSTR**  <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  **);**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**BOOL RemoveKey( LPCTSTR**  <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  **);**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**BOOL RemoveKey( WORD**  <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  **);**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**BOOL RemoveKey( WORD**  <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  **);**|  
  
### Example  
 See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> class used in all collection examples.  
  
 [!code[NVC_MFCCollections#70](../vs140/codesnippet/CPP/cmapstringtoob-class_9.cpp)]  
  
 The results from this program are as follows:  
  
 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  
  
##  \<a name="cmapstringtoob__setat">\</a>  CMapStringToOb::SetAt  
 The primary means to insert an element in a map.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
 Specifies the string that is the key of the new element.  
  
 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
 Specifies the <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> pointer that is the value of the new element.  
  
### Remarks  
 First, the key is looked up. If the key is found, then the corresponding value is changed; otherwise a new key-value element is created.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**void SetAt( void\***  <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> **, void\***  <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  **);**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**void SetAt( void\***  <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> **, WORD**  <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  **);**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**void SetAt( LPCTSTR**  <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> **, void\***  <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  **);**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**void SetAt( LPCTSTR**  <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> **, LPCTSTR**  <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  **);**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**void SetAt( WORD**  <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> **, CObject\***  <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>  **);**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**void SetAt( WORD**  <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> **, void\***  <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  **);**|  
  
### Example  
 See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> class used in all collection examples.  
  
 [!code[NVC_MFCCollections#71](../vs140/codesnippet/CPP/cmapstringtoob-class_10.cpp)]  
  
 The results from this program are as follows:  
  
 <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>  
  
## See Also  
 [Base Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)   
 [CMapPtrToWord](../vs140/cmapptrtoword-class.md)   
 [CMapStringToPtr](../vs140/cmapstringtoptr-class.md)   
 [CMapStringToString](../vs140/cmapstringtostring-class.md)   
 [CMapWordToOb](../vs140/cmapwordtoob-class.md)   
 [CMapWordToPtr](../vs140/cmapwordtoptr-class.md)