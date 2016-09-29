---
title: "Sample Container Members"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "container classes"
ms.assetid: dc5a1998-a31b-4adf-b888-8abe5b87a4e0
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Sample Container Members
> [!NOTE]
>  This topic is in the Visual C++ documentation as a nonfunctional example of containers used in the Standard C++ Library. For more information, see [STL Containers](../VS_csharp/stl-containers.md).  
  
## Reference  
  
## Typedefs  
  
|||  
|-|-|  
|[const_iterator](../VS_csharp/container-class--const_iterator.md)|Describes an object that can serve as a constant iterator for the controlled sequence.|  
|[const_reference](../VS_csharp/container-class--const_reference.md)|Describes an object that can serve as a constant reference to an element of the controlled sequence.|  
|[const_reverse_iterator](../VS_csharp/container-class--const_reverse_iterator.md)|Describes an object that can serve as a constant reverse iterator for the controlled sequence.|  
|[difference_type](../VS_csharp/container-class--difference_type.md)|Describes an object that can represent the difference between the addresses of any two elements in the controlled sequence.|  
|[iterator](../VS_csharp/container-class--iterator.md)|Describes an object that can serve as an iterator for the controlled sequence.|  
|[reference](../VS_csharp/container-class--reference.md)|Describes an object that can serve as a reference to an element of the controlled sequence.|  
|[reverse_iterator](../VS_csharp/container-class--reverse_iterator.md)|Describes an object that can serve as a reverse iterator for the controlled sequence.|  
|[size_type](../VS_csharp/container-class--size_type.md)|Describes an object that can represent the length of any controlled sequence.|  
|[value_type](../VS_csharp/container-class--value_type.md)|Acts a synonym for the template parameter **Ty**.|  
  
## Member Functions  
  
|||  
|-|-|  
|[begin](../VS_csharp/container-class--begin.md)|Returns an iterator that points at the first element of the sequence (or just beyond the end of an empty sequence).|  
|[clear](../VS_csharp/container-class--clear.md)|Calls [erase](../VS_csharp/container-class--erase.md)( [begin](../VS_csharp/container-class--begin.md), [end](../VS_csharp/container-class--end.md)).|  
|[empty](../VS_csharp/container-class--empty.md)|Returns **true** for an empty controlled sequence.|  
|[end](../VS_csharp/container-class--end.md)|Returns an iterator that points just beyond the end of the sequence.|  
|[erase](../VS_csharp/container-class--erase.md)|Erases an element.|  
|[max_size](../VS_csharp/container-class--max_size.md)|Returns the length of the longest sequence that the object can control, in constant time regardless of the length of the controlled sequence.|  
|[rbegin](../VS_csharp/container-class--rbegin.md)|Returns a reverse iterator that points just beyond the end of the controlled sequence, designating the beginning of the reverse sequence.|  
|[rend](../VS_csharp/container-class--rend.md)|The member function returns a reverse iterator that points at the first element of the sequence (or just beyond the end of an empty sequence), designating the end of the reverse sequence.|  
|[size](../VS_csharp/container-class--size.md)|Returns the length of the controlled sequence, in constant time regardless of the length of the controlled sequence.|  
|[swap](../VS_csharp/container-class--swap.md)|Swaps the controlled sequences between **\*this** and `_Right`.|