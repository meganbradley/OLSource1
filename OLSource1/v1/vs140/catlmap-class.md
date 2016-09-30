---
title: "CAtlMap Class"
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
  - "ATL.CAtlMap"
  - "CAtlMap"
  - "ATL::CAtlMap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAtlMap class"
ms.assetid: 5e2fe028-8e6d-4686-93df-1433d2080ec3
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlMap Class
This class provides methods for creating and managing a map object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 The key element type.  
  
 V  
 The value element type.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The code used to copy or move key elements. See [CElementTraits Class](../vs140/celementtraits-class.md) for more details.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 The code used to copy or move value elements.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlMap::KINGARGTYPE](../vs140/catlmap--kinargtype.md)|Type used when a key is passed as an input argument|  
|[CAtlMap::KOUTARGTYPE](../vs140/catlmap--koutargtype.md)|Type used when a key is returned as an output argument.|  
|[CAtlMap::VINARGTYPE](../vs140/catlmap--vinargtype.md)|Type used when a value is passed as an input argument.|  
|[CAtlMap::VOUTARGTYPE](../vs140/catlmap--voutargtype.md)|Type used when a value is passed as an output argument.|  
  
### Public Classes  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlMap::CPair Class](../vs140/catlmap--cpair-class.md)|A class containing the key and value elements.|  
  
### CPair Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CPair::m_key](../vs140/catlmap--cpair--m_key.md)|The data member storing the key element.|  
|[CPair::m_value](../vs140/catlmap--cpair--m_value.md)|The data member storing the value element.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlMap::CAtlMap](../vs140/catlmap--catlmap.md)|The constructor.|  
|[CAtlMap::~CAtlMap](../vs140/catlmap--~catlmap.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlMap::AssertValid](../vs140/catlmap--assertvalid.md)|Call this method to cause an ASSERT if the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is not valid.|  
|[CAtlMap::DisableAutoRehash](../vs140/catlmap--disableautorehash.md)|Call this method to disable automatic rehashing of the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object.|  
|[CAtlMap::EnableAutoRehash](../vs140/catlmap--enableautorehash.md)|Call this method to enable automatic rehashing of the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object.|  
|[CAtlMap::GetAt](../vs140/catlmap--getat.md)|Call this method to return the element at a specified position in the map.|  
|[CAtlMap::GetCount](../vs140/catlmap--getcount.md)|Call this method to retrieve the number of elements in the map.|  
|[CAtlMap::GetHashTableSize](../vs140/catlmap--gethashtablesize.md)|Call this method to determine the number of bins in the map's hash table.|  
|[CAtlMap::GetKeyAt](../vs140/catlmap--getkeyat.md)|Call this method to retrieve the key stored at the given position in the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object.|  
|[CAtlMap::GetNext](../vs140/catlmap--getnext.md)|Call this method to obtain a pointer to the next element pair stored in the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object.|  
|[CAtlMap::GetNextAssoc](../vs140/catlmap--getnextassoc.md)|Gets the next element for iterating.|  
|[CAtlMap::GetNextKey](../vs140/catlmap--getnextkey.md)|Call this method to retrieve the next key from the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object.|  
|[CAtlMap::GetNextValue](../vs140/catlmap--getnextvalue.md)|Call this method to get the next value from the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object.|  
|[CAtlMap::GetStartPosition](../vs140/catlmap--getstartposition.md)|Call this method to start a map iteration.|  
|[CAtlMap::GetValueAt](../vs140/catlmap--getvalueat.md)|Call this method to retrieve the value stored at a given position in the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object.|  
|[CAtlMap::InitHashTable](../vs140/catlmap--inithashtable.md)|Call this method to initialize the hash table.|  
|[CAtlMap::IsEmpty](../vs140/catlmap--isempty.md)|Call this method to test for an empty map object.|  
|[CAtlMap::Lookup](../vs140/catlmap--lookup.md)|Call this method to look up keys or values in the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object.|  
|[CAtlMap::Rehash](../vs140/catlmap--rehash.md)|Call this method to rehash the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object.|  
|[CAtlMap::RemoveAll](../vs140/catlmap--removeall.md)|Call this method to remove all elements from the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object.|  
|[CAtlMap::RemoveAtPos](../vs140/catlmap--removeatpos.md)|Call this method to remove the element at the given position in the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object.|  
|[CAtlMap::RemoveKey](../vs140/catlmap--removekey.md)|Call this method to remove an element from the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object, given the key.|  
|[CAtlMap::SetAt](../vs140/catlmap--setat.md)|Call this method to insert an element pair into the map.|  
|[CAtlMap::SetOptimalLoad](../vs140/catlmap--setoptimalload.md)|Call this method to set the optimal load of the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object.|  
|[CAtlMap::SetValueAt](../vs140/catlmap--setvalueat.md)|Call this method to change the value stored at a given position in the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlMap::operator &#91;&#93;](../vs140/catlmap--operator.md)|Replaces or adds a new element to the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.|  
  
