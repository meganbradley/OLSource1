---
title: "Differences from Other Implementations"
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
ms.assetid: 944fed1c-52a0-4096-b88a-4941259ba3d0
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Differences from Other Implementations
## Microsoft Specific  
 The following list shows some differences between Microsoft C++ and other compilers.  
  
-   The compiler cannot instantiate a template outside of the module in which it is defined. Visual C++ does not support the **export** keyword.  
  
-   Templates cannot be used with functions declared with **__declspec (dllimport)** or **__declspec (dllexport)**.  
  
-   All template arguments must be of an unambiguous type that exactly matches that of the template parameter list. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     The compiler should instantiate the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> templated function in the form <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, but the inference cannot be followed.  
  
-   When resolving names used in class templates or function templates, all names are treated as dependent names.  See [Name Resolution for Dependent Types](../vs140/name-resolution-for-dependent-types.md)  
  
-   In a class template, the template parameter can be redefined in the scope of the class definition.  See [Name Resolution for Locally Declared Names](../vs140/name-resolution-for-locally-declared-names.md)  
  
## END Microsoft Specific  
  
## See Also  
 [Templates](../vs140/templates--c---.md)