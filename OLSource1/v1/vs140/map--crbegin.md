---
title: "map::crbegin"
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
  - "std::map::crbegin"
  - "map.crbegin"
  - "std.map.crbegin"
  - "map::crbegin"
  - "map/std::map::crbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "crbegin method"
ms.assetid: 78fffdc8-c437-4644-8528-3bfe81e3ef45
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::crbegin
Returns a const iterator addressing the first element in a reversed map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A const reverse bidirectional iterator addressing the first element in a reversed [map](../vs140/map-class.md) or addressing what had been the last element in the unreversed <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is used with a reversed <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> just as [begin](../vs140/map--begin.md) is used with a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 With the return value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object cannot be modified  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> can be used to iterate through a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> backwards.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The first element of the reversed map m1 is 3.**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)