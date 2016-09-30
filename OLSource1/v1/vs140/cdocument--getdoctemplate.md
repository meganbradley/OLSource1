---
title: "CDocument::GetDocTemplate"
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
  - "GetDocTemplate"
  - "CDocument::GetDocTemplate"
  - "CDocument.GetDocTemplate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDocTemplate method"
  - "CDocument class, operations"
  - "document templates, getting"
ms.assetid: a02c4f2e-8800-4a40-bd2d-85ab64c0087c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocument::GetDocTemplate
Call this function to get a pointer to the document template for this document type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to the document template for this document type, or **NULL** if the document is not managed by a document template.  
  
## Example  
 [!code[NVC_MFCDocView#58](../vs140/codesnippet/CPP/cdocument--getdoctemplate_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocument Class](../vs140/cdocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocTemplate Class](../vs140/cdoctemplate-class.md)