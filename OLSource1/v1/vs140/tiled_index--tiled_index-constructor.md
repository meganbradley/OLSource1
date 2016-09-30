---
title: "tiled_index::tiled_index Constructor"
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
  - "amp/Concurrency::tiled_index::tiled_index"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tiled_index, constructor"
ms.assetid: 1f43e0fe-eab7-4e1d-8fd1-bb84c790b01c
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# tiled_index::tiled_index Constructor
Initializes a new instance of the [tiled_index](../vs140/tiled_index-class.md) class.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The global [index](../vs140/index-class.md) of the constructed <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The local [index](../vs140/index-class.md) of the constructed <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The tile [index](../vs140/index-class.md) of the constructed <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The tile origin [index](../vs140/index-class.md) of the constructed <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The [tile_barrier](../vs140/tile_barrier-class.md) object of the constructed <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object to be copied to the constructed <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
## Overloads  
  
|||  
|-|-|  
|Name|Description|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Initializes a new instance of the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> class from the index of the tile in global coordinates and the relative position in the tile in local coordinates. The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> parameters are computed.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Initializes a new instance of the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> class by copying the specified <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object.|  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [tiled_index Class](../vs140/tiled_index-class.md)