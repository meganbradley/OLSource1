---
title: "Clipboard"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - cutting and copying data
  - copying data
  - Clipboard
  - Clipboard, programming
  - transferring data
ms.assetid: a71b2824-1f14-4914-8816-54578d73ad4e
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Clipboard
This family of articles explains how to implement support for the Windows Clipboard in MFC applications. The Windows Clipboard is used in two ways:  
  
-   Implementing standard Edit menu commands, such as Cut, Copy, and Paste.  
  
-   Implementing uniform data transfer with drag and drop (OLE).  
  
 The Clipboard is the standard Windows method of transferring data between a source and a destination. It can also be very useful in OLE operations. With the advent of OLE, there are two Clipboard mechanisms in Windows. The standard Windows Clipboard API is still available, but it has been supplemented with the OLE data transfer mechanism. OLE uniform data transfer (UDT) supports Cut, Copy, and Paste with the Clipboard and drag and drop.  
  
 The Clipboard is a system service shared by the entire Windows session, so it does not have a handle or class of its own. You manage the Clipboard through member functions of class [CWnd](../vs140/cwnd-class.md).  
  
## What do you want to know more about?  
  
-   [When to use each Clipboard mechanism](../vs140/clipboard--when-to-use-each-clipboard-mechanism.md)  
  
-   [Using the traditional Windows Clipboard API](../vs140/clipboard--using-the-windows-clipboard.md)  
  
-   [Using the OLE Clipboard mechanism](../vs140/clipboard--using-the-ole-clipboard-mechanism.md)  
  
-   [Copying and pasting data](../vs140/clipboard--copying-and-pasting-data.md)  
  
-   [Adding other formats](../vs140/clipboard--adding-other-formats.md)  
  
-   [The Windows Clipboard](https://msdn.microsoft.com/en-us/library/ms648709)  
  
-   [Implementing drag and drop (OLE)](../vs140/drag-and-drop--ole-.md)  
  
## See Also  
 [User Interface Elements](../vs140/user-interface-elements--mfc-.md)