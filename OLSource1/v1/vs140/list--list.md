---
title: "list::list"
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
  - "std::list::list"
  - "list"
  - "std.list.list"
  - "list.list"
  - "list/std::list::list"
  - "list::list"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "list class, constructor"
  - "list method"
ms.assetid: 415ff234-ff4e-4236-a7fe-0aa1ec7300a2
caps.latest.revision: 22
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# list::list
Constructs a list of a specific size or with elements of a specific value or with a specific allocator or as a copy of all or part of some other list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The allocator class to use with this object.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The number of elements in the list constructed.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The value of the elements in the list.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The list of which the constructed list is to be a copy.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The position of the first element in the range of elements to be copied.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|The position of the first element beyond the range of elements to be copied.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|The initializer_list that contains the elements to be copied.|  
  
## Remarks  
 All constructors store an allocator object (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>) and initialize the list.  
  
 [get_allocator](../vs140/list--get_allocator.md) returns a copy of the allocator object used to construct a list.  
  
 The first two constructors specify an empty initial list, the second specifying the allocator type (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>) to be used.  
  
 The third constructor specifies a repetition of a specified number (<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>) of elements of the default value for class **Type**.  
  
 The fourth and fifth constructors specify a repetition of (<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>) elements of value <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 The sixth constructor specifies a copy of the list <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 The seventh constructor moves the list <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 The eighth constructor uses an initializer_list to specify the elements.  
  
 The next two constructors copy the range <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> of a list.  
  
 None of the constructors perform any interim reallocations.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **c1 = 0 0 0c2 = 2 2 2 2 2c3 = 1 1 1c4 = 2 2 2 2 2c5 = 2 2c6 = 2 2 2c7 = 2 2 2c8 = 1 2 3 4**   
## Requirements  
 **Header:** \<list>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)