## Remarks  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> provides support for a mapping array of any given type, managing an unordered array of key elements and their associated values. Elements (consisting of a key and a value) are stored using a hashing algorithm, allowing a large amount of data to be efficiently stored and retrieved.  
  
 The <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> parameters are traits classes that contain any supplemental code needed to copy or move elements.  
  
 An alternative to <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> is offered by the [CRBMap](../vs140/crbmap-class.md) class. <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> also stores key/value pairs, but exhibits different performance characteristics. The time taken to insert an item, look up a key, or delete a key from a <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> object is of order  *log(n)*, where *n* is the number of elements. For <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>, all of these operations typically take a constant time, although worst-case scenarios might be of order *n*. Therefore, in a typical case, <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> is faster.  
  
 The other difference between <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> becomes apparent when iterating through the stored elements. In a <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, the elements are visited in a sorted order. In a <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, the elements are not ordered, and no order can be inferred.  
  
 When a small number of elements need to be stored, consider using the [CSimpleMap](../vs140/csimplemap-class.md) class instead.  
  
 For more information, see [ATL Collection Classes](../vs140/atl-collection-classes.md).  
  
## Requirements  
 **Header:** atlcoll.h  
  
##  \<a name="catlmap__assertvalid">\</a>  CAtlMap::AssertValid  
 Call this method to cause an ASSERT if the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> object is not valid.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 In debug builds, this method will cause an ASSERT if the <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> object is not valid.  
  
### Example  
 See the example for [CAtlMap::CAtlMap](../vs140/catlmap--catlmap.md).  
  
##  \<a name="catlmap__catlmap">\</a>  CAtlMap::CAtlMap  
 The constructor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 The number of bins providing pointers to the stored elements. See Remarks later in this topic for an explanation of bins.  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 The optimal load ratio.  
  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 The lower threshold for the load ratio.  
  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 The upper threshold for the load ratio.  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 The block size.  
  
### Remarks  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> references all of its stored elements by first creating an index using a hashing algorithm on the key. This index references a "bin" which contains a pointer to the stored elements. If the bin is already in use, a linked-list is created to access the subsequent elements. Traversing a list is slower than directly accessing the correct element, and so the map structure needs to balance storage requirements against performance. The default parameters have been chosen to give good results in most cases.  
  
 The load ratio is the ratio of the number of bins to the number of elements stored in the map object. When the map structure is recalculated, the *fOptimalLoad* parameter value will be used to calculate the number of bins required. This value can be changed using the [CAtlMap::SetOptimalLoad](../vs140/catlmap--setoptimalload.md) method.  
  
 The <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> parameter is the lower value that the load ratio can reach before <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> will recalculate the optimal size of the map.  
  
 The <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> parameter is the upper value that the load ratio can reach before the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> object will recalculate the optimal size of the map.  
  
 This recalculation process (known as rehashing) is enabled by default. If you want to disable this process, perhaps when entering a lot of data at one time, call the [CAtlMap::DisableAutoRehash](../vs140/catlmap--disableautorehash.md) method. Reactivate it with the [CAtlMap::EnableAutoRehash](../vs140/catlmap--enableautorehash.md) method.  
  
 The <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> parameter is a measure of the amount of memory allocated when a new element is required. Larger block sizes reduce calls to memory allocation routines, but use more resources.  
  
 Before any data can be stored, it is necessary to initialize the hash table with a call to [CAtlMap::InitHashTable](../vs140/catlmap--inithashtable.md).  
  
