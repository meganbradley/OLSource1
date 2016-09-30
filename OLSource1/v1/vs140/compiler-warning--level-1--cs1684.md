---
title: "Compiler Warning (level 1) CS1684"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS1684"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1684"
ms.assetid: 620419bf-b6d5-4cda-a549-fcacf2f08920
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) CS1684
Reference to type 'Type Name' claims it is defined in 'Namespace', but it could not be found  
  
 This error can be caused by a reference inside one namespace referring to a type that it says exists inside a second namespace, but the type does not exist. For example, mydll.dll says that type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> exists inside yourdll.dll, but no such type exists inside yourdll.dll. One possible cause of this error is that the version of yourdll.dll you are using is too old and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> has not yet been defined.  
  
 The following sample generates CS1684.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 We now rebuild the first assembly, leaving out the definition of the class C2 not to be defined in the recompilation.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
 This module references the second module by means of the identifier <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. But the second module contains a reference to the class <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, which no longer exists because of the compilation in the previous step, and therefore the CS1684 error message is returned from the compilation of this module.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>