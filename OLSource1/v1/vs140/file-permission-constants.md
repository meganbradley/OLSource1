---
title: "File Permission Constants"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - _S_IWRITE
  - _S_IREAD
dev_langs: 
  - C++
  - C
helpviewer_keywords: 
  - S_IWRITE constant
  - constants [C++], file attributes
  - S_IREAD constant
  - file permissions [C++]
  - _S_IWRITE constant
  - _S_IREAD constant
ms.assetid: 593cad33-31d1-44d2-8941-8af7d210c88c
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# File Permission Constants
## Syntax  
  
```  
  
#include <sys/stat.h>  
  
```  
  
## Remarks  
 One of these constants is required when `_O_CREAT` (`_open`, `_sopen`) is specified.  
  
 The `pmode` argument specifies the file's permission settings as follows.  
  
|Constant|Meaning|  
|--------------|-------------|  
|`_S_IREAD`|Reading permitted|  
|`_S_IWRITE`|Writing permitted|  
|`_S_IREAD` &#124; `_S_IWRITE`|Reading and writing permitted|  
  
 When used as the `pmode` argument for `_umask`, the manifest constant sets the permission setting, as follows.  
  
|Constant|Meaning|  
|--------------|-------------|  
|`_S_IREAD`|Writing not permitted (file is read-only)|  
|`_S_IWRITE`|Reading not permitted (file is write-only)|  
|`_S_IREAD` &#124; `_S_IWRITE`|Neither reading nor writing permitted|  
  
## See Also  
 [_open, _wopen](../vs140/_open--_wopen.md)   
 [_sopen, _wsopen](../vs140/_sopen--_wsopen.md)   
 [_umask](../vs140/_umask.md)   
 [Standard Types](../vs140/standard-types.md)   
 [Global Constants](../vs140/global-constants.md)