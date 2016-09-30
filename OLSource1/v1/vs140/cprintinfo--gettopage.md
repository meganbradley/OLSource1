---
title: "CPrintInfo::GetToPage"
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
  - "CPrintInfo.GetToPage"
  - "GetToPage"
  - "CPrintInfo::GetToPage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPrintInfo structure, attributes"
  - "GetToPage method"
ms.assetid: 17b1203a-e6e4-4431-9d24-a622e23405a3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrintInfo::GetToPage
Call this function to retrieve the number of the last page to be printed.  
  
## Syntax  
  
```  
  
UINT GetToPage( ) const;  
```  
  
## Return Value  
 The number of the last page to be printed.  
  
## Remarks  
 This is the value specified by the user in the Print dialog box, and it is stored in the `CPrintDialog` object referenced by the `m_pPD` member. If the user has not specified a value, the default is the last page of the document.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CPrintInfo Structure](../vs140/cprintinfo-structure.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintInfo::m_nCurPage](../vs140/cprintinfo--m_ncurpage.md)   
 [CPrintInfo::m_pPD](../vs140/cprintinfo--m_ppd.md)   
 [CPrintInfo::GetFromPage](../vs140/cprintinfo--getfrompage.md)