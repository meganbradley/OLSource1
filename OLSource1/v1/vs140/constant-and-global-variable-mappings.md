---
title: "Constant and Global Variable Mappings"
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
  - _tenviron
  - _TEOF
  - _tfinddata_t
dev_langs: 
  - C++
  - C
helpviewer_keywords: 
  - tfinddatat function
  - tenviron function
  - TEOF type
  - _TEOF type
  - generic-text mappings
  - _tenviron function
  - _tfinddata_t function
ms.assetid: 3af4fd3e-9ed5-4ed9-96fd-7031e5126fd1
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Constant and Global Variable Mappings
These generic-text constant, global variable, and standard-type mappings are defined in TCHAR.H and depend on whether the constant `_UNICODE` or `_MBCS` has been defined in your program.  
  
### Generic-Text Constant and Global Variable Mappings  
  
|Generic-text - object name|SBCS (_UNICODE, _MBCS not defined)|_MBCS defined|_UNICODE defined|  
|----------------------------------|--------------------------------------------|--------------------|-----------------------|  
|`_TEOF`|`EOF`|`EOF`|`WEOF`|  
|`_tenviron`|`_environ`|`_environ`|`_wenviron`|  
|`_tpgmptr`|`_pgmptr`|`_pgmptr`|`_wpgmptr`|  
  
## See Also  
 [Generic-Text Mappings](../vs140/generic-text-mappings.md)   
 [Data Type Mappings](../vs140/data-type-mappings.md)   
 [Routine Mappings](../vs140/routine-mappings.md)   
 [A Sample Generic-Text Program](../vs140/a-sample-generic-text-program.md)   
 [Using Generic-Text Mappings](../vs140/using-generic-text-mappings.md)