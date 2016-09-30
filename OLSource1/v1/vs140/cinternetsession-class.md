---
title: "CInternetSession Class"
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
  - "CInternetSession"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CInternetSession class"
  - "Internet sessions"
ms.assetid: ef54feb4-9d0f-4e65-a45d-7a4cf6c40e51
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CInternetSession Class
Creates and initializes a single or several simultaneous Internet sessions and, if necessary, describes your connection to a proxy server.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CInternetSession::CInternetSession](#cinternetsession__cinternetsession)|Constructs a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CInternetSession::Close](#cinternetsession__close)|Closes the Internet connection when the Internet session is terminated.|  
|[CInternetSession::EnableStatusCallback](#cinternetsession__enablestatuscallback)|Establishes a status callback routine.|  
|[CInternetSession::GetContext](#cinternetsession__getcontext)|Closes the Internet connection when the Internet session is terminated.|  
|[CInternetSession::GetCookie](#cinternetsession__getcookie)|Returns cookies for the specified URL and all its parent URLs.|  
|[CInternetSession::GetCookieLength](#cinternetsession__getcookielength)|Retrieves the variable specifying the length of the cookie stored in the buffer.|  
|[CInternetSession::GetFtpConnection](#cinternetsession__getftpconnection)|Opens an FTP session with a server. Logs on the user.|  
|[CInternetSession::GetGopherConnection](#cinternetsession__getgopherconnection)|Opens a gopher server for an application that is trying to open a connection.|  
|[CInternetSession::GetHttpConnection](#cinternetsession__gethttpconnection)|Opens an HTTP server for an application that is trying to open a connection.|  
|[CInternetSession::OnStatusCallback](#cinternetsession__onstatuscallback)|Updates the status of an operation when status callback is enabled.|  
|[CInternetSession::OpenURL](#cinternetsession__openurl)|Parses and opens a URL.|  
|[CInternetSession::SetCookie](#cinternetsession__setcookie)|Sets a cookie for the specified URL.|  
|[CInternetSession::SetOption](#cinternetsession__setoption)|Sets options for the Internet session.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CInternetSession::operator HINTERNET](#cinternetsession__operator_hinternet)|A handle to the current Internet session.|  
  
## Remarks  
 If your Internet connection must be maintained for the duration of an application, you can create a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> member of the class [CWinApp](../vs140/cwinapp-class.md).  
  
 Once you have established an Internet session, you can call [OpenURL](#cinternetsession__openurl). <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> then parses the URL for you by calling the global function [AfxParseURL](../vs140/afxparseurl.md). Regardless of its protocol type, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> interprets the URL and manages it for you. It can handle requests for local files identified with the URL resource "file://". <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> will return a pointer to a [CStdioFile](../vs140/cstdiofile-class.md) object if the name you pass it is a local file.  
  
 If you open a URL on an Internet server using <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, you can read information from the site. If you want to perform service-specific (for example, HTTP, FTP, or gopher) actions on files located on a server, you must establish the appropriate connection with that server. To open a particular kind of connection directly to a particular service, use one of the following member functions:  
  
-   [GetGopherConnection](#cinternetsession__getgopherconnection) to open a connection to a gopher service.  
  
-   [GetHttpConnection](#cinternetsession__gethttpconnection) to open a connection to an HTTP service.  
  
-   [GetFtpConnection](#cinternetsession__getftpconnection) to open a connection to an FTP service.  
  
 [SetOption](#cinternetsession__setoption) allows you to set the query options of your session, such as time-out values, number of retries, and so on.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> member functions [SetCookie](#cinternetsession__setcookie), [GetCookie](#cinternetsession__getcookie), and [GetCookieLength](#cinternetsession__getcookielength) provide the means to manage a Win32 cookie database, through which servers and scripts maintain state information about the client workstation.  
  
 For more information about basic Internet programming tasks, see the article [Internet First Steps: WinInet](../vs140/wininet-basics.md). For general information about using the MFC WinInet classes, see the article [Internet Programming with WinInet](../vs140/win32-internet-extensions--wininet-.md).  
  
> [!NOTE]
>  <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> will throw an [AfxThrowNotSupportedException](../vs140/afxthrownotsupportedexception.md) for unsupported service types. Only the following service types are currently supported: FTP, HTTP, gopher, and file.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxinet.h  
  
##  \<a name="cinternetsession__cinternetsession">\</a>  CInternetSession::CInternetSession  
 This member function is called when a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object is created.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 A pointer to a string that identifies the name of the application or entity calling the Internet functions (for example, "Microsoft Internet Browser"). If <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is **NULL** (the default), the framework calls the global function [AfxGetAppName](../vs140/afxgetappname.md), which returns a null-terminated string containing an application's name. Some protocols use this string to identify your application to the server.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 The context identifier for the operation. <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> identifies the operation's status information returned by [CInternetSession::OnStatusCallback](#cinternetsession__onstatuscallback). The default is set to 1; however, you can explicitly assign a specific context ID for the operation. The object and any work it does will be associated with that context ID.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The type of access required. The following are valid values, exactly one of which may be supplied:  
  
-   **INTERNET_OPEN_TYPE_PRECONFIG** Connect using preconfigured settings in the registry. This access type is set as the default. To connect through a TIS proxy, set <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> to this value; you then set the registry appropriately.  
  
-   <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> Connect directly to Internet.  
  
-   <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> Connect through a CERN proxy.  
  
 For information on connecting with different types of proxies, see [Steps in a Typical FTP Client Application](../vs140/steps-in-a-typical-ftp-client-application.md).  
  
 *pstrProxyName*  
 The name of the preferred CERN proxy if <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is set as <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. The default is **NULL**.  
  
 *pstrProxyBypass*  
 A pointer to a string containing an optional list of server addresses. These addresses may be bypassed when using proxy access. If a **NULL** value is supplied, the bypass list will be read from the registry. This parameter is meaningful only if <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 Indicates various caching options. The default is set to 0. The possible values include:  
  
-   <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> Do not cache the data, either locally or in any gateway servers.  
  
-   <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> Download operations are satisfied through the persistent cache only. If the item does not exist in the cache, an appropriate error code is returned. This flag may be combined with the bitwise <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> ( **&#124;**) operator.  
  
### Remarks  
 **CInternetSession** is the first Internet function called by an application. It initializes internal data structures and prepares for future calls from the application.  
  
 If no Internet connection can be opened, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> throws an [AfxThrowInternetException](../vs140/afxthrowinternetexception.md).  
  
### Example  
  See the example for [CFtpFileFind](../vs140/cftpfilefind-class.md).  
  
##  \<a name="cinternetsession__close">\</a>  CInternetSession::Close  
 Call this member function when your application has finished using the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Example  
  See the example for [CFtpFileFind](../vs140/cftpfilefind-class.md).  
  
##  \<a name="cinternetsession__enablestatuscallback">\</a>  CInternetSession::EnableStatusCallback  
 Call this member function to enable status callback.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 Specifies whether callback is enabled or disabled. The default is **TRUE**.  
  
### Return Value  
 Nonzero if successful; otherwise 0. If the call fails, determine the cause of the failure by examining the thrown [CInternetException](../vs140/cinternetexception-class.md) object.  
  
### Remarks  
 When handling status callback, you can provide status about the progress of the operation (such as resolving name, connecting to server, and so on) in the status bar of the application. Displaying operation status is especially desirable during a long-term operation.  
  
 Because callbacks occur during the request's processing, the application should spend as little time as possible in the callback to prevent degradation of data throughput to the network. For example, putting up a dialog box in a callback may be such a lengthy operation that the server terminates the request.  
  
 The status callback cannot be removed as long as any callbacks are pending.  
  
 To handle any operations asynchronously, you must either create your own thread or use the WinInet functions without MFC.  
  
##  \<a name="cinternetsession__getcontext">\</a>  CInternetSession::GetContext  
 Call this member function to get the context value for a particular application session.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The application-defined context Identifier.  
  
### Remarks  
 [OnStatusCallback](#cinternetsession__onstatuscallback) uses the context ID returned by **GetContext** to report the status of a particular application. For example, when a user activates an Internet request that involves returning status information, the status callback uses the context ID to report status on that particular request. If the user activates two separate Internet requests that both involve returning status information, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> uses the context identifiers to return status about their corresponding requests. Consequently, the context identifier is used for all status callback operations, and it is associated with the session until the session is ended.  
  
 For more information about asynchronous operations, see the article [Internet First Steps: WinInet](../vs140/wininet-basics.md).  
  
##  \<a name="cinternetsession__getcookie">\</a>  CInternetSession::GetCookie  
 This member function implements the behavior of the Win32 function                 [InternetGetCookie](http://msdn.microsoft.com/library/windows/desktop/aa384710), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 A pointer to a string containing the URL.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 A pointer to a string containing the name of the cookie to get for the specified URL.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 In the first overload, a pointer to a string containing the address of the buffer that receives the cookie data. This value can be **NULL**. In the second overload, a reference to a [CString](../vs140/cstringt-class.md) object to receive the cookie data.  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 The variable specifying the size of the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> buffer. If the function succeeds, the buffer receives the amount of data copied to the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> buffer. If <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> is **NULL**, this parameter receives a value that specifies the size of the buffer necessary to copy all the cookie data.  
  
### Return Value  
 Returns **TRUE** if successful, or **FALSE** otherwise. If the call fails, call the Win32 function                         [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) to determine the cause of the error. The following error values apply:  
  
-   **ERROR_NO_MORE_ITEMS** There is no cookie for the specified URL and all its parents.  
  
-   **ERROR_INSUFFICIENT_BUFFER** The value passed in <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> is insufficient to copy all the cookie data. The value returned in <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> is the size of the buffer necessary to get all the data.  
  
### Remarks  
 In the second overload, MFC retrieves the cookie data into the supplied <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object.  
  
##  \<a name="cinternetsession__getcookielength">\</a>  CInternetSession::GetCookieLength  
 Call this member function to get the length of the cookie stored in the buffer.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 A pointer to a string containing the URL  
  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 A pointer to a string containing the name of the cookie.  
  
### Return Value  
 A <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> value indicating the length of the cookie, stored in the buffer. Zero if no cookie with the name indicated by <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> exists.  
  
### Remarks  
 This value is used by [GetCookie](#cinternetsession__getcookie).  
  
##  \<a name="cinternetsession__getftpconnection">\</a>  CInternetSession::GetFtpConnection  
 Call this member function to establish an FTP connection and get a pointer to a <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 A pointer to a string containing the FTP server name.  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string that specifies the name of the user to log in. If **NULL**, the default is anonymous.  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 A pointer to a null-terminated string that specifies the password to use to log in. If both <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> are **NULL**, the default anonymous password is the user's email name. If <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> is **NULL** (or an empty string) but <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> is not **NULL**, a blank password is used. The following table describes the behavior for the four possible settings of <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>:  
  
|<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>|Username sent to FTP server|Password sent to FTP server|  
|--------------------|--------------------|---------------------------------|---------------------------------|  
|**NULL** or " "|**NULL** or " "|"anonymous"|User's email name|  
|Non- **NULL** String|**NULL** or " "|<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>|" "|  
|**NULL** Non- **NULL** String|**ERROR**|**ERROR**||  
|Non- **NULL** String|Non- **NULL** String|<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>|  
  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 A number that identifies the TCP/IP port to use on the server.  
  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 Specifies passive or active mode for this FTP session. If set to **TRUE**, it sets the Win32 API <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> to **INTERNET_FLAG_PASSIVE**.  
  
### Return Value  
 A pointer to a [CFtpConnection](../vs140/cftpconnection-class.md) object. If the call fails, determine the cause of the failure by examining the thrown [CInternetException](../vs140/cinternetexception-class.md) object.  
  
### Remarks  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> connects to an FTP server, and creates and returns a pointer to a **CFTPConnection** object. It does not perform any specific operation on the server. If you intend to read or write to files, for example, you must perform those operations as separate steps. See the classes [CFtpConnection](../vs140/cftpconnection-class.md) and [CFtpFileFind](../vs140/cftpfilefind-class.md) for information about searching for files, opening files, and reading or writing to files. See the article [Internet Programming with WinInet](../vs140/win32-internet-extensions--wininet-.md) for steps in performing common FTP connection tasks.  
  
### Example  
  See the example for [CFtpFileFind](../vs140/cftpfilefind-class.md).  
  
##  \<a name="cinternetsession__getgopherconnection">\</a>  CInternetSession::GetGopherConnection  
 Call this member function to establish a new gopher connection and get a pointer to a <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 A pointer to a string containing the gopher server name.  
  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 A pointer to a string containing the user name.  
  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 A pointer to a string containing the access password.  
  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 A number that identifies the TCP/IP port to use on the server.  
  
### Return Value  
 A pointer to a [CGopherConnection](../vs140/cgopherconnection-class.md) object. If the call fails, determine the cause of the failure by examining the thrown [CInternetException](../vs140/cinternetexception-class.md) object.  
  
### Remarks  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> connects to a gopher server, and creates and returns a pointer to a <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> object. It does not perform any specific operation on the server. If you intend to read or write data, for example, you must perform those operations as separate steps. See the classes [CGopherConnection](../vs140/cgopherconnection-class.md), [CGopherFile](../vs140/cgopherfile-class.md), and [CGopherFileFind](../vs140/cgopherfilefind-class.md) for information about searching for files, opening files, and reading or writing to files. For information about browsing an FTP site, see the member function [OpenURL](#cinternetsession__openurl). See the article [Internet Programming with WinInet](../vs140/win32-internet-extensions--wininet-.md) for steps in performing common gopher connection tasks.  
  
##  \<a name="cinternetsession__gethttpconnection">\</a>  CInternetSession::GetHttpConnection  
 Call this member function to establish an HTTP connection and get a pointer to a <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 A pointer to a string containing the HTTP server name.  
  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 A number that identifies the TCP/IP port to use on the server.  
  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 A pointer to a string containing the user name.  
  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 A pointer to a string containing the access password.  
  
 *dwflags*  
 Any combination of the **INTERNET_ FLAG_\*** flags. See the table in the **Remarks** section of [CHttpConnection::OpenRequest](../vs140/chttpconnection-class.md#chttpconnection__openrequest) for a description of <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> values.  
  
### Return Value  
 A pointer to a [CHttpConnection](../vs140/chttpconnection-class.md) object. If the call fails, determine the cause of the failure by examining the thrown [CInternetException](../vs140/cinternetexception-class.md) object.  
  
### Remarks  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> connects to an HTTP server, and creates and returns a pointer to a <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> object. It does not perform any specific operation on the server. If you intend to query an HTTP header, for example, you must perform this operation as a separate step. See the classes [CHttpConnection](../vs140/chttpconnection-class.md) and [CHttpFile](../vs140/chttpfile-class.md) for information about operations you can perform by using a connection to an HTTP server. For information about browsing an HTTP site, see the member function [OpenURL](#cinternetsession__openurl). See the article [Internet Programming with WinInet](../vs140/win32-internet-extensions--wininet-.md) for steps in performing common HTTP connection tasks.  
  
##  \<a name="cinternetsession__onstatuscallback">\</a>  CInternetSession::OnStatusCallback  
 This member function is called by the framework to update the status when status callback is enabled and an operation is pending.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 The context value supplied by the application.  
  
 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 A status code which indicates why the callback is being made. See **Remarks** for a table of possible values.  
  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 A pointer to a buffer containing information pertinent to this callback.  
  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 The size of <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>.  
  
### Remarks  
 You must first call [EnableStatusCallback](#cinternetsession__enablestatuscallback) to take advantage of status callback.  
  
 The <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> parameter indicates the operation being performed and determines what the contents of <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> will be. <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> indicates the length of the data included in <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>. The following status values for <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> are defined as follows:  
  
|Value|Meaning|  
|-----------|-------------|  
|<CodeContentPlaceHolder>103\</CodeContentPlaceHolder>|Looking up the IP address of the name contained in <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>105\</CodeContentPlaceHolder>|Successfully found the IP address of the name contained in <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>107\</CodeContentPlaceHolder>|Connecting to the socket address ( [SOCKADDR](../vs140/sockaddr-structure.md)) pointed to by <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>109\</CodeContentPlaceHolder>|Successfully connected to the socket address ( <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>) pointed to by <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>112\</CodeContentPlaceHolder>|Sending the information request to the server. The <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> parameter is **NULL**.|  
|**INTERNET_STATUS_ REQUEST_SENT**|Successfully sent the information request to the server. The <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> parameter is **NULL**.|  
|<CodeContentPlaceHolder>115\</CodeContentPlaceHolder>|Waiting for the server to respond to a request. The <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> parameter is **NULL**.|  
|<CodeContentPlaceHolder>117\</CodeContentPlaceHolder>|Successfully received a response from the server. The <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> parameter is **NULL**.|  
|<CodeContentPlaceHolder>119\</CodeContentPlaceHolder>|Closing the connection to the server. The <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> parameter is **NULL**.|  
|<CodeContentPlaceHolder>121\</CodeContentPlaceHolder>|Successfully closed the connection to the server. The <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> parameter is **NULL**.|  
|<CodeContentPlaceHolder>123\</CodeContentPlaceHolder>|Used by the Win32 API function                                         [InternetConnect](http://msdn.microsoft.com/library/windows/desktop/aa384363) to indicate that it has created the new handle. This lets the application call the Win32 function                                         [InternetCloseHandle](http://msdn.microsoft.com/library/windows/desktop/aa384350) from another thread if the connect is taking too long. See the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]for more information about these functions.|  
|<CodeContentPlaceHolder>124\</CodeContentPlaceHolder>|Successfully terminated this handle value.|  
  
 Override this member function to require some action before a status callback routine is performed.  
  
> [!NOTE]
>  Status callbacks need thread-state protection. If you are using MFC in a shared library, add the following line to the beginning of your override:  
  
 [!code[NVC_MFCHtmlHttp#8](../vs140/codesnippet/CPP/cinternetsession-class_1.cpp)]  
  
 For more information about asynchronous operations, see the article [Internet First Steps: WinInet](../vs140/wininet-basics.md).  
  
##  \<a name="cinternetsession__openurl">\</a>  CInternetSession::OpenURL  
 Call this member function to send the specified request to the HTTP server and allow the client to specify additional RFC822, MIME, or HTTP headers to send along with the request.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 *pstrURL*  
 A pointer to the name of the URL to begin reading. Only URLs beginning with file:, ftp:, gopher:, or http: are supported. **ASSERTS** if                                 *pszURL* is **NULL**.  
  
 <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
 An application-defined value passed with the returned handle in callback.  
  
 <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
 The flags describing how to handle this connection. See **Remarks** for more information about the valid flags. The valid flags are:  
  
-   **INTERNET_FLAG_TRANSFER_ASCII** The default. Transfer the file as ASCII text.  
  
-   **INTERNET_FLAG_TRANSFER_BINARY** Transfer the file as a binary file.  
  
-   <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> Get the data from the wire even if it is locally cached.  
  
-   <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> Do not cache the data, either locally or in any gateways.  
  
-   <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> This flag is applicable to HTTP requests only. It requests secure transactions on the wire with Secure Sockets Layer or PCT.  
  
-   **INTERNET_OPEN_FLAG_USE_EXISTING_CONNECT** If possible, reuse the existing connections to the server for new requests generated by **OpenUrl** instead of creating a new session for each connection request.  
  
-   **INTERNET_FLAG_PASSIVE** Used for an FTP site. Uses passive FTP semantics. Used with [CInternetConnection](../vs140/cinternetconnection-class.md) of <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
 A pointer to a string containing the headers to be sent to the HTTP server.  
  
 *dwHeadersLength*  
 The length, in characters, of the additional headers. If this is -1L and <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> is non- **NULL**, then <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> is assumed to be zero terminated and the length is calculated.  
  
### Return Value  
 Returns a file handle for FTP, GOPHER, HTTP, and FILE-type Internet services only. Returns **NULL** if parsing was unsuccessful.  
  
 The pointer that <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> returns depends on                         *pszURL*'s type of service. The table below illustrates the possible pointers <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> can return.  
  
|URL type|Returns|  
|--------------|-------------|  
|file://|**CStdioFile\***|  
|http://|**CHttpFile\***|  
|gopher://|**CGopherFile\***|  
|ftp://|**CInternetFile\***|  
  
### Remarks  
 The parameter <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> must include either **INTERNET_FLAG_TRANSFER_ASCII** or **INTERNET_FLAG_TRANSFER_BINARY**, but not both. The remaining flags can be combined with the bitwise <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> operator ( **&#124;**).  
  
 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>, which wraps the Win32 function **InternetOpenURL**, allows only downloading, retrieving, and reading the data from an Internet server. <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> allows no file manipulation on a remote location, so it requires no [CInternetConnection](../vs140/cinternetconnection-class.md) object.  
  
 To use connection-specific (that is, protocol-specific) functions, such as writing to a file, you must open a session, then open a particular kind of connection, then use that connection to open a file in the desired mode. See <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> for more information about connection-specific functions.  
  
##  \<a name="cinternetsession__operator_hinternet">\</a>  CInternetSession::operator HINTERNET  
 Use this operator to get the Windows handle for the current Internet session.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
##  \<a name="cinternetsession__setcookie">\</a>  CInternetSession::SetCookie  
 Sets a cookie for the specified URL.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
 A pointer to a null-terminated string that specifies the URL for which the cookie should be set.  
  
 <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
 A pointer to a string containing the name of the cookie.  
  
 <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>  
 A pointer to a string containing the actual string data to associate with the URL.  
  
### Return Value  
 Returns **TRUE** if successful, or **FALSE** otherwise. To get the specific error code, call **GetLastError.**  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [InternetSetCookie](http://msdn.microsoft.com/library/windows/desktop/aa385107), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cinternetsession__setoption">\</a>  CInternetSession::SetOption  
 Call this member function to set options for the Internet session.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  
 The Internet option to set. See                                 [Option Flags](http://msdn.microsoft.com/library/windows/desktop/aa385328) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]for a list of the possible options.  
  
 <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
 A buffer that contains the option setting.  
  
 *dwBufferLength*  
 The length of <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> or the size of <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> that contains the option setting.  
  
 <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>  
 Indicates various caching options. The default is set to 0. The possible values include:  
  
-   <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> Do not cache the data, either locally or in any gateway servers.  
  
-   <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> Download operations are satisfied through the persistent cache only. If the item does not exist in the cache, an appropriate error code is returned. This flag may be combined with the bitwise <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> ( **&#124;**) operator.  
  
### Return Value  
 If the operation was successful, a value of **TRUE** is returned. If an error occurred, a value of **FALSE** is returned. If the call fails, the Win32 function                         [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) may be called to determine the cause of the error.  
  
## See Also  
 [Base Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CInternetConnection](../vs140/cinternetconnection-class.md)   
 [CHttpConnection](../vs140/chttpconnection-class.md)   
 [CFtpConnection](../vs140/cftpconnection-class.md)   
 [CGopherConnection](../vs140/cgopherconnection-class.md)