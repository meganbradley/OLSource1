---
title: "CDHtmlDialog::CDHtmlDialog"
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
  - "CDHtmlDialog.CDHtmlDialog"
  - "CDHtmlDialog::CDHtmlDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDHtmlDialog class, constructor"
ms.assetid: 8438979e-fcd9-4a3b-9b53-7c0321745c8d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDHtmlDialog::CDHtmlDialog
Constructs a resource-based dynamic HTML dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The null-terminated string that is the name of a dialog-box template resource.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The null-terminated string that is the name of an HTML resource.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the parent or owner window object (of type [CWnd](../vs140/cwnd-class.md)) to which the dialog object belongs. If it is **NULL**, the dialog object's parent window is set to the main application window.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Contains the ID number of a dialog-box template resource.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Contains the ID number of an HTML resource.  
  
## Remarks  
 The second form of the constructor provides access to the dialog resource through the template name. The third form of the constructor provides access to the dialog resource through the ID of the resource template. Usually, the ID begins with the **IDD_** prefix.  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [CDHtmlDialog Class](../vs140/cdhtmldialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDHtmlDialog::LoadFromResource](../vs140/cdhtmldialog--loadfromresource.md)