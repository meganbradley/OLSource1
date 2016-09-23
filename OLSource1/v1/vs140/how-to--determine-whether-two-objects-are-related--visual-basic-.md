---
title: "How to: Determine Whether Two Objects Are Related (Visual Basic)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - VB
helpviewer_keywords: 
  - inheritance, Visual Basic objects
  - objects [Visual Basic], inheritance
  - object variables, determining relation
ms.assetid: da002e3f-6616-4bad-a229-f842d06652bb
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Determine Whether Two Objects Are Related (Visual Basic)
You can compare two objects to determine the relationship, if any, between the classes from which they are created. The <xref:System.Type.IsInstanceOfType?qualifyHint=False> method of the <xref:System.Type?qualifyHint=True> class returns `True` if the specified class inherits from the current class, or if the current type is an interface supported by the specified class.  
  
### To determine if one object inherits from another object's class or interface  
  
1.  On the object you think might be of the base type, invoke the <xref:System.Object.GetType?qualifyHint=False> method.  
  
2.  On the <xref:System.Type?qualifyHint=True> object returned by <xref:System.Object.GetType?qualifyHint=False>, invoke the <xref:System.Type.IsInstanceOfType?qualifyHint=False> method.  
  
3.  In the argument list for <xref:System.Type.IsInstanceOfType?qualifyHint=False>, specify the object you think might be of the derived type.  
  
     <xref:System.Type.IsInstanceOfType?qualifyHint=False> returns `True` if its argument type inherits from the <xref:System.Type?qualifyHint=True> object type.  
  
## Example  
 The following example determines whether one object represents a class derived from another object's class.  
  
```  
Public Class baseClass  
End Class  
Public Class derivedClass : Inherits baseClass  
End Class  
Public Class testTheseClasses  
    Public Sub seeIfRelated()  
        Dim baseObj As Object = New baseClass()  
        Dim derivedObj As Object = New derivedClass()  
        Dim related As Boolean  
        related = baseObj.GetType().IsInstanceOfType(derivedObj)  
        MsgBox(CStr(related))  
    End Sub  
End Class  
```  
  
 Note the unexpected placement of the two object variables in the call to <xref:System.Type.IsInstanceOfType?qualifyHint=False>. The supposed base type is used to generate the <xref:System.Type?qualifyHint=True> class, and the supposed derived type is passed as an argument to the <xref:System.Type.IsInstanceOfType?qualifyHint=False> method.  
  
## See Also  
 <xref:System.Object.GetType?qualifyHint=False>   
 <xref:System.Type?qualifyHint=True>   
 <xref:System.Type.IsInstanceOfType?qualifyHint=False>   
 [Object Data Type](../vs140/object-data-type.md)   
 [Object Variables in Visual Basic](../vs140/object-variables-in-visual-basic.md)   
 [Object Variable Values](../vs140/object-variable-values--visual-basic-.md)   
 [How to: Determine Whether Two Objects Are Identical](../vs140/how-to--determine-whether-two-objects-are-identical--visual-basic-.md)