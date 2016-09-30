---
title: "COleControlContainer::GetDlgItemInt"
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
  - "COleControlContainer.GetDlgItemInt"
  - "COleControlContainer::GetDlgItemInt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleControlContainer class, overridables"
  - "GetDlgItemInt method"
ms.assetid: a866a031-77b3-4deb-a708-006940eb40b7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlContainer::GetDlgItemInt
Retrieves the value of the translated text of the given control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The identifier of the control.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to a Boolean variable that receives a function success/failure value (**TRUE** indicates success, **FALSE** indicates failure).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies whether the function should examine the text for a minus sign at the beginning and return a signed integer value if it finds one. If the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter is **TRUE**, specifying that the value to be retrieved is a signed integer value, cast the return value to an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> type. To get extended error information, call [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360).  
  
## Return Value  
 If successful, the variable pointed to by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is set to **TRUE**, and the return value is the translated value of the control text.  
  
 If the function fails, the variable pointed to by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is set to **FALSE**, and the return value is zero. Note that, since zero is a possible translated value, a return value of zero does not by itself indicate failure.  
  
 If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is **NULL**, the function returns no information about success or failure.  
  
## Remarks  
 The function translates the retrieved text by stripping any extra spaces at the beginning of the text and then converting the decimal digits. The function stops translating when it reaches the end of the text or encounters a nonnumeric character.  
  
 This function returns zero if the translated value is greater than **INT_MAX** (for signed numbers) or **UINT_MAX** (for unsigned numbers).  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlContainer Class](../vs140/colecontrolcontainer-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)