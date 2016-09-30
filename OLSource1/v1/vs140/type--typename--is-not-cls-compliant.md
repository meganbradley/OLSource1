---
title: "Type &lt;typename&gt; is not CLS-compliant"
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
  - "bc40041"
  - "vbc40041"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC40041"
ms.assetid: 634132c2-5646-44aa-98c6-f773e2e63882
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type &lt;typename&gt; is not CLS-compliant
A variable, property, or function return is declared with a data type that is not CLS-compliant.  
  
 For an application to be compliant with the [Common Language Specification](assetId:///4f0b77d0-4844-464f-af73-6e06bedeafc6) (CLS), it must use only CLS-compliant types.  
  
 The following [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] data types are not CLS-compliant:  
  
-   [SByte Data Type (Visual Basic)](../vs140/sbyte-data-type--visual-basic-.md)  
  
-   [UInteger Data Type](../vs140/uinteger-data-type.md)  
  
-   [ULong Data Type (Visual Basic)](../vs140/ulong-data-type--visual-basic-.md)  
  
-   [UShort Data Type (Visual Basic)](../vs140/ushort-data-type--visual-basic-.md)  
  
 **Error ID:** BC40041  
  
### To correct this error  
  
-   If your application needs to be CLS-compliant, change the data type of this element to the closest CLS-compliant type. For example, in place of <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> you might be able to use <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if you do not need the value range above 2,147,483,647. If you do need the extended range, you can replace <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
-   If your application does not need to be CLS-compliant, you do not need to change anything. You should be aware of its noncompliance, however.  
  
## See Also  
 [\<PAVE OVER> Writing CLS-Compliant Code](assetId:///4c705105-69a2-4e5e-b24e-0633bc32c7f3)