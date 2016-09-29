---
title: "Document-Template Classes"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vc.classes.document"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "document templates, classes"
ms.assetid: 901749e9-8048-44a0-b5e2-361554650a73
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Document-Template Classes
Document-template objects coordinate the creation of document, view, and frame window objects when a new document or view is created.  
  
 [CDocTemplate](../vs140/cdoctemplate-class.md)  
 The base class for document templates. You will never use this class directly; instead, you use one of the other document-template classes derived from this class.  
  
 [CMultiDocTemplate](../vs140/cmultidoctemplate-class.md)  
 A template for documents in the multiple document interface (MDI). MDI applications can have multiple documents open at a time.  
  
 [CSingleDocTemplate](../vs140/csingledoctemplate-class.md)  
 A template for documents in the single document interface (SDI). SDI applications have only one document open at a time.  
  
## Related Class  
 [CCreateContext](../vs140/ccreatecontext-structure.md)  
 A structure passed by a document template to window-creation functions to coordinate the creation of document, view, and frame-window objects.  
  
## See Also  
 [Class Overview](../vs140/class-library-overview.md)