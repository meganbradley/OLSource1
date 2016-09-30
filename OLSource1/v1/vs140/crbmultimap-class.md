---
title: "CRBMultiMap Class"
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
  - "CRBMultiMap"
  - "ATL.CRBMultiMap"
  - "ATL::CRBMultiMap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRBMultiMap class"
ms.assetid: 94d3ec0c-3e30-4ab7-a101-d8da4fb8add3
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRBMultiMap Class
This class represents a mapping structure that allows each key can be associated with more than one value, using a Red-Black binary tree.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The key element type.  
  
 *V*  
 The value element type.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The code used to copy or move key elements. See [CElementTraits Class](../vs140/celementtraits-class.md) for more details.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The code used to copy or move value elements.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CRBMultiMap::CRBMultiMap](../vs140/crbmultimap--crbmultimap.md)|The constructor.|  
|[CRBMultiMap::~CRBMultiMap](../vs140/crbmultimap--~crbmultimap.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CRBMultiMap::FindFirstWithKey](../vs140/crbmultimap--findfirstwithkey.md)|Call this method to find the position of the first element with a given key.|  
|[CRBMultiMap::GetNextValueWithKey](../vs140/crbmultimap--getnextvaluewithkey.md)|Call this method to get the value associated with a given key, and update the position value.|  
|[CRBMultiMap::GetNextWithKey](../vs140/crbmultimap--getnextwithkey.md)|Call this method to get the element associated with a given key, and update the position value.|  
|[CRBMultiMap::Insert](../vs140/crbmultimap--insert.md)|Call this method to insert an element pair into the map.|  
|[CRBMultiMap::RemoveKey](../vs140/crbmultimap--removekey.md)|Call this method to remove all of the key/value elements for a given key.|  
  
## Remarks  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> provides support for a mapping array of any given type, managing an ordered array of key elements and values. Unlike the [CRBMap](../vs140/crbmap-class.md) class, each key can be associated with more than one value.  
  
 Elements (consisting of a key and a value) are stored in a binary tree structure, using the [CRBMultiMap::Insert](../vs140/crbmultimap--insert.md) method. Elements can be removed using the [CRBMultiMap::RemoveKey](../vs140/crbmultimap--removekey.md) method, which deletes all elements which match the given key.  
  
 Traversing the tree is made possible with methods such as [CRBTree::GetHeadPosition](../vs140/crbtree--getheadposition.md), [CRBTree::GetNext](../vs140/crbtree--getnext.md), and [CRBTree::GetNextValue](../vs140/crbtree--getnextvalue.md). Accessing the potentially multiple values per key is possible using the [CRBMultiMap::FindFirstWithKey](../vs140/crbmultimap--findfirstwithkey.md), [CRBMultiMap::GetNextValueWithKey](../vs140/crbmultimap--getnextvaluewithkey.md), and [CRBMultiMap::GetNextWithKey](../vs140/crbmultimap--getnextwithkey.md) methods. See the example for [CRBMultiMap::CRBMultiMap](../vs140/crbmultimap--crbmultimap.md) for an illustration of this in practice.  
  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameters are traits classes that contain any supplemental code needed to copy or move elements.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is derived from [CRBTree](../vs140/crbtree-class.md), which implements a binary tree using the Red-Black algorithm. An alternative to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is offered by the [CAtlMap](../vs140/catlmap-class.md) class. When only a small number of elements needs to be stored, consider using the [CSimpleMap](../vs140/csimplemap-class.md) class instead.  
  
 For a more complete discussion of the various collection classes and their features and performance characteristics, see [ATL Collection Classes](../vs140/atl-collection-classes.md).  
  
## Inheritance Hierarchy  
 [CRBTree](../vs140/crbtree-class.md)  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlcoll.h  
  
##  \<a name="crbmultimap__crbmultimap">\</a>  CRBMultiMap::CRBMultiMap  
 The constructor.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 The block size.  
  
### Remarks  
 The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> parameter is a measure of the amount of memory allocated when a new element is required. Larger block sizes reduce calls to memory allocation routines, but use more resources. The default will allocate space for 10 elements at a time.  
  
 See the documentation for the base class [CRBTree](../vs140/crbtree-class.md) for information on the other methods available.  
  
