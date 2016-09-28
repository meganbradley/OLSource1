---
title: "CPrintInfo::m_dwFlags"
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
  - "CPrintInfo.m_dwFlags"
  - "CPrintInfo::m_dwFlags"
  - "m_dwFlags"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPrintInfo structure, data members"
  - "m_dwFlags"
ms.assetid: 441b3374-b41e-475e-8fe8-2ef54a9402c6
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrintInfo::m_dwFlags
Contains a combination of flags specifying DocObject printing operations.  
  
## Remarks  
 Valid only if data member **m_bDocObject** is **TRUE**.  
  
 The flags can be one or more of the following values:  
  
-   **PRINTFLAG_MAYBOTHERUSER**  
  
-   **PRINTFLAG_PROMPTUSER**  
  
-   **PRINTFLAG_USERMAYCHANGEPRINTER**  
  
-   **PRINTFLAG_RECOMPOSETODEVICE**  
  
-   **PRINTFLAG_DONTACTUALLYPRINT**  
  
-   **PRINTFLAG_FORCEPROPERTIES**  
  
-   **PRINTFLAG_PRINTTOFILE**  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CPrintInfo Structure](../vs140/cprintinfo-structure.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintInfo::m_bDocObject](../vs140/cprintinfo--m_bdocobject.md)   
 [CPrintInfo::m_nOffsetPage](../vs140/cprintinfo--m_noffsetpage.md)