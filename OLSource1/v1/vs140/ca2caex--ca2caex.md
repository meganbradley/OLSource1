---
title: "CA2CAEX::CA2CAEX"
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
  - "ATL::CA2CAEX::CA2CAEX"
  - "ATL::CA2CAEX<t_nBufferLength>::CA2CAEX"
  - "ATL.CA2CAEX.CA2CAEX"
  - "ATL.CA2CAEX<t_nBufferLength>.CA2CAEX"
  - "CA2CAEX"
  - "CA2CAEX<t_nBufferLength>::CA2CAEX"
  - "CA2CAEX::CA2CAEX"
  - "CA2CAEX<t_nBufferLength>.CA2CAEX"
  - "CA2CAEX.CA2CAEX"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CA2CAEX class, constructor"
  - "CA2CAEX constructor"
ms.assetid: bd5d7ec2-dcea-4180-a613-42d132b5b906
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA2CAEX::CA2CAEX
The constructor.  
  
## Syntax  
  
```  
  
      CA2CAEX(  
   LPCSTR psz,  
   UINT nCodePage  
) throw(...);  
CA2CAEX(  
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
 [CA2CAEX Class](../vs140/ca2caex-class.md)