---
title: "CDocTemplate::AddDocument"
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
  - AddDocument
  - CDocTemplate.AddDocument
  - CDocTemplate::AddDocument
dev_langs: 
  - C++
helpviewer_keywords: 
  - AddDocument method
  - documents, adding to templates
  - CDocTemplate class, operations
ms.assetid: d72727dd-7101-4a38-bb25-b00f7bec637e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDocTemplate::AddDocument
Use this function to add a document to a template.  
  
## Syntax  
  
```  
  
      virtual void AddDocument(  
   CDocument* pDoc   
);  
```  
  
#### Parameters  
 `pDoc`  
 A pointer to the document to be added.  
  
## Remarks  
 The derived classes [CMultiDocTemplate](../vs140/cmultidoctemplate-class.md) and [CSingleDocTemplate](../vs140/csingledoctemplate-class.md) override this function. If you derive your own document-template class from `CDocTemplate`, your derived class must override this function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocTemplate Class](../vs140/cdoctemplate-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocTemplate::RemoveDocument](../vs140/cdoctemplate--removedocument.md)   
 [CMultiDocTemplate Class](../vs140/cmultidoctemplate-class.md)   
 [CSingleDocTemplate Class](../vs140/csingledoctemplate-class.md)