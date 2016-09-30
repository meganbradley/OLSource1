---
title: "CInternetSession::OnStatusCallback"
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
  - "INTERNET_STATUS_CONNECTION_CLOSED"
  - "INTERNET_STATUS_SENDING_REQUEST"
  - "INTERNET_STATUS_REQUEST_SENT"
  - "OnStatusCallback"
  - "INTERNET_STATUS_HANDLE_CLOSING"
  - "INTERNET_STATUS_REQUEST_COMPLETE"
  - "CInternetSession::OnStatusCallback"
  - "INTERNET_STATUS_RESPONSE_RECEIVED"
  - "CInternetSession.OnStatusCallback"
  - "INTERNET_STATUS_HANDLE_CREATED"
  - "INTERNET_STATUS_RESOLVING_NAME"
  - "INTERNET_STATUS_CONNECTED_TO_SERVER"
  - "INTERNET_STATUS_NAME_RESOLVED"
  - "INTERNET_STATUS_CLOSING_CONNECTION"
  - "INTERNET_STATUS_RECEIVING_RESPONSE"
  - "INTERNET_STATUS_CONNECTING_TO_SERVER"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "INTERNET_STATUS_CONNECTING_TO_SERVER"
  - "INTERNET_STATUS_NAME_RESOLVED"
  - "INTERNET_STATUS_CONNECTED_TO_SERVER"
  - "INTERNET_STATUS_CONNECTION_CLOSED"
  - "INTERNET_STATUS_RESOLVING_NAME"
  - "OnStatusCallback method"
  - "asynchronous connections"
  - "INTERNET_STATUS_CLOSING_CONNECTION"
  - "INTERNET_STATUS_REQUEST_COMPLETE"
  - "INTERNET_STATUS_RESPONSE_RECEIVED"
  - "INTERNET_STATUS_HANDLE_CLOSING"
  - "CInternetSession class, overridables"
  - "INTERNET_STATUS_ REQUEST_SENT"
  - "INTERNET_STATUS_SENDING_REQUEST"
  - "INTERNET_STATUS_RECEIVING_RESPONSE"
  - "INTERNET_STATUS_HANDLE_CREATED"
ms.assetid: cf123163-eb5c-4c9c-87ae-de8cf22eb5c3
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CInternetSession::OnStatusCallback
This member function is called by the framework to update the status when status callback is enabled and an operation is pending.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The context value supplied by the application.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A status code which indicates why the callback is being made. See **Remarks** for a table of possible values.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to a buffer containing information pertinent to this callback.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The size of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 You must first call [EnableStatusCallback](../vs140/cinternetsession--enablestatuscallback.md) to take advantage of status callback.  
  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter indicates the operation being performed and determines what the contents of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> will be. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> indicates the length of the data included in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. The following status values for <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> are defined as follows:  
  
|Value|Meaning|  
|-----------|-------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Looking up the IP address of the name contained in <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Successfully found the IP address of the name contained in <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Connecting to the socket address ([SOCKADDR](../vs140/sockaddr-structure.md)) pointed to by <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Successfully connected to the socket address (<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>) pointed to by <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Sending the information request to the server. The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> parameter is **NULL**.|  
|**INTERNET_STATUS_ REQUEST_SENT**|Successfully sent the information request to the server. The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> parameter is **NULL**.|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Waiting for the server to respond to a request. The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> parameter is **NULL**.|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|Successfully received a response from the server. The <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> parameter is **NULL**.|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|Closing the connection to the server. The <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> parameter is **NULL**.|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|Successfully closed the connection to the server. The <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> parameter is **NULL**.|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|Used by the Win32 API function [InternetConnect](http://msdn.microsoft.com/library/windows/desktop/aa384363) to indicate that it has created the new handle. This lets the application call the Win32 function [InternetCloseHandle](http://msdn.microsoft.com/library/windows/desktop/aa384350) from another thread if the connect is taking too long. See the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]for more information about these functions.|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|Successfully terminated this handle value.|  
  
 Override this member function to require some action before a status callback routine is performed.  
  
> [!NOTE]
>  Status callbacks need thread-state protection. If you are using MFC in a shared library, add the following line to the beginning of your override:  
  
 [!code[NVC_MFCHtmlHttp#8](../vs140/codesnippet/CPP/cinternetsession--onstatuscallback_1.cpp)]  
  
 For more information about asynchronous operations, see the article [Internet First Steps: WinInet](../vs140/wininet-basics.md).  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CInternetSession Class](../vs140/cinternetsession-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CInternetSession::EnableStatusCallback](../vs140/cinternetsession--enablestatuscallback.md)   
 [CInternetSession::GetContext](../vs140/cinternetsession--getcontext.md)