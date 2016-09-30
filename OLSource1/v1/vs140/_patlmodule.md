---
title: "_pAtlModule"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "ATLBASE/_pAtlModule"
  - "_pAtlModule"
  - "ATL::_pAtlModule"
  - "ATL._pAtlModule"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pAtlModule variable"
  - "_pAtlModule variable"
ms.assetid: 0ecde3a9-3f4d-4c7b-bb54-713ce05c4777
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _pAtlModule
A global variable storing a pointer to the current module.  
  
## Syntax  
  
```  
__declspec(selectany) CAtlModule * _pAtlModule  
```  
  
## Remarks  
 Methods on this global variable can be used to provide the functionality that the (now obsolete) class [CComModule](../vs140/ccommodule-class.md) provided in Visual C++ 6.0.  
  
## Example  
 [!code[NVC_ATL_Windowing#97](../vs140/codesnippet/CPP/_patlmodule_1.cpp)]  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [Global Variables](../vs140/atl-global-variables.md)