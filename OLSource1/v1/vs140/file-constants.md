---
title: "File Constants"
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
  - "_O_EXCL"
  - "_O_RDWR"
  - "_O_APPEND"
  - "_O_RDONLY"
  - "_O_TRUNC"
  - "_O_CREAT"
  - "_O_WRONLY"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_O_RDWR constant"
  - "O_EXCL constant"
  - "O_RDWR constant"
  - "O_WRONLY constant"
  - "O_APPEND constant"
  - "O_CREAT constant"
  - "_O_CREAT constant"
  - "_O_APPEND constant"
  - "_O_EXCL constant"
  - "O_TRUNC constant"
  - "_O_RDONLY constant"
  - "_O_TRUNC constant"
  - "O_RDONLY constant"
  - "_O_WRONLY constant"
ms.assetid: c8fa5548-9ac2-4217-801d-eb45e86f2fa4
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# File Constants
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The integer expression formed from one or more of these constants determines the type of reading or writing operations permitted. It is formed by combining one or more constants with a translation-mode constant.  
  
 The file constants are as follows:  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Repositions the file pointer to the end of the file before every write operation.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Creates and opens a new file for writing; this has no effect if the file specified by *filename* exists.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Returns an error value if the file specified by *filename* exists. Only applies when used with <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Opens file for reading only; if this flag is given, neither <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> nor <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> can be given.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Opens file for both reading and writing; if this flag is given, neither <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> nor <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> can be given.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Opens and truncates an existing file to zero length; the file must have write permission. The contents of the file are destroyed. If this flag is given, you cannot specify <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Opens file for writing only; if this flag is given, neither <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> nor <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> can be given.  
  
## See Also  
 [_open, _wopen](../vs140/_open--_wopen.md)   
 [_sopen, _wsopen](../vs140/_sopen--_wsopen.md)   
 [Global Constants](../vs140/global-constants.md)