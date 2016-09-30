---
title: "map::crend"
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
  - "map::crend"
  - "std.map.crend"
  - "map/std::map::crend"
  - "std::map::crend"
  - "map.crend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "crend method"
ms.assetid: 199b68fb-33e9-4adc-9ebe-c00aa93d3ed8
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::crend
Returns a const iterator that addresses the location succeeding the last element in a reversed map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A const reverse bidirectional iterator that addresses the location succeeding the last element in a reversed [map](../vs140/map-class.md) (the location that had preceded the first element in the unreversed <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>).  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is used with a reversed map just as [end](../vs140/map--end.md) is used with a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 With the return value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object cannot be modified.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 The value returned by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> should not be dereferenced.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The last element of the reversed map m1 is 1.**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)