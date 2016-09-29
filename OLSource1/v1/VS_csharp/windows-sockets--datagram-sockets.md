---
title: "Windows Sockets: Datagram Sockets"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sockets [C++], datagram"
  - "Windows Sockets [C++], bi-directional data flow"
  - "datagram sockets [C++]"
  - "Windows Sockets [C++], datagram"
  - "sockets [C++], bi-directional data flow"
ms.assetid: bec16a1c-74c0-4ff9-8c18-c2d87897d264
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Windows Sockets: Datagram Sockets
This article describes datagram sockets, one of the two Windows Socket types available. (The other type is the [stream socket](../VS_csharp/windows-sockets--stream-sockets.md).)  
  
 Datagram sockets support a bidirectional data flow that is not guaranteed to be sequenced or unduplicated. Datagrams also are not guaranteed to be reliable; they can fail to arrive. Datagram data may arrive out of order and possibly duplicated, but record boundaries in the data are preserved, as long as the records are smaller than the receiver's internal size limit. You are responsible for managing sequencing and reliability. (Reliability tends to be good on local-area networks [LAN] but less so on wide-area networks [WAN], such as the Internet.)  
  
 Datagrams are "connectionless", that is, no explicit connection is established; you send a datagram message to a specified socket and you can receive messages from a specified socket.  
  
 An example of a datagram socket is an application that keeps system clocks on the network synchronized. This illustrates an additional capability of datagram sockets in at least some settings: broadcasting messages to a large number of network addresses.  
  
 Datagram sockets are better than stream sockets for record-oriented data. For more information about datagram sockets, see the Windows Sockets specification, available in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
## See Also  
 [Windows Sockets in MFC](../VS_csharp/windows-sockets-in-mfc.md)   
 [Windows Sockets: Background](../VS_csharp/windows-sockets--background.md)