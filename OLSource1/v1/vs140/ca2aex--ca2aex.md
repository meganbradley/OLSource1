---
title: "CA2AEX::CA2AEX"
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
  - "CA2AEX"
  - "ATL::CA2AEX<t_nBufferLength>::CA2AEX"
  - "ATL.CA2AEX.CA2AEX"
  - "CA2AEX<t_nBufferLength>.CA2AEX"
  - "CA2AEX::CA2AEX"
  - "ATL.CA2AEX<t_nBufferLength>.CA2AEX"
  - "CA2AEX<t_nBufferLength>::CA2AEX"
  - "ATL::CA2AEX::CA2AEX"
  - "CA2AEX.CA2AEX"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CA2AEX constructor"
  - "CA2AEX class, constructor"
ms.assetid: 003073e0-f466-4211-bbf9-97263075fad3
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA2AEX::CA2AEX
The constructor.  
  
## Syntax  
  
```  
  
      CA2AEX(  
   LPCSTR psz,  
   UINT nCodePage   
) throw(...);  
CA2AEX(  
   LPCSTR psz  
) throw(...);  
```  
  
#### Parameters  
 `psz`  
 The text string to be converted.  
  
 `nCodePage`  
 Unused in this class.  
  
## Remarks  
 Creates the buffer required for the translation.  
  
## Requirements  
 **Header:** atlconv.h  
  
## See Also  
 [CA2AEX Class](../vs140/ca2aex-class.md)