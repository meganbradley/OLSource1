---
title: "stoi"
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
  - "stoi"
  - "string/std::stoi"
  - "std::stoi"
  - "std.stoi"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "stoi function"
  - "stoi"
ms.assetid: 9c895354-bd9f-4d5d-b66f-b287e8f5c4ab
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# stoi
Converts a character sequence to an integer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The integer value.  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The character sequence to be converted.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Contains the index of the first unconverted character on return.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The number base to use.|  
  
## Remarks  
 The function <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> converts the sequence of characters in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to a value of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and returns the value. For example, when passed a character sequence "10", the value returned by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is the integer 10.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> behaves similarly to the function <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> for single-byte characters when it is called in the manner <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is an object internal to the function; or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> for wide characters, when it is called in similar manner, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. For more information, see [strtol, wcstol, _strtol_l, _wcstol_l](../vs140/strtol--wcstol--_strtol_l--_wcstol_l.md).  
  
 If <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> throws an object of type <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. If such a call would set <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, or if the returned valuecannot be represented as an object of type <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, it throws an object of type <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. Otherwise, if <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is not a null pointer, the function stores <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [string](../vs140/string--c---stl--string--.md)   
 [wstring](../vs140/wstring.md)   
 [\<string>](../vs140/-string-.md)