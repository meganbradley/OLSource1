---
title: "Implementing Property Pages"
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
  - "IPropertyPage2 class"
  - "IPropertyPage class"
  - "property pages, implementing"
ms.assetid: 62f29440-33a7-40eb-a1ef-3634c95f640c
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Implementing Property Pages
Property pages are COM objects that implement the `IPropertyPage` or **IPropertyPage2** interface. ATL provides support for implementing property pages through the [ATL Property Page Wizard](../vs140/atl-property-page-wizard.md) in the [Add Class dialog box](../vs140/add-class-dialog-box.md).  
  
 To create a property page using ATL:  
  
-   Create or open an ATL Dynamic-link library (DLL) server project.  
  
-   Open the [Add Class dialog box](../vs140/add-class-dialog-box.md) and select **ATL Property Page**.  
  
-   Make sure your property page is apartment threaded (since it has a user interface).  
  
-   Set the title, description (Doc String), and help file to be associated with your page.  
  
-   Add controls to the generated dialog resource to act as the user interface of your property page.  
  
-   Respond to changes in your page's user interface to perform validation, update the page site, or update the objects associated with your page. In particular, call [IPropertyPageImpl::SetDirty](../vs140/ipropertypageimpl--setdirty.md) when the user makes changes to the property page.  
  
-   Optionally override the `IPropertyPageImpl` methods using the guidelines below.  
  
    |IPropertyPageImpl method|Override when you want to...|Notes|  
    |------------------------------|----------------------------------|-----------|  
    |[SetObjects](../vs140/ipropertypageimpl--setobjects.md)|Perform basic sanity checks on the number of objects being passed to your page and the interfaces that they support.|Execute your own code before calling the base class implementation. If the objects being set don't conform to your expectations, you should fail the call as soon as possible.|  
    |[Activate](../vs140/ipropertypageimpl--activate.md)|Initialize your page's user interface (for example, set dialog controls with current property values from objects, create controls dynamically, or perform other initializations).|Call the base class implementation before your code so that the base class has a chance to create the dialog window and all the controls before you try to update them.|  
    |[Apply](../vs140/ipropertypageimpl--apply.md)|Validate the property settings and update the objects.|There is no need to call the base class implementation since it doesn't do anything apart from trace the call.|  
    |[Deactivate](../vs140/ipropertypageimpl--deactivate.md)|Clean up window-related items.|The base class implementation destroys the dialog box representing the property page. If you need to clean up before the dialog box is destroyed, you should add your code before calling the base class.|  
  
 For an example property page implementation, see [Example: Implementing a Property Page](../vs140/example--implementing-a-property-page.md).  
  
> [!NOTE]
>  If you want to host ActiveX controls in your property page, you will need to change the derivation of your wizard-generated class. Replace **CDialogImpl<CYourClass\>** with **CAxDialogImpl<CYourClass\>** in the list of base classes.  
  
## See Also  
 [Property Pages](../vs140/atl-com-property-pages.md)   
 [ATLPages Sample](../vs140/visual-c---samples.md)