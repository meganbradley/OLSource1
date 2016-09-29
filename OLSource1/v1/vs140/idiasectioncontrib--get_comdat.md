---
title: "IDiaSectionContrib::get_comdat"
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
  - "IDiaSectionContrib::get_comdat method"
ms.assetid: 8bd9be8d-59ee-4698-b055-daba354b8dcc
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSectionContrib::get_comdat
Retrieves a flag that indicates whether the section is a COMDAT record.  
  
## Syntax  
  
```cpp#  
HRESULT get_comdat (   
   BOOL* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns `TRUE` if the section is a COMDAT record; otherwise, returns `FALSE`.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.  
  
## Remarks  
 A COMDAT record is a Common Object File Format (COFF) record that makes packaged functions visible to the linker.  
  
## See Also  
 [IDiaSectionContrib](../vs140/idiasectioncontrib.md)