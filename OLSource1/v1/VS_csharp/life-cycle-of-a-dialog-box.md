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
  
-   [Creating and displaying dialog boxes](../VS_csharp/creating-and-displaying-dialog-boxes.md)  
  
-   [Creating modal dialog boxes](../VS_csharp/creating-modal-dialog-boxes.md)  
  
-   [Creating modeless dialog boxes](../VS_csharp/creating-modeless-dialog-boxes.md)  
  
-   [Using a dialog template in memory](../VS_csharp/using-a-dialog-template-in-memory.md)  
  
-   [Setting the dialog box's background color](../VS_csharp/setting-the-dialog-box’s-background-color.md)  
  
-   [Initializing the dialog box](../VS_csharp/initializing-the-dialog-box.md)  
  
-   [Handling Windows messages in your dialog box](../VS_csharp/handling-windows-messages-in-your-dialog-box.md)  
  
-   [Retrieving data from the dialog object](../VS_csharp/retrieving-data-from-the-dialog-object.md)  
  
-   [Closing the dialog box](../VS_csharp/closing-the-dialog-box.md)  
  
-   [Destroying the dialog box](../VS_csharp/destroying-the-dialog-box.md)  
  
-   [Dialog data exchange (DDX) and validation (DDV)](../VS_csharp/dialog-data-exchange-and-validation.md)  
  
-   [Property sheet dialog boxes](../VS_csharp/property-sheets-and-property-pages--mfc-.md)  
  
## See Also  
 [Dialog Boxes](../VS_csharp/dialog-boxes.md)