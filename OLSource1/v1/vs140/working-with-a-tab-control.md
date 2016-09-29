---
title: "Working with a Tab Control"
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
  - "CTabCtrl class, using"
  - "tab controls, working with"
  - "tab controls, using"
ms.assetid: 819488e3-4944-44b7-9483-195edb8e0aed
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Working with a Tab Control
The easiest way to use a tab control ([CTabCtrl](../vs140/ctabctrl-class.md)) is by adding it to a dialog template resource with the dialog editor. You can also use a tab control by itself. MFC calls **InitCommonControls** for you. The key tasks are as follows:  
  
-   [Creating the tab control](../vs140/creating-the-tab-control.md)  
  
-   [Adding tabs to a tab control](../vs140/adding-tabs-to-a-tab-control.md)  
  
-   [Processing tab control notification messages](../vs140/processing-tab-control-notification-messages.md)  
  
 If the tab control object is embedded in a parent view or dialog class, the control is destroyed when the parent is destroyed.  
  
## See Also  
 [Using CTabCtrl](../vs140/using-ctabctrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)