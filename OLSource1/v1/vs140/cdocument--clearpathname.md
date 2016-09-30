---
title: "CDocument::ClearPathName"
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
  - "CDocument::ClearPathName"
  - "CDocument.ClearPathName"
  - "ClearPathName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ClearPathName method"
ms.assetid: d1f46865-3c5f-40e0-98c2-22eb5888a83d
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocument::ClearPathName
Clears the path of the document object.  
  
## Syntax  
  
```  
virtual void ClearPathName();  
```  
  
## Remarks  
 Clearing the path from a `CDocument` object causes the application to prompt the user when the document is next saved. This makes a **Save** command behave like a **Save As** command.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocument Class](../vs140/cdocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)