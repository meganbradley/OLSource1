---
title: "CStringT::Format"
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
  - "ATL.CStringT.Format"
  - "CStringT.Format"
  - "CStringT::Format"
  - "ATL::CStringT::Format"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Format method"
ms.assetid: 6fa4ea8f-9957-4aa6-b242-5abfa524c0a9
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringT::Format
Writes formatted data to a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> in the same way that [sprintf_s](../vs140/sprintf_s--_sprintf_s_l--swprintf_s--_swprintf_s_l.md) formats data into a C-style character array.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The string resource identifier that contains the format-control string.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A format-control string.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Optional arguments.  
  
## Remarks  
 This function formats and stores a series of characters and values in the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Each optional argument (if any) is converted and output according to the corresponding format specification in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or from the string resource identified by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 The call will fail if the string object itself is offered as a parameter to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. For example, the following code will cause unpredictable results:  
  
 [!code[NVC_ATLMFC_Utilities#116](../vs140/codesnippet/CPP/cstringt--format_1.cpp)]  
  
 For more information, see [Format Specification Syntax: printf and wprintf Functions](../vs140/format-specification-syntax--printf-and-wprintf-functions.md).  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#117](../vs140/codesnippet/CPP/cstringt--format_2.cpp)]  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)   
 [sprintf_s, _sprintf_s_l, swprintf_s, _swprintf_s_l](../vs140/sprintf_s--_sprintf_s_l--swprintf_s--_swprintf_s_l.md)