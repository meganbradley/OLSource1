---
title: "hash_map::hash_map"
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
  - "stdext.hash_map.hash_map"
  - "hash_map/stdext::hash_map::hash_map"
  - "hash_map::hash_map"
  - "std::hash_map::hash_map"
  - "hash_map.hash_map"
  - "std.hash_map.hash_map"
  - "stdext::hash_map::hash_map"
  - "hash_map"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "hash_map class, constructor"
  - "hash_map method"
ms.assetid: c11d6729-c571-43a1-96fd-360ec678b23a
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::hash_map
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Constructs a hash_map that is empty or is a copy of all or part of some other hash_map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The storage allocator class to be used for this hash_map object, which defaults to **Allocator**.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The comparison function of type const <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> used to order the elements in the hash_map, which defaults to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The hash_map of which the constructed map is to be a copy.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The position of the first element in the range of elements to be copied.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|The position of the first element beyond the range of elements to be copied.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|The initializer_list|  
  
## Remarks  
 All constructors store a type of allocator object that manages memory storage for the hash_map and can later be returned by calling [get_allocator](../vs140/hash_map--get_allocator.md). The allocator parameter is often omitted in the class declarations and preprocessing macros used to substitute alternative allocators.  
  
 All constructors initialize their hash_map.  
  
 All constructors store a function object of type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> that is used to establish an order among the keys of the hash_map and that can later be returned by calling [key_comp](../vs140/hash_map--key_comp.md).  
  
 The first three constructors specify an empty initial hash_map, in addition, the second specifies the type of comparison function (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>) to be used in establishing the order of the elements and the third explicitly specifies the allocator type (<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>) to be used. The keyword <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> suppresses certain kinds of automatic type conversion.  
  
 The fourth constructor specifies a copy of the hash_map <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 The next three constructors copy the range <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> of a hash_map with increasing explicitness in specifying the type of comparison function of class <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and allocator.  
  
 The last constructor moves the hash_map <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)