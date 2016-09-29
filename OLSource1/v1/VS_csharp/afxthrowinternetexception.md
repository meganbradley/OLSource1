---
title: "AfxThrowInternetException"
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
  - "AFXINET/AfxThrowInternetException"
  - "AfxThrowInternetException"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "exception-throwing functions"
  - "AfxThrowInternetException function"
ms.assetid: c9645b10-9541-48b2-8b0c-94ca33fed3cb
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxThrowInternetException
Throws an Internet exception.  
  
## Syntax  
  
```  
  
      void AFXAPI AfxThrowInternetException(  
   DWORD dwContext,  
   DWORD dwError = 0   
);  
```  
  
#### Parameters  
 `dwContext`  
 The context identifier for the operation that caused the error. The default value of `dwContext` is specified originally in [CInternetSession](../VS_csharp/cinternetsession-class.md) and is passed to [CInternetConnection](../VS_csharp/cinternetconnection-class.md)- and [CInternetFile](../VS_csharp/cinternetfile-class.md)-derived classes. For specific operations performed on a connection or a file, you usually override the default with a `dwContext` of your own. This value then is returned to [CInternetSession::OnStatusCallback](../Topic/CInternetSession::OnStatusCallback.md) to identify the specific operation's status. For more information on context identifiers, see the article [Internet First Steps: WinInet](../VS_csharp/wininet-basics.md).  
  
 `dwError`  
 The error that caused the exception.  
  
## Remarks  
 You are responsible for determining the cause based on the operating-system error code.  
  
> [!NOTE]
>  To call this function, your project must include AFXINET.H.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [CInternetException Class](../VS_csharp/cinternetexception-class.md)   
 [THROW](../VS_csharp/throw--mfc-.md)