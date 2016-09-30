---
title: "tiled_extent Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "amp/Concurrency::tiled_extent"
dev_langs: 
  - "C++"
ms.assetid: 671ecaf8-c7b0-4ac8-bbdc-e30bd92da7c0
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# tiled_extent Class
A <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object is an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object of one to three dimensions that subdivides the extent space into one-, two-, or three-dimensional tiles.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The length of the most significant dimension.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The length of the next-to-most significant dimension.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The length of the least significant dimension.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[tiled_extent::tiled_extent Constructor](../vs140/tiled_extent--tiled_extent-constructor.md)|Initializes a new instance of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> class.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[tiled_extent::get_tile_extent Method](../vs140/tiled_extent--get_tile_extent-method.md)|Returns an <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object  that captures the values of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> template arguments <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.|  
|[tiled_extent::pad Method](../vs140/tiled_extent--pad-method.md)|Returns a new <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object with extents adjusted up to be evenly divisible by the tile dimensions.|  
|[tiled_extent::truncate Method](../vs140/tiled_extent--truncate-method.md)|Returns a new <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object with extents adjusted down to be evenly divisible by the tile dimensions.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[tiled_extent::operator= Operator](../vs140/tiled_extent--operator=-operator.md)|Copies the contents of the specified <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object into this one.|  
  
### Public Constants  
  
|Name|Description|  
|----------|-----------------|  
|[tiled_extent::tile_dim0 Constant](../vs140/tiled_extent--tile_dim0-constant.md)|Stores the length of the most significant dimension.|  
|[tiled_extent::tile_dim1 Constant](../vs140/tiled_extent--tile_dim1-constant.md)|Stores the length of the next-to-most significant dimension.|  
|[tiled_extent::tile_dim2 Constant](../vs140/tiled_extent--tile_dim2-constant.md)|Stores the length of the least significant dimension.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[tiled_extent::tile_extent Data Member](../vs140/tiled_extent--tile_extent-data-member.md)|Gets an <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object  that captures the values of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> template arguments <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [Concurrency Namespace (C++ AMP)](../vs140/concurrency-namespace--c---amp-.md)