---
title: "COleDocument::EnableCompoundFile"
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
  - EnableCompoundFile
  - COleDocument::EnableCompoundFile
  - COleDocument.EnableCompoundFile
dev_langs: 
  - C++
helpviewer_keywords: 
  - EnableCompoundFile method
  - COleDocument class, operations
ms.assetid: 9e9ce0f3-df37-4963-92f5-1409652f970c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleDocument::EnableCompoundFile
Call this function if you want to store the document using the compound-file format.  
  
## Syntax  
  
```  
  
      void EnableCompoundFile(  
   BOOL bEnable = TRUE   
);  
```  
  
#### Parameters  
 `bEnable`  
 Specifies whether compound file support is enabled or disabled.  
  
## Remarks  
 This is also called structured storage. You typically call this function from the constructor of your `COleDocument`-derived class. For more information about compound documents, see the article [Containers: Compound Files](../vs140/containers--compound-files.md)..  
  
 If you do not call this member function, documents will be stored in a nonstructured ("flat") file format.  
  
 After compound file support is enabled or disabled for a document, the setting should not be changed during the document's lifetime.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDocument Class](../vs140/coledocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem Class](../vs140/coleclientitem-class.md)