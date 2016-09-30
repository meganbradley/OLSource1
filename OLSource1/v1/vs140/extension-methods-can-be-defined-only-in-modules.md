---
title: "Extension methods can be defined only in modules"
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
  - "vbc36551"
  - "bc36551"
helpviewer_keywords: 
  - "BC36551"
ms.assetid: c832d523-5bf6-4baf-b91c-bd26d94453ed
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Extension methods can be defined only in modules
This error occurs when an extension method has been defined outside a module. In Visual Basic, all extension methods must be defined within standard modules.  
  
 **Error ID:** BC36551  
  
### To correct this error  
  
-   Place the extension method in a module.  
  
## Example  
 The following example extends the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> class, adding a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> method.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [NOT IN BUILD: Application of Attributes](assetId:///2b1703ed-4437-49b3-bc0b-568094324f47)   
 [Extension Methods (Visual Basic)](../vs140/extension-methods--visual-basic-.md)   
 [Module (Visual Basic)](../vs140/module--keyword---visual-basic-.md)   
 [Module Statement](../vs140/module-statement.md)