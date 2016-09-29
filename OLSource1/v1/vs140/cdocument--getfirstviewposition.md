---
title: "CDocument::GetFirstViewPosition"
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
  - "CDocument::GetFirstViewPosition"
  - "CDocument.GetFirstViewPosition"
  - "GetFirstViewPosition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "document view position"
  - "CDocument class, operations"
  - "document views"
  - "GetFirstViewPosition method"
  - "views, position"
ms.assetid: 960181d5-1c5c-4335-b19d-ad259faa9a68
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocument::GetFirstViewPosition
Call this function to get the position of the first view in the list of views associated with the document.  
  
## Syntax  
  
```  
  
virtual POSITION GetFirstViewPosition( ) const;  
```  
  
## Return Value  
 A **POSITION** value that can be used for iteration with the [GetNextView](../vs140/cdocument--getnextview.md) member function.  
  
## Example  
 [!code[NVC_MFCDocView#59](../vs140/codesnippet/CPP/cdocument--getfirstviewposition_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocument Class](../vs140/cdocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocument::GetNextView](../vs140/cdocument--getnextview.md)