---
title: "Type &#39;&lt;typename&gt;&#39; is not defined"
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
  - "vbc30002"
  - "bc30002"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC30002"
ms.assetid: b0faf204-57fd-44de-8c05-9db027eea663
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type &#39;&lt;typename&gt;&#39; is not defined
The statement has made reference to a type that has not been defined. You can define a type in a declaration statement such as `Enum`, `Structure`, `Class`, or `Interface`.  
  
 **Error ID:** BC30002  
  
### To correct this error  
  
-   Ensure that the type definition and its reference both use the same spelling.  
  
-   Ensure that the type definition is accessible to the reference. For example, if the type is in another module and has been declared `Private`, move the type definition to the referencing module or declare it `Public`.  
  
-   Ensure that the namespace of the type is not redefined within your project. If it is, use the `Global` keyword to fully qualify the type name. For example, if a project defines a namespace named `System`, the <xref:System.Object*?displayProperty=fullName> type cannot be accessed unless it is fully qualified with the `Global` keyword: `Global.System.Object`.  
  
-   If the type is defined, but the object library or type library in which it is defined is not registered in [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)], click **Add Reference** on the **Project** menu, and then select the appropriate object library or type library.  
  
-   Ensure that the type is in an assembly that is part of the targeted .NET Framework profile. For more information, see [Troubleshooting .NET Framework Targeting Errors](../VS_csharp/troubleshooting-.net-framework-targeting-errors.md).  
  
## See Also  
 [Namespaces in Visual Basic](../VS_csharp/namespaces-in-visual-basic.md)   
 [Enum Statement](../VS_csharp/enum-statement--visual-basic-.md)   
 [Structure Statement](../VS_csharp/structure-statement.md)   
 [Class Statement](../VS_csharp/class-statement--visual-basic-.md)   
 [Interface Statement](../VS_csharp/interface-statement--visual-basic-.md)   
 [Project References](../VS_csharp/managing-references-in-a-project.md)