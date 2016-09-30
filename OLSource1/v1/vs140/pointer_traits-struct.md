---
title: "pointer_traits Struct"
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
  - "memory/std::pointer_traits::element_type"
  - "memory/std::pointer_traits::pointer"
  - "memory/std::pointer_traits"
  - "memory/std::pointer_traits::difference_type"
  - "memory/std::pointer_traits::rebind"
  - "xmemory0/std::pointer_traits::element_type"
  - "xmemory0/std::pointer_traits::pointer"
  - "xmemory0/std::pointer_traits"
  - "xmemory0/std::pointer_traits::difference_type"
  - "xmemory0/std::pointer_traits::rebind"
dev_langs: 
  - "C++"
ms.assetid: 545aecf1-3561-4859-8b34-603c079fe1b3
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# pointer_traits Struct
Supplies information that is needed by an object of template class <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to describe an allocator with pointer type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Ptr can be a raw pointer of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or a class with the following properties.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if that type exists, otherwise <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is a raw pointer, the type is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|The type <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> if that type exists, otherwise <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is a raw pointer, the type is <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|The type is <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.|  
  
### Structs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Attempts to convert the underlying pointer type to a specified type.|  
  
### Methods  
  
|Name|Description|  
|----------|-----------------|  
|[pointer_traits_pointer_to](#pointer_traits__pointer_to_method)|Converts an arbitrary reference to an object of class <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.|  
  
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
##  \<a name="pointer_traits__pointer_to_method">\</a>  pointer_traits::pointer_to Method  
 Static method that returns <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, if that function exists. Otherwise, it is not possible to convert an arbitrary reference to an object of class <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is a raw pointer, this method returns <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [\<memory>](../vs140/-memory-.md)   
 [allocator_traits Class](../vs140/allocator_traits-class.md)