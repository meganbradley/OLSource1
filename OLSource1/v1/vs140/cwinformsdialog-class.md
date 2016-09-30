---
title: "CWinFormsDialog Class"
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
  - "CWinFormsDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MFC [C++], Windows Forms support"
  - "CWinFormsDialog class"
  - "Windows Forms [C++], MFC support"
ms.assetid: e3cec000-a578-448e-b06a-8af256312f61
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinFormsDialog Class
A wrapper for an MFC dialog class that hosts a Windows Forms user control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The .NET Framework user control to be displayed in the MFC application.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CWinFormsDialog::CWinFormsDialog](#cwinformsdialog__cwinformsdialog)|Constructs a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CWinFormsDialog::GetControl](#cwinformsdialog__getcontrol)|Retrieves a reference to the Windows Forms user control.|  
|[CWinFormsDialog::GetControlHandle](#cwinformsdialog__getcontrolhandle)|Retrieves a window handle to the Windows Forms user control.|  
|[CWinFormsDialog::OnInitDialog](#cwinformsdialog__oninitdialog)|Initializes the MFC dialog box by creating and hosting a Windows Forms user control on it.|  
  
### Public Operators  
  
|Name||  
|----------|-|  
|[CWinFormsDialog::operator -&gt;](#cwinformsdialog__operator_-_gt_)|Replaces [GetControl](#cwinformsdialog__getcontrol) in expressions.|  
|[CWinFormsDialog::operator TManagedControl^](#cwinformsdialog__operator_tmanagedcontrol^)|Casts a type as a reference to a Windows Forms user control.|  
  
## Remarks  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is a wrapper for an MFC dialog class ( [CDialog](../vs140/cdialog-class.md)) that hosts a Windows Forms ( \<xref:System.Windows.Forms.UserControl*>) user control. This allows the display of .NET Framework controls on a modal or modeless MFC dialog box.  
  
 For more information on using Windows Forms, see [Using Windows Forms in MFC](../vs140/using-a-windows-form-user-control-in-mfc.md) and [Hosting a Windows Form User Control as an MFC Dialog Box](../vs140/hosting-a-windows-form-user-control-as-an-mfc-dialog-box.md).  
  
## Requirements  
 **Header:** afxwinforms.h  
  
##  \<a name="cwinformsdialog__cwinformsdialog">\</a>  CWinFormsDialog::CWinFormsDialog  
 Constructs a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Contains the ID of a dialog box template resource. Use the dialog editor to create the dialog template and store it in the application's resource script file. For more information on dialog templates, see [CDialog Class](../vs140/cdialog-class.md).  
  
##  \<a name="cwinformsdialog__getcontrol">\</a>  CWinFormsDialog::GetControl  
 Retrieves a reference to the Windows Forms user control.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 Returns a reference to the \<xref:System.Windows.Forms.UserControl*> control in the MFC dialog box.  
  
##  \<a name="cwinformsdialog__getcontrolhandle">\</a>  CWinFormsDialog::GetControlHandle  
 Retrieves a window handle to the Windows Forms user control.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 Returns a window handle to the Windows Forms user control.  
  
##  \<a name="cwinformsdialog__oninitdialog">\</a>  CWinFormsDialog::OnInitDialog  
 Initializes the MFC dialog box by creating and hosting a Windows Forms user control on it.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A boolean value that specifies whether the application has set the input focus to one of the controls in the dialog box. If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> returns nonzero, Windows sets the input focus to the first control in the dialog box. This method can return 0 only if the application has explicitly set the input focus to one of the controls in the dialog box.  
  
### Remarks  
 When the MFC dialog box is created (using the [Create](../vs140/cdialog-class.md#cdialog__create), [CreateIndirect](../vs140/cdialog-class.md#cdialog__createindirect), or [DoModal](../vs140/cdialog-class.md#cdialog__domodal) method inherited from [CDialog](../vs140/cdialog-class.md)), a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> message is sent and this method is called. It creates an instance of a \<xref:System.Windows.Forms.UserControl*> control on the dialog box and adjusts the size of the dialog box to accommodate for the size of the user control. Then it hosts the new control in the MFC dialog box.  
  
 Override this member function if you need to perform special processing when the dialog box is initialized. For more information on using this method, see [CDialog::OnInitDialog](../vs140/cdialog-class.md#cdialog__oninitdialog).  
  
##  \<a name="cwinformsdialog__operator_-_gt_">\</a>  CWinFormsDialog::operator -&gt;  
 Replaces [GetControl](#cwinformsdialog__getcontrol) in expressions.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 This operator provides a convenient syntax that replaces <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> in expressions.  
  
 For information on using Windows Forms, see [Using a Windows Form User Control in MFC](../vs140/using-a-windows-form-user-control-in-mfc.md).  
  
##  \<a name="cwinformsdialog__operator_tmanagedcontrol_xor">\</a>  CWinFormsDialog::operator TManagedControl^  
 Casts a type as a reference to a Windows Forms user control.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 This operator casts a type as a reference to a \<xref:System.Windows.Forms.UserControl*> control. It is used to pass a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> dialog box to functions that accept a pointer to a Windows Forms user control object.  
  
## See Also  
 \<xref:System.Windows.Forms.UserControl*?displayProperty=fullName>   
 [CWnd Class](../vs140/cwnd-class.md)   
 [CWinFormsView Class](../vs140/cwinformsview-class.md)   
 [CDialog Class](../vs140/cdialog-class.md)