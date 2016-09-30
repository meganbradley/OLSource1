---
title: "CAccessToken::GetProcessToken"
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
  - "GetProcessToken"
  - "ATL.CAccessToken.GetProcessToken"
  - "CAccessToken::GetProcessToken"
  - "CAccessToken.GetProcessToken"
  - "ATL::CAccessToken::GetProcessToken"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetProcessToken method"
ms.assetid: f8bc2ea5-6434-46df-bd34-cd862d998ac7
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAccessToken::GetProcessToken
Call this method to initialize the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> with the access token from the given process.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies an access mask that specifies the requested types of access to the access token. These requested access types are compared with the token's DACL to determine which accesses are granted or denied.  
  
 *hProcess*  
 Handle to the process whose access token is opened. If the default value of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is used, the current process is used.  
  
## Return Value  
 Returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> on success, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> on failure.  
  
## Remarks  
 Calls the [OpenProcessToken](http://msdn.microsoft.com/library/aa379295\(VS.85\).aspx) Win32 function.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAccessToken Class](../vs140/caccesstoken-class.md)