---
title: "CInternetSession::GetCookie"
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
  - "GetCookie"
  - "CInternetSession.GetCookie"
  - "CInternetSession::GetCookie"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCookie method"
ms.assetid: 62899a69-0ed8-4340-bd93-88a20d55bb12
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CInternetSession::GetCookie
This member function implements the behavior of the Win32 function [InternetGetCookie](http://msdn.microsoft.com/library/windows/desktop/aa384710), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a string containing the URL.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a string containing the name of the cookie to get for the specified URL.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 In the first overload, a pointer to a string containing the address of the buffer that receives the cookie data. This value can be **NULL**. In the second overload, a reference to a [CString](../vs140/cstringt-class.md) object to receive the cookie data.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The variable specifying the size of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> buffer. If the function succeeds, the buffer receives the amount of data copied to the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> buffer. If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is **NULL**, this parameter receives a value that specifies the size of the buffer necessary to copy all the cookie data.  
  
## Return Value  
 Returns **TRUE** if successful, or **FALSE** otherwise. If the call fails, call the Win32 function [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) to determine the cause of the error. The following error values apply:  
  
-   **ERROR_NO_MORE_ITEMS** There is no cookie for the specified URL and all its parents.  
  
-   **ERROR_INSUFFICIENT_BUFFER** The value passed in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is insufficient to copy all the cookie data. The value returned in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is the size of the buffer necessary to get all the data.  
  
## Remarks  
 In the second overload, MFC retrieves the cookie data into the supplied <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CInternetSession::GetCookieLength](../vs140/cinternetsession--getcookielength.md)   
 [CInternetSession::SetCookie](../vs140/cinternetsession--setcookie.md)