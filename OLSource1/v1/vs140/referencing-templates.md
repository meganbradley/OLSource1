---
title: "Referencing Templates"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: 593ca6aa-6e17-41f6-8ec3-d7e11c31bf1d
caps.latest.revision: 9
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Referencing Templates
This topic shows how to use a template that has been previously declared.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The *template-arg-list* should be a comma-separated list of:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 All *expression* arguments must be constant expressions. The compiler creates a new instance (called an instantiation) of the templated class or function if there is no exact match to a previously generated template. For example, to reference the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> class defined in [Member Function Templates](../vs140/member-function-templates.md):  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Each generated function template creates its own static variables and members.  
  
 All template arguments must be accessible at the point where they are used.  
  
 The exception to the above syntax rule is in identifying a member template specialization in an expression after the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, **.** or **->** operators. After these operators, the keyword <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> can be specified. Visual C++ departs from the standard in that the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> keyword is always optional in this context, whereas the standard requires it in some circumstances. The template keyword cannot be used in the specialization unless following these operators.  
  
 [ **::** &#124; **->** &#124; **.** ] **template***template*-*name***<***template*-<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>-<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>**>**  
  
 For example, the following specifies a call to the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> specialization of the member function template <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> which is a member of the class <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and passes it the parameter <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Templates](../vs140/templates--c---.md)