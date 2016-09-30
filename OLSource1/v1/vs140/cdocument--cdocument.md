---
title: "CDocument::CDocument"
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
  - "CDocument.CDocument"
  - "CDocument::CDocument"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "documents, creating"
  - "documents, constructing"
  - "CDocument class, constructor"
  - "documents, destroying"
  - "CDocument class, construction/destruction"
ms.assetid: 82eabad0-e2bd-428c-ae84-ec08b6fc8c71
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocument::CDocument
Constructs a **CDocument** object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The framework handles document creation for you. Override the [OnNewDocument](../vs140/cdocument--onnewdocument.md) member function to perform initialization on a per-document basis; this is particularly important in single document interface (SDI) applications.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocument Class](../vs140/cdocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocument::OnNewDocument](../vs140/cdocument--onnewdocument.md)   
 [CDocument::OnOpenDocument](../vs140/cdocument--onopendocument.md)