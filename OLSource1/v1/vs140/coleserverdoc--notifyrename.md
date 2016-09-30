---
title: "COleServerDoc::NotifyRename"
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
  - "COleServerDoc.NotifyRename"
  - "NotifyRename"
  - "COleServerDoc::NotifyRename"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleServerDoc class, operations"
  - "NotifyRename method"
ms.assetid: 227ae374-bf4f-4522-acfc-5c4c76c333a6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerDoc::NotifyRename
Call this function after the user renames the server document.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a string specifying the new name of the server document; this is typically a fully qualified path.  
  
## Remarks  
 When the user chooses the Save As command from the File menu, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is called by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>'s implementation of the [OnSaveDocument](../vs140/cdocument--onsavedocument.md) member function. This function notifies the OLE system DLLs, which in turn notify the containers. In container applications written with the Microsoft Foundation Class Library, the [OnChange](../vs140/coleclientitem--onchange.md) member function of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is called.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerDoc Class](../vs140/coleserverdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerDoc::NotifySaved](../vs140/coleserverdoc--notifysaved.md)   
 [CDocument::OnSaveDocument](../vs140/cdocument--onsavedocument.md)