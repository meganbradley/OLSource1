---
title: "CAxDialogImpl::IsDialogMessage"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - ATL.CAxDialogImpl.IsDialogMessage
  - CAxDialogImpl::IsDialogMessage
  - CAxDialogImpl.IsDialogMessage
  - ATL::CAxDialogImpl::IsDialogMessage
dev_langs: 
  - C++
helpviewer_keywords: 
  - IsDialogMessage method
ms.assetid: 0c54e7ff-267a-4219-8bb6-f94234aba867
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAxDialogImpl::IsDialogMessage
Call this method to determine whether a message is intended for this dialog box and, if it is, process the message.  
  
## Syntax  
  
```  
  
      BOOL IsDialogMessage(  
   LPMSG pMsg  
);  
```  
  
#### Parameters  
 `pMsg`  
 Pointer to a [MSG](http://msdn.microsoft.com/library/windows/desktop/ms644958) structure that contains the message to be checked.  
  
## Return Value  
 Returns TRUE if the message has been processed, FALSE otherwise.  
  
## Remarks  
 This method is intended to be called from within a message loop.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CAxDialogImpl Class](../vs140/caxdialogimpl-class.md)