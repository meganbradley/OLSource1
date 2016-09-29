---
title: "COleServerDoc::OnSetHostNames"
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
  - "OnSetHostNames"
  - "COleServerDoc::OnSetHostNames"
  - "COleServerDoc.OnSetHostNames"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnSetHostNames method"
  - "COleServerDoc class, overridables"
ms.assetid: 92341f95-7bb4-473f-9d6d-ea17874c513b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerDoc::OnSetHostNames
Called by the framework when the container sets or changes the host names for this document.  
  
## Syntax  
  
```  
  
      virtual void OnSetHostNames(  
   LPCTSTR lpszHost,  
   LPCTSTR lpszHostObj   
);  
```  
  
#### Parameters  
 `lpszHost`  
 Pointer to a string that specifies the name of the container application.  
  
 `lpszHostObj`  
 Pointer to a string that specifies the container's name for the document.  
  
## Remarks  
 The default implementation changes the document title for all views referring to this document.  
  
 Override this function if your application sets the titles through a different mechanism.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerDoc Class](../vs140/coleserverdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::SetHostNames](../vs140/coleclientitem--sethostnames.md)