---
title: "Adding an ATL Property Page"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "property pages, adding"
  - "ATL projects, adding property pages"
  - "controls [ATL], property pages"
ms.assetid: ddf92b49-42a2-46d2-b6b8-d37baedebeca
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Adding an ATL Property Page
To add an Active Template Library (ATL) property page to your project, your project must have been created as an ATL application or as an MFC application that contains ATL support. You can use the [ATL Project Wizard](../vs140/atl-project-wizard.md) to create an ATL application or [add an ATL object to your MFC application](../vs140/adding-atl-support-to-your-mfc-project.md) to implement ATL support for an MFC application.  
  
 If you are adding a property page for a control, your control must support the [ISpecifyPropertyPagesImpl](../vs140/ispecifypropertypagesimpl-class.md) interface. By default, this interface is in the derivation list of your control class when you [create an ATL control](../vs140/adding-an-atl-control.md) using the [ATL Control Wizard](../vs140/atl-control-wizard.md).  
  
> [!NOTE]
>  If your control class does not have [ISpecifyPropertyPagesImpl](../vs140/ispecifypropertypagesimpl-class.md) in its derivation list, you must add it manually.  
  
### To add an ATL property page to your project  
  
1.  In either **Solution Explorer** or [Class View](assetId:///8d7430a9-3e33-454c-a9e1-a85e3d2db925), right-click the name of the project to which you want to add the ATL property page.  
  
2.  From the shortcut menu, click **Add** and then click **Add Class**.  
  
3.  In the [Add Class](../vs140/add-class-dialog-box.md) dialog box, in the Templates pane, click **ATL Property Page** and then click **Open** to display the [ATL Property Page Wizard](../vs140/atl-property-page-wizard.md).  
  
 Once you create a property page for a control, you must provide the [PROP_PAGE](../vs140/prop_page.md) entry in the property map for the control.  
  
## See Also  
 [Property Pages](../vs140/atl-com-property-pages.md)   
 [Fundamentals of ATL COM Objects](../vs140/fundamentals-of-atl-com-objects.md)   
 [Example: Implementing a Property Page](../vs140/example--implementing-a-property-page.md)