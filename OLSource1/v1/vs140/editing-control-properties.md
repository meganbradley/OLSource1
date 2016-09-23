---
title: "Editing Control Properties"
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
  - C++
helpviewer_keywords: 
  - controls [C++], undoing changes
  - controls [C++], editing properties
  - dialog box controls, editing properties
ms.assetid: 9bdae21d-6dec-4344-a197-2ca4fc46d040
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Editing Control Properties
### To edit the properties of a control or controls  
  
1.  In the dialog box, select the control you want to modify.  
  
    > [!NOTE]
    >  If you select multiple controls, only the properties common to the selected controls can be edited.  
  
2.  In the [Properties window](../vs140/properties-window.md), change the properties of your control.  
  
    > [!NOTE]
    >  When you set the **Bitmap** property for a button, radio button, or check box control equal to **True**, the style BS_BITMAP is implemented for your control. For more information, see [Button Styles](../vs140/button-styles.md). For an example of associating a bitmap with a control, see [CButton::SetBitmap](../vs140/cbutton--setbitmap.md). Bitmaps will not appear on your control while you are in the Dialog resource editor.  
  
### To undo changes to the properties of a control  
  
1.  Make sure the control has focus in the Dialog editor.  
  
2.  Choose **Undo** from the **Edit** menu (if focus is not on the control, the **Undo** command will be unavailable).  
  
 For information on adding resources to managed projects, see [Resources in Applications](assetId:///8ad495d4-2941-40cf-bf64-e82e85825890) in the *.NET Framework Developer's Guide.* For information on manually adding resource files to managed projects, accessing resources, displaying static resources, and assigning resources strings to properties, see [Walkthrough: Localizing Windows Forms](assetId:///9a96220d-a19b-4de0-9f48-01e5d82679e5) and [Walkthrough: Using Resources for Localization with ASP.NET](assetId:///bb4e5b44-e2b0-48ab-bbe9-609fb33900b6).  
  
 Requirements  
  
 Win32  
  
## See Also  
 [Controls in Dialog Boxes](../vs140/controls-in-dialog-boxes.md)