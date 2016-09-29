---
title: "Life Cycle of a Dialog Box"
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
  - "dialog boxes, life cycle"
  - "modal dialog boxes, life cycle"
  - "modeless dialog boxes, life cycle"
  - "MFC dialog boxes, life cycle"
  - "life cycle of dialog boxes"
ms.assetid: e16fd78e-238d-4f31-8c9d-8564f3953bd9
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Life Cycle of a Dialog Box
During the life cycle of a dialog box, the user invokes the dialog box, typically inside a command handler that creates and initializes the dialog object, the user interacts with the dialog box, and the dialog box closes.  
  
 For modal dialog boxes, your handler gathers any data the user entered once the dialog box closes. Since the dialog object exists after its dialog window has closed, you can simply use the member variables of your dialog class to extract the data.  
  
 For modeless dialog boxes, you may often extract data from the dialog object while the dialog box is still visible. At some point, the dialog object is destroyed; when this happens depends on your code.  
  
## What do you want to know more about?  
  
-   [Creating and displaying dialog boxes](../vs140/creating-and-displaying-dialog-boxes.md)  
  
-   [Creating modal dialog boxes](../vs140/creating-modal-dialog-boxes.md)  
  
-   [Creating modeless dialog boxes](../vs140/creating-modeless-dialog-boxes.md)  
  
-   [Using a dialog template in memory](../vs140/using-a-dialog-template-in-memory.md)  
  
-   [Setting the dialog box's background color](../vs140/setting-the-dialog-box’s-background-color.md)  
  
-   [Initializing the dialog box](../vs140/initializing-the-dialog-box.md)  
  
-   [Handling Windows messages in your dialog box](../vs140/handling-windows-messages-in-your-dialog-box.md)  
  
-   [Retrieving data from the dialog object](../vs140/retrieving-data-from-the-dialog-object.md)  
  
-   [Closing the dialog box](../vs140/closing-the-dialog-box.md)  
  
-   [Destroying the dialog box](../vs140/destroying-the-dialog-box.md)  
  
-   [Dialog data exchange (DDX) and validation (DDV)](../vs140/dialog-data-exchange-and-validation.md)  
  
-   [Property sheet dialog boxes](../vs140/property-sheets-and-property-pages--mfc-.md)  
  
## See Also  
 [Dialog Boxes](../vs140/dialog-boxes.md)