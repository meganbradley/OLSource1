---
title: "CFindReplaceDialog::CFindReplaceDialog"
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
  - "CFindReplaceDialog::CFindReplaceDialog"
  - "CFindReplaceDialog.CFindReplaceDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFindReplaceDialog class, constructor"
  - "CFindReplaceDialog class, construction/destruction"
ms.assetid: b900e5ef-719f-49b0-992e-531d332ca951
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFindReplaceDialog::CFindReplaceDialog
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Because the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object is a modeless dialog box, you must construct it on the heap by using the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> operator.  
  
 During destruction, the framework tries to perform a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> on the pointer to the dialog box. If you created the dialog box on the stack, the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> pointer does not exist and undefined behavior may result.  
  
 For more information on the construction of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> objects, see the [CFindReplaceDialog](../vs140/cfindreplacedialog-class.md) overview. Use the [CFindReplaceDialog::Create](../vs140/cfindreplacedialog--create.md) member function to display the dialog box.  
  
## Example  
 [!code[NVC_MFCDocView#170](../vs140/codesnippet/CPP/cfindreplacedialog--cfindreplacedialog_1.cpp)]  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFindReplaceDialog Class](../vs140/cfindreplacedialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFindReplaceDialog::Create](../vs140/cfindreplacedialog--create.md)