---
title: "How to: Print a Form by Using the PrintForm Component (Visual Basic)"
ms.custom: na
ms.date: "09/23/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Form, printing"
ms.assetid: df963bf6-3ee1-49f4-8b2e-1d95d1beb0be
caps.latest.revision: 23
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Print a Form by Using the PrintForm Component (Visual Basic)
The <xref:Microsoft.VisualBasic.PowerPacks.Printing.PrintForm*> component enables you to quickly print an image of a form exactly as it appears on screen without using a <xref:System.Drawing.Printing.PrintDocument*> component. The following procedures show how to print a form to a printer, to a print preview window, and to an Encapsulated PostScript file.  
  
 The PowerPack controls are no longer included in Visual Studio, but you can download them from the [Download Center](http://www.microsoft.com/en-us/download/details.aspx?id=25169).  
  
### To print a form to the default printer  
  
1.  In the **Toolbox**, click the **Visual Basic PowerPacks** tab and then drag the <xref:Microsoft.VisualBasic.PowerPacks.Printing.PrintForm*> component onto the form.  
  
     The <xref:Microsoft.VisualBasic.PowerPacks.Printing.PrintForm*> component is added to the component tray.  
  
2.  In the **Properties** window, set the <xref:Microsoft.VisualBasic.PowerPacks.Printing.PrintForm.PrintAction*> property to <xref:System.Drawing.Printing.PrintAction.PrintToPrinter*>.  
  
3.  Add the following code in the appropriate event handler (for example, in the `Click` event handler for a **Print**`Button`).  
  
    ```  
    PrintForm1.Print()  
    ```  
  
### To display a form in a print preview window  
  
1.  In the **Toolbox**, click the **Visual Basic PowerPacks** tab and then drag the <xref:Microsoft.VisualBasic.PowerPacks.Printing.PrintForm*> component onto the form.  
  
     The <xref:Microsoft.VisualBasic.PowerPacks.Printing.PrintForm*> component is added to the component tray.  
  
2.  In the **Properties** window, set the <xref:Microsoft.VisualBasic.PowerPacks.Printing.PrintForm.PrintAction*> property to <xref:System.Drawing.Printing.PrintAction.PrintToPreview*>.  
  
3.  Add the following code in the appropriate event handler (for example, in the `Click` event handler for a **Print**`Button`).  
  
    ```  
    PrintForm1.Print()  
    ```  
  
### To print a form to a file  
  
1.  In the **Toolbox**, click the **Visual Basic PowerPacks** tab and then drag the <xref:Microsoft.VisualBasic.PowerPacks.Printing.PrintForm*> component onto the form.  
  
     The <xref:Microsoft.VisualBasic.PowerPacks.Printing.PrintForm*> component is added to the component tray.  
  
2.  In the **Properties** window, set the <xref:Microsoft.VisualBasic.PowerPacks.Printing.PrintForm.PrintAction*> property to <xref:System.Drawing.Printing.PrintAction.PrintToFile*>.  
  
3.  Optionally, select the <xref:Microsoft.VisualBasic.PowerPacks.Printing.PrintForm.PrintFileName*> property and type the full path and file name for the destination file.  
  
     If you skip this step, the user will be prompted for a file name at run time.  
  
4.  Add the following code in the appropriate event handler (for example, in the `Click` event handler for a **Print**`Button`).  
  
    ```  
    PrintForm1.Print()  
    ```  
  
## See Also  
 <xref:Microsoft.VisualBasic.PowerPacks.Printing.PrintForm.PrintAction*>   
 <xref:Microsoft.VisualBasic.PowerPacks.Printing.PrintForm.PrintFileName*>   
 [How to: Print the Client Area of a Form](../vs140/how-to--print-the-client-area-of-a-form--visual-basic-.md)   
 [How to: Print Client and Non-client Areas of a Form](../vs140/how-to--print-client-and-non-client-areas-of-a-form--visual-basic-.md)   
 [How to: Print a Scrollable Form](../vs140/how-to--print-a-scrollable-form--visual-basic-.md)   
 [PrintForm Component](../vs140/printform-component--visual-basic-.md)