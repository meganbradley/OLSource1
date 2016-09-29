---
title: "Role of the View in Printing"
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
  - "views, printing"
  - "OnDraw method, and printing"
  - "printing [MFC], OnDraw method"
  - "printing [MFC], views"
  - "CView class, role in printing"
  - "printing views"
ms.assetid: 8d4a3c8e-1fce-4edc-b608-94cb5f3e487e
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Role of the View in Printing
Your view also plays two important roles in printing its associated document.  
  
 The view:  
  
-   Uses the same [OnDraw](../vs140/cview--ondraw.md) code to draw on the printer as to draw on the screen.  
  
-   Manages dividing the document into pages for printing.  
  
 For more information about printing and about the view's role in printing, see [Printing and Print Preview](../vs140/printing-and-print-preview.md).  
  
## See Also  
 [Using Views](../vs140/using-views.md)