---
title: "Creating the Dialog Resource"
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
  - "dialog resources"
  - "MFC dialog boxes, creating"
  - "dialog templates, creating dialog resource"
  - "templates, creating"
  - "resources [MFC], creating dialog boxes"
  - "MFC dialog boxes, dialog resource"
ms.assetid: 0b83bd33-14d3-4611-8129-fccdae18053e
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Creating the Dialog Resource
To design the [dialog box](../VS_csharp/dialog-boxes.md) and create the dialog resource, you use the [dialog editor](../VS_csharp/dialog-editor.md). In the dialog editor, you can:  
  
-   Adjust the size and location your dialog box will have when it appears.  
  
-   Drag various kinds of controls from a controls palette and drop them where you want them in the dialog box.  
  
-   Position the controls with alignment buttons on the toolbar.  
  
-   Test your dialog box by simulating the appearance and behavior it will have in your program. In Test mode, you can manipulate the dialog box's controls by typing text in text boxes, clicking pushbuttons, and so on.  
  
 When you finish, your dialog-template resource is stored in your application's resource script file. You can edit it later if needed. For a full description of how to create and edit dialog resources, see the [dialog editor](../VS_csharp/dialog-editor.md) topics. This technique is also used to create the dialog-template resources for [CFormView](../VS_csharp/cformview-class.md) and [CRecordView](../VS_csharp/crecordview-class.md) classes.  
  
 When the dialog box's appearance suits you, create a dialog class and map its messages, as discussed in [Creating a Dialog Class with Code Wizards](../VS_csharp/creating-a-dialog-class-with-code-wizards.md).  
  
## See Also  
 [Dialog Boxes](../VS_csharp/dialog-boxes.md)   
 [Life Cycle of a Dialog Box](../VS_csharp/life-cycle-of-a-dialog-box.md)