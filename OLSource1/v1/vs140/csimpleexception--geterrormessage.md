---
title: "CSimpleException::GetErrorMessage"
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
  - "CSimpleException.GetErrorMessage"
  - "CSimpleException::GetErrorMessage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSimpleExceptionClass"
  - "CSimpleExceptionClass, get error message"
ms.assetid: 48fec433-e472-4ef8-af48-1d6e42df98af
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleException::GetErrorMessage
Call this member function to provide text about an error that has occurred.  
  
## Syntax  
  
```  
  
      virtual BOOL GetErrorMessage(  
   LPTSTR lpszError,  
   UINT nMaxError,  
   PUNIT pnHelpContext = NULL  
);  
```  
  
#### Parameters  
 `lpszError`  
 A pointer to a buffer that will receive an error message.  
  
 `nMaxError`  
 The maximum number of characters the buffer can hold, including the **NULL** terminator.  
  
 `pnHelpContext`  
 The address of a **UINT** that will receive the help context ID. If **NULL**, no ID will be returned.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0 if no error message text is available.  
  
## Remarks  
 For more information, see [CException::GetErrorMessage](../vs140/cfileexception--geterrormessage.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CSimpleException Class](../vs140/csimpleexception-class.md)