---
title: "Type parameters cannot be used as qualifiers"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vbc32098
  - bc32098
dev_langs: 
  - VB
helpviewer_keywords: 
  - BC32098
ms.assetid: bab05325-dde8-4621-a5f6-368b5b7b2d76
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Type parameters cannot be used as qualifiers
A programming element is qualified with a qualification string that includes a type parameter.  
  
 A type parameter represents a requirement for a type that is to be supplied when the generic type is constructed. It does not represent a specific defined type. A qualification string must include only elements that are defined at compile time.  
  
 The following statements can generate this error.  
  
```  
Public Function checkText(Of c As System.Windows.Forms.Control)(  
    ByVal badText As String) As Boolean  
  
    Dim saveText As c.Text  
    ' Insert code to look for badText within saveText.  
End Function  
```  
  
 **Error ID:** BC32098  
  
### To correct this error  
  
1.  Remove the type parameter from the qualification string, or replace it with a defined type.  
  
2.  If you need to use a constructed type to locate the programming element being qualified, you must use additional program logic.  
  
## See Also  
 [References to Declared Elements](../vs140/references-to-declared-elements--visual-basic-.md)   
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [Type List](../vs140/type-list--visual-basic-.md)