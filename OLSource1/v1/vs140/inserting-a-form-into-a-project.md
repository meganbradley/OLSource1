---
title: "Inserting a Form into a Project"
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
  - "inserting forms"
  - "Insert New dialog box"
  - "forms, adding to projects"
ms.assetid: f3bd2998-3ce2-496d-ac5c-57ca70eec7cb
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Inserting a Form into a Project
Forms provide a convenient container for controls. You can easily insert an MFC-based form into your application as long as the application supports the MFC libraries.  
  
### To insert a form into your project  
  
1.  From Class View, select the project to which you want to add the form, and click the right mouse button.  
  
2.  From the shortcut menu, click **Add** and then click **Add Class**.  
  
     If the **New Form** command is not available, your project may be based on the Active Template Library (ATL). To add a form to an ATL project, you must [specify certain settings](../vs140/application-settings--atl-project-wizard.md) when first creating the project.  
  
3.  From the **MFC** folder, click **MFC Class**.  
  
4.  Using the MFC Class Wizard, make the new class derive from [CFormView](../vs140/cformview-class.md).  
  
 Visual C++ adds the form to your application, opening it inside the Dialog editor so that you can begin adding controls and working on its overall design.  
  
 You may want to perform the following additional steps (not applicable for dialog-based applications):  
  
1.  Override the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> member function.  
  
2.  Implement a member function to move data from your view to your document.  
  
3.  Create an <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function.  
  
## See Also  
 [Form Views](../vs140/form-views--mfc-.md)