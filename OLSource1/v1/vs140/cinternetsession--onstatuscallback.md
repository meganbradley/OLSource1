---
title: "CInternetSession::OnStatusCallback"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - INTERNET_STATUS_CONNECTION_CLOSED
  - INTERNET_STATUS_SENDING_REQUEST
  - INTERNET_STATUS_REQUEST_SENT
  - OnStatusCallback
  - INTERNET_STATUS_HANDLE_CLOSING
  - INTERNET_STATUS_REQUEST_COMPLETE
  - CInternetSession::OnStatusCallback
  - INTERNET_STATUS_RESPONSE_RECEIVED
  - CInternetSession.OnStatusCallback
  - INTERNET_STATUS_HANDLE_CREATED
  - INTERNET_STATUS_RESOLVING_NAME
  - INTERNET_STATUS_CONNECTED_TO_SERVER
  - INTERNET_STATUS_NAME_RESOLVED
  - INTERNET_STATUS_CLOSING_CONNECTION
  - INTERNET_STATUS_RECEIVING_RESPONSE
  - INTERNET_STATUS_CONNECTING_TO_SERVER
dev_langs: 
  - C++
helpviewer_keywords: 
  - INTERNET_STATUS_CONNECTING_TO_SERVER
  - INTERNET_STATUS_NAME_RESOLVED
  - INTERNET_STATUS_CONNECTED_TO_SERVER
  - INTERNET_STATUS_CONNECTION_CLOSED
  - INTERNET_STATUS_RESOLVING_NAME
  - OnStatusCallback method
  - asynchronous connections
  - INTERNET_STATUS_CLOSING_CONNECTION
  - INTERNET_STATUS_REQUEST_COMPLETE
  - INTERNET_STATUS_RESPONSE_RECEIVED
  - INTERNET_STATUS_HANDLE_CLOSING
  - CInternetSession class, overridables
  - INTERNET_STATUS_ REQUEST_SENT
  - INTERNET_STATUS_SENDING_REQUEST
  - INTERNET_STATUS_RECEIVING_RESPONSE
  - INTERNET_STATUS_HANDLE_CREATED
ms.assetid: cf123163-eb5c-4c9c-87ae-de8cf22eb5c3
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CInternetSession::OnStatusCallback
This member function is called by the framework to update the status when status callback is enabled and an operation is pending.  
  
## Syntax  
  
```  
  
      virtual void OnStatusCallback(  
   DWORD_PTR dwContext,  
   DWORD dwInternetStatus,  
   LPVOID lpvStatusInformation,  
   DWORD dwStatusInformationLength   
);  
```  
  
#### Parameters  
 `dwContext`  
 The context value supplied by the application.  
  
 `dwInternetStatus`  
 A status code which indicates why the callback is being made. See **Remarks** for a table of possible values.  
  
 `lpvStatusInformation`  
 A pointer to a buffer containing information pertinent to this callback.  
  
 `dwStatusInformationLength`  
 The size of `lpvStatusInformation`.  
  
## Remarks  
 You must first call [EnableStatusCallback](../vs140/cinternetsession--enablestatuscallback.md) to take advantage of status callback.  
  
 The `dwInternetStatus` parameter indicates the operation being performed and determines what the contents of `lpvStatusInformation` will be. `dwStatusInformationLength` indicates the length of the data included in `lpvStatusInformation`. The following status values for `dwInternetStatus` are defined as follows:  
  
|Value|Meaning|  
|-----------|-------------|  
|`INTERNET_STATUS_RESOLVING_NAME`|Looking up the IP address of the name contained in `lpvStatusInformation`.|  
|`INTERNET_STATUS_NAME_RESOLVED`|Successfully found the IP address of the name contained in `lpvStatusInformation`.|  
|`INTERNET_STATUS_CONNECTING_TO_SERVER`|Connecting to the socket address ([SOCKADDR](../vs140/sockaddr-structure.md)) pointed to by `lpvStatusInformation`.|  
|`INTERNET_STATUS_CONNECTED_TO_SERVER`|Successfully connected to the socket address (`SOCKADDR`) pointed to by `lpvStatusInformation`.|  
|`INTERNET_STATUS_SENDING_REQUEST`|Sending the information request to the server. The `lpvStatusInformation` parameter is **NULL**.|  
|**INTERNET_STATUS_ REQUEST_SENT**|Successfully sent the information request to the server. The `lpvStatusInformation` parameter is **NULL**.|  
|`INTERNET_STATUS_RECEIVING_RESPONSE`|Waiting for the server to respond to a request. The `lpvStatusInformation` parameter is **NULL**.|  
|`INTERNET_STATUS_RESPONSE_RECEIVED`|Successfully received a response from the server. The `lpvStatusInformation` parameter is **NULL**.|  
|`INTERNET_STATUS_CLOSING_CONNECTION`|Closing the connection to the server. The `lpvStatusInformation` parameter is **NULL**.|  
|`INTERNET_STATUS_CONNECTION_CLOSED`|Successfully closed the connection to the server. The `lpvStatusInformation` parameter is **NULL**.|  
|`INTERNET_STATUS_HANDLE_CREATED`|Used by the Win32 API function [InternetConnect](http://msdn.microsoft.com/library/windows/desktop/aa384363) to indicate that it has created the new handle. This lets the application call the Win32 function [InternetCloseHandle](http://msdn.microsoft.com/library/windows/desktop/aa384350) from another thread if the connect is taking too long. See the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]for more information about these functions.|  
|`INTERNET_STATUS_HANDLE_CLOSING`|Successfully terminated this handle value.|  
  
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