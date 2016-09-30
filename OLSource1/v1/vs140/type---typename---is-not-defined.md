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
The statement has made reference to a type that has not been defined. You can define a type in a declaration statement such as <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 **Error ID:** BC30002  
  
### To correct this error  
  
-   Ensure that the type definition and its reference both use the same spelling.  
  
-   Ensure that the type definition is accessible to the reference. For example, if the type is in another module and has been declared <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, move the type definition to the referencing module or declare it <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
-   Ensure that the namespace of the type is not redefined within your project. If it is, use the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> keyword to fully qualify the type name. For example, if a project defines a namespace named <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, the \<xref:System.Object*?displayProperty=fullName> type cannot be accessed unless it is fully qualified with the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> keyword: <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
-   If the type is defined, but the object library or type library in which it is defined is not registered in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)], click **Add Reference** on the **Project** menu, and then select the appropriate object library or type library.  
  
-   Ensure that the type is in an assembly that is part of the targeted .NET Framework profile. For more information, see [Troubleshooting .NET Framework Targeting Errors](../vs140/troubleshooting-.net-framework-targeting-errors.md).  
  
## See Also  
 [Namespaces in Visual Basic](../vs140/namespaces-in-visual-basic.md)   
 [Enum Statement](../vs140/enum-statement--visual-basic-.md)   
 [Structure Statement](../vs140/structure-statement.md)   
 [Class Statement](../vs140/class-statement--visual-basic-.md)   
 [Interface Statement](../vs140/interface-statement--visual-basic-.md)   
 [Project References](../vs140/managing-references-in-a-project.md)