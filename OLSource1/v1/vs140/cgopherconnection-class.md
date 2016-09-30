---
title: "CGopherConnection Class"
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
  - "CGopherConnection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "servers, connecting to"
  - "Internet server, gopher"
  - "connecting to servers, gopher servers"
  - "protocols, gopher"
  - "services, gopher"
  - "CGopherConnection class"
  - "gopher protocol"
  - "gopher server"
  - "connecting to servers"
  - "Internet connections, gopher"
ms.assetid: b5b96aea-ac99-430e-bd84-d1372b43f78f
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CGopherConnection Class
Manages your connection to a gopher Internet server.  
  
> [!NOTE]
>  The classes <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and their members have been deprecated because they do not work on the Windows XP platform, but they will continue to work on earlier platforms.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CGopherConnection::CGopherConnection](#cgopherconnection__cgopherconnection)|Constructs a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CGopherConnection::CreateLocator](#cgopherconnection__createlocator)|Creates a [CGopherLocator](../vs140/cgopherlocator-class.md) object to find files on a gopher server.|  
|[CGopherConnection::GetAttribute](#cgopherconnection__getattribute)|Retrieves attribute information about the gopher object.|  
|[CGopherConnection::OpenFile](#cgopherconnection__openfile)|Opens a gopher file.|  
  
## Remarks  
 The gopher service is one of three Internet services recognized by the MFC WinInet classes.  
  
 The class <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> contains a constructor and three additional member functions that manage the gopher service: [OpenFile](#cgopherconnection__openfile), [CreateLocator](#cgopherconnection__createlocator), and [GetAttribute](#cgopherconnection__getattribute).  
  
 To communicate with a gopher Internet server, you must first create an instance of [CInternetSession](../vs140/cinternetsession-class.md), and then call [CInternetSession::GetGopherConnection](../vs140/cinternetsession-class.md#cinternetsession__getgopherconnection), which creates the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object and returns a pointer to it. You never create a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object directly.  
  
 To learn more about how <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> works with the other MFC Internet classes, see the article [Internet Programming with WinInet](../vs140/win32-internet-extensions--wininet-.md). For more information about using the other two supported Internet services, FTP and HTTP see the classes [CHttpConnection](../vs140/chttpconnection-class.md) and [CFtpConnection](../vs140/cftpconnection-class.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CInternetConnection](../vs140/cinternetconnection-class.md)  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxinet.h  
  
##  \<a name="cgopherconnection__cgopherconnection">\</a>  CGopherConnection::CGopherConnection  
 This member function is called to construct a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 A pointer to the related [CInternetSession](../vs140/cinternetsession-class.md) object.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The Windows handle of the current Internet session.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 A pointer to a string containing the FTP server name.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The context identifier for the operation. <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> identifies the operation's status information returned by [CInternetSession::OnStatusCallback](../vs140/cinternetsession-class.md#cinternetsession__onstatuscallback). The default is set to 1; however, you can explicitly assign a specific context ID for the operation. The object and any work it does will be associated with that context ID.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string that specifies the name of the user to log in. If **NULL**, the default is anonymous.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 A pointer to a null-terminated string that specifies the password to use to log in. If both <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> are **NULL**, the default anonymous password is the user's email name. If <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is **NULL** (or an empty string) but <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is not **NULL**, a blank password is used. The following table describes the behavior for the four possible settings of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>:  
  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|Username sent to FTP server|Password sent to FTP server|  
|--------------------|--------------------|---------------------------------|---------------------------------|  
|**NULL** or " "|**NULL** or " "|"anonymous"|User's email name|  
|Non- **NULL** String|**NULL** or " "|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|" "|  
|**NULL** Non- **NULL** String|**ERROR**|**ERROR**||  
|Non- **NULL** String|Non- **NULL** String|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 A number that identifies the TCP/IP port to use on the server.  
  
### Remarks  
 You never create a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> directly. Rather, call [CInternetSession::GetGopherConnection](../vs140/cinternetsession-class.md#cinternetsession__getgopherconnection), which creates a <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object and returns a pointer to it.  
  
##  \<a name="cgopherconnection__createlocator">\</a>  CGopherConnection::CreateLocator  
 Call this member function to create a gopher locator to find or identify a file on a gopher server.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 A pointer to a string containing the name of the gopher document or directory to be retrieved. If the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> parameter is **NULL**, the default directory for the gopher server is returned.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 A pointer to the selector string to be sent to the gopher server in order to retrieve an item. <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> can be **NULL**.  
  
 *dwGopherType*  
 This specifies whether <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> refers to a directory or document, and whether the request is gopher or gopher+. See the attributes for the structure                                 [GOPHER_FIND_DATA](http://msdn.microsoft.com/library/windows/desktop/aa384215) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 A pointer to a string identifying the file to open. Generally, this string is returned from a call to [CGopherFileFind::GetLocator](../vs140/cgopherfilefind-class.md#cgopherfilefind__getlocator).  
  
 *pstrServerName*  
 A pointer to a string containing the gopher server name.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 The number identifying the Internet port for this connection.  
  
### Return Value  
 A [CGopherLocator](../vs140/cgopherlocator-class.md) object.  
  
### Remarks  
 The static version of the member function requires you to specify a server, while the non-static version uses the server name from the connection object.  
  
 In order to retrieve information from a gopher server, an application must first get a gopher locator. The application must then treat the locator as an opaque token (that is, the application can use the locator but not directly manipulate or compare it). Normally, the application uses the locator for calls to the [CGopherFileFind::FindFile](../vs140/cgopherfilefind-class.md#cgopherfilefind__findfile) member function to retrieve a specific piece of information.  
  
##  \<a name="cgopherconnection__getattribute">\</a>  CGopherConnection::GetAttribute  
 Call this member function to retrieve specific attribute information about an item from the gopher server.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 A reference to a [CGopherLocator](../vs140/cgopherlocator-class.md) object.  
  
 *strRequestedAttributes*  
 A space-delimited string specifying the names of the requested attributes.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 A reference to a [CString](../vs140/cstringt-class.md) that receives the locator type.  
  
### Return Value  
 Nonzero if successful; otherwise 0. If the call fails, the Win32 function                         [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) may be called to determine the cause of the error.  
  
##  \<a name="cgopherconnection__openfile">\</a>  CGopherConnection::OpenFile  
 Call this member function to open a file on a gopher server.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 A reference to a [CGopherLocator](../vs140/cgopherlocator-class.md) object.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 Any combination of INTERNET_FLAG_* flags. See [CInternetSession::OpenUrl](../vs140/cinternetsession-class.md#cinternetsession__openurl) for further information on INTERNET_FLAG_\* flags.  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 A pointer to a file-view string. If several views of the file exist at the server, this parameter specifies which file view to open. If <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> is **NULL**, the default file view is used.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The context ID for the file being opened. See **Remarks** for more information about <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
### Return Value  
 A pointer to the [CGopherFile](../vs140/cgopherfile-class.md) object to be opened.  
  
### Remarks  
 Override the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> default to set the context identifier to a value of your choosing. The context identifier is associated with this specific operation of the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> object created by its [CInternetSession](../vs140/cinternetsession-class.md) object. The value is returned to [CInternetSession::OnStatusCallback](../vs140/cinternetsession-class.md#cinternetsession__onstatuscallback) to provide status on the operation with which it is identified. See the article [Internet First Steps: WinInet](../vs140/wininet-basics.md) for more information about the context identifier.  
  
## See Also  
 [Base Class](../vs140/cinternetconnection-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFtpConnection](../vs140/cftpconnection-class.md)   
 [CHttpConnection](../vs140/chttpconnection-class.md)   
 [CInternetConnection](../vs140/cinternetconnection-class.md)   
 [CGopherLocator](../vs140/cgopherlocator-class.md)   
 [CGopherFile](../vs140/cgopherfile-class.md)   
 [CInternetSession](../vs140/cinternetsession-class.md)