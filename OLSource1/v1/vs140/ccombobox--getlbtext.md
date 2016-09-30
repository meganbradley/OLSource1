---
title: "CComboBox::GetLBText"
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
  - "CComboBox.GetLBText"
  - "GetLBText"
  - "CComboBox::GetLBText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetLBText method"
ms.assetid: 63fe09d9-8df7-46eb-ae6a-f6c97bf6e750
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBox::GetLBText
Gets a string from the list box of a combo box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Contains the zero-based index of the list-box string to be copied.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Points to a buffer that is to receive the string. The buffer must have sufficient space for the string and a terminating null character.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Return Value  
 The length (in bytes) of the string, excluding the terminating null character. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> does not specify a valid index, the return value is **CB_ERR**.  
  
## Remarks  
 The second form of this member function fills a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object with the item's text.  
  
## Example  
 [!code[NVC_MFC_CComboBox#24](../vs140/codesnippet/CPP/ccombobox--getlbtext_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBox::GetLBTextLen](../vs140/ccombobox--getlbtextlen.md)   
 [CB_GETLBTEXT](http://msdn.microsoft.com/library/windows/desktop/bb775862)