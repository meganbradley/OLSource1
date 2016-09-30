---
title: "SOCKADDR Structure"
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
  - "SOCKADDR"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SOCKADDR structure"
ms.assetid: df1ed66a-f4b8-43f8-8db8-8c2533d25f68
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SOCKADDR Structure
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> structure is used to store an Internet Protocol (IP) address for a machine participating in a Windows Sockets communication.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *sa_family*  
 Socket address family.  
  
 *sa_data*  
 Maximum size of all the different socket address structures.  
  
## Remarks  
 The Microsoft TCP/IP Sockets Developer's Kit only supports the Internet address domains. To actually fill in values for each part of an address, you use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> data structure, which is specifically for this address format. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> data structures are the same size. You simply cast to switch between the two structure types.  
  
## Requirements  
 **Header:** winsock2.h  
  
## See Also  
 [Structures, Styles, Callbacks, and Message Maps](../vs140/structures--styles--callbacks--and-message-maps.md)   
 [SOCKADDR_IN Structure](../vs140/sockaddr_in-structure.md)   
 [CAsyncSocket::Create](../vs140/casyncsocket--create.md)   
 [CSocket::Create](../vs140/csocket--create.md)