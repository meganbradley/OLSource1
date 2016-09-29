---
title: "CPrintInfo::GetMinPage"
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
  - "CPrintInfo::GetMinPage"
  - "GetMinPage"
  - "CPrintInfo.GetMinPage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPrintInfo structure, attributes"
  - "GetMinPage method"
ms.assetid: 3a19de44-e66d-463c-9049-70e964158cb0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrintInfo::GetMinPage
Call this function to retrieve the number of the first page of the document.  
  
## Syntax  
  
```  
  
UINT GetMinPage( ) const;  
```  
  
## Return Value  
 The number of the first page of the document.  
  
## Remarks  
 This value is stored in the `CPrintDialog` object referenced by the `m_pPD` member.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CPrintInfo Structure](../vs140/cprintinfo-structure.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintInfo::m_nCurPage](../vs140/cprintinfo--m_ncurpage.md)   
 [CPrintInfo::m_pPD](../vs140/cprintinfo--m_ppd.md)   
 [CPrintInfo::GetMaxPage](../vs140/cprintinfo--getmaxpage.md)   
 [CPrintInfo::SetMaxPage](../vs140/cprintinfo--setmaxpage.md)   
 [CPrintInfo::SetMinPage](../vs140/cprintinfo--setminpage.md)