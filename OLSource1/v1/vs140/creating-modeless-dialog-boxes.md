---
title: "Creating Modeless Dialog Boxes"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - MFC dialog boxes, modeless
  - modeless dialog boxes, creating
  - MFC dialog boxes, creating
ms.assetid: 70d78c7f-3d40-477b-9f78-0f33c359f88b
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Creating Modeless Dialog Boxes
For a modeless dialog box, you must provide your own public constructor in your dialog class. To create a modeless dialog box, call your public constructor and then call the dialog object's [Create](../vs140/cdialog--create.md) member function to load the dialog resource. You can call **Create** either during or after the constructor call. If the dialog resource has the property **WS_VISIBLE**, the dialog box appears immediately. If not, you must call its [ShowWindow](../vs140/cwnd--showwindow.md) member function.  
  
## See Also  
 [Life Cycle of a Dialog Box](../vs140/life-cycle-of-a-dialog-box.md)