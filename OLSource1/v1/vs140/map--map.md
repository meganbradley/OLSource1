---
title: "map::map"
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
  - "map::map"
  - "map/std::map::map"
  - "map.map"
  - "std.map.map"
  - "map"
  - "std::map::map"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "map class, constructor"
  - "map method"
ms.assetid: b35c0055-889c-463d-9015-cfd127fb71be
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::map
Constructs a map that is empty or that is a copy of all or part of some other map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The storage allocator class to be used for this map object, which defaults to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The comparison function of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> used to order the elements in the map, which defaults to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|The map of which the constructed set is to be a copy.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|The position of the first element in the range of elements to be copied.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|The position of the first element beyond the range of elements to be copied.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|The initializer_list from which the elements are to be copied.|  
  
## Remarks  
 All constructors store a type of allocator object that manages memory storage for the map and that can later be returned by calling [get_allocator](../vs140/map--get_allocator.md). The allocator parameter is often omitted in the class declarations and preprocessing macros used to substitute alternative allocators.  
  
 All constructors initialize their map.  
  
 All constructors store a function object of type Traits that is used to establish an order among the keys of the map and that can later be returned by calling [key_comp](../vs140/map--key_comp.md).  
  
 The first three constructors specify an empty initial map, the second specifying the type of comparison function (<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>) to be used in establishing the order of the elements and the third explicitly specifying the allocator type (<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>) to be used. The key word <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> suppresses certain kinds of automatic type conversion.  
  
 The fourth constructor specifies a copy of the map <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 The fifth constructor specifies a copy of the map by moving <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 The sixth, seventh, and eighth constructors use an initializer_list from which to copy the members.  
  
 The next three constructors copy the range <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> of a map with increasing explicitness in specifying the type of comparison function of class <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and allocator.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)