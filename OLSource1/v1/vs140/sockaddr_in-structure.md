---
title: "SOCKADDR_IN Structure"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "SOCKADDR_IN"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SOCKADDR_IN structure"
ms.assetid: e8cd7c34-78bd-4e28-a990-eb3ca070b7a6
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SOCKADDR_IN Structure
In the Internet address family, the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> structure is used by Windows Sockets to specify a local or remote endpoint address to which to connect a socket.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *sin_family*  
 Address family (must be **AF_INET**).  
  
 *sin_port*  
 IP port.  
  
 *sin_addr*  
 IP address.  
  
 *sin_zero*  
 Padding to make structure the same size as <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 This is the form of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure specific to the Internet address family and can be cast to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 The IP address component of this structure is of type **IN_ADDR**. The **IN_ADDR** structure is defined in Windows Sockets header file WINSOCK.H as follows:  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** winsock2.h  
  
## See Also  
 [Structures, Styles, Callbacks, and Message Maps](../vs140/structures--styles--callbacks--and-message-maps.md)   
 [SOCKADDR Structure](../vs140/sockaddr-structure.md)