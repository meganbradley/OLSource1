---
title: "fseek, _lseek Constants"
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
  - "SEEK_END"
  - "SEEK_SET"
  - "SEEK_CUR"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "SEEK_SET constant"
  - "SEEK_END constant"
  - "SEEK_CUR constant"
ms.assetid: 9deeb13e-5aa3-4c33-80d8-721c80a4de9d
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# fseek, _lseek Constants
## Syntax  
  
```  
  
#include <stdio.h>  
  
```  
  
## Remarks  
 The *origin* argument specifies the initial position and can be one of the following manifest constants:  
  
|Constant|Meaning|  
|--------------|-------------|  
|`SEEK_END`|End of file|  
|`SEEK_CUR`|Current position of file pointer|  
|`SEEK_SET`|Beginning of file|  
  
## See Also  
 [fseek, _fseeki64](../vs140/fseek--_fseeki64.md)   
 [_lseek, _lseeki64](../vs140/_lseek--_lseeki64.md)   
 [Global Constants](../vs140/global-constants.md)