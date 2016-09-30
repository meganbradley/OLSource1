---
title: "&#39;Exit Do&#39; can only appear inside a &#39;Do&#39; statement"
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
  - "bc30089"
  - "vbc30089"
helpviewer_keywords: 
  - "BC30089"
ms.assetid: 0e1d0b35-e42b-4b90-b8a2-91fd6ef44f06
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;Exit Do&#39; can only appear inside a &#39;Do&#39; statement
An <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> statement occurs outside of a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> loop. <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is valid only between a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement and a corresponding <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement.  
  
 **Error ID:** BC30089  
  
### To correct this error  
  
1.  Make sure a valid <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement precedes the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and a valid <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement appears after it.  
  
2.  Verify that other control structures within the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> loop are correctly terminated.  
  
## See Also  
 [Do...Loop Statement](../vs140/do...loop-statement--visual-basic-.md)