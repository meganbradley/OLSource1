---
title: "CArchive::Flush"
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
  - "CArchive.Flush"
  - "CArchive::Flush"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CArchive class, basic input/output"
  - "data transfer [C++], flushing archive buffer"
  - "data transfer [C++]"
  - "Flush method"
  - "storage [C++]"
ms.assetid: d0d2eaf7-d504-42a8-8c25-d22e729b49fd
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArchive::Flush
Forces any data remaining in the archive buffer to be written to the file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> ensures that all data is transferred from the archive to the file. You must call [CFile::Close](../vs140/cfile--close.md) to complete the transfer from the file to the storage medium.  
  
## Example  
 [!code[NVC_MFCSerialization#13](../vs140/codesnippet/CPP/carchive--flush_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CArchive Class](../vs140/carchive-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArchive::Close](../vs140/carchive--close.md)   
 [CFile::Flush](../vs140/cfile--flush.md)   
 [CFile::Close](../vs140/cfile--close.md)