---
title: "Dialog Boxes"
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
  - "modeless dialog boxes, MFC dialog boxes"
  - "MFC, dialog boxes"
  - "modal dialog boxes, MFC dialog boxes"
  - "CDialog class, MFC dialog boxes"
  - "MFC dialog boxes"
ms.assetid: e4feea1a-8360-4ccb-9b84-507f1ccd9ef3
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Dialog Boxes
Applications for Windows frequently communicate with the user through dialog boxes. Class [CDialog](../vs140/cdialog-class.md) provides an interface for managing dialog boxes, the Visual C++ dialog editor makes it easy to design dialog boxes and create their dialog-template resources, and Code wizards simplify the process of initializing and validating the controls in a dialog box and of gathering the values entered by the user.  
  
 Dialog boxes contain controls, including:  
  
-   Windows common controls such as edit boxes, pushbuttons, list boxes, combo boxes, tree controls, list controls, and progress indicators.  
  
-   ActiveX controls.  
  
-   Owner-drawn controls: controls that you are responsible for drawing in the dialog box.  
  
 Most dialog boxes are modal, which require the user to close the dialog box before using any other part of the program. But it is possible to create modeless dialog boxes, which let users work with other windows while the dialog box is open. MFC supports both kinds of dialog box with class `CDialog`. The controls are arranged and managed using a dialog-template resource, created with the [dialog editor](../vs140/dialog-editor.md).  
  
 [Property sheets](../vs140/property-sheets--mfc-.md), also known as tab dialog boxes, are dialog boxes that contain "pages" of distinct dialog-box controls. Each page has a file folder "tab" at the top. Clicking a tab brings that page to the front of the dialog box.  
  
## What do you want to know more about?  
  
-   [Example: Displaying a Dialog Box via a Menu Command](../vs140/example--displaying-a-dialog-box-via-a-menu-command.md)  
  
-   [Dialog-box components in the framework](../vs140/dialog-box-components-in-the-framework.md)  
  
-   [Modal and modeless dialog boxes](../vs140/modal-and-modeless-dialog-boxes.md)  
  
-   [Property sheets and property pages](../vs140/property-sheets-and-property-pages--mfc-.md) in a dialog box  
  
-   [Creating the dialog resource](../vs140/creating-the-dialog-resource.md)  
  
-   [Creating a dialog class with Code Wizards](../vs140/creating-a-dialog-class-with-code-wizards.md)  
  
-   [Life cycle of a dialog box](../vs140/life-cycle-of-a-dialog-box.md)  
  
-   [Dialog data exchange (DDX) and validation (DDV)](../vs140/dialog-data-exchange-and-validation.md)  
  
-   [Type-safe access to controls in a dialog box](../vs140/type-safe-access-to-controls-in-a-dialog-box.md)  
  
-   [Mapping Windows messages to your class](../vs140/mapping-windows-messages-to-your-class.md)  
  
-   [Commonly Overridden Member Functions](../vs140/commonly-overridden-member-functions.md)  
  
-   [Commonly Added Member Functions](../vs140/commonly-added-member-functions.md)  
  
-   [Common dialog classes](../vs140/common-dialog-classes.md)  
  
-   [Dialog boxes in OLE](../vs140/dialog-boxes-in-ole.md)  
  
-   Create an application whose user interface is a dialog box: see the [CMNCTRL1](../vs140/visual-c---samples.md) or [CMNCTRL2](../vs140/visual-c---samples.md) sample programs. The Application Wizard provides this option as well.  
  
-   [Samples](../vs140/dialog-sample-list.md)  
  
## See Also  
 [User Interface Elements](../vs140/user-interface-elements--mfc-.md)