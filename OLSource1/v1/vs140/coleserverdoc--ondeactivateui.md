---
title: "COleServerDoc::OnDeactivateUI"
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
  - "COleServerDoc::OnDeactivateUI"
  - "COleServerDoc.OnDeactivateUI"
  - "OnDeactivateUI"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDeactivateUI method"
  - "COleServerDoc class, overridables"
ms.assetid: c08e25d6-2b67-4989-8b64-f7805cceb815
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerDoc::OnDeactivateUI
Called when the user deactivates an item that was activated in place.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies whether the editing changes can be undone.  
  
## Remarks  
 This function restores the container application's user interface to its original state, hiding any menus and other controls that were created for in-place activation.  
  
 The framework always sets <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to **FALSE**. If the server supports undo and there is an operation that can be undone, call the base-class implementation with <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> set to **TRUE**.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerDoc Class](../vs140/coleserverdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerDoc::OnDeactivate](../vs140/coleserverdoc--ondeactivate.md)