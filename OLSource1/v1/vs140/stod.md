---
title: "stod"
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
  - "stod"
  - "string/std::stod"
  - "std.stod"
  - "std::stod"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "stod"
  - "stod function"
ms.assetid: 42aad3e3-f79b-43bf-ab13-61da7a88bd09
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# stod
Converts a character sequence to a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The character sequence to be converted.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The index value of the first unconverted character.|  
  
## Return Value  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> value.  
  
## Remarks  
 The function converts the sequence of elements in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to a value <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> as if by calling <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is an object internal to the function. If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> it throws an object of type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. If such a call would set <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, it throws an object of type <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. Otherwise, if <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is not a null pointer, the function stores <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [string](../vs140/string--c---stl--string--.md)   
 [wstring](../vs140/wstring.md)   
 [\<string>](../vs140/-string-.md)