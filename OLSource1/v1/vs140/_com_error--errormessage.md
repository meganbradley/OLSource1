---
title: "_com_error::ErrorMessage"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "_com_error::ErrorMessage"
  - "_com_error.ErrorMessage"
  - "ErrorMessage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ErrorMessage method"
ms.assetid: e47335b6-01af-4975-a841-121597479eb7
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _com_error::ErrorMessage
**Microsoft Specific**  
  
 Retrieves the string message for <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> stored in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns the string message for the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> recorded within the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object. If the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is a mapped 16-bit [wCode](../vs140/_com_error--wcode.md), then a generic message "<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>" is returned. If no message is found, then a generic message "<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>" is returned. The returned string is either a Unicode or multibyte string, depending on the state of the **_UNICODE** macro.  
  
## Remarks  
 Retrieves the appropriate system message text for <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> recorded within the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object. The system message text is obtained by calling the Win32 [FormatMessage](http://msdn.microsoft.com/library/windows/desktop/ms679351) function. The string returned is allocated by the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> API, and it is released when the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object is destroyed.  
  
 **END Microsoft Specific**  
  
## See Also  
 [_com_error Class](../vs140/_com_error-class.md)