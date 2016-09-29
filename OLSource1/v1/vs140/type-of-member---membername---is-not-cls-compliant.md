---
title: "Type of member &#39;&lt;membername&gt;&#39; is not CLS-compliant"
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
  - "bc40025"
  - "vbc40025"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC40025"
ms.assetid: adbd34bb-43d2-4266-90e7-cd1afaf49b4e
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type of member &#39;&lt;membername&gt;&#39; is not CLS-compliant
The data type specified for this member is not part of the [Common Language Specification](assetId:///4f0b77d0-4844-464f-af73-6e06bedeafc6) (CLS). This is not an error within your component, because the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] and [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] support this data type. However, another component written in strictly CLS-compliant code might not support this data type. Such a component might not be able to interact successfully with your component.  
  
 The following [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] data types are not CLS-compliant:  
  
-   [SByte Data Type (Visual Basic)](../vs140/sbyte-data-type--visual-basic-.md)  
  
-   [UInteger Data Type](../vs140/uinteger-data-type.md)  
  
-   [ULong Data Type (Visual Basic)](../vs140/ulong-data-type--visual-basic-.md)  
  
-   [UShort Data Type (Visual Basic)](../vs140/ushort-data-type--visual-basic-.md)  
  
 By default, this message is a warning. For more information on hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC40025  
  
### To correct this error  
  
-   If your component interfaces only with other [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] components, or does not interface with any other components, you do not need to change anything.  
  
-   If you are interfacing with a component not written for the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)], you might be able to determine, either through reflection or from documentation, whether it supports this data type. If it does, you do not need to change anything.  
  
-   If you are interfacing with a component that does not support this data type, you must replace it with the closest CLS-compliant type. For example, in place of `UInteger` you might be able to use `Integer` if you do not need the value range above 2,147,483,647. If you do need the extended range, you can replace `UInteger` with `Long`.  
  
-   If you are interfacing with Automation or COM objects, keep in mind that some types have different data widths than in the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)]. For example, `uint` is often 16 bits in other environments. If you are passing a 16-bit argument to such a component, declare it as `UShort` instead of `UInteger` in your managed [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] code.  
  
## See Also  
 [Reflection Overview](assetId:///d1a58e7f-fb39-4d50-bf84-e3b8f9bf9775)   
 [\<PAVE OVER> Writing CLS-Compliant Code](assetId:///4c705105-69a2-4e5e-b24e-0633bc32c7f3)