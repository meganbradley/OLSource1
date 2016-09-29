---
title: "XML literal cannot appear here unless it is enclosed in parentheses"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "bc31198"
  - "vbc31198"
helpviewer_keywords: 
  - "BC31198"
ms.assetid: 97b16076-39ff-430a-9c65-073d01bcb08e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# XML literal cannot appear here unless it is enclosed in parentheses
An XML literal declaration is used in an expression in a location that is ambiguous to the [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compiler. That is, the [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compiler cannot determine whether the less-than character (<) is intended as a comparative operator or the start of an XML literal. The following code provides an example:  
  
 [Visual Basic]  
  
```  
' Generates an error.  
Dim queryResult = From element In elements _  
                  Where <sample>Value</sample> = "Value" _  
                  Select element  
```  
  
 **Error ID:** BC31198  
  
### To correct this error  
  
-   Enclose the XML literal declaration in parentheses, as shown in the following example:  
  
    ```vb#  
    Dim queryResult = From element In elements _  
                      Where (<sample> Value</sample>) = "Value" _  
                      Select element  
    ```  
  
-   Modify your code to refer to an existing XML literal, as shown in the following example:  
  
    ```vb#  
    Dim queryResult = From element In elements _  
                      Where e.<sample>.Value = "Value" _  
                      Select element  
    ```  
  
## See Also  
 [XML Literals](../vs140/xml-literals--visual-basic-.md)   
 [XML Axis Properties](../vs140/xml-axis-properties--visual-basic-.md)   
 [XML in Visual Basic](../vs140/xml-in-visual-basic.md)