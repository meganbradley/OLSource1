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
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# File Position Errors
**ANSI 4.9.9.1, 4.9.9.4** The value to which the macro `errno` is set by the `fgetpos` or `ftell` function on failure  
  
 When `fgetpos` or `ftell` fails, `errno` is set to the manifest constant `EINVAL` if the position is invalid or EBADF if the file number is bad. The constants are defined in ERRNO.H.  
  
## See Also  
 [Library Functions](../vs140/library-functions.md)