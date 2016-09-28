---
title: "Input and Output"
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
  - "c.io"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "input routines"
  - "I/O [CRT]"
  - "I/O routines"
  - "I/O [CRT], routines"
  - "output routines"
ms.assetid: 1c177301-e341-4ca0-aedc-0a87fe1c75ae
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Input and Output
The I/O functions read and write data to and from files and devices. File I/O operations take place in text mode or binary mode. The Microsoft run-time library has three types of I/O functions:  
  
-   [Stream I/O](../vs140/stream-i-o.md) functions treat data as a stream of individual characters.  
  
-   [Low-level I/O](../vs140/low-level-i-o.md) functions invoke the operating system directly for lower-level operation than that provided by stream I/O.  
  
-   [Console and port I/O](../vs140/console-and-port-i-o.md) functions read or write directly to a console (keyboard and screen) or an I/O port (such as a printer port).  
  
    > [!NOTE]
    >  Because stream functions are buffered and low-level functions are not, these two types of functions are generally incompatible. For processing a particular file, use either stream or low-level functions exclusively.  
  
## See Also  
 [Run-Time Routines by Category](../vs140/run-time-routines-by-category.md)