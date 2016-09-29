---
title: "All field widths, except the last element, must be greater than zero"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbrTextFieldParser_FieldWidthsMustPositive"
ms.assetid: 41d8c661-a749-4c89-be56-905c6e7c3c9d
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# All field widths, except the last element, must be greater than zero
All field widths, except the last element, must be greater than zero. A field width less than or equal to zero in the last element indicates the last field is of variable length.  
  
 The operation has failed because a field width other than the last element is set to zero or less. A field width less than or equal to zero can be used as the last element to indicate that the last field is of variable length, but it cannot be used as any other element.  
  
### To correct this error  
  
-   Set the field width to the correct length.  
  
## See Also  
 [TextFieldParser.SetFieldWidths Method](assetId:///958fed9f-e0f3-4fc5-83b4-386156bdf036)   
 [TextFieldParser.FieldWidths Property](assetId:///c6985360-60c6-494e-89e7-43b6b73f2597)   
 [How to: Read From a Fixed-width Text File in Visual Basic](../vs140/how-to--read-from-fixed-width-text-files-in-visual-basic.md)   
 [TextFieldParser Object](../vs140/textfieldparser-object.md)