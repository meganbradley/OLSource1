---
title: "Clipboard: When to Use Each Clipboard Mechanism"
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
  - "applications [OLE], Clipboard"
  - "OLE Clipboard, guidelines"
  - "Clipboard [C++], mechanisms"
  - "OLE Clipboard, formats"
  - "formats [C++], Clipboard for OLE"
  - "Clipboard [C++], formats"
ms.assetid: fd071996-ef8c-488b-81bd-89057095a201
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Clipboard: When to Use Each Clipboard Mechanism
Follow these guidelines in using the Clipboard:  
  
-   Use the OLE Clipboard mechanism now to enable new capabilities in the future. While the standard Clipboard API will be maintained, the OLE mechanism is the future of data transfer.  
  
-   Use the OLE Clipboard mechanism if you are writing an OLE application or you want any of the OLE features, such as drag and drop.  
  
-   Use the OLE Clipboard mechanism if you are providing OLE formats.  
  
## What do you want to do?  
  
-   [Use the OLE Clipboard mechanism](../vs140/clipboard--using-the-ole-clipboard-mechanism.md)  
  
-   [Use the Windows Clipboard mechanism](../vs140/clipboard--using-the-windows-clipboard.md)  
  
## See Also  
 [Clipboard](../vs140/clipboard.md)