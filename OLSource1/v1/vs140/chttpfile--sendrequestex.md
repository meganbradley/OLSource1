---
title: "CHttpFile::SendRequestEx"
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
  - "CHttpFile.SendRequestEx"
  - "CHttpFile::SendRequestEx"
  - "SendRequestEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SendRequestEx method"
  - "CHttpFile class, operations"
  - "HTTP requests, sending"
ms.assetid: 28e3ab8e-00f5-4ef2-a21e-46890dfd1710
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHttpFile::SendRequestEx
Call this member function to send a request to an HTTP server.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *dwTotalLen*  
 Number of bytes to be sent in the request.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Flags describing the operation. For a list of appropriate flags, see [HttpSendRequestEx](http://msdn.microsoft.com/library/windows/desktop/aa384318) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]*.*  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The context identifier for the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> operation. See Remarks for more information about this parameter.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to an initialized [INTERNET_BUFFERS](http://msdn.microsoft.com/library/windows/desktop/aa385132) that describes the input buffer used for the operation.  
  
 *lpBuffOut*  
 Pointer to an initialized **INTERNET_BUFFERS** that describes the output buffer used for the operation.  
  
## Return Value  
 Nonzero if successful. If the call fails, determine the cause of the failure by examining the thrown [CInternetException](../vs140/cinternetexception-class.md) object.  
  
## Remarks  
 This function allows your application to send data using the [Write](../vs140/cinternetfile--write.md) and [WriteString](../vs140/cinternetfile--writestring.md) methods of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. You must know the length of the data to send before calling either override of this function. The first override allows you to specify the length of data you'd like to send. The second override accepts pointers to **INTERNET_BUFFERS** structures, which can be used to describe the buffer in great detail.  
  
 After content is written to the file, call [EndRequest](../vs140/chttpfile--endrequest.md) to end the operation.  
  
 The default value for <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is sent by MFC to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object from the [CInternetSession](../vs140/cinternetsession-class.md) object that created the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object. When you call [CInternetSession::OpenURL](../vs140/cinternetsession--openurl.md) or [CHttpConnection](../vs140/chttpconnection-class.md) to construct a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object, you can override the default to set the context identifier to a value of your choosing. The context identifier is returned to [CInternetSession::OnStatusCallback](../vs140/cinternetsession--onstatuscallback.md) to provide status on the object with which it is identified. See the article [Internet First Steps: WinInet](../vs140/wininet-basics.md) for more information about the context identifier.  
  
## Exceptions  
 This method can throw exceptions of type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Example  
 This code fragment sends the content of a string to a DLL named MFCISAPI.DLL on the LOCALHOST server. While this example uses only one call to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, using multiple calls to send data in blocks is acceptable.  
  
 [!code[NVC_MFCWinInet#9](../vs140/codesnippet/CPP/chttpfile--sendrequestex_1.cpp)]  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CHttpFile Class](../vs140/chttpfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CInternetFile Class](../vs140/cinternetfile-class.md)   
 [CHttpFile::SendRequest](../vs140/chttpfile--sendrequest.md)