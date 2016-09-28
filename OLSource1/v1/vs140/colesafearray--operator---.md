---
title: "COleSafeArray::operator &lt;&lt;"
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
  - "COleSafeArray::operator<<"
  - "COleSafeArray.operator<<"
  - "operator>>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator <<, arrays"
  - "<< operator"
  - "operator<<, arrays"
ms.assetid: 86932034-d6d0-4665-8702-f1431c0bccd8
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleSafeArray::operator &lt;&lt;
The `COleSafeArray` insertion (<<) operator supports diagnostic dumping and storing of a `COleSafeArray` object to an archive.  
  
## Syntax  
  
```  
  
      CDumpContext& AFXAPI operator<<(  
   CDumpContext& dc,  
   COleSafeArray& saSrc   
);  
```  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleSafeArray Class](../vs140/colesafearray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)