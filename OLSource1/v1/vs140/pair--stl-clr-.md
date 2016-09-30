---
title: "pair (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "pair (STL/CLR)"
f1_keywords: 
  - "cliext::pair"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pair class [STL/CLR]"
ms.assetid: 3326b4d9-a52a-49e5-8103-9aa5e8b352de
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# pair (STL-CLR)
The template class describes an object that wraps a pair of values.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 Value1  
 The type of first wrapped value.  
  
 Value2  
 The type of second wrapped value.  
  
## Members  
  
|Type Definition|Description|  
|---------------------|-----------------|  
|[first_type](../vs140/pair--first_type--stl-clr-.md)|The type of the first wrapped value.|  
|[second_type](../vs140/pair--second_type--stl-clr-.md)|The type of the second wrapped value.|  
  
|Member Object|Description|  
|-------------------|-----------------|  
|[first](../vs140/pair--first--stl-clr-.md)|The first stored value.|  
|[second](../vs140/pair--second--stl-clr-.md)|The second stored value.|  
  
|Member Function|Description|  
|---------------------|-----------------|  
|[pair](../vs140/pair--pair--stl-clr-.md)|Constructs a pair object.|  
|[swap](../vs140/pair--swap--stl-clr-.md)|Swaps the contents of two pairs.|  
  
|Operator|Description|  
|--------------|-----------------|  
|[operator=](../vs140/pair--operator=--stl-clr-.md)|Replaces the stored pair of values.|  
  
## Remarks  
 The object stores a pair of values. You use this template class to combine two values into a single object. Note that <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> (described here) stores only managed types; to store a pair of unmanaged types use <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, declared in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<cliext/utility>  
  
 **Namespace:** cliext  
  
## See Also  
 [make_pair](../vs140/make_pair--stl-clr-.md)