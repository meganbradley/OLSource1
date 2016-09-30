---
title: "CSocketAddr Class"
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
  - "CSocketAddr"
  - "ATL.CSocketAddr"
  - "ATL::CSocketAddr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSocketAddr class"
ms.assetid: 2fb2d8a7-899e-4a36-a342-cc9f4fcdd68c
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSocketAddr Class
This class provides methods for converting host names to host addresses, supporting both IPv4 and IPV6 formats.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CSocketAddr::CSocketAddr](../vs140/csocketaddr--csocketaddr.md)|The constructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CSocketAddr::FindAddr](../vs140/csocketaddr--findaddr.md)|Call this method to convert the provided host name to the host address.|  
|[CSocketAddr::FindINET4Addr](../vs140/csocketaddr--findinet4addr.md)|Call this method to convert the IPv4 host name to the host address.|  
|[CSocketAddr::FindINET6Addr](../vs140/csocketaddr--findinet6addr.md)|Call this method to convert the IPv6 host name to the host address.|  
|[CSocketAddr::GetAddrInfo](../vs140/csocketaddr--getaddrinfo.md)|Call this method to return a pointer to a specific element in the **addrinfo** list.|  
|[CSocketAddr::GetAddrInfoList](../vs140/csocketaddr--getaddrinfolist.md)|Call this method to return a pointer to the **addrinfo** list.|  
  
## Remarks  
 This class provides an IP version agnostic approach for looking up network addresses for use with Windows sockets API functions and socket wrappers in libraries.  
  
 The members of this class that are used to look up network addresses use the Win32 API function [getaddrinfo](http://msdn.microsoft.com/library/windows/desktop/ms738520).  
  
 This class supports both IPv4 andIPv6 network addresses.  
  
## Requirements  
 **Header:** atlsocket.h  
  
##  \<a name="csocketaddr__csocketaddr">\</a>  CSocketAddr::CSocketAddr  
 The constructor.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 Creates a new <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object and initializes the linked list containing response information about the host.  
  
##  \<a name="csocketaddr__findaddr">\</a>  CSocketAddr::FindAddr  
 Call this method to convert the provided host name to the host address.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The host name or dotted IP address.  
  
 *szPortOrServiceName*  
 The port number or name of service on host.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The port number.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 0 or combination of AI_PASSIVE, AI_CANONNAME or AI_NUMERICHOST.  
  
 *addr_family*  
 Address family (such as PF_INET).  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Socket type (such as SOCK_STREAM).  
  
 *ai_proto*  
 Protocol (such as IPPROTO_IP or IPPROTO_IPV6).  
  
### Return Value  
 Returns zero if the address is calculated successfully. Returns a nonzero Windows Socket error code on failure. If successful, the calculated address is stored in a linked list that may be referenced using <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
### Remarks  
 The host name parameter may be in either IPv4 or IPv6 format. This method calls the Win32 API function [getaddrinfo](http://msdn.microsoft.com/library/windows/desktop/ms738520) to perform the conversion.  
  
##  \<a name="csocketaddr__findinet4addr">\</a>  CSocketAddr::FindINET4Addr  
 Call this method to convert the IPv4 host name to the host address.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The host name or dotted IP address.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The port number.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 0 or combination of AI_PASSIVE, AI_CANONNAME or AI_NUMERICHOST.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Socket type (such as SOCK_STREAM).  
  
### Return Value  
 Returns zero if the address is calculated successfully. Returns a nonzero Windows Socket error code on failure. If successful, the calculated address is stored in a linked list that may be referenced using <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method calls the Win32 API function [getaddrinfo](http://msdn.microsoft.com/library/windows/desktop/ms738520) to perform the conversion.  
  
##  \<a name="csocketaddr__findinet6addr">\</a>  CSocketAddr::FindINET6Addr  
 Call this method to convert the IPv6 host name to the host address.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The host name or dotted IP address.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 The port number.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 0 or combination of AI_PASSIVE, AI_CANONNAME or AI_NUMERICHOST.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Socket type (such as SOCK_STREAM).  
  
### Return Value  
 Returns zero if the address is calculated successfully. Returns a nonzero Windows Socket error code on failure. If successful, the calculated address is stored in a linked list that may be referenced using <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method calls the Win32 API function [getaddrinfo](http://msdn.microsoft.com/library/windows/desktop/ms738520) to perform the conversion.  
  
##  \<a name="csocketaddr__getaddrinfo">\</a>  CSocketAddr::GetAddrInfo  
 Call this method to return a pointer to a specific element in the **addrinfo** list.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 A reference to a specific element in the [addrinfo](http://msdn.microsoft.com/library/windows/desktop/ms737530) list.  
  
### Return Value  
 Returns a pointer to the **addrinfo** structure referenced by <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> in the linked list containing response information about the host.  
  
##  \<a name="csocketaddr__getaddrinfolist">\</a>  CSocketAddr::GetAddrInfoList  
 Call this method to return a pointer to the **addrinfo** list.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to a linked list of one or more <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> structures containing response information about the host. For more information about the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> structure, see the "addrinfo" article in the [MSDN Library](http://go.microsoft.com/fwlink/?linkid=556)  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)