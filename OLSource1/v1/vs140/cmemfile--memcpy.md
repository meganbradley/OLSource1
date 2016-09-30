---
title: "CMemFile::Memcpy"
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
  - "CMemFile.Memcpy"
  - "CMemFile::Memcpy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Memcpy method"
  - "CMemFile class, advanced overridables"
ms.assetid: 4ee8e96e-df1a-43cc-91a4-26f6396f1519
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMemFile::Memcpy
This function is called by the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> overrides of [CFile::Read](../vs140/cfile--read.md) and [CFile::Write](../vs140/cfile--write.md) to transfer data to and from the memory file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the memory block into which the source memory will be copied.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to the source memory block.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Number of bytes to be copied.  
  
## Return Value  
 A copy of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 Override this function if you want to change the way that <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> does these memory copies.  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CMemFile Class](../vs140/cmemfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFile::Read](../vs140/cfile--read.md)   
 [CFile::Write](../vs140/cfile--write.md)