---
title: "COleServerDoc::OnShowDocument"
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
  - "COleServerDoc.OnShowDocument"
  - "COleServerDoc::OnShowDocument"
  - "OnShowDocument"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleServerDoc class, overridables"
  - "OnShowDocument method"
ms.assetid: 919f1b39-776a-4085-bbaf-388d07dd9fd5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerDoc::OnShowDocument
The framework calls the `OnShowDocument` function when the server document must be hidden or shown.  
  
## Syntax  
  
```  
  
      virtual void OnShowDocument(  
   BOOL bShow   
);  
```  
  
#### Parameters  
 `bShow`  
 Specifies whether the user interface to the document is to be shown or hidden.  
  
## Remarks  
 If `bShow` is **TRUE**, the default implementation activates the server application, if necessary, and causes the container application to scroll its window so that the item is visible. If `bShow` is **FALSE**, the default implementation deactivates the item through a call to `OnDeactivate`, then destroys or hides all frame windows that have been created for the document, except the first one. If no visible documents remain, the default implementation hides the server application.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerDoc Class](../vs140/coleserverdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerDoc::ActivateInPlace](../vs140/coleserverdoc--activateinplace.md)   
 [COleServerItem::OnDoVerb](../vs140/coleserveritem--ondoverb.md)   
 [COleServerDoc::IsInPlaceActive](../vs140/coleserverdoc--isinplaceactive.md)   
 [COleServerDoc::OnDeactivateUI](../vs140/coleserverdoc--ondeactivateui.md)