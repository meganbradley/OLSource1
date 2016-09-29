---
title: "Declaring a Variable Based on Your New Control Class"
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
  - "vc.codewiz.classes.control.variable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "variables, control classes"
  - "control classes, variables"
  - "classes [C++], declaring variables based on"
ms.assetid: 5722dc38-c0eb-40bd-93da-67a808140d03
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Declaring a Variable Based on Your New Control Class
Once you have created an MFC control class, you can declare a variable based on it. To provide a context for the new variable, you must open the dialog editor and edit the dialog box in which you want to use your reusable control. Also, the dialog box must already have a class associated with it. For information on using the dialog editor, see [Dialog Editor](../vs140/dialog-editor.md).  
  
### To declare a variable based on your reusable class  
  
1.  While editing the dialog box, drag a control of the same type as the base class of your new control from the Controls toolbar onto the dialog box.  
  
2.  Place the mouse pointer over the dropped control.  
  
3.  While pressing the CTRL key, double-click the control.  
  
     The [Add Member Variable](../vs140/add-member-variable-wizard.md) dialog box appears.  
  
4.  In the **Access** box, select the correct access for your control.  
  
5.  Click the **Control variable** check box.  
  
6.  In the **Variable name** box, type a name.  
  
7.  Under **Category**, click **Control**.  
  
8.  In the **Control ID** list, pick the control that you added. The **Variable type** list should display the correct variable type, and the **Control type** box should display the correct control type.  
  
9. In the **Comment** box, add any comment you want to appear in your code.  
  
10. Click **OK**.  
  
## See Also  
 [Mapping Messages to Functions](../vs140/mapping-messages-to-functions.md)   
 [Adding Functionality with Code Wizards](../vs140/adding-functionality-with-code-wizards--c---.md)   
 [Adding a Class](../vs140/adding-a-class--visual-c---.md)   
 [Adding a Member Function](../vs140/adding-a-member-function--visual-c---.md)   
 [Adding a Member Variable](../vs140/adding-a-member-variable---visual-c---.md)   
 [Overriding a Virtual Function](../vs140/overriding-a-virtual-function--visual-c---.md)   
 [MFC Message Handler](../vs140/adding-an-mfc-message-handler.md)   
 [Navigating the Class Structure](../vs140/navigating-the-class-structure--visual-c---.md)