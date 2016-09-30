---
title: "Type of optional value for optional parameter &lt;parametername&gt; is not CLS-compliant"
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
  - "BC40042"
  - "vbc40042"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC40042"
ms.assetid: 1d6eae29-4ad3-4434-bde4-a53b6051adf5
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type of optional value for optional parameter &lt;parametername&gt; is not CLS-compliant
A procedure is marked as `<CLSCompliant(True)>` but declares an [Optional (Visual Basic)](../vs140/optional--visual-basic-.md) parameter with default value of a noncompliant type.  
  
 For a procedure to be compliant with the [Common Language Specification](assetId:///4f0b77d0-4844-464f-af73-6e06bedeafc6) (CLS), it must use only CLS-compliant types. This applies to the types of the parameters, the return type, and the types of all its local variables. It also applies to the default values of optional parameters.  
  
 The following [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] data types are not CLS-compliant:  
  
-   [SByte Data Type (Visual Basic)](../vs140/sbyte-data-type--visual-basic-.md)  
  
-   [UInteger Data Type](../vs140/uinteger-data-type.md)  
  
-   [ULong Data Type (Visual Basic)](../vs140/ulong-data-type--visual-basic-.md)  
  
-   [UShort Data Type (Visual Basic)](../vs140/ushort-data-type--visual-basic-.md)  
  
 When you apply the \<xref:System.CLSCompliantAttribute*> attribute to a programming element, you set the attribute's `isCompliant` parameter to either `True` or `False` to indicate compliance or noncompliance. There is no default for this parameter, and you must supply a value.  
  
 If you do not apply \<xref:System.CLSCompliantAttribute*> to an element, it is considered to be noncompliant.  
  
 By default, this message is a warning. For information on hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC40042  
  
### To correct this error  
  
-   If the optional parameter must have a default value of this particular type, remove \<xref:System.CLSCompliantAttribute*>. The procedure cannot be CLS-compliant.  
  
-   If the procedure must be CLS-compliant, change the type of this default value to the closest CLS-compliant type. For example, in place of `UInteger` you might be able to use `Integer` if you do not need the value range above 2,147,483,647. If you do need the extended range, you can replace `UInteger` with `Long`.  
  
-   If you are interfacing with Automation or COM objects, keep in mind that some types have different data widths than in the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)]. For example, `int` is often 16 bits in other environments. If you are accepting a 16-bit integer from such a component, declare it as `Short` instead of `Integer` in your managed [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] code.  
  
## See Also  
 [\<PAVE OVER> Writing CLS-Compliant Code](assetId:///4c705105-69a2-4e5e-b24e-0633bc32c7f3)