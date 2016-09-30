---
title: "CDocument::OnUpdateFileSendMail"
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
  - "OnUpdateFileSendMail"
  - "CDocument::OnUpdateFileSendMail"
  - "CDocument.OnUpdateFileSendMail"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MAPI and Send Mail command"
  - "mail"
  - "OnUpdateFileSendMail method"
  - "e-mail, sending"
  - "mail, sending"
  - "e-mail"
  - "CDocument class, mail functions"
  - "documents, mailing"
ms.assetid: 2861c621-b49c-419f-ae89-10561cc2b62c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocument::OnUpdateFileSendMail
Enables the **ID_FILE_SEND_MAIL** command if mail support (MAPI) is present.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the [CCmdUI](../vs140/ccmdui-class.md) object associated with the **ID_FILE_SEND_MAIL** command.  
  
## Remarks  
 Otherwise the function removes the **ID_FILE_SEND_MAIL** command from the menu, including separators above or below the menu item as appropriate. MAPI is enabled if MAPI32.DLL is present in the path and, in the [Mail] section of the WIN.INI file, MAPI=1. Most applications put this command on the File menu.  
  
 **CDocument** supports sending your document via mail if mail support (MAPI) is present. See the articles [MAPI Topics](../vs140/mapi.md) and [MAPI Support in MFC](../vs140/mapi-support-in-mfc.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocument Class](../vs140/cdocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocument::OnFileSendMail](../vs140/cdocument--onfilesendmail.md)