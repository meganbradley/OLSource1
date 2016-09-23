---
title: "Overriding a Virtual Function (Visual C++)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vc.codewiz.virtualfunc.override
dev_langs: 
  - C++
helpviewer_keywords: 
  - virtual functions, overriding
  - base classes, overriding virtual functions defined in
  - Properties window, overriding virtual functions in
ms.assetid: 2d8c76f2-7a6b-4c9c-8de5-4282ce7755b6
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Overriding a Virtual Function (Visual C++)
You can override virtual functions defined in a base class from the Visual Studio [Properties window](../vs140/properties-window.md).  
  
### To override a virtual function in the Properties window  
  
1.  In Class View, click the class.  
  
2.  In the Properties window, click the **Overrides** button.  
  
    > [!NOTE]
    >  The **Overrides** button is available when you select either the class name in Class View or when you click within the source window.  
  
     The left column lists the virtual functions. If the name of a virtual function also appears in the right column, then an override has already been implemented.  
  
3.  If the function has no override, then click the cell in the right column in the Properties window to display the suggested name of the function override as <add\>*FuncName*.  
  
4.  Click the suggested name to add stub code for the function.  
  
5.  To edit an overriding function, double-click the name of the function in Class View and edit the code in the source window.  
  
 To remove an override, click the override function name in the right column and select <delete\>*FuncName*. The function's code is commented out.  
  
## See Also  
 [Adding Functionality with Code Wizards](../vs140/adding-functionality-with-code-wizards--c---.md)   
 [Adding a Class](../vs140/adding-a-class--visual-c---.md)   
 [Adding a Member Function](../vs140/adding-a-member-function--visual-c---.md)   
 [Adding a Member Variable](../vs140/adding-a-member-variable---visual-c---.md)   
 [MFC Message Handler](../vs140/adding-an-mfc-message-handler.md)   
 [Navigating the Class Structure](../vs140/navigating-the-class-structure--visual-c---.md)