---
title: "CPrintInfo::m_nJobNumber"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CPrintInfo.m_nJobNumber
  - m_nJobNumber
  - CPrintInfo::m_nJobNumber
dev_langs: 
  - C++
helpviewer_keywords: 
  - CPrintInfo structure, data members
  - m_nJobNumber
  - print jobs, numbering
  - printing [MFC], job numbers
ms.assetid: e83aa3e2-7f23-4f0a-9be8-6abd6cb49e30
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPrintInfo::m_nJobNumber
Indicates the job number assigned by the operating system for the current print job.  
  
## Remarks  
 This value may be **SP_ERROR** if the job hasn't yet printed (that is, if the `CPrintInfo` object is newly constructed and has not yet been used to print), or if there was an error in starting the job.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CPrintInfo Structure](../vs140/cprintinfo-structure.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)