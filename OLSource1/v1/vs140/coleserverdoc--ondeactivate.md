---
title: "COleServerDoc::OnDeactivate"
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
  - "COleServerDoc::OnDeactivate"
  - "COleServerDoc.OnDeactivate"
  - "OnDeactivate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleServerDoc class, overridables"
  - "OnDeactivate method"
ms.assetid: 1b0dce0d-32dc-4b6a-9e71-ffb0853f86f6
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerDoc::OnDeactivate
Called by the framework when the user deactivates an embedded or linked item that is currently in-place active.  
  
## Syntax  
  
```  
  
virtual void OnDeactivate( );  
```  
  
## Remarks  
 This function restores the container application's user interface to its original state and destroys any menus and other controls that were created for in-place activation.  
  
 The undo state information should be unconditionally released at this point.  
  
 For more information, see the article [Activation](../vs140/activation--c---.md)..  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerDoc Class](../vs140/coleserverdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerDoc::ActivateInPlace](../vs140/coleserverdoc--activateinplace.md)   
 [COleServerDoc::OnDeactivateUI](../vs140/coleserverdoc--ondeactivateui.md)   
 [COleServerDoc::DestroyInPlaceFrame](../vs140/coleserverdoc--destroyinplaceframe.md)