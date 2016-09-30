---
title: "Option Strict On does not allow narrowing in implicit type conversions between method &#39;&lt;methodname&gt;&#39; and delegate &#39;&lt;delegatename&gt;&#39;"
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
  - "bc36663"
  - "vbc36663"
helpviewer_keywords: 
  - "BC36663"
ms.assetid: fefc7ab5-b587-4ff9-a6bc-4c4e5d4b6b29
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Option Strict On does not allow narrowing in implicit type conversions between method &#39;&lt;methodname&gt;&#39; and delegate &#39;&lt;delegatename&gt;&#39;
With <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> on, you cannot have a narrowing conversion between the data type of a parameter in a delegate and the corresponding parameter of a function or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> assigned to a variable of that delegate type. For example, function delegate <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> has one parameter of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and functions <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> have one parameter of different numeric types.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Because there is a widening conversion from <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, the following assignments are valid.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The conversion from <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is a narrowing conversion. Therefore, the following assignment is not valid.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Error ID: BC36663  
  
### To correct this error  
  
-   Change the data type of the parameter in the delegate or the method so that the required widening relationship exists.  
  
## See Also  
 [Relaxed Delegate Conversion](../vs140/relaxed-delegate-conversion--visual-basic-.md)   
 [Delegates in Visual Basic](../vs140/delegates--visual-basic-.md)   
 [Widening and Narrowing Conversions](../vs140/widening-and-narrowing-conversions--visual-basic-.md)   
 [NOT IN BUILD: Delegates and the AddressOf Operator](assetId:///7b2ed932-8598-4355-b2f7-5cedb23ee86f)