---
title: "Using Property Sheets in Your Application"
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
  - "dialog templates, property sheets"
  - "dialog resources"
  - "property pages, property sheets"
  - "DoModal method property sheets"
  - "AddPage method"
  - "property sheets, about property sheets"
  - "Create method [C++], property sheets"
  - "CPropertyPage class, styles"
ms.assetid: 240654d4-152b-4e3f-af7b-44234339206e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using Property Sheets in Your Application
To use a property sheet in your application, complete the following steps:  
  
1.  Create a dialog template resource for each property page. Keep in mind that the user may be switching from one page to another, so lay out each page as consistently as possible.  
  
     The dialog templates for all pages do not have to be the same size. The framework uses the size of the largest page to determine how much space to allocate in the property sheet for the property pages.  
  
     When you create the dialog template resource for a property page, you must specify the following styles in the Dialog Properties property sheet:  
  
    -   Set the **Caption** edit box on the **General** page to the text you wish to appear in the tab for this page.  
  
    -   Set the **Style** list box on the **Styles** page to **Child**.  
  
    -   Set the **Border** list box on the **Styles** page to **Thin**.  
  
    -   Ensure that the **Titlebar** check box on the **Styles** page is selected.  
  
    -   Ensure that the **Disabled** check box on the **More Styles** page is selected.  
  
2.  Create a [CPropertyPage](../vs140/cpropertypage-class.md)-derived class corresponding to each property page dialog template. See [Adding a Class](../vs140/adding-a-class--visual-c---.md). Choose `CPropertyPage` as the base class.  
  
3.  Create member variables to hold the values for this property page. The process for adding member variables to a property page is exactly the same as adding member variables to a dialog box, because a property page is a specialized dialog box. For more information, see [Defining Member Variables for Dialog Controls](../vs140/defining-member-variables-for-dialog-controls.md).  
  
4.  Construct a [CPropertySheet](../vs140/cpropertysheet-class.md) object in your source code. Usually, you construct the `CPropertySheet` object in the handler for the command that displays the property sheet. This object represents the entire property sheet. If you create a modal property sheet with the [DoModal](../vs140/cpropertysheet--domodal.md) function, the framework supplies three command buttons by default: OK, Cancel, and Apply. The framework creates no command buttons for modeless property sheets created with the [Create](../vs140/cpropertysheet--create.md) function. You do not need to derive a class from `CPropertySheet` unless you want to either add other controls (such as a preview window) or display a modeless property sheet. This step is necessary for modeless property sheets because they do not contain any default controls that could be used to close the property sheet.  
  
5.  For each page to be added to the property sheet, do the following:  
  
    -   Construct one object for each `CPropertyPage`-derived class that you created earlier in this process.  
  
    -   Call [CPropertySheet::AddPage](../vs140/cpropertysheet--addpage.md) for each page.  
  
     Typically, the object that creates the `CPropertySheet` also creates the `CPropertyPage` objects in this step. However, if you implement a `CPropertySheet`-derived class, you can embed the `CPropertyPage` objects in the `CPropertySheet` object and call `AddPage` for each page from the `CPropertySheet`-derived class constructor. `AddPage` adds the `CPropertyPage` object to the property sheet's list of pages but does not actually create the window for that page. Therefore, it is not necessary to wait until creation of the property sheet window to call `AddPage`; you can call `AddPage` from the property sheet's constructor.  
  
     By default, if a property sheet has more tabs than will fit in a single row of the property sheet, the tabs will stack in multiple rows. To disable stacking, call [CPropertySheet::EnableStackedTabs](../vs140/cpropertysheet--enablestackedtabs.md) with the parameter set to **FALSE**. You must call `EnableStackedTabs` when you create the property sheet.  
  
6.  Call [CPropertySheet::DoModal](../vs140/cpropertysheet--domodal.md) or [Create](../vs140/cpropertysheet--create.md) to display the property sheet. Call `DoModal` to create a property sheet as a modal dialog box. Call **Create** to create the property sheet as a modeless dialog box.  
  
7.  Exchange data between property pages and the owner of the property sheet. This is explained in the article [Exchanging Data](../vs140/exchanging-data.md).  
  
 For an example of how to use property sheets, see the MFC General sample [PROPDLG](../vs140/visual-c---samples.md).  
  
## See Also  
 [Property Sheets](../vs140/property-sheets--mfc-.md)