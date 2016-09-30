---
title: "CFile::UnlockRange"
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
  - "UnlockRange"
  - "CFile::UnlockRange"
  - "CFile.UnlockRange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UnlockRange method"
  - "CFile class, locking"
ms.assetid: f531a98b-cf25-47c3-bd1a-6daba9fdf0af
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFile::UnlockRange
Unlocks a range of bytes in an open file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The byte offset of the start of the byte range to unlock.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The number of bytes in the range to unlock.  
  
## Remarks  
 See the description of the [LockRange](../vs140/cfile--lockrange.md) member function for details.  
  
> [!NOTE]
>  This function is not available for the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>-derived class.  
  
## Example  
 [!code[NVC_MFCFiles#12](../vs140/codesnippet/CPP/cfile--unlockrange_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFile Class](../vs140/cfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFile::LockRange](../vs140/cfile--lockrange.md)