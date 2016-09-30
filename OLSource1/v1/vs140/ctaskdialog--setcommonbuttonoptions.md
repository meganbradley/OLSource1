---
title: "CTaskDialog::SetCommonButtonOptions"
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
  - "CTaskDialog::SetCommonButtonOptions"
  - "SetCommonButtonOptions"
  - "CTaskDialog.SetCommonButtonOptions"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetCommonButtonOptions method"
ms.assetid: 6f9a36e2-41f8-4033-94a5-991a51db2150
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::SetCommonButtonOptions
Updates a subset of common buttons to be enabled and to require UAC elevation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A mask for the common buttons to disable.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A mask for the common buttons that require elevation.  
  
## Remarks  
 You can set the common buttons available to an instance of the [CTaskDialog Class](../vs140/ctaskdialog-class.md) by using the constructor [CTaskDialog::CTaskDialog](../vs140/ctaskdialog--ctaskdialog.md) and the method [CTaskDialog::SetCommonButtons](../vs140/ctaskdialog--setcommonbuttons.md). <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> does not support adding new common buttons.  
  
 If you use this method to disable or elevate a common button that is not available for this <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, this method throws an exception by using the [ENSURE (MFC)](../vs140/ensure--mfc-.md) macro.  
  
 This method enables any button that is available to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> but is not in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, even if it was previously disabled. This method treats elevation in a similar manner: it records common buttons as not requiring elevation if the common button is available but not included in <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Example  
 [!code[NVC_MFC_CTaskDialog#6](../vs140/codesnippet/CPP/ctaskdialog--setcommonbuttonoptions_1.cpp)]  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::CTaskDialog](../vs140/ctaskdialog--ctaskdialog.md)   
 [CTaskDialog::SetCommonButtons](../vs140/ctaskdialog--setcommonbuttons.md)