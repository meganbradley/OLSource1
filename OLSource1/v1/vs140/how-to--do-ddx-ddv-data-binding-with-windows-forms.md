---
title: "How to: Do DDX-DDV Data Binding with Windows Forms"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "get-started-article"
H1: "How to: Do DDX/DDV Data Binding with Windows Forms"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MFC [C++], hosting a Windows Forms Control"
  - "Windows Forms [C++], MFC support"
ms.assetid: b2957370-cf1f-4779-94ac-228cd393686c
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Do DDX-DDV Data Binding with Windows Forms
[DDX_ManagedControl](../vs140/ddx_managedcontrol.md) calls [CWinFormsControl::CreateManagedControl](../vs140/cwinformscontrol--createmanagedcontrol.md) to create a control matching the resource control ID. If you use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> for a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> control (in wizard-generated code), you should not call <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> explicitly for the same control.  
  
 Call <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in [DoDataExchange](../vs140/cwnd--dodataexchange.md) to create controls from resource IDs. For data exchange, you do not need to use the DDX/DDV functions with Windows Forms controls. Instead, you can place code to access the properties of the managed control in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> method of your dialog (or view) class, as in the following example.  
  
 The following example shows how to bind a native C++ string to a .NET user control.  
  
## Example  
 The following is an example of DDX/DDV data binding of an MFC string <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> with the user-defined <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> property of a .NET user control.  
  
 The control is created when [CDialog::OnInitDialog](../vs140/cdialog--oninitdialog.md) calls <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> for the first time, so any code that references <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> must come after the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> call.  
  
 You can implement this code in the MFC01 application you created in [How to: Create the User Control and Host in a Dialog Box](../vs140/how-to--create-the-user-control-and-host-in-a-dialog-box.md).  
  
 Put the following code in the declaration of CMFC01Dlg:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 Put the following code in the implementation of CMFC01Dlg:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 Now we will add the handler method for a click on the OK button. Click the **Resource View** tab. In Resource View, double-click on <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. The dialog resource appears in Resource Editor. Then double click the OK button..  
  
 Define the handler as follows.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
 And add the following line to the implementation of BOOL CMFC01Dlg::OnInitDialog().  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 You can now build and run the application. Notice that any text in the text box will be displayed in a pop-up message box when the application closes.  
  
## See Also  
 [CWinFormsControl Class](../vs140/cwinformscontrol-class.md)   
 [DDX_ManagedControl](../vs140/ddx_managedcontrol.md)   
 [CWnd::DoDataExchange](../vs140/cwnd--dodataexchange.md)