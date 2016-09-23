---
title: "CStdioFile::m_pStream"
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
  - CStdioFile.m_pStream
  - m_pStream
  - CStdioFile::m_pStream
dev_langs: 
  - C++
helpviewer_keywords: 
  - CStdioFile class, data members
  - m_pStream
ms.assetid: 706de778-4f04-4518-a692-d4a434a28f2a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CStdioFile::m_pStream
The `m_pStream` data member is the pointer to an open file as returned by the C run-time function `fopen`.  
  
## Syntax  
  
```  
  
FILE* m_pStream;  
  
```  
  
## Remarks  
 It is **NULL** if the file has never been opened or has been closed.  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CStdioFile Class](../vs140/cstdiofile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)