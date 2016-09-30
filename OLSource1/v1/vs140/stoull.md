---
title: "stoull"
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
  - "string/std::stoull"
  - "stoull"
  - "std::stoull"
  - "std.stoull"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "stoull function"
  - "stoull"
ms.assetid: 3eac457d-047e-45c1-898c-83010179752c
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# stoull
Converts a character sequence to an <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
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