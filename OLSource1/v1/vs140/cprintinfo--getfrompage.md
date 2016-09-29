---
title: "CPrintInfo::GetFromPage"
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
  - "CPrintInfo::GetFromPage"
  - "GetFromPage"
  - "CPrintInfo.GetFromPage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetFromPage method"
  - "CPrintInfo structure, attributes"
ms.assetid: c068bfc4-1b99-4504-ad50-d3eecae52eb0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrintInfo::GetFromPage
Call this function to retrieve the number of the first page to be printed.  
  
## Syntax  
  
```  
  
UINT GetFromPage( ) const;  
```  
  
## Return Value  
 The number of the first page to be printed.  
  
## Remarks  
 This is the value specified by the user in the Print dialog box, and it is stored in the `CPrintDialog` object referenced by the `m_pPD` member. If the user has not specified a value, the default is the first page of the document.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CPrintInfo Structure](../vs140/cprintinfo-structure.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintInfo::m_nCurPage](../vs140/cprintinfo--m_ncurpage.md)   
 [CPrintInfo::m_pPD](../vs140/cprintinfo--m_ppd.md)   
 [CPrintInfo::GetToPage](../vs140/cprintinfo--gettopage.md)