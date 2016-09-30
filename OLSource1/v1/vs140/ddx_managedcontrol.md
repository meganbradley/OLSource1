---
title: "DDX_ManagedControl"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "DDX_ManagedControl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDX_ManagedControl function"
ms.assetid: 61b55a90-c993-478e-9dea-db27fbf0e193
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDX_ManagedControl
Creates a .NET control matching the control's resource ID.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a [CDataExchange](../vs140/cdataexchange-class.md) object. The framework supplies this object to establish the context of the data exchange, including its direction.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The resource ID of the control associated with the control property.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A reference to a [CWinFormsControl](../vs140/cwinformscontrol-class.md) object.  
  
## Remarks  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> calls [CWinFormsControl::CreateManagedControl](../vs140/cwinformscontrol--createmanagedcontrol.md) to create a control matching the resource control ID. Use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to create controls from resource IDs in [CDialog::OnInitDialog](../vs140/cdialog--oninitdialog.md). For data exchange, you do not need to use the DDX/DDV functions with Windows Forms controls.  
  
 For more information, see [How To: Do DDX/DDV Data Binding with Windows Forms](../vs140/how-to--do-ddx-ddv-data-binding-with-windows-forms.md).  
  
## Requirements  
 **Header:** afxwinforms.h  
  
## See Also  
 [CWinFormsControl::CreateManagedControl](../vs140/cwinformscontrol--createmanagedcontrol.md)   
 [CDialog::OnInitDialog](../vs140/cdialog--oninitdialog.md)