---
title: "Using Slider Controls"
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
  - "CSliderCtrl class, using"
  - "slider controls"
  - "slider controls, using"
ms.assetid: 2b1a8ac8-2b17-41e1-aa24-83c1fd737049
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using Slider Controls
Typical usage of an slider control follows the pattern below:  
  
-   The control is created. If the control is specified in a dialog box template, creation is automatic when the dialog box is created. (You should have a [CSliderCtrl](../vs140/csliderctrl-class.md) member in your dialog class that corresponds to the slider control.) Alternatively, you can use the [Create](../vs140/csliderctrl--create.md) member function to create the control as a child window of any window.  
  
-   Call the various Set member functions to set values for the control. Changes that you can make include setting the minimum and maximum positions for the slider, drawing tick marks, setting a selection range, and repositioning the slider. For controls in a dialog box, a good time to do this is in the dialog's [OnInitDialog](../vs140/cdialog--oninitdialog.md) function.  
  
-   As the user interacts with the control, it will send various notification messages. You can extract the slider value from the control by calling the [GetPos](../vs140/csliderctrl--getpos.md) member function.  
  
-   When you're done with the control, you need to make sure it's properly destroyed. If the slider control is in a dialog box, it and the `CSliderCtrl` object will be destroyed automatically. If not, you need to ensure that both the control and the `CSliderCtrl` object are properly destroyed.  
  
## See Also  
 [Using CSliderCtrl](../vs140/using-csliderctrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)