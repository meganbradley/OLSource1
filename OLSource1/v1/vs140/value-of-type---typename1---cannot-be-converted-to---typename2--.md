---
title: "Value of type &#39;&lt;typename1&gt;&#39; cannot be converted to &#39;&lt;typename2&gt;&#39;"
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
  - "vbc30955"
  - "bc30955"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC30955"
ms.assetid: 966b61eb-441e-48b0-bedf-ca95384ecb8b
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Value of type &#39;&lt;typename1&gt;&#39; cannot be converted to &#39;&lt;typename2&gt;&#39;
Value of type '<typename1\>' cannot be converted to '<typename2\>'. Type mismatch could be due to the mixing of a file reference with a project reference to assembly '<assemblyname\>'. Try replacing the file reference to '<filepath\>' in project '<projectname1\>' with a project reference to '<projectname2\>'.  
  
 In a situation where a project makes both a project reference and a file reference, the compiler cannot guarantee that one type can be converted to another.  
  
 The following pseudo-code illustrates a situation that can generate this error.  
  
 `' ================ Visual Basic project P1 ================`  
  
 `'        P1 makes a PROJECT REFERENCE to project P2`  
  
 `'        and a FILE REFERENCE to project P3.`  
  
 `Public commonObject As P3.commonClass`  
  
 `commonObject = P2.getCommonClass()`  
  
 `' ================ Visual Basic project P2 ================`  
  
 `'        P2 makes a PROJECT REFERENCE to project P3`  
  
 `Public Function getCommonClass() As P3.commonClass`  
  
 `Return New P3.commonClass`  
  
 `End Function`  
  
 `' ================ Visual Basic project P3 ================`  
  
 `Public Class commonClass`  
  
 `End Class`  
  
 Project `P1` makes an indirect project reference through project `P2` to project `P3`, and also a direct file reference to `P3`. The declaration of `commonObject` uses the file reference to `P3`, while the call to `P2.getCommonClass` uses the project reference to `P3`.  
  
 The problem in this situation is that the file reference specifies a file path and name for the output file of `P3` (typically p3.dll), while the project references identify the source project (`P3`) by project name. Because of this, the compiler cannot guarantee that the type `P3.commonClass` comes from the same source code through the two different references.  
  
 This situation typically occurs when project references and file references are mixed. In the preceding illustration, the problem would not occur if `P1` made a direct project reference to `P3` instead of a file reference.  
  
 **Error ID:** BC30955  
  
### To correct this error  
  
-   Change the file reference to a project reference.  
  
## See Also  
 [Type Conversions in Visual Basic](../vs140/type-conversions-in-visual-basic.md)   
 [Managing Project References](../vs140/managing-references-in-a-project.md)   
 [NIB How to: Add or Remove References By Using the Add Reference Dialog Box](assetId:///3bd75d61-f00c-47c0-86a2-dd1f20e231c9)