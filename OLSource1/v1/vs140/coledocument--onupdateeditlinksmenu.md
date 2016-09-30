---
title: "COleDocument::OnUpdateEditLinksMenu"
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
  - "OnUpdateEditLinksMenu"
  - "COleDocument::OnUpdateEditLinksMenu"
  - "COleDocument.OnUpdateEditLinksMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnUpdateEditLinksMenu method"
  - "COleDocument class, message handlers"
ms.assetid: 560598b8-8c21-4bbc-9511-c32c23f1b148
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDocument::OnUpdateEditLinksMenu
Called by the framework to update the Links command on the Edit menu.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> structure that represents the menu that generated the update command. The update handler calls the **Enable** member function of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure through <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to update the user interface.  
  
## Remarks  
 Starting with the first OLE item in the document, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> accesses each item, tests whether the item is a link, and, if it is a link, enables the Links command. Override this function to change the behavior.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDocument Class](../vs140/coledocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDocument::OnEditLinks](../vs140/coledocument--oneditlinks.md)   
 [COleDocument::GetStartPosition](../vs140/coledocument--getstartposition.md)   
 [COleDocument::GetNextClientItem](../vs140/coledocument--getnextclientitem.md)   
 [CCmdUI Class](../vs140/ccmdui-class.md)