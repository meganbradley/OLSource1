---
title: "Byte and Wide Streams"
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
  - "Byte and Wide Streams"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "byte streams"
  - "wide streams"
ms.assetid: 61ef0587-4cbc-4eb8-aae5-4c298dbbc6f9
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Byte and Wide Streams
A byte stream treats a file as a sequence of bytes. Within the program, the stream is the identical sequence of bytes.  
  
 By contrast, a wide stream treats a file as a sequence of generalized multibyte characters, which can have a broad range of encoding rules. (Text and binary files are still read and written as previously described.) Within the program, the stream looks like the corresponding sequence of wide characters. Conversions between the two representations occur within the Standard C Library. The conversion rules can, in principle, be altered by a call to [setlocale](../vs140/setlocale--_wsetlocale.md) that alters the category `LC_CTYPE`. Each wide stream determines its conversion rules at the time it becomes wide oriented, and retains these rules even if the category `LC_CTYPE` subsequently changes.  
  
 Positioning within a wide stream suffers the same limitations as for text steams. Moreover, the file-position indicator may well have to deal with a state-dependent encoding. Typically, it includes both a byte offset within the stream and an object of type `mbstate_t`. Thus, the only reliable way to obtain a file position within a wide stream is by calling [fgetpos](../vs140/fgetpos.md), and the only reliable way to restore a position obtained this way is by calling [fsetpos](../vs140/fsetpos.md).  
  
## See Also  
 [Files and Streams](../vs140/files-and-streams.md)   
 [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md)