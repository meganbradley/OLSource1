---
title: "Manipulating the Progress Control"
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
  - "CProgressCtrl class, working with"
  - "progress controls [C++], manipulating"
  - "CProgressCtrl class, manipulating"
  - "controlling progress controls"
  - "CProgressCtrl class, using"
ms.assetid: 9af561d1-980b-4003-a6da-ff79be15bf23
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Manipulating the Progress Control
There are three ways to change the current position of a progress control ([CProgressCtrl](../vs140/cprogressctrl-class.md)).  
  
-   The position can be changed by a preset increment amount.  
  
-   The position can be changed by an arbitrary amount.  
  
-   The position can be changed to a specific value.  
  
### To change the position by a preset amount  
  
1.  Use the [SetStep](../vs140/cprogressctrl--setstep.md) member function to set the increment amount. By default, this value is 10. This value is typically set as one of the initial settings for the control. The step value can be negative.  
  
2.  Use the [StepIt](../vs140/cprogressctrl--stepit.md) member function to increment the position. This causes the control to redraw itself.  
  
    > [!NOTE]
    >  `StepIt` will cause the position to wrap. For example, given a range of 1 –100, a step of 20, and a position of 90, `StepIt` will set the position to 10.  
  
### To change the position by an arbitrary amount  
  
1.  Use the [OffsetPos](../vs140/cprogressctrl--offsetpos.md) member function to change the position. `OffsetPos` will accept negative values.  
  
    > [!NOTE]
    >  `OffsetPos`, unlike `StepIt`, will not wrap the position. The new position is adjusted to remain within the range.  
  
### To change the position to a specific value  
  
1.  Use the [SetPos](../vs140/cprogressctrl--setpos.md) member function to set the position to a specific value. If necessary, the new position is adjusted to be within the range.  
  
 Typically, the progress control is used solely for output. To get the current position without specifying a new value, use [GetPos](../vs140/cprogressctrl--getpos.md).  
  
## See Also  
 [Using CProgressCtrl](../vs140/using-cprogressctrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)