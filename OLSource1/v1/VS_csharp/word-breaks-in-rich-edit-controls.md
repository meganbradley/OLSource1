---
title: "Word Breaks in Rich Edit Controls"
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
  - "CRichEditCtrl class, word breaks in"
  - "word breaks"
  - "breaking words in CRichEditCtrl"
  - "rich edit controls, word breaks in"
ms.assetid: 641dcf9e-7b40-4dc0-85f7-575a8c142f73
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Word Breaks in Rich Edit Controls
A rich edit control ([CRichEditCtrl](../VS_csharp/cricheditctrl-class.md)) calls a function called a "word break procedure" to find breaks between words and to determine where it can break lines. The control uses this information when performing word-wrap operations and when processing the CTRL+LEFT and CTRL+RIGHT key combinations. An application can send messages to a rich edit control to replace the default word-break procedure, to retrieve word-break information, and to determine what line a given character falls on.  
  
## See Also  
 [Using CRichEditCtrl](../VS_csharp/using-cricheditctrl.md)   
 [Controls (MFC)](../VS_csharp/controls--mfc-.md)