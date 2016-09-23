---
title: "COleServerDoc::OnReactivateAndUndo"
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
  - OnReactivateAndUndo
  - COleServerDoc.OnReactivateAndUndo
  - COleServerDoc::OnReactivateAndUndo
dev_langs: 
  - C++
helpviewer_keywords: 
  - COleServerDoc class, overridables
  - OnReactivateAndUndo method
ms.assetid: edd82065-f220-41b2-8c16-9b73271d24d7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleServerDoc::OnReactivateAndUndo
The framework calls this function when the user chooses to undo changes made to an item that has been activated in place, changed, and subsequently deactivated.  
  
## Syntax  
  
```  
  
virtual BOOL OnReactivateAndUndo( );  
```  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The default implementation does nothing except return **FALSE** to indicate failure.  
  
 Override this function if your application supports undo. Usually you would perform the undo operation, then activate the item by calling `ActivateInPlace`. If the container application is written with the Microsoft Foundation Class Library, calling `COleClientItem::ReactivateAndUndo` causes this function to be called.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerDoc Class](../vs140/coleserverdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerDoc::ActivateInPlace](../vs140/coleserverdoc--activateinplace.md)   
 [COleServerDoc::IsInPlaceActive](../vs140/coleserverdoc--isinplaceactive.md)   
 [COleClientItem::ReactivateAndUndo](../vs140/coleclientitem--reactivateandundo.md)