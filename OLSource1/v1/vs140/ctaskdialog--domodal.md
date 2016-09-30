---
title: "CTaskDialog::DoModal"
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
  - "CTaskDialog::DoModal"
  - "CTaskDialog.DoModal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DoModal method"
ms.assetid: 397dcad6-305e-4341-84b9-356091d301be
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::DoModal
Shows the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and makes it modal.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The parent window for the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Return Value  
 An integer that corresponds to the selection made by the user.  
  
## Remarks  
 Displays this instance of the [CTaskDialog](../vs140/ctaskdialog-class.md). The application then waits for the user to close the dialog box.  
  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> closes when the user selects a common button, a command link control, or closes the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. The return value is the identifier that indicates how the user closed the dialog box.  
  
## Example  
 [!code[NVC_MFC_CTaskDialog#7](../vs140/codesnippet/CPP/ctaskdialog--domodal_1.cpp)]  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)