---
title: "COleConvertDialog::GetSelectionType"
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
  - "COleConvertDialog.GetSelectionType"
  - "GetSelectionType"
  - "COleConvertDialog::GetSelectionType"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleConvertDialog class, operations and attributes"
  - "GetSelectionType method"
ms.assetid: ba39c5e5-9102-4f6a-bd6c-f76fa0b18c70
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleConvertDialog::GetSelectionType
Call this function to determine the type of conversion selected in the Convert dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Type of selection made.  
  
## Remarks  
 The return type values are specified by the **Selection** enumeration type declared in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> class.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 Brief descriptions of these values follow:  
  
-   **COleConvertDialog::noConversion** Returned if either the dialog box was canceled or the user selected no conversion. If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> returned **IDOK**, it is possible that the user selected a different icon than the one previously selected.  
  
-   **COleConvertDialog::convertItem** Returned if the Convert To radio button was checked, the user selected a different item to convert to, and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> returned **IDOK**.  
  
-   **COleConvertDialog::activateAs** Returned if the Activate As radio button was checked, the user selected a different item to activate, and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> returned **IDOK**.  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COleConvertDialog Class](../vs140/coleconvertdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleConvertDialog::DoModal](../vs140/coleconvertdialog--domodal.md)   
 [COleConvertDialog::COleConvertDialog](../vs140/coleconvertdialog--coleconvertdialog.md)