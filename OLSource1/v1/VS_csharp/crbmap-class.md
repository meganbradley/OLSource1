---
title: "CRBMap Class"
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
  - "ATL.CRBMap"
  - "CRBMap"
  - "ATL::CRBMap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRBMap class"
ms.assetid: 658e94dc-e835-4356-aed1-1513e1f66969
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRBMap Class
This class represents a mapping structure, using a Red-Black binary tree.  
  
## Syntax  
  
```  
  
template<   
      typename  K,  
      typename  V,  
      class  KTraits  
    = CElementTraits<  K  
    >,  
      class  VTraits  
    = CElementTraits<  V  
    >   
   > class CRBMap : public CRBTree<  K  
   ,  V  
   ,  KTraits  
   ,  VTraits  
    >  
  
```  
  
#### Parameters  
 `K`  
 The key element type.  
  
 *V*  
 The value element type.  
  
 `KTraits`  
 The code used to copy or move key elements. See [CElementTraits Class](../VS_csharp/celementtraits-class.md) for more details.  
  
 `VTraits`  
 The code used to copy or move value elements.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CRBMap::CRBMap](../Topic/CRBMap::CRBMap.md)|The constructor.|  
|[CRBMap::~CRBMap](../Topic/CRBMap::~CRBMap.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CRBMap::Lookup](../Topic/CRBMap::Lookup.md)|Call this method to look up keys or values in the `CRBMap` object.|  
|[CRBMap::RemoveKey](../Topic/CRBMap::RemoveKey.md)|Call this method to remove an element from the `CRBMap` object, given the key.|  
|[CRBMap::SetAt](../Topic/CRBMap::SetAt.md)|Call this method to insert an element pair into the map.|  
  
## Remarks  
 `CRBMap` provides support for a mapping array of any given type, managing an ordered array of key elements and their associated values. Each key can have only one associated value. Elements (consisting of a key and a value) are stored in a binary tree structure, using the [CRBMap::SetAt](../Topic/CRBMap::SetAt.md) method. Elements can be removed using the [CRBMap::RemoveKey](../Topic/CRBMap::RemoveKey.md) method, which deletes the element with the given key value.  
  
 Traversing the tree is made possible with methods such as [CRBTree::GetHeadPosition](../Topic/CRBTree::GetHeadPosition.md), [CRBTree::GetNext](../Topic/CRBTree::GetNext.md), and [CRBTree::GetNextValue](../Topic/CRBTree::GetNextValue.md).  
  
 The `KTraits` and `VTraits` parameters are traits classes that contain any supplemental code needed to copy or move elements.  
  
 `CRBMap` is derived from [CRBTree](../VS_csharp/crbtree-class.md), which implements a binary tree using the Red-Black algorithm. [CRBMultiMap](../VS_csharp/crbmultimap-class.md) is a variation that allows multiple values for each key. It too is derived from `CRBTree`, and so shares many features with `CRBMap`.  
  
 An alternative to both `CRBMap` and `CRBMultiMap` is offered by the [CAtlMap](../VS_csharp/catlmap-class.md) class. When only a small number of elements needs to be stored, consider using the [CSimpleMap](../VS_csharp/csimplemap-class.md) class instead.  
  
 For a more complete discussion of the various collection classes and their features and performance characteristics, see [ATL Collection Classes](../VS_csharp/atl-collection-classes.md).  
  
## Inheritance Hierarchy  
 [CRBTree](../VS_csharp/crbtree-class.md)  
  
 `CRBMap`  
  
## Requirements  
 **Header:** atlcoll.h  
  
##  <a name="crbmap__crbmap"></a>  CRBMap::CRBMap  
 The constructor.  
  
```  
  
explicit CRBMap(  
      size_t  nBlockSize  
    = 10   
   ) throw( );  
  
```  
  
### Parameters  
 `nBlockSize`  
 The block size.  
  
