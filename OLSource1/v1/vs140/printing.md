---
title: "Printing"
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
  - "view classes, print operations"
  - "documents, printing"
  - "printing [MFC], from framework"
  - "printing [MFC]"
ms.assetid: be465e8d-b0c9-4fc5-9fa8-d10486064f76
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Printing
Microsoft Windows implements device-independent display. In MFC, this means that the same drawing calls, in the `OnDraw` member function of your view class, are responsible for drawing on the display and on other devices, such as printers. For print preview, the target device is a simulated printer output to the display.  
  
##  <a name="_core_your_role_in_printing_vs.._the_framework.92.s_role"></a> Your Role in Printing vs. the Framework's Role  
 Your view class has the following responsibilities:  
  
-   Inform the framework how many pages are in the document.  
  
-   When asked to print a specified page, draw that portion of the document.  
  
-   Allocate and deallocate any fonts or other graphics device interface (GDI) resources needed for printing.  
  
-   If necessary, send any escape codes needed to change the printer mode before printing a given page, for example, to change the printing orientation on a per-page basis.  
  
 The framework's responsibilities are as follows:  
  
-   Display the **Print** dialog box.  
  
-   Create a [CDC](../vs140/cdc-class.md) object for the printer.  
  
-   Call the [StartDoc](../vs140/cdc--startdoc.md) and [EndDoc](../vs140/cdc--enddoc.md) member functions of the `CDC` object.  
  
-   Repeatedly call the [StartPage](../vs140/cdc--startpage.md) member function of the `CDC` object, inform the view class which page should be printed, and call the [EndPage](../vs140/cdc--endpage.md) member function of the `CDC` object.  
  
-   Call overridable functions in the view at the appropriate times.  
  
 The following articles discuss how the framework supports printing and print preview:  
  
### What do you want to know more about?  
  
-   [How default printing is done](../vs140/how-default-printing-is-done.md)  
  
-   [Multipage documents](../vs140/multipage-documents.md)  
  
-   [Headers and footers](../vs140/headers-and-footers.md)  
  
-   [Allocating GDI resources for printing](../vs140/allocating-gdi-resources.md)  
  
-   [Print preview](../vs140/print-preview-architecture.md)  
  
## See Also  
 [Printing and Print Preview](../vs140/printing-and-print-preview.md)