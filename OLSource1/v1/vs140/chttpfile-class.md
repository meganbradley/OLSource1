---
title: "CHttpFile Class"
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
  - "CHttpFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HTTP files"
  - "HTTP requests, requesting and reading files"
  - "CHttpFile class"
ms.assetid: 399e7c68-bbce-4374-8c55-206e9c7baac6
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHttpFile Class
Provides the functionality to request and read files on an HTTP server.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Protected Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CHttpFile::CHttpFile](#chttpfile__chttpfile)|Creates a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CHttpFile::AddRequestHeaders](#chttpfile__addrequestheaders)|Adds headers to the request sent to an HTTP server.|  
|[CHttpFile::EndRequest](#chttpfile__endrequest)|Ends a request sent to an HTTP server with the [SendRequestEx](#chttpfile__sendrequestex) member function.|  
|[CHttpFile::GetFileURL](#chttpfile__getfileurl)|Gets the URL for the specified file.|  
|[CHttpFile::GetObject](#chttpfile__getobject)|Gets the target object of the verb in a request to an HTTP server.|  
|[CHttpFile::GetVerb](#chttpfile__getverb)|Gets the verb that was used in a request to an HTTP server.|  
|[CHttpFile::QueryInfo](#chttpfile__queryinfo)|Returns the response or request headers from the HTTP server.|  
|[CHttpFile::QueryInfoStatusCode](#chttpfile__queryinfostatuscode)|Retrieves the status code associated with an HTTP request and places it in the supplied <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter.|  
|[CHttpFile::SendRequest](#chttpfile__sendrequest)|Sends a request to an HTTP server.|  
|[CHttpFile::SendRequestEx](#chttpfile__sendrequestex)|Sends a request to an HTTP server using the [Write](../vs140/cinternetfile-class.md#cinternetfile__write) or [WriteString](../vs140/cinternetfile-class.md#cinternetfile__writestring) methods of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.|  
  
## Remarks  
 If your Internet session reads data from an HTTP server, you must create an instance of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 To learn more about how <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> works with the other MFC Internet classes, see the article [Internet Programming with WinInet](../vs140/win32-internet-extensions--wininet-.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CFile](../vs140/cfile-class.md)  
  
 [CStdioFile](../vs140/cstdiofile-class.md)  
  
 [CInternetFile](../vs140/cinternetfile-class.md)  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxinet.h  
  
##  \<a name="chttpfile__addrequestheaders">\</a>  CHttpFile::AddRequestHeaders  
 Call this member function to add one or more HTTP request headers to the HTTP request handle.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 A pointer to a string containing the header or headers to append to the request. Each header must be terminated by a CR/LF pair.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 Modifies the semantics of the new headers. Can be one of the following:  
  
-   <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> Merges headers of the same name, using the flag to add the first header found to the subsequent header. For example, "Accept: text/*" followed by "Accept: audio/\*" results in the formation of the single header "Accept: text/\*, audio/\*". It is up to the calling application to ensure a cohesive scheme with respect to data received by requests sent with coalesced or separate headers.  
  
-   <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> Performs a remove and add to replace the current header. The header name will be used to remove the current header, and the full value will be used to add the new header. If the header-value is empty and the header is found, it is removed. If not empty, the header-value is replaced.  
  
-   <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> Only adds the header if it does not already exist. If one exists, an error is returned.  
  
-   <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> Used with REPLACE. Adds the header if it doesn't exist.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 The length, in characters, of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. If this is -1L, then <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is assumed to be zero-terminated and the length is computed.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 A reference to a [CString](../vs140/cstringt-class.md) object containing the request header or headers to be added.  
  
### Return Value  
 Nonzero if successful; otherwise 0. If the call fails, the Win32 function                         [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) may be called to determine the cause of the error.  
  
### Remarks  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> appends additional, free-format headers to the HTTP request handle. It is intended for use by sophisticated clients who need detailed control over the exact request sent to the HTTP server.  
  
> [!NOTE]
>  The application can pass multiple headers in <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> for an <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> call using <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>. If the application tries to remove or replace a header using **HTTP_ADDREQ_FLAG_REMOVE** or <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, only one header can be supplied in <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
##  \<a name="chttpfile__chttpfile">\</a>  CHttpFile::CHttpFile  
 This member function is called to construct a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 A handle to an Internet file.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 A handle to an Internet session.  
  
 *pstrObject*  
 A pointer to a string containing the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 A pointer to a string containing the name of the server.  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 A pointer to a string containing the method to be used when sending the request. Can be **POST**, **HEAD**, or <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
 dwContext  
 The context identifier for the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object. See **Remarks** for more information about this parameter.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 A pointer to a [CHttpConnection](../vs140/chttpconnection-class.md) object.  
  
### Remarks  
 You never construct a <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object directly; rather call [CInternetSession::OpenURL](../vs140/cinternetsession-class.md#cinternetsession__openurl) or [CHttpConnection::OpenRequest](../vs140/chttpconnection-class.md#chttpconnection__openrequest) instead.  
  
 The default value for <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> is sent by MFC to the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object from the [CInternetSession](../vs140/cinternetsession-class.md) object that created the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object. When you call <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> to construct a <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object, you can override the default to set the context identifier to a value of your choosing. The context identifier is returned to [CInternetSession::OnStatusCallback](../vs140/cinternetsession-class.md#cinternetsession__onstatuscallback) to provide status on the object with which it is identified. See the article [Internet First Steps: WinInet](../vs140/wininet-basics.md) for more information about the context identifier.  
  
##  \<a name="chttpfile__endrequest">\</a>  CHttpFile::EndRequest  
 Call this member function to end a request sent to an HTTP server with the [SendRequestEx](#chttpfile__sendrequestex) member function.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 Flags describing the operation. For a list of the appropriate flags, see                                 [HttpEndRequest](http://msdn.microsoft.com/library/windows/desktop/aa384230) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 Pointer to an initialized                                 [INTERNET_BUFFERS](http://msdn.microsoft.com/library/windows/desktop/aa385132) that describes the input buffer used for the operation.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 The context identifier for the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> operation. See Remarks for more information about this parameter.  
  
### Return Value  
 Nonzero if successful; otherwise 0. If the call fails, determine the cause of the failure by examining the thrown [CInternetException](../vs140/cinternetexception-class.md) object.  
  
### Remarks  
 The default value for <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> is sent by MFC to the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object from the [CInternetSession](../vs140/cinternetsession-class.md) object that created the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> object. When you call [CInternetSession::OpenURL](../vs140/cinternetsession-class.md#cinternetsession__openurl) or [CHttpConnection](../vs140/chttpconnection-class.md) to construct a <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> object, you can override the default to set the context identifier to a value of your choosing. The context identifier is returned to [CInternetSession::OnStatusCallback](../vs140/cinternetsession-class.md#cinternetsession__onstatuscallback) to provide status on the object with which it is identified. See article [Internet First Steps: WinInet](../vs140/wininet-basics.md) for more information about the context identifier.  
  
##  \<a name="chttpfile__getfileurl">\</a>  CHttpFile::GetFileURL  
 Call this member function to get the name of the HTTP file as a URL.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A [CString](../vs140/cstringt-class.md) object containing a URL referencing the resource associated with this file.  
  
### Remarks  
 Use this member function only after a successful call to [SendRequest](#chttpfile__sendrequest) or on a <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> object successfully created by [OpenURL](../vs140/cinternetsession-class.md#cinternetsession__openurl).  
  
##  \<a name="chttpfile__getobject">\</a>  CHttpFile::GetObject  
 Call this member function to get the name of the object associated with this <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 A [CString](../vs140/cstringt-class.md) object containing the name of the object.  
  
### Remarks  
 Use this member function only after a successful call to [SendRequest](#chttpfile__sendrequest) or on a <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> object successfully created by [OpenURL](../vs140/cinternetsession-class.md#cinternetsession__openurl).  
  
##  \<a name="chttpfile__getverb">\</a>  CHttpFile::GetVerb  
 Call this member function to get the HTTP verb (or method) associated with this <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A [CString](../vs140/cstringt-class.md) object containing the name of the HTTP verb (or method).  
  
### Remarks  
 Use this member function only after a successful call to [SendRequest](#chttpfile__sendrequest) or on a <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> object successfully created by [OpenURL](../vs140/cinternetsession-class.md#cinternetsession__openurl).  
  
##  \<a name="chttpfile__queryinfo">\</a>  CHttpFile::QueryInfo  
 Call this member function to return response or request headers from an HTTP request.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 A combination of the attribute to query and the following flags that specify the type of information requested:  
  
-   **HTTP_QUERY_CUSTOM** Finds the header name and returns this value in <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> on output. **HTTP_QUERY_CUSTOM** throws an assertion if the header isn't found.  
  
-   **HTTP_QUERY_FLAG_REQUEST_HEADERS** Typically, the application queries the response headers, but an application can also query request headers by using this flag.  
  
-   **HTTP_QUERY_FLAG_SYSTEMTIME** For those headers whose value is a date/time string, such as "Last-Modified-Time," this flag returns the header value as a standard Win32                                         [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure that does not require the application to parse the data. If you use this flag, you may want to use the <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> override of the function.  
  
-   **HTTP_QUERY_FLAG_NUMBER** For those headers whose value is a number, such as the status code, this flag returns the data as a 32-bit number.  
  
 See the **Remarks** section for a list of the possible values.  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 A pointer to the buffer that receives the information.  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 On entry, this points to a value containing the length of the data buffer, in number of characters or bytes. See the **Remarks** section for more detailed information about this parameter.  
  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 A pointer to a zero-based header index. Can be **NULL**. Use this flag to enumerate multiple headers with the same name. On input, <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> indicates the index of the specified header to return. On output, <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> indicates the index of the next header. If the next index cannot be found, **ERROR_HTTP_HEADER_NOT_FOUND** is returned.  
  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 A reference to the [CString](../vs140/cstringt-class.md) object receiving the returned information.  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 An index value. See <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>.  
  
 *pSysTime*  
 A pointer to a Win32                                 [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure.  
  
### Return Value  
 Nonzero if successful; otherwise 0. If the call fails, the Win32 function                         [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) may be called to determine the cause of the error.  
  
### Remarks  
 Use this member function only after a successful call to [SendRequest](#chttpfile__sendrequest) or on a <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> object successfully created by [OpenURL](../vs140/cinternetsession-class.md#cinternetsession__openurl).  
  
 You can retrieve the following types of data from <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>:  
  
-   strings (default)  
  
-   <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> (for "Data:" "Expires:" etc, headers)  
  
-   <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> (for **STATUS_CODE**, **CONTENT_LENGTH**, etc.)  
  
 When a string is written to the buffer, and the member function succeeds, <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> contains the length of the string in characters minus 1 for the terminating **NULL** character.  
  
 The possible <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> values include:  
  
-   **HTTP_QUERY_MIME_VERSION**  
  
-   **HTTP_QUERY_CONTENT_TYPE**  
  
-   **HTTP_QUERY_CONTENT_TRANSFER_ENCODING**  
  
-   **HTTP_QUERY_CONTENT_ID**  
  
-   **HTTP_QUERY_CONTENT_DESCRIPTION**  
  
-   **HTTP_QUERY_CONTENT_LENGTH**  
  
-   **HTTP_QUERY_ALLOWED_METHODS**  
  
-   **HTTP_QUERY_PUBLIC_METHODS**  
  
-   **HTTP_QUERY_DATE**  
  
-   **HTTP_QUERY_EXPIRES**  
  
-   **HTTP_QUERY_LAST_MODIFIED**  
  
-   **HTTP_QUERY_MESSAGE_ID**  
  
-   **HTTP_QUERY_URI**  
  
-   **HTTP_QUERY_DERIVED_FROM**  
  
-   **HTTP_QUERY_LANGUAGE**  
  
-   **HTTP_QUERY_COST**  
  
-   **HTTP_QUERY_WWW_LINK**  
  
-   **HTTP_QUERY_PRAGMA**  
  
-   **HTTP_QUERY_VERSION**  
  
-   **HTTP_QUERY_STATUS_CODE**  
  
-   **HTTP_QUERY_STATUS_TEXT**  
  
-   **HTTP_QUERY_RAW_HEADERS**  
  
-   **HTTP_QUERY_RAW_HEADERS_CRLF**  
  
##  \<a name="chttpfile__queryinfostatuscode">\</a>  CHttpFile::QueryInfoStatusCode  
 Call this member function to get the status code associated with an HTTP request and place it in the supplied <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> parameter.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 A reference to a status code. Status codes indicate the success or failure of the requested event. See **Remarks** for a selection of status code descriptions.  
  
### Return Value  
 Nonzero if successful; otherwise 0. If the call fails, the Win32 function                         [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) may be called to determine the cause of the error.  
  
### Remarks  
 Use this member function only after a successful call to [SendRequest](#chttpfile__sendrequest) or on a <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> object successfully created by [OpenURL](../vs140/cinternetsession-class.md#cinternetsession__openurl).  
  
 HTTP status codes fall into groups indicating the success or failure of the request. The following tables outline the status code groups and the most common HTTP status codes.  
  
|Group|Meaning|  
|-----------|-------------|  
|200-299|Success|  
|300-399|Information|  
|400-499|Request error|  
|500-599|Server error|  
  
 Common HTTP Status Codes:  
  
|Status code|Meaning|  
|-----------------|-------------|  
|200|URL located, transmission follows|  
|400|Unintelligible request|  
|404|Requested URL not found|  
|405|Server does not support requested method|  
|500|Unknown server error|  
|503|Server capacity reached|  
  
##  \<a name="chttpfile__sendrequest">\</a>  CHttpFile::SendRequest  
 Call this member function to send a request to an HTTP server.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 A pointer to a string containing the name of the headers to send.  
  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 The length of the headers identified by <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 Any optional data to send immediately after the request headers. This is generally used for **POST** and **PUT** operations. This can be **NULL** if there is no optional data to send.  
  
 *dwOptionalLen*  
 The length of <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 A string containing the name of the headers for the request being sent.  
  
### Return Value  
 Nonzero if successful; otherwise 0. If the call fails, determine the cause of the failure by examining the thrown [CInternetException](../vs140/cinternetexception-class.md) object.  
  
##  \<a name="chttpfile__sendrequestex">\</a>  CHttpFile::SendRequestEx  
 Call this member function to send a request to an HTTP server.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 *dwTotalLen*  
 Number of bytes to be sent in the request.  
  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 Flags describing the operation. For a list of appropriate flags, see                                 [HttpSendRequestEx](http://msdn.microsoft.com/library/windows/desktop/aa384318) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]*.*  
  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 The context identifier for the <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> operation. See Remarks for more information about this parameter.  
  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 Pointer to an initialized                                 [INTERNET_BUFFERS](http://msdn.microsoft.com/library/windows/desktop/aa385132) that describes the input buffer used for the operation.  
  
 *lpBuffOut*  
 Pointer to an initialized **INTERNET_BUFFERS** that describes the output buffer used for the operation.  
  
### Return Value  
 Nonzero if successful. If the call fails, determine the cause of the failure by examining the thrown [CInternetException](../vs140/cinternetexception-class.md) object.  
  
### Remarks  
 This function allows your application to send data using the [Write](../vs140/cinternetfile-class.md#cinternetfile__write) and [WriteString](../vs140/cinternetfile-class.md#cinternetfile__writestring) methods of <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>. You must know the length of the data to send before calling either override of this function. The first override allows you to specify the length of data you'd like to send. The second override accepts pointers to **INTERNET_BUFFERS** structures, which can be used to describe the buffer in great detail.  
  
 After content is written to the file, call [EndRequest](#chttpfile__endrequest) to end the operation.  
  
 The default value for <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> is sent by MFC to the <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> object from the [CInternetSession](../vs140/cinternetsession-class.md) object that created the <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> object. When you call [CInternetSession::OpenURL](../vs140/cinternetsession-class.md#cinternetsession__openurl) or [CHttpConnection](../vs140/chttpconnection-class.md) to construct a <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> object, you can override the default to set the context identifier to a value of your choosing. The context identifier is returned to [CInternetSession::OnStatusCallback](../vs140/cinternetsession-class.md#cinternetsession__onstatuscallback) to provide status on the object with which it is identified. See the article [Internet First Steps: WinInet](../vs140/wininet-basics.md) for more information about the context identifier.  
  
### Example  
 This code fragment sends the content of a string to a DLL named MFCISAPI.DLL on the LOCALHOST server. While this example uses only one call to <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>, using multiple calls to send data in blocks is acceptable.  
  
 [!code[NVC_MFCWinInet#9](../vs140/codesnippet/CPP/chttpfile-class_1.cpp)]  
  
## See Also  
 [Base Class](../vs140/cinternetfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CInternetFile](../vs140/cinternetfile-class.md)   
 [CGopherFile](../vs140/cgopherfile-class.md)   
 [CHttpConnection](../vs140/chttpconnection-class.md)