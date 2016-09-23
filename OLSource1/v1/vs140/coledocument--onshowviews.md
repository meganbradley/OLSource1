---
title: "COleDocument::OnShowViews"
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
  - COleDocument::OnShowViews
  - OnShowViews
  - COleDocument.OnShowViews
dev_langs: 
  - C++
helpviewer_keywords: 
  - COleDocument class, overridables
  - OnShowViews method
ms.assetid: 500f1e6d-c14b-4536-bcb4-a87b8e9eaf0b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleDocument::OnShowViews
The framework calls this function after the document's visibility state changes.  
  
## Syntax  
  
```  
  
      virtual void OnShowViews(  
   BOOL bVisible   
);  
```  
  
#### Parameters  
 `bVisible`  
 Indicates whether the document has become visible or invisible.  
  
## Remarks  
 The default version of this function does nothing. Override it if your application must perform any special processing when the document's visibility changes.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDocument Class](../vs140/coledocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)