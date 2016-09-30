---
title: "CSimpleDialog Class"
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
  - "ATL::CSimpleDialog"
  - "CSimpleDialgo"
  - "CSimpleDialog"
  - "ATL.CSimpleDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSimpleDialog class"
  - "CSimpleDialog class, modal dialog boxes in ATL"
  - "dialog boxes, modal"
  - "modal dialog boxes, ATL"
ms.assetid: 2ae65cc9-4f32-4168-aecd-200b4a480fdf
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleDialog Class
This class implements a basic modal dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *t_wDlgTemplateID*  
  
 The resource ID of the dialog template resource.  
  
 *t_bCenter*  
 **TRUE** if the dialog object is to be centered on the owner window; otherwise **FALSE**.  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CSimpleDialog::DoModal](../vs140/csimpledialog--domodal.md)|Creates a modal dialog box.|  
  
## Remarks  
 Implements a modal dialog box with basic functionality. <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> provides support for Windows common controls only. To create and display a modal dialog box, create an instance of this class, providing the name of an existing resource template for the dialog box. The dialog box object closes when the user clicks any control with a pre-defined value (such as IDOK or IDCANCEL).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> allows you to create only modal dialog boxes. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> provides the dialog box procedure, which uses the default message map to direct messages to the appropriate handlers.  
  
 See [Implementing a Dialog Box](../vs140/implementing-a-dialog-box.md) for more information.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlwin.h  
  
##  \<a name="csimpledialog__domodal">\</a>  CSimpleDialog::DoModal  
 Invokes a modal dialog box and returns the dialog-box result when done.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A handle to the parent of the dialog box. If no value is provided, the parent is set to the current active window.  
  
### Return Value  
 If successful, the return value is the resource ID of the control that dismissed the dialog box.  
  
 If the function fails, the return value is –1. To get extended error information, call <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method handles all interaction with the user while the dialog box is active. This is what makes the dialog box modal; that is, the user cannot interact with other windows until the dialog box is closed.  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)