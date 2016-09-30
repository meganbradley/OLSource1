---
title: "ATL Dialog Wizard"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "vc.codewiz.class.atl.dlg.overview"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ATL projects, adding dialog resources"
  - "ATL Dialog Wizard"
ms.assetid: b0b9ace5-83c9-40d3-82c3-eb6293f10583
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATL Dialog Wizard
This wizard inserts into the project an ATL dialog box object, derived from [CAxDialogImpl](../vs140/caxdialogimpl-class.md). A dialog box derived from <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> can host ActiveX controls.  
  
 The wizard creates a dialog resource with default **OK** and **Cancel** buttons. You can edit the dialog resource and add ActiveX controls using the [Dialog Editor](../vs140/dialog-editor.md) in Resource View.  
  
 The wizard inserts into the header file a [message map](../vs140/message-maps--atl-.md) and declarations for handling the default click events. See [Implementing a Dialog Box](../vs140/implementing-a-dialog-box.md) for more information about ATL dialog boxes.  
  
 **Short name**  
 Sets the abbreviated name for the ATL dialog object. The name you provide determines the class name and the file (.cpp and .h) names, unless you change those fields individually.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Sets the name of the class to be created. This name is based on the name you provide in **Short name**, preceded by 'C', the typical prefix for a class name.  
  
 **.h file**  
 Sets the name of the header file for the new object's class. By default, this name is based on the name you provide in **Short name**. Click the ellipsis button to save the file name to the location of your choice, or to append the class declaration to an existing file. If you choose an existing file, the wizard will not save it to the selected location until you click **Finish** in the wizard.  
  
 The wizard does not overwrite a file. If you select the name of an existing file, when you click **Finish**, the wizard prompts you to indicate whether the class declaration should be appended to the contents of the file. Click **Yes** to append the file; click **No** to return to the wizard and specify another file name.  
  
 **.cpp file**  
 Sets the name of the implementation file for the new object's class. By default, this name is based on the name you provide in **Short name**. Click the ellipsis button to save the file name to the location of your choice. The file is not saved to the selected location until you click **Finish** in the wizard.  
  
 The wizard does not overwrite a file. If you select the name of an existing file, when you click **Finish**, the wizard prompts you to indicate whether the class implementation should be appended to the contents of the file. Click **Yes** to append the file; click **No** to return to the wizard and specify another file name.  
  
## See Also  
 [ATL Dialog Box](../vs140/adding-an-atl-dialog-box.md)