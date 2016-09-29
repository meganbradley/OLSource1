---
title: "Windows Sockets: Example of Sockets Using Archives"
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
  - "sockets [C++], with archives"
  - "examples [MFC], Windows Sockets"
  - "Windows Sockets [C++], with archives"
ms.assetid: 2e3c9bb2-7e7b-4f28-8dc5-6cb7a484edac
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Windows Sockets: Example of Sockets Using Archives
This article presents an example of using class [CSocket](../vs140/csocket-class.md). The example employs `CArchive` objects to serialize data through a socket. Note that this is not document serialization to or from a file.  
  
 The following example illustrates how you use the archive to send and receive data through `CSocket` objects. The example is designed so that two instances of the application (on the same machine or on different machines on the network) exchange data. One instance sends data, which the other instance receives and acknowledges. Either application can initiate an exchange, and either can act as server or as client to the other application. The following function is defined in the application's view class:  
  
 [!code[NVC_MFCSimpleSocket#1](../vs140/codesnippet/CPP/windows-sockets--example-of-sockets-using-archives_1.cpp)]  
  
 The most important thing about this example is that its structure parallels that of an MFC `Serialize` function. The **PacketSerialize** member function consists of an **if** statement with an **else** clause. The function receives two [CArchive](../vs140/carchive-class.md) references as parameters: `arData` and `arAck`. If the `arData` archive object is set for storing (sending), the **if** branch executes; otherwise, if `arData` is set for loading (receiving) the function takes the **else** branch. For more information about serialization in MFC, see [Serialization](../vs140/how-to--make-a-type-safe-collection.md).  
  
> [!NOTE]
>  The `arAck` archive object is assumed to be the opposite of `arData`. If `arData` is for sending, `arAck` receives, and the converse is true.  
  
 For sending, the example function loops for a specified number of times, each time generating some random data for demonstration purposes. Your application would obtain real data from some source, such as a file. The `arData` archive's insertion operator (**<<**) is used to send a stream of three consecutive chunks of data:  
  
-   A "header" that specifies the nature of the data (in this case, the value of the `bValue` variable and how many copies will be sent).  
  
     Both items are generated randomly for this example.  
  
-   The specified number of copies of the data.  
  
     The inner **for** loop sends `bValue` the specified number of times.  
  
-   A string called `strText` that the receiver displays to its user.  
  
 For receiving, the function operates similarly, except that it uses the archive's extraction operator (**>>**) to get data from the archive. The receiving application verifies the data it receives, displays the final "Received" message, and then sends back a message that says "Sent" for the sending application to display.  
  
 In this communications model, the word "Received", the message sent in the `strText` variable, is for display at the other end of the communication, so it specifies to the receiving user that a certain number of packets of data have been received. The receiver replies with a similar string that says "Sent", for display on the original sender's screen. Receipt of both strings indicates that successful communication has occurred.  
  
> [!CAUTION]
>  If you are writing an MFC client program to communicate with established (non-MFC) servers, do not send C++ objects through the archive. Unless the server is an MFC application that understands the kinds of objects you want to send, it won't be able to receive and deserialize your objects. An example in the article [Windows Sockets: Byte Ordering](../vs140/windows-sockets--byte-ordering.md) shows a communication of this type.  
  
 For more information, see Windows Sockets Specification: **htonl**, **htons**, **ntohl**, **ntohs**. Also, for more information, see:  
  
-   [Windows Sockets: Deriving from Socket Classes](../vs140/windows-sockets--deriving-from-socket-classes.md)  
  
-   [Windows Sockets: How Sockets with Archives Work](../vs140/windows-sockets--how-sockets-with-archives-work.md)  
  
-   [Windows Sockets: Background](../vs140/windows-sockets--background.md)  
  
## See Also  
 [Windows Sockets in MFC](../vs140/windows-sockets-in-mfc.md)   
 [CArchive::IsStoring](../vs140/carchive--isstoring.md)   
 [CArchive::operator <<](../vs140/carchive--operator---.md)   
 [CArchive::operator >>](../vs140/carchive--operator---.md)   
 [CArchive::Flush](../vs140/carchive--flush.md)   
 [CObject::Serialize](../vs140/cobject--serialize.md)