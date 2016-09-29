---
title: "Hosting a Windows Form User Control in an MFC Dialog Box"
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
  - "MFC [C++], Windows Forms support"
  - "hosting Windows Forms control [C++]"
  - "Windows Forms [C++], MFC support"
ms.assetid: 9f66ee52-b7cb-4ffd-8306-392a5da990d8
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Hosting a Windows Form User Control in an MFC Dialog Box
MFC hosts a Windows Forms control as a special kind of ActiveX control and communicates with the control by using ActiveX interfaces, and properties and methods of the <xref:System.Windows.Forms.Control*> class. We recommend that you use .NET Framework properties and methods to operate on the control.  
  
 For a sample application that shows Windows Forms used with MFC, see [MFC and Windows Forms Integration](http://www.microsoft.com/downloads/details.aspx?FamilyID=987021bc-e575-4fe3-baa9-15aa50b0f599&displaylang=en).  
  
> [!NOTE]
>  In the current release, a `CDialogBar` object cannot host Windows Forms controls.  
  
## In This Section  
 [How to: Create the User Control and Host Dialog Box](../VS_csharp/how-to--create-the-user-control-and-host-in-a-dialog-box.md)  
  
 [How to: Do DDX/DDV Data Binding with Windows Forms](../VS_csharp/how-to--do-ddx-ddv-data-binding-with-windows-forms.md)  
  
 [How to: Sink Windows Forms Events from Native C++ Classes](../VS_csharp/how-to--sink-windows-forms-events-from-native-c---classes.md)  
  
## Reference  
 [CWinFormsControl Class](../VS_csharp/cwinformscontrol-class.md) &#124; [CDialog Class](../VS_csharp/cdialog-class.md) &#124; [CWnd Class](../VS_csharp/cwnd-class.md) &#124; <xref:System.Windows.Forms.Control*>  
  
## See Also  
 [Using Windows Forms in MFC](../VS_csharp/using-a-windows-form-user-control-in-mfc.md)   
 [Windows Forms/MFC Programming Differences](../VS_csharp/windows-forms-mfc-programming-differences.md)   
 [Hosting a Windows Forms User Control as an MFC View](../VS_csharp/hosting-a-windows-forms-user-control-as-an-mfc-view.md)   
 [Hosting a Windows Forms Form as an MFC Dialog Box](../VS_csharp/hosting-a-windows-form-user-control-as-an-mfc-dialog-box.md)