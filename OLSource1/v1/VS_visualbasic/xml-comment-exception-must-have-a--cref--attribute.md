---
title: "XML comment exception must have a &#39;cref&#39; attribute"
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
  - "bc42319"
  - "vbc42319"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC42319"
ms.assetid: 62eeeba3-6811-48be-b1ef-c2e4feda3177
caps.latest.revision: 13
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
# XML comment exception must have a &#39;cref&#39; attribute
The \<exception> tag provides a way to document the exceptions that may be thrown by a method. The required `cref` attribute designates the name of a member, which is checked by the documentation generator. If the member exists, it is translated to the canonical element name in the documentation file.  
  
 **Error ID:** BC42319  
  
### To correct this error  
  
-   Add the `cref` attribute to the exception as follows:  
  
    ```  
    '''<exception cref="member">description</exception>  
    ```  
  
## See Also  
 [\<exception>](../VS_visualbasic/-exception---visual-basic-.md)   
 [How to: Create XML Documentation](../VS_visualbasic/how-to--create-xml-documentation-in-visual-basic.md)   
 [XML Comment Tags](../VS_visualbasic/recommended-xml-tags-for-documentation-comments--visual-basic-.md)