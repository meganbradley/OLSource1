---
title: "Translation Mode Constants"
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
  - "_O_BINARY"
  - "_O_TEXT"
  - "_O_RAW"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "O_BINARY constant"
  - "O_TEXT constant"
  - "O_RAW constant"
  - "_O_TEXT constant"
  - "_O_RAW constant"
  - "translation constants"
  - "_O_BINARY constant"
  - "translation, constants"
  - "translation, modes"
  - "translation modes (file I/O)"
ms.assetid: a5993bf4-7e7a-47f9-83c3-e46332b85579
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Translation Mode Constants
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> manifest constants determine the translation mode for files (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) or the translation mode for streams (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>).  
  
 The allowed values are:  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Opens file in text (translated) mode. Carriage return – linefeed (CR-LF) combinations are translated into a single linefeed (LF) on input. Linefeed characters are translated into CR-LF combinations on output. Also, CTRL+Z is interpreted as an end-of-file character on input. In files opened for reading and reading/writing, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> checks for CTRL+Z at the end of the file and removes it, if possible. This is done because using the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> functions to move within a file ending with CTRL+Z may cause <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to behave improperly near the end of the file.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Opens file in binary (untranslated) mode. The above translations are suppressed.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Same as <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. Supported for C 2.0 compatibility.  
  
 For more information, see [Text and Binary Mode File I/O](../vs140/text-and-binary-mode-file-i-o.md) and [File Translation](../vs140/file-translation-constants.md).  
  
## See Also  
 [_open, _wopen](../vs140/_open--_wopen.md)   
 [_pipe](../vs140/_pipe.md)   
 [_sopen, _wsopen](../vs140/_sopen--_wsopen.md)   
 [_setmode](../vs140/_setmode.md)   
 [Global Constants](../vs140/global-constants.md)