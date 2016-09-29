---
title: "COleDocument::OnUpdatePasteLinkMenu"
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
  - "OnUpdatePasteLinkMenu"
  - "COleDocument::OnUpdatePasteLinkMenu"
  - "COleDocument.OnUpdatePasteLinkMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnUpdatePasteLinkMenu method"
  - "COleDocument class, message handlers"
ms.assetid: bcb2e757-dedf-4d87-9ca7-aaa17ef8170a
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDocument::OnUpdatePasteLinkMenu
Called by the framework to determine whether a linked OLE item can be pasted from the Clipboard.  
  
## Syntax  
  
```  
  
      afx_msg void OnUpdatePasteLinkMenu(  
   CCmdUI* pCmdUI   
);  
```  
  
#### Parameters  
 `pCmdUI`  
 A pointer to a `CCmdUI` structure that represents the menu that generated the update command. The update handler calls the **Enable** member function of the `CCmdUI` structure through `pCmdUI` to update the user interface.  
  
## Remarks  
 The Paste Special menu command is enabled or disabled depending on whether the item can be pasted into the document or not.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDocument Class](../vs140/coledocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDocument::OnUpdatePasteMenu](../vs140/coledocument--onupdatepastemenu.md)   
 [CCmdUI Class](../vs140/ccmdui-class.md)