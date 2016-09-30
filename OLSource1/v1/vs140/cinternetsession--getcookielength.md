---
title: "CInternetSession::GetCookieLength"
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
  - "CInternetSession.GetCookieLength"
  - "GetCookieLength"
  - "CInternetSession::GetCookieLength"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCookieLength method"
ms.assetid: 2f24ebcc-e85a-44fe-b303-8ea21990cbc2
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CInternetSession::GetCookieLength
Call this member function to get the length of the cookie stored in the buffer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a string containing the URL  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a string containing the name of the cookie.  
  
## Return Value  
 A <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> value indicating the length of the cookie, stored in the buffer. Zero if no cookie with the name indicated by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> exists.  
  
## Remarks  
 This value is used by [GetCookie](../vs140/cinternetsession--getcookie.md).  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CInternetSession Class](../vs140/cinternetsession-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CInternetSession::SetCookie](../vs140/cinternetsession--setcookie.md)