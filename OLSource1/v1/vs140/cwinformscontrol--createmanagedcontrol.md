---
title: "CWinFormsControl::CreateManagedControl"
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
  - "CWinFormsControl::CreateManagedControl"
  - "CreateManagedControl"
  - "CWinFormsControl.CreateManagedControl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateManagedControl method"
ms.assetid: 066d3e8d-d912-45c7-b36b-f7a48dd75ce7
caps.latest.revision: 23
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinFormsControl::CreateManagedControl
Creates a Windows Forms control in an MFC container.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The data type of the control to be created. Must be a \<xref:System.Type*?displayProperty=fullName> data type.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The window style to apply to the control. Specify a combination of [Window Styles](../vs140/window-styles.md). Currently, only the following styles are supported: WS_TABSTOP, WS_VISIBLE, WS_DISABLED and WS_GROUP.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A [RECT Structure](../vs140/rect-structure.md) that defines the coordinates of the upper-left and lower-right corners of the control (first overload only).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The handle of the static place holder control placed in the Resource Editor. The newly created Windows Forms control replaces the static control, assuming its position, z-order, and styles (second overload only).  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A pointer to the parent window.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The resource ID number to be assigned to the newly created control.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 An instance of a Windows Forms control to be associated with the [CWinFormsControl](../vs140/cwinformscontrol-class.md) object (fourth overload only).  
  
## Return Value  
 If successful, returns a nonzero value. If unsuccessful, returns zero.  
  
## Remarks  
 This method instantiates a .NET Framework Windows Forms control in an MFC container.  
  
 The first overload of the method accepts a .NET Framework data type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> so that MFC can instantiate a new object of this type. <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> must be a \<xref:System.Type*?displayProperty=fullName> data type.  
  
 The second overload of the method creates a Windows Forms control based on the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> template parameter of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> class. The size and position of the control is based on the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> structure passed to the method. Only <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> matters for the styles.  
  
 The third overload of the method creates a Windows Forms control that replaces a static control, destroying it and assuming its position, z-order, and styles. The static control serves only as a placeholder for the Windows Forms control. When creating the control, this overload combines the styles from <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> with the static control's resource styles.  
  
 The fourth overload of the method allows you to pass in an already instantiated Windows Forms control <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> that MFC will wrap. It must be of the same type as the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> template parameter of the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> class.  
  
 See [Using a Windows Form User Control in MFC](../vs140/using-a-windows-form-user-control-in-mfc.md) for samples on using Windows Form controls.  
  
## Requirements  
 **Header:** afxwinforms.h  
  
## See Also  
 [CWinFormsControl Class](../vs140/cwinformscontrol-class.md)   
 [GetControl](../vs140/cwinformscontrol--getcontrol.md)