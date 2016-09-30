---
title: "stoll"
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
  - "std.stoll"
  - "string/std::stoll"
  - "stoll"
  - "std::stoll"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "stoll"
  - "stoll function"
ms.assetid: 0233b9a0-1dce-4a6b-a4c1-f064752c551b
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# stoll
Converts a character sequence to a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The character sequence to be converted.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The index value of the first unconverted character.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The number base to use.|  
  
## Return Value  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> value.  
  
## Remarks  
 The function converts the sequence of elements in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to a value <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> as if by calling <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is an object internal to the function. If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> it throws an object of type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. If such a call would set <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, it throws an object of type <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. Otherwise, if <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is not a null pointer, the function stores <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [string](../vs140/string--c---stl--string--.md)   
 [wstring](../vs140/wstring.md)   
 [\<string>](../vs140/-string-.md)