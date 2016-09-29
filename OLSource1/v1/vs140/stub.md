---
title: "STUB"
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
  - "STUB"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "STUB .def file statement"
ms.assetid: 0a3b9643-19ed-47e9-8173-ee16bc8ed056
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# STUB
When used in a module definition file that builds a virtual device driver (VxD), allows you to specify a file name that contains an IMAGE_DOS_HEADER structure (defined in WINNT.H) to be used in the virtual device driver (VxD), rather than the default header.  
  
```  
STUB:filename  
```  
  
## Remarks  
 An equivalent way to specify *filename* is with the [/STUB](../vs140/-stub--ms-dos-stub-file-name-.md) linker option.  
  
 STUB is valid in a module definition file only when building a VxD.  
  
## See Also  
 [Rules for Module-Definition Statements](../vs140/rules-for-module-definition-statements.md)