---
title: "stof"
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
  - "string/std::stof"
  - "stof"
  - "std::stof"
  - "std.stof"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "stof"
  - "stof function"
ms.assetid: d633979b-2347-46d2-9d1d-01c947e76232
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# stof
Converts a character sequence to a float.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The character sequence to be converted.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The index value of the first unconverted character.|  
  
## Return Value  
 The float value.  
  
## Remarks  
 The function converts the sequence of elements in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to a value <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> as if by calling <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is an object internal to the function. If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> it throws an object of type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. If such a call would set <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, it throws an object of type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. Otherwise, if <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is not a null pointer, the function stores <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [string](../vs140/string--c---stl--string--.md)   
 [wstring](../vs140/wstring.md)   
 [\<string>](../vs140/-string-.md)