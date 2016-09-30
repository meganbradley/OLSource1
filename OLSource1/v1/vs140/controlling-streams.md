---
title: "Controlling Streams"
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
  - "Controlling Streams"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "streams, controlling"
  - "controlling streams"
  - "streams"
ms.assetid: 267e9013-9afc-45f6-91e3-ca093230d9d9
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Controlling Streams
[fopen](../vs140/fopen--_wfopen.md) returns the address of an object of type <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>. You use this address as the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> argument to several library functions to perform various operations on an open file. For a byte stream, all input takes place as if each character is read by calling [fgetc](../vs140/fgetc--fgetwc.md), and all output takes place as if each character is written by calling [fputc](../vs140/fputc--fputwc.md). For a wide stream, all input takes place as if each character is read by calling [fgetwc](../vs140/fgetc--fgetwc.md), and all output takes place as if each character is written by calling [fputwc](../vs140/fputc--fputwc.md).  
  
 You can close a file by calling [fclose](../vs140/fclose--_fcloseall.md), after which the address of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object is invalid.  
  
 A <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object stores the state of a stream, including:  
  
-   An error indicator set nonzero by a function that encounters a read or write error.  
  
-   An end-of-file indicator set nonzero by a function that encounters the end of the file while reading.  
  
-   A file-position indicator specifies the next byte in the stream to read or write, if the file can support positioning requests.  
  
-   A [stream state](../vs140/stream-states.md) specifies whether the stream will accept reads and/or writes and whether the stream is unbound, byte oriented, or wide oriented.  
  
-   A conversion state remembers the state of any partly assembled or generated generalized multibyte character, as well as any shift state for the sequence of bytes in the file).  
  
-   A file buffer specifies the address and size of an array object that library functions can use to improve the performance of read and write operations to the stream.  
  
 Do not alter any value stored in a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object or in a file buffer that you specify for use with that object. You cannot copy a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object and portably use the address of the copy as a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> argument to a library function.  
  
## See Also  
 [Files and Streams](../vs140/files-and-streams.md)