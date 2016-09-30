---
title: "Property without a &#39;ReadOnly&#39; or &#39;WriteOnly&#39; specifier must provide both a &#39;Get&#39; and a &#39;Set&#39;"
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
  - "bc30124"
  - "vbc30124"
helpviewer_keywords: 
  - "BC30124"
ms.assetid: b24fc997-9a6b-44d1-b712-dab498a6fc72
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Property without a &#39;ReadOnly&#39; or &#39;WriteOnly&#39; specifier must provide both a &#39;Get&#39; and a &#39;Set&#39;
If a property is not declared as <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, it must supply procedures for reading and writing its value.  
  
 **Error ID:** BC30124  
  
### To correct this error  
  
1.  Make sure you include both a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> procedure and a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> procedure between the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement and the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement.  
  
2.  Verify that other procedures within the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> declaration are correctly terminated.  
  
## See Also  
 [Property Statement](../vs140/property-statement.md)   
 [Get Statement](../vs140/get-statement.md)   
 [Set Statement](../vs140/set-statement--visual-basic-.md)