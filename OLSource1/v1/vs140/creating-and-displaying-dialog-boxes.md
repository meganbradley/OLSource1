---
title: "Creating and Displaying Dialog Boxes"
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
  - "modal dialog boxes, creating"
  - "opening dialog boxes"
  - "modeless dialog boxes, creating"
  - "MFC dialog boxes, creating"
  - "MFC dialog boxes, displaying"
ms.assetid: 1c5219ee-8b46-44bc-9708-83705d4f248b
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Creating and Displaying Dialog Boxes
Creating a dialog object is a two-phase operation. First, construct the dialog object, then create the dialog window. Modal and modeless dialog boxes differ somewhat in the process used to create and display them. The following table lists how modal and modeless dialog boxes are normally constructed and displayed.  
  
### Dialog Creation  
  
|Dialog type|How to create it|  
|-----------------|----------------------|  
|[Modeless](../vs140/creating-modeless-dialog-boxes.md)|Construct <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, then call **Create** member function.|  
|[Modal](../vs140/creating-modal-dialog-boxes.md)|Construct <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, then call <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> member function.|  
  
 You can, if you want, create your dialog box from an [in-memory dialog template](../vs140/using-a-dialog-template-in-memory.md) that you have constructed rather than from a dialog template resource. This is an advanced topic, however.  
  
## See Also  
 [Life Cycle of a Dialog Box](../vs140/life-cycle-of-a-dialog-box.md)