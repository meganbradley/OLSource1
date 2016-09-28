---
title: "Mid Statement"
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
  - "vb.MidB"
  - "vb.Mid"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "substrings, Mid statement"
  - "strings [Visual Basic], substrings"
  - "Mid statement"
  - "strings [Visual Basic], replacing"
ms.assetid: 2b82d7a8-9646-4cb0-bec5-80abc98297bf
caps.latest.revision: 24
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Mid Statement
Replaces a specified number of characters in a `String` variable with characters from another string.  
  
## Syntax  
  
```  
Mid( _  
   ByRef Target As String, _  
   ByVal Start As Integer, _  
   Optional ByVal Length As Integer _  
) = StringExpression  
```  
  
## Parts  
 `Target`  
 Required. Name of the `String` variable to modify.  
  
 `Start`  
 Required. `Integer` expression. Character position in `Target` where the replacement of text begins. `Start` uses a one-based index.  
  
 `Length`  
 Optional. `Integer` expression. Number of characters to replace. If omitted, all of `String` is used.  
  
 `StringExpression`  
 Required. `String` expression that replaces part of `Target`.  
  
## Exceptions  
  
|Exception type|Condition|  
|--------------------|---------------|  
|<xref:System.ArgumentException*>|`Start` <= 0 or `Length` < 0.|  
  
## Remarks  
 The number of characters replaced is always less than or equal to the number of characters in `Target`.  
  
 Visual Basic has a [Mid](assetId:///M:Microsoft.VisualBasic.Strings.Mid(System.String,System.Int32)?qualifyHint=False&autoUpgrade=True) function and a `Mid` statement. These elements both operate on a specified number of characters in a string, but the `Mid` function returns the characters while the `Mid` statement replaces the characters. For more information, see assetId:///M:Microsoft.VisualBasic.Strings.Mid(System.String,System.Int32)?qualifyHint=False&autoUpgrade=True.  
  
> [!NOTE]
>  The `MidB` statement of earlier versions of Visual Basic replaces a substring in bytes, rather than characters. It is used primarily for converting strings in double-byte character set (DBCS) applications. All Visual Basic strings are in Unicode, and `MidB` is no longer supported.  
  
## Example  
 This example uses the `Mid` statement to replace a specified number of characters in a string variable with characters from another string.  
  
 [!code[VbVbalrStrings#5](../vs140/codesnippet/VisualBasic/mid-statement_1.vb)]  
  
## Requirements  
 **Namespace:** [Microsoft.VisualBasic](../vs140/visual-basic-runtime-library-members.md)  
  
 **Module:** `Strings`  
  
 **Assembly:** [!INCLUDE[vbprvbruntime](../vs140/includes/vbprvbruntime_md.md)]  
  
## See Also  
 assetId:///M:Microsoft.VisualBasic.Strings.Mid(System.String,System.Int32)?qualifyHint=False&autoUpgrade=True   
 [Strings](../vs140/strings-in-visual-basic.md)   
 [Introduction to Strings in Visual Basic](../vs140/introduction-to-strings-in-visual-basic.md)