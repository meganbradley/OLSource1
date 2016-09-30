---
title: "File Position Errors"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "file pointers [C++], file position errors"
ms.assetid: d5e59d8b-08c0-4927-a338-0b2d8234ce24
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# File Position Errors
**ANSI 4.9.9.1, 4.9.9.4** The value to which the macro <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> is set by the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function on failure  
  
 When <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> fails, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is set to the manifest constant <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if the position is invalid or EBADF if the file number is bad. The constants are defined in ERRNO.H.  
  
## See Also  
 [Library Functions](../vs140/library-functions.md)