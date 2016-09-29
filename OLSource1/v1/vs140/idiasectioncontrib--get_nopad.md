---
title: "IDiaSectionContrib::get_nopad"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSectionContrib::get_nopad method"
ms.assetid: f5c08603-0b3e-4e81-acf1-1b95a6a83bed
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSectionContrib::get_nopad
Retrieves a flag indicating whether the section should not be padded to the next memory boundary.  
  
## Syntax  
  
```cpp#  
HRESULT get_nopad(  
   BOOL* pRetVal  
};  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns `TRUE` if the section should not be padded to the next memory boundary; otherwise returns `FALSE`.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.  
  
## Remarks  
 This is a property typically seen only on older files.  
  
## See Also  
 [IDiaSectionContrib](../vs140/idiasectioncontrib.md)