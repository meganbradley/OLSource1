---
title: "CDocTemplate::RemoveDocument"
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
  - "CDocTemplate.RemoveDocument"
  - "RemoveDocument"
  - "CDocTemplate::RemoveDocument"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "documents, removing"
  - "RemoveDocument method"
  - "removing documents"
  - "CDocTemplate class, operations"
ms.assetid: bf00ec59-c6ba-4471-873d-1f2570ed9252
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocTemplate::RemoveDocument
Removes the document pointed to by `pDoc` from the list of documents associated with this template.  
  
## Syntax  
  
```  
  
      virtual void RemoveDocument(  
   CDocument* pDoc   
);  
```  
  
#### Parameters  
 `pDoc`  
 Pointer to the document to be removed.  
  
## Remarks  
 The derived classes `CMultiDocTemplate` and `CSingleDocTemplate` override this function. If you derive your own document-template class from `CDocTemplate`, your derived class must override this function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocTemplate Class](../vs140/cdoctemplate-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocTemplate::AddDocument](../vs140/cdoctemplate--adddocument.md)   
 [CMultiDocTemplate Class](../vs140/cmultidoctemplate-class.md)   
 [CSingleDocTemplate Class](../vs140/csingledoctemplate-class.md)