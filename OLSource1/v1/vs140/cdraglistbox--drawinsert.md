---
title: "CDragListBox::DrawInsert"
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
  - "CDragListBox.DrawInsert"
  - "DrawInsert"
  - "CDragListBox::DrawInsert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawInsert method"
  - "CDragListBox class, operations"
ms.assetid: b09b7b9d-5b8d-40bc-b144-2d0b634cfe7d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDragListBox::DrawInsert
Called by the framework to draw the insertion guide before the item with the indicated index.  
  
## Syntax  
  
```  
  
      virtual void DrawInsert(  
   int nItem   
);  
```  
  
#### Parameters  
 `nItem`  
 Zero-based index of the insertion point.  
  
## Remarks  
 A value of - 1 clears the insertion guide. Override this function to modify the appearance or behavior of the insertion guide.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CDragListBox Class](../vs140/cdraglistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)