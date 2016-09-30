---
title: "stoul"
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
  - "std::stoul"
  - "std.stoul"
  - "stoul"
  - "string/std::stoul"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "stoul"
  - "stoul function"
ms.assetid: aaeb71f6-4536-46eb-ae68-18f868c8c689
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# stoul
Converts a character sequence to an unsigned long.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The character sequence to be converted.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The index value of the first unconverted character.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The number base to use.|  
  
## Return Value  
 The unsigned long-integer value.  
  
## Remarks  
 The function converts the sequence of elements in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to a value <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> as if by calling <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is an object internal to the function. If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> it throws an object of type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. If such a call would set <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, it throws an object of type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. Otherwise, if <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is not a null pointer, the function stores <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [string](../vs140/string--c---stl--string--.md)   
 [wstring](../vs140/wstring.md)   
 [\<string>](../vs140/-string-.md)