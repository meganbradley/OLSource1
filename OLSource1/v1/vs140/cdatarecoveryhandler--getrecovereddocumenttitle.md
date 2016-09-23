---
title: "CDataRecoveryHandler::GetRecoveredDocumentTitle"
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
  - CDataRecoveryHandler.GetRecoveredDocumentTitle
  - CDataRecoveryHandler::GetRecoveredDocumentTitle
  - GetRecoveredDocumentTitle
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetRecoveredDocumentTitle method
ms.assetid: 21a9c1c3-36c0-47e1-9bb7-0addad6827f3
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDataRecoveryHandler::GetRecoveredDocumentTitle
Creates and returns the title for the recovered document.  
  
## Syntax  
  
```  
virtual CString GetRecoveredDocumentTitle(  
   const CString &strDocumentTitle  
) const;  
```  
  
#### Parameters  
 [in] `strDocumentTitle`  
 The normal title for the document.  
  
## Return Value  
 The recovered document title.  
  
## Remarks  
 By default, the recovered title of a document is the normal title with **[recovered]** appended to it. The recovered title is displayed to the user when the `CDataRecoveryHandler` queries the user to restore autosaved documents.  
  
## Requirements  
 **Header:** afxdatarecovery.h  
  
## See Also  
 [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataRecoveryHandler::GetNormalDocumentTitle](../vs140/cdatarecoveryhandler--getnormaldocumenttitle.md)