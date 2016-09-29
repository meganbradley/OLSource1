---
title: "Windows Sockets: Converting Strings"
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
  - "Windows Sockets [C++], multibyte character string conversion"
  - "sockets [C++], multibyte character string conversion issues"
  - "string conversion, multibyte character strings"
ms.assetid: 9df522b5-6b23-41e0-bb96-e4e623baf141
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Windows Sockets: Converting Strings
This article and two companion articles explain several issues in Windows Sockets programming. This article covers converting strings. The other issues are covered in [Windows Sockets: Blocking](../VS_csharp/windows-sockets--blocking.md) and [Windows Sockets: Byte Ordering](../VS_csharp/windows-sockets--byte-ordering.md).  
  
 If you use or derive from class [CAsyncSocket](../VS_csharp/casyncsocket-class.md), you will need to manage these issues yourself. If you use or derive from class [CSocket](../VS_csharp/csocket-class.md), MFC manages them for you.  
  
## Converting Strings  
 If you communicate between applications that use strings stored in different wide-character formats, such as Unicode or multibyte character sets (MBCS), or between one of these and an application using ANSI character strings, you must manage the conversions yourself under `CAsyncSocket`. The `CArchive` object used with a `CSocket` object manages this conversion for you through the capabilities of class [CString](../VS_csharp/cstringt-class.md). For more information, see the Windows Sockets specification, located in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
 For more information, see:  
  
-   [Windows Sockets: Using Class CAsyncSocket](../VS_csharp/windows-sockets--using-class-casyncsocket.md)  
  
-   [Windows Sockets: Using Sockets with Archives](../VS_csharp/windows-sockets--using-sockets-with-archives.md)  
  
-   [Windows Sockets: Background](../VS_csharp/windows-sockets--background.md)  
  
-   [Windows Sockets: Stream Sockets](../VS_csharp/windows-sockets--stream-sockets.md)  
  
-   [Windows Sockets: Datagram Sockets](../VS_csharp/windows-sockets--datagram-sockets.md)  
  
## See Also  
 [Windows Sockets in MFC](../VS_csharp/windows-sockets-in-mfc.md)