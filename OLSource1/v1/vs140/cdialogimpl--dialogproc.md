---
title: "CDialogImpl::DialogProc"
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
  - "DialogProc"
  - "CDialogImpl::DialogProc"
  - "CDialogImpl.DialogProc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DialogProc method"
ms.assetid: 828fa7fc-dd61-4f72-954c-2185d17823fc
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDialogImpl::DialogProc
This static function implements the dialog box procedure.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The handle to the dialog box.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The message sent to the dialog box.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Additional message-specific information.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] Additional message-specific information.  
  
## Return Value  
 **TRUE** if the message is processed; otherwise, **FALSE**.  
  
## Remarks  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> uses the default message map to direct messages to the appropriate handlers.  
  
 You can override <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to provide a different mechanism for handling messages.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CDialogImpl Class](../vs140/cdialogimpl-class.md)   
 [BEGIN_MSG_MAP](../vs140/begin_msg_map.md)