---
title: "CRichEditView::InsertFileAsObject"
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
  - "CRichEditView.InsertFileAsObject"
  - "InsertFileAsObject"
  - "CRichEditView::InsertFileAsObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InsertFileAsObject method"
  - "CRichEditView class, operations"
ms.assetid: 67c6b1d9-d3c4-4e10-a013-a9969e040657
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditView::InsertFileAsObject
Call this function to insert the specified file (as a [CRichEditCntrItem](../vs140/cricheditcntritem-class.md) object) into a rich edit view.  
  
## Syntax  
  
```  
  
      void InsertFileAsObject(  
   LPCTSTR lpszFileName   
);  
```  
  
#### Parameters  
 `lpszFileName`  
 String containing the name of the file to be inserted.  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditView Class](../vs140/cricheditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditView::InsertItem](../vs140/cricheditview--insertitem.md)   
 [CRichEditCntrItem Class](../vs140/cricheditcntritem-class.md)