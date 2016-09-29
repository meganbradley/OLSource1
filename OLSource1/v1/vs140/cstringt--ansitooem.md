---
title: "CStringT::AnsiToOem"
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
  - "AnsiToOem"
  - "ATL::CStringT::AnsiToOem"
  - "ATL.CStringT.AnsiToOem"
  - "CStringT::AnsiToOem"
  - "CStringT.AnsiToOem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AnsiToOem method"
ms.assetid: d6c3e893-7cdc-469d-ae40-e8c8c257da95
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringT::AnsiToOem
Converts all the characters in this `CStringT` object from the ANSI character set to the OEM character set.  
  
## Syntax  
  
```  
void AnsiToOem();  
```  
  
## Remarks  
 The function is not available if `_UNICODE` is defined.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#106](../vs140/codesnippet/CPP/cstringt--ansitooem_1.cpp)]  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)