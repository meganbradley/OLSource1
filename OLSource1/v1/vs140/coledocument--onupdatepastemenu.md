---
title: "COleDocument::OnUpdatePasteMenu"
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
  - "OnUpdatePasteMenu"
  - "COleDocument::OnUpdatePasteMenu"
  - "COleDocument.OnUpdatePasteMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDocument class, message handlers"
  - "OnUpdatePasteMenu method"
ms.assetid: 65521b1d-f727-4225-916c-36524a283a00
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDocument::OnUpdatePasteMenu
Called by the framework to determine whether an embedded OLE item can be pasted from the Clipboard.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> structure that represents the menu that generated the update command. The update handler calls the **Enable** member function of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure through <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to update the user interface.  
  
## Remarks  
 The Paste menu command and button are enabled or disabled depending on whether the item can be pasted into the document or not.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDocument Class](../vs140/coledocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDocument::OnUpdatePasteLinkMenu](../vs140/coledocument--onupdatepastelinkmenu.md)   
 [CCmdUI Class](../vs140/ccmdui-class.md)