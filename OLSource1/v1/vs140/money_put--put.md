---
title: "money_put::put"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "std::money_put::put"
  - "money_put::put"
  - "xlocmon/std::money_put::put"
  - "money_put.put"
  - "put"
  - "std.money_put.put"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "put method"
ms.assetid: 7d12b948-c3a5-48b9-b1ee-70bdb7e5f5bd
caps.latest.revision: 18
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# money_put::put
Converts either number or a string to a character sequence that represents a monetary value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An iterator addressing the first element of the inserted string.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A Boolean value indicating the type of currency symbol expected in the sequence: **true** if international, **false** if domestic.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A format flag which when set indicates that the currency symbol is optional; otherwise, it is required  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A character which is used for spacing.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A string object to be converted.  
  
## Return Value  
 An output iterator the addresses the position one beyond the last element produced.  
  
## Remarks  
 Both member functions return [do_put](../vs140/money_put--do_put.md)(<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **money_put( ) = "CAD1,000.12"**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [money_put Class](../vs140/money_put-class.md)