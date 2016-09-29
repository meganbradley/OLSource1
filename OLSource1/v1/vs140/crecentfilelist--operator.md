---
title: "CRecentFileList::operator"
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
  - "CRecentFileList.operator[]"
  - "CRecentFileList::operator[]"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator[], most recently used file list"
  - "operator [], most recently used file list"
  - "[] operator"
ms.assetid: 7c8d5927-1c6d-4b7a-9ebc-6481782bbfd5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecentFileList::operator
The overloaded subscript (`[]`) operator returns a single `CString` specified by the zero-based index in `nIndex`.  
  
## Syntax  
  
```  
  
      CString& operator[ ](int nIndex);  
```  
  
#### Parameters  
 `nIndex`  
 Zero-based index of a `CString` in a set of `CString`s.  
  
## Requirements  
 **Header:** afxadv.h  
  
## See Also  
 [CRecentFileList Class](../vs140/crecentfilelist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)