### Example  
 [!code[NVC_ATL_Utilities#72](../vs140/codesnippet/CPP/catlmap-class_1.cpp)]  
  
##  \<a name="catlmap___dtorcatlmap">\</a>  CAtlMap::~CAtlMap  
 The destructor.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 Frees any allocated resources.  
  
##  \<a name="catlmap__cpair_class">\</a>  CAtlMap::CPair Class  
 A class containing the key and value elements.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 This class is used by the methods [CAtlMap::GetNext](../vs140/catlmap--getnext.md) and [CAtlMap::Lookup](../vs140/catlmap--lookup.md) to access the key and value elements stored in the mapping structure.  
  
##  \<a name="catlmap__disableautorehash">\</a>  CAtlMap::DisableAutoRehash  
 Call this method to disable automatic rehashing of the <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 When automatic rehashing is enabled (which it is by default), the number of bins in the hash table will automatically be recalculated if the load value (the ratio of the number of bins to the number of elements stored in the array) exceeds the maximum or minimum values specified at the time the map was created.  
  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> is most useful when a large number of elements will be added to the map at once. Instead of triggering the rehashing process every time the limits are exceeded, it is more efficient to call <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>, add the elements, and finally call [CAtlMap::EnableAutoRehash](../vs140/catlmap--enableautorehash.md).  
  
##  \<a name="catlmap__enableautorehash">\</a>  CAtlMap::EnableAutoRehash  
 Call this method to enable automatic rehashing of the <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 When automatic rehashing is enabled (which it is by default), the number of bins in the hash table will automatically be recalculated if the load value (the ratio of the number of bins to the number of elements stored in the array) exceeds the maximum or minimum values specified at the time the map is created.  
  
 **EnableAutoRefresh** is most often used after a call to [CAtlMap::DisableAutoRehash](../vs140/catlmap--disableautorehash.md).  
  
##  \<a name="catlmap__getat">\</a>  CAtlMap::GetAt  
 Call this method to return the element at a specified position in the map.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 The position counter, returned by a previous call to [CAtlMap::GetNextAssoc](../vs140/catlmap--getnextassoc.md) or [CAtlMap::GetStartPosition](../vs140/catlmap--getstartposition.md).  
  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 Template parameter specifying the type of the map's key.  
  
 *value*  
 Template parameter specifying the type of the map's value.  
  
### Return Value  
 Returns a pointer to the current pair of key/value elements stored in the map.  
  
### Remarks  
 In debug builds, an assertion error will occur if <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> is equal to NULL.  
  
##  \<a name="catlmap__getcount">\</a>  CAtlMap::GetCount  
 Call this method to retrieve the number of elements in the map.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 Returns the number of elements in the map object. A single element is a key/value pair.  
  
### Example  
 See the example for [CAtlMap::CAtlMap](../vs140/catlmap--catlmap.md).  
  
##  \<a name="catlmap__gethashtablesize">\</a>  CAtlMap::GetHashTableSize  
 Call this method to determine the number of bins in the map's hash table.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 Returns the number of bins in the hash table. See [CAtlMap::CAtlMap](../vs140/catlmap--catlmap.md) for an explanation.  
  
##  \<a name="catlmap__getkeyat">\</a>  CAtlMap::GetKeyAt  
 Call this method to retrieve the key stored at the given position in the <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 The position counter, returned by a previous call to [CAtlMap::GetNextAssoc](../vs140/catlmap--getnextassoc.md) or [CAtlMap::GetStartPosition](../vs140/catlmap--getstartposition.md).  
  
### Return Value  
 Returns a reference to the key stored at the given position in the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> object.  
  
### Example  
 See the example for [CAtlMap::CAtlMap](../vs140/catlmap--catlmap.md).  
  
##  \<a name="catlmap__getnext">\</a>  CAtlMap::GetNext  
 Call this method to obtain a pointer to the next element pair stored in the <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 The position counter, returned by a previous call to [CAtlMap::GetNextAssoc](../vs140/catlmap--getnextassoc.md) or [CAtlMap::GetStartPosition](../vs140/catlmap--getstartposition.md).  
  
### Return Value  
 Returns a pointer to the next pair of key/value elements stored in the map. The <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> position counter is updated after each call. If the retrieved element is the last in the map, <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> is set to NULL.  
  
##  \<a name="catlmap__getnextassoc">\</a>  CAtlMap::GetNextAssoc  
 Gets the next element for iterating.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 The position counter, returned by a previous call to [CAtlMap::GetNextAssoc](#vclrfcatlmapgetnextassoc) or [CAtlMap::GetStartPosition](../vs140/catlmap--getstartposition.md).  
  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 Template parameter specifying the type of the map's key.  
  
 *value*  
 Template parameter specifying the type of the map's value.  
  
### Remarks  
 The <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> position counter is updated after each call. If the retrieved element is the last in the map, <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> is set to NULL.  
  
##  \<a name="catlmap__getnextkey">\</a>  CAtlMap::GetNextKey  
 Call this method to retrieve the next key from the <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 The position counter, returned by a previous call to [CAtlMap::GetNextAssoc](../vs140/catlmap--getnextassoc.md) or [CAtlMap::GetStartPosition](../vs140/catlmap--getstartposition.md).  
  
### Return Value  
 Returns a reference to the next key in the map.  
  
### Remarks  
 Updates the current position counter, <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>. If there are no more entries in the map, the position counter is set to NULL.  
  
##  \<a name="catlmap__getnextvalue">\</a>  CAtlMap::GetNextValue  
 Call this method to get the next value from the <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 The position counter, returned by a previous call to [CAtlMap::GetNextAssoc](../vs140/catlmap--getnextassoc.md) or [CAtlMap::GetStartPosition](../vs140/catlmap--getstartposition.md).  
  
### Return Value  
 Returns a reference to the next value in the map.  
  
### Remarks  
 Updates the current position counter, <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>. If there are no more entries in the map, the position counter is set to NULL.  
  
### Example  
 See the example for [CAtlMap::CAtlMap](../vs140/catlmap--catlmap.md).  
  
##  \<a name="catlmap__getstartposition">\</a>  CAtlMap::GetStartPosition  
 Call this method to start a map iteration.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 Returns the start position, or NULL is returned if the map is empty.  
  
### Remarks  
 Call this method to start a map iteration by returning a **POSITION** value that can be passed to the <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> method.  
  
> [!NOTE]
>  The iteration sequence is not predictable  
  
### Example  
 See the example for [CAtlMap::CAtlMap](../vs140/catlmap--catlmap.md).  
  
##  \<a name="catlmap__getvalueat">\</a>  CAtlMap::GetValueAt  
 Call this method to retrieve the value stored at a given position in the <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
 The position counter, returned by a previous call to [CAtlMap::GetNextAssoc](../vs140/catlmap--getnextassoc.md) or [CAtlMap::GetStartPosition](../vs140/catlmap--getstartposition.md).  
  
### Return Value  
 Returns a reference to the value stored at the given position in the <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> object.  
  
##  \<a name="catlmap__inithashtable">\</a>  CAtlMap::InitHashTable  
 Call this method to initialize the hash table.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 The number of bins used by the hash table. See [CAtlMap::CAtlMap](../vs140/catlmap--catlmap.md) for an explanation.  
  
 <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
 A flag indication when memory should be allocated.  
  
### Return Value  
 Returns **true** on successful initialization,                         **false** on failure.  
  
### Remarks  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> must be called before any elements are stored in the hash table.  If this method is not called explicitly, it will be called automatically the first time an element is added using the bin count specified by the **CAtlMap** constructor.  Otherwise, the map will be initialized using the new bin count specified by the <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> parameter.  
  
 If the <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> parameter is false, the memory required by the hash table will not be allocated until it is first required. This can be useful if it is uncertain if the map will be used.  
  
### Example  
 See the example for [CAtlMap::CAtlMap](../vs140/catlmap--catlmap.md).  
  
##  \<a name="catlmap__isempty">\</a>  CAtlMap::IsEmpty  
 Call this method to test for an empty map object.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
 Returns **true** if the map is empty,                         **false** otherwise.  
  
##  \<a name="catlmap__kinargtype">\</a>  CAtlMap::KINARGTYPE  
 Type used when a key is passed as an input argument.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
##  \<a name="catlmap__koutargtype">\</a>  CAtlMap::KOUTARGTYPE  
 Type used when a key is returned as an output argument.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
##  \<a name="catlmap__lookup">\</a>  CAtlMap::Lookup  
 Call this method to look up keys or values in the <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
 Specifies the key that identifies the element to be looked up.  
  
 *value*  
 Variable that receives the looked-up value.  
  
### Return Value  
 The first form of the method returns true if the key is found, otherwise false. The second and third forms return a pointer to a [CPair](../vs140/catlmap--cpair-class.md) which can be used as a position for calls to [CAtlMap::GetNext](../vs140/catlmap--getnext.md) and so on.  
  
### Remarks  
 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> uses a hashing algorithm to quickly find the map element containing a key that exactly matches the given key parameter.  
  
##  \<a name="catlmap__operator__at">\</a>  CAtlMap::operator []  
 Replaces or adds a new element to the <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
 The key of the element to add or replace.  
  
### Return Value  
 Returns a reference to the value associated with the given key.  
  
### Example  
 If the key already exists, the element is replaced. If the key does not exist, a new element is added. See the example for [CAtlMap::CAtlMap](../vs140/catlmap--catlmap.md).  
  
##  \<a name="catlmap__rehash">\</a>  CAtlMap::Rehash  
 Call this method to rehash the <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
 The new number of bins to use in the hash table. See [CAtlMap::CAtlMap](../vs140/catlmap--catlmap.md) for an explanation.  
  
### Remarks  
 If <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> is 0, <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> calculates a reasonable number based on the number of elements in the map and the optimal load setting. Normally the rehashing process is automatic, but if [CAtlMap::DisableAutoRehash](../vs140/catlmap--disableautorehash.md) has been called, this method will perform the necessary resizing.  
  
##  \<a name="catlmap__removeall">\</a>  CAtlMap::RemoveAll  
 Call this method to remove all elements from the <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Remarks  
 Clears out the <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> object, freeing the memory used to store the elements.  
  
##  \<a name="catlmap__removeatpos">\</a>  CAtlMap::RemoveAtPos  
 Call this method to remove the element at the given position in the <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
 The position counter, returned by a previous call to [CAtlMap::GetNextAssoc](../vs140/catlmap--getnextassoc.md) or [CAtlMap::GetStartPosition](../vs140/catlmap--getstartposition.md).  
  
### Remarks  
 Removes the key/value pair stored at the specified position. The memory used to store the element is freed. The POSITION referenced by <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> becomes invalid, and while the POSITION of any other elements in the map remains valid, they do not necessarily retain the same order.  
  
##  \<a name="catlmap__removekey">\</a>  CAtlMap::RemoveKey  
 Call this method to remove an element from the <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> object, given the key.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
 The key corresponding to the element pair you want to remove.  
  
### Return Value  
 Returns **true** if the key is found and removed,                         **false** on failure.  
  
### Example  
 See the example for [CAtlMap::CAtlMap](../vs140/catlmap--catlmap.md).  
  
##  \<a name="catlmap__setat">\</a>  CAtlMap::SetAt  
 Call this method to insert an element pair into the map.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
 The key value to add to the <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> object.  
  
 *value*  
 The value to add to the <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Returns the position of the key/value element pair in the <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> object.  
  
### Remarks  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> replaces an existing element if a matching key is found. If the key is not found, a new key/value pair is created.  
  
##  \<a name="catlmap__setoptimalload">\</a>  CAtlMap::SetOptimalLoad  
 Call this method to set the optimal load of the <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 The optimal load ratio.  
  
 <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
 The lower threshold for the load ratio.  
  
 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
 The upper threshold for the load ratio.  
  
 <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  
 Flag indicating if the hash table should be recalculated.  
  
### Remarks  
 This method redefines the optimal load value for the <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> object. See [CAtlMap::CAtlMap](../vs140/catlmap--catlmap.md) for a discussion of the various parameters. If <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> is true, and the number of elements is outside the minimum and maximum values, the hash table is recalculated.  
  
##  \<a name="catlmap__setvalueat">\</a>  CAtlMap::SetValueAt  
 Call this method to change the value stored at a given position in the <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
 The position counter, returned by a previous call to [CAtlMap::GetNextAssoc](../vs140/catlmap--getnextassoc.md) or [CAtlMap::GetStartPosition](../vs140/catlmap--getstartposition.md).  
  
 *value*  
 The value to add to the <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> object.  
  
### Remarks  
 Changes the value element stored at the given position in the <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> object.  
  
##  \<a name="catlmap__vinargtype">\</a>  CAtlMap::VINARGTYPE  
 Type used when a value is passed as an input argument.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
##  \<a name="catlmap__voutargtype">\</a>  CAtlMap::VOUTARGTYPE  
 Type used when a value is passed as an output argument.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
##  \<a name="catlmap__cpair__m_key">\</a>  CAtlMap::CPair::m_key  
 The data member storing the key element.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>  
 The key element type.  
  
##  \<a name="catlmap__cpair__m_value">\</a>  CAtlMap::CPair::m_value  
 The data member storing the value element.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 *V*  
 The value element type.  
  
## See Also  
 [Marquee Sample](../vs140/visual-c---samples.md)   
 [UpdatePV Sample](../vs140/visual-c---samples.md)   
 [Class Overview](../vs140/atl-class-overview.md)