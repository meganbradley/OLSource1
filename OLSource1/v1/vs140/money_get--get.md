---
title: "money_get::get"
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
  - "money_get.get"
  - "get"
  - "std::money_get::get"
  - "std.money_get.get"
  - "money_get::get"
  - "xlocmon/std::money_get::get"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get method"
ms.assetid: ac28c0c1-0cfe-411c-a458-7dcd95072089
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# money_get::get
Extracts a numerical value from a character sequence that represents a monetary value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Input iterator addressing the beginning of the sequence to be converted.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Input iterator addressing the end of the sequence to be converted.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A Boolean value indicating the type of currency symbol expected in the sequence: **true** if international, **false** if domestic.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A format flag which when set indicates that the currency symbol is optional; otherwise, it is required  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Sets the appropriate bitmask elements for the stream state according to whether the operations succeeded.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A string storing the converted sequence.  
  
## Return Value  
 An input iterator addressing the first element beyond the monetary input field.  
  
## Remarks  
 Both member functions return [do_get](../vs140/money_get--do_get.md)(<CodeContentPlaceHolder>10\</CodeContentPlaceHolder> <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
 If you run Windows 2000 or earlier, you will get this output:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 If you run Windows XP, you will get this output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [money_get Class](../vs140/money_get-class.md)