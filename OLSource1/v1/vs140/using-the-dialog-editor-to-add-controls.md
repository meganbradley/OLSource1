---
title: "Using the Dialog Editor to Add Controls"
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
  - "Windows common controls [C++], adding"
  - "dialog box controls [C++], adding to dialog boxes"
  - "controls [MFC], adding to dialog boxes"
  - "Dialog editor, creating controls"
  - "common controls [C++], adding"
ms.assetid: d3f9f994-7e54-4656-a545-42c204557c36
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using the Dialog Editor to Add Controls
When you create your dialog-template resource with the [dialog editor](../vs140/dialog-editor.md), you drag controls from a controls palette and drop them into the dialog box. This adds the specifications for that control type to the dialog-template resource. When you construct a dialog object and call its **Create** or `DoModal` member function, the framework creates a Windows control and places it in the dialog window on screen.  
  
 You can instead [create controls by hand](../vs140/adding-controls-by-hand.md) if you want. This is more work.  
  
## See Also  
 [Making and Using Controls](../vs140/making-and-using-controls.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)