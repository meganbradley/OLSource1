---
title: "CDocTemplate::SetDefaultTitle"
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
  - CDocTemplate.SetDefaultTitle
  - SetDefaultTitle
  - CDocTemplate::SetDefaultTitle
dev_langs: 
  - C++
helpviewer_keywords: 
  - defaults, document titles
  - SetDefaultTitle method
  - default document titles
  - CDocTemplate class, overridables
  - documents, default title
ms.assetid: f122f478-a0b0-4854-932e-9fa179528e95
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDocTemplate::SetDefaultTitle
Call this function to load the document's default title and display it in the document's title bar.  
  
## Syntax  
  
```  
  
      virtual void SetDefaultTitle(  
   CDocument* pDocument   
) = 0;  
```  
  
#### Parameters  
 *pDocument*  
 Pointer to the document whose title is to be set.  
  
## Remarks  
 For information on the default title, see the description of **CDocTemplate::docName** in [CDocTemplate::GetDocString](../vs140/cdoctemplate--getdocstring.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocTemplate Class](../vs140/cdoctemplate-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocTemplate::GetDocString](../vs140/cdoctemplate--getdocstring.md)