---
title: "Settings for the Progress Control"
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
  - "CProgressCtrl class, settings"
  - "progress controls [C++], settings"
ms.assetid: f4616e91-74fa-4000-ba0d-d3ddc0ee075b
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Settings for the Progress Control
The basic settings for the progress control ([CProgressCtrl](../vs140/cprogressctrl-class.md)) are the range and current position. The range represents the entire duration of the operation. The current position represents the progress that your application has made toward completing the operation. Any changes to the range or position cause the progress control to redraw itself.  
  
 By default, the range is set to 0 – 100, and the initial position is set to 0. To retrieve the current range settings for the progress control, use the [GetRange](../vs140/cprogressctrl--getrange.md) member function. To change the range, use the [SetRange](../vs140/cprogressctrl--setrange.md) member function.  
  
 To set the position, use [SetPos](../vs140/cprogressctrl--setpos.md). To retrieve the current position without specifying a new value, use [GetPos](../vs140/cprogressctrl--getpos.md). For example, you might want to simply query on the status of the current operation.  
  
 To step the current position of the progress control, use [StepIt](../vs140/cprogressctrl--stepit.md). To set the amount of each step, use [SetStep](../vs140/cprogressctrl--setstep.md)  
  
## See Also  
 [Using CProgressCtrl](../vs140/using-cprogressctrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)