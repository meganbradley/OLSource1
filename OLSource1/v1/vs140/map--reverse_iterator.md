---
title: "map::reverse_iterator"
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
  - "reverse_iterator"
  - "map.reverse_iterator"
  - "map/std::map::reverse_iterator"
  - "std.map.reverse_iterator"
  - "map::reverse_iterator"
  - "std::map::reverse_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reverse_iterator typedef"
  - "reverse_iterator method"
ms.assetid: 105d1d38-98ac-4341-8b22-b7b4e20c27d4
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::reverse_iterator
A type that provides a bidirectional iterator that can read or modify an element in a reversed map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 A type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> cannot modify the value of an element and is use to iterate through the map in reverse.  
  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> defined by map points to elements that are objects of [value_type](../vs140/map--value_type.md), that is of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>*\<***const Key**, **Type***>*, whose first member is the key to the element and whose second member is the mapped datum held by the element.  
  
 To dereference a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> pointing to an element in a map, use the **->** operator.  
  
 To access the value of the key for the element, use <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> -> **first**, which is equivalent to (\*<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>).**first**. To access the value of the mapped datum for the element, use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> -> **second**, which is equivalent to (\*<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>).**first**.  
  
## Example  
 See example for [rbegin](../vs140/map--rbegin.md) for an example of how to declare and use <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)