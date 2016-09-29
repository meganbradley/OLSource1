---
title: "Expression recursively calls the containing property &#39;&lt;propertyname&gt;&#39;"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbc42026"
  - "BC42026"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC42026"
ms.assetid: 4fde9db6-3bf3-48dc-8e05-981bf08969da
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expression recursively calls the containing property &#39;&lt;propertyname&gt;&#39;
A statement in the `Set` procedure of a property definition stores a value into the name of the property.  
  
 The recommended approach to holding the value of a property is to define a `Private` variable in the property's container and use it in both the `Get` and `Set` procedures. The `Set` procedure should then store the incoming value in this `Private` variable.  
  
 The `Get` procedure behaves like a `Function` procedure, so it can assign a value to the property name and return control by encountering the `End Get` statement. The recommended approach, however, is to include the `Private` variable as the value in a [Return Statement (Visual Basic)](../vs140/return-statement--visual-basic-.md).  
  
 The `Set` procedure behaves like a `Sub` procedure, which does not return a value. Therefore, the procedure or property name has no special meaning within a `Set` procedure, and you cannot store a value into it.  
  
 The following example illustrates the approach that can cause this error, followed by the recommended approach.  
  
```  
Public Class illustrateProperties  
' The code in the following property causes this error.  
    Public Property badProp() As Char  
        Get  
            Dim charValue As Char  
            ' Insert code to update charValue.  
            badProp = charValue  
        End Get  
        Set(ByVal Value As Char)  
            ' The following statement causes this error.  
            badProp = Value  
            ' The value stored in the local variable badProp  
            ' is not used by the Get procedure in this property.  
        End Set  
    End Property  
' The following code uses the recommended approach.  
    Private propValue As Char  
    Public Property goodProp() As Char  
        Get  
            ' Insert code to update propValue.  
            Return propValue  
        End Get  
        Set(ByVal Value As Char)  
            propValue = Value  
        End Set  
    End Property  
End Class  
```  
  
 By default, this message is a warning. For more information about hiding warnings or treating warnings as errors, please see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC42026  
  
### To correct this error  
  
-   Rewrite the property definition to use the recommended approach as illustrated in the preceding example.  
  
## See Also  
 [Property Procedures](../vs140/property-procedures--visual-basic-.md)   
 [Property Statement](../vs140/property-statement.md)   
 [Set Statement (Visual Basic)](../vs140/set-statement--visual-basic-.md)