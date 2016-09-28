---
title: "Adding a Member Variable  (Visual C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vc.codewiz.classes.member.variable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "member variables, adding"
  - "member variables"
ms.assetid: 437783bd-8eb4-4508-8b73-7380116e9d71
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Adding a Member Variable  (Visual C++)
You can add a member variable to a class using Class View. Member variables can be either for [data exchange and data validation](../vs140/dialog-data-exchange-and-validation.md), or they can be generic. The data member variable wizard is specifically designed to take the relevant information and use it to insert elements in your source files at the appropriate locations. You can add a member variable from the [Dialog editor](../vs140/dialog-editor.md) in [Resource View](../vs140/resource-view-window.md), or from [Class View](assetId:///8d7430a9-3e33-454c-a9e1-a85e3d2db925).  
  
> [!NOTE]
>  When you are designing and implementing a dialog box, you might find it more efficient to use the Dialog editor to add the dialog box controls, and then to implement the controls' member variables.  
  
### To add a member variable for a dialog control in Resource View using the Add Member Variable Wizard  
  
1.  In Resource View, expand the project node and the Dialog node to display the list of the project's dialog boxes.  
  
2.  Double-click the dialog box to which you want to add the member variable to open it in the Dialog editor.  
  
3.  In the dialog box displayed in the Dialog editor, right-click the control to which you want to add the member variable.  
  
4.  On the shortcut menu, click **Add Variable** to display the [Add Member Variable Wizard](../vs140/add-member-variable-wizard.md).  
  
    > [!NOTE]
    >  A default value is already provided in **Control ID**.  
  
5.  Provide the information in the appropriate wizard boxes. See [Dialog Box Controls and Variable Types](../vs140/dialog-box-controls-and-variable-types.md) for more information.  
  
6.  Click **Finish** to add the definition and implementation code to the project and close the wizard.  
  
### To add a member variable from Class View using the Add Member Variable Wizard  
  
1.  In [Class View](assetId:///8d7430a9-3e33-454c-a9e1-a85e3d2db925), expand the project node to display the classes in the project.  
  
2.  Right-click the class to which you want to add a variable.  
  
3.  On the shortcut menu, click **Add**, and then click **Add Variable** to display the Add Member Variable Wizard.  
  
4.  Provide the information in the appropriate wizard boxes. See [Add Member Variable Wizard](../vs140/add-member-variable-wizard.md) for details.  
  
5.  Click **Finish** to add the definition and implementation code to the project and close the wizard.  
  
## See Also  
 [Adding Functionality with Code Wizards](../vs140/adding-functionality-with-code-wizards--c---.md)   
 [Adding a Class](../vs140/adding-a-class--visual-c---.md)   
 [Adding a Member Function](../vs140/adding-a-member-function--visual-c---.md)   
 [MFC Message Handler](../vs140/adding-an-mfc-message-handler.md)   
 [Navigating the Class Structure](../vs140/navigating-the-class-structure--visual-c---.md)