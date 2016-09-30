---
title: "CInternetSession::SetOption"
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
  - "CInternetSession.SetOption"
  - "SetOption"
  - "CInternetSession::SetOption"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Internet options"
  - "SetOption method"
  - "CInternetSession class, attributes"
  - "Set Internet options"
  - "Set option"
ms.assetid: 4c30d846-9c8a-4e7c-a0f3-11fb7b1ef040
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CInternetSession::SetOption
Call this member function to set options for the Internet session.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The Internet option to set. See [Option Flags](http://msdn.microsoft.com/library/windows/desktop/aa385328) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]for a list of the possible options.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A buffer that contains the option setting.  
  
 *dwBufferLength*  
 The length of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or the size of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> that contains the option setting.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Indicates various caching options. The default is set to 0. The possible values include:  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> Do not cache the data, either locally or in any gateway servers.  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> Download operations are satisfied through the persistent cache only. If the item does not exist in the cache, an appropriate error code is returned. This flag may be combined with the bitwise <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> (**&#124;**) operator.  
  
## Return Value  
 If the operation was successful, a value of **TRUE** is returned. If an error occurred, a value of **FALSE** is returned. If the call fails, the Win32 function [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) may be called to determine the cause of the error.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CInternetSession Class](../vs140/cinternetsession-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CInternetSession::ServiceTypeFromHandle](assetId:///00458651-5aea-4788-bc37-9fc45f731a80)