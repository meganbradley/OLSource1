---
title: "_SECURE_SCL"
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
  - "_SECURE_SCL"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_SECURE_SCL"
ms.assetid: 4ffbc788-cc12-4c6a-8cd7-490081675086
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _SECURE_SCL
Defines whether [Checked Iterators](../vs140/checked-iterators.md) are enabled. If defined as 1, unsafe iterator use causes a runtime error and the program is terminated. If defined as 0, checked iterators are disabled. In debug mode, the default value for **_SECURE_SCL** is 1, meaning checked iterators are enabled. In release mode, the default value for `_SECURE_SCL` is 0.  
  
> [!IMPORTANT]
>  Use `_ITERATOR_DEBUG_LEVEL` to control `_SECURE_SCL`. For more information, see [_ITERATOR_DEBUG_LEVEL](../vs140/_iterator_debug_level.md).  
  
## Remarks  
 To enable checked iterators, set **_SECURE_SCL** to 1:  
  
```  
#define _SECURE_SCL 1  
```  
  
 To disable checked iterators, set **_SECURE_SCL** to 0:  
  
```  
#define _SECURE_SCL 0  
```  
  
 For information on how to disable warnings about checked iterators, see [_SCL_SECURE_NO_WARNINGS](../vs140/_scl_secure_no_warnings.md).  
  
## See Also  
 [_ITERATOR_DEBUG_LEVEL](../vs140/_iterator_debug_level.md)   
 [Checked Iterators](../vs140/checked-iterators.md)   
 [Debug Iterator Support](../vs140/debug-iterator-support.md)   
 [Safe Libraries: Standard C++ Library](../vs140/safe-libraries--c---standard-library.md)