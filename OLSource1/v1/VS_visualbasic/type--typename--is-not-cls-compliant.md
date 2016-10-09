---
title: "Type &lt;typename&gt; is not CLS-compliant"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 7
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Type &lt;typename&gt; is not CLS-compliant
A variable, property, or function return is declared with a data type that is not CLS-compliant.  
  
 For an application to be compliant with the [Language Independence and Language-Independent Components](../Topic/Language%20Independence%20and%20Language-Independent%20Components.md) (CLS), it must use only CLS-compliant types.  
  
 The following [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] data types are not CLS-compliant:  
  
-   [SByte Data Type](../VS_visualbasic/sbyte-data-type--visual-basic-.md)  
  
-   [UInteger Data Type](../VS_visualbasic/uinteger-data-type.md)  
  
-   [ULong Data Type](../VS_visualbasic/ulong-data-type--visual-basic-.md)  
  
-   [UShort Data Type](../VS_visualbasic/ushort-data-type--visual-basic-.md)  
  
 **Error ID:** BC40041  
  
### To correct this error  
  
-   If your application needs to be CLS-compliant, change the data type of this element to the closest CLS-compliant type. For example, in place of `UInteger` you might be able to use `Integer` if you do not need the value range above 2,147,483,647. If you do need the extended range, you can replace `UInteger` with `Long`.  
  
-   If your application does not need to be CLS-compliant, you do not need to change anything. You should be aware of its noncompliance, however.  
  
## See Also  
 [\<PAVE OVER> Writing CLS-Compliant Code](assetId:///4c705105-69a2-4e5e-b24e-0633bc32c7f3)