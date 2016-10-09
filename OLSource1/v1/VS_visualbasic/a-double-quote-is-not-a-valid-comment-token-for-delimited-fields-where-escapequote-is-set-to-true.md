---
title: "A double quote is not a valid comment token for delimited fields where EscapeQuote is set to True"
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
  - "vbrTextFieldParser_InvalidComment"
dev_langs: 
  - "VB"
ms.assetid: 636d4b81-00ba-4cfd-98f7-4d57036f494d
caps.latest.revision: 9
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# A double quote is not a valid comment token for delimited fields where EscapeQuote is set to True
A quotation mark has been supplied as the delimiter for the `TextFieldParser`, but `EscapeQuotes` is set to `True`.  
  
### To correct this error  
  
-   Set `EscapeQuotes` to `False`.  
  
## See Also  
 \<xref:Microsoft.VisualBasic.FileIO.TextFieldParser.SetDelimiters*>   
 \<xref:Microsoft.VisualBasic.FileIO.TextFieldParser.Delimiters*>   
 \<xref:Microsoft.VisualBasic.FileIO.TextFieldParser>   
 [How to: Read From Comma-Delimited Text Files](../VS_visualbasic/how-to--read-from-comma-delimited-text-files-in-visual-basic.md)