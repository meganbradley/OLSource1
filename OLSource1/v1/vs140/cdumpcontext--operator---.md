---
title: "CDumpContext::operator &lt;&lt;"
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
  - "CDumpContext.operator<<"
  - "CDumpContext::operator<<"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "<< operator"
  - "operator <<, data to dump context"
  - "CDumpContext class, basic input/output"
  - "operator<<, data to dump context"
  - "CDumpContext class, operators"
ms.assetid: deba7768-7f68-4e54-b4f8-eb554ba767a2
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDumpContext::operator &lt;&lt;
Outputs the specified data to the dump context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> reference. Using the return value, you can write multiple insertions on a single line of source code.  
  
## Remarks  
 The insertion operator is overloaded for <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> pointers as well as for most primitive types. A pointer to character results in a dump of string contents; a pointer to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> results in a hexadecimal dump of the address only. A **LONGLONG** results in a dump of a 64-bit signed integer; A **ULONGLONG** results in a dump of a 64-bit unsigned integer.  
  
 If you use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> macro in the implementation of your class, then the insertion operator, through <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, will print the name of your <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>-derived class. Otherwise, it will print <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. If you override the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function of the class, then you can provide a more meaningful output of the object's contents instead of a hexadecimal dump.  
  
## Example  
 [!code[NVC_MFC_Utilities#17](../vs140/codesnippet/CPP/cdumpcontext--operator---_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CDumpContext Class](../vs140/cdumpcontext-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)