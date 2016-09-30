---
title: "Type of parameter &#39;&lt;parametername&gt;&#39; is not CLS-compliant"
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
  - "vbc40028"
  - "bc40028"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC40028"
ms.assetid: dfa1f6f9-bb88-44ad-b85f-149144363d41
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type of parameter &#39;&lt;parametername&gt;&#39; is not CLS-compliant
A procedure is marked as <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> but declares a parameter with a type that is marked as <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, is not marked, or does not qualify because it is a noncompliant type.  
  
 For a procedure to be compliant with the [Common Language Specification](assetId:///4f0b77d0-4844-464f-af73-6e06bedeafc6) (CLS), it must use only CLS-compliant types. This applies to the types of the parameters, the return type, and the types of all its local variables.  
  
 The following [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] data types are not CLS-compliant:  
  
-   [SByte Data Type (Visual Basic)](../vs140/sbyte-data-type--visual-basic-.md)  
  
-   [UInteger Data Type](../vs140/uinteger-data-type.md)  
  
-   [ULong Data Type (Visual Basic)](../vs140/ulong-data-type--visual-basic-.md)  
  
-   [UShort Data Type (Visual Basic)](../vs140/ushort-data-type--visual-basic-.md)  
  
 When you apply the \<xref:System.CLSCompliantAttribute*> to a programming element, you set the attribute's <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter to either <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to indicate compliance or noncompliance. There is no default for this parameter, and you must supply a value.  
  
 If you do not apply the \<xref:System.CLSCompliantAttribute*> to an element, it is considered to be noncompliant.  
  
 By default, this message is a warning. For information on hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC40028  
  
### To correct this error  
  
-   If the procedure must take a parameter of this particular type, remove the \<xref:System.CLSCompliantAttribute*>. The procedure cannot be CLS-compliant.  
  
-   If the procedure must be CLS-compliant, change the type of this parameter to the closest CLS-compliant type. For example, in place of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> you might be able to use <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if you do not need the value range above 2,147,483,647. If you do need the extended range, you can replace <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
-   If you are interfacing with Automation or COM objects, keep in mind that some types have different data widths than in the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)]. For example, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is often 16 bits in other environments. If you are accepting a 16-bit integer from such a component, declare it as <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> in your managed [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] code.  
  
## See Also  
 [\<PAVE OVER> Writing CLS-Compliant Code](assetId:///4c705105-69a2-4e5e-b24e-0633bc32c7f3)