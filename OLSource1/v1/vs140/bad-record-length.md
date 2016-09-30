---
title: "Bad record length"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbrID59"
dev_langs: 
  - "VB"
ms.assetid: 0926a3a4-177b-4452-9b33-d8a01e24cc21
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Bad record length
Among the possible causes of this error are:  
  
-   The length of a record variable specified in a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement differs from the length specified in the corresponding <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement.  
  
-   The variable in a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statement is or includes a variable-length string.  
  
-   The variable in a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is or includes a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>type**.**  
  
### To correct this error  
  
1.  Make sure the sum of the sizes of fixed-length variables in the user-defined type defining the record variable's type is the same as the value stated in the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> statement's <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> clause.  
  
2.  If the variable in a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> statement is or includes a variable-length string, make sure the variable-length string is at least 2 characters shorter than the record length specified in the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> clause of the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> statement.  
  
3.  If the variable in a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is or includes a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> make sure the variable-length string is at least 4 bytes shorter than the record length specified in the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> clause of the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> statement.  
  
## See Also  
 \<xref:Microsoft.VisualBasic.FileSystem.FileGet*>   
 \<xref:Microsoft.VisualBasic.FileSystem.FileGetObject*>   
 \<xref:Microsoft.VisualBasic.FileSystem.FilePut*>   
 \<xref:Microsoft.VisualBasic.FileSystem.FilePutObject*>