### Remarks  
 The `nBlockSize` parameter is a measure of the amount of memory allocated when a new element is required. Larger block sizes reduce calls to memory allocation routines, but use more resources. The default will allocate space for 10 elements at a time.  
  
 See the documentation for the base class [CRBTree](../VS_csharp/crbtree-class.md) for information on the other methods available.  
  
### Example  
 [!code[NVC_ATL_Utilities#81](../VS_csharp/codesnippet/CPP/crbmap-class_1.cpp)]  
  
##  <a name="crbmap___dtorcrbmap"></a>  CRBMap::~CRBMap  
 The destructor.  
  
```  
  
~CRBMap( ) throw( );  
  
```  
  
### Remarks  
 Frees any allocated resources.  
  
 See the documentation for the base class [CRBTree](../VS_csharp/crbtree-class.md) for information on the other methods available.  
  
##  <a name="crbmap__lookup"></a>  CRBMap::Lookup  
 Call this method to look up keys or values in the `CRBMap` object.  
  
```  
  
bool Lookup(  
      KINARGTYPE  key,  
      VOUTARGTYPE  value  
   ) const throw(...);  
   const CPair* Lookup(  
      KINARGTYPE  key  
   ) const throw( );  
   CPair* Lookup(  
      KINARGTYPE  key  
   ) throw( );  
  
```  
  
### Parameters  
 `key`  
 Specifies the key that identifies the element to be looked up.  
  
 *value*  
 Variable that receives the looked-up value.  
  
### Return Value  
 The first form of the method returns true if the key is found, otherwise false. The second and third forms return a pointer to a [CPair](../VS_csharp/crbtree--cpair-class.md).  
  
### Remarks  
 See the documentation for the base class [CRBTree](../VS_csharp/crbtree-class.md) for information on the other methods available.  
  
### Example  
 [!code[NVC_ATL_Utilities#82](../VS_csharp/codesnippet/CPP/crbmap-class_2.cpp)]  
  
##  <a name="crbmap__removekey"></a>  CRBMap::RemoveKey  
 Call this method to remove an element from the `CRBMap` object, given the key.  
  
```  
  
bool RemoveKey(  
      KINARGTYPE  key  
   ) throw( );  
  
```  
  
### Parameters  
 `key`  
 The key corresponding to the element pair you want to remove.  
  
### Return Value  
 Returns true if the key is found and removed, false on failure.  
  
### Remarks  
 See the documentation for the base class [CRBTree](../VS_csharp/crbtree-class.md) for information on the other methods available.  
  
### Example  
 [!code[NVC_ATL_Utilities#83](../VS_csharp/codesnippet/CPP/crbmap-class_3.cpp)]  
  
##  <a name="crbmap__setat"></a>  CRBMap::SetAt  
 Call this method to insert an element pair into the map.  
  
```  
  
POSITION SetAt(  
      KINARGTYPE  key,  
      VINARGTYPE  value  
   ) throw(...);  
  
```  
  
### Parameters  
 `key`  
 The key value to add to the `CRBMap` object.  
  
 *value*  
 The value to add to the `CRBMap` object.  
  
### Return Value  
 Returns the position of the key/value element pair in the `CRBMap` object.  
  
### Remarks  
 `SetAt` replaces an existing element if a matching key is found. If the key is not found, a new key/value pair is created.  
  
 See the documentation for the base class [CRBTree](../VS_csharp/crbtree-class.md) for information on the other methods available.  
  
### Example  
 [!code[NVC_ATL_Utilities#84](../VS_csharp/codesnippet/CPP/crbmap-class_4.cpp)]  
  
## See Also  
 [CRBTree Class](../VS_csharp/crbtree-class.md)   
 [CAtlMap Class](../VS_csharp/catlmap-class.md)   
 [CRBMultiMap Class](../VS_csharp/crbmultimap-class.md)   
 [Class Overview](../VS_csharp/atl-class-overview.md)