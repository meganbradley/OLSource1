---
title: "COleClientItem::OnDeactivateUI"
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
  - "COleClientItem.OnDeactivateUI"
  - "OnDeactivateUI"
  - "COleClientItem::OnDeactivateUI"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDeactivateUI method"
  - "COleClientItem class, overridables"
ms.assetid: 92a0ef2a-f88d-4130-8b38-2411021b0532
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::OnDeactivateUI
Called when the user deactivates an item that was activated in place.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies whether the editing changes are undoable.  
  
## Remarks  
 This function restores the container application's user interface to its original state, hiding any menus and other controls that were created for in-place activation.  
  
 If <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is **FALSE**, the container should disable the undo command, in effect discarding the undo state of the container, because it indicates that the last operation performed by the server is not undoable.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::OnActivateUI](../vs140/coleclientitem--onactivateui.md)   
 [COleClientItem::OnDeactivateAndUndo](../vs140/coleclientitem--ondeactivateandundo.md)   
 [COleClientItem::OnDeactivate](../vs140/coleclientitem--ondeactivate.md)