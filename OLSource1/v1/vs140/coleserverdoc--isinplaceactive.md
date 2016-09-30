---
title: "COleServerDoc::IsInPlaceActive"
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
  - "COleServerDoc::IsInPlaceActive"
  - "COleServerDoc.IsInPlaceActive"
  - "IsInPlaceActive"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleServerDoc class, attributes"
  - "IsInPlaceActive method"
ms.assetid: 1336c21f-001b-47e9-86e6-fd0ec15db423
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerDoc::IsInPlaceActive
Call the `IsInPlaceActive` member function to determine whether the item is currently in the in-place active state.  
  
## Syntax  
  
```  
  
BOOL IsInPlaceActive( ) const;  
```  
  
## Return Value  
 Nonzero if the `COleServerDoc` object is active in place; otherwise 0.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerDoc Class](../vs140/coleserverdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::OnActivate](../vs140/coleclientitem--onactivate.md)   
 [COleServerDoc::OnReactivateAndUndo](../vs140/coleserverdoc--onreactivateandundo.md)   
 [COleServerDoc::ActivateInPlace](../vs140/coleserverdoc--activateinplace.md)