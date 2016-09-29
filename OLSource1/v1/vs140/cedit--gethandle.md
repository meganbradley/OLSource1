---
title: "CEdit::GetHandle"
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
  - "CEdit.GetHandle"
  - "CEdit::GetHandle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetHandle method"
  - "CEdit class, multiple-line operations"
ms.assetid: 99e2df6c-2c32-4a40-b0d5-281f3c130b21
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEdit::GetHandle
Call this function to retrieve a handle to the memory currently allocated for a multiple-line edit control.  
  
## Syntax  
  
```  
  
HLOCAL GetHandle( ) const;  
```  
  
## Return Value  
 A local memory handle that identifies the buffer holding the contents of the edit control. If an error occurs, such as sending the message to a single-line edit control, the return value is 0.  
  
## Remarks  
 The handle is a local memory handle and may be used by any of the **Local** Windows memory functions that take a local memory handle as a parameter.  
  
 **GetHandle** is processed only by multiple-line edit controls.  
  
 Call **GetHandle** for a multiple-line edit control in a dialog box only if the dialog box was created with the **DS_LOCALEDIT** style flag set. If the **DS_LOCALEDIT** style is not set, you will still get a nonzero return value, but you will not be able to use the returned value.  
  
> [!NOTE]
>  **GetHandle** will not work with Windows 95/98. If you call **GetHandle** in Windows 95/98, it will return **NULL**. **GetHandle** will work as documented under Windows NT, versions 3.51 and later.  
  
 For more information, see [EM_GETHANDLE](http://msdn.microsoft.com/library/windows/desktop/bb761576) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CEdit#10](../vs140/codesnippet/CPP/cedit--gethandle_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CEdit Class](../vs140/cedit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEdit::SetHandle](../vs140/cedit--sethandle.md)