### Example  
 [!code[NVC_ATL_Utilities#85](../vs140/codesnippet/CPP/crbmultimap-class_1.cpp)]  
  
##  \<a name="crbmultimap___dtorcrbmultimap">\</a>  CRBMultiMap::~CRBMultiMap  
 The destructor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 Frees any allocated resources.  
  
 See the documentation for the base class [CRBTree](../vs140/crbtree-class.md) for information on the other methods available.  
  
##  \<a name="crbmultimap__findfirstwithkey">\</a>  CRBMultiMap::FindFirstWithKey  
 Call this method to find the position of the first element with a given key.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 Specifies the key that identifies the element to be found.  
  
### Return Value  
 Returns the POSITION of the first key/value element if the key is found, NULL otherwise.  
  
### Remarks  
 A key in the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> can have one or more associated values. This method will provide the position value of the first value (which may, in fact, be the only value) associated with that particular key. The position value returned can then be used with [CRBMultiMap::GetNextValueWithKey](../vs140/crbmultimap--getnextvaluewithkey.md) or [CRBMultiMap::GetNextWithKey](../vs140/crbmultimap--getnextwithkey.md) to obtain the value and update the position.  
  
 See the documentation for the base class [CRBTree](../vs140/crbtree-class.md) for information on the other methods available.  
  
### Example  
 See the example for [CRBMultiMap::CRBMultiMap](../vs140/crbmultimap--crbmultimap.md).  
  
##  \<a name="crbmultimap__getnextvaluewithkey">\</a>  CRBMultiMap::GetNextValueWithKey  
 Call this method to get the value associated with a given key and update the position value.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The position value, obtained with either a call to [CRBMultiMap::FindFirstWithKey](../vs140/crbmultimap--findfirstwithkey.md) or [CRBMultiMap::GetNextWithKey](../vs140/crbmultimap--getnextwithkey.md), or a previous call to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 Specifies the key that identifies the element to be found.  
  
### Return Value  
 Returns the element pair associated with the given key.  
  
### Remarks  
 The position value is updated to point to the next value associated with the key. If no more values exist, the position value is set to NULL.  
  
 See the documentation for the base class [CRBTree](../vs140/crbtree-class.md) for information on the other methods available.  
  
### Example  
 See the example for [CRBMultiMap::CRBMultiMap](../vs140/crbmultimap--crbmultimap.md).  
  
##  \<a name="crbmultimap__getnextwithkey">\</a>  CRBMultiMap::GetNextWithKey  
 Call this method to get the element associated with a given key and update the position value.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 The position value, obtained with either a call to [CRBMultiMap::FindFirstWithKey](../vs140/crbmultimap--findfirstwithkey.md) or [CRBMultiMap::GetNextValueWithKey](../vs140/crbmultimap--getnextvaluewithkey.md), or a previous call to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Specifies the key that identifies the element to be found.  
  
### Return Value  
 Returns the next [CRBTree::CPair Class](../vs140/crbtree--cpair-class.md) element associated with the given key.  
  
### Remarks  
 The position value is updated to point to the next value associated with the key. If no more values exist, the position value is set to NULL.  
  
 See the documentation for the base class [CRBTree](../vs140/crbtree-class.md) for information on the other methods available.  
  
##  \<a name="crbmultimap__insert">\</a>  CRBMultiMap::Insert  
 Call this method to insert an element pair into the map.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 The key value to add to the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object.  
  
 *value*  
 The value to add to the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object, associated with <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
### Return Value  
 Returns the position of the key/value element pair in the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object.  
  
### Remarks  
 See the documentation for the base class [CRBTree](../vs140/crbtree-class.md) for information on the other methods available.  
  
### Example  
 See the example for [CRBMultiMap::CRBMultiMap](../vs140/crbmultimap--crbmultimap.md).  
  
##  \<a name="crbmultimap__removekey">\</a>  CRBMultiMap::RemoveKey  
 Call this method to remove all of the key/value elements for a given key.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 Specifies the key that identifies the element(s) to be deleted.  
  
### Return Value  
 Returns the number of values associated with the given key.  
  
### Remarks  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> deletes all of the key/value elements that have a key that matches <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
 See the documentation for the base class [CRBTree](../vs140/crbtree-class.md) for information on the other methods available.  
  
### Example  
 See the example for [CRBMultiMap::CRBMultiMap](../vs140/crbmultimap--crbmultimap.md).  
  
## See Also  
 [CRBTree Class](../vs140/crbtree-class.md)   
 [CAtlMap Class](../vs140/catlmap-class.md)   
 [CRBMap Class](../vs140/crbmap-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)