---
title: "CArchive::Write"
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
  - "CArchive::Write"
  - "CArchive.Write"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CArchive class, basic input/output"
  - "I/O [C++], CArchive class"
  - "Write method"
ms.assetid: 229d20c8-ede5-4595-9ccf-17183e12a8fe
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArchive::Write
Writes a specified number of bytes to the archive.  
  
## Syntax  
  
```  
  
      void Write(  
   const void* lpBuf,  
   UINT nMax   
);  
```  
  
#### Parameters  
 `lpBuf`  
 A pointer to a user-supplied buffer that contains the data to be written to the archive.  
  
 `nMax`  
 An integer that specifies the number of bytes to be written to the archive.  
  
## Remarks  
 The archive does not format the bytes.  
  
 You can use the **Write** member function within your `Serialize` function to write ordinary structures that are contained in your objects.  
  
## Example  
 [!code[NVC_MFCSerialization#23](../vs140/codesnippet/CPP/carchive--write_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CArchive Class](../vs140/carchive-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArchive::Read](../vs140/carchive--read.md)