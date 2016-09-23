---
title: "CListBox::GetText"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CListBox::GetText
  - CListBox.GetText
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetText method
  - CListBox class, general operations
ms.assetid: 6b81780d-2e93-4dd4-835d-44a2e442bc93
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CListBox::GetText
Gets a string from a list box.  
  
## Syntax  
  
```  
  
      int GetText(  
   int nIndex,  
   LPTSTR lpszBuffer   
) const;  
void GetText(  
   int nIndex,  
   CString& rString   
) const;  
```  
  
#### Parameters  
 `nIndex`  
 Specifies the zero-based index of the string to be retrieved.  
  
 `lpszBuffer`  
 Points to the buffer that receives the string. The buffer must have sufficient space for the string and a terminating null character. The size of the string can be determined ahead of time by calling the `GetTextLen` member function.  
  
 `rString`  
 A reference to a `CString` object.  
  
## Return Value  
 The length (in bytes) of the string, excluding the terminating null character. If `nIndex` does not specify a valid index, the return value is **LB_ERR**.  
  
## Remarks  
 The second form of this member function fills a `CString` object with the string text.  
  
## Example  
 [!code[NVC_MFC_CListBox#21](../vs140/codesnippet/CPP/clistbox--gettext_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListBox::GetTextLen](../vs140/clistbox--gettextlen.md)   
 [LB_GETTEXT](http://msdn.microsoft.com/library/windows/desktop/bb761313)