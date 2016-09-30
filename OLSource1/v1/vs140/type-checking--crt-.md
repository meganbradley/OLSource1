---
title: "Type Checking (CRT)"
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
  - "c.types"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "checking type"
  - "variable argument functions"
  - "type checking"
ms.assetid: 1ba7590b-d1c0-4636-b6a0-e231395abdad
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type Checking (CRT)
The compiler performs limited type checking on functions that can take a variable number of arguments, as follows:  
  
|Function call|Type-checked arguments|  
|-------------------|-----------------------------|  
|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|First argument (format string)|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|First two arguments (file or buffer and format string)|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|First three arguments (file or buffer, count, and format string)|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|First two arguments (path and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> flag)|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|First three arguments (path, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> flag, and sharing mode)|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|First two arguments (path and first argument pointer)|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|First three arguments (mode flag, path, and first argument pointer)|  
  
 The compiler performs the same limited type checking on the wide-character counterparts of these functions.  
  
## See Also  
 [CRT Library Features](../vs140/crt-library-features.md)