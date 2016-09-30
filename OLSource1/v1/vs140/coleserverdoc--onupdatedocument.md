---
title: "COleServerDoc::OnUpdateDocument"
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
  - "OnUpdateDocument"
  - "COleServerDoc.OnUpdateDocument"
  - "COleServerDoc::OnUpdateDocument"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleServerDoc class, overridables"
  - "OnUpdateDocument method"
ms.assetid: 261c0000-0e50-4b30-a27b-5a5eae289a32
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerDoc::OnUpdateDocument
Called by the framework when saving a document that is an embedded item in a compound document.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the document was successfully updated; otherwise 0.  
  
## Remarks  
 The default implementation calls the [COleServerDoc::NotifySaved](../vs140/coleserverdoc--notifysaved.md) and [COleServerDoc::SaveEmbedding](../vs140/coleserverdoc--saveembedding.md) member functions and then marks the document as clean. Override this function if you want to perform special processing when updating an embedded item.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerDoc Class](../vs140/coleserverdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerDoc::NotifySaved](../vs140/coleserverdoc--notifysaved.md)   
 [COleServerDoc::SaveEmbedding](../vs140/coleserverdoc--saveembedding.md)   
 [CDocument::OnSaveDocument](../vs140/cdocument--onsavedocument.md)