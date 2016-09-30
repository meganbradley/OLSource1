---
title: "CTaskDialog::SetMainIcon"
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
  - "SetMainIcon"
  - "CTaskDialog::SetMainIcon"
  - "CTaskDialog.SetMainIcon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetMainIcon method"
ms.assetid: c0250952-640f-4cba-8cec-ee329b3c6b9a
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::SetMainIcon
Updates the main icon of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The new icon.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The new icon.  
  
## Remarks  
 This method throws an exception with the [ENSURE (MFC)](../vs140/ensure--mfc-.md) macro if the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is displayed or the input parameter is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 A <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> can only accept an <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> as a main icon. You can configure this by setting the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> option in the constructor or in the [CTaskDialog::SetOptions](../vs140/ctaskdialog--setoptions.md) method. By default, the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is configured to use <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> as the input type for the main icon. This method generates an exception if you try to set the icon using the inappropriate type.  
  
## Example  
 [!code[NVC_MFC_CTaskDialog#7](../vs140/codesnippet/CPP/ctaskdialog--setmainicon_1.cpp)]  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::SetOptions](../vs140/ctaskdialog--setoptions.md)