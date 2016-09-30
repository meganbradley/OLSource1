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
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Mid Statement
Replaces a specified number of characters in a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> variable with characters from another string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Required. Name of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> variable to modify.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Required. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> expression. Character position in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> where the replacement of text begins. <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> uses a one-based index.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Optional. <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> expression. Number of characters to replace. If omitted, all of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is used.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Required. <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> expression that replaces part of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
## Exceptions  
  
|Exception type|Condition|  
|--------------------|---------------|  
|\<xref:System.ArgumentException*>|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder> <= 0 or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> < 0.|  
  
## Remarks  
 The number of characters replaced is always less than or equal to the number of characters in <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 Visual Basic has a \<xref:Microsoft.VisualBasic.Strings.Mid*> function and a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> statement. These elements both operate on a specified number of characters in a string, but the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> function returns the characters while the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> statement replaces the characters. For more information, see \<xref:Microsoft.VisualBasic.Strings.Mid*>.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> statement of earlier versions of Visual Basic replaces a substring in bytes, rather than characters. It is used primarily for converting strings in double-byte character set (DBCS) applications. All Visual Basic strings are in Unicode, and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is no longer supported.  
  
## Example  
 This example uses the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> statement to replace a specified number of characters in a string variable with characters from another string.  
  
 [!code[VbVbalrStrings#5](../vs140/codesnippet/VisualBasic/mid-statement_1.vb)]  
  
## Requirements  
 **Namespace:** [Microsoft.VisualBasic](../vs140/visual-basic-runtime-library-members.md)  
  
 **Module:** <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
 **Assembly:** [!INCLUDE[vbprvbruntime](../vs140/includes/vbprvbruntime_md.md)]  
  
## See Also  
 \<xref:Microsoft.VisualBasic.Strings.Mid*>   
 [Strings](../vs140/strings-in-visual-basic.md)   
 [Introduction to Strings in Visual Basic](../vs140/introduction-to-strings-in-visual-basic.md)