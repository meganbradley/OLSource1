---
title: "CMFCToolBarImages::IsReadOnly"
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
  - "CMFCToolBarImages::IsReadOnly"
  - "CMFCToolBarImages.IsReadOnly"
  - "IsReadOnly"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsReadOnly method"
ms.assetid: bdd42781-de0b-4030-b5d1-27e4a6455385
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarImages::IsReadOnly
Specifies whether the toolbar images are read-only.  
  
## Syntax  
  
```  
BOOL IsReadOnly() const;  
```  
  
## Return Value  
 `TRUE` if the toolbar images are read-only, otherwise `FALSE`.  
  
## Remarks  
 The `CMFCToolbarImages` object is read-only when the bitmap with toolbar images was loaded from a read-only file, or when the bitmap was copied in using the `CMFCToolBarImages::CopyTemp`method.  
  
## Requirements  
 **Header:** afxtoolbarimages.h  
  
## See Also  
 [CMFCToolBarImages Class](../vs140/cmfctoolbarimages-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)