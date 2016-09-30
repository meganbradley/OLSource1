---
title: "Deriving Controls from a Standard Control"
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
  - "standard controls, deriving controls from"
  - "common controls [C++], deriving from"
  - "derived controls"
  - "controls [MFC], derived"
  - "Windows common controls [C++], deriving from"
  - "standard controls"
ms.assetid: a6f84315-7007-4e0e-8576-78be81254802
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Deriving Controls from a Standard Control
As with any [CWnd](../vs140/cwnd-class.md)-derived class, you can modify a control's behavior by deriving a new class from an existing control class.  
  
### To create a derived control class  
  
1.  Derive your class from an existing control class and optionally override the **Create** member function so that it provides the necessary arguments to the base-class **Create** function.  
  
2.  Provide message-handler member functions and message-map entries to modify the control's behavior in response to specific Windows messages. See [Mapping Messages to Functions](../vs140/mapping-messages-to-functions.md).  
  
3.  Provide new member functions to extend the functionality of the control (optional).  
  
 Using a derived control in a dialog box requires extra work. The types and positions of controls in a dialog box are normally specified in a dialog-template resource. If you create a derived control class, you cannot specify it in a dialog template since the resource compiler knows nothing about your derived class.  
  
#### To place your derived control in a dialog box  
  
1.  Embed an object of the derived control class in the declaration of your derived dialog class.  
  
2.  Override the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> member function in your dialog class to call the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function for the derived control.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> "dynamically subclasses" a control created from a dialog template. When a control is dynamically subclassed, you hook into Windows, process some messages within your own application, then pass the remaining messages on to Windows. For more information, see the [SubclassDlgItem](../vs140/cwnd--subclassdlgitem.md) member function of class <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in the *MFC Reference*. The following example shows how you might write an override of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to call <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>:  
  
 [!code[NVC_MFCControlLadenDialog#3](../vs140/codesnippet/CPP/deriving-controls-from-a-standard-control_1.cpp)]  
  
 Because the derived control is embedded in the dialog class, it will be constructed when the dialog box is constructed, and it will be destroyed when the dialog box is destroyed. Compare this code to the example in [Adding Controls By Hand](../vs140/adding-controls-by-hand.md).  
  
## See Also  
 [Making and Using Controls](../vs140/making-and-using-controls.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)