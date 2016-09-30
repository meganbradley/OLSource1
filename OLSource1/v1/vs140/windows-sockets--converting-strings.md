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
This article and two companion articles explain several issues in Windows Sockets programming. This article covers converting strings. The other issues are covered in [Windows Sockets: Blocking](../vs140/windows-sockets--blocking.md) and [Windows Sockets: Byte Ordering](../vs140/windows-sockets--byte-ordering.md).  
  
 If you use or derive from class [CAsyncSocket](../vs140/casyncsocket-class.md), you will need to manage these issues yourself. If you use or derive from class [CSocket](../vs140/csocket-class.md), MFC manages them for you.  
  
## Converting Strings  
 If you communicate between applications that use strings stored in different wide-character formats, such as Unicode or multibyte character sets (MBCS), or between one of these and an application using ANSI character strings, you must manage the conversions yourself under <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object used with a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object manages this conversion for you through the capabilities of class [CString](../vs140/cstringt-class.md). For more information, see the Windows Sockets specification, located in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 For more information, see:  
  
-   [Windows Sockets: Using Class CAsyncSocket](../vs140/windows-sockets--using-class-casyncsocket.md)  
  
-   [Windows Sockets: Using Sockets with Archives](../vs140/windows-sockets--using-sockets-with-archives.md)  
  
-   [Windows Sockets: Background](../vs140/windows-sockets--background.md)  
  
-   [Windows Sockets: Stream Sockets](../vs140/windows-sockets--stream-sockets.md)  
  
-   [Windows Sockets: Datagram Sockets](../vs140/windows-sockets--datagram-sockets.md)  
  
## See Also  
 [Windows Sockets in MFC](../vs140/windows-sockets-in-mfc.md)