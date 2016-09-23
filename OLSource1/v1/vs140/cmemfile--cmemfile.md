---
title: "CMemFile::CMemFile"
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
  - CMemFile::CMemFile
  - CMemFile.CMemFile
dev_langs: 
  - C++
helpviewer_keywords: 
  - CMemFile class, constructor
ms.assetid: fedb77d2-22d1-4177-a187-bcac913bf3a4
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMemFile::CMemFile
The first overload opens an empty memory file.  
  
## Syntax  
  
```  
  
      CMemFile(  
   UINT nGrowBytes = 1024   
);  
CMemFile(  
   BYTE* lpBuffer,  
   UINT nBufferSize,  
   UINT nGrowBytes = 0   
);  
```  
  
#### Parameters  
 `nGrowBytes`  
 The memory allocation increment in bytes.  
  
 *lpBuffe*r  
 Pointer to a buffer that receives information of the size `nBufferSize`.  
  
 `nBufferSize`  
 An integer that specifies the size of the file buffer, in bytes.  
  
## Remarks  
 Note that the file is opened by the constructor and that you should not call [CFile::Open](../vs140/cfile--open.md).  
  
 The second overload acts the same as if you used the first constructor and immediately called [Attach](../vs140/cmemfile--attach.md) with the same parameters. See **Attach** for details.  
  
## Example  
 [!code[NVC_MFCFiles#36](../vs140/codesnippet/CPP/cmemfile--cmemfile_1.cpp)]
  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CMemFile Class](../vs140/cmemfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMemFile::Attach](../vs140/cmemfile--attach.md)