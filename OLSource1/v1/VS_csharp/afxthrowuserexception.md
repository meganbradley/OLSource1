---
title: "AfxThrowUserException"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "AFXWIN/AfxThrowUserException"
  - "AfxThrowUserException"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "exception-throwing functions"
  - "AfxThrowUserException function"
ms.assetid: c0c124ce-8b6b-4ccc-93ec-805273057304
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxThrowUserException
Throws an exception to stop an end-user operation.  
  
## Syntax  
  
```  
  
void AfxThrowUserException( );  
```  
  
## Remarks  
 This function is normally called immediately after `AfxMessageBox` has reported an error to the user.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [CUserException Class](../VS_csharp/cuserexception-class.md)   
 [THROW](../VS_csharp/throw--mfc-.md)   
 [AfxMessageBox](../VS_csharp/afxmessagebox.md)   
 [How Do I: Create my Own Custom Exception Classes?](http://go.microsoft.com/fwlink/?LinkId=128045)