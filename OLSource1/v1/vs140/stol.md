---
title: "stol"
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
  - "std.stol"
  - "stol"
  - "string/std::stol"
  - "std::stol"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "stol"
  - "stol function"
ms.assetid: ecd75b86-2850-4f69-bb1d-8741fb71fc08
caps.latest.revision: 14
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# stol
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
 The long-integer value.  
  
## Remarks  
 The function converts the sequence of elements in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to a value <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> as if by calling <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is an object internal to the function. If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> it throws an object of type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. If such a call would set <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, it throws an object of type <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. Otherwise, if <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is not a null pointer, the function stores <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [string](../vs140/string--c---stl--string--.md)   
 [wstring](../vs140/wstring.md)   
 [\<string>](../vs140/-string-.md)   
 [basic_string Class](../vs140/basic_string-class.md)