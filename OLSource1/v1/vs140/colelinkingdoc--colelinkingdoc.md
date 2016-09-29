---
title: "COleLinkingDoc::COleLinkingDoc"
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
  - "COleLinkingDoc"
  - "COleLinkingDoc.COleLinkingDoc"
  - "COleLinkingDoc::COleLinkingDoc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleLinkingDoc class, constructor"
ms.assetid: 01439322-dc07-4d04-8b2e-2b505729489f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleLinkingDoc::COleLinkingDoc
Constructs a `COleLinkingDoc` object without beginning communications with the OLE system DLLs.  
  
## Syntax  
  
```  
  
COleLinkingDoc( );  
```  
  
## Remarks  
 You must call the `Register` member function to inform OLE that the document is open.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleLinkingDoc Class](../vs140/colelinkingdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleLinkingDoc::Register](../vs140/colelinkingdoc--register.md)