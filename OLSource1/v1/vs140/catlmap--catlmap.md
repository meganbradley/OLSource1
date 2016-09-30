---
title: "CAtlMap::CAtlMap"
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
  - "ATL.CAtlMap.CAtlMap"
  - "CAtlMap::CAtlMap"
  - "ATL::CAtlMap::CAtlMap"
  - "CAtlMap.CAtlMap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAtlMap constructor"
  - "CAtlMap class, constructor"
ms.assetid: 51d9e79b-eb18-414a-8452-be7421f83113
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlMap::CAtlMap
The constructor.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The number of bins providing pointers to the stored elements. See Remarks later in this topic for an explanation of bins.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The optimal load ratio.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The lower threshold for the load ratio.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The upper threshold for the load ratio.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The block size.  
  
## Remarks  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> references all of its stored elements by first creating an index using a hashing algorithm on the key. This index references a "bin" which contains a pointer to the stored elements. If the bin is already in use, a linked-list is created to access the subsequent elements. Traversing a list is slower than directly accessing the correct element, and so the map structure needs to balance storage requirements against performance. The default parameters have been chosen to give good results in most cases.  
  
 The load ratio is the ratio of the number of bins to the number of elements stored in the map object. When the map structure is recalculated, the *fOptimalLoad* parameter value will be used to calculate the number of bins required. This value can be changed using the [CAtlMap::SetOptimalLoad](../vs140/catlmap--setoptimalload.md) method.  
  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter is the lower value that the load ratio can reach before <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> will recalculate the optimal size of the map.  
  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter is the upper value that the load ratio can reach before the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object will recalculate the optimal size of the map.  
  
 This recalculation process (known as rehashing) is enabled by default. If you want to disable this process, perhaps when entering a lot of data at one time, call the [CAtlMap::DisableAutoRehash](../vs140/catlmap--disableautorehash.md) method. Reactivate it with the [CAtlMap::EnableAutoRehash](../vs140/catlmap--enableautorehash.md) method.  
  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter is a measure of the amount of memory allocated when a new element is required. Larger block sizes reduce calls to memory allocation routines, but use more resources.  
  
 Before any data can be stored, it is necessary to initialize the hash table with a call to [CAtlMap::InitHashTable](../vs140/catlmap--inithashtable.md).  
  
## Example  
 [!code[NVC_ATL_Utilities#72](../vs140/codesnippet/CPP/catlmap--catlmap_1.cpp)]  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlMap Class](../vs140/catlmap-class.md)   
 [CAtlMap::~CAtlMap](../vs140/catlmap--~catlmap.md)