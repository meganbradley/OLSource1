---
title: "CHttpFile::EndRequest"
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
  - "EndRequest"
  - "CHttpFile::EndRequest"
  - "CHttpFile.EndRequest"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EndRequest method"
  - "CHttpFile class, operations"
ms.assetid: e58e4478-8416-4985-9a07-c5152ea719a8
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHttpFile::EndRequest
Call this member function to end a request sent to an HTTP server with the [SendRequestEx](../vs140/chttpfile--sendrequestex.md) member function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Flags describing the operation. For a list of the appropriate flags, see [HttpEndRequest](http://msdn.microsoft.com/library/windows/desktop/aa384230) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to an initialized [INTERNET_BUFFERS](http://msdn.microsoft.com/library/windows/desktop/aa385132) that describes the input buffer used for the operation.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The context identifier for the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> operation. See Remarks for more information about this parameter.  
  
## Return Value  
 Nonzero if successful; otherwise 0. If the call fails, determine the cause of the failure by examining the thrown [CInternetException](../vs140/cinternetexception-class.md) object.  
  
## Remarks  
 The default value for <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is sent by MFC to the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object from the [CInternetSession](../vs140/cinternetsession-class.md) object that created the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object. When you call [CInternetSession::OpenURL](../vs140/cinternetsession--openurl.md) or [CHttpConnection](../vs140/chttpconnection-class.md) to construct a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object, you can override the default to set the context identifier to a value of your choosing. The context identifier is returned to [CInternetSession::OnStatusCallback](../vs140/cinternetsession--onstatuscallback.md) to provide status on the object with which it is identified. See article [Internet First Steps: WinInet](../vs140/wininet-basics.md) for more information about the context identifier.  
  
## Exceptions  
 This method can throw exceptions of type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CHttpFile Class](../vs140/chttpfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CInternetFile Class](../vs140/cinternetfile-class.md)