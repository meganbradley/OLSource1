---
title: "CFile::GetPosition"
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
  - "CFile.GetPosition"
  - "CFile::GetPosition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPosition method"
  - "CFile class, status"
ms.assetid: e4274a9d-c40d-4309-b5f6-e226c00fc8f9
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFile::GetPosition
Obtains the current value of the file pointer, which can be used in subsequent calls to `Seek`.  
  
## Syntax  
  
```  
  
virtual ULONGLONG GetPosition( ) const;  
```  
  
## Return Value  
 The file pointer.  
  
## Example  
 [!code[NVC_MFCFiles#8](../vs140/codesnippet/CPP/cfile--getposition_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFile Class](../vs140/cfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)