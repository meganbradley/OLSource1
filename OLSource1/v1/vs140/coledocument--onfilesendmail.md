---
title: "COleDocument::OnFileSendMail"
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
  - "COleDocument::OnFileSendMail"
  - "COleDocument.OnFileSendMail"
  - "OnFileSendMail"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDocument class, mail functions"
  - "OnFileSendMail method"
ms.assetid: 185ea608-ab73-4363-aa1a-6904695c5d99
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDocument::OnFileSendMail
Sends a message via the resident mail host (if any) with the document as an attachment.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to serialize (save) untitled and modified documents to a temporary file, which is then sent via electronic mail. If the document has not been modified, a temporary file is not needed; the original is sent. <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> loads MAPI32.DLL if it has not already been loaded.  
  
 Unlike the implementation of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> for **CDocument**, this function handles compound files correctly.  
  
 For more information, see the [MAPI Topics](../vs140/mapi.md) and [MAPI Support in MFC](../vs140/mapi-support-in-mfc.md) articles..  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDocument Class](../vs140/coledocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocument::OnFileSendMail](../vs140/cdocument--onfilesendmail.md)   
 [CDocument::OnUpdateFileSendMail](../vs140/cdocument--onupdatefilesendmail.md)   
 [CDocument::OnSaveDocument](../vs140/cdocument--onsavedocument.md)