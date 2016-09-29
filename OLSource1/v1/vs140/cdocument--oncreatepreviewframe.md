---
title: "CDocument::OnCreatePreviewFrame"
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
  - "afxwin/CDocument::OnCreatePreviewFrame"
  - "OnCreatePreviewFrame"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnCreatePreviewFrame"
ms.assetid: 18a1e06d-89cb-4061-8539-b387ed27a1d1
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocument::OnCreatePreviewFrame
Called by the framework when it needs to create a preview frame for Rich Preview.  
  
## Syntax  
  
```  
virtual BOOL OnCreatePreviewFrame();  
```  
  
## Return Value  
 Returns `TRUE` if the frame is created successfully; otherwise `FALSE`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocument Class](../vs140/cdocument-class.md)