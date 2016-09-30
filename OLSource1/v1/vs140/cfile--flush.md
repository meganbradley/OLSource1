---
title: "CFile::Flush"
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
  - "CFile.Flush"
  - "CFile::Flush"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Flush method"
  - "CFile class, input/output"
ms.assetid: 5061b688-6abe-4513-b08b-4973b3699963
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFile::Flush
Forces any data remaining in the file buffer to be written to the file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The use of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> does not guarantee flushing of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> buffers. If you are using an archive, call [CArchive::Flush](../vs140/carchive--flush.md) first.  
  
## Example  
 See the example for [CFile::SetFilePath](../vs140/cfile--setfilepath.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFile Class](../vs140/cfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)