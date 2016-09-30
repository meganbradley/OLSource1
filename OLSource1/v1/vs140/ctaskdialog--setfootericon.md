---
title: "CTaskDialog::SetFooterIcon"
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
  - "CTaskDialog::SetFooterIcon"
  - "SetFooterIcon"
  - "CTaskDialog.SetFooterIcon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetFooterIcon method"
ms.assetid: ace3f2a5-9def-4371-9ef6-a7735193b55b
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::SetFooterIcon
Updates the footer icon of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The new icon for the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The new icon for the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 The footer icon is displayed on the bottom of the [CTaskDialog Class](../vs140/ctaskdialog-class.md). It can have associated footer text. You can change the footer text with [CTaskDialog::SetFooterText](../vs140/ctaskdialog--setfootertext.md).  
  
 This method throws an exception with the [ENSURE (MFC)](../vs140/ensure--mfc-.md) macro if the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is displayed or the input parameter is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 A <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> can only accept an <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> as a footer icon. This is configured by setting the option <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> in the constructor or [CTaskDialog::SetOptions](../vs140/ctaskdialog--setoptions.md). By default, the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is configured to use <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> as the input type for the footer icon. This method generates an exception if you try to set the icon using the inappropriate type.  
  
## Example  
 [!code[NVC_MFC_CTaskDialog#7](../vs140/codesnippet/CPP/ctaskdialog--setfootericon_1.cpp)]  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::CTaskDialog](../vs140/ctaskdialog--ctaskdialog.md)   
 [CTaskDialog::SetFooterText](../vs140/ctaskdialog--setfootertext.md)