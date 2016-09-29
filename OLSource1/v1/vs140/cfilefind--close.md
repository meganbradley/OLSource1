---
title: "CFileFind::Close"
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
  - "CFileFind::Close"
  - "CFileFind.Close"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "searches [C++]"
  - "Close method"
  - "files [C++], closing searches"
  - "searches [C++], closing"
  - "CFileFind class, operations"
ms.assetid: add4ec7c-90b8-49ee-9743-b1ae8f439f5b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileFind::Close
Call this member function to end the search, reset the context, and release all resources.  
  
## Syntax  
  
```  
  
void Close( );  
  
```  
  
## Remarks  
 After calling **Close**, you do not have to create a new `CFileFind` instance before calling [FindFile](../vs140/cfilefind--findfile.md) to begin a new search.  
  
## Example  
 See the example for [CFileFind::GetFileName](../vs140/cfilefind--getfilename.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFileFind Class](../vs140/cfilefind-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)