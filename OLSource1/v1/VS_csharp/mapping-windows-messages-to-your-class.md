---
title: "Mapping Windows Messages to Your Class"
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
  - "MFC dialog boxes, Windows messages"
  - "message maps [C++], in dialog class"
  - "Windows messages [C++], mapping in dialog classes"
  - "messages to dialog class"
  - "mappings, messages to dialog class"
  - "message maps [C++], mapping Windows messages to classes"
  - "messages to dialog class, mapping"
ms.assetid: a4c6fd1f-1d33-47c9-baa0-001755746d6d
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Mapping Windows Messages to Your Class
If you need your dialog box to handle Windows messages, override the appropriate handler functions. To do so, use the Properties window to [map the messages](../VS_csharp/mapping-messages-to-functions.md) to the dialog class. This writes a message-map entry for each message and adds the message-handler member functions to the class. Use the Visual C++ source code editor to write code in the message handlers.  
  
 You can also override member functions of [CDialog](../VS_csharp/cdialog-class.md) and its base classes, especially [CWnd](../VS_csharp/cwnd-class.md).  
  
## What do you want to know more about?  
  
-   [Message handling and mapping](../VS_csharp/message-handling-and-mapping.md)  
  
-   [Commonly overridden member functions](../VS_csharp/commonly-overridden-member-functions.md)  
  
-   [Commonly added member functions](../VS_csharp/commonly-added-member-functions.md)  
  
## See Also  
 [Dialog Boxes](../VS_csharp/dialog-boxes.md)   
 [Life Cycle of a Dialog Box](../VS_csharp/life-cycle-of-a-dialog-box.md)